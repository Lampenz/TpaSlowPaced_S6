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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Golden Gothic Garden Door Item")]
    public partial class GoldenGothicGardenDoorObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(GoldenGothicGardenDoorItem);

        public override LocString DisplayName => Localizer.DoStr("Golden Gothic Garden Door");

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public override bool HasTier => true;

        public override int Tier => 2;

        static GoldenGothicGardenDoorObject()
        {
            AddOccupancy<GoldenGothicGardenDoorObject>(GateOccupancy.GothicGardenDoor);
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
    [LocDisplayName("Golden Gothic Garden Door")]
    [LocDescription("A golden gothic garden door that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(2)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(500)]
    public partial class GoldenGothicGardenDoorItem : WorldObjectItem<GoldenGothicGardenDoorObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [RequiresSkill(typeof(SmeltingSkill), 1)]
    [ForceCreateView]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Golden Gothic Garden Door Item")]
    public partial class GoldenGothicGardenDoorRecipe : Recipe
    {
        public GoldenGothicGardenDoorRecipe()
        {
            this.Init(
                name: "GoldenGothicGardenDoor",  //noloc
                displayName: Localizer.DoStr("Golden Gothic Garden Door"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 2, typeof(SmeltingSkill)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldenGothicGardenDoorItem>()
                });

            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AnvilObject), typeof(IronGothicGardenDoorRecipe), this);
        }

        partial void ModsPostInitialize();
    }
}
