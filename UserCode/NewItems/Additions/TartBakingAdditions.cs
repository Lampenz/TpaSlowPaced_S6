namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class MoldFruitMuffin : SimpleRecipePatch<FruitMuffinRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TartBakingMoldItem>(1);
        }
    }

    public sealed class MoldFruitTart : SimpleRecipePatch<FruitTartRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TartBakingMoldItem>(1);
        }
    }

    public sealed class MoldHuckleberryPie : SimpleRecipePatch<HuckleberryPieRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TartBakingMoldItem>(1);
        }
    }

    public sealed class MoldMeatPie : SimpleRecipePatch<MeatPieRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<TartBakingMoldItem>(1);
        }
    }
}