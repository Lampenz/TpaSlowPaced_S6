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
	public partial class LoggingSpeedLowTalent : Talent
	{
		public LoggingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<LoggingSkill>(this, "Logging");
		}
	}

	[Serialized]
	public partial class HuntingSpeedLowTalent : Talent
	{
		public HuntingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<HuntingSkill>(this, "Hunting");
		}
	}

	[Serialized]
	public partial class GatheringSpeedLowTalent : Talent
	{
		public GatheringSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<GatheringSkill>(this, "Gathering");
		}
	}

	[Serialized]
	public partial class CampfireCookingSpeedLowTalent : Talent
	{
		public CampfireCookingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CampfireCookingSkill>(this, "CampfireCooking");
		}
	}

	[Serialized]
	public partial class MiningSpeedLowTalent : Talent
	{
		public MiningSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MiningSkill>(this, "Mining");
		}
	}

	[Serialized]
	public partial class MasonrySpeedLowTalent : Talent
	{
		public MasonrySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MasonrySkill>(this, "Masonry");
		}
	}

	[Serialized]
	public partial class FarmingSpeedLowTalent : Talent
	{
		public FarmingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<FarmingSkill>(this, "Farming");
		}
	}

	[Serialized]
	public partial class ShipwrightSpeedLowTalent : Talent
	{
		public ShipwrightSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ShipwrightSkill>(this, "Shipwright");
		}
	}

	[Serialized]
	public partial class MillingSpeedLowTalent : Talent
	{
		public MillingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MillingSkill>(this, "Milling");
		}
	}

	[Serialized]
	public partial class ButcherySpeedLowTalent : Talent
	{
		public ButcherySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ButcherySkill>(this, "Butchery");
		}
	}

	[Serialized]
	public partial class BakingSpeedLowTalent : Talent
	{
		public BakingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BakingSkill>(this, "Baking");
		}
	}

	[Serialized]
	public partial class TailoringSpeedLowTalent : Talent
	{
		public TailoringSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<TailoringSkill>(this, "Tailoring");
		}
	}

	[Serialized]
	public partial class CarpentrySpeedLowTalent : Talent
	{
		public CarpentrySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CarpentrySkill>(this, "Carpentry");
		}
	}

	[Serialized]
	public partial class BasicEngineeringSpeedLowTalent : Talent
	{
		public BasicEngineeringSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BasicEngineeringSkill>(this, "BasicEngineering");
		}
	}

	[Serialized]
	public partial class SmeltingSpeedLowTalent : Talent
	{
		public SmeltingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<SmeltingSkill>(this, "Smelting");
		}
	}

	[Serialized]
	public partial class CookingSpeedLowTalent : Talent
	{
		public CookingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CookingSkill>(this, "Cooking");
		}
	}

	[Serialized]
	public partial class BlacksmithSpeedLowTalent : Talent
	{
		public BlacksmithSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<BlacksmithSkill>(this, "Blacksmith");
		}
	}

	[Serialized]
	public partial class PotterySpeedLowTalent : Talent
	{
		public PotterySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PotterySkill>(this, "Pottery");
		}
	}

	[Serialized]
	public partial class PaintingSpeedLowTalent : Talent
	{
		public PaintingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PaintingSkill>(this, "Painting");
		}
	}

	[Serialized]
	public partial class GlassworkingSpeedLowTalent : Talent
	{
		public GlassworkingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<GlassworkingSkill>(this, "Glassworking");
		}
	}

	[Serialized]
	public partial class MechanicsSpeedLowTalent : Talent
	{
		public MechanicsSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<MechanicsSkill>(this, "Mechanics");
		}
	}

	[Serialized]
	public partial class PaperMillingSpeedLowTalent : Talent
	{
		public PaperMillingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<PaperMillingSkill>(this, "PaperMilling");
		}
	}

	[Serialized]
	public partial class FertilizersSpeedLowTalent : Talent
	{
		public FertilizersSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<FertilizersSkill>(this, "Fertilizers");
		}
	}

	[Serialized]
	public partial class AdvancedBakingSpeedLowTalent : Talent
	{
		public AdvancedBakingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedBakingSkill>(this, "AdvancedBaking");
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingSpeedLowTalent : Talent
	{
		public AdvancedSmeltingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedSmeltingSkill>(this, "AdvancedSmelting");
		}
	}

	[Serialized]
	public partial class AdvancedCookingSpeedLowTalent : Talent
	{
		public AdvancedCookingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedCookingSkill>(this, "AdvancedCooking");
		}
	}

	[Serialized]
	public partial class CompositesSpeedLowTalent : Talent
	{
		public CompositesSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<CompositesSkill>(this, "Composites");
		}
	}

	[Serialized]
	public partial class AdvancedMasonrySpeedLowTalent : Talent
	{
		public AdvancedMasonrySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<AdvancedMasonrySkill>(this, "AdvancedMasonry");
		}
	}

	[Serialized]
	public partial class OilDrillingSpeedLowTalent : Talent
	{
		public OilDrillingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<OilDrillingSkill>(this, "OilDrilling");
		}
	}

	[Serialized]
	public partial class ElectronicsSpeedLowTalent : Talent
	{
		public ElectronicsSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<ElectronicsSkill>(this, "Electronics");
		}
	}

	[Serialized]
	public partial class IndustrySpeedLowTalent : Talent
	{
		public IndustrySpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<IndustrySkill>(this, "Industry");
		}
	}

	
	[Serialized]
	public partial class RecyclingSpeedLowTalent : Talent
	{
		public RecyclingSpeedLowTalent()
		{
			SkillTalentBonuses.AddCraftTimeBonus<RecyclingSkill>(this, "Recycling");
		}
	}
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Fast Production (Logging)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class LoggingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public LoggingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingSpeedLowTalent),
			};
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Hunting)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class HuntingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public HuntingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingSpeedLowTalent),
			};
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Gathering)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class GatheringSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public GatheringSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringSpeedLowTalent),
			};
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (CampfireCooking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class CampfireCookingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public CampfireCookingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingSpeedLowTalent),
			};
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Mining)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class MiningSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public MiningSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningSpeedLowTalent),
			};
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Fast Production (Masonry)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class MasonrySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public MasonrySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonrySpeedLowTalent),
			};
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Farming)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class FarmingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public FarmingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingSpeedLowTalent),
			};
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Shipwright)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class ShipwrightSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public ShipwrightSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightSpeedLowTalent),
			};
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Milling)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class MillingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public MillingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingSpeedLowTalent),
			};
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Butchery)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class ButcherySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public ButcherySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcherySpeedLowTalent),
			};
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Baking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class BakingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public BakingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingSpeedLowTalent),
			};
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Tailoring)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class TailoringSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public TailoringSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringSpeedLowTalent),
			};
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Carpentry)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class CarpentrySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public CarpentrySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentrySpeedLowTalent),
			};
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (BasicEngineering)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class BasicEngineeringSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public BasicEngineeringSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringSpeedLowTalent),
			};
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Smelting)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class SmeltingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public SmeltingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingSpeedLowTalent),
			};
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Cooking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class CookingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public CookingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingSpeedLowTalent),
			};
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Blacksmith)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class BlacksmithSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public BlacksmithSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithSpeedLowTalent),
			};
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Pottery)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class PotterySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public PotterySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotterySpeedLowTalent),
			};
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Painting)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class PaintingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public PaintingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingSpeedLowTalent),
			};
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Glassworking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class GlassworkingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public GlassworkingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingSpeedLowTalent),
			};
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Mechanics)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class MechanicsSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public MechanicsSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsSpeedLowTalent),
			};
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (PaperMilling)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class PaperMillingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public PaperMillingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingSpeedLowTalent),
			};
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Fertilizers)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class FertilizersSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public FertilizersSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersSpeedLowTalent),
			};
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (AdvancedBaking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class AdvancedBakingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedBakingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingSpeedLowTalent),
			};
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (AdvancedSmelting)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class AdvancedSmeltingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedSmeltingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingSpeedLowTalent),
			};
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (AdvancedCooking)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class AdvancedCookingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedCookingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingSpeedLowTalent),
			};
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Composites)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class CompositesSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public CompositesSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesSpeedLowTalent),
			};
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (AdvancedMasonry)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class AdvancedMasonrySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public AdvancedMasonrySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonrySpeedLowTalent),
			};
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (OilDrilling)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class OilDrillingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public OilDrillingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingSpeedLowTalent),
			};
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Electronics)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class ElectronicsSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public ElectronicsSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsSpeedLowTalent),
			};
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Fast Production (Industry)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class IndustrySpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public IndustrySpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustrySpeedLowTalent),
			};
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}
	
	
	[Serialized]
	[LocDisplayName("Fast Production (Recycling)")]
	[LocDescription("Reduces crafting times significantly.")]
	public partial class RecyclingSpeedLowTalentGroup : SpeedTalentGroupBase
	{
		public RecyclingSpeedLowTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingSpeedLowTalent),
			};
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}
	
	

}
