// Player Defaults Compatibility Tool
// Add a new provider class in any mod and implement IPlayerDefaultsProvider to patch player defaults.

using System;
using System.Collections.Generic;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;

public interface IPlayerDefaultsProvider
{
    // Lower numbers are applied first. Defaults use 0. Mods should usually use 100+.
    int Priority { get; }

    IEnumerable<KeyValuePair<Type, int>> AddDefaultToolbar();
    IEnumerable<Type> RemoveDefaultToolbar();

    IEnumerable<KeyValuePair<Type, int>> AddDefaultInventory();
    IEnumerable<Type> RemoveDefaultInventory();

    IEnumerable<KeyValuePair<Type, int>> AddDefaultCampsiteInventory();
    IEnumerable<Type> RemoveDefaultCampsiteInventory();

    IEnumerable<Type> AddSkillsForcedToLevelUp();
    IEnumerable<Type> RemoveSkillsForcedToLevelUp();

    IEnumerable<Type> AddDefaultSkills();
    IEnumerable<Type> RemoveDefaultSkills();

    IEnumerable<KeyValuePair<UserStatType, IDynamicValue>> AddDefaultDynamicValues();

    // Override-safe variant. The value is only constructed if it survives later removals/overrides.
    // Prefer this for SkillModifiedValue-backed stats: constructing a SkillModifiedValue registers a
    // skill benefit globally (SkillModifiedValueManager), so an eagerly-built value that is later
    // removed still leaks its benefit. Returning factories lets the loader build only the winner.
    IEnumerable<KeyValuePair<UserStatType, Func<IDynamicValue>>> AddDefaultDynamicValueFactories();

    IEnumerable<UserStatType> RemoveDefaultDynamicValues();
}

public abstract class PlayerDefaultsProviderBase : IPlayerDefaultsProvider
{
    public virtual int Priority => 100;

    public virtual IEnumerable<KeyValuePair<Type, int>> AddDefaultToolbar() { yield break; }
    public virtual IEnumerable<Type> RemoveDefaultToolbar() { yield break; }

    public virtual IEnumerable<KeyValuePair<Type, int>> AddDefaultInventory() { yield break; }
    public virtual IEnumerable<Type> RemoveDefaultInventory() { yield break; }

    public virtual IEnumerable<KeyValuePair<Type, int>> AddDefaultCampsiteInventory() { yield break; }
    public virtual IEnumerable<Type> RemoveDefaultCampsiteInventory() { yield break; }

    public virtual IEnumerable<Type> AddSkillsForcedToLevelUp() { yield break; }
    public virtual IEnumerable<Type> RemoveSkillsForcedToLevelUp() { yield break; }

    public virtual IEnumerable<Type> AddDefaultSkills() { yield break; }
    public virtual IEnumerable<Type> RemoveDefaultSkills() { yield break; }

    public virtual IEnumerable<KeyValuePair<UserStatType, IDynamicValue>> AddDefaultDynamicValues() { yield break; }
    public virtual IEnumerable<KeyValuePair<UserStatType, Func<IDynamicValue>>> AddDefaultDynamicValueFactories() { yield break; }
    public virtual IEnumerable<UserStatType> RemoveDefaultDynamicValues() { yield break; }
}
