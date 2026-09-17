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
	public partial class LoggingSpeedHighTalent : Talent
	{
		public LoggingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<LoggingSkill>(this, "Logging", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class HuntingSpeedHighTalent : Talent
	{
		public HuntingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<HuntingSkill>(this, "Hunting", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class GatheringSpeedHighTalent : Talent
	{
		public GatheringSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<GatheringSkill>(this, "Gathering", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class CampfireCookingSpeedHighTalent : Talent
	{
		public CampfireCookingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CampfireCookingSkill>(this, "CampfireCooking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class MiningSpeedHighTalent : Talent
	{
		public MiningSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MiningSkill>(this, "Mining", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class MasonrySpeedHighTalent : Talent
	{
		public MasonrySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MasonrySkill>(this, "Masonry", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class FarmingSpeedHighTalent : Talent
	{
		public FarmingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<FarmingSkill>(this, "Farming", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class ShipwrightSpeedHighTalent : Talent
	{
		public ShipwrightSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ShipwrightSkill>(this, "Shipwright", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class MillingSpeedHighTalent : Talent
	{
		public MillingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MillingSkill>(this, "Milling", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class ButcherySpeedHighTalent : Talent
	{
		public ButcherySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ButcherySkill>(this, "Butchery", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class BakingSpeedHighTalent : Talent
	{
		public BakingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BakingSkill>(this, "Baking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class TailoringSpeedHighTalent : Talent
	{
		public TailoringSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<TailoringSkill>(this, "Tailoring", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class CarpentrySpeedHighTalent : Talent
	{
		public CarpentrySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CarpentrySkill>(this, "Carpentry", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class BasicEngineeringSpeedHighTalent : Talent
	{
		public BasicEngineeringSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BasicEngineeringSkill>(this, "BasicEngineering", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class SmeltingSpeedHighTalent : Talent
	{
		public SmeltingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<SmeltingSkill>(this, "Smelting", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class CookingSpeedHighTalent : Talent
	{
		public CookingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CookingSkill>(this, "Cooking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class BlacksmithSpeedHighTalent : Talent
	{
		public BlacksmithSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BlacksmithSkill>(this, "Blacksmith", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class PotterySpeedHighTalent : Talent
	{
		public PotterySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PotterySkill>(this, "Pottery", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class PaintingSpeedHighTalent : Talent
	{
		public PaintingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PaintingSkill>(this, "Painting", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class GlassworkingSpeedHighTalent : Talent
	{
		public GlassworkingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<GlassworkingSkill>(this, "Glassworking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class MechanicsSpeedHighTalent : Talent
	{
		public MechanicsSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MechanicsSkill>(this, "Mechanics", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class PaperMillingSpeedHighTalent : Talent
	{
		public PaperMillingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PaperMillingSkill>(this, "PaperMilling", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class FertilizersSpeedHighTalent : Talent
	{
		public FertilizersSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<FertilizersSkill>(this, "Fertilizers", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class AdvancedBakingSpeedHighTalent : Talent
	{
		public AdvancedBakingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedBakingSkill>(this, "AdvancedBaking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingSpeedHighTalent : Talent
	{
		public AdvancedSmeltingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedSmeltingSkill>(this, "AdvancedSmelting", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class AdvancedCookingSpeedHighTalent : Talent
	{
		public AdvancedCookingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedCookingSkill>(this, "AdvancedCooking", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class CompositesSpeedHighTalent : Talent
	{
		public CompositesSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CompositesSkill>(this, "Composites", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class AdvancedMasonrySpeedHighTalent : Talent
	{
		public AdvancedMasonrySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedMasonrySkill>(this, "AdvancedMasonry", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class OilDrillingSpeedHighTalent : Talent
	{
		public OilDrillingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<OilDrillingSkill>(this, "OilDrilling", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class ElectronicsSpeedHighTalent : Talent
	{
		public ElectronicsSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ElectronicsSkill>(this, "Electronics", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	[Serialized]
	public partial class IndustrySpeedHighTalent : Talent
	{
		public IndustrySpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<IndustrySkill>(this, "Industry", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}

	
	[Serialized]
	public partial class RecyclingSpeedHighTalent : Talent
	{
		public RecyclingSpeedHighTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<RecyclingSkill>(this, "Recycling", value: 0.8f, cap: 0.2f, powervalue: 1.05f, powercap: 1.2f );
		}
	}
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Lightning Production (Logging)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class LoggingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public LoggingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Hunting)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class HuntingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public HuntingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Gathering)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class GatheringSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public GatheringSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (CampfireCooking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class CampfireCookingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public CampfireCookingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Mining)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class MiningSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public MiningSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Lightning Production (Masonry)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class MasonrySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public MasonrySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonrySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Farming)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class FarmingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public FarmingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Shipwright)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class ShipwrightSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public ShipwrightSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Milling)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class MillingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public MillingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Butchery)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class ButcherySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public ButcherySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcherySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Baking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class BakingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public BakingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Tailoring)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class TailoringSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public TailoringSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Carpentry)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class CarpentrySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public CarpentrySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentrySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (BasicEngineering)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class BasicEngineeringSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public BasicEngineeringSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Smelting)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class SmeltingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public SmeltingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Cooking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class CookingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public CookingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Blacksmith)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class BlacksmithSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public BlacksmithSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Pottery)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class PotterySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public PotterySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotterySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Painting)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class PaintingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public PaintingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Glassworking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class GlassworkingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public GlassworkingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Mechanics)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class MechanicsSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public MechanicsSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (PaperMilling)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class PaperMillingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public PaperMillingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Fertilizers)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class FertilizersSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public FertilizersSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (AdvancedBaking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class AdvancedBakingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedBakingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (AdvancedSmelting)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class AdvancedSmeltingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedSmeltingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (AdvancedCooking)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class AdvancedCookingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedCookingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Composites)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class CompositesSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public CompositesSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (AdvancedMasonry)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class AdvancedMasonrySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedMasonrySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonrySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (OilDrilling)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class OilDrillingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public OilDrillingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Electronics)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class ElectronicsSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public ElectronicsSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Lightning Production (Industry)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class IndustrySpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public IndustrySpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustrySpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}

	
	
	[Serialized]
	[LocDisplayName("Lightning Production (Recycling)")]
	[LocDescription("Reduces crafting times drastically.")]
	public partial class RecyclingSpeedHighTalentGroup : SpeedTalentGroupBase
	{
		public RecyclingSpeedHighTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingSpeedHighTalent),
			};
			this.StarCost = 2;
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}
	
	

}
