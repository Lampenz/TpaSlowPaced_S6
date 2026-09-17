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
    public partial class AdvancedMasonryStandingSignsTalent : Talent
    {
        public AdvancedMasonryStandingSignsTalent()
        {

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Standing up"),
                EffectDescription = Localizer.Do($"Increase yield for standing signs by {Text.Positive("+1")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(SmallStandingAshlarStoneSignRecipe), typeof(SmallStandingAshlarBasaltSignRecipe), typeof(SmallStandingAshlarShaleSignRecipe), typeof(SmallStandingAshlarGneissSignRecipe), typeof(SmallStandingAshlarGraniteSignRecipe), typeof(SmallStandingAshlarLimestoneSignRecipe), typeof(SmallStandingAshlarSandstoneSignRecipe), typeof(LargeStandingAshlarStoneSignRecipe), typeof(LargeStandingAshlarBasaltSignRecipe), typeof(LargeStandingAshlarShaleSignRecipe), typeof(LargeStandingAshlarGneissSignRecipe), typeof(LargeStandingAshlarGraniteSignRecipe), typeof(LargeStandingAshlarLimestoneSignRecipe), typeof(LargeStandingAshlarSandstoneSignRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedMasonrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Standing up")]
    [LocDescription("Increases yield for standing signs.")]
    public partial class AdvancedMasonryStandingSignsTalentGroup : TalentGroup
    {
        public AdvancedMasonryStandingSignsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedMasonryStandingSignsTalent),
            };
            this.OwningSkill = typeof(AdvancedMasonrySkill);
            this.Level = 2;
        }
    }

}
