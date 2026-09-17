using System;
using System.Collections.Generic;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

public sealed class PlayerDefaultsDynamicValues : PlayerDefaultsProviderBase
{
    public override int Priority => 0;

    // Factory variant: each value is built only if it survives later providers' removals/overrides,
    // so the IntelligenceSkillMod can replace MaxCalories/CalorieRate without the SelfImprovement
    // SkillModifiedValue ever being constructed (and thus never leaking its benefit registration).
    public override IEnumerable<KeyValuePair<UserStatType, Func<IDynamicValue>>> AddDefaultDynamicValueFactories()
    {
        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.MaxCalories,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                new MultiDynamicValue(MultiDynamicOps.Multiply,
                    CreateSmv(0f, new BonusUnitsDecoratorStrategy(SelfImprovementSkill.AdditiveStrategy, "cal", (float val) => val / 2f), typeof(SelfImprovementSkill), Localizer.DoStr("stomach capacity"), DynamicValueType.Misc),
                    new ConstantValue(0.5f)),
                new TalentModifiedValue(typeof(UserStatType), typeof(SelfImprovementGluttonTalent), 0),
                new ConstantValue(3000)));

        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.MaxCarryWeight,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                CreateSmv(0f, new BonusUnitsDecoratorStrategy(SelfImprovementSkill.AdditiveStrategy, "kg", (float val) => val / 1000f), typeof(SelfImprovementSkill), Localizer.DoStr("carry weight"), DynamicValueType.Misc),
                new TalentModifiedValue(typeof(UserStatType), typeof(SelfImprovementDeeperPocketsTalent), 0),
                new ConstantValue(ToolbarBackpackInventory.DefaultWeightLimit)));

        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.CalorieRate,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                //CreateSmv(1f, SelfImprovementSkill.MultiplicativeStrategy, typeof(SelfImprovementSkill), Localizer.DoStr("calorie cost"), typeof(Calorie)),
                new ConstantValue(1)));

        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.DetectionRange,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                CreateSmv(0f, HuntingSkill.AdditiveStrategy, typeof(HuntingSkill), Localizer.DoStr("how close you can approach animals"), DynamicValueType.Misc),
                new ConstantValue(0)));

        yield return new KeyValuePair<UserStatType, Func<IDynamicValue>>(
            UserStatType.MovementSpeed,
            () => new MultiDynamicValue(MultiDynamicOps.Sum,
                new TalentModifiedValue(typeof(UserStatType), typeof(SelfImprovementNatureAdventurerSpeedTalent), 0),
                new TalentModifiedValue(typeof(UserStatType), typeof(SelfImprovementUrbanTravellerSpeedTalent), 0)));
    }

    private static SkillModifiedValue CreateSmv(float startValue, ModificationStrategy strategy, Type skillType, LocString benefitsDescription, DynamicValueType valueType)
    {
        var smv = new SkillModifiedValue(startValue, strategy, skillType, typeof(Player), benefitsDescription, valueType);
        return smv;
    }
}
