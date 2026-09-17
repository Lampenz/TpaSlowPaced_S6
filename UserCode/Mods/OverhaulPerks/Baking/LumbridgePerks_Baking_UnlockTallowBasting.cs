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
    public partial class BakingUnlockTallowBastingTalent : Talent
    {
        public BakingUnlockTallowBastingTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fat is Flavor"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(RoastPumpkinTallowRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fat is Flavor"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(TallowBastedRoastRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Fat is Flavor")]
    [LocDescription("Unlock more efficient recipes for pumpkin and roast, basted in tallow.")]
    public partial class BakingUnlockTallowBastingTalentGroup : TalentGroup
    {
        public BakingUnlockTallowBastingTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BakingUnlockTallowBastingTalent),
            };
            this.OwningSkill = typeof(BakingSkill);
            this.Level = 3;
        }
    }
    
}
