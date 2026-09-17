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
    public partial class CampfireCookingSaladsSpecialtyTalent : Talent
    {
        public CampfireCookingSaladsSpecialtyTalent()
        {	
			
			this.AddCostLaborTimeSpecialty(
				"Woodland Greens",
				typeof(CampfireCookingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(FernCampfireSaladRecipe),typeof(RootCampfireSaladRecipe),typeof(BeetCampfireSaladRecipe),typeof(JungleCampfireSaladRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.1f,
				numberOfLevels: 5);
			
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Woodland Greens")]
    [LocDescription("Reduced cost for campfire salads. Makes all crafting a little slower.")]
    public partial class CampfireCookingSaladsSpecialtyTalentGroup : TalentGroup
    {
        public CampfireCookingSaladsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CampfireCookingSaladsSpecialtyTalent),
            };
            this.OwningSkill = typeof(CampfireCookingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
