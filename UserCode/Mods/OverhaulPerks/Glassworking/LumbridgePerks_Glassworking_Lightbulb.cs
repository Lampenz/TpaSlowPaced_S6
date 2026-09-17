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
    public partial class GlassworkingLightbulbYieldTalent : Talent
    {
        public GlassworkingLightbulbYieldTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Bright Idea"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<System.Type> { typeof(LightBulbRecipe), typeof(LightBulbWithGoldWiringRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 2f, Cap = 3f, LowerIsBetter = false } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Bright Idea")]
    [LocDescription("Grants  a bonus 1 Lightbulb per craft. Can be taken twice.")]
    public partial class GlassworkingLightbulbYieldTalentGroup : TalentGroup
    {
        public GlassworkingLightbulbYieldTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GlassworkingLightbulbYieldTalent),
            };
            this.OwningSkill = typeof(GlassworkingSkill);
            this.Level = 2;
			this.StarCost = 2;
        }
		public override int MaxTalentLevel { get => 2; set { } }
    }

}
