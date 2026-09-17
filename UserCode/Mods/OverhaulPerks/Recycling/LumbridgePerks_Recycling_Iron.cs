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
    public partial class RecyclingIronYieldTalent : Talent
    {
        public RecyclingIronYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Back to the Forge"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(RecycledIronBarRecipe) }, SkillTypes = new HashSet<Type> { typeof(RecyclingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Back to the Forge")]
    [LocDescription("Increase yield for recycling iron.")]
    public partial class RecyclingIronYieldTalentGroup : TalentGroup
    {
        public RecyclingIronYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(RecyclingIronYieldTalent),
            };
            this.OwningSkill = typeof(RecyclingSkill);
            this.Level = 2;
        }
    }

}
