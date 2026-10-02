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


    [RotatedVariants(typeof(GoldFenceWallBlock), typeof(GoldFenceWall90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWall90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallBarBlock), typeof(GoldFenceWallBar90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceBarFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallSpikeBlock), typeof(GoldFenceWallSpike90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallSpikeHalfBlock), typeof(GoldFenceWallSpikeHalf90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeHalfFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallSpikeLowBlock), typeof(GoldFenceWallSpikeLow90Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeLowFormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallSpikeGaussDownBlock), typeof(GoldFenceWallSpikeGaussDown90Block), typeof(GoldFenceWallSpikeGaussDown180Block), typeof(GoldFenceWallSpikeGaussDown270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending1FormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallSpikeGaussDownBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussDown90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussDown180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussDown270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [RotatedVariants(typeof(GoldFenceWallSpikeGaussUpBlock), typeof(GoldFenceWallSpikeGaussUp90Block), typeof(GoldFenceWallSpikeGaussUp180Block), typeof(GoldFenceWallSpikeGaussUp270Block))]
    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending2FormType), typeof(GoldFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class GoldFenceWallSpikeGaussUpBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussUp90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussUp180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class GoldFenceWallSpikeGaussUp270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

}
