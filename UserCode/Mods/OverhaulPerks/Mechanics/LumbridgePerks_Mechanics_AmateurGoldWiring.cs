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
    public partial class MechanicsAmateurGoldWiringsTalent : Talent
    {
        public MechanicsAmateurGoldWiringsTalent()
        {
			
			this.AddAmateurRecipeUnlock(
				"Savant Gold Wiringmaker",
				typeof(AmateurGoldWiringRecipe),
				typeof(MechanicsSkill));
			
        }
    }

    [Serialized]
    [LocDisplayName("Amateur Gold Wiringmaker")]
    [LocDescription("You have a knack for making Gold Wirings. But you have sworn off ever becoming a full mechanic. Unlocks a very efficient recipe without learning mechanics.\n Careful! This perk makes the rest of Mechanics highly inefficient!")]
    public partial class MechanicsAmateurGoldWiringsTalentGroup : TalentGroup
    {
        public MechanicsAmateurGoldWiringsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MechanicsAmateurGoldWiringsTalent),
            };
            this.OwningSkill = typeof(MechanicsSkill);
            this.Level = 0;
        }
    }
    
}
