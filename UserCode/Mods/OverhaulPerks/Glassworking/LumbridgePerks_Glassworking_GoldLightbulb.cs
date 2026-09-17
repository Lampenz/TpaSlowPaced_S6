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
    public partial class GlassworkingGoldWiringLightbulbRecipeTalent : Talent
    {
        public GlassworkingGoldWiringLightbulbRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Golden Idea"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(LightBulbWithGoldWiringRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Golden Idea")]
    [LocDescription("Unlock an alternate recipe for lightbulbs using gold wiring instead.")]
    public partial class GlassworkingGoldWiringLightbulbRecipeTalentGroup : TalentGroup
    {
        public GlassworkingGoldWiringLightbulbRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GlassworkingGoldWiringLightbulbRecipeTalent),
            };
            this.OwningSkill = typeof(GlassworkingSkill);
            this.Level = 3;
        }
    }

}
