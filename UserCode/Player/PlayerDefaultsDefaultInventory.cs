using System;
using System.Collections.Generic;
using Eco.Mods.TechTree;

public sealed class PlayerDefaultsDefaultInventory : PlayerDefaultsProviderBase
{
    public override int Priority => 0;

    public override IEnumerable<KeyValuePair<Type, int>> AddDefaultInventory()
    {
        yield return new KeyValuePair<Type, int>(typeof(StarterCampItem), 1);
    }
}
