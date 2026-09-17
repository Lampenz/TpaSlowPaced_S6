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
    public partial class FarmingPerennialUnlockTalent : Talent
    {
        public FarmingPerennialUnlockTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Perennial Bushes"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(TomatoSeedRecipe),typeof(PricklyPearSeedRecipe),typeof(PineappleSeedRecipe),typeof(PapayaSeedRecipe),typeof(HuckleberrySeedRecipe),typeof(CottonSeedRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Perennial Bushes")]
    [LocDescription("Unlock seeds for bushes that don't need to be replanted every harvest.")]
    public partial class FarmingPerennialUnlockTalentGroup : TalentGroup
    {
        public FarmingPerennialUnlockTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(FarmingPerennialUnlockTalent),
            };
            this.OwningSkill = typeof(FarmingSkill);
            this.Level = 2;
        }
    }
    
}
