using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Wires;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using EcoPulse.Gates;
using System;
using System.Collections.Generic;

namespace Eco.Mods.TechTree
{
    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [MustBeGridAligned]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Hewn Double Door Item")]
    public partial class HewnDoubleDoorObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(HewnDoubleDoorItem);

        public override LocString DisplayName => Localizer.DoStr("Hewn Double Door");

        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        public override bool HasTier => true;

        public override int Tier => 2;

        static HewnDoubleDoorObject()
        {
            AddOccupancy<HewnDoubleDoorObject>(GateOccupancy.DoubleDoor);
        }


        protected override void Initialize()
        {
            this.ModsPreInitialize();
            base.Initialize();
            this.ModsPostInitialize();

        }


        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Hewn Double Door")]
    [LocDescription("A hewn double door that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(2)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(600)]
    public partial class HewnDoubleDoorItem : WorldObjectItem<HewnDoubleDoorObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }


    [RequiresSkill(typeof(CarpentrySkill), 2)]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Hewn Double Door Item")]
    public partial class HewnDoubleDoorRecipe : RecipeFamily
    {
        public HewnDoubleDoorRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "HewnDoubleDoor",  //noloc
                displayName: Localizer.DoStr("Hewn Double Door"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 4, typeof(CarpentrySkill)),
                    new IngredientElement("HewnLog", 3, typeof(CarpentrySkill)),
                    new IngredientElement("WoodBoard", 6, typeof(CarpentrySkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<HewnDoubleDoorItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;

            this.LaborInCalories = CreateLaborInCaloriesValue(150, typeof(CarpentrySkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(HewnDoubleDoorRecipe), start: 2, skillType: typeof(CarpentrySkill));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Hewn Double Door"), recipeType: typeof(HewnDoubleDoorRecipe));
            this.ModsPostInitialize();


            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
