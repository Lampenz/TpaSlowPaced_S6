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
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
	using Eco.Shared.Items;
	using Eco.Shared.View;
	using Eco.Shared.Serialization;
    using Eco.Simulation.WorldLayers;
	using Eco.Mods.TechTree;
    
	[Serialized]
    public partial class PaintingPigmentSpecialtyTalent : Talent
    {
        public PaintingPigmentSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Colors of the Wind",
				typeof(PaintingSkill),
				new CraftBonusCause
				{
					ItemTags = new HashSet<string> { "Pigment" }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.2f,
				numberOfLevels: 3);
			
        }
    }

    [Serialized]
    [LocDisplayName("Colors of the Wind")]
    [LocDescription("Reduced cost for pigments. Makes all crafting a little slower.")]
    public partial class PaintingPigmentSpecialtyTalentGroup : TalentGroup
    {
        public PaintingPigmentSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PaintingPigmentSpecialtyTalent),
            };
            this.OwningSkill = typeof(PaintingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
