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
    public partial class MillingFlaxseedOilYieldSpecialtyTalent : Talent
    {
        public MillingFlaxseedOilYieldSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Non-Food-Grade Workshop"),
                EffectDescription = Localizer.Do($"Increase flaxseed oil yield by {Text.Positive("+0.2")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(FlaxseedOilRecipe), typeof(ProcesssedFlaxseedOilRecipe) }, SkillTypes = new HashSet<Type> { typeof(MillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 0.2f } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Non-Food-Grade Workshop"),
                EffectDescription = Localizer.Do($"Decreases cheese yield by {Text.Negative("-0.5")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(SunCheeseRecipe), typeof(ProcessedSunCheeseRecipe) }, SkillTypes = new HashSet<Type> { typeof(MillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = -0.5f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Non-Food-Grade Workshop")]
    [LocDescription("Increased yield when making flaxseed oil. Reduced yield when making cheese.")]
    public partial class MillingFlaxseedOilYieldSpecialtyTalentGroup : TalentGroup
    {
        public MillingFlaxseedOilYieldSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MillingFlaxseedOilYieldSpecialtyTalent),
            };
            this.OwningSkill = typeof(MillingSkill);
            this.Level = 3;
        }
    }

}
