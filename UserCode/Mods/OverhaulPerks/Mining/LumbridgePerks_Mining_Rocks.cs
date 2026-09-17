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
    public partial class MiningCrushedRockSpecialtyTalent : Talent
    {
        public MiningCrushedRockSpecialtyTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Quarry Master"),
				EffectDescription = Localizer.Do($"Increases output for rock crushing by {Text.Positive("+20%")} per level."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(CrushedShaleRecipe), typeof(CrushedLimestoneRecipe), typeof(CrushedGraniteRecipe), typeof(CrushedSandstoneRecipe),typeof(CrushedShaleLv2Recipe), typeof(CrushedLimestoneLv2Recipe), typeof(CrushedGraniteLv2Recipe), typeof(CrushedSandstoneLv2Recipe), typeof(CrushedBasaltLv2Recipe), typeof(CrushedGneissLv2Recipe),typeof(CrushedShaleLv3Recipe), typeof(CrushedLimestoneLv3Recipe), typeof(CrushedGraniteLv3Recipe), typeof(CrushedSandstoneLv3Recipe), typeof(CrushedBasaltLv3Recipe), typeof(CrushedGneissLv3Recipe)  }, SkillTypes = new HashSet<Type> { typeof(MiningSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.2f, Cap = 2f, LowerIsBetter = false } },
            });
			

			
        }
    }

    [Serialized]
    [LocDisplayName("Quarry Master")]
    [LocDescription("Improved yield when crushing rocks")]
    public partial class MiningCrushedRockSpecialtyTalentGroup : TalentGroup
    {
        public MiningCrushedRockSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MiningCrushedRockSpecialtyTalent),
            };
            this.OwningSkill = typeof(MiningSkill);
            this.Level = 1;
        }
    }

}
