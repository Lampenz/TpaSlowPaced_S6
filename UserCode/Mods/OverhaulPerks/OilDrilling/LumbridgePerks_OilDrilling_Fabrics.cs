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
    public partial class OilDrillingFabricsSpecialtyTalent : Talent
    {
        public OilDrillingFabricsSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Filaments"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(NylonRecipe), typeof(SyntheticRubberRecipe) }, SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.5f, Cap = 2f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Filaments")]
    [LocDescription("Increased nylon and synthetic rubber yield. Can be taken up to three times.")]
    public partial class OilDrillingFabricsSpecialtyTalentGroup : TalentGroup
    {
        public OilDrillingFabricsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(OilDrillingFabricsSpecialtyTalent),
            };
            this.OwningSkill = typeof(OilDrillingSkill);
            this.Level = 2;
        }
		public override int MaxTalentLevel { get => 3; set { } }
    }

}
