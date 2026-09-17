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
	public partial class LoggingCaloriesHighTalent : Talent
	{
		public LoggingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<LoggingSkill>(this, "Logging", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class HuntingCaloriesHighTalent : Talent
	{
		public HuntingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<HuntingSkill>(this, "Hunting", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class GatheringCaloriesHighTalent : Talent
	{
		public GatheringCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<GatheringSkill>(this, "Gathering", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class CampfireCookingCaloriesHighTalent : Talent
	{
		public CampfireCookingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CampfireCookingSkill>(this, "CampfireCooking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class MiningCaloriesHighTalent : Talent
	{
		public MiningCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MiningSkill>(this, "Mining", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class MasonryCaloriesHighTalent : Talent
	{
		public MasonryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MasonrySkill>(this, "Masonry", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class FarmingCaloriesHighTalent : Talent
	{
		public FarmingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<FarmingSkill>(this, "Farming", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class ShipwrightCaloriesHighTalent : Talent
	{
		public ShipwrightCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ShipwrightSkill>(this, "Shipwright", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class MillingCaloriesHighTalent : Talent
	{
		public MillingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MillingSkill>(this, "Milling", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class ButcheryCaloriesHighTalent : Talent
	{
		public ButcheryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ButcherySkill>(this, "Butchery", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class BakingCaloriesHighTalent : Talent
	{
		public BakingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BakingSkill>(this, "Baking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class TailoringCaloriesHighTalent : Talent
	{
		public TailoringCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<TailoringSkill>(this, "Tailoring", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class CarpentryCaloriesHighTalent : Talent
	{
		public CarpentryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CarpentrySkill>(this, "Carpentry", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class BasicEngineeringCaloriesHighTalent : Talent
	{
		public BasicEngineeringCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BasicEngineeringSkill>(this, "BasicEngineering", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class SmeltingCaloriesHighTalent : Talent
	{
		public SmeltingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<SmeltingSkill>(this, "Smelting", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class CookingCaloriesHighTalent : Talent
	{
		public CookingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CookingSkill>(this, "Cooking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class BlacksmithCaloriesHighTalent : Talent
	{
		public BlacksmithCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BlacksmithSkill>(this, "Blacksmith", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class PotteryCaloriesHighTalent : Talent
	{
		public PotteryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PotterySkill>(this, "Pottery", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class PaintingCaloriesHighTalent : Talent
	{
		public PaintingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PaintingSkill>(this, "Painting", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class GlassworkingCaloriesHighTalent : Talent
	{
		public GlassworkingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<GlassworkingSkill>(this, "Glassworking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class MechanicsCaloriesHighTalent : Talent
	{
		public MechanicsCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MechanicsSkill>(this, "Mechanics", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class PaperMillingCaloriesHighTalent : Talent
	{
		public PaperMillingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PaperMillingSkill>(this, "PaperMilling", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class FertilizersCaloriesHighTalent : Talent
	{
		public FertilizersCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<FertilizersSkill>(this, "Fertilizers", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class AdvancedBakingCaloriesHighTalent : Talent
	{
		public AdvancedBakingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedBakingSkill>(this, "AdvancedBaking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingCaloriesHighTalent : Talent
	{
		public AdvancedSmeltingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedSmeltingSkill>(this, "AdvancedSmelting", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class AdvancedCookingCaloriesHighTalent : Talent
	{
		public AdvancedCookingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedCookingSkill>(this, "AdvancedCooking", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class CompositesCaloriesHighTalent : Talent
	{
		public CompositesCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CompositesSkill>(this, "Composites", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class AdvancedMasonryCaloriesHighTalent : Talent
	{
		public AdvancedMasonryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedMasonrySkill>(this, "AdvancedMasonry", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class OilDrillingCaloriesHighTalent : Talent
	{
		public OilDrillingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<OilDrillingSkill>(this, "OilDrilling", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class ElectronicsCaloriesHighTalent : Talent
	{
		public ElectronicsCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ElectronicsSkill>(this, "Electronics", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}

	[Serialized]
	public partial class IndustryCaloriesHighTalent : Talent
	{
		public IndustryCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<IndustrySkill>(this, "Industry", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}


	
	[Serialized]
	public partial class RecyclingCaloriesHighTalent : Talent
	{
		public RecyclingCaloriesHighTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<RecyclingSkill>(this, "Recycling", value: 0.8f, cap: 0.2f, powervalue: 1.15f, powercap: 1.6f );
		}
	}
	
	
	
	
	
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Masterful Production (Logging)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class LoggingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public LoggingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Hunting)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class HuntingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public HuntingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Gathering)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class GatheringCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public GatheringCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (CampfireCooking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class CampfireCookingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public CampfireCookingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Mining)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class MiningCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public MiningCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Masterful Production (Masonry)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class MasonryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public MasonryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Farming)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class FarmingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public FarmingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Shipwright)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class ShipwrightCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public ShipwrightCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Milling)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class MillingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public MillingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Butchery)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class ButcheryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public ButcheryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcheryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Baking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class BakingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public BakingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Tailoring)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class TailoringCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public TailoringCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Carpentry)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class CarpentryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public CarpentryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (BasicEngineering)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class BasicEngineeringCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public BasicEngineeringCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Smelting)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class SmeltingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public SmeltingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Cooking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class CookingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public CookingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Blacksmith)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class BlacksmithCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public BlacksmithCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Pottery)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class PotteryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public PotteryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotteryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Painting)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class PaintingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public PaintingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Glassworking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class GlassworkingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public GlassworkingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Mechanics)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class MechanicsCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public MechanicsCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (PaperMilling)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class PaperMillingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public PaperMillingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Fertilizers)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class FertilizersCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public FertilizersCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (AdvancedBaking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class AdvancedBakingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedBakingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (AdvancedSmelting)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class AdvancedSmeltingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedSmeltingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (AdvancedCooking)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class AdvancedCookingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedCookingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Composites)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class CompositesCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public CompositesCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (AdvancedMasonry)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class AdvancedMasonryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedMasonryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (OilDrilling)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class OilDrillingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public OilDrillingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Electronics)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class ElectronicsCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public ElectronicsCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Masterful Production (Industry)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class IndustryCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public IndustryCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustryCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}


	
	[Serialized]
	[LocDisplayName("Masterful Production (Recycling)")]
	[LocDescription("Reduces calorie costs drastically. \nAt max investment, crafting is one fifth the calorie cost, so you can craft five times as much.")]
	public partial class RecyclingCaloriesHighTalentGroup : CaloriesTalentGroupBase
	{
		public RecyclingCaloriesHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingCaloriesHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}

}
