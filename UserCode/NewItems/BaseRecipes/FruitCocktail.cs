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

    [RequiresSkill(typeof(GatheringSkill), 5)]
    [Ecopedia("Food", "Campfire", subPageName: "Fruit Cocktail Item")]
    public partial class FruitCocktailRecipe : RecipeFamily
    {
        public FruitCocktailRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FruitCocktail",  //noloc
                displayName: Localizer.DoStr("Fruit Cocktail"),

                //Input + talents
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PapayaItem), 1, typeof(GatheringSkill)),
                    new IngredientElement(typeof(HuckleberriesItem), 3, typeof(GatheringSkill)),
                    new IngredientElement(typeof(CoconutItem), 1, typeof(GatheringSkill)),
                },

                //Output
                items: new List<CraftingElement>
                {
                    new CraftingElement<FruitCocktailItem>(1.1f)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(15, typeof(GatheringSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FruitCocktailRecipe), start: 1, skillType: typeof(GatheringSkill));


            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Fern Campfire Salad"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Fruit cocktail"), recipeType: typeof(FruitCocktailRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(ArrastraObject), recipeFamily: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
