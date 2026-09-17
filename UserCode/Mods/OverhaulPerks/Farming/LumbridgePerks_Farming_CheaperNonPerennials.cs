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
    public partial class FarmingNonPerennialSeedsTalent : Talent
    {
        public FarmingNonPerennialSeedsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Seed Saver"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, ItemTags = new HashSet<string> { "Seed" } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 3f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Seed Saver")]
    [LocDescription("Increases seed yield, but leaves perennials locked.")]
    public partial class FarmingNonPerennialSeedsTalentGroup : TalentGroup
    {
        public FarmingNonPerennialSeedsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingNonPerennialSeedsTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 2;
        }
    }
    
}
