// Semi Truck - an articulated tractor and trailer for Eco, with swappable container bodies.
//
// STRUCTURE, and why it is this shape
//
// The vehicle is the tractor AND the trailer bogie together, as one object. The bogie
// cannot be a separate attachable thing: Eco instantiates attachments as visual prefabs
// parented to the chassis and never wires them into RCC's wheel arrays, so an attachment
// that brought its own working wheels is not possible. Physics stays on the vehicle.
//
// Built on Eco's own TrailerTruckObject prefab. Vanilla never made it craftable - it is
// [Category("Hidden")] with no recipe anywhere in __core__ - so this mod is turning on a
// vehicle Eco built and never shipped, rather than competing with one.
//
// THREE-PART CONTAINER DESIGN, and why it cannot be two
//
// A container has to be two different things at once: a box you place in the world and
// fill up, and cargo the truck carries. Those are different base classes in Eco -
// WorldObjectItem<T> places world objects, VehicleToolItem slots into a vehicle - and no
// item can be both. Eco hit this exact wall with the Truck Dumpster Loader and split it
// in three. So do we:
//
//   SemiContainerObject / ...Item   the box. An ordinary placeable storage world object.
//   SemiContainerLoaderItem         the module. Fitted to the truck's one body slot; the
//                                   twist locks and hydraulics that let it carry a box.
//   SemiContainerCarrierComponent   the mechanism the module installs on the truck.
//
// The container is never a module. It is cargo, riding in the loader's one carry slot,
// exactly as a dumpster rides in TruckDumpsterLoaderItem's.
//
// WHERE THE CARGO LIVES
//
// Vanilla stashes a lifted dumpster's contents in a private list on the carrier, sealed
// until setdown. We do better: the loader installs the 40-slot hold on the TRUCK, and a
// load moves the container's contents into it. So a container keeps its cargo when it is
// standing in your yard, AND the driver can still open the hold and work it on the road -
// which is how this mod already behaved before containers became placeable.
//
// CRITICAL: class name SemiTruckObject must match SemiTruckObject.prefab exactly. Eco
// resolves an object's model from its class name. Same for SemiContainerObject, and for
// the module: SemiContainerLoaderItem.prefab's root GameObject must carry that exact name,
// because ModularVehicle looks bodies up by the item's ServerName.

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Controller;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Components.Storage;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Interactions.Interactors;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Placement;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Gameplay.Utils;          // ResultExtensions.NotifyIfFailed
    using Eco.Shared.IoC;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    // InteractionTrigger / InteractionTriggerInfo / InteractionTarget live here, NOT in
    // Eco.Gameplay.Interactions - that namespace holds the attribute and the interactors.
    using Eco.Shared.SharedTypes;
    using Eco.Shared.States;
    using Eco.Shared.Time;
    using Eco.World;
    using static Eco.Gameplay.Components.PartsComponent;

    // Eco.Shared.Math owns Vector3i and no Vector3, so the two never collide - but the
    // component offsets below are System.Numerics, matching Eco's own module components,
    // and spelling that out beats leaving a reader to work out which Vector3 this is.
    using Vector3 = System.Numerics.Vector3;

    /// <summary>The placed semi. Model comes from SemiTruckObject.prefab.</summary>
    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))]
    [RequireComponent(typeof(PaintableComponent))]
    [RequireComponent(typeof(FuelSupplyComponent))]
    [RequireComponent(typeof(FuelConsumptionComponent))]
    [RequireComponent(typeof(MovableLinkComponent))]
    [RequireComponent(typeof(AirPollutionComponent))]
    [RequireComponent(typeof(VehicleComponent))]
    [RequireComponent(typeof(CustomTextComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(PartsComponent))]
    // The point of the whole mod. Attachment slots are declared in Initialize below.
    [RequireComponent(typeof(ModularVehicleComponent))]
    // Deliberately NO PublicStorageComponent and NO StockpileComponent. The vehicle hauls
    // nothing by itself; the loader module brings the hold and the container brings the box.
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Semi Truck Item")]
    public partial class SemiTruckObject : PhysicsWorldObject, IRepresentsItem
    {
        // Empty occupancy: a vehicle drives, so it reserves no world blocks.
        static SemiTruckObject() => WorldObject.AddOccupancy<SemiTruckObject>(new List<BlockOccupancy>(0));

        public override TableTextureMode TableTexture => TableTextureMode.Metal;
        public override bool PlacesBlocks             => false;
        public override LocString DisplayName         => Localizer.DoStr("Semi Truck");
        public Type RepresentedItemType               => typeof(SemiTruckItem);

        private SemiTruckObject() { }

        private static readonly string[] FuelTags = new string[] { "Liquid Fuel" };  //noloc

        /// <summary>
        /// What this truck will accept in its one attachment slot. Ours only, so vanilla's
        /// own lists are never touched - ModularVehicleComponent.Initialize is public and
        /// each vehicle passes its own whitelist.
        ///
        /// The container is deliberately NOT here. It is cargo, not a module.
        /// </summary>
        private static readonly Type[] AttachmentTypeList = new Type[]
        {
            typeof(SemiContainerLoaderItem),
        };

        /// <summary>
        /// Segments are a separate multi-axle mechanism. Every shipped vehicle passes an
        /// empty list and nothing in the game exercises that path, so this does too.
        /// </summary>
        private static readonly Type[] SegmentTypeList = Array.Empty<Type>();

        protected override void Initialize()
        {
            base.Initialize();

            this.GetComponent<CustomTextComponent>().Initialize(200);
            this.GetComponent<FuelSupplyComponent>().Initialize(2, FuelTags);
            this.GetComponent<FuelConsumptionComponent>().Initialize(250);
            this.GetComponent<AirPollutionComponent>().Initialize(0.5f);

            // (segmentSlots, attachmentSlots, segmentTypes, attachTypes). One body at a time.
            var modular = this.GetComponent<ModularVehicleComponent>();
            modular.Initialize(0, 1, SegmentTypeList, AttachmentTypeList);

            // The trailer-mounted container visual is NOT driven from here any more. It
            // follows whether a container is actually aboard, which only the carrier knows,
            // so SemiContainerCarrierComponent owns that state. With no loader fitted there
            // is no carrier and no container, so clear it here to cover a truck that had its
            // module pulled off - the client would otherwise keep the last state it was sent.
            if (modular.VehicleToolItem is not SemiContainerLoaderItem)
                this.SetAnimatedState(SemiContainerCarrierComponent.ContainerVisualState, false);

            this.GetComponent<MinimapComponent>().InitAsMovable();
            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Vehicles"));

            // (maxSpeed, efficiency, seats). maxSpeed deliberately sits between the two
            // vanilla trucks this one sits between in the tech tree: faster than the Steam
            // Truck (18) and slower than the modern Truck (20). Efficiency (3) still matches
            // vanilla TrailerTruckObject, which this vehicle is otherwise built on.
            this.GetComponent<VehicleComponent>().Initialize(19, 3, 2);

            this.GetComponent<PartsComponent>().Config(() => LocString.Empty, new PartInfo[]
            {
                new() { TypeName = nameof(AdvancedCombustionEngineItem), Quantity = 1 },
                new() { TypeName = nameof(ElectricMotorItem),        Quantity = 1 },
                new() { TypeName = nameof(RubberWheelItem),          Quantity = 6 },
                new() { TypeName = nameof(LightBulbItem),            Quantity = 4 },
                new() { TypeName = nameof(LubricantItem),            Quantity = 2 },
                new() { TypeName = nameof(FuseItem),                 Quantity = 2 },
                new() { TypeName = nameof(InsulatedCopperWiringItem), Quantity = 2 },
                new() { TypeName = nameof(RadiatorItem),             Quantity = 1 },
            });
        }
    }

    /// <summary>The carried item. IPersistentData carries parts and fuel across pickup.</summary>
    [Serialized]
    [LocDisplayName("Semi Truck")]
    [LocDescription("An articulated truck that hauls swappable container trailers.")]
    [IconGroup("World Object Minimap")]
    [Weight(40000)]
    // Vanilla TruckItem's salvage line at 2x, matching how the recipe scales. Without a
    // SalvageCost an item scraps into nothing, which no shipped vehicle does.
    [SalvageCost(typeof(IronScrap), 16.0f, typeof(Textiles), 2.4f, typeof(CopperScrap), 8.0f, typeof(ChemicalWaste), 4.0f)]
    [AirPollution(0.5f)]
    [Ecopedia("Crafted Objects", "Vehicles", createAsSubPage: true)]
    public partial class SemiTruckItem : WorldObjectItem<SemiTruckObject>, IPersistentData
    {
        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)]
        public object PersistentData { get; set; }
    }

    // ---------------------------------------------------------------------------------
    // THE CONTAINER, as a thing that stands in the world
    // ---------------------------------------------------------------------------------

    /// <summary>
    /// The shipping container as a placed world object: a plain storage box you can put
    /// down, fill, and later have a semi pick up with its cargo still inside.
    ///
    /// Its footprint is measured off the container's own colliders in the shipped bundle
    /// (2.14 x 2.02 x 5.10 m), which rounds to 2 wide, 2 high, 5 long. The prefab is built
    /// with its pivot at the base, centred across the width and the length, so the blocks
    /// below straddle it evenly. Occupancy lives in TWO systems - this list and the
    /// prefab's own volume - and a mismatch shows up only in the CLIENT log.
    /// </summary>
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(PublicStorageComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    // Refuses to be pocketed while it still holds cargo. See the component for why this,
    // rather than weight, is the gate.
    [RequireComponent(typeof(SemiContainerSealComponent))]
    [Tag("Usable")]
    // Marks it as something a semi's loader may lift. The matching tag on the ITEM is what
    // the carry slot filters on; this one is what the lift search finds.
    [Tag(SemiContainerCarrierComponent.LiftableTag)]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Semi Container Item")]
    public partial class SemiContainerObject : WorldObject, IRepresentsItem
    {
        static SemiContainerObject() => WorldObject.AddOccupancy<SemiContainerObject>(BuildOccupancy());

        /// <summary>2 wide x 2 high x 5 long, centred on the origin block in x and z.</summary>
        static List<BlockOccupancy> BuildOccupancy()
        {
            var blocks = new List<BlockOccupancy>(20);
            for (var x = -1; x <= 0; x++)
                for (var y = 0; y <= 1; y++)
                    for (var z = -2; z <= 2; z++)
                        blocks.Add(new BlockOccupancy(new Vector3i(x, y, z)));
            return blocks;
        }

        public override TableTextureMode TableTexture => TableTextureMode.Metal;
        public override LocString DisplayName         => Localizer.DoStr("Semi Container");
        public Type RepresentedItemType               => typeof(SemiContainerItem);

        protected override void Initialize()
        {
            base.Initialize();

            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Storage"));

            // Matches the hold the loader module installs on the truck, so a full container
            // always fits its cargo back and forth without a partial transfer.
            //
            // Deliberately NO StockpileComponent. The inherited "Contents" anchor was sized
            // for vanilla's open-top trailer, not this sealed box, so a full load visibly
            // clipped through the walls. A shipping container is opaque, so this is now
            // opaque storage like any other - full inside, nothing visible from outside.
            this.GetComponent<PublicStorageComponent>().Initialize(
                SemiContainerLoaderItem.CargoSlots, SemiContainerLoaderItem.CargoMaxWeight);
        }
    }

    /// <summary>
    /// Blocks pickup while the container still holds cargo, which is the behaviour asked
    /// for: a loaded container may only be moved by a truck.
    ///
    /// This is the gate rather than sheer weight, because weight does not actually stop a
    /// pickup - Eco's generic pickup pushes a storage object's contents into whatever
    /// inventory it is picking up into, so a heavy full box just becomes a heavy full
    /// backpack. IPickupConfirmationComponent.CanPickup is the real veto, checked by
    /// WorldObjectUtil.CheckForPickUpAsync before anything moves.
    ///
    /// The truck's loader is unaffected: it empties the container into the truck's hold
    /// first, so by the time it lifts, this returns success.
    /// </summary>
    [Serialized, NoIcon]
    public class SemiContainerSealComponent : WorldObjectComponent, IPickupConfirmationComponent
    {
        public Result CanPickup() =>
            this.Parent.GetComponent<PublicStorageComponent>()?.Inventory.IsEmpty != false
                ? Result.Succeeded
                : Result.FailLoc($"{this.Parent.MarkedUpName} still has cargo in it. Empty it, or have a semi with a container loader pick it up.");
    }

    /// <summary>
    /// The container item. Placing it puts the box down; a semi's loader turns it back
    /// into this item when it lifts it aboard.
    ///
    /// Weight is what a real empty container weighs relative to Eco's scale rather than a
    /// gate on anything - the seal component above is what actually stops a loaded pickup.
    /// </summary>
    [Serialized]
    [LocDisplayName("Semi Container")]
    [LocDescription("A shipping container. Stands wherever you put it and holds cargo; a semi with a container loader can lift it, load and all.")]
    [IconGroup("World Object Minimap")]
    [Weight(12000)]
    [SalvageCost(typeof(IronScrap), 6.0f, typeof(ChemicalWaste), 0.2f)]
    // The carry-slot filter. Both this and the object carry the tag, mirroring how vanilla
    // declares a liftable - two attributes and nothing else.
    [Tag(SemiContainerCarrierComponent.LiftableTag)]
    [Ecopedia("Crafted Objects", "Vehicles", createAsSubPage: true)]
    public partial class SemiContainerItem : WorldObjectItem<SemiContainerObject>, IPersistentData
    {
        // Sits on the ground on its own base, like a dumpster.
        protected override OccupancyContext GetOccupancyContext =>
            new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));

        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)]
        public object PersistentData { get; set; }
    }

    // ---------------------------------------------------------------------------------
    // THE LOADER MODULE
    // ---------------------------------------------------------------------------------

    /// <summary>
    /// The body that goes in the truck's module slot: twist locks, a hold, and the gear to
    /// pick a container up. Modelled directly on TruckDumpsterLoaderItem.
    ///
    /// Component order matters. The hold and the carry slot must install before the
    /// carrier, because the carrier resolves both by name in its Initialize; and the
    /// stockpile that renders the load must follow the storage it binds.
    ///
    /// The prefab for this item MUST have its root GameObject named SemiContainerLoaderItem.
    /// ModularVehicle keys its lookup on the item's ServerName, so a mismatch means the
    /// module silently never registers while every server-side mechanic still works.
    /// </summary>
    [Serialized]
    [LocDisplayName("Semi Container Loader")]
    [LocDescription("Twist locks and lift gear for a semi. Fitted to the truck, it picks up and sets down shipping containers without unpacking them.")]
    [Weight(8000)]
    [SalvageCost(typeof(IronScrap), 6.0f, typeof(CopperScrap), 0.5f, typeof(ChemicalWaste), 0.2f)]
    [Category("Tool")]
    [Tag("Tool")]
    [RepairRequiresSkill(typeof(IndustrySkill), 0)]
    [Ecopedia("Items", "Tools", createAsSubPage: true)]
    public partial class SemiContainerLoaderItem : VehicleToolItem
    {
        /// <summary>Hold size. Shared with the container so a full box always transfers whole.</summary>
        public const int CargoSlots     = 40;
        public const int CargoMaxWeight = 10_000_000;

        /// <summary>Name of the one-slot inventory the lifted container itself sits in.</summary>
        public const string CarrySlotName = "SemiContainerCarry";  //noloc

        public override bool ShownOnToolbar => false;   // Bulk cargo; keep the driving HUD clean.

        // Opts this module into the vehicle tool control, which is what puts the load /
        // unload key on the driver's control hints and lets a press reach the server.
        public override bool      UsesToolControl  => true;
        public override LocString ToolControlLabel => Localizer.DoStr("Load / Unload Container");

        public override IEnumerable<ComponentInstallation> ComponentsToInstall => new[]
        {
            // The hold. This is the cargo the player actually works with, and it stays
            // reachable while driving - the container's contents are moved in here on a
            // load and back out on a setdown.
            ComponentInstallation.For<PublicStorageComponent>(
                name:         nameof(SemiContainerLoaderItem),
                configure:    c =>
                {
                    c.Initialize(CargoSlots, CargoMaxWeight);
                    // Nothing goes in the hold unless there is a container to hold it.
                    // Resolved at check time because the carrier installs after this.
                    c.Storage.AddInvRestriction(new SemiCargoHoldRestriction(
                        () => c.Parent?.GetComponent<SemiContainerCarrierComponent>(nameof(SemiContainerLoaderItem))?.AcceptsCargo ?? false));
                },
                canUninstall: c => c.Inventory.IsEmpty),
            // Reports ground-polluting cargo. Named so it binds this module's hold, and
            // must follow the storage entry it binds.
            ComponentInstallation.For<GroundPolluterReportComponent>(
                name:         nameof(SemiContainerLoaderItem)),

            // The carry slot: one container, and only the lift controls may touch it.
            ComponentInstallation.For<PublicStorageComponent>(
                name:         CarrySlotName,
                configure:    c =>
                {
                    c.Initialize(1);
                    c.Storage.AddInvRestriction(new TagRestriction(SemiContainerCarrierComponent.LiftableTag));
                    c.Storage.AddInvRestriction(new StackLimitRestriction(1));
                    // Hands off entirely - vanilla's own restriction, reused. A hand take
                    // would strand the container's load in the truck's hold; a hand put
                    // would skip the lift and its checks.
                    c.Storage.AddInvRestriction(new LoaderCarrySlotRestriction(
                        () => c.Parent?.GetComponent<SemiContainerCarrierComponent>(nameof(SemiContainerLoaderItem))?.TransferInProgress ?? false));
                },
                canUninstall:      c => c.Inventory.IsEmpty,   //Can't pull the module off with a container aboard.
                proxyInteractions: false),                     //Loaded by the lift controls, not by hand.

            ComponentInstallation.For<SemiContainerCarrierComponent>(
                name:      nameof(SemiContainerLoaderItem),
                configure: c =>
                {
                    // Vehicle-local. Measured off the shipped bundle: the rig's solid
                    // colliders run z -0.49 .. +6.62 with the cab forward, so the whole
                    // truck lies AHEAD of its own origin and anything behind it is at
                    // negative z. x is +0.50 because the rig's origin sits half a metre
                    // off its centreline.
                    //
                    // One point serves both, so a container you just set down is standing
                    // exactly where the next lift will look for it.
                    c.PickupOffset  = new Vector3(0.5f, 0f, -3.2f);
                    c.SetdownOffset = new Vector3(0.5f, 0f, -3.2f);
                }),
        };
    }

    /// <summary>
    /// Refuses cargo into the truck's hold unless a container is actually aboard. Without
    /// it the hold is a second, invisible truck bed that survives having no container, and
    /// the first setdown would tip its contents into a box the player never loaded.
    /// </summary>
    public class SemiCargoHoldRestriction : InventoryRestriction
    {
        readonly Func<bool> isCarrying;

        public SemiCargoHoldRestriction(Func<bool> isCarrying) => this.isCarrying = isCarrying;

        public override LocString Message  => Localizer.DoStr("Load a container onto the truck before putting cargo in it.");
        public override int       Priority => base.Priority + 1;
        public override RestrictionDescriptor Describe() => null; //About there being no container, not about what fits.

        public override int MaxAccepted(Item item) => this.isCarrying() ? -1 : 0;
        // Taking is always allowed: a load that somehow ended up here must never be trapped.
    }

    /// <summary>
    /// Installed on the semi by its loader module. Lifts a whole container - cargo and all
    /// - onto the trailer, and sets it back down elsewhere.
    ///
    /// The lift and the setdown are Eco's own <see cref="WorldObjectUtil.TryPickUpNow"/>
    /// and <see cref="WorldObjectPlacementUtils.TryPlaceWorldObject"/>, so authorization,
    /// laws, deeds and occupancy all run exactly as they would if a player did it by hand.
    /// Nothing here reimplements a rule.
    ///
    /// There is no animation. Vanilla's dumpster loader drives an arm rig through a client
    /// MonoBehaviour, and a mod cannot ship client code - only bind to classes the game
    /// already has. A semi does not lift a container with an arm anyway; it backs under
    /// one. So the container simply appears on the trailer, switched by the same animated
    /// state the prefab already listens to.
    /// </summary>
    [Serialized, NoIcon]
    public class SemiContainerCarrierComponent : ParkedVehicleModuleComponent
    {
        /// <summary>Tag marking a container this loader may lift. Carried by both the item and the object.</summary>
        public const string LiftableTag = "SemiLiftable";  //noloc

        /// <summary>Animated state on the truck prefab that switches the trailer-mounted container mesh.</summary>
        public const string ContainerVisualState = "SemiContainerAttached";  //noloc

        /// <summary>Vehicle-local centre of the zone a lift looks in; set by the installing module.</summary>
        public Vector3 PickupOffset;
        /// <summary>Vehicle-local point a carried container is set back down at.</summary>
        public Vector3 SetdownOffset;

        /// <summary>Server-side busy window, gating spammed key presses. Short, because nothing has to animate.</summary>
        public float ActionSeconds = 1.5f;

        /// <summary>Radius of the lift zone. Generous next to the dumpster loader's 3 m: a semi is
        /// seven metres long and the driver is reversing a container onto a trailer, not lining a
        /// bin up under an arm.</summary>
        internal const float LiftRange = 6f;

        PublicStorageComponent cargo;      //The 40-slot hold on the truck.
        PublicStorageComponent carrySlot;  //The one slot the container item itself sits in.
        double busyUntil;                  //Transient - a restart clears it.

        /// <summary>True only while this module moves a container in or out of the carry slot, which is
        /// what opens <see cref="LoaderCarrySlotRestriction"/> for that transfer alone.</summary>
        public bool TransferInProgress { get; private set; }

        [SyncToView] public bool IsCarrying => this.carrySlot != null && !this.carrySlot.Inventory.IsEmpty;

        /// <summary>Whether the hold will take cargo right now.
        ///
        /// The transfer window matters as much as the carrying state: a load moves the
        /// container's contents into the hold BEFORE the container itself is lifted, so at
        /// that moment nothing is aboard yet and a plain IsCarrying test would have the
        /// loader refuse its own transfer - making every non-empty container impossible to
        /// pick up, with a message blaming the hold for being full.</summary>
        public bool AcceptsCargo => this.IsCarrying || this.TransferInProgress;

        bool Busy => TimeUtil.Seconds < this.busyUntil;

        public override void Initialize()
        {
            base.Initialize();
            this.cargo     = this.Parent.GetComponent<PublicStorageComponent>(nameof(SemiContainerLoaderItem));
            this.carrySlot = this.Parent.GetComponent<PublicStorageComponent>(SemiContainerLoaderItem.CarrySlotName);

            // The trailer container mesh follows what is actually aboard, whatever moved it.
            this.carrySlot.Inventory.OnChanged.Add(_ => this.SyncVisual());
            this.SyncVisual();

            // The driver's key. Eco gives a module no direct input path on the server, but
            // the client's tool control writes ModularVehicleComponent.State, so watching
            // that property IS the key press. Subscribed as a method group, not a lambda:
            // the subscription is weak, and a closure with no other owner would be
            // collected out from under us.
            if (this.Parent.GetComponent<ModularVehicleComponent>() is { } modular)
                modular.Subscribe(nameof(ModularVehicleComponent.State), this.OnToolStateChanged);
        }

        void SyncVisual() => this.Parent.SetAnimatedState(ContainerVisualState, this.IsCarrying);

        /// <summary>The tool control is a toggle, so one key does both jobs: carrying means set down,
        /// empty means pick up. Vanilla needs a second binding for setdown only because its client
        /// script can declare one, and a mod cannot.</summary>
        void OnToolStateChanged()
        {
            var modular = this.Parent.GetComponent<ModularVehicleComponent>();
            if (modular == null || modular.State == ModularVehicleToolState.Disabled) return;

            // Momentary: drop straight back to Disabled so the next press registers as a
            // fresh activation. This re-enters through the subscription and short-circuits
            // on the line above, which is why it happens before any work is done.
            modular.State = ModularVehicleToolState.Disabled;
            modular.Changed(nameof(ModularVehicleComponent.State));

            // The actor is the driver by construction - the tool control only exists for
            // whoever is at the wheel.
            if (this.Vehicle.Driver is { } driver) this.Toggle(driver, fromSeat: true);
        }

        /// <summary>On-foot equivalent of the driver's key, for loading without climbing in - and a
        /// working path to the feature if the tool control ever stops reaching the server.</summary>
        [Interaction(InteractionTrigger.RightClick, "Load / Unload Container", authRequired: AccessType.FullAccess)]
        public void ToggleContainerInteraction(Player player, InteractionTriggerInfo trigger, InteractionTarget target)
            => this.Toggle(player, fromSeat: false);

        void Toggle(Player player, bool fromSeat)
        {
            if (this.Busy) { player.MsgLocStr("The container loader is still busy.", NotificationStyle.Error); return; }

            // The parked check is the driver's; on foot the truck is parked by definition,
            // and demanding it settle would just reject a player who nudged it walking past.
            if (fromSeat && !this.CheckDriverAndParked(player, "Park the truck before loading or unloading a container.")) return;

            if (this.IsCarrying) this.TryUnload(player);
            else                 this.TryLoad(player);
        }

        /// <summary>Lifts the nearest container in the zone aboard, cargo and all.</summary>
        void TryLoad(Player player)
        {
            var zoneCenter = this.Parent.Position + this.Parent.Rotation.RotateVector(this.PickupOffset);
            var container  = FindNearestLiftable(zoneCenter);
            if (container == null)                                          { player.MsgLocStr("No container in range. Back the trailer up to one.", NotificationStyle.Error); return; }
            if (!container.IsAuthorized(player.User, AccessType.FullAccess)) { player.MsgLocStr("You're not authorized to take that container.",     NotificationStyle.Error); return; }   //Pre-check; the pickup re-checks authoritatively.

            var lifted = false;
            // Opened for this whole sequence, not just the lift: it unlocks the carry slot
            // AND the hold, and the cargo has to move before the container can be taken.
            this.TransferInProgress = true;
            try
            {
                // Empty it into the hold FIRST. Eco's pickup pushes a storage object's
                // contents into the inventory it is picking up into, and the carry slot
                // takes containers and nothing else - so a loaded container cannot be
                // lifted while it is still loaded.
                if (!this.TakeCargoFrom(container)) { player.MsgLocStr("The truck's hold can't take that container's cargo.", NotificationStyle.Error); return; }

                lifted = container.TryPickUpNow(player, this.carrySlot.Inventory, caloriesNeeded: 0f, force: false).Success;
            }
            finally { this.TransferInProgress = false; }

            if (!lifted) { this.GiveCargoTo(container); return; }   //Refused (auth, laws) and already toasted; the container keeps its load.

            this.busyUntil = TimeUtil.Seconds + this.ActionSeconds;
            player.MsgLocStr("Container loaded.", NotificationStyle.InfoBox);
        }

        /// <summary>Sets the carried container down behind the truck, truck-aligned, with its cargo back inside.</summary>
        async void TryUnload(Player player)
        {
            var stack = this.carrySlot.Inventory.NonEmptyStacks.FirstOrDefault();
            if (stack?.Item is not WorldObjectItem containerItem) { player.MsgLocStr("Not carrying a container.", NotificationStyle.Error); return; }

            var pos = World.GetWrappedWorldPosition(this.Parent.Position + this.Parent.Rotation.RotateVector(this.SetdownOffset));

            // Both of these toast their own reason (no solid ground, someone else's deed,
            // something already there), so a rejected setdown tells the driver why.
            if (containerItem.OccupancyContext?.CanPlaceObject(player, containerItem, pos, this.Parent.Rotation) == false) return;
            if (WorldObjectPlacementUtils.IsValidPlacement(containerItem, pos, this.Parent.Rotation, null).NotifyIfFailed(player.User)) return;

            // Built by hand rather than via TryPlaceWorldObjectNow: the placement decrements
            // our carry slot, and the change set has to know that inventory up front. The
            // convenience wrapper only registers the player's own.
            using var pack = new GameActionPack(InventoryChangeSet.New(new[] { this.carrySlot.Inventory, player.User.Inventory }, player.User));

            WorldObject placed;
            this.TransferInProgress = true;   //Opens the carry slot so the placement may consume the container from it.
            try
            {
                var getPlaced = await WorldObjectPlacementUtils.TryPlaceWorldObject(pack, player, containerItem, stack, pos, this.Parent.Rotation, null);
                placed        = pack.TryPerform(player.User).Success ? getPlaced?.Invoke() : null;   //Failures notify through the pack.
            }
            finally { this.TransferInProgress = false; }

            if (placed == null) return;

            this.busyUntil = TimeUtil.Seconds + this.ActionSeconds;
            if (!this.GiveCargoTo(placed)) player.MsgLocStr("The container is down, but some of its cargo wouldn't fit back in and is still in the truck.", NotificationStyle.Error);
            else                           player.MsgLocStr("Container set down.", NotificationStyle.InfoBox);
        }

        /// <summary>Moves a container's cargo into the truck's hold, leaving it empty for the lift.
        /// All or nothing: a partial move would leave the lift to fail with the load split in two.</summary>
        bool TakeCargoFrom(WorldObject container)
        {
            var source = ContentInventory(container);
            if (source == null || source.IsEmpty) return true;

            source.MoveAsManyItemsAsPossible(this.cargo.Inventory, sourceStackPredicate: null);
            if (source.IsEmpty) return true;

            this.cargo.Inventory.MoveAsManyItemsAsPossible(source, sourceStackPredicate: null);   //Put back what did move.
            return false;
        }

        /// <summary>Hands the hold's contents to a container. Anything that will not fit stays in the
        /// truck rather than being destroyed, and the caller says so.</summary>
        bool GiveCargoTo(WorldObject container)
        {
            if (this.cargo.Inventory.IsEmpty) return true;
            var target = ContentInventory(container);
            if (target == null) return false;
            this.cargo.Inventory.MoveAsManyItemsAsPossible(target, sourceStackPredicate: null);
            return this.cargo.Inventory.IsEmpty;
        }

        /// <summary>A container's own cargo inventory - the one a plain pickup would drain.</summary>
        static Inventory ContentInventory(WorldObject container) =>
            container.Components.OfType<IInventoryWorldObjectComponent>().Select(c => c.Inventory).FirstOrDefault();

        /// <summary>Nearest liftable-tagged object in the zone. Matches on the CREATING ITEM's tag,
        /// as vanilla does, so the object and its item can never disagree about being liftable.</summary>
        static WorldObject FindNearestLiftable(Vector3 zoneCenter)
        {
            var liftableTag = TagManager.GetTagOrFail(LiftableTag);
            return ServiceHolder<IWorldObjectManager>.Obj.GetObjectsWithin(zoneCenter, LiftRange)
                .Where(obj => (obj.CreatingItem as Item)?.Type.HasTag(liftableTag) == true)
                .OrderBy(obj => World.WrappedDistance(zoneCenter, obj.Position))
                .FirstOrDefault();
        }
    }

    // ---------------------------------------------------------------------------------
    // RECIPES
    // ---------------------------------------------------------------------------------

    /// <summary>
    /// The truck itself.
    ///
    /// Placement reasoning, from the shipped recipes rather than taste:
    ///
    ///   Truck          IndustrySkill 2, RoboticAssemblyLine, 2000 cal, 18 xp
    ///   SEMI TRUCK     IndustrySkill 4, RoboticAssemblyLine, 3500 cal, 14 xp
    ///
    /// EVERY craftable Industry vehicle sits at level 2 - Excavator, Scorpion, SkidSteer,
    /// Industrial Elevator, Truck. Putting the semi there would make it a sidegrade to the
    /// Truck rather than a step past it. Level 4 is a real, populated tier (Industrial
    /// Generator, Refrigerator, Belt Sorter) so it does not read as an arbitrary wall.
    ///
    /// Level 6 was the alternative and was rejected: vanilla TrailerTruck repairs at
    /// Industry 6, which hints SLG saw it as end-game, but level 6 holds exactly one other
    /// recipe in the whole game and level 5 is empty. Sitting alone up there reads as a
    /// dead end rather than a destination.
    ///
    /// Ingredients are the Truck's list scaled for a vehicle roughly twice the size.
    /// </summary>
    [RequiresSkill(typeof(IndustrySkill), 4)]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Semi Truck Item")]
    public partial class SemiTruckRecipe : RecipeFamily
    {
        public SemiTruckRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SemiTruck",  //noloc
                displayName: Localizer.DoStr("Semi Truck"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem),   40, typeof(IndustrySkill)),
                    new IngredientElement(typeof(GearboxItem),       6, typeof(IndustrySkill)),
                    new IngredientElement(typeof(SteelSpringItem),  10, typeof(IndustrySkill)),
                    new IngredientElement(typeof(NylonFabricItem),  20, typeof(IndustrySkill)),
                    // Not reducible by skill, matching how the shipped trucks treat their
                    // engine, wheels and consumables.
                    new IngredientElement(typeof(AdvancedCombustionEngineItem), 2, true),
                    new IngredientElement(typeof(ElectricMotorItem),           2, true),
                    new IngredientElement(typeof(RubberWheelItem),            12, true),
                    new IngredientElement(typeof(SteelAxleItem),               4, true),
                    new IngredientElement(typeof(RadiatorItem),                2, true),
                    new IngredientElement(typeof(LightBulbItem),               6, true),
                    new IngredientElement(typeof(LubricantItem),               4, true),
                    new IngredientElement(typeof(FuseItem),                    4, true),
                    new IngredientElement(typeof(InsulatedCopperWiringItem),   4, true),
                },
                garbages: new List<GarbageOutput>
                {
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SemiTruckItem>()
                });

            this.Recipes           = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 24;

            this.LaborInCalories = CreateLaborInCaloriesValue(3500, typeof(IndustrySkill));
            this.CraftMinutes    = CreateCraftTimeValue(beneficiary: typeof(SemiTruckRecipe),
                                                        start: 15, skillType: typeof(IndustrySkill));

            this.Initialize(displayText: Localizer.DoStr("Semi Truck"), recipeType: typeof(SemiTruckRecipe));

            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipeFamily: this);
        }
    }

    /// <summary>
    /// The container, deliberately cheap and EARLY.
    ///
    /// Industry 2 matches TruckFlatbedItem, the equivalent vanilla body. The intent is that
    /// a hauler buys one expensive truck and one loader, then runs many containers through
    /// them - staging loaded boxes at each end of a route is the whole point of the design,
    /// and that falls apart if each box costs like a vehicle. Cheaper than it was when a
    /// container was also the module, because now you are meant to own several.
    /// </summary>
    [RequiresSkill(typeof(IndustrySkill), 2)]
    [Ecopedia("Crafted Objects", "Vehicles", subPageName: "Semi Container Item")]
    public partial class SemiContainerRecipe : RecipeFamily
    {
        public SemiContainerRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SemiContainer",  //noloc
                displayName: Localizer.DoStr("Semi Container"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem),  14, typeof(IndustrySkill)),
                    new IngredientElement(typeof(RivetItem),       10, typeof(IndustrySkill)),
                    new IngredientElement(typeof(SteelSpringItem),  2, typeof(IndustrySkill)),
                },
                garbages: new List<GarbageOutput>
                {
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SemiContainerItem>()
                });

            this.Recipes           = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 12;

            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(IndustrySkill));
            this.CraftMinutes    = CreateCraftTimeValue(beneficiary: typeof(SemiContainerRecipe),
                                                        start: 5, skillType: typeof(IndustrySkill));

            this.Initialize(displayText: Localizer.DoStr("Semi Container"), recipeType: typeof(SemiContainerRecipe));

            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipeFamily: this);
        }
    }

    /// <summary>
    /// The loader module. Bought once and left on the truck, so it is priced as a fitting
    /// rather than as a vehicle: the wheels and axles that used to be in the container
    /// recipe live here now, because this is the part that actually carries the load.
    ///
    /// Industry 3 sits it between the container and the truck. You can have containers
    /// before you can move them, which is the right way round - a yard full of boxes is a
    /// reason to want the truck.
    /// </summary>
    [RequiresSkill(typeof(IndustrySkill), 3)]
    [Ecopedia("Items", "Tools", subPageName: "Semi Container Loader Item")]
    public partial class SemiContainerLoaderRecipe : RecipeFamily
    {
        public SemiContainerLoaderRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SemiContainerLoader",  //noloc
                displayName: Localizer.DoStr("Semi Container Loader"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SteelPlateItem),  16, typeof(IndustrySkill)),
                    new IngredientElement(typeof(RivetItem),        8, typeof(IndustrySkill)),
                    new IngredientElement(typeof(SteelSpringItem),  4, typeof(IndustrySkill)),
                    new IngredientElement(typeof(GearboxItem),      2, typeof(IndustrySkill)),
                    new IngredientElement(typeof(RubberWheelItem),  4, true),
                    new IngredientElement(typeof(SteelAxleItem),    2, true),
                    new IngredientElement(typeof(LubricantItem),    2, true),
                },
                garbages: new List<GarbageOutput>
                {
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SemiContainerLoaderItem>()
                });

            this.Recipes           = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 14;

            this.LaborInCalories = CreateLaborInCaloriesValue(1600, typeof(IndustrySkill));
            this.CraftMinutes    = CreateCraftTimeValue(beneficiary: typeof(SemiContainerLoaderRecipe),
                                                        start: 8, skillType: typeof(IndustrySkill));

            this.Initialize(displayText: Localizer.DoStr("Semi Container Loader"), recipeType: typeof(SemiContainerLoaderRecipe));

            CraftingComponent.AddRecipe(tableType: typeof(RoboticAssemblyLineObject), recipeFamily: this);
        }
    }
}
