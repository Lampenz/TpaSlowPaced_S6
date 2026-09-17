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
    public partial class MiningIronSpecialtyTalent : Talent
    {
        public MiningIronSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Gold Rush",
				typeof(MiningSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(IronConcentrateRecipe), typeof(ConcentrateDryIronRecipe), typeof(ConcentrateIronLv2Recipe), typeof(ConcentrateDryIronLv2Recipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.08f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Iron Specialty")]
    [LocDescription("Reduced cost for iron concentrate. Makes all crafting a little slower.")]
    public partial class MiningIronSpecialtyTalentGroup : TalentGroup
    {
        public MiningIronSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MiningIronSpecialtyTalent),
            };
            this.OwningSkill = typeof(MiningSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
