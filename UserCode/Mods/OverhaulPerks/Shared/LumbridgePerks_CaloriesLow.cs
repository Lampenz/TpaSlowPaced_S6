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
	public partial class LoggingCaloriesLowTalent : Talent
	{
		public LoggingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<LoggingSkill>(this, "Logging");
		}
	}

	[Serialized]
	public partial class HuntingCaloriesLowTalent : Talent
	{
		public HuntingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<HuntingSkill>(this, "Hunting");
		}
	}

	[Serialized]
	public partial class GatheringCaloriesLowTalent : Talent
	{
		public GatheringCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<GatheringSkill>(this, "Gathering");
		}
	}

	[Serialized]
	public partial class CampfireCookingCaloriesLowTalent : Talent
	{
		public CampfireCookingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CampfireCookingSkill>(this, "CampfireCooking");
		}
	}

	[Serialized]
	public partial class MiningCaloriesLowTalent : Talent
	{
		public MiningCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MiningSkill>(this, "Mining");
		}
	}

	[Serialized]
	public partial class MasonryCaloriesLowTalent : Talent
	{
		public MasonryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MasonrySkill>(this, "Masonry");
		}
	}

	[Serialized]
	public partial class FarmingCaloriesLowTalent : Talent
	{
		public FarmingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<FarmingSkill>(this, "Farming");
		}
	}

	[Serialized]
	public partial class ShipwrightCaloriesLowTalent : Talent
	{
		public ShipwrightCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ShipwrightSkill>(this, "Shipwright");
		}
	}

	[Serialized]
	public partial class MillingCaloriesLowTalent : Talent
	{
		public MillingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MillingSkill>(this, "Milling");
		}
	}

	[Serialized]
	public partial class ButcheryCaloriesLowTalent : Talent
	{
		public ButcheryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ButcherySkill>(this, "Butchery");
		}
	}

	[Serialized]
	public partial class BakingCaloriesLowTalent : Talent
	{
		public BakingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BakingSkill>(this, "Baking");
		}
	}

	[Serialized]
	public partial class TailoringCaloriesLowTalent : Talent
	{
		public TailoringCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<TailoringSkill>(this, "Tailoring");
		}
	}

	[Serialized]
	public partial class CarpentryCaloriesLowTalent : Talent
	{
		public CarpentryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CarpentrySkill>(this, "Carpentry");
		}
	}

	[Serialized]
	public partial class BasicEngineeringCaloriesLowTalent : Talent
	{
		public BasicEngineeringCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BasicEngineeringSkill>(this, "BasicEngineering");
		}
	}

	[Serialized]
	public partial class SmeltingCaloriesLowTalent : Talent
	{
		public SmeltingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<SmeltingSkill>(this, "Smelting");
		}
	}

	[Serialized]
	public partial class CookingCaloriesLowTalent : Talent
	{
		public CookingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CookingSkill>(this, "Cooking");
		}
	}

	[Serialized]
	public partial class BlacksmithCaloriesLowTalent : Talent
	{
		public BlacksmithCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<BlacksmithSkill>(this, "Blacksmith");
		}
	}

	[Serialized]
	public partial class PotteryCaloriesLowTalent : Talent
	{
		public PotteryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PotterySkill>(this, "Pottery");
		}
	}

	[Serialized]
	public partial class PaintingCaloriesLowTalent : Talent
	{
		public PaintingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PaintingSkill>(this, "Painting");
		}
	}

	[Serialized]
	public partial class GlassworkingCaloriesLowTalent : Talent
	{
		public GlassworkingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<GlassworkingSkill>(this, "Glassworking");
		}
	}

	[Serialized]
	public partial class MechanicsCaloriesLowTalent : Talent
	{
		public MechanicsCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<MechanicsSkill>(this, "Mechanics");
		}
	}

	[Serialized]
	public partial class PaperMillingCaloriesLowTalent : Talent
	{
		public PaperMillingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<PaperMillingSkill>(this, "PaperMilling");
		}
	}

	[Serialized]
	public partial class FertilizersCaloriesLowTalent : Talent
	{
		public FertilizersCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<FertilizersSkill>(this, "Fertilizers");
		}
	}

	[Serialized]
	public partial class AdvancedBakingCaloriesLowTalent : Talent
	{
		public AdvancedBakingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedBakingSkill>(this, "AdvancedBaking");
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingCaloriesLowTalent : Talent
	{
		public AdvancedSmeltingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedSmeltingSkill>(this, "AdvancedSmelting");
		}
	}

	[Serialized]
	public partial class AdvancedCookingCaloriesLowTalent : Talent
	{
		public AdvancedCookingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedCookingSkill>(this, "AdvancedCooking");
		}
	}

	[Serialized]
	public partial class CompositesCaloriesLowTalent : Talent
	{
		public CompositesCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<CompositesSkill>(this, "Composites");
		}
	}

	[Serialized]
	public partial class AdvancedMasonryCaloriesLowTalent : Talent
	{
		public AdvancedMasonryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<AdvancedMasonrySkill>(this, "AdvancedMasonry");
		}
	}

	[Serialized]
	public partial class OilDrillingCaloriesLowTalent : Talent
	{
		public OilDrillingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<OilDrillingSkill>(this, "OilDrilling");
		}
	}

	[Serialized]
	public partial class ElectronicsCaloriesLowTalent : Talent
	{
		public ElectronicsCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<ElectronicsSkill>(this, "Electronics");
		}
	}

	[Serialized]
	public partial class IndustryCaloriesLowTalent : Talent
	{
		public IndustryCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<IndustrySkill>(this, "Industry");
		}
	}


	
	[Serialized]
	public partial class RecyclingCaloriesLowTalent : Talent
	{
		public RecyclingCaloriesLowTalent()
		{
			SkillTalentBonuses.AddLaborCostBonus<RecyclingSkill>(this, "Recycling");
		}
	}
	
	
	
	
	
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Efficient Production (Logging)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class LoggingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public LoggingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Hunting)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class HuntingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public HuntingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Gathering)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class GatheringCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public GatheringCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringCaloriesLowTalent),
			};
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (CampfireCooking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class CampfireCookingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public CampfireCookingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Mining)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class MiningCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public MiningCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningCaloriesLowTalent),
			};
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Efficient Production (Masonry)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class MasonryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public MasonryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Farming)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class FarmingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public FarmingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Shipwright)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class ShipwrightCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public ShipwrightCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightCaloriesLowTalent),
			};
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Milling)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class MillingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public MillingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Butchery)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class ButcheryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public ButcheryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcheryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Baking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class BakingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public BakingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Tailoring)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class TailoringCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public TailoringCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringCaloriesLowTalent),
			};
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Carpentry)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class CarpentryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public CarpentryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (BasicEngineering)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class BasicEngineeringCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public BasicEngineeringCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringCaloriesLowTalent),
			};
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Smelting)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class SmeltingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public SmeltingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Cooking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class CookingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public CookingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Blacksmith)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class BlacksmithCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public BlacksmithCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithCaloriesLowTalent),
			};
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Pottery)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class PotteryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public PotteryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotteryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Painting)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class PaintingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public PaintingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Glassworking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class GlassworkingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public GlassworkingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Mechanics)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class MechanicsCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public MechanicsCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsCaloriesLowTalent),
			};
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (PaperMilling)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class PaperMillingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public PaperMillingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Fertilizers)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class FertilizersCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public FertilizersCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersCaloriesLowTalent),
			};
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (AdvancedBaking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class AdvancedBakingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedBakingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (AdvancedSmelting)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class AdvancedSmeltingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedSmeltingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (AdvancedCooking)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class AdvancedCookingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedCookingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Composites)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class CompositesCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public CompositesCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesCaloriesLowTalent),
			};
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (AdvancedMasonry)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class AdvancedMasonryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public AdvancedMasonryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (OilDrilling)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class OilDrillingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public OilDrillingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Electronics)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class ElectronicsCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public ElectronicsCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsCaloriesLowTalent),
			};
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Efficient Production (Industry)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class IndustryCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public IndustryCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustryCaloriesLowTalent),
			};
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}


	
	[Serialized]
	[LocDisplayName("Efficient Production (Recycling)")]
	[LocDescription("Reduces calorie costs significantly. \nAt max investment, crafting is half the calorie cost, so you can craft twice as much.")]
	public partial class RecyclingCaloriesLowTalentGroup : CaloriesTalentGroupBase
	{
		public RecyclingCaloriesLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingCaloriesLowTalent),
			};
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}
	

}
