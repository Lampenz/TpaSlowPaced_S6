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


    [RotatedVariants(typeof(CopperFenceCornerBorderBlock), typeof(CopperFenceCornerBorder90Block), typeof(CopperFenceCornerBorder180Block), typeof(CopperFenceCornerBorder270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerBorderBarBlock), typeof(CopperFenceCornerBorderBar90Block), typeof(CopperFenceCornerBorderBar180Block), typeof(CopperFenceCornerBorderBar270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceBarFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerBorderSpikeBlock), typeof(CopperFenceCornerBorderSpike90Block), typeof(CopperFenceCornerBorderSpike180Block), typeof(CopperFenceCornerBorderSpike270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerBorderSpikeHalfBlock), typeof(CopperFenceCornerBorderSpikeHalf90Block), typeof(CopperFenceCornerBorderSpikeHalf180Block), typeof(CopperFenceCornerBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeHalfFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerBorderSpikeLowBlock), typeof(CopperFenceCornerBorderSpikeLow90Block), typeof(CopperFenceCornerBorderSpikeLow180Block), typeof(CopperFenceCornerBorderSpikeLow270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeLowFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }
}
