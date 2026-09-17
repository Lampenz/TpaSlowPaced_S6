namespace MyMod
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	
	
	
    /// <summary>
    /// Example showing how to use the recipe patch framework
    /// </summary>
    public sealed class SteelBarDynamicIngredientExample2 :
        SimpleRecipePatch<DowelRecipe>
    {
        protected override void Modify()
        {
			

				
			// Add output item
			AddOutput<HewnLogItem>(1);
		
			
        }
    }
	
	
	
}
