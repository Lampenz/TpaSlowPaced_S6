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


    [RotatedVariants(typeof(CopperFenceWallBorderBlock), typeof(CopperFenceWallBorder90Block), typeof(CopperFenceWallBorder180Block), typeof(CopperFenceWallBorder270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceWallBorderBarBlock), typeof(CopperFenceWallBorderBar90Block), typeof(CopperFenceWallBorderBar180Block), typeof(CopperFenceWallBorderBar270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceBarFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceWallBorderSpikeBlock), typeof(CopperFenceWallBorderSpike90Block), typeof(CopperFenceWallBorderSpike180Block), typeof(CopperFenceWallBorderSpike270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceWallBorderSpikeHalfBlock), typeof(CopperFenceWallBorderSpikeHalf90Block), typeof(CopperFenceWallBorderSpikeHalf180Block), typeof(CopperFenceWallBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeHalfFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceWallBorderSpikeLowBlock), typeof(CopperFenceWallBorderSpikeLow90Block), typeof(CopperFenceWallBorderSpikeLow180Block), typeof(CopperFenceWallBorderSpikeLow270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeLowFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }
}
