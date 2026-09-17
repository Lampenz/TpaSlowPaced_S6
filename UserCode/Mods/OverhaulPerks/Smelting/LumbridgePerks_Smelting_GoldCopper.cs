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
    public partial class SmeltingGoldCopperSpecialtyTalent : Talent
    {
        public SmeltingGoldCopperSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Foundry Fire",
				typeof(SmeltingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(GoldBarRecipe),typeof(SmeltGoldRecipe), typeof(CopperBarRecipe), typeof(SmeltCopperRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.12f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Foundry Fire")]
    [LocDescription("Reduced cost for copper and gold bars. Makes all crafting a little slower.")]
    public partial class SmeltingGoldCopperSpecialtyTalentGroup : TalentGroup
    {
        public SmeltingGoldCopperSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(SmeltingGoldCopperSpecialtyTalent),
            };
            this.OwningSkill = typeof(SmeltingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
