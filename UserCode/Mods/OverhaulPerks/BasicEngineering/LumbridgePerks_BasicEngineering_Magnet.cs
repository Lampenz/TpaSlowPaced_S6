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
    public partial class BasicEngineeringMagnetYieldTalent : Talent
    {
        public BasicEngineeringMagnetYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hidden Attraction"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(MagnetRecipe) }, SkillTypes = new HashSet<Type> { typeof(BasicEngineeringSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Hidden Attraction")]
    [LocDescription("Increased yield for magnets.")]
    public partial class BasicEngineeringMagnetYieldTalentGroup : TalentGroup
    {
        public BasicEngineeringMagnetYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BasicEngineeringMagnetYieldTalent),
            };
            this.OwningSkill = typeof(BasicEngineeringSkill);
            this.Level = 3;
        }
    }

}
