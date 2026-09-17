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
    public partial class MiningMixCrushedRocksRecipeTalent : Talent
    {
        public MiningMixCrushedRocksRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Kicking Rocks"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(MixCrushedRocksRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Kicking Rocks")]
    [LocDescription("Unlock a recipe to mix any crushed rocks into mixed crushed rock. This perk is free.")]
    public partial class MiningMixCrushedRocksRecipeTalentGroup : TalentGroup
    {
        public MiningMixCrushedRocksRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MiningMixCrushedRocksRecipeTalent),
            };
            this.OwningSkill = typeof(MiningSkill);
            this.Level = 2;
			this.StarCost = 0;
        }
    }

}
