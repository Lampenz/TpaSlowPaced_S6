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
    public partial class AdvancedMasonryFountainsTalent : Talent
    {
        public AdvancedMasonryFountainsTalent()
        {

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Fancy Fountains"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(AshlarSmallStoneFountainRecipe), typeof(AshlarSmallBasaltFountainRecipe), typeof(AshlarSmallShaleFountainRecipe), typeof(AshlarSmallGneissFountainRecipe), typeof(AshlarSmallGraniteFountainRecipe), typeof(AshlarSmallLimestoneFountainRecipe), typeof(AshlarSmallSandstoneFountainRecipe), typeof(AshlarLargeStoneFountainRecipe), typeof(AshlarLargeBasaltFountainRecipe), typeof(AshlarLargeShaleFountainRecipe), typeof(AshlarLargeGneissFountainRecipe), typeof(AshlarLargeGraniteFountainRecipe), typeof(AshlarLargeLimestoneFountainRecipe), typeof(AshlarLargeSandstoneFountainRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedMasonrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Fancy Fountains")]
    [LocDescription("Increases yield for Fountains.")]
    public partial class AdvancedMasonryFountainsTalentGroup : TalentGroup
    {
        public AdvancedMasonryFountainsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedMasonryFountainsTalent),
            };
            this.OwningSkill = typeof(AdvancedMasonrySkill);
            this.Level = 3;
        }
    }

}
