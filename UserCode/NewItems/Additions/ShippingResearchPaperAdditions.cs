namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class ShippingResearchGlassworkingSkillBook : SimpleRecipePatch<GlassworkingSkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShippingResearchPaperBasicItem>(5);
        }
    }
}