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
    public partial class MasonryQuicklimeSpecialtyTalent : Talent
    {
        public MasonryQuicklimeSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Keep it dry"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(QuicklimeRecipe) }, SkillTypes = new HashSet<Type> { typeof(MasonrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 2f, Cap = 3f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Keep it dry")]
    [LocDescription("Increase yield for quicklime by 100% per level. Can be taken twice.")]
    public partial class MasonryQuicklimeSpecialtyTalentGroup : TalentGroup
    {
        public MasonryQuicklimeSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MasonryQuicklimeSpecialtyTalent),
            };
            this.OwningSkill = typeof(MasonrySkill);
            this.Level = 2;
			this.StarCost = 1;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
