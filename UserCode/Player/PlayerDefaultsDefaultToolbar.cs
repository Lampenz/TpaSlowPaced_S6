using System;
using System.Collections.Generic;
using Eco.Mods.TechTree;

public sealed class PlayerDefaultsDefaultToolbar : PlayerDefaultsProviderBase
{
    public override int Priority => 100;

    public override IEnumerable<KeyValuePair<Type, int>> AddDefaultToolbar()
    {
        yield return new KeyValuePair<Type, int>(typeof(StoneHammerItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(SmallCanoeItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(BoiledGrainsItem), 10);
        yield return new KeyValuePair<Type, int>(typeof(BeetCampfireSaladItem), 10);                    
    }
}
