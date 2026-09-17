namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class FilterClayMold : SimpleRecipePatch<ClayMoldRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(1);
        }
    }

    public sealed class FilterWoodenMold : SimpleRecipePatch<WoodenMoldRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(1);
        }
    }

    public sealed class FilterRockerBox : SimpleRecipePatch<RockerBoxRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(5);
            //AddIngredient<ShipWaxItem>(2); moved to own file
        }
    }

    public sealed class FilterMechanicalWaterPump : SimpleRecipePatch<MechanicalWaterPumpRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(16);
        }
    }

    public sealed class FilterWasteFilter : SimpleRecipePatch<WasteFilterRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(40);
        }
    }

    public sealed class FilterYellowPowder : SimpleRecipePatch<YellowPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterWhitePowder : SimpleRecipePatch<WhitePowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterMagentaPowder : SimpleRecipePatch<MagentaPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterCyanPowder : SimpleRecipePatch<CyanPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterColoredPowder : SimpleRecipePatch<ColoredPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterCharcoalPowder : SimpleRecipePatch<CharcoalPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterBluePowder : SimpleRecipePatch<BluePowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterBlackPowder : SimpleRecipePatch<BlackPowderRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterCopperHydroxide : SimpleRecipePatch<CopperHydroxideRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterIronOxide : SimpleRecipePatch<IronOxideRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }

    public sealed class FilterPowderedCreosote : SimpleRecipePatch<PowderedCreosoteRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<RoughFabricFilterItem>(2);
        }
    }
}