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
    public partial class CookingUnlockMixedFishSoupTalent : Talent
    {
        public CookingUnlockMixedFishSoupTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Faux Fin"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(FauxSharkFilletSoupRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Faux Fin")]
    [LocDescription("Unlock a new recipe producing shark fillet soup from a mix of fish.")]
    public partial class CookingUnlockMixedFishSoupTalentGroup : TalentGroup
    {
        public CookingUnlockMixedFishSoupTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CookingUnlockMixedFishSoupTalent),
            };
            this.OwningSkill = typeof(CookingSkill);
            this.Level = 3;
        }
    }
    
}
