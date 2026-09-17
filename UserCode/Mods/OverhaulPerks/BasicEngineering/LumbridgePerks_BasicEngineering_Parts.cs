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
    public partial class BasicEngineeringPartsSpecialtyTalent : Talent
    {
        public BasicEngineeringPartsSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Precision Machining"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Durability, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(BasicEngineeringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.4f, Cap = 3.0f, LowerIsBetter = false } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Precision Machining"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Integrity, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(BasicEngineeringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.4f, Cap = 3.0f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Precision Machining")]
    [LocDescription("Improves how long your wheels and gears last.")]
    public partial class BasicEngineeringPartsSpecialtyTalentGroup : TalentGroup
    {
        public BasicEngineeringPartsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BasicEngineeringPartsSpecialtyTalent),
            };
            this.OwningSkill = typeof(BasicEngineeringSkill);
            this.Level = 3;
        }
    }

}
