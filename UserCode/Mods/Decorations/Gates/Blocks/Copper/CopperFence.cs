namespace Eco.Mods.TechTree
{
    using Eco.Core.Controller;
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

    [RequiresSkill(typeof(SmeltingSkill), 1)]
    [ForceCreateView]
    [Ecopedia("Blocks", "Construction", subPageName: "Copper Fence Item")]
    public partial class CopperFenceRecipe : Recipe
    {
        public CopperFenceRecipe()
        {
            this.Init(
                "CopperFence",
                Localizer.DoStr("Copper Fence"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperBarItem), 1, typeof(SmeltingSkill)),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<CopperFenceItem>()
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AnvilObject), typeof(IronFenceRecipe), this);
        }

        /// <summary>Hook for mods to customize Recipe after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [BlockTier(2)]
    [RequiresSkill(typeof(SmeltingSkill), 1)]
    public partial class CopperFenceBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CopperFenceItem); } }
    }

    [Serialized]
    [LocDisplayName("Copper Fence")]
    [LocDescription("A copper fence with three vertical bars allowing visibility while marking boundaries.")]
    [MaxStackSize(20)]
    [Weight(1000)]
    [Ecopedia("Blocks", "Construction", createAsSubPage: true)]
    [Tag("CopperFence")]
    [Tag("Constructable")]
    [Tier(2)]
    public partial class CopperFenceItem : BlockItem<CopperFenceBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Copper Fences"); } }

        private static Type[] blockTypes = new Type[] {
            typeof(CopperFenceStacked1Block),
            typeof(CopperFenceStacked2Block),
            typeof(CopperFenceStacked3Block),
            typeof(CopperFenceStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }


    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CopperFenceStacked1Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CopperFenceStacked2Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class CopperFenceStacked3Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid, Wall] public class CopperFenceStacked4Block : PickupableBlock { } //Only a wall if it's all 4 CopperFence


 }
