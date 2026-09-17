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
    public partial class MillingFlourSpecialtyTalent : Talent
    {
        public MillingFlourSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Flour Power",
				typeof(MillingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(FlourRecipe), typeof(RiceFlourRecipe), typeof(CornmealRecipe), typeof(ProcessedFlourRecipe), typeof(ProcessedRiceFlourRecipe), typeof(ProcessedCornmealRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.15f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Flour Power")]
    [LocDescription("Reduced cost for flour, rice flour, and cornmeal. Makes all crafting a little slower.")]
    public partial class MillingFlourSpecialtyTalentGroup : TalentGroup
    {
        public MillingFlourSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MillingFlourSpecialtyTalent),
            };
            this.OwningSkill = typeof(MillingSkill);
            this.Level = 1;
        }
    }

}
