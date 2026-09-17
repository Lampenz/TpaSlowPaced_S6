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
		

	// MaxTalentLevel = how many talent (star) levels a perk has. The empty setter makes our value survive
	// the game forcing every level-scaling group to 5 during talent init. This is the DEFAULT for the family;
	// to give one perk a different cap, add `public override int MaxTalentLevel { get => N; set { } }` to that
	// specific group's class (e.g. HuntingSpeedTalentGroup). `this.Level` below is the unlock level, unrelated.
	public abstract class SpeedTalentGroupBase : TalentGroup
	{
		protected SpeedTalentGroupBase()
		{
			this.Level = 5;
		}
		public override int MaxTalentLevel { get => 4; set { } }
	}
	public abstract class CaloriesTalentGroupBase : TalentGroup
	{
		protected CaloriesTalentGroupBase()
		{
			this.Level = 4;
		}
		public override int MaxTalentLevel { get => 4; set { } }
	}
	
	public abstract class ResearchSpecialistTalentGroupBase : TalentGroup
	{
		protected ResearchSpecialistTalentGroupBase()
		{
			this.Level = 7;
		}
	}
	public abstract class ResearchUniversalistTalentGroupBase : TalentGroup
	{
		protected ResearchUniversalistTalentGroupBase()
		{
			this.Level = 7;
		}
	}
	public abstract class ResearchPragmatistTalentGroupBase : TalentGroup
	{
		protected ResearchPragmatistTalentGroupBase()
		{
			this.Level = 7;
		}
	}

}
