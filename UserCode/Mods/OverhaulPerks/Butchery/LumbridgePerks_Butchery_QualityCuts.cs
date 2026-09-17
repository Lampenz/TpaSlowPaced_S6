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
    public partial class ButcheryQualityCutsSpecialtyTalent : Talent
    {
        public ButcheryQualityCutsSpecialtyTalent()
        {
			this.AddCostLaborTimeSpecialty(
				"Quality Cuts",
				typeof(ButcherySkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(PreparedMeatRecipe), typeof(PrimeCutRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.10f,
				numberOfLevels: 3);
				
        }
    }

    [Serialized]
    [LocDisplayName("Quality Cuts")]
    [LocDescription("Reduced cost for prepared meat and prime cuts. Makes all crafting a little slower.")]
    public partial class ButcheryQualityCutsSpecialtyTalentGroup : TalentGroup
    {
        public ButcheryQualityCutsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ButcheryQualityCutsSpecialtyTalent),
            };
            this.OwningSkill = typeof(ButcherySkill);
            this.Level = 3;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
