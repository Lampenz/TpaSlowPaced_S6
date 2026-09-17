namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class WaxLumberBench : SimpleRecipePatch<LumberBenchRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxLumberChair : SimpleRecipePatch<LumberChairRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxLumberDoor : SimpleRecipePatch<LumberDoorRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxLumberDresser : SimpleRecipePatch<LumberDresserRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxLumberHallwayTable : SimpleRecipePatch<LumberHallwayTableRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(1);
        }
    }

    public sealed class WaxLumberTable : SimpleRecipePatch<LumberTableRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxDecorativeShipWheel : SimpleRecipePatch<DecorativeShipWheelRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(3);
        }
    }

    public sealed class WaxRockerBox : SimpleRecipePatch<RockerBoxRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(2);
        }
    }

    public sealed class WaxSmallWoodenBoat : SimpleRecipePatch<SmallWoodenBoatRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(5);
        }
    }

    public sealed class WaxWoodenBarge : SimpleRecipePatch<WoodenBargeRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(10);
        }
    }

    public sealed class WaxWoodenTransportShip : SimpleRecipePatch<WoodenTransportShipRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(14);
        }
    }

    public sealed class WaxMediumfishingTrawler : SimpleRecipePatch<MediumFishingTrawlerRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<ShipWaxItem>(16);
        }
    }



}