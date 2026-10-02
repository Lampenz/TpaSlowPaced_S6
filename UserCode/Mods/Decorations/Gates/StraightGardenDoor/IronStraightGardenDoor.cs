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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Iron Straight Garden Door Item")]
    public partial class IronStraightGardenDoorObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(IronStraightGardenDoorItem);

        public override LocString DisplayName => Localizer.DoStr("Iron Straight Garden Door");

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public override bool HasTier => true;

        public override int Tier => 2;

        static IronStraightGardenDoorObject()
        {
            AddOccupancy<IronStraightGardenDoorObject>(GateOccupancy.StraightGardenDoor);
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
    [LocDisplayName("Iron Straight Garden Door")]
    [LocDescription("An iron straight garden door that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(2)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(500)]
    public partial class IronStraightGardenDoorItem : WorldObjectItem<IronStraightGardenDoorObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [RequiresSkill(typeof(SmeltingSkill), 1)]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Iron Straight Garden Door Item")]
    public partial class IronStraightGardenDoorRecipe : RecipeFamily
    {
        public IronStraightGardenDoorRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronStraightGardenDoor",  //noloc
                displayName: Localizer.DoStr("Iron Straight Garden Door"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(SmeltingSkill)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<IronStraightGardenDoorItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;

            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronStraightGardenDoorRecipe), start: 2, skillType: typeof(SmeltingSkill));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Iron Straight Garden Door"), recipeType: typeof(IronStraightGardenDoorRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
