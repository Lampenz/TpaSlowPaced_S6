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


    [RotatedVariants(typeof(IronFenceCornerBlock), typeof(IronFenceCorner90Block), typeof(IronFenceCorner180Block), typeof(IronFenceCorner270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCorner90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCorner180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCorner270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceCornerBarBlock), typeof(IronFenceCornerBar90Block), typeof(IronFenceCornerBar180Block), typeof(IronFenceCornerBar270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceBarFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerSpikeBlock), typeof(IronFenceCornerSpike90Block), typeof(IronFenceCornerSpike180Block), typeof(IronFenceCornerSpike270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerSpikeHalfBlock), typeof(IronFenceCornerSpikeHalf90Block), typeof(IronFenceCornerSpikeHalf180Block), typeof(IronFenceCornerSpikeHalf270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeHalfFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerSpikeLowBlock), typeof(IronFenceCornerSpikeLow90Block), typeof(IronFenceCornerSpikeLow180Block), typeof(IronFenceCornerSpikeLow270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeLowFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }
}