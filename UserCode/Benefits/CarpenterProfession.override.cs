// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;
    using Eco.Shared.Serialization;
    using System.Collections.Generic;


    
    // Logging Talents
    // Level 3 1+ Tool Damage
    // Level 3 Increased output of charcoal recipes by +1
    // Level 6 Cut apart an entire tree by random chance +25%, triggers with onFelled
    // Level 6 AoE Debris Pickup - Hand pickup
    #region Logging

    public partial class WoodBurnerTalent : Talent
    {
        public WoodBurnerTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Wood burner!"),
                EffectDescription = Localizer.Do($"Increases output of all charcoal recipes by {Text.Positive(Text.Num(1f))}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(DenseCharcoalRecipe), typeof(PeatCharcoalRecipe), typeof(CharcoalRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
        }
    }

    // CleanupCrew partial — adds bonuses to the AutoGen base class
    public partial class CleanupCrewTalent
    {
        public CleanupCrewTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name              = Localizer.DoStr("Cleanup Crew"),
                EffectDescription = Localizer.DoStr("Allows debris pickup by hand."),
                Causes            = new List<BonusCause> { new ActionCause { Action = BonusAction.PickupDebris } },
                Effects           = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }
    public partial class LoggersLuckTalent
    {
        public LoggersLuckTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Logger's Luck"),
                EffectDescription = Localizer.Do($"{Text.Positive("25%")} chance to auto-split trunk and destroy stump when felling a tree."),
                Causes = new List<BonusCause> { new ActionCause { Action = BonusAction.AutoProcessLog } },
                Effects = new List<BonusEffect> { new BonusEffectChance { Chance = 0.25f, SuccessValue = 1f } },
            });
        }
    }
    #endregion
	
	
}
