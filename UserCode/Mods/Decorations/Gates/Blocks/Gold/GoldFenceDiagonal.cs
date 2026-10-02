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


    [RotatedVariants(typeof(GoldFenceDiagonalBlock), typeof(GoldFenceDiagonal90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalFenceFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceDiagonalBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceDiagonal90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceDiagonalSpikeBlock), typeof(GoldFenceDiagonalSpike90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceDiagonalSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceDiagonalSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceDiagonalSpikeHalfBlock), typeof(GoldFenceDiagonalSpikeHalf90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeHalfFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceDiagonalSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceDiagonalSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }


    [RotatedVariants(typeof(GoldFenceDiagonalSpikeLowBlock), typeof(GoldFenceDiagonalSpikeLow90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeLowFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceDiagonalSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceDiagonalSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }
}
