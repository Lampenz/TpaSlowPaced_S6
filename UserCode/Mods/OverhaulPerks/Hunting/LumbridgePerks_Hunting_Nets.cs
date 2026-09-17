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
    public partial class HuntingNetsYieldYieldTalent : Talent
    {
        public HuntingNetsYieldYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sure Catch"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(FlaxTrawlerNetRecipe), typeof(NylonTrawlerNetRecipe) }, SkillTypes = new HashSet<Type> { typeof(HuntingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Sure Catch")]
    [LocDescription("Triple yield when making nets.")]
    public partial class HuntingNetsYieldYieldTalentGroup : TalentGroup
    {
        public HuntingNetsYieldYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(HuntingNetsYieldYieldTalent),
            };
            this.OwningSkill = typeof(HuntingSkill);
            this.Level = 2;
        }
    }

}
