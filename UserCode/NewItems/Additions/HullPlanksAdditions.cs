namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;
	
    public sealed class StorageSiloHulls :
        SimpleRecipePatch<StorageSiloRecipe>
    {
        protected override void Modify()
        {	
            // Static quantity:
            AddIngredient<WoodenHullPlanksItem>(8);
        }
    }
	
    public sealed class SeedbarrelHulls :
        SimpleRecipePatch<SeedbarrelRecipe>
    {
        protected override void Modify()
        {	
            // Static quantity:
            AddIngredient<WoodenHullPlanksItem>(2);
        }
    }
	
    public sealed class WoodenWheelHulls :
        SimpleRecipePatch<WoodenWheelRecipe>
    {
        protected override void Modify()
        {	
            // Static quantity:
            AddIngredient<WoodenHullPlanksItem>(1);
        }
    }	
}
