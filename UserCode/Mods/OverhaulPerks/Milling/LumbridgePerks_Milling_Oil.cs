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
    public partial class MillingOilSpecialtyTalent : Talent
    {
        public MillingOilSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Well-Oiled Machine",
				typeof(MillingSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Oil" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.1f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Well-Oiled Machine")]
    [LocDescription("Reduced cost for oils. Makes all crafting a little slower.")]
    public partial class MillingOilSpecialtyTalentGroup : TalentGroup
    {
        public MillingOilSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MillingOilSpecialtyTalent),
            };
            this.OwningSkill = typeof(MillingSkill);
            this.Level = 1;
        }
    }

}
