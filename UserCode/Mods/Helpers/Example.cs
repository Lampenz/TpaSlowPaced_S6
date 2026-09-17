namespace MyMod
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;
	
	/*
    /// <summary>
    /// Example showing how to use the recipe patch framework
    /// </summary>
    public sealed class SteelBarDynamicIngredientExample :
        SimpleRecipePatch<SteelBarRecipe>
    {
        protected override void Modify()
        {
			
			// Item + static
			AddIngredient<OakLogItem>(2);

			// Item + skill
			AddIngredient<OakLogItem, CarpentrySkill>(2);

			// Item + skill + talent
			AddIngredient<
				BeetItem,
				BakingSkill,
				BakingSpecialtyBakedVeggiesTalent>(5);

			// Tag + static
			AddTagIngredient("Wood", 2);

			// Tag + skill
			AddTagIngredient<CarpentrySkill>(
				"Wood",
				2);

			// Tag + skill + talent
			AddTagIngredient<
				CarpentrySkill,
				SomeCarpentryTalent>(
				"Wood",
				2);
				
			// Add output item
			AddOutput<FlourItem>(1);
			
			// Add talent output item
			AddTalentOutput<TallowItem, CampfireCookingSkill, CampfireCookingTallowYieldSpecialtyTalent>(1);
			
			//Remove ingredient item
			RemoveIngredient<ClayItem>();
			
			//Remove output item
            RemoveOutput<SteelBarItem>();
			
			// Rename recipe
			RenameRecipe(Localizer.DoStr("My New Recipe Name"));
			
        }
    }
	
	*/
	
}
