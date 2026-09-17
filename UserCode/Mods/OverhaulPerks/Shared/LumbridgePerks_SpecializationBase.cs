namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;
    using Eco.Shared.Serialization;

    public static class LumbridgeTalentBonusHelpers
    {
        public const float BaseResourceDiscount = 0.10f;
        public const float ExtraBonusForVariants = 0.02f;
        public const int DefaultNumberOfLevels = 5;

        public const float LaborValue = 1.05f;
        public const float LaborCap = 1.25f;

        public const float CraftTimeValue = 1.05f;
        public const float CraftTimeCap = 1.25f;

        public static void AddCostLaborTimeSpecialty(
            this Talent talent,
            string talentName,
            Type skillType,
            CraftBonusCause cause,
            bool isVariantSpecialization = false,
            float? resourceDiscount = null,
            int numberOfLevels = DefaultNumberOfLevels)
        {
            talent.AddCostLaborTimeSpecialty(
                talentName,
                null,
                skillType,
                cause,
                isVariantSpecialization,
                resourceDiscount,
                numberOfLevels);
        }

        public static void AddCostLaborTimeSpecialty(
            this Talent talent,
            string talentName,
            string description,
            Type skillType,
            CraftBonusCause cause,
            bool isVariantSpecialization = false,
            float? resourceDiscount = null,
            int numberOfLevels = DefaultNumberOfLevels)
        {
            if (numberOfLevels <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(numberOfLevels),
                    numberOfLevels,
                    "The number of levels must be greater than zero.");

            var effectiveResourceDiscount =
                resourceDiscount ?? BaseResourceDiscount;

            if (effectiveResourceDiscount < 0f)
                throw new ArgumentOutOfRangeException(
                    nameof(resourceDiscount),
                    resourceDiscount,
                    "The resource discount cannot be negative.");

            if (isVariantSpecialization)
                effectiveResourceDiscount += ExtraBonusForVariants;

            var resourceValue = 1f - effectiveResourceDiscount;
            var resourceCap =
                1f - (effectiveResourceDiscount * numberOfLevels);

            talent.AddSpecialtyBonus(
                talentName,
                BonusAction.ResourceCost,
                skillType,
                resourceValue,
                resourceCap,
                cause,
                restrictToRecipesAndTags: true,
                description: description);

            talent.AddSpecialtyBonus(
                talentName,
                BonusAction.LaborCost,
                skillType,
                LaborValue,
                LaborCap,
                cause,
                restrictToRecipesAndTags: false);

            talent.AddSpecialtyBonus(
                talentName,
                BonusAction.CraftTime,
                skillType,
                CraftTimeValue,
                CraftTimeCap,
                cause,
                restrictToRecipesAndTags: false);
        }

        private static void AddSpecialtyBonus(
            this Talent talent,
            string talentName,
            BonusAction action,
            Type skillType,
            float value,
            float cap,
            CraftBonusCause sourceCause,
            bool restrictToRecipesAndTags,
            string description = null)
        {
            var cause = new CraftBonusCause
            {
                Action = action,
                Recipes = restrictToRecipesAndTags
                    ? sourceCause.Recipes
                    : null,

                ItemTags = restrictToRecipesAndTags
                    ? sourceCause.ItemTags
                    : null,

                SkillTypes = new HashSet<Type> { skillType }
            };

            var effects = new List<BonusEffect>
            {
                new BonusEffectCappedMultiplicative
                {
                    Value = value,
                    Cap = cap,
                    LowerIsBetter = true
                }
            };

            if (description == null)
            {
                talent.Bonuses.Add(new Bonus
                {
                    Name = Localizer.DoStr(talentName),
                    Causes = new List<BonusCause> { cause },
                    Effects = effects
                });
            }
            else
            {
                talent.Bonuses.Add(new Bonus
                {
                    Name = Localizer.DoStr(talentName),
                    EffectDescription = Localizer.DoStr(
						$"{Text.Positive($"-{ToPercent(1f - value)}")} per level " +
						$"(capped at {Text.Positive($"-{ToPercent(1f - cap)}")}) " +
						$"Resource Cost for {description}."),
                    Causes = new List<BonusCause> { cause },
                    Effects = effects
                });
            }
        }

        private static string ToPercent(float value) =>
            $"{Math.Round(value * 100f)}%";
    }
}