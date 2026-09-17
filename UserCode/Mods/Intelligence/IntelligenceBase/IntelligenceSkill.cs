// Eco 0.14.x — Event-only, force-learned Diet specialty (no prompt) + direct level sync.
// - One bootstrap IModInit to guarantee 0-star override is installed before learning.
// - Force-learn prerequisites (Survivalist, SelfImprovement) + Diet for everyone (init + join/login).
// - Level = clamp(floor((Carbs + Protein + Fat + Vitamins) / 10), 1..10).
// - No timers, no RPC, no Concurrent*; level is set directly on safe events.

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections;
    using System.Reflection;

    using Eco.Core.Plugins.Interfaces;              // IModInit
    using Eco.Gameplay.DynamicValues;               // AdditiveStrategy, MultiplicativeStrategy
    using Eco.Gameplay.Players;                     // User, UserManager, UserXP
    using Eco.Gameplay.Players.Food;                // Stomach, Nutrients
    using Eco.Gameplay.Skills;                      // Skill, Skillset
    using Eco.Shared.Localization;                  // Localizer
    using Eco.Shared.Serialization;                 // [Serialized]
    using Eco.Shared.Utils;                         // ThreadSafeAction AddUnique
	using Eco.Simulation.Time;
	using Eco.Shared.Time;
	using Eco.Gameplay.Disasters;
	
    using Eco.Gameplay.Systems.Messaging.Chat.Commands; // ChatCommand, ChatCommandHandler, ChatAuthorizationLevel

    // -----------------------------
    // Diet specialty
    // -----------------------------
    [Serialized]
    [LocDisplayName("Intelligence")]
    [LocDescription("Intelligence unlocks more technologically advanced crafting. Starts at 1 and automatically goes up as your diet and housing go up, leaning towards the lower of the two.\nSee the /intelligence command for a breakdown.")]
    [RequiresSkill(typeof(SurvivalistSkill), 0)]
    public partial class IntelligenceSkill : Skill
    {
        public override string Title => Localizer.DoStr("Diet");
        public override int MaxLevel => 50;
        public override int Tier     => 1;
		public override int SpecialtyCost => 0;
		
		

        // Provide 11 entries (0..10)
        public static MultiplicativeStrategy MultiplicativeStrategy = new(new float[]
        {
			1.00f, 0.99f, 0.98f, 0.97f, 0.96f,
			0.95f, 0.94f, 0.93f, 0.92f, 0.91f,
			0.90f, 0.89f, 0.88f, 0.87f, 0.86f,
			0.85f, 0.84f, 0.83f, 0.82f, 0.81f,
			0.80f, 0.79f, 0.78f, 0.77f, 0.76f,
			0.75f, 0.74f, 0.73f, 0.72f, 0.71f,
			0.70f, 0.69f, 0.68f, 0.67f, 0.66f,
			0.65f, 0.64f, 0.63f, 0.62f, 0.61f,
			0.60f, 0.59f, 0.58f, 0.57f, 0.56f,
			0.55f, 0.54f, 0.53f, 0.52f, 0.51f,
			0.50f
		});
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;

        public static AdditiveStrategy AdditiveStrategy = new(new float[]
        {
			0.0f, 200.0f, 400.0f, 600.0f, 800.0f,
			1000.0f, 1200.0f, 1400.0f, 1600.0f, 1800.0f,
			2000.0f, 2200.0f, 2400.0f, 2600.0f, 2800.0f,
			3000.0f, 3200.0f, 3400.0f, 3600.0f, 3800.0f,
			4000.0f, 4200.0f, 4400.0f, 4600.0f, 4800.0f,
			5000.0f, 5200.0f, 5400.0f, 5600.0f, 5800.0f,
			6000.0f, 6200.0f, 6400.0f, 6600.0f, 6800.0f,
			7000.0f, 7200.0f, 7400.0f, 7600.0f, 7800.0f,
			8000.0f, 8200.0f, 8400.0f, 8600.0f, 8800.0f,
			9000.0f, 9200.0f, 9400.0f, 9600.0f, 9800.0f,
			10000.0f
		});
		public override AdditiveStrategy AddStrategy => AdditiveStrategy;

        // Keep it permanently learned in practice (we re-enforce on events).
        public override bool CanBeRefunded => false;

        public override void OnLevelUp(User user) => OnLevelChanged(user);
        public override void OnReset(User user)   => OnLevelChanged(user);
        private void OnLevelChanged(User user)
        {
            user?.Stomach?.ChangedMaxCalories();
            user?.ChangedCarryWeight();
        }
    }

    // -----------------------------
    // Bootstrap (0-star + learning + event wiring)
    // -----------------------------
    public sealed class NRE_DietBootstrap : IModInit
    {
        static bool initialized;
        static Func<User, Type, int?> prevStarCalc;
		
		// Intelligence tuning
		private const float LowerValueWeight = 0.75f;
		private const float IntelligenceScaling = 10f;

		private const float IntelligencePerDayLateStart = 0.3f;
		private const float IntelligenceAtMeteorImpact = 6.0f;
		
        public static void Initialize()
        {
            if (initialized) return;
            initialized = true;



            // 2) Initial sweep: force-learn prereqs + Diet for anyone already online.
            ForceLearnForOnlineUsers();

            // 3) For all future users, force-learn on safe join events (no RPC => no prompt).
            UserManager.NewUserJoinedEvent.AddUnique(ForceLearnAll);
            UserManager.OnUserLoggedIn.AddUnique(ForceLearnAll);

            // 4) Level sync on safe, main-thread events only.
            UserXP.UserSkillRateChangedEvent?.AddUnique(SyncDietLevel);
            Stomach.GlobalFoodEatenEvent?.AddUnique((u, _, __) => SyncDietLevel(u));
            Stomach.FoodContentUpdatedEvent?.AddUnique((u, __)  => SyncDietLevel(u));
        }

        // ---------- learning ----------
        static void ForceLearnForOnlineUsers()
        {
            try
            {
                // Treat OnlineUsers as IEnumerable at runtime to avoid Concurrent* compile dep.
                var p = typeof(UserManager).GetProperty("OnlineUsers", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                var online = p?.GetValue(null) as IEnumerable;
                if (online == null) return;
                foreach (var e in online)
                    if (e is User u) ForceLearnAll(u);
            }
            catch { /* safe to ignore */ }
        }

        static void ForceLearnAll(User user)
        {
            if (user == null) return;
            var set = user.Skillset;
            if (set == null) return;

            // Ensure typical prereqs are present so specialty can be learned server-side.
            TryLearn(set, typeof(SurvivalistSkill));
            TryLearn(set, typeof(SelfImprovementSkill));

            // Now enforce Diet itself (server-side; no prompt; idempotent).
            TryLearn(set, typeof(IntelligenceSkill));
            set.GetOrAddSkill(typeof(IntelligenceSkill)); // ensure live instance
        }

        static void TryLearn(Skillset set, Type t)
        {
            try { if (!set.HasSkill(t)) set.LearnSkill(t); else set.LearnSkill(t); } catch { /* ignore */ }
        }

        // ---------- level sync (no XP; set directly) ----------
        static void SyncDietLevel(User user)
        {
            if (user == null) return;
            var set  = user.Skillset;
            var diet = set?.GetOrAddSkill(typeof(IntelligenceSkill)) as Skill;
            var stomach = user.Stomach;
            if (diet == null || stomach == null) return;

            
            // 10–19.99 -> 1, 20–29.99 -> 2, …, ≥100 -> 10
			
			var breakdown = GetIntelligenceBreakdown(user);
			float rawLevel = Math.Max(1f, Math.Min(breakdown.Total, diet.MaxLevel));

			int target = Clamp((int)Math.Floor(rawLevel), 1, diet.MaxLevel);
			float progress = rawLevel - target;

			int current = GetLevel(diet);

			if (current != target)
				TrySetLevelDirect(diet, user, target);

			// ExperienceToLevel depends on the current level.
			diet.Experience = progress * diet.ExperienceToLevel;

			User.UiStateChangedEvent?.Invoke(user);
        }

        // ---------- helpers ----------
        static int Clamp(int v, int lo, int hi) => v < lo ? lo : (v > hi ? hi : v);

        static int GetLevel(Skill s)
        {
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            try
            {
                var p = s.GetType().GetProperty("Level", flags);
                if (p != null)
                {
                    var v = p.GetValue(s);
                    if (v is int i) return i;
                    var pv = v?.GetType().GetProperty("Value", flags);
                    if (pv?.GetValue(v) is int ii) return ii;
                }
            }
            catch { }
            return 1;
        }

        static bool TrySetLevelDirect(Skill s, User user, int level)
        {
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

            // Common method names across 0.12 builds.
            foreach (var name in new[] { "SetLevelDirect", "ForceSetLevel", "LevelUpTo", "SetLevel" })
            {
                foreach (var m in s.GetType().GetMethods(flags))
                {
                    if (m.Name != name) continue;
                    var ps = m.GetParameters();
                    try
                    {
                        if (ps.Length == 1 && ps[0].ParameterType == typeof(int))
                        { m.Invoke(s, new object[] { level }); FireLevelHooks(s, user); return true; }

                        if (ps.Length == 2)
                        {
                            if (ps[0].ParameterType == typeof(User) && ps[1].ParameterType == typeof(int))
                            { m.Invoke(s, new object[] { user, level }); FireLevelHooks(s, user); return true; }

                            if (ps[0].ParameterType == typeof(int) && ps[1].ParameterType == typeof(User))
                            { m.Invoke(s, new object[] { level, user }); FireLevelHooks(s, user); return true; }
                        }
                    }
                    catch { /* try next */ }
                }
            }

            // Fallback: write Level / Level.Value if available.
            try
            {
                var p = s.GetType().GetProperty("Level", flags);
                if (p != null)
                {
                    var v = p.GetValue(s);
                    if (v is int)
                    { p.SetValue(s, level); FireLevelHooks(s, user); return true; }

                    var pv = v?.GetType().GetProperty("Value", flags);
                    if (pv?.CanWrite == true)
                    { pv.SetValue(v, level); FireLevelHooks(s, user); return true; }
                }
            }
            catch { }

            return false;
        }

        static void FireLevelHooks(Skill s, User user)
        {
            var flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            try { s.GetType().GetMethod("OnLevelUp", flags, null, new[] { typeof(User) }, null)?.Invoke(s, new object[] { user }); } catch { }
            try { s.GetType().GetMethod("OnLevelChanged", flags, null, new[] { typeof(User) }, null)?.Invoke(s, new object[] { user }); } catch { }
        }
		
		public readonly struct IntelligenceBreakdown
		{
			public readonly float BaseIntelligence, FoodXP, HousingXP, LowerXP, HigherXP, MeteorBonus, LateStartBonus, Total;

			public IntelligenceBreakdown(float foodXP, float housingXP, float lowerXP, float higherXP, float meteorBonus, float lateStartBonus)
			{
				BaseIntelligence = 1;
				FoodXP = foodXP;
				HousingXP = housingXP;
				LowerXP = lowerXP;
				HigherXP = higherXP;
				MeteorBonus = meteorBonus;
				LateStartBonus = lateStartBonus;
				Total = BaseIntelligence + lowerXP + higherXP + meteorBonus + lateStartBonus;
			}
		}
		
		public static IntelligenceBreakdown GetIntelligenceBreakdown(User user)
		{
			float housingXP = user?.ResidencyPropertyValue?.Value ?? 0f;
			float foodXP = user?.Stomach?.NutrientSkillRate() ?? 0f;

			float lowerXP = (LowerValueWeight * Math.Min(foodXP, housingXP)) / IntelligenceScaling;
			float higherXP = ((1f - LowerValueWeight) * Math.Max(foodXP, housingXP)) / IntelligenceScaling;

			float worldAge = (float)WorldTime.Seconds;
			float secondsRemaining = (float)Math.Max(DisasterPlugin.MeteorData.ImpactTime - WorldTime.Seconds, 0.0);

			float meteorBonus =
				(worldAge / (worldAge + secondsRemaining)) * IntelligenceAtMeteorImpact;

			float lateStartBonus =
				((worldAge - (float)user.OnlineTimeLog.TotalAge()) / 86400f) * IntelligencePerDayLateStart;

			return new IntelligenceBreakdown(foodXP, housingXP, lowerXP, higherXP, meteorBonus, lateStartBonus);
		}
		
    }
	
	
	/// <summary>Player chat command to read the intelligence breakdown.</summary>
    [ChatCommandHandler]
	public static class IntelligenceCommands
	{
		[ChatCommand("Shows an intelligence breakdown.", "intelligencetest", ChatAuthorizationLevel.User)]
		public static void Intelligence(User user, string playerName = null)
		{
			if (user == null) return;

			User target = user;

			if (!string.IsNullOrWhiteSpace(playerName))
			{
				target = UserManager.FindUserByName(playerName);

				if (target == null)
				{
					user.Msg(Localizer.DoStr($"Player '{playerName}' not found."));
					return;
				}
			}

			var b = NRE_DietBootstrap.GetIntelligenceBreakdown(target);

			string lowerSource;
			string higherSource;

			if (b.FoodXP == b.HousingXP)
			{
				lowerSource = "Food/Housing";
				higherSource = "Food/Housing";
			}
			else
			{
				lowerSource = b.FoodXP < b.HousingXP ? "Food" : "Housing";
				higherSource = b.FoodXP > b.HousingXP ? "Food" : "Housing";
			}

			user.Msg(Localizer.DoStr(
				$"Intelligence Breakdown ({target.Name})\n" +
				$"Base: 1\n" +
				$"Lower ({lowerSource}): {b.LowerXP:F2}\n" +
				$"Higher ({higherSource}): {b.HigherXP:F2}\n" +
				$"Meteor Approaching: {b.MeteorBonus:F2}\n" +
				$"Late Start: {b.LateStartBonus:F2}\n" +
				$"Total: {b.Total:F2}"
			));
		}
	}
	
	
}