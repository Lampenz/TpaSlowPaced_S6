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
    public partial class PaintingPaintSpecialtyTalent : Talent
    {
        public PaintingPaintSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Brush & Barrel",
				typeof(PaintingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(BasePaintRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.20f,
				numberOfLevels: 3);
			
        }
    }

    [Serialized]
    [LocDisplayName("Brush & Barrel")]
    [LocDescription("Reduced cost for base paint. Makes all crafting a little slower.")]
    public partial class PaintingPaintSpecialtyTalentGroup : TalentGroup
    {
        public PaintingPaintSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PaintingPaintSpecialtyTalent),
            };
            this.OwningSkill = typeof(PaintingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
