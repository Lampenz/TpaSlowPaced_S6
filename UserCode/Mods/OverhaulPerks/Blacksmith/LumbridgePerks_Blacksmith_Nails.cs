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
    public partial class BlacksmithNailsSpecialtyTalent : Talent
    {
        public BlacksmithNailsSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Nailed It",
				typeof(BlacksmithSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(NailRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.25f,
				numberOfLevels: 2);
			
        }
    }

    [Serialized]
    [LocDisplayName("Nailed It")]
    [LocDescription("Reduced cost for nails. Makes all crafting a little slower.")]
    public partial class BlacksmithNailsSpecialtyTalentGroup : TalentGroup
    {
        public BlacksmithNailsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithNailsSpecialtyTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
