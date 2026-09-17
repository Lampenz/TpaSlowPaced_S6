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
    public partial class ElectronicsStreetlampsTalent : Talent
    {
        public ElectronicsStreetlampsTalent()
        {
			
			
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Light the Way"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(StreetlampRecipe), typeof(ModernStreetLightRecipe), typeof(ModernDoubleStreetLightRecipe)  } , SkillTypes = new HashSet<Type> { typeof(ElectronicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
			
			
        }
    }

    [Serialized]
    [LocDisplayName("Light the Way")]
    [LocDescription("Grants a 25% discount for streetlamps.")]
    public partial class ElectronicsStreetlampsTalentGroup : TalentGroup
    {
        public ElectronicsStreetlampsTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ElectronicsStreetlampsTalent),
            };
            this.OwningSkill = typeof(ElectronicsSkill);
            this.Level = 6;
        }
    }
    
}
