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
    public partial class MillingSyrupYeastTalent : Talent
    {
        public MillingSyrupYeastTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Cultured Syrup"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(SyrupYeastRecipe), typeof(ProcessedSyrupYeastRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    [Serialized]
    [LocDisplayName("Cultured Syrup")]
    [LocDescription("Unlock recipes to make yeast from syrups instead of sugar directly.")]
    public partial class MillingSyrupYeastTalentGroup : TalentGroup
    {
        public MillingSyrupYeastTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MillingSyrupYeastTalent),
            };
            this.OwningSkill = typeof(MillingSkill);
            this.Level = 2;
        }
    }
    
}
