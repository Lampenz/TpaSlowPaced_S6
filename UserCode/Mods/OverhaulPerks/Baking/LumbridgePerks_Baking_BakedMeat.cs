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
    public partial class BakingBakedMeatSpecialtyTalent : Talent
    {
        public BakingBakedMeatSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Golden Roast",
				typeof(BakingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(BakedMeatRecipe), typeof(BakedPreparedMeatRecipe), typeof(BakedRoastRecipe), typeof(OilBastedRoastRecipe), typeof(TallowBastedRoastRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.1f,
				numberOfLevels: 3);
			
        }
    }

    [Serialized]
    [LocDisplayName("Golden Roast")]
    [LocDescription("Reduced cost for baked meat and roast. Makes all crafting a little slower.")]
    public partial class BakingBakedMeatSpecialtyTalentGroup : TalentGroup
    {
        public BakingBakedMeatSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BakingBakedMeatSpecialtyTalent),
            };
            this.OwningSkill = typeof(BakingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }


	
    
}
