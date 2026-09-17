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
    public partial class CarpentryHousingSpecialtyTalent : Talent
    {
        public CarpentryHousingSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Lumber Construction",
				typeof(CarpentrySkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Housing" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 3);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Lumber Construction")]
    [LocDescription("Reduced cost for lumber furniture. Makes all crafting a little slower.")]
    public partial class CarpentryHousingSpecialtyTalentGroup : TalentGroup
    {
        public CarpentryHousingSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CarpentryHousingSpecialtyTalent),
            };
            this.OwningSkill = typeof(CarpentrySkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }


	
    
}
