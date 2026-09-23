namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;
    
    public sealed class AdvGathPaperMillingSkillBookRecipe :
        SimpleRecipePatch<PaperMillingSkillBookRecipe>
    {
        protected override void Modify()
        {
            RemoveIngredient<GatheringResearchPaperAdvancedItem>();
        }
    }

    public sealed class AdvGathPaperbakingSkillBookRecipe :
        SimpleRecipePatch<BakingSkillBookRecipe>
    {
        protected override void Modify()
        {
            RemoveIngredient<GatheringResearchPaperAdvancedItem>();
        }
    }

    public sealed class AdvGathPaperCookingSkillBookRecipe :
        SimpleRecipePatch<CookingSkillBookRecipe>
    {
        protected override void Modify()
        {
            RemoveIngredient<GatheringResearchPaperAdvancedItem>();
        }
    }
}