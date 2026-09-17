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
    public partial class LoggingSoftwoodHewnLogSpecialtyTalent : Talent
    {
        public LoggingSoftwoodHewnLogSpecialtyTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Soft Touch"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SpecialistSoftwoodHewnLogRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			this.AddCostLaborTimeSpecialty(
				"Soft Touch",
				typeof(LoggingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type>
					{
						typeof(SpecialistSoftwoodHewnLogRecipe)
					}
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.12f,
				numberOfLevels: 5);
			
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Soft Touch")]
    [LocDescription("Reduced cost for softwood hewn specifically. Makes all crafting a little slower.")]
    public partial class LoggingSoftwoodHewnLogSpecialtyTalentGroup : TalentGroup
    {
        public LoggingSoftwoodHewnLogSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingSoftwoodHewnLogSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
