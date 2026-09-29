namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class TailoringResearchPotterySkillBook : SimpleRecipePatch<PotterySkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TailoringResearchPaperBasicItem>(5);
        }
    }

    public sealed class TailoringResearchbakingSkillBook : SimpleRecipePatch<BakingSkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TailoringResearchPaperBasicItem>(5);
        }
    }

    public sealed class TailoringResearchCookingSkillBook : SimpleRecipePatch<CookingSkillBookRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TailoringResearchPaperBasicItem>(5);
        }
    }

}