using System;
using System.Collections.Generic;
using Eco.Mods.TechTree;

public sealed class PlayerDefaultsDefaultCampsiteInventory : PlayerDefaultsProviderBase
{
    public override int Priority => 100;

    public override IEnumerable<KeyValuePair<Type, int>> AddDefaultCampsiteInventory()
    {
        yield return new KeyValuePair<Type, int>(typeof(ClaimToolItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(StoneAxeItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(WoodenShovelItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(StonePickaxeItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(RawFishItem), 20);
        yield return new KeyValuePair<Type, int>(typeof(StorageChestItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(WheelbarrowItem), 1);
        yield return new KeyValuePair<Type, int>(typeof(StoreItem), 1);
    }
}
