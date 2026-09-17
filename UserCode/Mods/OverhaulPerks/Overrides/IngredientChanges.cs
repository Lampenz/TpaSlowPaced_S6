namespace Eco.Mods.TechTree
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
    using Eco.Gameplay.Garbage;
	using System.Linq;
	
	public partial class WoodenHullPlanksRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement("HewnLog", 2,typeof(ShipwrightSkill) ) );
        }
    }
	
	
	
	
	
	
	
	
	
	
	
	public partial class IronAxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronHammerRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronHoeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronMacheteRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronPickaxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronShovelRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	public partial class IronSickleRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 2, typeof(BlacksmithSkill)));
        }
    }
	
	public partial class SteelAxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelHammerRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelHoeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelMacheteRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelPickaxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelShovelRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	public partial class SteelSickleRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 4, typeof(BlacksmithSkill)));
        }
    }
	
	
	
	public partial class ModernAxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernHammerRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernHoeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernMacheteRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernPickaxeRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernShovelRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	public partial class ModernScytheRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ParaffinItem), 1, typeof(BlacksmithSkill)));
        }
    }
	
	
	
	public partial class CompositeLumberRecipe
    {
        partial void ModsPreInitialize()
        {
            var recipe = this.Recipes[0];

            recipe.Ingredients.Add(
                new IngredientElement(typeof(ResinItem), 1, typeof(CompositesSkill)));
        }
    }
	
	
}