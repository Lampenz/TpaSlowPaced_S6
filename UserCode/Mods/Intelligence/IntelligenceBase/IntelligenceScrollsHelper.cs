namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;

    public static class IntelligenceScrollsHelper
    {
        public const int ScrollOutputAmount = 2;
        public const float IngredientCostMultiplier = 1.0f;

        public static void ConfigurePreInitialize<TScroll>(
            RecipeFamily recipeFamily,
            params IngredientElement[] additionalIngredients)
            where TScroll : Item, new()
        {
            var recipe = recipeFamily.Recipes[0];

            ConfigureScrollOutput<TScroll>(recipe);

            ConfigureIngredients(recipe);

            foreach (var ingredient in additionalIngredients)
                recipe.Ingredients.Add(ingredient);
        }

        public static void ConfigurePostInitialize(
            RecipeFamily recipeFamily,
            Type skillType)
        {
            ConfigureSkillRequirement(recipeFamily, skillType);
            ConfigureRecipeName(recipeFamily);
        }

        private static void ConfigureScrollOutput<TScroll>(Recipe recipe)
            where TScroll : Item, new()
        {
            recipe.Products.Clear();

            recipe.Products.Add(
                new CraftingElement<TScroll>(ScrollOutputAmount));
        }

        private static void ConfigureIngredients(Recipe recipe)
        {
            for (int i = 0; i < recipe.Ingredients.Count; i++)
            {
                var ingredient = recipe.Ingredients[i];

                var quantity =
                    ingredient.Quantity.GetBaseValue *
                    IngredientCostMultiplier;

                recipe.Ingredients[i] = ingredient.IsSpecificItem
                    ? new IngredientElement(
                        ingredient.ItemRepresentation,
                        quantity,
                        true)
                    : new IngredientElement(
                        ingredient.InnerName,
                        quantity,
                        true);
            }
        }

        private static void ConfigureSkillRequirement(
            RecipeFamily recipeFamily,
            Type skillType)
        {
            if (recipeFamily.RequiredSkills == null ||
                recipeFamily.RequiredSkills.Length == 0)
            {
                throw new InvalidOperationException(
                    $"No skill requirement found on {recipeFamily.GetType().FullName}.");
            }

            var requirement = recipeFamily.RequiredSkills[0];

            var skillTypeProperty =
                typeof(BaseRequiresSkillAttribute)
                    .GetProperty(
                        nameof(BaseRequiresSkillAttribute.SkillType));

            var levelProperty =
                typeof(BaseRequiresSkillAttribute)
                    .GetProperty(
                        nameof(BaseRequiresSkillAttribute.Level));

            if (skillTypeProperty == null || levelProperty == null)
            {
                throw new InvalidOperationException(
                    "Could not access SkillType or Level on BaseRequiresSkillAttribute.");
            }

            if (!SkillBookIntelligenceRequirements.BySkillName
                    .TryGetValue(skillType.Name, out var level))
            {
                throw new KeyNotFoundException(
                    $"No Intelligence skill requirement configured for '{skillType.Name}'.");
            }

            skillTypeProperty.SetValue(
                requirement,
                typeof(IntelligenceSkill));

            levelProperty.SetValue(
                requirement,
                level);
        }

        private static void ConfigureRecipeName(
            RecipeFamily recipeFamily)
        {
            var recipe = recipeFamily.Recipes[0];

            var name =
                $"{recipe.Name.AddSpacesBetweenCapitals()} Skill Scroll";

            var property =
                typeof(RecipeFamily).GetProperty(
                    nameof(RecipeFamily.RecipeName));

            if (property == null)
            {
                throw new InvalidOperationException(
                    "Could not find RecipeFamily.RecipeName.");
            }

            property.SetValue(recipeFamily, name);
        }
    }
}