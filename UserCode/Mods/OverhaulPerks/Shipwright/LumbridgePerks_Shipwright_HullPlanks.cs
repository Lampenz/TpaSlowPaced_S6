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
    public partial class ShipwrightHullPlankSpecialtyTalent : Talent
    {
        public ShipwrightHullPlankSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Hullwright",
				typeof(ShipwrightSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(WoodenHullPlanksRecipe), typeof(BoardsWoodenHullPlanksRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.125f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Hullwright")]
    [LocDescription("Reduced cost for wooden hull planks. Makes all crafting a little slower.")]
    public partial class ShipwrightHullPlankSpecialtyTalentGroup : TalentGroup
    {
        public ShipwrightHullPlankSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ShipwrightHullPlankSpecialtyTalent),
            };
            this.OwningSkill = typeof(ShipwrightSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
