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


    [RotatedVariants(typeof(GoldFenceCornerBlock), typeof(GoldFenceCorner90Block), typeof(GoldFenceCorner180Block), typeof(GoldFenceCorner270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCorner90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCorner180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCorner270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceCornerBarBlock), typeof(GoldFenceCornerBar90Block), typeof(GoldFenceCornerBar180Block), typeof(GoldFenceCornerBar270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerFenceBarFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerSpikeBlock), typeof(GoldFenceCornerSpike90Block), typeof(GoldFenceCornerSpike180Block), typeof(GoldFenceCornerSpike270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerSpikeHalfBlock), typeof(GoldFenceCornerSpikeHalf90Block), typeof(GoldFenceCornerSpikeHalf180Block), typeof(GoldFenceCornerSpikeHalf270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeHalfFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerSpikeLowBlock), typeof(GoldFenceCornerSpikeLow90Block), typeof(GoldFenceCornerSpikeLow180Block), typeof(GoldFenceCornerSpikeLow270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerSpikeLowFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }
}
