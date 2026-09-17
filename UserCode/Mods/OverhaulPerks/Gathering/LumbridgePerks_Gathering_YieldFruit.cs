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
    public partial class GatheringFruitYieldSpecialtyTalent : Talent
    {
        public GatheringFruitYieldSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Orchard Keeper"),
                Causes = new List<BonusCause> { new HarvestBonusCause { Action = BonusAction.HarvestYield, ItemTags = new HashSet<string> { "Fruit" } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.20f, Cap = 3f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Orchard Keeper")]
    [LocDescription("Increased yield when harvesting fruit.")]
    public partial class GatheringFruitYieldSpecialtyTalentGroup : TalentGroup
    {
        public GatheringFruitYieldSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GatheringFruitYieldSpecialtyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 1;
			this.StarCost = 1;
        }
		public override int MaxTalentLevel { get => 10; set { } }
    }

}
