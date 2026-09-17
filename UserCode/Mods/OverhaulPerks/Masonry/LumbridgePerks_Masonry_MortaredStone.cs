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
    public partial class MasonryMortaredStoneSpecialtyTalent : Talent
    {
        public MasonryMortaredStoneSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Architectural Stone",
				typeof(MasonrySkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "MortaredStone" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.10f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Architectural Stone")]
    [LocDescription("Reduced cost for mortared stone. Makes all crafting a little slower.")]
    public partial class MasonryMortaredStoneSpecialtyTalentGroup : TalentGroup
    {
        public MasonryMortaredStoneSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MasonryMortaredStoneSpecialtyTalent),
            };
            this.OwningSkill = typeof(MasonrySkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
