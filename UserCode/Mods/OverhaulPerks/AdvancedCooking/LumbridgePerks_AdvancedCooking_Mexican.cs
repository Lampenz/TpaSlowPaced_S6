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
    public partial class AdvancedCookingMexicanSpecialtyTalent : Talent
    {
        public AdvancedCookingMexicanSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Spicy Supper"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(ElkTacoRecipe),typeof(TortillaRecipe),typeof(CornFrittersRecipe),typeof(AgoutiEnchiladasRecipe) }, SkillTypes = new HashSet<Type> { typeof(AdvancedCookingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Spicy Supper")]
    [LocDescription("Better yield for tacos, tortillas, enchiladas, and corn fritters.")]
    public partial class AdvancedCookingMexicanSpecialtyTalentGroup : TalentGroup
    {
        public AdvancedCookingMexicanSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(AdvancedCookingMexicanSpecialtyTalent),
            };
            this.OwningSkill = typeof(AdvancedCookingSkill);
            this.Level = 3;
        }
    }

}
