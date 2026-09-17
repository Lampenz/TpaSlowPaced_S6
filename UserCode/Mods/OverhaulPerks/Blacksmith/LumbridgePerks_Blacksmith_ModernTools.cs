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
    public partial class BlacksmithModernToolsSpecialtyTalent : Talent
    {
        public BlacksmithModernToolsSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Precision Machining",
				"modern tools",
				typeof(BlacksmithSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(ModernShovelRecipe), typeof(ModernAxeRecipe), typeof(ModernMacheteRecipe), typeof(ModernPickaxeRecipe), typeof(ModernHammerRecipe), typeof(ModernHoeRecipe), typeof(ModernRockDrillRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.08f,
				numberOfLevels: 5);
			
        }
    }

    [Serialized]
    [LocDisplayName("Precision Machining")]
    [LocDescription("Reduced cost for modern tools. Makes all crafting a little slower.")]
    public partial class BlacksmithModernToolsSpecialtyTalentGroup : TalentGroup
    {
        public BlacksmithModernToolsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithModernToolsSpecialtyTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
