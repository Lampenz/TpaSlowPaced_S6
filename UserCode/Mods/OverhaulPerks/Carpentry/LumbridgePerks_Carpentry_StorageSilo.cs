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
    public partial class CarpentryStorageSiloSpecialtyTalent : Talent
    {
        public CarpentryStorageSiloSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Overflowing Silos"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(StorageSiloRecipe) }, SkillTypes = new HashSet<Type> { typeof(CarpentrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Overflowing Silos")]
    [LocDescription("Increased yield when making storage silos.")]
    public partial class CarpentryStorageSiloSpecialtyTalentGroup : TalentGroup
    {
        public CarpentryStorageSiloSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(CarpentryStorageSiloSpecialtyTalent),
            };
            this.OwningSkill = typeof(CarpentrySkill);
            this.Level = 3;
        }
    }

}
