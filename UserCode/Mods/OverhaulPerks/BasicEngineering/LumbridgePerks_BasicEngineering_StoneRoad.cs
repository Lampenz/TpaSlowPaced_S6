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
    public partial class BasicEngineeringStoneRoadSpecialtyTalent : Talent
    {
        public BasicEngineeringStoneRoadSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Stone by Stone",
				typeof(BasicEngineeringSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(StoneRoadRecipe),typeof(CheaperStoneRoadRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 3);
			
        }
    }

    [Serialized]
    [LocDisplayName("Stone by Stone")]
    [LocDescription("Reduced cost for stone roads. Makes all crafting a little slower.")]
    public partial class BasicEngineeringStoneRoadSpecialtyTalentGroup : TalentGroup
    {
        public BasicEngineeringStoneRoadSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BasicEngineeringStoneRoadSpecialtyTalent),
            };
            this.OwningSkill = typeof(BasicEngineeringSkill);
            this.Level = 2;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
