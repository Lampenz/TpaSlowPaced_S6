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
    public partial class FarmingFasterNonPerennialsTalent : Talent
    {
        public FarmingFasterNonPerennialsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Seedling Transplants"),
                EffectDescription = Localizer.Do($"Planted crops start with {Text.Positive("20%")} more maturity."),
                Causes = new List<BonusCause> { new ActionCause { Action = BonusAction.PlantMaturity } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 0.2f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Seedling Transplants")]
    [LocDescription("Plants start with 20% more maturity, but leaves perennials locked.")]
    public partial class FarmingFasterNonPerennialsTalentGroup : TalentGroup
    {
        public FarmingFasterNonPerennialsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingFasterNonPerennialsTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 2;
        }
    }
    
}
