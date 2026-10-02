# Grill & Door Recipe Patterns

This document explains the recipe patterns used in the Gates mod for creating variants of doors and grills.

## Tag Product Pattern Overview

When you need multiple versions of the same object with different materials (e.g., different wood types or metals), use the **Tag Product pattern** instead of creating separate RecipeFamily instances.

**Why this pattern?**
- Keeps ingredients organized with tags
- Shares XP/labor/time specs across variants
- Reduces code duplication
- Makes it easy to add new variants

## Pattern Structure

### Parent Recipe (RecipeFamily)

The parent defines the generic recipe with **placeholder ingredients** (tags):

```csharp
[RequiresSkill(typeof(SomeSkill), 2)]
[Ecopedia("Housing Objects", "Doors", subPageName: "Parent Name Item")]
public partial class ParentRecipe : RecipeFamily
{
    public ParentRecipe()
    {
        var recipe = new Recipe();
        recipe.Init(
            name: "ParentName",
            displayName: Localizer.DoStr("Parent Name"),
            ingredients: new List<IngredientElement>
            {
                new IngredientElement("TagName", 5, typeof(SomeSkill), typeof(SomeTalent)),
            },
            items: new List<CraftingElement>
            {
                new CraftingElement<ParentItem>()
            });

        this.Recipes = new List<Recipe> { recipe };
        this.ExperienceOnCraft = 3;
        this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(SomeSkill));
        this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ParentRecipe), start: 4, skillType: typeof(SomeSkill));

        this.ModsPreInitialize();
        this.Initialize(displayText: Localizer.DoStr("Parent Name"), recipeType: typeof(ParentRecipe));
        this.ModsPostInitialize();

        CraftingComponent.AddRecipe(tableType: typeof(CraftingTable), recipeFamily: this);
    }
    partial void ModsPreInitialize();
    partial void ModsPostInitialize();
}
```

**Key characteristics:**
- Inherits `RecipeFamily`
- Uses **generic tag ingredients** (e.g., `"Metal"`, `"Wood"`, `"Lumber"`)
- Defines XP, labor, and craft time explicitly
- Registered via `AddRecipe()`

### Child Recipe (Recipe)

Each variant inherits the parent's specs but uses **specific items**:

```csharp
[RequiresSkill(typeof(SomeSkill), 2)]
[ForceCreateView]
[Ecopedia("Housing Objects", "Doors", subPageName: "Variant Name Item")]
public partial class VariantRecipe : Recipe
{
    public VariantRecipe()
    {
        this.Init(
            name: "VariantName",
            displayName: Localizer.DoStr("Variant Name"),
            ingredients: new List<IngredientElement>
            {
                new IngredientElement(typeof(SpecificItem), 5, typeof(SomeSkill), typeof(SomeTalent)),
            },
            items: new List<CraftingElement>
            {
                new CraftingElement<VariantItem>()
            });

        this.ModsPostInitialize();
        CraftingComponent.AddTagProduct(typeof(CraftingTable), typeof(ParentRecipe), this);
    }
    partial void ModsPostInitialize();
}
```

**Key characteristics:**
- Inherits `Recipe` (NOT `RecipeFamily`)
- Uses **specific item types** (e.g., `typeof(CopperBarItem)`)
- XP/labor/time inherited from parent
- Registered via `AddTagProduct()` referencing the parent

## Key Differences: Parent vs Child

| Aspect | Parent (RecipeFamily) | Child (Recipe) |
|--------|----------------------|----------------|
| **Inherits** | `RecipeFamily` | `Recipe` |
| **Ingredients** | Generic tags (e.g., `"Metal"`) | Specific items (e.g., `typeof(CopperBarItem)`) |
| **XP/Labor/Time** | Defined explicitly | Inherited from parent |
| **Registration** | `AddRecipe()` | `AddTagProduct()` with parent reference |

## Current Implementations

### LumberDoubleDoor
- **Parent**: `LumberDoubleDoorRecipe` with `"Lumber"` tag
- **Variants**: 8 wood types (Birch, Cedar, Ceiba, Fir, Oak, Palm, Redwood, Spruce)
- **Crafting table**: `SawmillObject`
- **Occupancy**: `GateOccupancy.DoubleDoor` (2x2)

### HewnDoubleDoor
- **Parent**: `HewnDoubleDoorRecipe` with `"HewnLog"` tag
- **Variants**: 8 wood types (same as Lumber)
- **Crafting table**: `CarpentryTableObject`
- **Occupancy**: `GateOccupancy.DoubleDoor` (2x2)

### Grill
- **Parent**: `IronGrillRecipe` with `"Metal"` tag
- **Variants**: Copper, Gold
- **Crafting table**: `AnvilObject`
- **Occupancy**: `GateOccupancy.Grill` (5x4)

## When to Use This Pattern

Use the Tag Product pattern when:
1. You have 2+ variants of the same object type
2. Variants differ only in material/ingredient
3. XP/labor/time specs are identical across variants
4. You want to avoid code duplication

## Adding a New Variant

To add a new variant to an existing family:

1. **Create new files** following the naming convention:
   - Object: `{Material}{ObjectType}Object`
   - Item: `{Material}{ObjectType}Item`
   - Recipe: `{Material}{ObjectType}Recipe`

2. **Copy an existing variant** and update:
   - Class names (search/replace `{ExistingMaterial}` with `{NewMaterial}`)
   - Item types in ingredients (update `typeof({Material}BarItem)`)
   - Display names

3. **Register via AddTagProduct()**:
   ```csharp
   CraftingComponent.AddTagProduct(typeof(CraftingTable), typeof(ParentRecipe), this);
   ```

4. **Update CLAUDE.md** to reflect the new variant count

## Adding a New Family

To create a completely new family:

1. **Create directory**: `Src/Mods/UserCode/EcoPulse/Gates/{FamilyName}/`

2. **Create parent recipe** with generic ingredients and full specs

3. **Create variant files** for each material version

4. **Create centralized occupancy** in `GateOccupancy.cs` if the pattern is reusable:
   ```csharp
   public static List<BlockOccupancy> FamilyName => new List<BlockOccupancy> { ... };
   ```

5. **Update CLAUDE.md** with the new family details
