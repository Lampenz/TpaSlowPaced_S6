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
    public partial class CookingFruitSaladSpecialtyTalent : Talent
    {
        public CookingFruitSaladSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Berry Blessed",
				typeof(CookingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(ExoticFruitSaladRecipe),typeof(RainforestFruitSaladRecipe),typeof(MixedFruitSaladRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.15f,
				numberOfLevels: 4);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Berry Blessed")]
    [LocDescription("Reduced cost for fruit salads. Makes all crafting a little slower.")]
    public partial class CookingFruitSaladSpecialtyTalentGroup : TalentGroup
    {
        public CookingFruitSaladSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CookingFruitSaladSpecialtyTalent),
            };
            this.OwningSkill = typeof(CookingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
