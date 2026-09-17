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
    public partial class MechanicsVehiclesSpecialtyTalent : Talent
    {
        public MechanicsVehiclesSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Steam Power",
				typeof(MechanicsSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Vehicles" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.15f,
				numberOfLevels: 4);
			
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Steam Power")]
    [LocDescription("Reduced cost for vehicles. Makes all crafting a little slower.")]
    public partial class MechanicsVehiclesSpecialtyTalentGroup : TalentGroup
    {
        public MechanicsVehiclesSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MechanicsVehiclesSpecialtyTalent),
            };
            this.OwningSkill = typeof(MechanicsSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }
    
}
