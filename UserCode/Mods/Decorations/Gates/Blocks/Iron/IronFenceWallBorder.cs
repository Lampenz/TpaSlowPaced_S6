namespace Eco.Mods.TechTree
{
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Pipes;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.SharedTypes;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;


    [RotatedVariants(typeof(IronFenceWallBorderBlock), typeof(IronFenceWallBorder90Block), typeof(IronFenceWallBorder180Block), typeof(IronFenceWallBorder270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceWallBorderBarBlock), typeof(IronFenceWallBorderBar90Block), typeof(IronFenceWallBorderBar180Block), typeof(IronFenceWallBorderBar270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceBarFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceWallBorderSpikeBlock), typeof(IronFenceWallBorderSpike90Block), typeof(IronFenceWallBorderSpike180Block), typeof(IronFenceWallBorderSpike270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceWallBorderSpikeHalfBlock), typeof(IronFenceWallBorderSpikeHalf90Block), typeof(IronFenceWallBorderSpikeHalf180Block), typeof(IronFenceWallBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeHalfFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceWallBorderSpikeLowBlock), typeof(IronFenceWallBorderSpikeLow90Block), typeof(IronFenceWallBorderSpikeLow180Block), typeof(IronFenceWallBorderSpikeLow270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeLowFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }
}