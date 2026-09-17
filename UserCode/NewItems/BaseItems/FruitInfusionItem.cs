namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Time;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Fruit Infusion")] // Defines the localized name of the item.
    [Weight(100)] // Defines how heavy the FruitInfusion is.
    [Ecopedia("Food", "Campfire", createAsSubPage: true)]
    [LocDescription("A heated fruitcocktail which mystical refreshing powers.")] //The tooltip description for the food item.
    public partial class FruitInfusionItem : FoodItem
    {
        // Prevent this item from being put on a table.
        public override bool CanBeHeld                  => false;

        /// <summary>The plural localization name for the food item.</summary>
        public override LocString DisplayNamePlural     => Localizer.DoStr("Fruit Infusion");

        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories                  => 650;

        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 5, Protein = 0, Vitamins = 12};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        public override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(72);
    }
}
