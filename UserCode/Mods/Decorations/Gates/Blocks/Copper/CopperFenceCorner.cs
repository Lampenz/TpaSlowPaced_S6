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


    [RotatedVariants(typeof(CopperFenceCornerBlock), typeof(CopperFenceCorner90Block), typeof(CopperFenceCorner180Block), typeof(CopperFenceCorner270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCorner90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCorner180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCorner270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceCornerBarBlock), typeof(CopperFenceCornerBar90Block), typeof(CopperFenceCornerBar180Block), typeof(CopperFenceCornerBar270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceBarFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerSpikeBlock), typeof(CopperFenceCornerSpike90Block), typeof(CopperFenceCornerSpike180Block), typeof(CopperFenceCornerSpike270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerSpikeHalfBlock), typeof(CopperFenceCornerSpikeHalf90Block), typeof(CopperFenceCornerSpikeHalf180Block), typeof(CopperFenceCornerSpikeHalf270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeHalfFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceCornerSpikeLowBlock), typeof(CopperFenceCornerSpikeLow90Block), typeof(CopperFenceCornerSpikeLow180Block), typeof(CopperFenceCornerSpikeLow270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeLowFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceCornerSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceCornerSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }
}
