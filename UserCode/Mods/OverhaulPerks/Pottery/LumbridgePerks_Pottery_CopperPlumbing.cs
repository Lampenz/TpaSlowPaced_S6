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
    public partial class PotteryCopperPlumbingRecipeTalent : Talent
    {
        public PotteryCopperPlumbingRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Copper Plumbing"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(CopperBathtubRecipe), typeof(CopperSmallSinkRecipe), typeof(CopperToiletRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Copper Plumbing")]
    [LocDescription("Unlock a recipe to make bathtubs and sinks with copper pipes, and toilets with mostly copper pipes.")]
    public partial class PotteryCopperPlumbingRecipeTalentGroup : TalentGroup
    {
        public PotteryCopperPlumbingRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PotteryCopperPlumbingRecipeTalent),
            };
            this.OwningSkill = typeof(PotterySkill);
            this.Level = 6;
        }
    }

}
