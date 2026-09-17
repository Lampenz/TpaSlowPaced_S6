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
    
	[Serialized]
    public partial class BasicEngineeringCarbonFilterYieldTalent : Talent
    {
        public BasicEngineeringCarbonFilterYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Activated Carbon"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(CarbonFilterRecipe) }, SkillTypes = new HashSet<Type> { typeof(BasicEngineeringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Activated Carbon")]
    [LocDescription("Increased yield for carbon filters.")]
    public partial class BasicEngineeringCarbonFilterYieldTalentGroup : TalentGroup
    {
        public BasicEngineeringCarbonFilterYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BasicEngineeringCarbonFilterYieldTalent),
            };
            this.OwningSkill = typeof(BasicEngineeringSkill);
            this.Level = 3;
        }
    }

}
