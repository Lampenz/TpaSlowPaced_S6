// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;
    using Eco.Shared.Serialization;
    using System.Collections.Generic;


    #region Chef Profession

    // Adv Baking Talents
    // Level 3 - Abundant - 15% Cost reduction Pirozhok
    // Level 3 - Fruit centric - 15% Cost reduction Fruit Tart
    // Level 6 - Stuff it - Wellington, bearclaw, stuffed turkey, macaroon, pirozhok Craft speed increase 30%
    // Level 6 - Top it - pizzas, tart Craft speed increase 30%
    #region AdvancedBaking

    public partial class TopItTalent : Talent
    {
        public TopItTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Top it"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(FantasticForestPizzaRecipe), typeof(HeartyHometownPizzaRecipe), typeof(SensuousSeaPizzaRecipe), typeof(TastyTropicalPizzaRecipe),typeof(FruitTartRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
        }
    }

    public partial class StuffItTalent : Talent
    {
        public StuffItTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Stuff it"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(ElkWellingtonRecipe), typeof(BearclawRecipe), typeof(StuffedTurkeyRecipe ), typeof(MacaronsRecipe), typeof(PirozhokRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
        }
    }

    public partial class FruitCentricTalent : Talent
    {
        public FruitCentricTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fruit Centric"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(FruitTartRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class AbundantTalent : Talent
    {
        public AbundantTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Stuff it"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PirozhokRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Baking Talents
    // Level 3 - Homegrown - Baked veggies 30% craft speed increase
    // Level 3 - Meat specialist - Baked meats 30% craft speed increase
    // Level 6 - Filled meals - Pies - Resource reduction 15% + 5% pastry cost increase (Huckleberrypie + meatpie)
    // Level 6 - Sweet - Pastries - Resource Reduction 15% + 5% pies cost increase (Fritter, Donut, Muffin)
    #region Baking

    public partial class HomegrownTalent : Talent
    {
        public HomegrownTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Homegrown"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, ItemTags = new HashSet<string> { "BakedVegetable" } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
        }
    }

    public partial class MeatSpecialistTalent : Talent
    {
        public MeatSpecialistTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Stuff it"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(BakedRoastRecipe), typeof(BakedMeatRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
        }
    }

    public partial class FilledMealsTalent : Talent
    {
        public FilledMealsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Filled Meals"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(HuckleberryPieRecipe), typeof(MeatPieRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Filled Meals"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(HuckleberryFritterRecipe), typeof(WorldlyDonutRecipe), typeof(FruitMuffinRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 1.05f, LowerIsBetter = true } },
            });
        }
    }

    public partial class SweetTalent : Talent
    {
        public SweetTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sweet"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(HuckleberryPieRecipe), typeof(MeatPieRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 1.05f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sweet"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(HuckleberryFritterRecipe), typeof(WorldlyDonutRecipe), typeof(FruitMuffinRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Advanced Cooking Talents
    // Level 6 - In a bowl - 20% Craft speed increase and 10% cost reduction for Pineapple friend rice + poke bowl + Sweet Salad + Crimson salad.
    // Level 6 - Take out - 20% Craft speed increase and 10% cost reduction for enchiladas + banh xeo + elk taco.
    // Level 3 - Refined scraps - Refine tallow recipe unlock.
    // Level 3 - Fully staffed - Increased craft speed 30% + 15% cost reduction.
    #region AdvancedCooking

    public partial class FullyStaffedTalent : Talent
    {
        public FullyStaffedTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fully Staffed"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, SkillTypes = new HashSet<Type> { typeof(AdvancedCookingSkill)} } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.7f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fully Staffed"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, SkillTypes = new HashSet<Type> { typeof(AdvancedCookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class RefinedScrapsTalent : Talent
    {
        public RefinedScrapsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Refined Scraps"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(RefineTallowRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    public partial class TakeOutTalent : Talent
    {
        public TakeOutTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Take Out"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(AgoutiEnchiladasRecipe), typeof(BanhXeoRecipe), typeof(ElkTacoRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Take Out"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(AgoutiEnchiladasRecipe), typeof(BanhXeoRecipe), typeof(ElkTacoRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });
        }
    }

    public partial class InaBowlTalent : Talent
    {
        public InaBowlTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("In a Bowl"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(PineappleFriendRiceRecipe), typeof(PokeBowlRecipe), typeof(SweetSaladRecipe),typeof(CrimsonSaladRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Take Out"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PineappleFriendRiceRecipe), typeof(PokeBowlRecipe), typeof(SweetSaladRecipe), typeof(CrimsonSaladRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Cooking Talents
    // Level 3 - Dual Dexterity - 50% Reduce craft time of salads. + Reduce labor for skill
    // Level 3 - Extra Pans - 50% Reduce craft time Simmered meat, stocks. + Reduce labor for skill
    // Level 6 - Something fishy - 15% Reduce cost to Shark soup & Clam chowder
    // Level 6 - Fast Food - 15% Reduce cost to Pupusas & loaded taro fries
    #region Cooking

    public partial class FastFoodTalent : Talent
    {
        public FastFoodTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fast Food"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PupusasRecipe), typeof(LoadedTaroFriesRecipe), typeof(CrispyBaconRecipe), typeof(TaroFriesRecipe), typeof(LoadedTaroFriesRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    public partial class SomethingFishyTalent : Talent
    {
        public SomethingFishyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Something Fishy"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(SharkFilletSoupRecipe), typeof(ClamChowderRecipe), typeof(VegetableSoupRecipe), typeof(AutumnStewRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    public partial class ExtraPansTalent : Talent
    {
        public ExtraPansTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Extra Pans"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(SimmeredMeatRecipe), typeof(MeatStockRecipe), typeof(VegetableStockRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Extra Pans"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.LaborCost, SkillTypes = new HashSet<Type> { typeof(CookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class DualDexterityTalent : Talent
    {
        public DualDexterityTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Extra Pans"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, ItemTags = new HashSet<string> { "Salad" } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Extra Pans"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.LaborCost, SkillTypes = new HashSet<Type> { typeof(CookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Cutting Edge Cooking Talents
    // Level 3 - - 
    // Level 3 - - 
    // Level 6 - - 
    // Level 6 - - 
    #region CuttingEdgeCooking
    #endregion

    // Campfire Cooking Talents
    // Level 3 - Using Scraps - Unlocks Render Fat Recipe
    // Level 3 - Roasted - Unlocks Campfire Roasts
    // Level 6 - Stew Gourmand - Reduces resource cost for stews by 25%
    // Level 6 - Side Dishes - Reduces resource cost for salads by 25%
    #region CampfireCooking Draft
    // Level 6
    /// <summary> Reduces resource cost for salads by 25% </summary>
    public partial class SideDishesTalent : Talent
    {
        public SideDishesTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Side Dishes"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(BeetCampfireSaladRecipe), typeof(RootCampfireSaladRecipe), typeof(JungleCampfireSaladRecipe), typeof(FernCampfireSaladRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }
    // Level 6
    /// <summary> Reduces resource cost for stews by 25% </summary>
    public partial class StewGourmandTalent : Talent
    {
        public StewGourmandTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Stew Gourmand"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(FieldCampfireStewRecipe), typeof(JungleCampfireStewRecipe), typeof(MeatyStewRecipe), typeof(RootCampfireStewRecipe), typeof(WildStewRecipe), typeof(FishStewRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }
    // Level 3
    /// <summary> Unlocks render fat recipe in the campfire. </summary>
    public partial class UsingScrapsTalent : Talent
    {
        public UsingScrapsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("UsingScraps"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(RenderFatRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }
    // Level 3
    /// <summary> Unlocks Roast recipe in the campfire. </summary>
    public partial class RoastedTalent : Talent
    {
        public RoastedTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Roasted"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(CampfireRoastRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    #endregion

    #endregion
}
