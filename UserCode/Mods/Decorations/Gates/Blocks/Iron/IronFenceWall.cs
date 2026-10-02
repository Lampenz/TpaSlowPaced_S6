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


    [RotatedVariants(typeof(IronFenceWallBlock), typeof(IronFenceWall90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWall90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }


    [RotatedVariants(typeof(IronFenceWallBarBlock), typeof(IronFenceWallBar90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallFenceBarFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallBarBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallBar90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceWallSpikeBlock), typeof(IronFenceWallSpike90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallSpikeBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpike90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceWallSpikeHalfBlock), typeof(IronFenceWallSpikeHalf90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeHalfFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallSpikeHalfBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeHalf90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceWallSpikeLowBlock), typeof(IronFenceWallSpikeLow90Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeLowFormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallSpikeLowBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeLow90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceWallSpikeGaussDownBlock), typeof(IronFenceWallSpikeGaussDown90Block), typeof(IronFenceWallSpikeGaussDown180Block), typeof(IronFenceWallSpikeGaussDown270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending1FormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallSpikeGaussDownBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussDown90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussDown180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussDown270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [RotatedVariants(typeof(IronFenceWallSpikeGaussUpBlock), typeof(IronFenceWallSpikeGaussUp90Block), typeof(IronFenceWallSpikeGaussUp180Block), typeof(IronFenceWallSpikeGaussUp270Block))]
    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [IsForm(typeof(GateWallSpikeAscending2FormType), typeof(IronFenceItem))]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    public class IronFenceWallSpikeGaussUpBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussUp90Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussUp180Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Wall, Constructed, Solid, BuildRoomMaterialOption]
    [BlockTier(2)]
    public partial class IronFenceWallSpikeGaussUp270Block : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

}