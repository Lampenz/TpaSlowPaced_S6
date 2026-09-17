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
    public partial class GatheringCottonLintSpecialtyTalent : Talent
    {
        public GatheringCottonLintSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Cotton Gin"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(CottonLintRecipe) }, SkillTypes = new HashSet<Type> { typeof(GatheringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Cotton Gin")]
    [LocDescription("Increased yield when making cotton lints")]
    public partial class GatheringCottonLintSpecialtyTalentGroup : TalentGroup
    {
        public GatheringCottonLintSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GatheringCottonLintSpecialtyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 2;
        }
    }

}
