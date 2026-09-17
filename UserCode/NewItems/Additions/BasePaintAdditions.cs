namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;
	
    public sealed class BasePaintAsphalt :
        SimpleRecipePatch<AsphaltConcreteRecipe>
    {
        protected override void Modify()
        {	
            // Static quantity:
            AddIngredient<BasePaintItem>(1);
        }
    }
	
    public sealed class BasePaintRecycledAsphalt :
        SimpleRecipePatch<AsphaltFromStoneRoadRecipe>
    {
        protected override void Modify()
        {	
            // Static quantity:
            AddIngredient<BasePaintItem>(2);
        }
    }
}
