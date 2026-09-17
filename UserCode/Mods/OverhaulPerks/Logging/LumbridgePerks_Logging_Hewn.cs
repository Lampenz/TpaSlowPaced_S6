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
    public partial class LoggingHewnLogSpecialtyTalent : Talent
    {
        public LoggingHewnLogSpecialtyTalent()
        {
			

			this.AddCostLaborTimeSpecialty(
				"Steady Hands",
				typeof(LoggingSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "HewnLog" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.10f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Steady Hands")]
    [LocDescription("Reduced cost for hewn logs. Makes all crafting a little slower.")]
    public partial class LoggingHewnLogSpecialtyTalentGroup : TalentGroup
    {
        public LoggingHewnLogSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingHewnLogSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
