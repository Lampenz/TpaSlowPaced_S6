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
	public partial class LoggingResearchSpecialistTalent : Talent
	{
		public LoggingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<LoggingSkill>(this, "Logging");
		}
	}

	[Serialized]
	public partial class HuntingResearchSpecialistTalent : Talent
	{
		public HuntingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<HuntingSkill>(this, "Hunting");
		}
	}

	[Serialized]
	public partial class GatheringResearchSpecialistTalent : Talent
	{
		public GatheringResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<GatheringSkill>(this, "Gathering");
		}
	}

	[Serialized]
	public partial class CampfireCookingResearchSpecialistTalent : Talent
	{
		public CampfireCookingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<CampfireCookingSkill>(this, "CampfireCooking");
		}
	}

	[Serialized]
	public partial class MiningResearchSpecialistTalent : Talent
	{
		public MiningResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<MiningSkill>(this, "Mining");
		}
	}

	[Serialized]
	public partial class MasonryResearchSpecialistTalent : Talent
	{
		public MasonryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<MasonrySkill>(this, "Masonry");
		}
	}

	[Serialized]
	public partial class FarmingResearchSpecialistTalent : Talent
	{
		public FarmingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<FarmingSkill>(this, "Farming");
		}
	}

	[Serialized]
	public partial class ShipwrightResearchSpecialistTalent : Talent
	{
		public ShipwrightResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<ShipwrightSkill>(this, "Shipwright");
		}
	}

	[Serialized]
	public partial class MillingResearchSpecialistTalent : Talent
	{
		public MillingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<MillingSkill>(this, "Milling");
		}
	}

	[Serialized]
	public partial class ButcheryResearchSpecialistTalent : Talent
	{
		public ButcheryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<ButcherySkill>(this, "Butchery");
		}
	}

	[Serialized]
	public partial class BakingResearchSpecialistTalent : Talent
	{
		public BakingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<BakingSkill>(this, "Baking");
		}
	}

	[Serialized]
	public partial class TailoringResearchSpecialistTalent : Talent
	{
		public TailoringResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<TailoringSkill>(this, "Tailoring");
		}
	}

	[Serialized]
	public partial class CarpentryResearchSpecialistTalent : Talent
	{
		public CarpentryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<CarpentrySkill>(this, "Carpentry");
		}
	}

	[Serialized]
	public partial class BasicEngineeringResearchSpecialistTalent : Talent
	{
		public BasicEngineeringResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<BasicEngineeringSkill>(this, "BasicEngineering");
		}
	}

	[Serialized]
	public partial class SmeltingResearchSpecialistTalent : Talent
	{
		public SmeltingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<SmeltingSkill>(this, "Smelting");
		}
	}

	[Serialized]
	public partial class CookingResearchSpecialistTalent : Talent
	{
		public CookingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<CookingSkill>(this, "Cooking");
		}
	}

	[Serialized]
	public partial class BlacksmithResearchSpecialistTalent : Talent
	{
		public BlacksmithResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<BlacksmithSkill>(this, "Blacksmith");
		}
	}

	[Serialized]
	public partial class PotteryResearchSpecialistTalent : Talent
	{
		public PotteryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<PotterySkill>(this, "Pottery");
		}
	}

	[Serialized]
	public partial class PaintingResearchSpecialistTalent : Talent
	{
		public PaintingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<PaintingSkill>(this, "Painting");
		}
	}

	[Serialized]
	public partial class GlassworkingResearchSpecialistTalent : Talent
	{
		public GlassworkingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<GlassworkingSkill>(this, "Glassworking");
		}
	}

	[Serialized]
	public partial class MechanicsResearchSpecialistTalent : Talent
	{
		public MechanicsResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<MechanicsSkill>(this, "Mechanics");
		}
	}

	[Serialized]
	public partial class PaperMillingResearchSpecialistTalent : Talent
	{
		public PaperMillingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<PaperMillingSkill>(this, "PaperMilling");
		}
	}

	[Serialized]
	public partial class FertilizersResearchSpecialistTalent : Talent
	{
		public FertilizersResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<FertilizersSkill>(this, "Fertilizers");
		}
	}

	[Serialized]
	public partial class AdvancedBakingResearchSpecialistTalent : Talent
	{
		public AdvancedBakingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<AdvancedBakingSkill>(this, "AdvancedBaking");
		}
	}

	[Serialized]
	public partial class AdvancedSmeltingResearchSpecialistTalent : Talent
	{
		public AdvancedSmeltingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<AdvancedSmeltingSkill>(this, "AdvancedSmelting");
		}
	}

	[Serialized]
	public partial class AdvancedCookingResearchSpecialistTalent : Talent
	{
		public AdvancedCookingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<AdvancedCookingSkill>(this, "AdvancedCooking");
		}
	}

	[Serialized]
	public partial class CompositesResearchSpecialistTalent : Talent
	{
		public CompositesResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<CompositesSkill>(this, "Composites");
		}
	}

	[Serialized]
	public partial class AdvancedMasonryResearchSpecialistTalent : Talent
	{
		public AdvancedMasonryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<AdvancedMasonrySkill>(this, "AdvancedMasonry");
		}
	}

	[Serialized]
	public partial class OilDrillingResearchSpecialistTalent : Talent
	{
		public OilDrillingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<OilDrillingSkill>(this, "OilDrilling");
		}
	}

	[Serialized]
	public partial class ElectronicsResearchSpecialistTalent : Talent
	{
		public ElectronicsResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<ElectronicsSkill>(this, "Electronics");
		}
	}

	[Serialized]
	public partial class IndustryResearchSpecialistTalent : Talent
	{
		public IndustryResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<IndustrySkill>(this, "Industry");
		}
	}


	
	[Serialized]
	public partial class RecyclingResearchSpecialistTalent : Talent
	{
		public RecyclingResearchSpecialistTalent()
		{
			ResearchTalentBonuses.AddSpecialistBonuses<RecyclingSkill>(this, "Recycling");
		}
	}
	
	
	
	
	
	
	
	
	[Serialized]
	[LocDisplayName("Specialist (Logging)")]
	[LocDescription("Reduced inputs for research papers in Logging. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class LoggingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public LoggingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(LoggingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(LoggingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Hunting)")]
	[LocDescription("Reduced inputs for research papers in Hunting. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class HuntingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public HuntingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(HuntingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(HuntingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Gathering)")]
	[LocDescription("Reduced inputs for research papers in Gathering. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class GatheringResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public GatheringResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GatheringResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(GatheringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Campfire Cooking)")]
	[LocDescription("Reduced inputs for research papers in Campfire Cooking. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class CampfireCookingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public CampfireCookingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CampfireCookingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(CampfireCookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Mining)")]
	[LocDescription("Reduced inputs for research papers in Mining. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class MiningResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public MiningResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MiningResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(MiningSkill);
			
		}
	}
	
    [Serialized]
	[LocDisplayName("Specialist (Masonry)")]
	[LocDescription("Reduced inputs for research papers in Masonry. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class MasonryResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public MasonryResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MasonryResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(MasonrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Farming)")]
	[LocDescription("Reduced inputs for research papers in Farming. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class FarmingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public FarmingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FarmingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(FarmingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Shipwright)")]
	[LocDescription("Reduced inputs for research papers in Shipwright. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class ShipwrightResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public ShipwrightResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(ShipwrightResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(ShipwrightSkill);
			
		}
	}




	[Serialized]
	[LocDisplayName("Specialist (Baking)")]
	[LocDescription("Reduced inputs for research papers in Baking. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class BakingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public BakingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BakingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(BakingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Tailoring)")]
	[LocDescription("Reduced inputs for research papers in Tailoring. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class TailoringResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public TailoringResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(TailoringResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(TailoringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Carpentry)")]
	[LocDescription("Reduced inputs for research papers in Carpentry. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class CarpentryResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public CarpentryResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CarpentryResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(CarpentrySkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Basic Engineering)")]
	[LocDescription("Reduced inputs for research papers in Basic Engineering. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class BasicEngineeringResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public BasicEngineeringResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BasicEngineeringResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(BasicEngineeringSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Smelting)")]
	[LocDescription("Reduced inputs for research papers in Smelting. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class SmeltingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public SmeltingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(SmeltingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(SmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Cooking)")]
	[LocDescription("Reduced inputs for research papers in Cooking. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class CookingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public CookingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(CookingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(CookingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Blacksmith)")]
	[LocDescription("Reduced inputs for research papers in Blacksmith. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class BlacksmithResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public BlacksmithResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(BlacksmithResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(BlacksmithSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Pottery)")]
	[LocDescription("Reduced inputs for research papers in Pottery. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class PotteryResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public PotteryResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PotteryResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(PotterySkill);
			
		}
	}



	[Serialized]
	[LocDisplayName("Specialist (Glassworking)")]
	[LocDescription("Reduced inputs for research papers in Glassworking. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class GlassworkingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public GlassworkingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(GlassworkingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(GlassworkingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Mechanics)")]
	[LocDescription("Reduced inputs for research papers in Mechanics. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class MechanicsResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public MechanicsResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(MechanicsResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(MechanicsSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Paper Milling)")]
	[LocDescription("Reduced inputs for research papers in Paper Milling. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class PaperMillingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public PaperMillingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(PaperMillingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(PaperMillingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Fertilizers)")]
	[LocDescription("Reduced inputs for research papers in Fertilizers. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class FertilizersResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public FertilizersResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(FertilizersResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(FertilizersSkill);
			
		}
	}



	[Serialized]
	[LocDisplayName("Specialist (Advanced Smelting)")]
	[LocDescription("Reduced inputs for research papers in Advanced Smelting. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class AdvancedSmeltingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public AdvancedSmeltingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedSmeltingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(AdvancedSmeltingSkill);
			
		}
	}

	[Serialized]
	[LocDisplayName("Specialist (Advanced Cooking)")]
	[LocDescription("Reduced inputs for research papers in Advanced Cooking. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class AdvancedCookingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public AdvancedCookingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(AdvancedCookingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(AdvancedCookingSkill);
			
		}
	}





	[Serialized]
	[LocDisplayName("Specialist (Oil Drilling)")]
	[LocDescription("Reduced inputs for research papers in Oil Drilling. \n \nCAREFUL! This raises the cost of all research papers outside this skill!")]
	public partial class OilDrillingResearchSpecialistTalentGroup : ResearchSpecialistTalentGroupBase
	{
		public OilDrillingResearchSpecialistTalentGroup()
		{
			Talents = new Type[]
			{
				typeof(OilDrillingResearchSpecialistTalent),
			};
			this.OwningSkill = typeof(OilDrillingSkill);
			
		}
	}





	

	
	

}
