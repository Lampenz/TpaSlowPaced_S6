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
    public partial class MechanicsVehiclesTalent : Talent
    {
        public MechanicsVehiclesTalent()
        {
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Steam Transport"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SteamTractorRecipe),typeof(SteamTruckRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Steam Transport")]
    [LocDescription("Unlocks the ability to make steam vehicles.")]
    public partial class MechanicsVehiclesTalentGroup : TalentGroup
    {
        public MechanicsVehiclesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MechanicsVehiclesTalent),
            };
            this.OwningSkill = typeof(MechanicsSkill);
            this.Level = 2;
        }
    }
    
}
