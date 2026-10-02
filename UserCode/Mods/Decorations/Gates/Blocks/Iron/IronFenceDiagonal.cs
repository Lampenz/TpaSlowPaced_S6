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


    [RotatedVariants(typeof(IronFenceDiagonalBlock), typeof(IronFenceDiagonal90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalFenceFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceDiagonalBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceDiagonal90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceDiagonalSpikeBlock), typeof(IronFenceDiagonalSpike90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceDiagonalSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceDiagonalSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceDiagonalSpikeHalfBlock), typeof(IronFenceDiagonalSpikeHalf90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeHalfFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceDiagonalSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceDiagonalSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceDiagonalSpikeLowBlock), typeof(IronFenceDiagonalSpikeLow90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeLowFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceDiagonalSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceDiagonalSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }
}
