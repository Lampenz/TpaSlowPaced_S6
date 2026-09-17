using System;
using System.Collections.Generic;
using Eco.Mods.TechTree;

public sealed class PlayerDefaultsDefaultSkills : PlayerDefaultsProviderBase
{
    public override int Priority => 0;

    public override IEnumerable<Type> AddDefaultSkills()
    {
        yield return typeof(CarpenterSkill);
        yield return typeof(LoggingSkill);
        yield return typeof(MasonSkill);
        yield return typeof(MiningSkill);
        yield return typeof(ChefSkill);
        yield return typeof(FarmerSkill);
        yield return typeof(GatheringSkill);
        yield return typeof(CampfireCookingSkill);
        yield return typeof(HunterSkill);
        yield return typeof(HuntingSkill);
        yield return typeof(SurvivalistSkill);
        yield return typeof(SelfImprovementSkill);
    }
}
