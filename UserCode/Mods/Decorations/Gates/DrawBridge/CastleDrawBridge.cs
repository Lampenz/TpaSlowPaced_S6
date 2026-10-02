using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Wires;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using EcoPulse.Gates;
using System;
using System.Collections.Generic;

namespace Eco.Mods.TechTree
{
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [MustBeGridAligned]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Castle Draw Bridge Item")]
    public partial class CastleDrawBridgeObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(CastleDrawBridgeItem);

        public override LocString DisplayName => Localizer.DoStr("Castle Draw Bridge");

        public override TableTextureMode TableTexture => TableTextureMode.Stone;

        public override bool HasTier => true;

        public override int Tier => 3;

        static CastleDrawBridgeObject()
        {
            AddOccupancy<CastleDrawBridgeObject>(GateOccupancy.CastleDrawBridge);
        }

        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();
            this.ModsPostInitialize();
        }

        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Castle Draw Bridge")]
    [LocDescription("A fortified castle drawbridge with stone pillars, an arched entrance with double doors, and iron chains. A formidable gateway for any settlement.")]
    [IconGroup("World Object Minimap")]
    [Tier(3)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(10000)]
    public partial class CastleDrawBridgeItem : WorldObjectItem<CastleDrawBridgeObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

}
