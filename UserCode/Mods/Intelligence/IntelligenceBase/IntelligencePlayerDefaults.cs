using System;
using System.Collections.Generic;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

public sealed class PlayerDefaultsIntelligenceDynamicValues : PlayerDefaultsProviderBase
{
    // Runs after PlayerDefaultsVanillaProvider, which uses Priority 0.
    public override int Priority => 100;

    public override IEnumerable<UserStatType> RemoveDefaultDynamicValues()
    {
        yield return UserStatType.MaxCalories;
        yield return UserStatType.CalorieRate;
    }

    public override IEnumerable<KeyValuePair<UserStatType, Func<IDynamicValue>>> AddDefaultDynamicValueFactories()
    {
        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.MaxCalories,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                new MultiDynamicValue(MultiDynamicOps.Multiply,
                    new SkillModifiedValue(
                        0f,
                        new BonusUnitsDecoratorStrategy(IntelligenceSkill.AdditiveStrategy, " cal", val => val),
                        typeof(IntelligenceSkill),
                        typeof(Player),
                        Localizer.DoStr("stomach capacity"),
                        DynamicValueType.Misc),
                    new ConstantValue(1f)),
                new TalentModifiedValue(typeof(UserStatType), typeof(SelfImprovementGluttonTalent), 0),
                new ConstantValue(3000)));

        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.CalorieRate,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                new MultiDynamicValue(MultiDynamicOps.Multiply,
                    new SkillModifiedValue(
                        1f,
                        new BonusUnitsDecoratorStrategy(IntelligenceSkill.MultiplicativeStrategy, "", val => val),
                        typeof(IntelligenceSkill),
                        typeof(Player),
                        Localizer.DoStr("calorie consumption"),
                        DynamicValueType.Misc),
                    new ConstantValue(0.5f)),
                new ConstantValue(1)));
    }
}
