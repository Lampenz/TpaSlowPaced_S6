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
    public partial class FarmingColdForestSpecialtySpecialtyTalent : Talent
    {
        public FarmingColdForestSpecialtySpecialtyTalent()
        {	
		
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Boreal Blessing"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(FernSporeRecipe),typeof(HuckleberrySeedRecipe),typeof(FireweedSeedRecipe)}, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) }  } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.90f, Cap = 0.5f, LowerIsBetter = true } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Boreal Blessing"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(HuckleberrySeedRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Boreal Blessing")]
    [LocDescription("Reduced cost for seeds from the cold forest region. Also unlocks huckleberry seeds.")]
    public partial class FarmingColdForestSpecialtySpecialtyTalentGroup : TalentGroup
    {
        public FarmingColdForestSpecialtySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingColdForestSpecialtySpecialtyTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 1;
        }
    }

}
