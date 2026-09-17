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
    public partial class OilDrillingLiquidsSpecialtyTalent : Talent
    {
        public OilDrillingLiquidsSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Solutions"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(EpoxyRecipe), typeof(NitricAcidRecipe) }, SkillTypes = new HashSet<Type> { typeof(OilDrillingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.5f, Cap = 2f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Solutions")]
    [LocDescription("Increased epoxy and nitric acid yield. Can be taken up to two times.")]
    public partial class OilDrillingLiquidsSpecialtyTalentGroup : TalentGroup
    {
        public OilDrillingLiquidsSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(OilDrillingLiquidsSpecialtyTalent),
            };
            this.OwningSkill = typeof(OilDrillingSkill);
            this.Level = 2;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
