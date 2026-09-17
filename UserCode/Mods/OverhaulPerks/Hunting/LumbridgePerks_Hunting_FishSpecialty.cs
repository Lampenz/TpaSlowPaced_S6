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
    public partial class HuntingRawFishSpecialtyTalent : Talent
    {
        public HuntingRawFishSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Fresh Catch",
				typeof(HuntingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(CleanMediumFishRecipe), typeof(CleanLargeFishRecipe), typeof(CleanPacificSardineRecipe), typeof(CleanUrchinsRecipe), typeof(CleanCrabRecipe), typeof(CleanMoonJellyfishRecipe), typeof(ShuckClamsRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.25f,
				numberOfLevels: 2);
			
        }
    }

    [Serialized]
    [LocDisplayName("Fresh Catch")]
    [LocDescription("Reduced cost for raw fish. Makes all crafting a little slower.")]
    public partial class HuntingRawFishSpecialtyTalentGroup : TalentGroup
    {
        public HuntingRawFishSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(HuntingRawFishSpecialtyTalent),
            };
            this.OwningSkill = typeof(HuntingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
