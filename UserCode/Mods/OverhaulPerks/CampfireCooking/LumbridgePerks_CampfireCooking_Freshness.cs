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
    public partial class CampfireCookingFreshnessTalent : Talent
    {
        public CampfireCookingFreshnessTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Backyard Garden"),
                EffectDescription = Localizer.Do($"Increases freshness of all harvested crops by {Text.Positive("20%")}."),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestFreshness } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 1.2f, LowerIsBetter = false } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Backyard Garden")]
    [LocDescription("Increases the freshness of harvested crops by 20%.")]
    public partial class CampfireCookingFreshnessTalentGroup : TalentGroup
    {
        public CampfireCookingFreshnessTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CampfireCookingFreshnessTalent),
            };
            this.OwningSkill = typeof(CampfireCookingSkill);
            this.Level = 2;
        }
    }
    
}
