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
    public partial class OilDrillingOilRefinerySpecialtyTalent : Talent
    {
        public OilDrillingOilRefinerySpecialtyTalent()
        {

			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Keep Your Hands Clean"),
                EffectDescription = Localizer.Do($"Increase yield at the oil refinery by {Text.Positive("+20%")} per level."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, CraftStationTypes = new HashSet<Type> { typeof(OilRefineryObject) } , SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.4f, Cap = 3f, LowerIsBetter = false } },
            });
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Keep Your Hands Clean"),
                EffectDescription = Localizer.Do($"Decreases crafting time at the oil refinery by {Text.Positive("10%")} per level."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, CraftStationTypes = new HashSet<Type> { typeof(OilRefineryObject) } , SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.9f, Cap = 0.5f, LowerIsBetter = true } },
            });
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Keep Your Hands Clean"),
                EffectDescription = Localizer.Do($"Lowers yields at the oil refinery by {Text.Negative("10%")} per level."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, CraftStationTypes = new HashSet<Type> { typeof(PumpJackObject) } , SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.9f, Cap = 0.5f, LowerIsBetter = false } },
            });
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Keep Your Hands Clean")]
    [LocDescription("Better yields at the refinery, but worse drilling .")]
    public partial class OilDrillingOilRefinerySpecialtyTalentGroup : TalentGroup
    {
        public OilDrillingOilRefinerySpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(OilDrillingOilRefinerySpecialtyTalent),
            };
            this.OwningSkill = typeof(OilDrillingSkill);
            this.Level = 1;
        }
    }

}
