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
    public partial class ElectronicsAmateurGoldFlakesTalent : Talent
    {
        public ElectronicsAmateurGoldFlakesTalent()
        {
			
			this.AddAmateurRecipeUnlock(
				"I love gooooold!",
				typeof(AmateurGoldFlakesRecipe),
				typeof(ElectronicsSkill));
			
        }
    }

    [Serialized]
    [LocDisplayName("I love gooooold!")]
    [LocDescription("You have a knack for making Gold Flakes. But you have sworn off ever fully learning Electronics. Unlocks a very efficient recipe without learning Electronics.\n Careful! This perk makes the rest of Electronics highly inefficient!")]
    public partial class ElectronicsAmateurGoldFlakesTalentGroup : TalentGroup
    {
        public ElectronicsAmateurGoldFlakesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ElectronicsAmateurGoldFlakesTalent),
            };
            this.OwningSkill = typeof(ElectronicsSkill);
            this.Level = 0;
        }
    }
    
}
