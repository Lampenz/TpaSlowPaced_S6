namespace RecipePatchFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Garbage;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
	using Eco.Shared.Localization;

    public interface IRecipePatch
    {
        int Order { get; }
        string Id { get; }

        bool AppliesTo(RecipeFamily family);
        void Apply(RecipeFamily family);
    }

    /// <summary>
    /// Low-level/advanced recipe patch.
    ///
    /// Prefer <see cref="SimpleRecipePatch{TRecipeFamily}"/> for normal recipe
    /// changes. Direct mutation of RecipeFamily/Recipe state is intentionally an
    /// escape hatch: the framework only guarantees reconciliation for the state
    /// changed by its supported helper methods.
    /// </summary>
    public abstract class RecipePatch<TRecipeFamily> : IRecipePatch
        where TRecipeFamily : RecipeFamily
    {
        public virtual int Order => 0;

        public virtual string Id =>
            this.GetType().FullName ?? this.GetType().Name;

        public bool AppliesTo(RecipeFamily family) =>
            family is TRecipeFamily;

        public void Apply(RecipeFamily family) =>
            this.Apply((TRecipeFamily)family);

        public abstract void Apply(TRecipeFamily family);
    }

    /// <summary>
    /// Convenience base class for common recipe changes.
    ///
    /// The helper intentionally keeps Eco's ingredient quantity semantics visible:
    ///
    /// AddStaticIngredient<TItem>(...) creates an IngredientElement using the bool
    /// overload, meaning its quantity is static and not affected by resource-cost
    /// skill discounts.
    ///
    /// AddSkillIngredient<TItem, TSkill>(...) creates an IngredientElement using
    /// the skill Type overload, meaning Eco builds the normal skill-modified
    /// quantity.
    /// </summary>
    public abstract class SimpleRecipePatch<TRecipeFamily> : RecipePatch<TRecipeFamily>
        where TRecipeFamily : RecipeFamily
    {
        private TRecipeFamily currentFamily;

        public sealed override void Apply(TRecipeFamily family)
        {
            this.currentFamily = family;

            try
            {
                this.Modify();
            }
            finally
            {
                this.currentFamily = null;
            }
        }

        /// <summary>
        /// Put the actual recipe modifications here.
        /// </summary>
        protected abstract void Modify();
		
		
		/// <summary>
		/// Rename the recipe and its RecipeFamily display name.
		///
		/// This updates:
		/// - Recipe.DisplayName for every recipe variant.
		/// - RecipeFamily.RecipeName, matching what RecipeFamily.Initialize()
		///   normally does with its displayText parameter.
		/// </summary>
		protected void RenameRecipe(LocString displayName)
		{
			foreach (var recipe in this.Recipes)
				recipe.DisplayName = displayName;

			RecipePatchRefresh.SetRecipeFamilyName(
				this.Family,
				displayName.NotTranslated);
		}
		
		
		// -------------------------------------------------------------------------
		// Item ingredients
		// -------------------------------------------------------------------------

		/// <summary>
		/// Add a specific-item ingredient with a static quantity.
		/// </summary>
		protected void AddIngredient<TItem>(
			float amount = 1)
			where TItem : Item
		{
			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						typeof(TItem),
						amount,
						true));
			}
		}

		/// <summary>
		/// Add a specific-item ingredient whose quantity is modified by a skill.
		/// </summary>
		protected void AddIngredient<TItem, TSkill>(
			float amount = 1)
			where TItem : Item
			where TSkill : Skill
		{
			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						typeof(TItem),
						amount,
						typeof(TSkill)));
			}
		}

		/// <summary>
		/// Add a specific-item ingredient whose quantity is modified by a skill
		/// and specialty talent.
		/// </summary>
		protected void AddIngredient<TItem, TSkill, TTalent>(
			float amount = 1)
			where TItem : Item
			where TSkill : Skill
			where TTalent : Talent
		{
			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						typeof(TItem),
						amount,
						typeof(TSkill),
						typeof(TTalent)));
			}
		}


		// -------------------------------------------------------------------------
		// Tag ingredients
		// -------------------------------------------------------------------------

		/// <summary>
		/// Add a tag ingredient with a static quantity.
		/// Example: AddTagIngredient("Wood", 1);
		/// </summary>
		protected void AddTagIngredient(
			string tag,
			float amount = 1)
		{
			if (string.IsNullOrWhiteSpace(tag))
				throw new ArgumentException(
					"Ingredient tag must not be empty.",
					nameof(tag));

			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						tag,
						amount,
						true));
			}
		}

		/// <summary>
		/// Add a tag ingredient whose quantity is modified by a skill.
		/// Example: AddTagIngredient&lt;CarpentrySkill&gt;("Wood", 1);
		/// </summary>
		protected void AddTagIngredient<TSkill>(
			string tag,
			float amount = 1)
			where TSkill : Skill
		{
			if (string.IsNullOrWhiteSpace(tag))
				throw new ArgumentException(
					"Ingredient tag must not be empty.",
					nameof(tag));

			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						tag,
						amount,
						typeof(TSkill)));
			}
		}

		/// <summary>
		/// Add a tag ingredient whose quantity is modified by a skill and talent.
		/// </summary>
		protected void AddTagIngredient<TSkill, TTalent>(
			string tag,
			float amount = 1)
			where TSkill : Skill
			where TTalent : Talent
		{
			if (string.IsNullOrWhiteSpace(tag))
				throw new ArgumentException(
					"Ingredient tag must not be empty.",
					nameof(tag));

			foreach (var recipe in this.Recipes)
			{
				recipe.Ingredients.Add(
					new IngredientElement(
						tag,
						amount,
						typeof(TSkill),
						typeof(TTalent)));
			}
		}

        /// <summary>
        /// Add an output to every recipe variant in this RecipeFamily.
        /// </summary>
        protected void AddOutput<TItem>(float amount = 1)
            where TItem : Item, new()
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Products.Add(
                    new CraftingElement<TItem>(amount));
            }
        }

        /// <summary>
        /// Add an output whose quantity is modified by the specified skill.
        /// </summary>
        protected void AddSkillOutput<TItem, TSkill>(float amount = 1)
            where TItem : Item, new()
            where TSkill : Skill
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Products.Add(
                    new CraftingElement<TItem>(
                        typeof(TSkill),
                        amount));
            }
        }

        /// <summary>
        /// Add an output whose quantity is modified by the specified skill and
        /// specialty talent.
        ///
        /// This mirrors Eco's
        /// CraftingElement&lt;TItem&gt;(Type skillType, amount, Type talentType)
        /// constructor.
        /// </summary>
        protected void AddTalentOutput<TItem, TSkill, TTalent>(
            float amount = 1)
            where TItem : Item, new()
            where TSkill : Skill
            where TTalent : Talent
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Products.Add(
                    new CraftingElement<TItem>(
                        typeof(TSkill),
                        amount,
                        typeof(TTalent)));
            }
        }

        /// <summary>
        /// Add recipe-declared garbage to every recipe variant.
        /// OwnerRecipe is assigned immediately, matching Recipe.Init().
        /// </summary>
        protected void AddGarbage<TGarbageMaterial>(float amount = 1)
            where TGarbageMaterial : GarbageMaterial
        {
            foreach (var recipe in this.Recipes)
            {
                var garbage =
                    new GarbageOutput(
                        typeof(TGarbageMaterial),
                        amount);

                RecipePatchRefresh.SetGarbageOwner(
                    garbage,
                    recipe);

                recipe.Garbages.Add(
                    garbage);
            }
        }

        /// <summary>
        /// Remove recipe-declared garbage of the specified material from every
        /// recipe variant.
        /// </summary>
        protected void RemoveGarbage<TGarbageMaterial>()
            where TGarbageMaterial : GarbageMaterial
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Garbages.RemoveAll(
                    garbage =>
                        garbage.GarbageMaterialType ==
                        typeof(TGarbageMaterial));
            }
        }

        /// <summary>
        /// Remove every specific-item ingredient of this item type.
        /// </summary>
        protected void RemoveIngredient<TItem>()
            where TItem : Item
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Ingredients.RemoveAll(
                    ingredient =>
                        ingredient.IsSpecificItem &&
                        ingredient.Item.Type == typeof(TItem));
            }
        }

        /// <summary>
        /// Remove every output of this item type.
        /// </summary>
        protected void RemoveOutput<TItem>()
            where TItem : Item
        {
            foreach (var recipe in this.Recipes)
            {
                recipe.Products.RemoveAll(
                    product => product.Item.Type == typeof(TItem));
            }
        }

        /// <summary>
        /// Advanced escape hatch. Prefer the supported Add/Remove helpers.
        /// Arbitrary Recipe mutation may change state the framework cannot
        /// automatically reconcile.
        /// </summary>
        protected void ForEachRecipe(Action<Recipe> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            foreach (var recipe in this.Recipes)
                action(recipe);
        }

        /// <summary>
        /// Advanced access to the RecipeFamily currently being patched.
        /// Prefer the supported helper methods when possible.
        /// </summary>
        protected TRecipeFamily Family =>
            this.currentFamily ??
            throw new InvalidOperationException(
                "Recipe patch helpers may only be used from Modify().");

        /// <summary>
        /// Advanced access to all Recipe variants in the current family.
        /// Prefer the supported helper methods when possible.
        /// </summary>
        protected IEnumerable<Recipe> Recipes =>
            this.Family.Recipes ?? Enumerable.Empty<Recipe>();
    }

    public static class RecipePatches
    {
        private sealed class RegisteredPatch<TRecipeFamily> : IRecipePatch
            where TRecipeFamily : RecipeFamily
        {
            private readonly Action<TRecipeFamily> action;

            public RegisteredPatch(
                string id,
                int order,
                Action<TRecipeFamily> action)
            {
                this.Id = id;
                this.Order = order;
                this.action = action;
            }

            public int Order { get; }

            public string Id { get; }

            public bool AppliesTo(RecipeFamily family) =>
                family is TRecipeFamily;

            public void Apply(RecipeFamily family) =>
                this.action((TRecipeFamily)family);
        }

        private static readonly List<IRecipePatch> Registered =
            new List<IRecipePatch>();

        private static bool applyingOrApplied;

        /// <summary>
        /// Alternative registration API for mods that already have an IModInit.
        ///
        /// Call this from IModInit.Initialize().
        /// </summary>
        public static void Register<TRecipeFamily>(
            string id,
            Action<TRecipeFamily> patch,
            int order = 0)
            where TRecipeFamily : RecipeFamily
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException(
                    "Patch id must not be empty.",
                    nameof(id));

            if (patch == null)
                throw new ArgumentNullException(nameof(patch));

            if (applyingOrApplied)
            {
                throw new InvalidOperationException(
                    $"Recipe patch '{id}' was registered too late. " +
                    "Register recipe patches from IModInit.Initialize().");
            }

            Registered.Add(
                new RegisteredPatch<TRecipeFamily>(
                    id,
                    order,
                    patch));
        }

        internal static void ApplyAll()
        {
            if (applyingOrApplied)
                return;

            applyingOrApplied = true;

            var families =
                RecipeManager.AllRecipeFamilies ??
                Array.Empty<RecipeFamily>();

            var originalFamilyRecipes =
                new HashSet<Recipe>(
                    families
                        .Where(family => family.Recipes != null)
                        .SelectMany(family => family.Recipes));

            var snapshots =
                families.ToDictionary(
                    family => family,
                    RecipePatchRefresh.CaptureFamilyState);

            var patches =
                Registered
                    .Concat(DiscoverPatchClasses())
                    .OrderBy(patch => patch.Order)
                    .ThenBy(patch => patch.Id, StringComparer.Ordinal)
                    .ToArray();

            foreach (var family in families)
            {
                var touched = false;

                foreach (var patch in patches)
                {
                    bool applies;

                    try
                    {
                        applies = patch.AppliesTo(family);
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException(
                            $"Recipe patch '{patch.Id}' failed while checking " +
                            $"whether it applies to recipe family " +
                            $"'{family.GetType().FullName}'.",
                            ex);
                    }

                    if (!applies)
                        continue;

                    touched = true;

                    try
                    {
                        patch.Apply(family);
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException(
                            $"Recipe patch '{patch.Id}' failed while patching " +
                            $"recipe family '{family.GetType().FullName}'.",
                            ex);
                    }
                }

                if (touched)
                {
                    RecipePatchRefresh.RefreshFamily(
                        family,
                        snapshots[family]);
                }
            }

            RecipePatchRefresh.RebuildRecipeManager(
                originalFamilyRecipes);
        }

        private static IEnumerable<IRecipePatch> DiscoverPatchClasses()
        {
            foreach (var type in typeof(IRecipePatch).ConcreteTypes())
            {
                if (type.IsAbstract || type.IsInterface)
                    continue;

                if (type.IsGenericType &&
                    type.GetGenericTypeDefinition() ==
                    typeof(RegisteredPatch<>))
                {
                    continue;
                }

                var constructor =
                    type.GetConstructor(Type.EmptyTypes);

                if (constructor == null)
                {
                    throw new InvalidOperationException(
                        $"Recipe patch type '{type.FullName}' " +
                        "requires a public parameterless constructor.");
                }

                yield return
                    (IRecipePatch)Activator.CreateInstance(type);
            }
        }
    }

    /// <summary>
    /// Repairs Eco's recipe caches/lookups after post-initialization patches.
    /// </summary>
    internal static class RecipePatchRefresh
    {
		
		private static readonly PropertyInfo RecipeNameProperty =
			RequiredProperty(
				typeof(RecipeFamily),
				nameof(RecipeFamily.RecipeName),
				BindingFlags.Instance |
				BindingFlags.Public |
				BindingFlags.NonPublic);
		
        private const BindingFlags InstancePrivate =
            BindingFlags.Instance |
            BindingFlags.NonPublic;

        private const BindingFlags StaticPrivate =
            BindingFlags.Static |
            BindingFlags.NonPublic;

        private static readonly FieldInfo SameIngredientsField =
            RequiredField(
                typeof(RecipeFamily),
                "allRecipesHaveSameIngredients",
                InstancePrivate);

        private static readonly FieldInfo TotalGarbagesCacheField =
            RequiredField(
                typeof(Recipe),
                "totalGarbagesCache",
                InstancePrivate);

        private static readonly PropertyInfo RecipeFamilyProperty =
            RequiredProperty(
                typeof(Recipe),
                nameof(Recipe.Family),
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

        private static readonly PropertyInfo GarbageOwnerRecipeProperty =
            RequiredProperty(
                typeof(GarbageOutput),
                nameof(GarbageOutput.OwnerRecipe),
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

        private static readonly IEqualityComparer<IngredientElement>
            IngredientComparer =
                CreateIngredientComparer();

        internal sealed class FamilyState
        {
            internal FamilyState(
                List<DynamicValueBinding> dynamicValues)
            {
                this.DynamicValues = dynamicValues;
            }

            internal List<DynamicValueBinding> DynamicValues { get; }
        }

        internal sealed class DynamicValueBinding
        {
            internal DynamicValueBinding(
                SkillModifiedValue value,
                Type beneficiaryType,
                string description)
            {
                this.Value = value;
                this.BeneficiaryType = beneficiaryType;
                this.Description = description;
            }

            internal SkillModifiedValue Value { get; }

            internal Type BeneficiaryType { get; }

            internal string Description { get; }
        }

        internal static FamilyState CaptureFamilyState(
            RecipeFamily family)
        {
            return new FamilyState(
                GetDynamicValueBindings(family).ToList());
        }
		
		internal static void SetRecipeFamilyName(
			RecipeFamily family,
			string recipeName)
		{
			if (family == null)
				throw new ArgumentNullException(nameof(family));

			var setter =
				RecipeNameProperty.GetSetMethod(
					nonPublic: true);

			if (setter == null)
			{
				throw new InvalidOperationException(
					"RecipePatchFramework is incompatible with this Eco " +
					"version: RecipeFamily.RecipeName no longer has a " +
					"setter accessible through reflection.");
			}

			setter.Invoke(
				family,
				new object[] { recipeName });
		}
		
        internal static void RefreshFamily(
            RecipeFamily family,
            FamilyState before)
        {
            if (family.Recipes == null)
                return;

            foreach (var recipe in family.Recipes)
            {
                RecipeFamilyProperty.SetValue(
                    recipe,
                    family);

                foreach (var garbage in
                    recipe.Garbages ??
                    Enumerable.Empty<GarbageOutput>())
                {
                    SetGarbageOwner(
                        garbage,
                        recipe);
                }

                // Ingredients and recipe-declared garbage can both affect
                // TotalGarbages. Force it to be calculated again.
                TotalGarbagesCacheField.SetValue(
                    recipe,
                    null);
            }

            ReconcileDynamicValues(
                family,
                before);

            RecalculateSameIngredients(
                family);
        }

        internal static void SetGarbageOwner(
            GarbageOutput garbage,
            Recipe recipe)
        {
            if (garbage == null)
                throw new ArgumentNullException(nameof(garbage));

            if (recipe == null)
                throw new ArgumentNullException(nameof(recipe));

            var setter =
                GarbageOwnerRecipeProperty.GetSetMethod(
                    nonPublic: true);

            if (setter == null)
            {
                throw new InvalidOperationException(
                    "RecipePatchFramework is incompatible with this Eco " +
                    "version: GarbageOutput.OwnerRecipe no longer has a " +
                    "setter accessible through reflection.");
            }

            setter.Invoke(
                garbage,
                new object[] { recipe });
        }

        private static void ReconcileDynamicValues(
            RecipeFamily family,
            FamilyState before)
        {
            var after =
                GetDynamicValueBindings(family).ToList();

            // Eco registers SkillModifiedValues during RecipeFamily.Initialize().
            // There is no public removal API available to safely undo a benefit
            // registration later. Refuse removal/replacement instead of leaving
            // stale global SkillModifiedValueManager state behind.
            foreach (var previous in before.DynamicValues)
            {
                if (!ContainsBinding(
                    after,
                    previous))
                {
                    throw new InvalidOperationException(
                        $"Recipe family '{family.GetType().FullName}' removed " +
                        $"or replaced an already-registered skill-modified " +
                        $"value ({previous.Description}). " +
                        "RecipePatchFramework cannot safely unregister existing " +
                        "SkillModifiedValue benefits from Eco's global manager. " +
                        "Removing/replacing skill-modified ingredients or outputs " +
                        "is therefore unsupported.");
                }
            }

            // Register only genuinely new SkillModifiedValue instances. Existing
            // ones were already registered by RecipeFamily.Initialize().
            foreach (var current in after)
            {
                if (ContainsBinding(
                    before.DynamicValues,
                    current))
                {
                    continue;
                }

                SkillModifiedValueManager.AddSkillBenefit(
                    current.BeneficiaryType,
                    current.Value);
            }
        }

        private static bool ContainsBinding(
            IEnumerable<DynamicValueBinding> bindings,
            DynamicValueBinding target)
        {
            return bindings.Any(
                candidate =>
                    ReferenceEquals(
                        candidate.Value,
                        target.Value) &&
                    candidate.BeneficiaryType ==
                        target.BeneficiaryType);
        }

        private static IEnumerable<DynamicValueBinding>
            GetDynamicValueBindings(
                RecipeFamily family)
        {
            if (family.Recipes == null)
                yield break;

            foreach (var recipe in family.Recipes)
            {
                if (recipe.Ingredients != null)
                {
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        if (ingredient.Quantity
                            is SkillModifiedValue quantity)
                        {
                            yield return
                                new DynamicValueBinding(
                                    quantity,
                                    ingredient.GetType(),
                                    $"ingredient in recipe '{recipe.Name}'");
                        }
                    }
                }

                if (recipe.Products != null)
                {
                    foreach (var product in recipe.Products)
                    {
                        if (product.Quantity
                            is SkillModifiedValue quantity)
                        {
                            // Mirrors RecipeFamily.Initialize().
                            yield return
                                new DynamicValueBinding(
                                    quantity,
                                    recipe.GetType(),
                                    $"output in recipe '{recipe.Name}'");
                        }
                    }
                }
            }
        }

        private static void RecalculateSameIngredients(
            RecipeFamily family)
        {
            if (family.Recipes == null ||
                family.Recipes.Count == 0)
            {
                SameIngredientsField.SetValue(
                    family,
                    false);

                return;
            }

            var defaultIngredients =
                family.DefaultRecipe.Ingredients;

            var allSame =
                family.Recipes.All(
                    recipe =>
                        recipe.Ingredients.SequenceEqual(
                            defaultIngredients,
                            IngredientComparer));

            SameIngredientsField.SetValue(
                family,
                allSame);
        }

        private static IEqualityComparer<IngredientElement>
            CreateIngredientComparer()
        {
            var comparerType =
                typeof(RecipeFamily)
                    .Assembly
                    .GetTypes()
                    .FirstOrDefault(
                        type =>
                            type.Name ==
                            "IngredientElementEqualityComparer");

            if (comparerType == null)
            {
                throw new InvalidOperationException(
                    "RecipePatchFramework is incompatible with this Eco " +
                    "version: IngredientElementEqualityComparer could not " +
                    "be found.");
            }

            var comparer =
                Activator.CreateInstance(
                    comparerType,
                    nonPublic: true)
                as IEqualityComparer<IngredientElement>;

            if (comparer == null)
            {
                throw new InvalidOperationException(
                    "RecipePatchFramework is incompatible with this Eco " +
                    "version: IngredientElementEqualityComparer no longer " +
                    "implements IEqualityComparer<IngredientElement>.");
            }

            return comparer;
        }

        internal static void RebuildRecipeManager(
            HashSet<Recipe> originalFamilyRecipes)
        {
            var families =
                RecipeManager.AllRecipeFamilies ??
                Array.Empty<RecipeFamily>();

            // Preserve Recipe instances that were not originally owned by a
            // RecipeFamily.
            var standaloneRecipes =
                (RecipeManager.AllRecipes ?? new List<Recipe>())
                    .Where(recipe =>
                        !originalFamilyRecipes.Contains(recipe));

            // Rebuild AllRecipes from the patched family recipe lists.
            var allRecipes =
                standaloneRecipes
                    .Concat(
                        families
                            .Where(family =>
                                family.Recipes != null)
                            .SelectMany(family =>
                                family.Recipes))
                    .Distinct()
                    .ToList();

            SetAutoPropertyBackingField(
                nameof(RecipeManager.AllRecipes),
                allRecipes);

            // Mirror RecipeManager.Initialize() semantics exactly:
            // duplicate family types are an error.
            var typeToRecipeFamily =
                families.ToDictionary(
                    family => family.GetType(),
                    family => family);

            // Eco intentionally tolerates duplicate simple type names here and
            // keeps the first.
            var typenameToRecipeFamily =
                typeToRecipeFamily
                    .DistinctBy(
                        pair => pair.Key.Name)
                    .ToDictionary(
                        pair => pair.Key.Name,
                        pair => pair.Value);

            var productToRecipes =
                (from Recipe recipe in allRecipes
                 from CraftingElement item in recipe.Products
                 group recipe by item.Item.Type)
                .ToDictionary(
                    group => group.Key,
                    group => group.ToList());

            RecipeManager.ProductNameToRecipes =
                productToRecipes.ToDictionary(
                    pair =>
                        TrimItemSuffix(
                            pair.Key.Name),
                    pair =>
                        pair.Value);

            var productToRecipeFamilies =
                (from RecipeFamily family in families
                 from Recipe recipe in family.Recipes
                 from CraftingElement item in recipe.Products
                 group family by item.Item.Type)
                .ToDictionary(
                    group => group.Key,
                    group => group.ToList());

            var tagToRecipeFamilies =
                (from RecipeFamily family in families
                 from IngredientElement ingredient in family.Ingredients
                 where !ingredient.IsSpecificItem
                 group family by ingredient.Tag)
                .ToDictionary(
                    group => group.Key,
                    group => group.ToList());

            var skillToRecipeFamilies =
                (from RecipeFamily family in families
                 from RequiresSkillAttribute skill in family.RequiredSkills
                 group family by skill.SkillType)
                .ToDictionary(
                    group => group.Key,
                    group => group.ToList());

            // Mirror RecipeManager.Initialize(): duplicate family simple names
            // are an error here.
            var recipeNameDictionary =
                families.ToDictionary(
                    family => family.GetType().Name,
                    family => family.GetType());

            SetPrivateStatic(
                "typeToRecipeFamily",
                typeToRecipeFamily);

            SetPrivateStatic(
                "typenameToRecipeFamily",
                typenameToRecipeFamily);

            SetPrivateStatic(
                "productToRecipes",
                productToRecipes);

            SetPrivateStatic(
                "productToRecipeFamilies",
                productToRecipeFamilies);

            SetPrivateStatic(
                "tagToRecipeFamilies",
                tagToRecipeFamilies);

            SetPrivateStatic(
                "skillToRecipeFamilies",
                skillToRecipeFamilies);

            SetPrivateStatic(
                "recipeNameDictionary",
                recipeNameDictionary);

            CraftingComponent.SortRecipes();
            TagManager.SetupRecipes();
        }

        private static string TrimItemSuffix(
            string name)
        {
            const string suffix = "Item";

            return name.EndsWith(
                suffix,
                StringComparison.Ordinal)
                ? name.Substring(
                    0,
                    name.Length - suffix.Length)
                : name;
        }

        private static FieldInfo RequiredField(
            Type type,
            string fieldName,
            BindingFlags flags)
        {
            return type.GetField(
                       fieldName,
                       flags)
                ?? throw new InvalidOperationException(
                    $"RecipePatchFramework is incompatible with this Eco " +
                    $"version: required field " +
                    $"'{type.FullName}.{fieldName}' was not found.");
        }

        private static PropertyInfo RequiredProperty(
            Type type,
            string propertyName,
            BindingFlags flags)
        {
            return type.GetProperty(
                       propertyName,
                       flags)
                ?? throw new InvalidOperationException(
                    $"RecipePatchFramework is incompatible with this Eco " +
                    $"version: required property " +
                    $"'{type.FullName}.{propertyName}' was not found.");
        }

        private static void SetPrivateStatic(
            string fieldName,
            object value)
        {
            RequiredField(
                    typeof(RecipeManager),
                    fieldName,
                    StaticPrivate)
                .SetValue(
                    null,
                    value);
        }

        private static void SetAutoPropertyBackingField(
            string propertyName,
            object value)
        {
            var fieldName =
                $"<{propertyName}>k__BackingField";

            RequiredField(
                    typeof(RecipeManager),
                    fieldName,
                    StaticPrivate)
                .SetValue(
                    null,
                    value);
        }
    }
}
