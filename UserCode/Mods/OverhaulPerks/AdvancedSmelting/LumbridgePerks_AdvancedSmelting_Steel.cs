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
    public partial class AdvancedSmeltingSteelSpecialtyTalent : Talent
    {
        public AdvancedSmeltingSteelSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Heavy Metal",
				typeof(AdvancedSmeltingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(SteelBarRecipe), typeof(CharcoalSteelRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.125f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Heavy Metal")]
    [LocDescription("Reduced cost for steel. Makes all crafting a little slower.")]
    public partial class AdvancedSmeltingSteelSpecialtyTalentGroup : TalentGroup
    {
        public AdvancedSmeltingSteelSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedSmeltingSteelSpecialtyTalent),
            };
            this.OwningSkill = typeof(AdvancedSmeltingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
