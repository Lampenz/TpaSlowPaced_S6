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
    public partial class ShipwrightMetalFramesSpecialtyTalent : Talent
    {
        public ShipwrightMetalFramesSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Hammer and Rivet"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(LargeMetalShipFrameRecipe),typeof(MediumMetalShipFrameRecipe) }, SkillTypes = new HashSet<Type> { typeof(ShipwrightSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("Hammer and Rivet")]
    [LocDescription("Increased yield when making metal frames.")]
    public partial class ShipwrightMetalFramesSpecialtyTalentGroup : TalentGroup
    {
        public ShipwrightMetalFramesSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ShipwrightMetalFramesSpecialtyTalent),
            };
            this.OwningSkill = typeof(ShipwrightSkill);
            this.Level = 3;
        }
    }

}
