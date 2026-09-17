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
    public partial class SmeltingIronSpecialtyTalent : Talent
    {
        public SmeltingIronSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Forge Fire",
				typeof(SmeltingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(IronBarRecipe), typeof(SmeltIronRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.08f,
				numberOfLevels: 8);
			
        }
    }

    [Serialized]
    [LocDisplayName("Forge Fire")]
    [LocDescription("Reduced cost for iron bars. Makes all crafting a little slower.")]
    public partial class SmeltingIronSpecialtyTalentGroup : TalentGroup
    {
        public SmeltingIronSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(SmeltingIronSpecialtyTalent),
            };
            this.OwningSkill = typeof(SmeltingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 8; set { } }
    }

}
