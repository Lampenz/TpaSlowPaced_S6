namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;

    public static class LumbridgeAmateurTalentHelpers
    {
        public const string DefaultPenaltyName = "Amateur Mechanic";
        public const float ResourceCostPenaltyValue = 1.20f;
		public const float ResourceCostPenaltyCap= 2.0f;
		
        public const float RecipeYieldMultiplierValue = 1.2f;
        public const float RecipeYieldMultiplierCap = 2f;

        public static void AddAmateurRecipeUnlock(
            this Talent talent,
            string unlockBonusName,
            Type recipeType,
            Type skillType)
        {
            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr(unlockBonusName),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.Unlock,
                        Recipes = new HashSet<Type> { recipeType }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectOverride
                    {
                        Value = 1f
                    }
                }
            });

            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr(DefaultPenaltyName),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.ResourceCost,
                        SkillTypes = new HashSet<Type> { skillType }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectCappedMultiplicative
                    {
                        Value = ResourceCostPenaltyValue,
						Cap = ResourceCostPenaltyCap,
                        LowerIsBetter = true
                    }
                }
            });

            talent.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr(unlockBonusName),
                EffectDescription = Localizer.DoStr($"Increases yield for this recipe by {Text.Positive("20%")} per level."),
                Causes = new List<BonusCause>
                {
                    new CraftBonusCause
                    {
                        Action = BonusAction.Yield,
                        Recipes = new HashSet<Type> { recipeType },
                        SkillTypes = new HashSet<Type> { skillType }
                    }
                },
                Effects = new List<BonusEffect>
                {
                    new BonusEffectCappedMultiplicative
                    {
                        Value = RecipeYieldMultiplierValue,
                        Cap = RecipeYieldMultiplierCap,
                        LowerIsBetter = false
                    }
                }
            });
        }
    }
}