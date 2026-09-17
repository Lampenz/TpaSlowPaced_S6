using System;
using System.Collections.Generic;
using Eco.Mods.TechTree;

public sealed class PlayerDefaultsForcedSkills : PlayerDefaultsProviderBase
{
    public override int Priority => 0;

    public override IEnumerable<Type> AddSkillsForcedToLevelUp()
    {
        yield return typeof(SurvivalistSkill);
        yield return typeof(SelfImprovementSkill);
    }
}
