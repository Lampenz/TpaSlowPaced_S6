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
    public partial class ButcheryScrapMeatYieldTalent : Talent
    {
        public ButcheryScrapMeatYieldTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Pulled Apart"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(ScrapMeatRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Pulled Apart")]
    [LocDescription("Increase yield of scrap meat by +2.")]
    public partial class ButcheryScrapMeatYieldTalentGroup : TalentGroup
    {
        public ButcheryScrapMeatYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ButcheryScrapMeatYieldTalent),
            };
            this.OwningSkill = typeof(ButcherySkill);
            this.Level = 2;
        }
    }

}
