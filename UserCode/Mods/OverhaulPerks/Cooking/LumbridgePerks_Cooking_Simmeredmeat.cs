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
    public partial class CookingSimmeredMeatSpecialtyTalent : Talent
    {
        public CookingSimmeredMeatSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Gentle Simmer",
				typeof(CookingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(SimmeredMeatRecipe),typeof(MixedSimmeredMeatRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.12f,
				numberOfLevels: 5);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Gentle Simmer")]
    [LocDescription("Reduced cost for simmered meat. Makes all crafting a little slower.")]
    public partial class CookingSimmeredMeatSpecialtyTalentGroup : TalentGroup
    {
        public CookingSimmeredMeatSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CookingSimmeredMeatSpecialtyTalent),
            };
            this.OwningSkill = typeof(CookingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
