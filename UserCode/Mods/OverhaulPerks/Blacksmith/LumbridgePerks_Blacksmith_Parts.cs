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
    public partial class BlacksmithPartsTalent : Talent
    {
        public BlacksmithPartsTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Factory Floor"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<System.Type> { typeof(BlacksmithSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Factory Floor")]
    [LocDescription("Reduces the cost of parts")]
    public partial class BlacksmithPartsTalentGroup : TalentGroup
    {
        public BlacksmithPartsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithPartsTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 2;
        }
    }

}
