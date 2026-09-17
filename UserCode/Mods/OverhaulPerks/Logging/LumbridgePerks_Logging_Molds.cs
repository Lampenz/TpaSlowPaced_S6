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
    public partial class LoggingWoodenMoldSpecialtyTalent : Talent
    {
        public LoggingWoodenMoldSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Moldwright"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(WoodenMoldRecipe) }, SkillTypes = new HashSet<Type> { typeof(LoggingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 2.5f, Cap = 4f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Moldwright")]
    [LocDescription("Increased yield when making wooden molds. Can be taken twice.")]
    public partial class LoggingWoodenMoldSpecialtyTalentGroup : TalentGroup
    {
        public LoggingWoodenMoldSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingWoodenMoldSpecialtyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 2;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
