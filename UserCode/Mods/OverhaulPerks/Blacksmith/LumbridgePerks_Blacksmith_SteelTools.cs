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
    public partial class BlacksmithSteelToolsSpecialtyTalent : Talent
    {
        public BlacksmithSteelToolsSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Cutting Edge",
				"steel tools",
				typeof(BlacksmithSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(SteelShovelRecipe), typeof(SteelAxeRecipe), typeof(SteelMacheteRecipe), typeof(SteelSickleRecipe), typeof(SteelPickaxeRecipe), typeof(SteelHammerRecipe), typeof(SteelHoeRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.10f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Cutting Edge")]
    [LocDescription("Reduced cost for steel tools. Makes all crafting a little slower.")]
    public partial class BlacksmithSteelToolsSpecialtyTalentGroup : TalentGroup
    {
        public BlacksmithSteelToolsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithSteelToolsSpecialtyTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
