// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;

    public static class ResearchTalentBonuses
    {
        public static void AddSpecialistBonuses<TSkill>(
            Talent talent,
            string skillName)
            where TSkill : Skill
        {
            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr($"Specialized {skillName} Researcher"),
                EffectDescription = Localizer.Do($"Reduce resource cost for {skillName} research papers by {Text.Positive("30%")}."),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.ResourceCost,
                        ItemTags = new HashSet<string> { "Research" },
                        SkillTypes = new HashSet<Type> { typeof(TSkill) }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative { Value = 0.70f, LowerIsBetter = true }
                },
            });

            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr($"Specialized {skillName} Researcher"),
                EffectDescription = Localizer.Do($"Increased resource cost for all research papers by {Text.Negative("5%")}."),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.ResourceCost,
                        ItemTags = new HashSet<string> { "Research" },
                        CraftStationTypes = new HashSet<Type> { typeof(ResearchTableObject) }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative { Value = 1.05f, LowerIsBetter = true }
                },
            });
        }

        public static void AddUniversalistBonuses<TSkill>(
            Talent talent,
            string skillName)
            where TSkill : Skill
        {
            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr($"Jack of all Trades ({skillName})"),
                EffectDescription = Localizer.Do($"Reduce resource cost for all research papers by {Text.Positive("5%")}."),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.ResourceCost,
                        ItemTags = new HashSet<string> { "Research" }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative { Value = 0.95f, LowerIsBetter = true }
                },
            });

            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr($"Jack of all Trades ({skillName})"),
                EffectDescription = Localizer.Do($"Increase crafting time for all research papers by {Text.Negative("50%")}."),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.CraftTime,
                        ItemTags = new HashSet<string> { "Research" }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative { Value = 1.50f, LowerIsBetter = true }
                },
            });
        }
		
		
		public static void AddPragmatistBonuses<TSkill>(
			Talent talent,
			string skillName)
			where TSkill : Skill
		{
			talent.Bonuses.Add(new Bonus
			{
				Name = Localizer.DoStr($"Practically Minded ({skillName})"),
				EffectDescription = Localizer.Do(
					$"Reduce resource cost for all {skillName} recipes by {Text.Positive("10%")}."),
				Causes = new List<BonusCause>
				{
					new CraftBonusCause
					{
						Action = BonusAction.ResourceCost,
						SkillTypes = new HashSet<Type> { typeof(TSkill) }
					}
				},
				Effects = new List<BonusEffect>
				{
					new BonusEffectMultiplicative
					{
						Value = 0.90f,
						LowerIsBetter = true
					}
				},
			});

			talent.Bonuses.Add(new Bonus
			{
				Name = Localizer.DoStr($"Practically Minded ({skillName})"),
				EffectDescription = Localizer.Do(
					$"Increase resource cost for {skillName} research papers by {Text.Negative("100%")}."),
				Causes = new List<BonusCause>
				{
					new CraftBonusCause
					{
						Action = BonusAction.ResourceCost,
						ItemTags = new HashSet<string> { "Research" },
						SkillTypes = new HashSet<Type> { typeof(TSkill) }
					}
				},
				Effects = new List<BonusEffect>
				{
					new BonusEffectMultiplicative
					{
						Value = 2.00f,
						LowerIsBetter = true
					}
				},
			});
		}
		
    }
}