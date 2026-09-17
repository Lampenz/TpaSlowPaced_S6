// DietCraftingGate (bulk, rule-based)
// ------------------------------------------------------------------------------------------------
// Adds an EXTRA diet skill-level requirement (IntelligenceSkill) to recipes IN BULK, by matching an
// existing required skill. Rule form: "any recipe family that already requires <SourceSkill> also
// requires <DietSkill> >= <Level>". Default rule: recipes requiring LoggingSkill also require
// IntelligenceSkill >= 2 (so Hewn Log, Lumber, Boards, etc. — everything gated on Logging — pick it up).
//
// Why this works: a recipe is gated by RecipeFamily.RequiredSkills (an array), and the engine enforces
// EVERY entry at craft/labor time (WorkOrder.CheckForMissingSkills -> req.IsMet(user) ->
// user.Skillset[SkillType].Level >= Level). We just append a requirement to the families that match.
//
// Approach: a startup plugin (IModKitPlugin/IInitializablePlugin) iterates RecipeManager.AllRecipeFamilies
// once (those are the same family instances used for crafting), and for each family whose RequiredSkills
// contains a rule's source skill, appends the diet requirement. RequiredSkills has a protected setter, so
// we set it via reflection. The extra RequiresSkillAttribute is built via DietGate.MakeRequirement, which
// briefly flips the attribute cache's CacheBuilding guard (its ctor refuses to run otherwise).
//
// Skills are resolved by NAME from Skill.AllSkills (populated well before plugins initialize), so this
// file references no mod-specific types and is fully self-contained.
//
// GOTCHA (learned the hard way): only RecipeFamily carries RequiredSkills. Recipe "tag-product" variants
// (e.g. SoftwoodHewnLogRecipe : Recipe) are crafted through their parent family's work order, so gating
// the family already covers them — and they have no RequiredSkills to set. AllRecipeFamilies only yields
// RecipeFamily instances, so we never touch the variants.

namespace Eco.Mods.DietGate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
	using Eco.Mods.TechTree;

    using Eco.Core.Plugins.Interfaces;     // IModKitPlugin, IInitializablePlugin
    using Eco.Core.Utils;                   // TimedTask

    using Eco.Gameplay.Items.Recipes;       // RecipeManager, RecipeFamily
    using Eco.Gameplay.Skills;              // RequiresSkillAttribute, Skill

    using Eco.Shared.Localization;          // Localizer
    using Eco.Shared.Logging;               // Log

    public class DietGatePlugin : IModKitPlugin, IInitializablePlugin
    {
        // ----- Configuration ------------------------------------------------------------------

        /// <summary>The diet specialty to require (resolved by class/display name).</summary>
        private const string DietSkillName = "IntelligenceSkill";

        /// <summary>Bulk rules: every recipe family that already requires SourceSkill also gets
        /// "DietSkill >= DietLevel". Add more lines to gate more skill lines.</summary>
        private const int SkillRequirementOffset = 0;

		private static IEnumerable<(string SourceSkill, int DietLevel)> Rules =>
			SkillBookIntelligenceRequirements.BySkillName
				.Select(kvp => (kvp.Key, kvp.Value + SkillRequirementOffset));

        // ----- Plugin boilerplate -------------------------------------------------------------

        public string GetCategory() => Localizer.DoStr("Skills");
        public string GetStatus()   => string.Empty;

        public void Initialize(TimedTask timer)
        {
            try { ApplyRules(); }
            catch (Exception ex) { Log.WriteErrorLineLoc($"[DietGate] Bulk apply failed: {ex}"); }
        }

        // ----- Core behavior ------------------------------------------------------------------

        private static void ApplyRules()
        {
            Type dietSkill = ResolveSkill(DietSkillName);
            if (dietSkill == null)
            {
                Log.WriteWarningLineLoc($"[DietGate] Diet skill '{DietSkillName}' not found; nothing applied.");
                return;
            }

            RecipeFamily[] families = RecipeManager.AllRecipeFamilies;
            if (families == null || families.Length == 0)
            {
                Log.WriteWarningLineLoc($"[DietGate] No recipe families loaded yet; nothing applied.");
                return;
            }

            MethodInfo setRequiredSkills = typeof(RecipeFamily)
                .GetProperty("RequiredSkills", BindingFlags.Public | BindingFlags.Instance)
                ?.GetSetMethod(nonPublic: true);
            if (setRequiredSkills == null)
            {
                Log.WriteErrorLineLoc($"[DietGate] Couldn't access RecipeFamily.RequiredSkills setter.");
                return;
            }

            foreach (var rule in Rules)
            {
                Type source = ResolveSkill(rule.SourceSkill);
                if (source == null)
                {
                    Log.WriteWarningLineLoc($"[DietGate] Source skill '{rule.SourceSkill}' not found; skipping rule.");
                    continue;
                }
                if (source == dietSkill) continue; // don't gate a skill on itself

                int changed = 0;
                foreach (RecipeFamily fam in families)
                {
                    RequiresSkillAttribute[] existing = fam?.RequiredSkills;
                    if (existing == null) continue;
                    if (!existing.Any(r => r != null && r.SkillType == source)) continue;   // doesn't require the source skill
                    if (existing.Any(r => r != null && r.SkillType == dietSkill)) continue;  // already has the diet requirement

                    RequiresSkillAttribute[] updated = DietGate.WithRequirement(existing, dietSkill, rule.DietLevel);
                    if (!ReferenceEquals(updated, existing))
                    {
                        setRequiredSkills.Invoke(fam, new object[] { updated });
                        changed++;
                    }
                }

                Log.WriteLineLoc($"[DietGate] {dietSkill.Name} >= {rule.DietLevel} added to {changed} recipe(s) requiring {source.Name}.");
            }
        }

        // ----- Helpers ------------------------------------------------------------------------

        private static readonly Dictionary<string, Type> SkillCache = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        /// <summary>Resolve a skill name (class name like "LoggingSkill" or display name) to its Type.</summary>
        private static Type ResolveSkill(string name)
        {
            if (SkillCache.TryGetValue(name, out var cached)) return cached;

            Skill[] all = Skill.AllSkills;
            Skill match =
                all?.FirstOrDefault(s => string.Equals(s.GetType().Name, name, StringComparison.OrdinalIgnoreCase)) ??
                all?.FirstOrDefault(s => string.Equals(s.GetType().Name, name + "Skill", StringComparison.OrdinalIgnoreCase)) ??
                all?.FirstOrDefault(s => string.Equals(s.DisplayName.ToString(), name, StringComparison.OrdinalIgnoreCase));

            Type type = match?.GetType();
            if (type != null) SkillCache[name] = type;
            return type;
        }
    }

    /// <summary>Runtime helper to append a skill-level requirement to a recipe's RequiredSkills array.</summary>
    public static class DietGate
    {
        private static readonly object Lock = new object();
        private static readonly Dictionary<(Type, int), RequiresSkillAttribute> ReqCache = new Dictionary<(Type, int), RequiresSkillAttribute>();

        /// <summary>Returns <paramref name="existing"/> plus a "(skillType >= level)" requirement, or the
        /// same array unchanged if it already requires that skill / construction fails.</summary>
        public static RequiresSkillAttribute[] WithRequirement(RequiresSkillAttribute[] existing, Type skillType, int level)
        {
            existing ??= Array.Empty<RequiresSkillAttribute>();
            if (skillType == null) return existing;
            if (existing.Any(r => r != null && r.SkillType == skillType)) return existing;

            RequiresSkillAttribute req = MakeRequirement(skillType, level);
            if (req == null) return existing;

            var result = new RequiresSkillAttribute[existing.Length + 1];
            Array.Copy(existing, result, existing.Length);
            result[existing.Length] = req;
            return result;
        }

        /// <summary>Construct a RequiresSkillAttribute at runtime (cached). Its ctor is guarded by
        /// Cache.CacheBuilding, so we flip that flag via reflection just for the construction.</summary>
        private static RequiresSkillAttribute MakeRequirement(Type skillType, int level)
        {
            lock (Lock)
            {
                var key = (skillType, level);
                if (ReqCache.TryGetValue(key, out var cached)) return cached;

                try
                {
                    var cache = RequiresSkillAttribute.Cache; // AttributeCache<RequiresSkillAttribute>
                    MethodInfo setBuilding = cache.GetType()
                        .GetProperty("CacheBuilding", BindingFlags.Public | BindingFlags.Instance)
                        ?.GetSetMethod(nonPublic: true);
                    if (setBuilding == null)
                    {
                        Log.WriteErrorLineLoc($"[DietGate] Couldn't access AttributeCache.CacheBuilding; cannot add {skillType.Name} requirement.");
                        return null;
                    }

                    setBuilding.Invoke(cache, new object[] { true });
                    RequiresSkillAttribute req;
                    try { req = new RequiresSkillAttribute(skillType, level); }
                    finally { setBuilding.Invoke(cache, new object[] { false }); }

                    ReqCache[key] = req;
                    return req;
                }
                catch (Exception ex)
                {
                    Log.WriteErrorLineLoc($"[DietGate] Failed to build requirement {skillType?.Name} >= {level}: {ex}");
                    return null;
                }
            }
        }
    }
}
