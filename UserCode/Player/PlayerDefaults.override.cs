// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// Player Defaults Compatibility Tool override.

using System;
using System.Collections.Generic;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Players;

// default starting player items / skills
public static class PlayerDefaults
{
    public static Dictionary<Type, int> GetDefaultToolbar()
    {
        return PlayerDefaultsLoader.BuildTypeDictionary(p => p.AddDefaultToolbar(), p => p.RemoveDefaultToolbar());
    }

    public static Dictionary<Type, int> GetDefaultInventory()
    {
        return PlayerDefaultsLoader.BuildTypeDictionary(p => p.AddDefaultInventory(), p => p.RemoveDefaultInventory());
    }

    public static Dictionary<Type, int> GetDefaultCampsiteInventory()
    {
        return PlayerDefaultsLoader.BuildTypeDictionary(p => p.AddDefaultCampsiteInventory(), p => p.RemoveDefaultCampsiteInventory());
    }

    public static IEnumerable<Type> GetSkillsForcedToLevelUp()
    {
        return PlayerDefaultsLoader.BuildTypeSet(p => p.AddSkillsForcedToLevelUp(), p => p.RemoveSkillsForcedToLevelUp());
    }

    public static IEnumerable<Type> GetDefaultSkills()
    {
        return PlayerDefaultsLoader.BuildTypeSet(p => p.AddDefaultSkills(), p => p.RemoveDefaultSkills());
    }

    public static Dictionary<UserStatType, IDynamicValue> GetDefaultDynamicValues()
    {
        return PlayerDefaultsLoader.BuildDynamicValues();
    }
}
