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


    [RotatedVariants(typeof(CopperFenceWallBlock), typeof(CopperFenceWall90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWall90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallBarBlock), typeof(CopperFenceWallBar90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceBarFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallSpikeBlock), typeof(CopperFenceWallSpike90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallSpikeHalfBlock), typeof(CopperFenceWallSpikeHalf90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeHalfFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallSpikeLowBlock), typeof(CopperFenceWallSpikeLow90Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeLowFormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallSpikeGaussDownBlock), typeof(CopperFenceWallSpikeGaussDown90Block), typeof(CopperFenceWallSpikeGaussDown180Block), typeof(CopperFenceWallSpikeGaussDown270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending1FormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallSpikeGaussDownBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussDown90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussDown180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussDown270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [RotatedVariants(typeof(CopperFenceWallSpikeGaussUpBlock), typeof(CopperFenceWallSpikeGaussUp90Block), typeof(CopperFenceWallSpikeGaussUp180Block), typeof(CopperFenceWallSpikeGaussUp270Block))]
    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending2FormType), typeof(CopperFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class CopperFenceWallSpikeGaussUpBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussUp90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussUp180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class CopperFenceWallSpikeGaussUp270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

}
