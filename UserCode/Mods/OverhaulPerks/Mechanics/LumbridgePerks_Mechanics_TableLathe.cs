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
    public partial class MechanicsLatheSpecialistTalent : Talent
	{
		public MechanicsLatheSpecialistTalent()
		{
			this.AddTableSpecialistBonus(
				"Turning",
				typeof(MechanicsSkill),
				typeof(LatheObject));
		}
	}

    [Serialized]
    [LocDisplayName("Turning")]
    [LocDescription("Reduces Lathe recipe costs and increases its craft speed.")]
    public partial class MechanicsLatheSpecialistTalentGroup : TalentGroup
    {
        public MechanicsLatheSpecialistTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MechanicsLatheSpecialistTalent),
            };
            this.OwningSkill = typeof(MechanicsSkill);
            this.Level = 3;
        }
    }
    
}
