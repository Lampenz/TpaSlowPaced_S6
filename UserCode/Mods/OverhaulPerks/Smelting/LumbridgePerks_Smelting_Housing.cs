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
    public partial class SmeltingHousingTalent : Talent
    {
        public SmeltingHousingTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Cast in Iron"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Housing" }, SkillTypes = new HashSet<System.Type> { typeof(SmeltingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Cast in Iron")]
    [LocDescription("Reduces the cost of all cast iron furniture")]
    public partial class SmeltingHousingTalentGroup : TalentGroup
    {
        public SmeltingHousingTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(SmeltingHousingTalent),
            };
            this.OwningSkill = typeof(SmeltingSkill);
            this.Level = 2;
        }
    }

}
