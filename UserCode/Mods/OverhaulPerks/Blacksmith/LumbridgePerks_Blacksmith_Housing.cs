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
    public partial class BlacksmithHousingTalent : Talent
    {
        public BlacksmithHousingTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Home & Hearth"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Housing" }, SkillTypes = new HashSet<System.Type> { typeof(BlacksmithSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Home & Hearth")]
    [LocDescription("Reduces the cost of metal furniture")]
    public partial class BlacksmithHousingTalentGroup : TalentGroup
    {
        public BlacksmithHousingTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithHousingTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 2;
        }
    }

}
