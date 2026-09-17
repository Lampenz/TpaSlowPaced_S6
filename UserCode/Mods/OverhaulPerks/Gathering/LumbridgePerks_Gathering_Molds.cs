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
    public partial class GatheringClayMoldSpecialtyTalent : Talent
    {
        public GatheringClayMoldSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Clay Shaper"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(ClayMoldRecipe) }, SkillTypes = new HashSet<Type> { typeof(GatheringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 3f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Clay Shaper")]
    [LocDescription("Increased yield when making clay molds.")]
    public partial class GatheringClayMoldSpecialtyTalentGroup : TalentGroup
    {
        public GatheringClayMoldSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GatheringClayMoldSpecialtyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 2;
        }
    }

}
