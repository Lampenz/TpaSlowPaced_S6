namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class SturdyLargeCanoe : SimpleRecipePatch<LargeCanoeRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(5);
        }
    }

    public sealed class SturdySmallWoodenBoat : SimpleRecipePatch<SmallWoodenBoatRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(8);
        }
    }

    public sealed class SturdyWoodenBarge : SimpleRecipePatch<WoodenBargeRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(20);
        }
    }

    public sealed class SturdyWoodenTransportShip : SimpleRecipePatch<WoodenTransportShipRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(10);
        }
    }

    public sealed class SturdyMediumFishingTrawler : SimpleRecipePatch<MediumFishingTrawlerRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(10);
        }
    }

    public sealed class SturdySmallWoodCart : SimpleRecipePatch<SmallWoodCartRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(1);
        }
    }

    public sealed class SturdyWoodCart : SimpleRecipePatch<WoodCartRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(2);
        }
    }

    public sealed class SturdySteamTruck : SimpleRecipePatch<SteamTruckRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(8);
        }
    } 

    public sealed class SturdySteamTractor : SimpleRecipePatch<SteamTractorRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(8);
        }
    } 

    public sealed class SturdyWoodShopCart : SimpleRecipePatch<WoodShopCartRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(4);
        }
    }

    public sealed class SturdyWoodenElevator : SimpleRecipePatch<WoodenElevatorRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(4);
        }
    }

    public sealed class SturdyPoweredCart : SimpleRecipePatch<PoweredCartRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(2);
        }
    }

    public sealed class SturdyHandPlow : SimpleRecipePatch<HandPlowRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(1);
        }
    }

    public sealed class SturdyLumber : SimpleRecipePatch<LumberRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<SturdyWoodenPlankItem>(1);
        }
    }
}