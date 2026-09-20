namespace Eco.Mods.TechTree
{
    public static class SkillBookIntelligenceRequirements
    {
        public static readonly System.Collections.Generic.Dictionary<string, int> BySkillName =
            new System.Collections.Generic.Dictionary<string, int>(System.StringComparer.OrdinalIgnoreCase)
            {


            /* (when gated by law, this were our defaults.)
            Day 4: Shipwright, Tailoring [x]
            Day 7:  Basic engineering, Milling, Fertilizers [x]
            Day 11: Smelting, Painting [x]
            Day 14: Cooking, Baking, Blacksmithing, Pottery, Glassworking, Papermilling
            Day 21:  Mechanics, Advanced smelting, Recycling,
            Day 28: Advanced cooking, Advanced baking, Industry, Oil Drilling
            Day 32: Advanced masonry, Electronics, Composites, Cutting edge cooking
            */

                ["MasonrySkill"]    = 3,
                ["CarpentrySkill"]  = 3,
                
                ["FarmingSkill"]    = 4,
                ["ButcherySkill"]   = 4,

                ["ShipwrightSkill"] = 5,
                ["TailoringSkill"]  = 5,

                ["BasicEngineeringSkill"]   = 7,
				["MillingSkill"]            = 7,
                ["FertilizersSkill"]        = 7,

                ["SmeltingSkill"] = 9,
                ["PaintingSkill"] = 9,

                ["BakingSkill"] = 11,
				["CookingSkill"] = 11,
                ["BlacksmithSkill"] = 11,               
				["PotterySkill"] = 11,
                ["GlassworkingSkill"] = 11,
                ["PaperMillingSkill"] = 11,

                ["MechanicsSkill"] = 14,
				["AdvancedSmeltingSkill"] = 14,
                ["RecyclingSkill"] = 14,

                ["AdvancedBakingSkill"] = 16,
                ["AdvancedCookingSkill"] = 16,
                ["IndustrySkill"] = 17,
                ["OilDrillingSkill"] = 17,

                ["AdvancedMasonrySkill"] = 18,
                ["ElectronicsSkill"] = 18,
                ["CompositesSkill"] = 18,
                ["CuttingEdgeCookingSkill"] = 20,
            };
    }
}