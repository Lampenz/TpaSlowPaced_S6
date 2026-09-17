namespace Eco.Mods.TechTree
{
    using System.Reflection;
    using Eco.Gameplay.Skills;
	
	
	
	public partial class LaserRecipe
    {
        partial void ModsPostInitialize()
        {
            var req = this.RequiredSkills[0];

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.SkillType))
                .SetValue(req, typeof(IntelligenceSkill));

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.Level))
                .SetValue(req, 19);

            this.RequiredSkills = new[] { req };
        }
    }
	
    public partial class ComputerLabRecipe
    {
        partial void ModsPostInitialize()
        {
            var req = this.RequiredSkills[0];

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.SkillType))
                .SetValue(req, typeof(IntelligenceSkill));

            typeof(BaseRequiresSkillAttribute)
                .GetProperty(nameof(BaseRequiresSkillAttribute.Level))
                .SetValue(req, 20);

            this.RequiredSkills = new[] { req };
        }
    }
	
	
	
	
}