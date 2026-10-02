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


    [RotatedVariants(typeof(CopperFenceDiagonalBlock), typeof(CopperFenceDiagonal90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalFenceFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceDiagonalBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceDiagonal90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceDiagonalSpikeBlock), typeof(CopperFenceDiagonalSpike90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceDiagonalSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceDiagonalSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceDiagonalSpikeHalfBlock), typeof(CopperFenceDiagonalSpikeHalf90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeHalfFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceDiagonalSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceDiagonalSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }


    [RotatedVariants(typeof(CopperFenceDiagonalSpikeLowBlock), typeof(CopperFenceDiagonalSpikeLow90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateDiagonalSpikeLowFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceDiagonalSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceDiagonalSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }
}
