using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Items;
using System;

namespace Eco.Mods.TechTree
{
	public static class Utils
    {
        public static void RemoveMolds(RecipeFamily recipeFamily, Type moldItem, int quantity)
        {
            if (recipeFamily.Recipes == null || recipeFamily.Recipes.Count == 0)
                return;

            var recipe = recipeFamily.Recipes[0];

            // Remove mold from products if it exists.
            int productIndex = recipe.Products.FindIndex(x => x.Item.Type == moldItem);

            if (productIndex >= 0)
                recipe.Products.RemoveAt(productIndex);

            // Find mold ingredient.
            int ingredientIndex = recipe.Ingredients.FindIndex(x => x.Item.Type == moldItem);

            if (ingredientIndex >= 0)
            {
                recipe.Ingredients.RemoveAt(ingredientIndex);

                // Re-add the mold with the desired quantity.
                recipe.Ingredients.Add(
                    new IngredientElement(moldItem, quantity, typeof(SmeltingSkill))
                );
            }
        }
    }
    
    public partial class SmeltCopperRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 3);
        }
    }
    
    public partial class CopperBarRecipe : RecipeFamily
    {
		partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 2);
        }
	}
    
    public partial class SmeltGoldRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 2);
        }
	}
    
    public partial class GoldBarRecipe : RecipeFamily
    {
		partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 2);
        }
	}
    
    public partial class SmeltIronRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 2);
        }
	}
    
    public partial class IronBarRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(ClayMoldItem), 2);
        }
	}
    
    public partial class SteelBarRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(CeramicMoldItem), 2);
        }
    }
    
    public partial class CharcoalSteelRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	Utils.RemoveMolds(this, typeof(CeramicMoldItem), 2);
        }
    }
    
    public partial class CeramicMoldRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(ClayMoldItem), 1, true));
        }
    }
}