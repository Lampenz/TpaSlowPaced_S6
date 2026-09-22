namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Interactions.Interactors;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Occupancy;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using static Eco.Gameplay.Components.PartsComponent;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Shared.Networking;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
    using Eco.Gameplay.Components.Storage;
    using Eco.Core.Plugins.Interfaces;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(PartsComponent))]
    [RequireComponent(typeof(PowerGridComponent))]
    [RequireComponent(typeof(PowerGeneratorComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(WindGeneratorComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [PowerGenerator(typeof(MechanicalPower))]
    [Tag("Usable")]
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "MillHouse Item")]
    [RepairRequiresSkill(typeof(MasonrySkill), 5)]
    [RepairRequiresSkill(typeof(SelfImprovementSkill), 4)]
    public partial class MillHouseObject : WorldObject, IRepresentsItem, IHasInteractions
    {
        public virtual Type RepresentedItemType => typeof(MillHouseItem);
        public override LocString DisplayName => Localizer.DoStr("MillHouse");
        public override TableTextureMode TableTexture => TableTextureMode.Brick;

        static MillHouseObject()
        {
            var BlockOccupancyList = new List<BlockOccupancy>
            {
                new BlockOccupancy(new Vector3i(0, 0, 0)),
                new BlockOccupancy(new Vector3i(0, 0, 1)),
                new BlockOccupancy(new Vector3i(0, 1, 0)),
                new BlockOccupancy(new Vector3i(0, 1, 1)),
            };

            AddOccupancy<MillHouseObject>(BlockOccupancyList);
        }


        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Power"));
            this.GetComponent<PowerGridComponent>().Initialize(30, new MechanicalPower(), 10, true);
            this.GetComponent<PowerGeneratorComponent>().Initialize(200);
            this.GetComponent<PartsComponent>().Config(() => LocString.Empty, new PartInfo[]
            {
                                new() { TypeName = nameof(LinenFabricItem), Quantity = 4},
                                new() { TypeName = nameof(LubricantItem), Quantity = 2},
                            });
            this.GetComponent<PowerGridComponent>().DurabilityUsedPerHourOfUse = 1.4f;
            this.ModsPostInitialize();
        }

        /// <summary>
        /// Hook for mods to customize WorldObject before initialization.
        /// You can change housing values here.
        /// </summary>
        partial void ModsPreInitialize();

        /// <summary>
        /// Hook for mods to customize WorldObject after initialization.
        /// </summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("MillHouse")]
    [LocDescription("A MillHouse to produce mechanical power")]
    [IconGroup("World Object Minimap")]
    [Ecopedia("Crafted Objects", "Power Generation", createAsSubPage: true)]
    [Weight(10000)]
    public partial class MillHouseItem : WorldObjectItem<MillHouseObject>, IPersistentData
    {
        protected override OccupancyContext GetOccupancyContext =>
            new SideAttachedContext(
                0 | DirectionAxisFlags.Down,
                WorldObject.GetOccupancyInfo(this.WorldObjectType)
            );

        [Serialized, SyncToView, NewTooltipChildren(
            CacheAs.Instance,
            flags: TTFlags.AllowNonControllerTypeForChildren
        )]
        public object PersistentData { get; set; }
    }


    [RequiresSkill(typeof(BasicEngineeringSkill), 5)]
    [Ecopedia("Crafted Objects", "Power Generation", subPageName: "MillHouse Item")]
    public partial class MillHouseRecipe : RecipeFamily
    {
        public MillHouseRecipe()
        {
            var recipe = new Recipe();

            recipe.Init(name: "MillHouse",displayName: Localizer.DoStr("MillHouse"),
            ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(LinenFabricItem), 12, typeof(BasicEngineeringSkill)),
                    new IngredientElement(typeof(LubricantItem), 4, typeof(BasicEngineeringSkill)),
                    new IngredientElement(typeof(MillStoneItem), 1, typeof(BasicEngineeringSkill)),
                    new IngredientElement("HewnLog", 45, typeof(BasicEngineeringSkill)),
                    new IngredientElement("MortaredStone", 45, typeof(BasicEngineeringSkill)),
                },

                items: new List<CraftingElement>{new CraftingElement<MillHouseItem>()}
            );

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 8;
            this.LaborInCalories = CreateLaborInCaloriesValue(100,typeof(BasicEngineeringSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MillHouseRecipe),start: 4,skillType: typeof(BasicEngineeringSkill));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("MillHouse"),recipeType: typeof(MillHouseRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(
                tableType: typeof(CarpentryTableObject),
                recipeFamily: this
            );
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
