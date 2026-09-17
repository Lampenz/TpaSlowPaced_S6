namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Core.Plugins.Interfaces; // AJOUTÉ - comme dans IceCream.cs
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
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
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Shared.Networking;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    using Eco.Gameplay.Housing.PropertyValues;
    using Eco.Gameplay.Civics.Objects;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems.NewTooltip;
    using Eco.Core.Controller;
    using Eco.Core.Utils;
    using Eco.Gameplay.Components.Storage;
    using static Eco.Gameplay.Housing.PropertyValues.HomeFurnishingValue;
    using Eco.Gameplay.Items.Recipes;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(MountComponent))]
    [RequireComponent(typeof(ForSaleComponent))]

    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "StairOutdoor Item")]
    public partial class StairOutdoorObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(StairOutdoorItem);
        public override LocString DisplayName => Localizer.DoStr("StairOutdoor");
        public override TableTextureMode TableTexture => TableTextureMode.Canvas;
        static StairOutdoorObject()
        {
            var BlockOccupancyList = new List<BlockOccupancy>
            {
                new BlockOccupancy(new Vector3i(-3, 0, -1)),
                new BlockOccupancy(new Vector3i(-3, 0, 0)),
                new BlockOccupancy(new Vector3i(-3, 0, 1)),
                new BlockOccupancy(new Vector3i(-3, 1, -1)),
                new BlockOccupancy(new Vector3i(-3, 1, 0)),
                new BlockOccupancy(new Vector3i(-3, 1, 1)),
                new BlockOccupancy(new Vector3i(-3, 2, -1)),
                new BlockOccupancy(new Vector3i(-3, 2, 0)),
                new BlockOccupancy(new Vector3i(-3, 2, 1)),
                new BlockOccupancy(new Vector3i(-3, 3, -1)),
                new BlockOccupancy(new Vector3i(-3, 3, 0)),
                new BlockOccupancy(new Vector3i(-3, 3, 1)),
                new BlockOccupancy(new Vector3i(-3, 4, -1)),
                new BlockOccupancy(new Vector3i(-3, 4, 0)),
                new BlockOccupancy(new Vector3i(-3, 4, 1)),
                new BlockOccupancy(new Vector3i(-3, 5, -1)),
                new BlockOccupancy(new Vector3i(-3, 5, 0)),
                new BlockOccupancy(new Vector3i(-3, 5, 1)),
                new BlockOccupancy(new Vector3i(-3, 6, -1)),
                new BlockOccupancy(new Vector3i(-3, 6, 0)),
                new BlockOccupancy(new Vector3i(-3, 6, 1)),
                new BlockOccupancy(new Vector3i(-3, 7, -1)),
                new BlockOccupancy(new Vector3i(-3, 7, 0)),
                new BlockOccupancy(new Vector3i(-3, 7, 1)),
                new BlockOccupancy(new Vector3i(-3, 8, -1)),
                new BlockOccupancy(new Vector3i(-3, 8, 0)),
                new BlockOccupancy(new Vector3i(-3, 8, 1)),
                new BlockOccupancy(new Vector3i(-3, 9, -1)),
                new BlockOccupancy(new Vector3i(-3, 9, 0)),
                new BlockOccupancy(new Vector3i(-3, 9, 1)),
                new BlockOccupancy(new Vector3i(-2, 0, -1)),
                new BlockOccupancy(new Vector3i(-2, 0, 0)),
                new BlockOccupancy(new Vector3i(-2, 0, 1)),
                new BlockOccupancy(new Vector3i(-2, 1, -1)),
                new BlockOccupancy(new Vector3i(-2, 1, 0)),
                new BlockOccupancy(new Vector3i(-2, 1, 1)),
                new BlockOccupancy(new Vector3i(-2, 2, -1)),
                new BlockOccupancy(new Vector3i(-2, 2, 0)),
                new BlockOccupancy(new Vector3i(-2, 2, 1)),
                new BlockOccupancy(new Vector3i(-2, 3, -1)),
                new BlockOccupancy(new Vector3i(-2, 3, 0)),
                new BlockOccupancy(new Vector3i(-2, 3, 1)),
                new BlockOccupancy(new Vector3i(-2, 4, -1)),
                new BlockOccupancy(new Vector3i(-2, 4, 0)),
                new BlockOccupancy(new Vector3i(-2, 4, 1)),
                new BlockOccupancy(new Vector3i(-2, 5, -1)),
                new BlockOccupancy(new Vector3i(-2, 5, 0)),
                new BlockOccupancy(new Vector3i(-2, 5, 1)),
                new BlockOccupancy(new Vector3i(-2, 6, -1)),
                new BlockOccupancy(new Vector3i(-2, 6, 0)),
                new BlockOccupancy(new Vector3i(-2, 6, 1)),
                new BlockOccupancy(new Vector3i(-2, 7, -1)),
                new BlockOccupancy(new Vector3i(-2, 7, 0)),
                new BlockOccupancy(new Vector3i(-2, 7, 1)),
                new BlockOccupancy(new Vector3i(-2, 8, -1)),
                new BlockOccupancy(new Vector3i(-2, 8, 0)),
                new BlockOccupancy(new Vector3i(-2, 8, 1)),
                new BlockOccupancy(new Vector3i(-2, 9, -1)),
                new BlockOccupancy(new Vector3i(-2, 9, 0)),
                new BlockOccupancy(new Vector3i(-2, 9, 1)),
                new BlockOccupancy(new Vector3i(-1, 0, -1)),
                new BlockOccupancy(new Vector3i(-1, 0, 0)),
                new BlockOccupancy(new Vector3i(-1, 0, 1)),
                new BlockOccupancy(new Vector3i(-1, 1, -1)),
                new BlockOccupancy(new Vector3i(-1, 1, 0)),
                new BlockOccupancy(new Vector3i(-1, 1, 1)),
                new BlockOccupancy(new Vector3i(-1, 2, -1)),
                new BlockOccupancy(new Vector3i(-1, 2, 0)),
                new BlockOccupancy(new Vector3i(-1, 2, 1)),
                new BlockOccupancy(new Vector3i(-1, 3, -1)),
                new BlockOccupancy(new Vector3i(-1, 3, 0)),
                new BlockOccupancy(new Vector3i(-1, 3, 1)),
                new BlockOccupancy(new Vector3i(-1, 4, -1)),
                new BlockOccupancy(new Vector3i(-1, 4, 0)),
                new BlockOccupancy(new Vector3i(-1, 4, 1)),
                new BlockOccupancy(new Vector3i(-1, 5, -1)),
                new BlockOccupancy(new Vector3i(-1, 5, 0)),
                new BlockOccupancy(new Vector3i(-1, 5, 1)),
                new BlockOccupancy(new Vector3i(-1, 6, -1)),
                new BlockOccupancy(new Vector3i(-1, 6, 0)),
                new BlockOccupancy(new Vector3i(-1, 6, 1)),
                new BlockOccupancy(new Vector3i(-1, 7, -1)),
                new BlockOccupancy(new Vector3i(-1, 7, 0)),
                new BlockOccupancy(new Vector3i(-1, 7, 1)),
                new BlockOccupancy(new Vector3i(-1, 8, -1)),
                new BlockOccupancy(new Vector3i(-1, 8, 0)),
                new BlockOccupancy(new Vector3i(-1, 8, 1)),
                new BlockOccupancy(new Vector3i(-1, 9, -1)),
                new BlockOccupancy(new Vector3i(-1, 9, 0)),
                new BlockOccupancy(new Vector3i(-1, 9, 1)),
                new BlockOccupancy(new Vector3i(0, 0, -1)),
                new BlockOccupancy(new Vector3i(0, 0, 0)),
                new BlockOccupancy(new Vector3i(0, 0, 1)),
                new BlockOccupancy(new Vector3i(0, 1, -1)),
                new BlockOccupancy(new Vector3i(0, 1, 0)),
                new BlockOccupancy(new Vector3i(0, 1, 1)),
                new BlockOccupancy(new Vector3i(0, 2, -1)),
                new BlockOccupancy(new Vector3i(0, 2, 0)),
                new BlockOccupancy(new Vector3i(0, 2, 1)),
                new BlockOccupancy(new Vector3i(0, 3, -1)),
                new BlockOccupancy(new Vector3i(0, 3, 0)),
                new BlockOccupancy(new Vector3i(0, 3, 1)),
                new BlockOccupancy(new Vector3i(0, 4, -1)),
                new BlockOccupancy(new Vector3i(0, 4, 0)),
                new BlockOccupancy(new Vector3i(0, 4, 1)),
                new BlockOccupancy(new Vector3i(0, 5, -1)),
                new BlockOccupancy(new Vector3i(0, 5, 0)),
                new BlockOccupancy(new Vector3i(0, 5, 1)),
                new BlockOccupancy(new Vector3i(0, 6, -1)),
                new BlockOccupancy(new Vector3i(0, 6, 0)),
                new BlockOccupancy(new Vector3i(0, 6, 1)),
                new BlockOccupancy(new Vector3i(0, 7, -1)),
                new BlockOccupancy(new Vector3i(0, 7, 0)),
                new BlockOccupancy(new Vector3i(0, 7, 1)),
                new BlockOccupancy(new Vector3i(0, 8, -1)),
                new BlockOccupancy(new Vector3i(0, 8, 0)),
                new BlockOccupancy(new Vector3i(0, 8, 1)),
                new BlockOccupancy(new Vector3i(0, 9, -1)),
                new BlockOccupancy(new Vector3i(0, 9, 0)),
                new BlockOccupancy(new Vector3i(0, 9, 1)),
                new BlockOccupancy(new Vector3i(1, 0, -1)),
                new BlockOccupancy(new Vector3i(1, 0, 0)),
                new BlockOccupancy(new Vector3i(1, 0, 1)),
                new BlockOccupancy(new Vector3i(1, 1, -1)),
                new BlockOccupancy(new Vector3i(1, 1, 0)),
                new BlockOccupancy(new Vector3i(1, 1, 1)),
                new BlockOccupancy(new Vector3i(1, 2, -1)),
                new BlockOccupancy(new Vector3i(1, 2, 0)),
                new BlockOccupancy(new Vector3i(1, 2, 1)),
                new BlockOccupancy(new Vector3i(1, 3, -1)),
                new BlockOccupancy(new Vector3i(1, 3, 0)),
                new BlockOccupancy(new Vector3i(1, 3, 1)),
                new BlockOccupancy(new Vector3i(1, 4, -1)),
                new BlockOccupancy(new Vector3i(1, 4, 0)),
                new BlockOccupancy(new Vector3i(1, 4, 1)),
                new BlockOccupancy(new Vector3i(1, 5, -1)),
                new BlockOccupancy(new Vector3i(1, 5, 0)),
                new BlockOccupancy(new Vector3i(1, 5, 1)),
                new BlockOccupancy(new Vector3i(1, 6, -1)),
                new BlockOccupancy(new Vector3i(1, 6, 0)),
                new BlockOccupancy(new Vector3i(1, 6, 1)),
                new BlockOccupancy(new Vector3i(1, 7, -1)),
                new BlockOccupancy(new Vector3i(1, 7, 0)),
                new BlockOccupancy(new Vector3i(1, 7, 1)),
                new BlockOccupancy(new Vector3i(1, 8, -1)),
                new BlockOccupancy(new Vector3i(1, 8, 0)),
                new BlockOccupancy(new Vector3i(1, 8, 1)),
                new BlockOccupancy(new Vector3i(1, 9, -1)),
                new BlockOccupancy(new Vector3i(1, 9, 0)),
                new BlockOccupancy(new Vector3i(1, 9, 1)),
                new BlockOccupancy(new Vector3i(2, 0, -1)),
                new BlockOccupancy(new Vector3i(2, 0, 0)),
                new BlockOccupancy(new Vector3i(2, 0, 1)),
                new BlockOccupancy(new Vector3i(2, 1, -1)),
                new BlockOccupancy(new Vector3i(2, 1, 0)),
                new BlockOccupancy(new Vector3i(2, 1, 1)),
                new BlockOccupancy(new Vector3i(2, 2, -1)),
                new BlockOccupancy(new Vector3i(2, 2, 0)),
                new BlockOccupancy(new Vector3i(2, 2, 1)),
                new BlockOccupancy(new Vector3i(2, 3, -1)),
                new BlockOccupancy(new Vector3i(2, 3, 0)),
                new BlockOccupancy(new Vector3i(2, 3, 1)),
                new BlockOccupancy(new Vector3i(2, 4, -1)),
                new BlockOccupancy(new Vector3i(2, 4, 0)),
                new BlockOccupancy(new Vector3i(2, 4, 1)),
                new BlockOccupancy(new Vector3i(2, 5, -1)),
                new BlockOccupancy(new Vector3i(2, 5, 0)),
                new BlockOccupancy(new Vector3i(2, 5, 1)),
                new BlockOccupancy(new Vector3i(2, 6, -1)),
                new BlockOccupancy(new Vector3i(2, 6, 0)),
                new BlockOccupancy(new Vector3i(2, 6, 1)),
                new BlockOccupancy(new Vector3i(2, 7, -1)),
                new BlockOccupancy(new Vector3i(2, 7, 0)),
                new BlockOccupancy(new Vector3i(2, 7, 1)),
                new BlockOccupancy(new Vector3i(2, 8, -1)),
                new BlockOccupancy(new Vector3i(2, 8, 0)),
                new BlockOccupancy(new Vector3i(2, 8, 1)),
                new BlockOccupancy(new Vector3i(2, 9, -1)),
                new BlockOccupancy(new Vector3i(2, 9, 0)),
                new BlockOccupancy(new Vector3i(2, 9, 1)),
            };

            AddOccupancy<StairOutdoorObject>(BlockOccupancyList);
        }
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = StairOutdoorItem.homeValue;
            this.GetComponent<MountComponent>().Initialize(2);
            this.ModsPostInitialize();
        }
        protected override void OnCreatePostInitialize()
        {
            base.OnCreatePostInitialize();
            this.GetComponent<PropertyAuthComponent>().SetPublic();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Stair Outdoor")]
    [LocDescription("Stair for your outdoor !")]
    [Ecopedia("Housing Objects", "Living Room", createAsSubPage: true)]
    [Tag("Housing")]
    [Tag("Mountable")]
    [Weight(2000)]
    [Tag(nameof(SurfaceTags.CanBeOnSurface))]
    public partial class StairOutdoorItem : WorldObjectItem<StairOutdoorObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(StairOutdoorObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Outdoor"),
            BaseValue = 3,
            TypeForRoomLimit = Localizer.DoStr("Stair"),
            DiminishingReturnMultiplier = 0.9f
        };
    }

    [RequiresSkill(typeof(BlacksmithSkill), 6)]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "Stair Outdoor Item")]
    public partial class StairOutdoorRecipe : RecipeFamily
    {
        public StairOutdoorRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "StairOutdoor",
                displayName: Localizer.DoStr("Stair Outdoor"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 20, typeof(BlacksmithSkill)),
                    new IngredientElement(typeof(SteelBarItem), 10, typeof(BlacksmithSkill)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<StairOutdoorItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(160, typeof(BlacksmithSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(StairOutdoorRecipe), start: 10, skillType: typeof(BlacksmithSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Stair Outdoor"), recipeType: typeof(StairOutdoorRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(MountComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(6)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "StairInside Item")]
    public partial class StairInsideObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(StairInsideItem);
        public override LocString DisplayName => Localizer.DoStr("StairInside");
        public override TableTextureMode TableTexture => TableTextureMode.Canvas;
        static StairInsideObject()
        {
            var BlockOccupancyList = new List<BlockOccupancy>
            {
                new BlockOccupancy(new Vector3i(0, 0, -1)),
                new BlockOccupancy(new Vector3i(0, 0, 0)),
                new BlockOccupancy(new Vector3i(0, 1, -1)),
                new BlockOccupancy(new Vector3i(0, 1, 0)),
                new BlockOccupancy(new Vector3i(1, 0, -1)),
                new BlockOccupancy(new Vector3i(1, 0, 0)),
                new BlockOccupancy(new Vector3i(1, 1, -1)),
                new BlockOccupancy(new Vector3i(1, 1, 0)),
            };

            AddOccupancy<StairInsideObject>(BlockOccupancyList);
        }
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = StairInsideItem.homeValue;
            this.GetComponent<MountComponent>().Initialize(2);
            this.ModsPostInitialize();
        }
        protected override void OnCreatePostInitialize()
        {
            base.OnCreatePostInitialize();
            this.GetComponent<PropertyAuthComponent>().SetPublic();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Stair Inside")]
    [LocDescription("Stair for your room !")]
    [Ecopedia("Housing Objects", "Living Room", createAsSubPage: true)]
    [Tag("Housing")]
    [Tag("Mountable")]
    [Weight(2000)]
    [Tag(nameof(SurfaceTags.CanBeOnSurface))]
    public partial class StairInsideItem : WorldObjectItem<StairInsideObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(StairInsideObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Living Room"),
            BaseValue = 2,
            TypeForRoomLimit = Localizer.DoStr("Stair"),
            DiminishingReturnMultiplier = 0.6f
        };
    }

    [RequiresSkill(typeof(CarpentrySkill), 6)]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "Stair Inside Item")]
    public partial class StairInsideRecipe : RecipeFamily
    {
        public StairInsideRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "StairInside",
                displayName: Localizer.DoStr("Stair Inside"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 20, typeof(CarpentrySkill)),
                    new IngredientElement("Lumber", 4, typeof(CarpentrySkill)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<StairInsideItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(160, typeof(CarpentrySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(StairInsideRecipe), start: 10, skillType: typeof(CarpentrySkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Stair Inside"), recipeType: typeof(StairInsideRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }



    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(MountComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(6)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "U-ShapedStaircase Item")]
    public partial class UShapedStaircaseObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(UShapedStaircaseItem);
        public override LocString DisplayName => Localizer.DoStr("U-ShapedStaircase");
        public override TableTextureMode TableTexture => TableTextureMode.Canvas;
        static UShapedStaircaseObject()
        {
            var BlockOccupancyList = new List<BlockOccupancy>
            {
 //       new BlockOccupancy(new Vector3i(-1, 0, 0)),
 //       new BlockOccupancy(new Vector3i(-1, 0, 1)), 
        new BlockOccupancy(new Vector3i(-1, 0, 2)), //
        new BlockOccupancy(new Vector3i(-1, 0, 3)),//
        new BlockOccupancy(new Vector3i(-1, 1, 0)),
        new BlockOccupancy(new Vector3i(-1, 1, 1)),
        new BlockOccupancy(new Vector3i(-1, 1, 2)),
        new BlockOccupancy(new Vector3i(-1, 1, 3)),
        new BlockOccupancy(new Vector3i(-1, 2, 0)),
        new BlockOccupancy(new Vector3i(-1, 2, 1)),
        new BlockOccupancy(new Vector3i(-1, 2, 2)),
        new BlockOccupancy(new Vector3i(-1, 2, 3)),
        new BlockOccupancy(new Vector3i(-1, 3, 0)),
        new BlockOccupancy(new Vector3i(-1, 3, 1)),
        new BlockOccupancy(new Vector3i(-1, 3, 2)),
 //       new BlockOccupancy(new Vector3i(-1, 3, 3)),
        new BlockOccupancy(new Vector3i(-1, 4, 0)),
        new BlockOccupancy(new Vector3i(-1, 4, 1)),
//        new BlockOccupancy(new Vector3i(-1, 4, 2)),
 //       new BlockOccupancy(new Vector3i(-1, 4, 3)),
 //       new BlockOccupancy(new Vector3i(0, 0, 0)),
        new BlockOccupancy(new Vector3i(0, 0, 1)),
        new BlockOccupancy(new Vector3i(0, 0, 2)),
        new BlockOccupancy(new Vector3i(0, 0, 3)),
        new BlockOccupancy(new Vector3i(0, 1, 0)),
        new BlockOccupancy(new Vector3i(0, 1, 1)),
        new BlockOccupancy(new Vector3i(0, 1, 2)),
        new BlockOccupancy(new Vector3i(0, 1, 3)),
        new BlockOccupancy(new Vector3i(0, 2, 0)),
        new BlockOccupancy(new Vector3i(0, 2, 1)),
        new BlockOccupancy(new Vector3i(0, 2, 2)),
        new BlockOccupancy(new Vector3i(0, 2, 3)),
       new BlockOccupancy(new Vector3i(0, 3, 0)),
        new BlockOccupancy(new Vector3i(0, 3, 1)),
        new BlockOccupancy(new Vector3i(0, 3, 2)),
 //       new BlockOccupancy(new Vector3i(0, 3, 3)),
       new BlockOccupancy(new Vector3i(0, 4, 0)),
        new BlockOccupancy(new Vector3i(0, 4, 1)),
//        new BlockOccupancy(new Vector3i(0, 4, 2)),
//        new BlockOccupancy(new Vector3i(0, 4, 3)),
//        new BlockOccupancy(new Vector3i(1, 0, 0)),
//        new BlockOccupancy(new Vector3i(1, 0, 1)),
//        new BlockOccupancy(new Vector3i(1, 0, 2)),
//        new BlockOccupancy(new Vector3i(1, 0, 3)),
//        new BlockOccupancy(new Vector3i(1, 1, 0)),
//        new BlockOccupancy(new Vector3i(1, 1, 1)),
//        new BlockOccupancy(new Vector3i(1, 1, 2)),
//        new BlockOccupancy(new Vector3i(1, 1, 3)),
        new BlockOccupancy(new Vector3i(1, 2, 0)),
        new BlockOccupancy(new Vector3i(1, 2, 1)),
//        new BlockOccupancy(new Vector3i(1, 2, 2)),
//        new BlockOccupancy(new Vector3i(1, 2, 3)),
        new BlockOccupancy(new Vector3i(1, 3, 0)),
        new BlockOccupancy(new Vector3i(1, 3, 1)),
        new BlockOccupancy(new Vector3i(1, 3, 2)),
 //       new BlockOccupancy(new Vector3i(1, 3, 3)),
        new BlockOccupancy(new Vector3i(1, 4, 0)),
        new BlockOccupancy(new Vector3i(1, 4, 1)),
//        new BlockOccupancy(new Vector3i(1, 4, 2)),
//        new BlockOccupancy(new Vector3i(1, 4, 3)),
        new BlockOccupancy(new Vector3i(1, 5, 1)), 
        new BlockOccupancy(new Vector3i(1, 5, 2)), 
//        new BlockOccupancy(new Vector3i(2, 0, 0)),
//        new BlockOccupancy(new Vector3i(2, 0, 1)),
//        new BlockOccupancy(new Vector3i(2, 0, 2)),
//        new BlockOccupancy(new Vector3i(2, 0, 3)),
//        new BlockOccupancy(new Vector3i(2, 1, 0)),
//        new BlockOccupancy(new Vector3i(2, 1, 1)),
//        new BlockOccupancy(new Vector3i(2, 1, 2)),
 //       new BlockOccupancy(new Vector3i(2, 1, 3)),
//        new BlockOccupancy(new Vector3i(2, 2, 0)),
//        new BlockOccupancy(new Vector3i(2, 2, 1)),
//        new BlockOccupancy(new Vector3i(2, 2, 2)),
 //       new BlockOccupancy(new Vector3i(2, 2, 3)),
        new BlockOccupancy(new Vector3i(2, 3, 0)),
        new BlockOccupancy(new Vector3i(2, 3, 1)),
        new BlockOccupancy(new Vector3i(2, 3, 2)),
 //       new BlockOccupancy(new Vector3i(2, 3, 3)),
        new BlockOccupancy(new Vector3i(2, 4, 0)),
        new BlockOccupancy(new Vector3i(2, 4, 1)),
        new BlockOccupancy(new Vector3i(2, 4, 2)),
 //       new BlockOccupancy(new Vector3i(2, 4, 3)),  
//        new BlockOccupancy(new Vector3i(2, 5, 0)), 
        new BlockOccupancy(new Vector3i(2, 5, 1)), 
        new BlockOccupancy(new Vector3i(2, 5, 2)), 		
//        new BlockOccupancy(new Vector3i(2, 5, 3)), 
 
            };

            AddOccupancy<UShapedStaircaseObject>(BlockOccupancyList);
        }
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = UShapedStaircaseItem.homeValue;
            this.GetComponent<MountComponent>().Initialize(2);
            this.ModsPostInitialize();
        }
        protected override void OnCreatePostInitialize()
        {
            base.OnCreatePostInitialize();
            this.GetComponent<PropertyAuthComponent>().SetPublic();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("U-Shaped Staircase")]
    [LocDescription("Stair for your room !")]
    [Ecopedia("Housing Objects", "Living Room", createAsSubPage: true)]
    [Tag("Housing")]
    [Tag("Mountable")]
    [Weight(2000)]
    [Tag(nameof(SurfaceTags.CanBeOnSurface))]
    public partial class UShapedStaircaseItem : WorldObjectItem<UShapedStaircaseObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(UShapedStaircaseObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Living Room"),
            BaseValue = 5,
            TypeForRoomLimit = Localizer.DoStr("Stair"),
            DiminishingReturnMultiplier = 0.9f
        };
    }

    [RequiresSkill(typeof(CarpentrySkill), 6)]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "U-Shaped Staircase Item")]
    public partial class UShapedStaircaseRecipe : RecipeFamily
    {
        public UShapedStaircaseRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "UShapedStaircase",
                displayName: Localizer.DoStr("U-Shaped Staircase"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GlassItem), 13, typeof(CarpentrySkill)),
                    new IngredientElement("Lumber", 9, typeof(CarpentrySkill)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<UShapedStaircaseItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(160, typeof(CarpentrySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(UShapedStaircaseRecipe), start: 10, skillType: typeof(CarpentrySkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("U-Shaped Staircase"), recipeType: typeof(UShapedStaircaseRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }



    // Classe IModInit - comme dans IceCream.cs
    public class StairMod : IModInit
    {
        public static ModRegistration Register() => new()
        {
            ModName = "StairMod",
            ModDescription = "This mod adds Multiple Stair",
            ModDisplayName = "Stair Mod",
        };
    }
	
	    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(MountComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(6)]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "StairAngle Item")]
            public partial class StairAngleObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(StairAngleItem);
        public override LocString DisplayName => Localizer.DoStr("StairAngle");
        public override TableTextureMode TableTexture => TableTextureMode.Canvas;
static StairAngleObject()
{
    var BlockOccupancyList = new List<BlockOccupancy>
    {
        new BlockOccupancy(new Vector3i(-2, 0, -1)),
        new BlockOccupancy(new Vector3i(-2, 0, 0)),
        new BlockOccupancy(new Vector3i(-2, 1, -1)),
        new BlockOccupancy(new Vector3i(-2, 1, 0)),
        new BlockOccupancy(new Vector3i(-2, 2, -1)),
        new BlockOccupancy(new Vector3i(-2, 2, 0)),
        new BlockOccupancy(new Vector3i(-2, 3, -1)),
        new BlockOccupancy(new Vector3i(-2, 3, 0)),
        new BlockOccupancy(new Vector3i(-1, 0, -1)),
        new BlockOccupancy(new Vector3i(-1, 0, 0)),
        new BlockOccupancy(new Vector3i(-1, 1, -1)),
        new BlockOccupancy(new Vector3i(-1, 1, 0)),
        new BlockOccupancy(new Vector3i(-1, 2, -1)),
        new BlockOccupancy(new Vector3i(-1, 2, 0)),
        new BlockOccupancy(new Vector3i(-1, 3, -1)),
        new BlockOccupancy(new Vector3i(-1, 3, 0)),
        new BlockOccupancy(new Vector3i(0, 0, -1)),
        new BlockOccupancy(new Vector3i(0, 0, 0)),
        new BlockOccupancy(new Vector3i(0, 1, -1)),
        new BlockOccupancy(new Vector3i(0, 1, 0)),
        new BlockOccupancy(new Vector3i(0, 2, -1)),
        new BlockOccupancy(new Vector3i(0, 2, 0)),
        new BlockOccupancy(new Vector3i(0, 3, -1)),
        new BlockOccupancy(new Vector3i(0, 3, 0)),
        new BlockOccupancy(new Vector3i(1, 0, -1)),
        new BlockOccupancy(new Vector3i(1, 0, 0)),
        new BlockOccupancy(new Vector3i(1, 1, -1)),
        new BlockOccupancy(new Vector3i(1, 1, 0)),
        new BlockOccupancy(new Vector3i(1, 2, -1)),
        new BlockOccupancy(new Vector3i(1, 2, 0)),
        new BlockOccupancy(new Vector3i(1, 3, -1)),
        new BlockOccupancy(new Vector3i(1, 3, 0)),      };

    AddOccupancy<StairAngleObject>(BlockOccupancyList);
}
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = StairAngleItem.homeValue;
            this.GetComponent<MountComponent>().Initialize(2);
            this.ModsPostInitialize();
        }
        protected override void OnCreatePostInitialize()
        {
            base.OnCreatePostInitialize();
            this.GetComponent<PropertyAuthComponent>().SetPublic();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Stair Angle")]
    [LocDescription("Stair for your room !")]
    [Ecopedia("Housing Objects", "Living Room", createAsSubPage: true)]
    [Tag("Housing")]
    [Tag("Mountable")]
    [Weight(2000)] // Defines how heavy StairAngle is.
    [Tag(nameof(SurfaceTags.CanBeOnSurface))] 
        public partial class StairAngleItem : WorldObjectItem<StairAngleObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext( 0  | DirectionAxisFlags.Down , WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName                              = typeof(StairAngleObject).UILink(),
            Category                                = HousingConfig.GetRoomCategory("Living Room"),
            BaseValue                               = 2,
            TypeForRoomLimit                        = Localizer.DoStr("Stair"),
            DiminishingReturnMultiplier             = 0.6f
            
        };

    }
	[RequiresSkill(typeof(CarpentrySkill), 6)]
    [Ecopedia("Housing Objects", "Living Room", subPageName: "Stair Angle Item")]
    public partial class StairAngleRecipe : RecipeFamily
    {
        public StairAngleRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "StairAngle",  //noloc
                displayName: Localizer.DoStr("Stair Angle"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 20, typeof(CarpentrySkill)), //noloc
					new IngredientElement("Lumber", 5,typeof(CarpentrySkill)), //noloc
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<StairAngleItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(160, typeof(CarpentrySkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(StairAngleRecipe), start: 10, skillType: typeof(CarpentrySkill));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "StairAngle"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Stair Angle"), recipeType: typeof(StairAngleRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
	
	
}