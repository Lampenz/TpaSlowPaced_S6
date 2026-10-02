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


    [RotatedVariants(typeof(GoldFenceWallBorderBlock), typeof(GoldFenceWallBorder90Block), typeof(GoldFenceWallBorder180Block), typeof(GoldFenceWallBorder270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceWallBorderBarBlock), typeof(GoldFenceWallBorderBar90Block), typeof(GoldFenceWallBorderBar180Block), typeof(GoldFenceWallBorderBar270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderFenceBarFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceWallBorderSpikeBlock), typeof(GoldFenceWallBorderSpike90Block), typeof(GoldFenceWallBorderSpike180Block), typeof(GoldFenceWallBorderSpike270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceWallBorderSpikeHalfBlock), typeof(GoldFenceWallBorderSpikeHalf90Block), typeof(GoldFenceWallBorderSpikeHalf180Block), typeof(GoldFenceWallBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeHalfFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceWallBorderSpikeLowBlock), typeof(GoldFenceWallBorderSpikeLow90Block), typeof(GoldFenceWallBorderSpikeLow180Block), typeof(GoldFenceWallBorderSpikeLow270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallBorderSpikeLowFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }
}
