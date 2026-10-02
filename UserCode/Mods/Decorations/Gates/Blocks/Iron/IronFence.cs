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

    [RequiresSkill(typeof(SmeltingSkill), 1)]
    [Ecopedia("Blocks", "Construction", subPageName: "Iron Fence Item")]
    public partial class IronFenceRecipe : RecipeFamily
    {
        public IronFenceRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "IronFence",
                Localizer.DoStr("Iron Fence"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(SmeltingSkill)),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<IronFenceItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f;
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(IronFenceRecipe), 1f, typeof(SmeltingSkill));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Iron Fence"), typeof(IronFenceRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(AnvilObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [BlockTier(2)]
    [RequiresSkill(typeof(SmeltingSkill), 1)]
    public partial class IronFenceBlock : Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronFenceItem); } }
    }

    [Serialized]
    [LocDisplayName("Iron Fence")]
    [LocDescription("An iron fence with three vertical bars allowing visibility while marking boundaries.")]
    [MaxStackSize(20)]
    [Weight(1000)]
    [Ecopedia("Blocks", "Construction", createAsSubPage: true)]
    [Tag("IronFence")]
    [Tag("Constructable")]
    [Tier(2)]
    public partial class IronFenceItem : BlockItem<IronFenceBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Iron Fences"); } }

        private static Type[] blockTypes = new Type[] {
            typeof(IronFenceStacked1Block),
            typeof(IronFenceStacked2Block),
            typeof(IronFenceStacked3Block),
            typeof(IronFenceStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }


    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class IronFenceStacked1Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class IronFenceStacked2Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.PartialStack)]
    [Serialized, Solid] public class IronFenceStacked3Block : PickupableBlock { }
    [Tag("Constructable")]
    [Tag(BlockTags.FullStack)]
    [Serialized, Solid, Wall] public class IronFenceStacked4Block : PickupableBlock { } //Only a wall if it's all 4 IronFence


 }
