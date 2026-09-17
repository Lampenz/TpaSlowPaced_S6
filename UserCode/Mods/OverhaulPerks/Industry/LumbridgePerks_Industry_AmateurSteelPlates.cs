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
    public partial class IndustryAmateurSteelPlatesTalent : Talent
    {
        public IndustryAmateurSteelPlatesTalent()
        {
			
			this.AddAmateurRecipeUnlock(
				"Savant Steel Platesmaker",
				typeof(AmateurSteelPlateRecipe),
				typeof(IndustrySkill));
			
        }
    }

    [Serialized]
    [LocDisplayName("Amateur Steel Platesmaker")]
    [LocDescription("You have a knack for making Steel Plates. But you have sworn off ever becoming a full Industrial Engineer. Unlocks a very efficient recipe without learning Industry.\n Careful! This perk makes the rest of Industry highly inefficient!")]
    public partial class IndustryAmateurSteelPlatesTalentGroup : TalentGroup
    {
        public IndustryAmateurSteelPlatesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(IndustryAmateurSteelPlatesTalent),
            };
            this.OwningSkill = typeof(IndustrySkill);
            this.Level = 0;
        }
    }
    
}
