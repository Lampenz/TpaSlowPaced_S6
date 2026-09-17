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
    public partial class IndustryAmateurSteelGearsTalent : Talent
    {
        public IndustryAmateurSteelGearsTalent()
        {
			
			this.AddAmateurRecipeUnlock(
				"Savant Steel Gearsmaker",
				typeof(AmateurSteelGearRecipe),
				typeof(IndustrySkill));
			
        }
    }

    [Serialized]
    [LocDisplayName("Amateur Steel Gearsmaker")]
    [LocDescription("You have a knack for making Steel Gears. But you have sworn off ever becoming a full Industrial Engineer. Unlocks a very efficient recipe without learning Industry.\n Careful! This perk makes the rest of Industry highly inefficient!")]
    public partial class IndustryAmateurSteelGearsTalentGroup : TalentGroup
    {
        public IndustryAmateurSteelGearsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(IndustryAmateurSteelGearsTalent),
            };
            this.OwningSkill = typeof(IndustrySkill);
            this.Level = 0;
        }
    }
    
}
