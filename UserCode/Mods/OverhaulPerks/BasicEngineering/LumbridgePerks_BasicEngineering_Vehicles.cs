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
    public partial class BasicEngineeringVehicleSpecialtyTalent : Talent
    {
        public BasicEngineeringVehicleSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Wainwright",
				typeof(BasicEngineeringSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Vehicles" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Wainwright")]
    [LocDescription("Reduced cost for carts. Makes all crafting a little slower.")]
    public partial class BasicEngineeringVehicleSpecialtyTalentGroup : TalentGroup
    {
        public BasicEngineeringVehicleSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BasicEngineeringVehicleSpecialtyTalent),
            };
            this.OwningSkill = typeof(BasicEngineeringSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
