namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    // public sealed class ShippingResearchBasicUpgradeLvl2 : SimpleRecipePatch<BasicUpgradeLvl2Recipe>
    // {
    //     protected override void Modify()
    //     {
    //         AddIngredient<ShippingResearchPaperBasicItem>(1);
    //     }
    // }

    // public sealed class TailoringResearchBasicUpgradeLvl4 : SimpleRecipePatch<BasicUpgradeLvl4Recipe>
    // {
    //     protected override void Modify()
    //     {
    //         AddIngredient<TailoringResearchPaperBasicItem>(1);
    //     }
    // }

    public sealed class ShippingResearchGlassworkingSkillBook : SimpleRecipePatch<GlassworkingSkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShippingResearchPaperBasicItem>(5);
        }
    }

    public sealed class TailoringResearchPotterySkillBook : SimpleRecipePatch<PotterySkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TailoringResearchPaperBasicItem>(5);
        }
    }
}