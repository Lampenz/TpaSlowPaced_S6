namespace Eco.Mods.TechTree
{
    using System.Reflection;
    using Eco.Gameplay.Skills;
	
	
	
	public partial class BasicUpgradeRecipe
    {
        partial void ModsPostInitialize()
        {
            var req = this.RequiredSkills[0];

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.SkillType))
                .SetValue(req, typeof(IntelligenceSkill));

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.Level))
                .SetValue(req, 4);

            this.RequiredSkills = new[] { req };
        }
    }
	
    public partial class AdvancedUpgradeRecipe
    {
        partial void ModsPostInitialize()
        {
            var req = this.RequiredSkills[0];

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.SkillType))
                .SetValue(req, typeof(IntelligenceSkill));

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.Level))
                .SetValue(req, 9);

            this.RequiredSkills = new[] { req };
        }
    }

	public partial class ModernUpgradeRecipe
    {
        partial void ModsPostInitialize()
        {
            var req = this.RequiredSkills[0];

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.SkillType))
                .SetValue(req, typeof(IntelligenceSkill));

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.Level))
                .SetValue(req, 14);

            this.RequiredSkills = new[] { req };
        }
    }
	
	
	
	
}