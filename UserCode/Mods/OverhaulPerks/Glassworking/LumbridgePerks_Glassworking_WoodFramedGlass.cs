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
    public partial class GlassworkingWoodFramedGlassRecipeTalent : Talent
    {
        public GlassworkingWoodFramedGlassRecipeTalent()
        {
            
			this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Timber Frames"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(WoodFramedGlassRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Timber Frames")]
    [LocDescription("Unlock an alternate recipe for glass using charcoal ash instead of lime.")]
    public partial class GlassworkingWoodFramedGlassRecipeTalentGroup : TalentGroup
    {
        public GlassworkingWoodFramedGlassRecipeTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GlassworkingWoodFramedGlassRecipeTalent),
            };
            this.OwningSkill = typeof(GlassworkingSkill);
            this.Level = 6;
        }
    }

}
