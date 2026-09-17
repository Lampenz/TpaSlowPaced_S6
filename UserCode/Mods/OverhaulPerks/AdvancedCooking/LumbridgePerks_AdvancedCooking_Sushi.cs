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
    public partial class AdvancedCookingSushiSpecialtyTalent : Talent
    {
        public AdvancedCookingSushiSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sushi Special"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(HosomakiRecipe),typeof(KelpyCrabRollRecipe),typeof(SpikyRollRecipe),typeof(SeededCamasRollRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedCookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Sushi Special")]
    [LocDescription("Better yield for sushi recipes.")]
    public partial class AdvancedCookingSushiSpecialtyTalentGroup : TalentGroup
    {
        public AdvancedCookingSushiSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedCookingSushiSpecialtyTalent),
            };
            this.OwningSkill = typeof(AdvancedCookingSkill);
            this.Level = 3;
        }
    }

}
