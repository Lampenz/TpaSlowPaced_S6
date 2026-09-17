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
	public partial class LoggingResearchPragmatistTalent : Talent
	{
		public LoggingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<LoggingSkill>(this, "Logging");
		}
	}

	[Serialized]
	public partial class HuntingResearchPragmatistTalent : Talent
	{
		public HuntingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<HuntingSkill>(this, "Hunting");
		}
	}

	[Serialized]
	public partial class GatheringResearchPragmatistTalent : Talent
	{
		public GatheringResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<GatheringSkill>(this, "Gathering");
		}
	}

	[Serialized]
	public partial class CampfireCookingResearchPragmatistTalent : Talent
	{
		public CampfireCookingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<CampfireCookingSkill>(this, "CampfireCooking");
		}
	}

	[Serialized]
	public partial class MiningResearchPragmatistTalent : Talent
	{
		public MiningResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<MiningSkill>(this, "Mining");
		}
	}

	[Serialized]
	public partial class MasonryResearchPragmatistTalent : Talent
	{
		public MasonryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<MasonrySkill>(this, "Masonry");
		}
	}

	[Serialized]
	public partial class FarmingResearchPragmatistTalent : Talent
	{
		public FarmingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<FarmingSkill>(this, "Farming");
		}
	}

	[Serialized]
	public partial class ShipwrightResearchPragmatistTalent : Talent
	{
		public ShipwrightResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<ShipwrightSkill>(this, "Shipwright");
		}
	}

	[Serialized]
	public partial class MillingResearchPragmatistTalent : Talent
	{
		public MillingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<MillingSkill>(this, "Milling");
		}
	}

	[Serialized]
	public partial class ButcheryResearchPragmatistTalent : Talent
	{
		public ButcheryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<ButcherySkill>(this, "Butchery");
		}
	}

	[Serialized]
	public partial class BakingResearchPragmatistTalent : Talent
	{
		public BakingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<BakingSkill>(this, "Baking");
		}
	}

	[Serialized]
	public partial class TailoringResearchPragmatistTalent : Talent
	{
		public TailoringResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<TailoringSkill>(this, "Tailoring");
		}
	}

	[Serialized]
	public partial class CarpentryResearchPragmatistTalent : Talent
	{
		public CarpentryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<CarpentrySkill>(this, "Carpentry");
		}
	}

	[Serialized]
	public partial class BasicEngineeringResearchPragmatistTalent : Talent
	{
		public BasicEngineeringResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<BasicEngineeringSkill>(this, "BasicEngineering");
		}
	}

	[Serialized]
	public partial class SmeltingResearchPragmatistTalent : Talent
	{
		public SmeltingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<SmeltingSkill>(this, "Smelting");
		}
	}

	[Serialized]
	public partial class CookingResearchPragmatistTalent : Talent
	{
		public CookingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<CookingSkill>(this, "Cooking");
		}
	}

	[Serialized]
	public partial class BlacksmithResearchPragmatistTalent : Talent
	{
		public BlacksmithResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<BlacksmithSkill>(this, "Blacksmith");
		}
	}

	[Serialized]
	public partial class PotteryResearchPragmatistTalent : Talent
	{
		public PotteryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<PotterySkill>(this, "Pottery");
		}
	}

	[Serialized]
	public partial class PaintingResearchPragmatistTalent : Talent
	{
		public PaintingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<PaintingSkill>(this, "Painting");
		}
	}

	[Serialized]
	public partial class GlassworkingResearchPragmatistTalent : Talent
	{
		public GlassworkingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<GlassworkingSkill>(this, "Glassworking");
		}
	}

	[Serialized]
	public partial class MechanicsResearchPragmatistTalent : Talent
	{
		public MechanicsResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<MechanicsSkill>(this, "Mechanics");
		}
	}

	[Serialized]
	public partial class PaperMillingResearchPragmatistTalent : Talent
	{
		public PaperMillingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<PaperMillingSkill>(this, "PaperMilling");
		}
	}

	[Serialized]
	public partial class FertilizersResearchPragmatistTalent : Talent
	{
		public FertilizersResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<FertilizersSkill>(this, "Fertilizers");
		}
	}

	[Serialized]
	public partial class AdvancedBakingResearchPragmatistTalent : Talent
	{
		public AdvancedBakingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<AdvancedBakingSkill>(this, "AdvancedBaking");
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingResearchPragmatistTalent : Talent
	{
		public AdvancedSmeltingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<AdvancedSmeltingSkill>(this, "AdvancedSmelting");
		}
	}

	[Serialized]
	public partial class AdvancedCookingResearchPragmatistTalent : Talent
	{
		public AdvancedCookingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<AdvancedCookingSkill>(this, "AdvancedCooking");
		}
	}

	[Serialized]
	public partial class CompositesResearchPragmatistTalent : Talent
	{
		public CompositesResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<CompositesSkill>(this, "Composites");
		}
	}

	[Serialized]
	public partial class AdvancedMasonryResearchPragmatistTalent : Talent
	{
		public AdvancedMasonryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<AdvancedMasonrySkill>(this, "AdvancedMasonry");
		}
	}

	[Serialized]
	public partial class OilDrillingResearchPragmatistTalent : Talent
	{
		public OilDrillingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<OilDrillingSkill>(this, "OilDrilling");
		}
	}

	[Serialized]
	public partial class ElectronicsResearchPragmatistTalent : Talent
	{
		public ElectronicsResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<ElectronicsSkill>(this, "Electronics");
		}
	}

	[Serialized]
	public partial class IndustryResearchPragmatistTalent : Talent
	{
		public IndustryResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<IndustrySkill>(this, "Industry");
		}
	}


	
	[Serialized]
	public partial class RecyclingResearchPragmatistTalent : Talent
	{
		public RecyclingResearchPragmatistTalent()
		{
			ResearchTalentBonuses.AddPragmatistBonuses<RecyclingSkill>(this, "Recycling");
		}
	}
	
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Practically Minded (Logging)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class LoggingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public LoggingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Hunting)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class HuntingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public HuntingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Gathering)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class GatheringResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public GatheringResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (CampfireCooking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class CampfireCookingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public CampfireCookingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Mining)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class MiningResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public MiningResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Practically Minded (Masonry)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class MasonryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public MasonryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Farming)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class FarmingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public FarmingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Shipwright)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class ShipwrightResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public ShipwrightResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Milling)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class MillingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public MillingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MillingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(MillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Butchery)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class ButcheryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public ButcheryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ButcheryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(ButcherySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Baking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class BakingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public BakingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Tailoring)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class TailoringResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public TailoringResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Carpentry)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class CarpentryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public CarpentryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (BasicEngineering)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class BasicEngineeringResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public BasicEngineeringResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Smelting)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class SmeltingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public SmeltingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Cooking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class CookingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public CookingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Blacksmith)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class BlacksmithResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public BlacksmithResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Pottery)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class PotteryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public PotteryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotteryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Painting)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class PaintingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public PaintingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaintingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(PaintingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Glassworking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class GlassworkingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public GlassworkingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Mechanics)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class MechanicsResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public MechanicsResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (PaperMilling)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class PaperMillingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public PaperMillingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Fertilizers)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class FertilizersResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public FertilizersResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (AdvancedBaking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class AdvancedBakingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public AdvancedBakingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedBakingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(AdvancedBakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (AdvancedSmelting)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class AdvancedSmeltingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public AdvancedSmeltingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (AdvancedCooking)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class AdvancedCookingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public AdvancedCookingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Composites)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class CompositesResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public CompositesResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CompositesResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(CompositesSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (AdvancedMasonry)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class AdvancedMasonryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public AdvancedMasonryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedMasonryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(AdvancedMasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (OilDrilling)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class OilDrillingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public OilDrillingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Electronics)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class ElectronicsResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public ElectronicsResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ElectronicsResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(ElectronicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Practically Minded (Industry)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class IndustryResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public IndustryResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(IndustryResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(IndustrySkill);
			
		}
	}


	
	[Serialized]
	[LocDisplayName("Practically Minded (Recycling)")]
	[LocDescription("Reduces crafting costs, but makes research very expensive..")]
	public partial class RecyclingResearchPragmatistTalentGroup : ResearchPragmatistTalentGroupBase
	{
		public RecyclingResearchPragmatistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(RecyclingResearchPragmatistTalent),
			};
			this.OwningSkill = typeof(RecyclingSkill);
			
		}
	}
	
	
	
	

}
