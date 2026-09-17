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
    public partial class CookingFastFoodDiscountTalent : Talent
    {
        public CookingFastFoodDiscountTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Quick Bite"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(PupusasRecipe), typeof(LoadedTaroFriesRecipe), typeof(TaroFriesRecipe), typeof(CrispyBaconRecipe), typeof(SmoothGutNoodleRollRecipe) }, SkillTypes = new HashSet<Type> { typeof(CookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.85f, Cap = 0.55f, LowerIsBetter = true } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Quick Bite")]
    [LocDescription("Cheaper fast food. Can be taken three times.")]
    public partial class CookingFastFoodDiscountTalentGroup : TalentGroup
    {
        public CookingFastFoodDiscountTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CookingFastFoodDiscountTalent),
            };
            this.OwningSkill = typeof(CookingSkill);
            this.Level = 6;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
