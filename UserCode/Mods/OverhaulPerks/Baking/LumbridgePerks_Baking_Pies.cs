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
    public partial class BakingPiesYieldTalent : Talent
    {
        public BakingPiesYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Perfect Pastry"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(MeatPieRecipe), typeof(HuckleberryPieRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 0.5f } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Perfect Pastry"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(MeatPieRecipe), typeof(HuckleberryPieRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Perfect Pastry")]
    [LocDescription("Improve efficiency making pies.")]
    public partial class BakingPiesYieldTalentGroup : TalentGroup
    {
        public BakingPiesYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BakingPiesYieldTalent),
            };
            this.OwningSkill = typeof(BakingSkill);
            this.Level = 6;
        }
    }
    
}
