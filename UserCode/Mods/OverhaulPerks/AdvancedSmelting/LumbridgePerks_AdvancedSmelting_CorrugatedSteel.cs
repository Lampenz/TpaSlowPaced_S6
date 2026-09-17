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
    public partial class AdvancedSmeltingCorrugatedSteelSpecialtyTalent : Talent
    {
        public AdvancedSmeltingCorrugatedSteelSpecialtyTalent()
        {
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Ripple Effect"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(CorrugatedSteelRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedSmeltingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 4f } },
            });
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Ripple Effect")]
    [LocDescription("Better yield for for corrugated steel.")]
    public partial class AdvancedSmeltingCorrugatedSteelSpecialtyTalentGroup : TalentGroup
    {
        public AdvancedSmeltingCorrugatedSteelSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedSmeltingCorrugatedSteelSpecialtyTalent),
            };
            this.OwningSkill = typeof(AdvancedSmeltingSkill);
            this.Level = 3;
        }
    }

}
