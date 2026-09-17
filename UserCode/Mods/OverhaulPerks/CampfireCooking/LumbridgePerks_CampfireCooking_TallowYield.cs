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
    public partial class CampfireCookingTallowYieldSpecialtyTalent : Talent
    {
        public CampfireCookingTallowYieldSpecialtyTalent()
        {	
			this.Value = 2.0f;
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Slow Rendering"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<System.Type> { typeof(RenderFatRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 2f, LowerIsBetter = false } },
            });
			
        }
		
		
		
    }

    [Serialized]
    [LocDisplayName("Slow Rendering")]
    [LocDescription("Doubles the tallow output for any campfire recipe producing tallow.")]
    public partial class CampfireCookingTallowYieldSpecialtyTalentGroup : TalentGroup
    {
        public CampfireCookingTallowYieldSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CampfireCookingTallowYieldSpecialtyTalent),
            };
            this.OwningSkill = typeof(CampfireCookingSkill);
            this.Level = 2;
        }
    }

}
