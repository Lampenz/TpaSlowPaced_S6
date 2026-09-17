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
    public partial class OilDrillingGasolineYieldTalent : Talent
    {
        public OilDrillingGasolineYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Pump to Petrol"),
                EffectDescription = Localizer.Do($"Increase yield for gasoline by {Text.Positive("+1")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(GasolineRecipe) }, SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Pump to Petrol")]
    [LocDescription("Increase yield for gasoline.")]
    public partial class OilDrillingGasolineYieldTalentGroup : TalentGroup
    {
        public OilDrillingGasolineYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(OilDrillingGasolineYieldTalent),
            };
            this.OwningSkill = typeof(OilDrillingSkill);
            this.Level = 3;
			this.StarCost = 2;
        }
    }

}
