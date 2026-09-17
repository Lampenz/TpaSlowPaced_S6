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
	public partial class LoggingResearchUniversalistTalent : Talent
	{
		public LoggingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<LoggingSkill>(this, "Logging");
		}
	}

	[Serialized]
	public partial class HuntingResearchUniversalistTalent : Talent
	{
		public HuntingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<HuntingSkill>(this, "Hunting");
		}
	}

	[Serialized]
	public partial class GatheringResearchUniversalistTalent : Talent
	{
		public GatheringResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<GatheringSkill>(this, "Gathering");
		}
	}

	[Serialized]
	public partial class CampfireCookingResearchUniversalistTalent : Talent
	{
		public CampfireCookingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<CampfireCookingSkill>(this, "CampfireCooking");
		}
	}

	[Serialized]
	public partial class MiningResearchUniversalistTalent : Talent
	{
		public MiningResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<MiningSkill>(this, "Mining");
		}
	}

	[Serialized]
	public partial class MasonryResearchUniversalistTalent : Talent
	{
		public MasonryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<MasonrySkill>(this, "Masonry");
		}
	}

	[Serialized]
	public partial class FarmingResearchUniversalistTalent : Talent
	{
		public FarmingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<FarmingSkill>(this, "Farming");
		}
	}

	[Serialized]
	public partial class ShipwrightResearchUniversalistTalent : Talent
	{
		public ShipwrightResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<ShipwrightSkill>(this, "Shipwright");
		}
	}

	[Serialized]
	public partial class MillingResearchUniversalistTalent : Talent
	{
		public MillingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<MillingSkill>(this, "Milling");
		}
	}

	[Serialized]
	public partial class ButcheryResearchUniversalistTalent : Talent
	{
		public ButcheryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<ButcherySkill>(this, "Butchery");
		}
	}

	[Serialized]
	public partial class BakingResearchUniversalistTalent : Talent
	{
		public BakingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<BakingSkill>(this, "Baking");
		}
	}

	[Serialized]
	public partial class TailoringResearchUniversalistTalent : Talent
	{
		public TailoringResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<TailoringSkill>(this, "Tailoring");
		}
	}

	[Serialized]
	public partial class CarpentryResearchUniversalistTalent : Talent
	{
		public CarpentryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<CarpentrySkill>(this, "Carpentry");
		}
	}

	[Serialized]
	public partial class BasicEngineeringResearchUniversalistTalent : Talent
	{
		public BasicEngineeringResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<BasicEngineeringSkill>(this, "BasicEngineering");
		}
	}

	[Serialized]
	public partial class SmeltingResearchUniversalistTalent : Talent
	{
		public SmeltingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<SmeltingSkill>(this, "Smelting");
		}
	}

	[Serialized]
	public partial class CookingResearchUniversalistTalent : Talent
	{
		public CookingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<CookingSkill>(this, "Cooking");
		}
	}

	[Serialized]
	public partial class BlacksmithResearchUniversalistTalent : Talent
	{
		public BlacksmithResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<BlacksmithSkill>(this, "Blacksmith");
		}
	}

	[Serialized]
	public partial class PotteryResearchUniversalistTalent : Talent
	{
		public PotteryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<PotterySkill>(this, "Pottery");
		}
	}

	[Serialized]
	public partial class PaintingResearchUniversalistTalent : Talent
	{
		public PaintingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<PaintingSkill>(this, "Painting");
		}
	}

	[Serialized]
	public partial class GlassworkingResearchUniversalistTalent : Talent
	{
		public GlassworkingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<GlassworkingSkill>(this, "Glassworking");
		}
	}

	[Serialized]
	public partial class MechanicsResearchUniversalistTalent : Talent
	{
		public MechanicsResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<MechanicsSkill>(this, "Mechanics");
		}
	}

	[Serialized]
	public partial class PaperMillingResearchUniversalistTalent : Talent
	{
		public PaperMillingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<PaperMillingSkill>(this, "PaperMilling");
		}
	}

	[Serialized]
	public partial class FertilizersResearchUniversalistTalent : Talent
	{
		public FertilizersResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<FertilizersSkill>(this, "Fertilizers");
		}
	}

	[Serialized]
	public partial class AdvancedBakingResearchUniversalistTalent : Talent
	{
		public AdvancedBakingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<AdvancedBakingSkill>(this, "AdvancedBaking");
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingResearchUniversalistTalent : Talent
	{
		public AdvancedSmeltingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<AdvancedSmeltingSkill>(this, "AdvancedSmelting");
		}
	}

	[Serialized]
	public partial class AdvancedCookingResearchUniversalistTalent : Talent
	{
		public AdvancedCookingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<AdvancedCookingSkill>(this, "AdvancedCooking");
		}
	}

	[Serialized]
	public partial class CompositesResearchUniversalistTalent : Talent
	{
		public CompositesResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<CompositesSkill>(this, "Composites");
		}
	}

	[Serialized]
	public partial class AdvancedMasonryResearchUniversalistTalent : Talent
	{
		public AdvancedMasonryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<AdvancedMasonrySkill>(this, "AdvancedMasonry");
		}
	}

	[Serialized]
	public partial class OilDrillingResearchUniversalistTalent : Talent
	{
		public OilDrillingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<OilDrillingSkill>(this, "OilDrilling");
		}
	}

	[Serialized]
	public partial class ElectronicsResearchUniversalistTalent : Talent
	{
		public ElectronicsResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<ElectronicsSkill>(this, "Electronics");
		}
	}

	[Serialized]
	public partial class IndustryResearchUniversalistTalent : Talent
	{
		public IndustryResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<IndustrySkill>(this, "Industry");
		}
	}


	
	[Serialized]
	public partial class RecyclingResearchUniversalistTalent : Talent
	{
		public RecyclingResearchUniversalistTalent()
		{
			ResearchTalentBonuses.AddUniversalistBonuses<RecyclingSkill>(this, "Recycling");
		}
	}
	
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Jack of all Trades (Logging)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Logging.")]
	public partial class LoggingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public LoggingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Hunting)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Hunting.")]
	public partial class HuntingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public HuntingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Gathering)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Gathering.")]
	public partial class GatheringResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public GatheringResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (CampfireCooking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of CampfireCooking.")]
	public partial class CampfireCookingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public CampfireCookingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Mining)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Mining.")]
	public partial class MiningResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public MiningResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Jack of all Trades (Masonry)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Masonry.")]
	public partial class MasonryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public MasonryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Farming)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Farming.")]
	public partial class FarmingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public FarmingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Shipwright)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Shipwright.")]
	public partial class ShipwrightResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public ShipwrightResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Milling)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Milling.")]
	public partial class MillingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public MillingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Butchery)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Butchery.")]
	public partial class ButcheryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public ButcheryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcheryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Baking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Baking.")]
	public partial class BakingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public BakingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Tailoring)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Tailoring.")]
	public partial class TailoringResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public TailoringResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Carpentry)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Carpentry.")]
	public partial class CarpentryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public CarpentryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (BasicEngineering)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of BasicEngineering.")]
	public partial class BasicEngineeringResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public BasicEngineeringResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Smelting)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Smelting.")]
	public partial class SmeltingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public SmeltingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Cooking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Cooking.")]
	public partial class CookingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public CookingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Blacksmith)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Blacksmith.")]
	public partial class BlacksmithResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public BlacksmithResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Pottery)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Pottery.")]
	public partial class PotteryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public PotteryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotteryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Painting)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Painting.")]
	public partial class PaintingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public PaintingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Glassworking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Glassworking.")]
	public partial class GlassworkingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public GlassworkingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Mechanics)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Mechanics.")]
	public partial class MechanicsResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public MechanicsResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (PaperMilling)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of PaperMilling.")]
	public partial class PaperMillingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public PaperMillingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Fertilizers)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Fertilizers.")]
	public partial class FertilizersResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public FertilizersResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (AdvancedBaking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of AdvancedBaking.")]
	public partial class AdvancedBakingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public AdvancedBakingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (AdvancedSmelting)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of AdvancedSmelting.")]
	public partial class AdvancedSmeltingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public AdvancedSmeltingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (AdvancedCooking)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of AdvancedCooking.")]
	public partial class AdvancedCookingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public AdvancedCookingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Composites)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Composites.")]
	public partial class CompositesResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public CompositesResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (AdvancedMasonry)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of AdvancedMasonry.")]
	public partial class AdvancedMasonryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public AdvancedMasonryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (OilDrilling)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of OilDrilling.")]
	public partial class OilDrillingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public OilDrillingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Electronics)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Electronics.")]
	public partial class ElectronicsResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public ElectronicsResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Jack of all Trades (Industry)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Industry.")]
	public partial class IndustryResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public IndustryResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustryResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}


	
	[Serialized]
	[LocDisplayName("Jack of all Trades (Recycling)")]
	[LocDescription("Reduced inputs, but increased crafting time, for all research papers, even outside of Recycling.")]
	public partial class RecyclingResearchUniversalistTalentGroup : ResearchUniversalistTalentGroupBase
	{
		public RecyclingResearchUniversalistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingResearchUniversalistTalent),
			};
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}
	
	
	
	
	
	
	
	
	
	
	

}
