namespace Eco.Mods.TechTree
{
    public static class SkillBookIntelligenceRequirements
    {
        public static readonly System.Collections.Generic.Dictionary<string, int> BySkillName =
            new System.Collections.Generic.Dictionary<string, int>(System.StringComparer.OrdinalIgnoreCase)
            {
                ["MasonrySkill"] = 2,
				
				["FarmingSkill"] = 3,

                ["ShipwrightSkill"] = 4,
                
                ["ButcherySkill"] = 4,
				
				["MillingSkill"] = 5,
                ["BakingSkill"] = 5,
				["CookingSkill"] = 5,
                ["TailoringSkill"] = 5,
				
                ["CarpentrySkill"] = 5,
                ["BasicEngineeringSkill"] = 5,

                ["SmeltingSkill"] = 6,
                
                ["BlacksmithSkill"] = 6,
                
                ["PaintingSkill"] = 7,
				
				["PotterySkill"] = 8,
                ["GlassworkingSkill"] = 9,

                ["MechanicsSkill"] = 10,
                ["PaperMillingSkill"] = 10,

                ["FertilizersSkill"] = 11,
				
                ["AdvancedBakingSkill"] = 12,
                ["AdvancedCookingSkill"] = 12,
				
				["AdvancedSmeltingSkill"] = 13,
                ["CompositesSkill"] = 13,

                ["AdvancedMasonrySkill"] = 14,

                ["OilDrillingSkill"] = 15,

                ["ElectronicsSkill"] = 16,

                ["IndustrySkill"] = 17,

                ["CuttingEdgeCookingSkill"] = 25,
            };
    }
}