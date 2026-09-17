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
    public partial class HuntingTrapHareTalent : Talent
    {
        public HuntingTrapHareTalent()
        {

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Carrot and Stick"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(TrapHareRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Carrot and Stick")]
    [LocDescription("Unlocks a recipe to trap hares from your campsite.")]
    public partial class HuntingTrapHareTalentGroup : TalentGroup
    {
        public HuntingTrapHareTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(HuntingTrapHareTalent),
            };
            this.OwningSkill = typeof(HuntingSkill);
            this.Level = 2;
        }
    }

}
