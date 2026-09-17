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
    public partial class FarmingRainforestSpecialtySpecialtyTalent : Talent
    {
        public FarmingRainforestSpecialtySpecialtyTalent()
        {	
		
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Jungle Bounty"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PineappleSeedRecipe),typeof(PapayaSeedRecipe),typeof(TaroSeedRecipe) }, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) }  } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.90f, Cap = 0.5f, LowerIsBetter = true } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Jungle Bounty"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(PineappleSeedRecipe), typeof(PapayaSeedRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Jungle Bounty")]
    [LocDescription("Reduced cost for seeds from the jungle region. Also unlocks pineapple and papaya seeds.")]
    public partial class FarmingRainforestSpecialtySpecialtyTalentGroup : TalentGroup
    {
        public FarmingRainforestSpecialtySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingRainforestSpecialtySpecialtyTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 1;
        }
    }

}
