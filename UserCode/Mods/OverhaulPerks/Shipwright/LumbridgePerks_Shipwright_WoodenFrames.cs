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
    public partial class ShipwrightWoodenFramesSpecialtyTalent : Talent
    {
        public ShipwrightWoodenFramesSpecialtyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("True Joinery"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Yield, Recipes = new HashSet<Type> { typeof(LargeWoodenShipFrameRecipe), typeof(MediumWoodenShipFrameRecipe), typeof(SmallWoodenShipFrameRecipe) }, SkillTypes = new HashSet<Type> { typeof(ShipwrightSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectAdditive { Value = 1f } },
            });
			
        }
    }

    [Serialized]
    [LocDisplayName("True Joinery")]
    [LocDescription("Increased yield when making wooden frames.")]
    public partial class ShipwrightWoodenFramesSpecialtyTalentGroup : TalentGroup
    {
        public ShipwrightWoodenFramesSpecialtyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ShipwrightWoodenFramesSpecialtyTalent),
            };
            this.OwningSkill = typeof(ShipwrightSkill);
            this.Level = 3;
        }
    }

}
