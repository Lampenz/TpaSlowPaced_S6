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
    public partial class FertilizersFertilizerFillerYieldTalent : Talent
    {
        public FertilizersFertilizerFillerYieldTalent()
        {
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Filler Yield"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, ItemTags = new HashSet<string> { "FertilizerFiller" }, SkillTypes = new HashSet<Type> { typeof(FertilizersSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Filler Yield")]
    [LocDescription("Increased yield when making fertilizer filler.")]
    public partial class FertilizersFertilizerFillerYieldTalentGroup : TalentGroup
    {
        public FertilizersFertilizerFillerYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FertilizersFertilizerFillerYieldTalent),
            };
            this.OwningSkill = typeof(FertilizersSkill);
            this.Level = 2;
        }
    }

}
