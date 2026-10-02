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


    [RotatedVariants(typeof(IronFenceCornerBorderBlock), typeof(IronFenceCornerBorder90Block), typeof(IronFenceCornerBorder180Block), typeof(IronFenceCornerBorder270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBorderBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorder90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorder180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorder270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerBorderBarBlock), typeof(IronFenceCornerBorderBar90Block), typeof(IronFenceCornerBorderBar180Block), typeof(IronFenceCornerBorderBar270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderFenceBarFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBorderBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderBar180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderBar270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerBorderSpikeBlock), typeof(IronFenceCornerBorderSpike90Block), typeof(IronFenceCornerBorderSpike180Block), typeof(IronFenceCornerBorderSpike270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBorderSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpike180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpike270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerBorderSpikeHalfBlock), typeof(IronFenceCornerBorderSpikeHalf90Block), typeof(IronFenceCornerBorderSpikeHalf180Block), typeof(IronFenceCornerBorderSpikeHalf270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeHalfFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBorderSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeHalf180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeHalf270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceCornerBorderSpikeLowBlock), typeof(IronFenceCornerBorderSpikeLow90Block), typeof(IronFenceCornerBorderSpikeLow180Block), typeof(IronFenceCornerBorderSpikeLow270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateCornerBorderSpikeLowFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceCornerBorderSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeLow180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceCornerBorderSpikeLow270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }
}