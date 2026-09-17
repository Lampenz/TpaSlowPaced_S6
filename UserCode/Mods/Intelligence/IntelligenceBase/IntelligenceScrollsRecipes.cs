namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items.Recipes;

    public partial class AdvancedBakingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<AdvancedBakingSkillScroll>(this, new IngredientElement(typeof(BakeryOvenItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(AdvancedBakingSkill));
        }
    }

    public partial class AdvancedCookingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<AdvancedCookingSkillScroll>(this, new IngredientElement(typeof(KitchenItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(AdvancedCookingSkill));
        }
    }

    public partial class AdvancedMasonrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<AdvancedMasonrySkillScroll>(this, new IngredientElement(typeof(AdvancedMasonryTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(AdvancedMasonrySkill));
        }
    }

    public partial class AdvancedSmeltingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<AdvancedSmeltingSkillScroll>(this, new IngredientElement(typeof(BlastFurnaceItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(AdvancedSmeltingSkill));
        }
    }

    public partial class BakingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<BakingSkillScroll>(this, new IngredientElement(typeof(BakeryOvenItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(BakingSkill));
        }
    }

    public partial class BasicEngineeringSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<BasicEngineeringSkillScroll>(this, new IngredientElement(typeof(WainwrightTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(BasicEngineeringSkill));
        }
    }

    public partial class BlacksmithSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<BlacksmithSkillScroll>(this, new IngredientElement(typeof(AnvilItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(BlacksmithSkill));
        }
    }

    public partial class ButcherySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<ButcherySkillScroll>(this, new IngredientElement(typeof(ButcheryTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(ButcherySkill));
        }
    }

    public partial class CarpentrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<CarpentrySkillScroll>(this, new IngredientElement(typeof(CarpentryTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(CarpentrySkill));
        }
    }

    public partial class CompositesSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<CompositesSkillScroll>(this, new IngredientElement(typeof(AdvancedCarpentryTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(CompositesSkill));
        }
    }

    public partial class CookingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<CookingSkillScroll>(this, new IngredientElement(typeof(CastIronStoveItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(CookingSkill));
        }
    }

    // public partial class CuttingEdgeCookingSkillBookRecipe
    // {
    //     partial void ModsPreInitialize()
    //     {
    //         IntelligenceScrollsHelper.ConfigurePreInitialize<CuttingEdgeCookingSkillScroll>(this, new IngredientElement(typeof(LaboratoryItem), 1, true));
    //     }

    //     partial void ModsPostInitialize()
    //     {
    //         IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(CuttingEdgeCookingSkill));
    //     }
    // }

    public partial class ElectronicsSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<ElectronicsSkillScroll>(this, new IngredientElement(typeof(EpoxyItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(ElectronicsSkill));
        }
    }

    public partial class FarmingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<FarmingSkillScroll>(this, new IngredientElement(typeof(FarmersTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(FarmingSkill));
        }
    }

    public partial class FertilizersSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<FertilizersSkillScroll>(this, new IngredientElement(typeof(FarmersTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(FertilizersSkill));
        }
    }

    public partial class GlassworkingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<GlassworkingSkillScroll>(this, new IngredientElement(typeof(ShippingResearchPaperBasicItem), 5, true), new IngredientElement(typeof(GlassworksItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(GlassworkingSkill));
        }
    }

    public partial class IndustrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<IndustrySkillScroll>(this);
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(IndustrySkill));
        }
    }

    public partial class MasonrySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<MasonrySkillScroll>(this, new IngredientElement(typeof(MasonryTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(MasonrySkill));
        }
    }

    public partial class MechanicsSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<MechanicsSkillScroll>(this, new IngredientElement(typeof(MachinistTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(MechanicsSkill));
        }
    }

    public partial class MillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<MillingSkillScroll>(this, new IngredientElement(typeof(MillItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(MillingSkill));
        }
    }

    public partial class OilDrillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<OilDrillingSkillScroll>(this);
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(OilDrillingSkill));
        }
    }

    public partial class PaperMillingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<PaperMillingSkillScroll>(this, new IngredientElement(typeof(SmallPaperMachineItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(PaperMillingSkill));
        }
    }

    public partial class PaintingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<PaintingSkillScroll>(this, new IngredientElement(typeof(PaintMixerItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(PaintingSkill));
        }
    }

    public partial class PotterySkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<PotterySkillScroll>(this, new IngredientElement(typeof(TailoringResearchPaperBasicItem), 5, true), new IngredientElement(typeof(KilnItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(PotterySkill));
        }
    }

    public partial class ShipwrightSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<ShipwrightSkillScroll>(this, new IngredientElement(typeof(SmallShipyardItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(ShipwrightSkill));
        }
    }

    public partial class SmeltingSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<SmeltingSkillScroll>(this, new IngredientElement(typeof(BloomeryItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(SmeltingSkill));
        }
    }

    public partial class TailoringSkillBookRecipe
    {
        partial void ModsPreInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePreInitialize<TailoringSkillScroll>(this, new IngredientElement(typeof(TailoringTableItem), 1, true));
        }

        partial void ModsPostInitialize()
        {
            IntelligenceScrollsHelper.ConfigurePostInitialize(this, typeof(TailoringSkill));
        }
    }
}