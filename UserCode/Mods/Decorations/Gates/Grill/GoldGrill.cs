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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Gold Grill Item")]
    public partial class GoldGrillObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(GoldGrillItem);

        public override LocString DisplayName => Localizer.DoStr("Gold Grill");

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public override bool HasTier => true;

        public override int Tier => 0;

        static GoldGrillObject()
        {
            AddOccupancy<GoldGrillObject>(GateOccupancy.Grill);
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
    [LocDisplayName("Gold Grill")]
    [LocDescription("A gold grill that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(0)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(500)]
    public partial class GoldGrillItem : WorldObjectItem<GoldGrillObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }


    [RequiresSkill(typeof(BlacksmithSkill), 2)]
    [ForceCreateView]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Gold Grill Item")]
    public partial class GoldGrillRecipe : Recipe
    {
        public GoldGrillRecipe()
        {
            this.Init(
                name: "GoldGrill",  //noloc
                displayName: Localizer.DoStr("Gold Grill"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 5, typeof(BlacksmithSkill)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldGrillItem>()
                });

            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AnvilObject), typeof(IronGrillRecipe), this);
        }


        /// <summary>Hook for mods to customize Recipe after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
