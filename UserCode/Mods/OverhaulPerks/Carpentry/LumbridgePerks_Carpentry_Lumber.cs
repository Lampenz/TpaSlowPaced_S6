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
	public partial class CarpentryLumberSpecialtyTalent : Talent
	{
		public CarpentryLumberSpecialtyTalent()
		{
			this.AddCostLaborTimeSpecialty(
				"Lumber Fabrication",
				typeof(CarpentrySkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(LumberRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.10f,
				numberOfLevels: 5);
		}
	}

    [Serialized]
    [LocDisplayName("Lumber Fabrication")]
    [LocDescription("Reduced cost for lumber. Makes all crafting a little slower.")]
    public partial class CarpentryLumberSpecialtyTalentGroup : TalentGroup
    {
        public CarpentryLumberSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CarpentryLumberSpecialtyTalent),
            };
            this.OwningSkill = typeof(CarpentrySkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
