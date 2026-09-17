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
    public partial class FarmingWarmForestSpecialtySpecialtyTalent : Talent
    {
        public FarmingWarmForestSpecialtySpecialtyTalent()
        {	
		

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Autumn Woods"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PumpkinSeedRecipe),typeof(BeetSeedRecipe),typeof(FernSporeRecipe),typeof(HuckleberrySeedRecipe) }, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) }  } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.90f, Cap = 0.5f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Autumn Woods")]
    [LocDescription("Reduced cost for seeds from the warm forest region.")]
    public partial class FarmingWarmForestSpecialtySpecialtyTalentGroup : TalentGroup
    {
        public FarmingWarmForestSpecialtySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingWarmForestSpecialtySpecialtyTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 1;
        }
    }

}
