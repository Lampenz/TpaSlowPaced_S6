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
    public partial class LoggingHardwoodBoardsSpecialtyTalent : Talent
    {
        public LoggingHardwoodBoardsSpecialtyTalent()
        {
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hard Grain"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SpecialistHardwoodBoardRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hard Grain"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SawSpecialistHardwoodBoardsRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Hard Grain")]
    [LocDescription("Unlock much more efficient board recipes using hardwood.")]
    public partial class LoggingHardwoodBoardsSpecialtyTalentGroup : TalentGroup
    {
        public LoggingHardwoodBoardsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingHardwoodBoardsSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 2;
        }
    }

}
