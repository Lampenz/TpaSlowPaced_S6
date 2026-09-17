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
    public partial class PaperMillingWaxedPaperYieldTalent : Talent
    {
        public PaperMillingWaxedPaperYieldTalent()
        {
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Sealed Sheets"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(WaxedPaperRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 4f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Sealed Sheets")]
    [LocDescription("Increased yield when making waxed paper.")]
    public partial class PaperMillingWaxedPaperYieldTalentGroup : TalentGroup
    {
        public PaperMillingWaxedPaperYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PaperMillingWaxedPaperYieldTalent),
            };
            this.OwningSkill = typeof(PaperMillingSkill);
            this.Level = 2;
        }
    }

}
