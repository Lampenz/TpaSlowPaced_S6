// Player Defaults Compatibility Tool

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;

public static class PlayerDefaultsLoader
{
    private static readonly Lazy<IReadOnlyList<IPlayerDefaultsProvider>> Providers = new Lazy<IReadOnlyList<IPlayerDefaultsProvider>>(FindProviders);

    // GetDefaultDynamicValues is invoked many times (once per user in BuildUserStats, plus on every
    // server reload). Each constructed SkillModifiedValue registers a benefit in the process-global
    // SkillModifiedValueManager, which is NEVER cleared. So we must build the dictionary exactly once
    // per process and hand back the same cached instance, or benefits accumulate => doubled tooltips
    // after a reload. The values are stateless shared descriptors, so caching one instance is correct.
    private static readonly Lazy<Dictionary<UserStatType, IDynamicValue>> DynamicValues = new Lazy<Dictionary<UserStatType, IDynamicValue>>(BuildDynamicValuesUncached);

    public static Dictionary<Type, int> BuildTypeDictionary(
        Func<IPlayerDefaultsProvider, IEnumerable<KeyValuePair<Type, int>>> addSelector,
        Func<IPlayerDefaultsProvider, IEnumerable<Type>> removeSelector)
    {
        var result = new Dictionary<Type, int>();

        foreach (var provider in Providers.Value)
        {
            foreach (var type in removeSelector(provider) ?? Enumerable.Empty<Type>())
                result.Remove(type);

            foreach (var pair in addSelector(provider) ?? Enumerable.Empty<KeyValuePair<Type, int>>())
                result[pair.Key] = pair.Value;
        }

        return result;
    }

    public static IEnumerable<Type> BuildTypeSet(
        Func<IPlayerDefaultsProvider, IEnumerable<Type>> addSelector,
        Func<IPlayerDefaultsProvider, IEnumerable<Type>> removeSelector)
    {
        var result = new List<Type>();
        var seen = new HashSet<Type>();

        foreach (var provider in Providers.Value)
        {
            foreach (var type in removeSelector(provider) ?? Enumerable.Empty<Type>())
            {
                if (!seen.Remove(type)) continue;
                result.Remove(type);
            }

            foreach (var type in addSelector(provider) ?? Enumerable.Empty<Type>())
            {
                if (!seen.Add(type)) continue;
                result.Add(type);
            }
        }

        return result.ToArray();
    }

    public static Dictionary<UserStatType, IDynamicValue> BuildDynamicValues() => DynamicValues.Value;

    private static Dictionary<UserStatType, IDynamicValue> BuildDynamicValuesUncached()
    {
        // Collect factories (not constructed values) so that a value removed/overridden by a later
        // provider is NEVER constructed. Constructing a SkillModifiedValue has a global side effect:
        // it registers the skill benefit in SkillModifiedValueManager. So building a loser would leak
        // its benefit (e.g. the SelfImprovement "stomach capacity" perk) even after we drop it here.
        var factories = new Dictionary<UserStatType, Func<IDynamicValue>>();

        foreach (var provider in Providers.Value)
        {
            foreach (var stat in provider.RemoveDefaultDynamicValues() ?? Enumerable.Empty<UserStatType>())
                factories.Remove(stat);

            // Legacy eager path: values here are already constructed during enumeration (the side
            // effect already happened). Capture the instance so it isn't built twice. Providers that
            // want override-safe behavior should use AddDefaultDynamicValueFactories instead.
            foreach (var pair in provider.AddDefaultDynamicValues() ?? Enumerable.Empty<KeyValuePair<UserStatType, IDynamicValue>>())
            {
                var value = pair.Value;
                factories[pair.Key] = () => value;
            }

            // Deferred path: only the surviving factory is ever invoked.
            foreach (var pair in provider.AddDefaultDynamicValueFactories() ?? Enumerable.Empty<KeyValuePair<UserStatType, Func<IDynamicValue>>>())
                factories[pair.Key] = pair.Value;
        }

        var result = new Dictionary<UserStatType, IDynamicValue>();
        foreach (var pair in factories)
            result[pair.Key] = pair.Value();

        return result;
    }

    private static IReadOnlyList<IPlayerDefaultsProvider> FindProviders()
    {
        return AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(GetLoadableTypes)
            .Where(t => typeof(IPlayerDefaultsProvider).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
            .Select(t => (IPlayerDefaultsProvider)Activator.CreateInstance(t))
            .OrderBy(p => p.Priority)
            .ThenBy(p => p.GetType().FullName)
            .ToArray();
    }

    private static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
    {
        try { return assembly.GetTypes(); }
        catch (ReflectionTypeLoadException ex) { return ex.Types.Where(t => t != null); }
    }
}
