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
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;


    #region Farmer Profession

    // Farming Talents
    // Level 3 - Seed sorting - Increased seed craft speed
    // Level 3 - Nutrient deficient - Nutrient consumption of plants (habitability agnostic? change harvesting properties like yield increase)
    // Level 6 - Gentle seeding - When planting/Seeding +20% maturity
    // Level 6 - Natural Selection - Extend wilt period by 30% (replaced by Labor reduction on seed crafting temporary)
    #region Farming

    public partial class SeedSortingTalent : Talent
    {
        public SeedSortingTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Seed Sorting"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
        }
    }

    public partial class NutrientDeficientTalent : Talent
    {
        public NutrientDeficientTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Nutrient Deficient"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });
        }
    }
    public partial class GentleSeedingTalent : Talent
    {
        public GentleSeedingTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Gentle Seeding"),
                EffectDescription = Localizer.Do($"Planted crops start with {Text.Positive("20%")} more maturity."),
                Causes = new List<BonusCause> { new ActionCause { Action = BonusAction.PlantMaturity } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 0.2f } },
            });
        }
    }

    public partial class NaturalSelectionTalent : Talent
    {
        public NaturalSelectionTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Natural Selection"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.LaborCost, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Fertilizers Talents
    // Level 3 - OrganicAbundance - Specific recipe reduction
    // Level 3 - RefinedProcess - Specific recipe reduction
    // Level 6 - EnrichedSoil - Increase nutrient value of applied fertilizer by 100%
    // Level 6 - SustainablePractice - yield +1
    #region Fertilizers
    public partial class OrganicAbundanceTalent : Talent
    {
        public OrganicAbundanceTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Organic Abundance"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(CompostFertilizerRecipe), typeof(BerryExtractFertilizerRecipe), typeof(CamasAshFertilizerRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class RefinedProcessingTalent : Talent
    {
        public RefinedProcessingTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Refined Processing"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(BloodMealFertilizerRecipe), typeof(PhosphateFertilizerRecipe), typeof(PeltFertilizerRecipe), typeof(HideAshFertilizerRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class EnrichedSoilTalent : Talent
    {
        public EnrichedSoilTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Enriched Soil"),
                EffectDescription = Localizer.Do($"Applied fertilizer grants {Text.Positive("200%")} more nutrients."),
                Causes = new List<BonusCause> { new ActionCause { Action = BonusAction.FertilizerNutrient } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 3f, LowerIsBetter = false } },
            });
        }
    }

    public partial class SustainablePracticeTalent : Talent
    {
        public SustainablePracticeTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sustainable Practice"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, SkillTypes = new HashSet<Type> { typeof(FertilizersSkill) },
                    Recipes = new HashSet<Type> { 
                    typeof(BerryExtractFertilizerRecipe),
                    typeof(BloodMealFertilizerRecipe),
                    typeof(CamasAshFertilizerRecipe),
                    typeof(CompostFertilizerRecipe),
                    typeof(HideAshFertilizerRecipe),
                    typeof(PeltFertilizerRecipe),
                    typeof(PhosphateFertilizerRecipe),
                    } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }

    #endregion

    // Milling Talents
    // Level 3 - Flour it - 18% Craft speed increase on Wheat, Corn flour + 5% reduction (max 80% / 25%)
    // Level 3 - Sugar Rush - 18% Craft speed increase on Sugar + 5% reduction (max 80% / 25%)
    // Level 6 - Another Beat - Beet Sugar + processed beet sugar (adv mill) Recipe Unlock ##
    // Level 6 - Omega 3 - Fish oil Recipe unlock
    #region Milling

    public partial class FlourItTalent : Talent
    {
        public FlourItTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Flour It!"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(FlourRecipe), typeof(RiceFlourRecipe), typeof(CornmealRecipe), } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.95f, Cap = 0.75f, LowerIsBetter = true} },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Flour It!"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(FlourRecipe), typeof(RiceFlourRecipe), typeof(CornmealRecipe), } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.82f, Cap = 0.2f, LowerIsBetter = true } },
            });
        }
    }

    public partial class SugarRushTalent : Talent
    {
        public SugarRushTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sugar Rush"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(SugarRecipe), typeof(ProcessedSugarRecipe), typeof(BeetSugarRecipe), typeof(ProcessedBeetSugarRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.95f, Cap = 0.75f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(SugarRecipe), typeof(ProcessedSugarRecipe), typeof(BeetSugarRecipe), typeof(ProcessedBeetSugarRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.82f, Cap = 0.2f, LowerIsBetter = true } },
            });
        }
    }

    public partial class AnotherBeatTalent : Talent
    {
        public AnotherBeatTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Another Beat"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(BeetSugarRecipe), typeof(ProcessedBeetSugarRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    public partial class Omega3Talent : Talent
    {
        public Omega3Talent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Omega 3"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(FishOilRecipe), typeof(ProcessedFishOilRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    #endregion

    // Gathering Talents
    // Level 3 - Fruiturist - Increases yields of fruits when harvested by +1.
    // Level 3 - Grainiac - Increases yields of grains when harvested by +1.
    // Level 6 - Keeping it fresh - Increases freshness of all harvested crops by 50%.
    // Level 6 - Natural Gatherer - Increases all gathering yield by +1.
    #region Gathering

    // Level 3
    /// <summary> Increases yields of Fruits when harvested by +1. </summary>
    public partial class FruituristTalent : Talent
    {
        public FruituristTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fruiturist"),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestYield, ItemTags = new HashSet<string> { "Fruit" } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }
    // Level 3
    /// <summary> Increases yields of grains when harvested by +1. (Rice, Corn, Wheat) </summary>
    public partial class GrainiacTalent : Talent
    {
        public GrainiacTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Grainiac"),
                EffectDescription = Localizer.Do($"Increases yields of grains by {Text.StyledNum(1f)}."),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestYield, ItemTags = new HashSet<string> { "Grain" } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }
    // Level 6
    /// <summary> Increases all gathering yield by +1. </summary>
    public partial class NaturalGathererTalent : Talent
    {
        public NaturalGathererTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Natural Gatherer"),
                EffectDescription = Localizer.Do($"Increases all gathering yield by {Text.StyledNum(1f)}."),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestYield, ItemTags = new HashSet<string> { "Crop" } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1 } },
            });
        }
    }
    // Level 6
    /// <summary> Increases freshness of all harvested crops by 50%. </summary>
    public partial class KeepingItFreshTalent : Talent
    {
        public KeepingItFreshTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Keeping it fresh!"),
                EffectDescription = Localizer.Do($"Increases freshness of all harvested crops by {Text.Positive("50%")}."),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestFreshness } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 1.5f, LowerIsBetter = false } },
            });
        }
    }

    #endregion

    #endregion
}
