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
    public partial class RecyclingGoldYieldTalent : Talent
    {
        public RecyclingGoldYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Second Mint"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(RecycledGoldBarRecipe) }, SkillTypes = new HashSet<Type> { typeof(RecyclingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 2f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Second Mint")]
    [LocDescription("Increase yield for recycling gold.")]
    public partial class RecyclingGoldYieldTalentGroup : TalentGroup
    {
        public RecyclingGoldYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(RecyclingGoldYieldTalent),
            };
            this.OwningSkill = typeof(RecyclingSkill);
            this.Level = 2;
        }
    }

}
