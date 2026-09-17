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
    public partial class FarmingOilySpecialtySpecialtyTalent : Talent
    {
        public FarmingOilySpecialtySpecialtyTalent()
        {	
		

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Seeds of Plenty"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(FlaxSeedRecipe),typeof(CottonSeedRecipe),typeof(SunflowerSeedRecipe) }, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) }  } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.90f, Cap = 0.5f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Seeds of Plenty")]
    [LocDescription("Reduced cost for oil-producing seeds.")]
    public partial class FarmingOilySpecialtySpecialtyTalentGroup : TalentGroup
    {
        public FarmingOilySpecialtySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingOilySpecialtySpecialtyTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 1;
        }
    }

}
