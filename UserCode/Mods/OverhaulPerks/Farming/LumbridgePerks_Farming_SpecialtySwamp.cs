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
    public partial class FarmingSwampSpecialtySpecialtyTalent : Talent
    {
        public FarmingSwampSpecialtySpecialtyTalent()
        {	
		
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Misty Marsh"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(BoleteMushroomSporesRecipe),typeof(CriminiMushroomSporesRecipe),typeof(CookeinaMushroomSporesRecipe),typeof(AmanitaMushroomSporesRecipe),typeof(CottonSeedRecipe),typeof(PumpkinSeedRecipe) }, SkillTypes = new HashSet<Type> { typeof(FarmingSkill) }  } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.90f, Cap = 0.5f, LowerIsBetter = true } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Misty Marsh"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(CottonSeedRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Misty Marsh")]
    [LocDescription("Reduced cost for seeds from the swamp region. Also unlocks cotton seeds.")]
    public partial class FarmingSwampSpecialtySpecialtyTalentGroup : TalentGroup
    {
        public FarmingSwampSpecialtySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingSwampSpecialtySpecialtyTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 1;
        }
    }

}
