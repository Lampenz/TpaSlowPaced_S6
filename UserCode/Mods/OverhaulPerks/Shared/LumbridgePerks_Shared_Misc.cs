// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
	using System.ComponentModel;
	using System.Linq;
	using System.Collections.Generic;
	using Eco.Gameplay.Components;
	using Eco.Gameplay.Items;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
	using Eco.Shared.Items;
	using Eco.Shared.View;
	using Eco.Shared.Serialization;
    using Eco.Simulation.WorldLayers;
	using Eco.Mods.TechTree;
	
    
    public static class SkillTalentBonuses
{
    public static void AddLaborCostBonus<TSkill>(
        Talent talent,
        string name,
        float value = 0.875f,
        float cap = 0.50f,
        float powervalue = 1.10f,
        float powercap = 1.4f)
        where TSkill : Skill
    {
        talent.Bonuses.Add(new Bonus
        {
            Name = Localizer.DoStr(name),
            Causes = new List<BonusCause>
            {
                new CraftBonusCause
                {
                    Action = BonusAction.LaborCost,
                    SkillTypes = new HashSet<Type> { typeof(TSkill) }
                }
            },
            Effects = new List<BonusEffect>
            {
                new BonusEffectCappedMultiplicative
                {
                    Value = value,
                    Cap = cap,
                    LowerIsBetter = true
                }
            },
        });
		talent.Bonuses.Add(new Bonus
        {
            Name = Localizer.DoStr(name),
            Causes = new List<BonusCause>
            {
                new CraftBonusCause
                {
                    Action = BonusAction.Power,
                    SkillTypes = new HashSet<Type> { typeof(TSkill) }
                }
            },
            Effects = new List<BonusEffect>
            {
                new BonusEffectCappedMultiplicative
                {
                    Value = powervalue,
                    Cap = powercap,
                    LowerIsBetter = true
                }
            },
        });
    }

    public static void AddCraftTimeBonus<TSkill>(
        Talent talent,
        string name,
        float value = 0.85f,
        float cap = 0.40f,
        float powervalue = 1.02f,
        float powercap = 1.1f)
        where TSkill : Skill
    {
        talent.Bonuses.Add(new Bonus
        {
            Name = Localizer.DoStr(name),
            Causes = new List<BonusCause>
            {
                new CraftBonusCause
                {
                    Action = BonusAction.CraftTime,
                    SkillTypes = new HashSet<Type> { typeof(TSkill) }
                }
            },
            Effects = new List<BonusEffect>
            {
                new BonusEffectCappedMultiplicative
                {
                    Value = value,
                    Cap = cap,
                    LowerIsBetter = true
                }
            },
        });
		talent.Bonuses.Add(new Bonus
        {
            Name = Localizer.DoStr(name),
            Causes = new List<BonusCause>
            {
                new CraftBonusCause
                {
                    Action = BonusAction.LaborCost,
                    SkillTypes = new HashSet<Type> { typeof(TSkill) }
                }
            },
            Effects = new List<BonusEffect>
            {
                new BonusEffectCappedMultiplicative
                {
                    Value = powervalue,
                    Cap = powercap,
                    LowerIsBetter = true
                }
            },
        });
    }
}

}
