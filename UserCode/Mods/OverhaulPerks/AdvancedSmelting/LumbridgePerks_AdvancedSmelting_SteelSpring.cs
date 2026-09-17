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
    public partial class AdvancedSmeltingSteelSpringYieldTalent : Talent
    {
        public AdvancedSmeltingSteelSpringYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Coiled Steel"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(SteelSpringRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedSmeltingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Coiled Steel")]
    [LocDescription("Improved yield for steel springs.")]
    public partial class AdvancedSmeltingSteelSpringYieldTalentGroup : TalentGroup
    {
        public AdvancedSmeltingSteelSpringYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedSmeltingSteelSpringYieldTalent),
            };
            this.OwningSkill = typeof(AdvancedSmeltingSkill);
            this.Level = 2;
        }
    }

}
