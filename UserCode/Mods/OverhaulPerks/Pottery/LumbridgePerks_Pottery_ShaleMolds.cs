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
    public partial class PotteryShaleMoldsRecipeTalent : Talent
    {
        public PotteryShaleMoldsRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Shale Molds"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(ShaleCeramicMoldRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Shale Molds")]
    [LocDescription("Unlock a recipe to make molds with shale instead of just clay.")]
    public partial class PotteryShaleMoldsRecipeTalentGroup : TalentGroup
    {
        public PotteryShaleMoldsRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PotteryShaleMoldsRecipeTalent),
            };
            this.OwningSkill = typeof(PotterySkill);
            this.Level = 2;
        }
    }

}
