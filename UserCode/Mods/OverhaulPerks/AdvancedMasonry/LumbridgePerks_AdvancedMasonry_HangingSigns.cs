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
    public partial class AdvancedMasonryHangingSignsTalent : Talent
    {
        public AdvancedMasonryHangingSignsTalent()
        {

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hanging down"),
                EffectDescription = Localizer.Do($"Increase yield for Hanging signs by {Text.Positive("+1")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(SmallHangingAshlarStoneSignRecipe), typeof(SmallHangingAshlarBasaltSignRecipe), typeof(SmallHangingAshlarShaleSignRecipe), typeof(SmallHangingAshlarGneissSignRecipe), typeof(SmallHangingAshlarGraniteSignRecipe), typeof(SmallHangingAshlarLimestoneSignRecipe), typeof(SmallHangingAshlarSandstoneSignRecipe), typeof(LargeHangingAshlarStoneSignRecipe), typeof(LargeHangingAshlarBasaltSignRecipe), typeof(LargeHangingAshlarShaleSignRecipe), typeof(LargeHangingAshlarGneissSignRecipe), typeof(LargeHangingAshlarGraniteSignRecipe), typeof(LargeHangingAshlarLimestoneSignRecipe), typeof(LargeHangingAshlarSandstoneSignRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedMasonrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Hanging down")]
    [LocDescription("Increases yield for Hanging signs.")]
    public partial class AdvancedMasonryHangingSignsTalentGroup : TalentGroup
    {
        public AdvancedMasonryHangingSignsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedMasonryHangingSignsTalent),
            };
            this.OwningSkill = typeof(AdvancedMasonrySkill);
            this.Level = 2;
        }
    }

}
