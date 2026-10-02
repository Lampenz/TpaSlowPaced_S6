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
    [Ecopedia("Blocks", "Construction", subPageName: "Gold Fence Item")]
    public partial class GoldFenceRecipe : Recipe
    {
        public GoldFenceRecipe()
        {
            this.Init(
                "GoldFence",
                Localizer.DoStr("Gold Fence"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 1, typeof(SmeltingSkill)),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<GoldFenceItem>()
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
    public partial class GoldFenceBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldFenceItem); } }
    }

    [Serialized]
    [LocDisplayName("Gold Fence")]
    [LocDescription("A gold fence with three vertical bars allowing visibility while marking boundaries.")]
    [MaxStackSize(20)]
    [Weight(1000)]
    [Ecopedia("Blocks", "Construction", createAsSubPage: true)]
    [Tag("GoldFence")]
    [Tag("Constructable")]
    [Tier(2)]
    public partial class GoldFenceItem : BlockItem<GoldFenceBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Gold Fences"); } }

        private static Type[] blockTypes = new Type[] {
            typeof(GoldFenceStacked1Block),
            typeof(GoldFenceStacked2Block),
            typeof(GoldFenceStacked3Block),
            typeof(GoldFenceStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }


    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldFenceStacked1Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldFenceStacked2Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class GoldFenceStacked3Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid, Wall] public class GoldFenceStacked4Block : PickupableBlock { } //Only a wall if it's all 4 GoldFence


 }
