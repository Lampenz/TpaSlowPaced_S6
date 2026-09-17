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
    public partial class PaintingArtSuppliesTalent : Talent
    {
        public PaintingArtSuppliesTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Art Studio"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(ArtSuppliesRecipe) }, SkillTypes = new HashSet<Type> { typeof(PaintingSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 6f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Art Studio")]
    [LocDescription("Increase yield for art supplies.")]
    public partial class PaintingArtSuppliesTalentGroup : TalentGroup
    {
        public PaintingArtSuppliesTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(PaintingArtSuppliesTalent),
            };
            this.OwningSkill = typeof(PaintingSkill);
            this.Level = 2;
        }
    }

}
