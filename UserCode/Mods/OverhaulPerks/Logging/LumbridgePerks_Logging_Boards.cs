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
    public partial class LoggingBoardsSpecialtyTalent : Talent
    {
        public LoggingBoardsSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Straight Grain"),
                EffectDescription = Localizer.Do($"Increase yield for all boards by {Text.Positive("+0.5")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, ItemTags = new HashSet<string> { "WoodBoard" }, SkillTypes = new HashSet<Type> { typeof(LoggingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 0.5f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Straight Grain")]
    [LocDescription("Increased yield for all boards.")]
    public partial class LoggingBoardsSpecialtyTalentGroup : TalentGroup
    {
        public LoggingBoardsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingBoardsSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 2;
        }
    }

}
