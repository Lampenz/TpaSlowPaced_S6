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
    [Ecopedia("Housing Objects", "Doors", subPageName: "Copper Grill Item")]
    public partial class CopperGrillObject : GateBaseObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(CopperGrillItem);

        public override LocString DisplayName => Localizer.DoStr("Copper Grill");

        public override TableTextureMode TableTexture => TableTextureMode.Metal;

        public override bool HasTier => true;

        public override int Tier => 0;

        static CopperGrillObject()
        {
            AddOccupancy<CopperGrillObject>(GateOccupancy.Grill);
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
    [LocDisplayName("Copper Grill")]
    [LocDescription("A copper grill that can be opened and closed to control access through doorways.")]
    [IconGroup("World Object Minimap")]
    [Tier(0)]
    [Ecopedia("Housing Objects", "Doors", createAsSubPage: true)]
    [Weight(500)]
    public partial class CopperGrillItem : WorldObjectItem<CopperGrillObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }


    [RequiresSkill(typeof(BlacksmithSkill), 2)]
    [ForceCreateView]
    [Ecopedia("Housing Objects", "Doors", subPageName: "Copper Grill Item")]
    public partial class CopperGrillRecipe : Recipe
    {
        public CopperGrillRecipe()
        {
            this.Init(
                name: "CopperGrill",  //noloc
                displayName: Localizer.DoStr("Copper Grill"),

                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CopperBarItem), 5, typeof(BlacksmithSkill)),
                },

                items: new List<CraftingElement>
                {
                    new CraftingElement<CopperGrillItem>()
                });

            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AnvilObject), typeof(IronGrillRecipe), this);
        }


        /// <summary>Hook for mods to customize Recipe after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
