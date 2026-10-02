
namespace EcoPulse.StatueMod
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
    using Eco.Mods.TechTree;

    [Serialized]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [Ecopedia("Housing Objects", "Outdoor", subPageName: "Golden Dolphin Statue Item")]
    public partial class GoldenDolphinStatueObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(GoldenDolphinStatueItem);
        public override LocString DisplayName => Localizer.DoStr("Golden Dolphin Statue");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;


        static GoldenDolphinStatueObject()
        {
            WorldObject.AddOccupancy<GoldenDolphinStatueObject>(DolphinStatue.GetOccupency());

        }
        protected override void Initialize()
        {
            this.ModsPreInitialize();
            this.GetComponent<HousingComponent>().HomeValue = GoldenDolphinStatueItem.homeValue;
            this.ModsPostInitialize();
        }

        /// <summary>Hook for mods to customize WorldObject before initialization. You can change housing values here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize WorldObject after initialization.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Golden Dolphin Statue")]
    [LocDescription("Golden dolphin that's worth its weight in... well, gold - and never needs to worry about market fluctuations!")]
    [Ecopedia("Housing Objects", "Outdoor", createAsSubPage: true)]
    [Tag("Housing")]
    [Weight(5000)] // Defines how heavy GoldenDolphinStatue is.
    public partial class GoldenDolphinStatueItem : WorldObjectItem<GoldenDolphinStatueObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(GoldenDolphinStatueObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Outdoor"),
            BaseValue = 7,
            TypeForRoomLimit = Localizer.DoStr("Statue"),
            DiminishingReturnMultiplier = 0.1f

        };

    }

    /// <summary>
    /// <para>Server side recipe definition for "GoldenDolphinStatue".</para>
    /// <para>More information about RecipeFamily objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.RecipeFamily.html</para>
    /// </summary>
    /// <remarks>
    /// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization. 
    /// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
    /// </remarks>
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 5)]
    [ForceCreateView]
    [Ecopedia("Housing Objects", "Outdoor", subPageName: "Golden Dolphin Statue Item")]
    public partial class GoldenDolphinStatueRecipe : Recipe
    {
        public GoldenDolphinStatueRecipe()
        {
            this.Init(
                name: "GoldenDolphinStatue",  //noloc
                displayName: Localizer.DoStr("Golden Dolphin Statue"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoldBarItem), 40, typeof(AdvancedSmeltingSkill)),
                    new IngredientElement(typeof(PedestalItem), 1, true),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoldenDolphinStatueItem>()
                });

            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(AnvilObject), typeof(GoldenLionStatueRecipe), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

}