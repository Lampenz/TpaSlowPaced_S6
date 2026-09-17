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
    public partial class TailoringNonNonLinenFabricSpecialtyTalent : Talent
    {
        public TailoringNonNonLinenFabricSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Common Cloth",
				typeof(TailoringSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(WoolFabricRecipe), typeof(WeaveWoolFabricRecipe), typeof(CottonFabricRecipe), typeof(WeaveCottonFabricRecipe), typeof(WeaveNylonFabricRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 3);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Common Cloth")]
    [LocDescription("Reduced cost for wool, cotton, and nylon fabrics. Makes all crafting a little slower.")]
    public partial class TailoringNonNonLinenFabricSpecialtyTalentGroup : TalentGroup
    {
        public TailoringNonNonLinenFabricSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(TailoringNonNonLinenFabricSpecialtyTalent),
            };
            this.OwningSkill = typeof(TailoringSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }


	
    
}
