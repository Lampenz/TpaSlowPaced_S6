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
    public partial class PotterySiftClayRecipeTalent : Talent
    {
        public PotterySiftClayRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Making Your Own Clay"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SiftClayRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Making Your Own Clay")]
    [LocDescription("Unlock a recipe to filter dirt for clay particles and byproducts.")]
    public partial class PotterySiftClayRecipeTalentGroup : TalentGroup
    {
        public PotterySiftClayRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PotterySiftClayRecipeTalent),
            };
            this.OwningSkill = typeof(PotterySkill);
            this.Level = 3;
        }
    }

}
