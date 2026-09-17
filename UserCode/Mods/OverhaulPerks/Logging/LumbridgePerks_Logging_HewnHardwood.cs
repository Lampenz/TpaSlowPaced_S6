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
    public partial class LoggingHardwoodHewnLogSpecialtyTalent : Talent
    {
        public LoggingHardwoodHewnLogSpecialtyTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hard Hand"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SpecialistHardwoodHewnLogRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
            this.AddCostLaborTimeSpecialty(
				"Hard Hand",
				typeof(LoggingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type>
					{
						typeof(SpecialistHardwoodHewnLogRecipe)
					}
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.12f,
				numberOfLevels: 5);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Hard Hand")]
    [LocDescription("Reduced cost for hardwood hewn specifically. Makes all crafting a little slower.")]
    public partial class LoggingHardwoodHewnLogSpecialtyTalentGroup : TalentGroup
    {
        public LoggingHardwoodHewnLogSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingHardwoodHewnLogSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
