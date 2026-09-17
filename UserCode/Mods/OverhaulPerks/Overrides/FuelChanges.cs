namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
	using Eco.Gameplay.Components.Storage;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Garbage;
	
	public partial class TorchStandObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Torch","Lightfuel"));
        }
    }
	public partial class WoodenWallTorchStandObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Torch","Lightfuel"));
        }
    }
	
	
	public partial class TallowCandleObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }

	public partial class CandleStandObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class CarvedPumpkinObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class CeilingCandleObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class TallowLampObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class TallowWallLampObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class TikiTorchObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	public partial class WallCandleObject
    {
        partial void ModsPostInitialize()
        {
            var fuel = this.GetComponent<FuelSupplyComponent>();

			fuel.Inventory.RemoveAllRestrictions(r => r is TagRestriction);
			fuel.Inventory.AddInvRestriction(new TagRestriction("Lightfuel"));
        }
    }
	
	
}