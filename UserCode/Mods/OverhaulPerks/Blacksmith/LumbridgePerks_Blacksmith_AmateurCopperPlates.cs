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
    public partial class BlacksmithAmateurCopperPlatesTalent : Talent
    {
        public BlacksmithAmateurCopperPlatesTalent()
        {
			
			this.AddAmateurRecipeUnlock(
				"Savant Copper Platesmaker",
				typeof(AmateurCopperPlateRecipe),
				typeof(BlacksmithSkill));
						
        }
    }

    [Serialized]
    [LocDisplayName("Amateur Copper Platesmaker")]
    [LocDescription("You have a knack for making Copper Plates. But you have sworn off ever becoming a full engineer. Unlocks a very efficient recipe without learning Blacksmith.\n Careful! This perk makes the rest of Blacksmith highly inefficient!")]
    public partial class BlacksmithAmateurCopperPlatesTalentGroup : TalentGroup
    {
        public BlacksmithAmateurCopperPlatesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(BlacksmithAmateurCopperPlatesTalent),
            };
            this.OwningSkill = typeof(BlacksmithSkill);
            this.Level = 0;
        }
    }
    
}
