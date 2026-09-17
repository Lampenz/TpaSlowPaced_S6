// Fish stock add PrimitiveFishOil?
// Paper plate
// -> Loaded taro fries
// -> Fish 'n Chips
// -> Boiled Rice
// -> Simmered meat?

namespace TPA_Mods
{

    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class InfusionExoticFruitSaladRecipe : SimpleRecipePatch<ExoticFruitSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FruitInfusionItem>(1);
        }
    }

    public sealed class InfusionMixedFruitSaladRecipe : SimpleRecipePatch<MixedFruitSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FruitInfusionItem>(1);
        }
    }

    public sealed class InfusionRainforestFruitSaladRecipe : SimpleRecipePatch<RainforestFruitSaladRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FruitInfusionItem>(1);
        }
    }

    public sealed class InfusionMochiRecipe : SimpleRecipePatch<MochiRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FruitInfusionItem>(1);
        }
    }

    public sealed class InfusionPokeBowlRecipe : SimpleRecipePatch<PokeBowlRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<FruitInfusionItem>(1);
        }
    }
}


