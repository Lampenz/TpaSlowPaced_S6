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
    public partial class CampfireCookingCampfireStewSpecialtyTalent : Talent
    {
        public CampfireCookingCampfireStewSpecialtyTalent()
        {
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Slow Simmer"),
				EffectDescription = Localizer.Do($"Unlocks stews. Either this or Stew Maker is enough to unlock stews."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(JungleCampfireStewRecipe),typeof(RootCampfireStewRecipe),typeof(FieldCampfireStewRecipe),typeof(MeatyStewRecipe),typeof(FishStewRecipe),typeof(WildStewRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
			this.AddCostLaborTimeSpecialty(
				"Slow Simmer",
				typeof(CampfireCookingSkill),
				new CraftBonusCause
				{
					Recipes = new HashSet<Type> { typeof(FishStewRecipe),typeof(RootCampfireStewRecipe),typeof(MeatyStewRecipe),typeof(WildStewRecipe),typeof(JungleCampfireStewRecipe),typeof(FieldCampfireStewRecipe) }
				},
				isVariantSpecialization: false,
				resourceDiscount: 0.1f,
				numberOfLevels: 5);
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Slow Simmer")]
    [LocDescription("Reduced cost for stews. Makes all crafting a little slower.")]
    public partial class CampfireCookingCampfireStewSpecialtyTalentGroup : TalentGroup
    {
        public CampfireCookingCampfireStewSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CampfireCookingCampfireStewSpecialtyTalent),
            };
            this.OwningSkill = typeof(CampfireCookingSkill);
            this.Level = 1;
        }
		public override int MaxTalentLevel { get => 5; set { } }
    }

}
