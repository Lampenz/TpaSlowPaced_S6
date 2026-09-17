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
    public partial class ElectronicsWorktablesTalent : Talent
    {
        public ElectronicsWorktablesTalent()
        {
			
			this.AddCostLaborTimeSpecialty(
				"Electrification",
				typeof(ElectronicsSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Crafting Table" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 3);
			
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Electrification")]
    [LocDescription("Reduced cost for workstations. Makes all crafting a little slower.")]
    public partial class ElectronicsWorktablesTalentGroup : TalentGroup
    {
        public ElectronicsWorktablesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ElectronicsWorktablesTalent),
            };
            this.OwningSkill = typeof(ElectronicsSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }
    
}
