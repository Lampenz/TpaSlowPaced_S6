namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;
	
    public sealed class WrappingMixedSaladRecipe :
        SimpleRecipePatch<MixedSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingGrasslandSaladRecipe :
        SimpleRecipePatch<GrasslandSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingForestSaladRecipe :
        SimpleRecipePatch<ForestSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingExoticSaladRecipe :
        SimpleRecipePatch<ExoticSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingLoadedTaroFriesRecipe :
        SimpleRecipePatch<LoadedTaroFriesRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingCrimsonSaladRecipe :
        SimpleRecipePatch<CrimsonSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingPineappleFriendRiceRecipe :
        SimpleRecipePatch<PineappleFriendRiceRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingMillionairesSaladRecipe :
        SimpleRecipePatch<MillionairesSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingMixedVegetableMedleyRecipe :
        SimpleRecipePatch<MixedVegetableMedleyRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingMushroomMedleyRecipe :
        SimpleRecipePatch<MushroomMedleyRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingExoticVegetableMedleyRecipe :
        SimpleRecipePatch<ExoticVegetableMedleyRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingSweetSaladRecipe :
        SimpleRecipePatch<SweetSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }

    public sealed class WrappingWildMixRecipe :
        SimpleRecipePatch<WildMixRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FoodWrappingPaperItem>(1);
        }
    }
}
