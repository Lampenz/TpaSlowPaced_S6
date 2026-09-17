# Recipe Patch Framework - Release Candidate

## Supported API

For normal patches, derive from:

```csharp
SimpleRecipePatch<TRecipeFamily>
```

Supported helpers:

```csharp
AddStaticIngredient<TItem>(amount);
AddSkillIngredient<TItem, TSkill>(amount);
AddIngredient<TItem>(amount, staticValue);
AddIngredient<TItem, TSkill>(amount);

RemoveIngredient<TItem>();

AddOutput<TItem>(amount);
RemoveOutput<TItem>();

AddGarbage<TGarbageMaterial>(amount);
RemoveGarbage<TGarbageMaterial>();
```

`RecipePatch<T>`, `ForEachRecipe`, `Family`, and `Recipes` remain available as
advanced escape hatches. Arbitrary mutations through them may affect Eco state
that Recipe Patch Framework does not know how to reconcile.

## Skill-modified values

Eco registers skill-modified ingredient/output values during
`RecipeFamily.Initialize()`.

Recipe Patch Framework runs later, so it now detects newly-added
`SkillModifiedValue` instances and registers them with
`SkillModifiedValueManager`.

Eco does not expose a safe public unregistration API for an already-registered
benefit. Therefore removing or replacing an existing skill-modified ingredient
or output is rejected with a clear startup error rather than leaving stale
global skill-benefit state.

Static ingredient/output removal is supported normally.

## Garbage

`AddGarbage<TGarbageMaterial>()` assigns `GarbageOutput.OwnerRecipe` through
reflection because Eco exposes that setter only inside its own assembly. This
matches Eco's normal `Recipe.Init()` behavior. Recipe garbage caches are invalidated
after a family is patched.

## Compatibility

The framework deliberately uses reflection for a few private Eco cache/index
members. Required reflected members fail loudly with an incompatibility message
if a future Eco release renames or changes them.

Only recipe families actually touched by a patch have their per-family state
refreshed.

## Other mods using PostInitialize directly

Recipe Patch Framework cannot guarantee it runs after every other mod's
`IModInit.PostInitialize()`.

Mods that want reliable index/cache rebuilding should make their recipe changes
through Recipe Patch Framework rather than mutating recipes directly from their
own `PostInitialize()`.
