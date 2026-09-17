namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;

    public static class LumbridgeTableSpecialistTalentHelpers
    {
        public const float CraftTimeValue = 0.5f;
        public const float ResourceCostValue = 0.8f;

        public static void AddTableSpecialistBonus(
            this Talent talent,
            string talentName,
            Type skillType,
            Type tableType)
        {
            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr(talentName),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.CraftTime,
                        CraftStationTypes = new HashSet<Type> { tableType },
                        SkillTypes = new HashSet<Type> { skillType }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative
                    {
                        Value = CraftTimeValue,
                        LowerIsBetter = true
                    }
                }
            });

            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr(talentName),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.ResourceCost,
                        CraftStationTypes = new HashSet<Type> { tableType },
                        SkillTypes = new HashSet<Type> { skillType }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectMultiplicative
                    {
                        Value = ResourceCostValue,
                        LowerIsBetter = true
                    }
                }
            });
        }
    }
}