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
    public partial class GlassworkingGlassSpecialtyTalent : Talent
    {
        public GlassworkingGlassSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Glassblowing",
				typeof(GlassworkingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(GlassRecipe), typeof(QuicklimeGlassRecipe), typeof(PotashGlassRecipe)  }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.125f,
				numberOfLevels: 4);
			
        }
    }

    [Serialized]
    [LocDisplayName("Glassblowing")]
    [LocDescription("Reduced cost for regular glass. Makes all crafting a little slower.")]
    public partial class GlassworkingGlassSpecialtyTalentGroup : TalentGroup
    {
        public GlassworkingGlassSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GlassworkingGlassSpecialtyTalent),
            };
            this.OwningSkill = typeof(GlassworkingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 4; set { } }
    }

}
