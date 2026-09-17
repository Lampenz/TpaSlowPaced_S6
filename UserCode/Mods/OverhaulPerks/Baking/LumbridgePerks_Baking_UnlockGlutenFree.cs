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
    public partial class BakingUnlockGlutenFreeMuffinsTalent : Talent
    {
        public BakingUnlockGlutenFreeMuffinsTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Gluten Free Muffins"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(GlutenFreeFruitMuffinRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Gluten Free Dough"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(GlutenFreeLeavenedDoughRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Gluten Free Baking")]
    [LocDescription("Unlock new gluten free baking recipes.")]
    public partial class BakingUnlockGlutenFreeMuffinsTalentGroup : TalentGroup
    {
        public BakingUnlockGlutenFreeMuffinsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BakingUnlockGlutenFreeMuffinsTalent),
            };
            this.OwningSkill = typeof(BakingSkill);
            this.Level = 2;
        }
    }
    
}
