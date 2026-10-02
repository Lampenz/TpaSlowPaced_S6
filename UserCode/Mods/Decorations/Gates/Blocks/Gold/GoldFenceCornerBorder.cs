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


    [RotatedVariants(typeof(GoldFenceCornerBorderBlock), typeof(GoldFenceCornerBorder90Block), typeof(GoldFenceCornerBorder180Block), typeof(GoldFenceCornerBorder270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerBorderBarBlock), typeof(GoldFenceCornerBorderBar90Block), typeof(GoldFenceCornerBorderBar180Block), typeof(GoldFenceCornerBorderBar270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceBarFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerBorderSpikeBlock), typeof(GoldFenceCornerBorderSpike90Block), typeof(GoldFenceCornerBorderSpike180Block), typeof(GoldFenceCornerBorderSpike270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerBorderSpikeHalfBlock), typeof(GoldFenceCornerBorderSpikeHalf90Block), typeof(GoldFenceCornerBorderSpikeHalf180Block), typeof(GoldFenceCornerBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeHalfFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceCornerBorderSpikeLowBlock), typeof(GoldFenceCornerBorderSpikeLow90Block), typeof(GoldFenceCornerBorderSpikeLow180Block), typeof(GoldFenceCornerBorderSpikeLow270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeLowFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceCornerBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceCornerBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }
}
