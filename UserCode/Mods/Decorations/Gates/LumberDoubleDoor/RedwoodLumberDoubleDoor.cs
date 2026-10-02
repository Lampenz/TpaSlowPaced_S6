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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Redwood Lumber Double Door Item")]
    public partial class RedwoodLumberDoubleDoorObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(RedwoodLumberDoubleDoorItem);

        public override LocString DisplayName => Localizer.DoStr("Redwood Lumber Double Door");

        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        public override bool HasTier => true;

        public override int Tier => 3;

        static RedwoodLumberDoubleDoorObject()
        {
            AddOccupancy<RedwoodLumberDoubleDoorObject>(GateOccupancy.DoubleDoor);
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
    [LocDisplayName("Redwood Lumber Double Door")]
    [LocDescription("A Redwood lumber double door that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(3)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(600)]
    public partial class RedwoodLumberDoubleDoorItem : WorldObjectItem<RedwoodLumberDoubleDoorObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }


    [RequiresSkill(typeof(CarpentrySkill), 2)]
    [ForceCreateView]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Redwood Lumber Double Door Item")]
    public partial class RedwoodLumberDoubleDoorRecipe : Recipe
    {
        public RedwoodLumberDoubleDoorRecipe()
        {
            this.Init(
                name: "RedwoodLumberDoubleDoor",  //noloc
                displayName: Localizer.DoStr("Redwood Lumber Double Door"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RedwoodLogItem), 4, typeof(CarpentrySkill)),
                    new IngredientElement("Lumber", 3, typeof(CarpentrySkill)),
                    new IngredientElement("WoodBoard", 6, typeof(CarpentrySkill))
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<RedwoodLumberDoubleDoorItem>()
                });

            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(SawmillObject), typeof(LumberDoubleDoorRecipe), this);
        }


        /// <summary>Hook for mods to customize Recipe after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}


