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
    public partial class BakingBakedVegetablesSpecialtyTalent : Talent
    {
        public BakingBakedVegetablesSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Roasted Roots",
				typeof(BakingSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "BakedVegetables" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.15f,
				numberOfLevels: 4);

        }
    }

    [Serialized]
    [LocDisplayName("Roasted Roots")]
    [LocDescription("Reduced cost for baked vegetables. Makes all crafting a little slower.")]
    public partial class BakingBakedVegetablesSpecialtyTalentGroup : TalentGroup
    {
        public BakingBakedVegetablesSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BakingBakedVegetablesSpecialtyTalent),
            };
            this.OwningSkill = typeof(BakingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
