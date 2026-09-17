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
    public partial class BlacksmithIronToolsSpecialtyTalent : Talent
    {
        public BlacksmithIronToolsSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Village Smith",
				"iron tools",
				typeof(BlacksmithSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(IronShovelRecipe), typeof(IronAxeRecipe), typeof(IronMacheteRecipe), typeof(IronSickleRecipe), typeof(IronPickaxeRecipe), typeof(IronHammerRecipe), typeof(IronHoeRecipe), typeof(IronRockDrillRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.125f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Village Smith")]
    [LocDescription("Reduced cost for iron tools. Makes all crafting a little slower.")]
    public partial class BlacksmithIronToolsSpecialtyTalentGroup : TalentGroup
    {
        public BlacksmithIronToolsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithIronToolsSpecialtyTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
