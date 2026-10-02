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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Iron Grill Item")]
    public partial class IronGrillObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(IronGrillItem);

        public override LocString DisplayName => Localizer.DoStr("Iron Grill");

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public override bool HasTier => true;

        public override int Tier => 0;

        static IronGrillObject()
        {
            AddOccupancy<IronGrillObject>(GateOccupancy.Grill);
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
    [LocDisplayName("Iron Grill")]
    [LocDescription("An iron grill that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(0)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(500)]
    public partial class IronGrillItem : WorldObjectItem<IronGrillObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }


    [RequiresSkill(typeof(BlacksmithSkill), 2)]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Iron Grill Item")]
    public partial class IronGrillRecipe : RecipeFamily
    {
        public IronGrillRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "IronGrill",  //noloc
                displayName: Localizer.DoStr("Iron Grill"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 5, typeof(BlacksmithSkill)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<IronGrillItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3;

            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(BlacksmithSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(IronGrillRecipe), start: 4, skillType: typeof(BlacksmithSkill));

            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Grill"), recipeType: typeof(IronGrillRecipe));
            this.ModsPostInitialize();


            CraftingComponent.AddRecipe(tableType: typeof(AnvilObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
