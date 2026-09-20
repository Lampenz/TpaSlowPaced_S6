namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;

    /// <summary>
    /// Server side talent definition for "ToolEfficiency".
    /// Kept for the other ToolEfficiency talents.
    /// </summary>
    public partial class ToolEfficiencyTalent : Talent
    {
        public override bool Base => true;
    }

    /// <summary>
    /// Level 0 Hatchet Job.
    /// This is now a ToolStrengthTalent so it can be read by
    /// TalentModifiedValue from the axe damage calculation.
    /// </summary>
    [Serialized]
    [LocDisplayName("Hatchet Job")]
    [LocDescription("Adds 0.5 damage to all related logging tools, does not require logging skill")]
    public partial class LoggingToolEfficiencyTalentGroup : TalentGroup
    {
        public LoggingToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(LoggingToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(LoggingSkill);
            this.Level = 0;
        }
    }

    [Serialized]
    public partial class LoggingToolEfficiencyTalent : ToolStrengthTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(LoggingToolEfficiencyTalentGroup); } }

        public LoggingToolEfficiencyTalent()
        {
            this.Value = 0.5f;
        }
    }

    /// <summary>
    /// Level 0 Mine Over Matter.
    /// This is now a ToolStrengthTalent so it can be read by
    /// TalentModifiedValue from mining tool damage calculations.
    /// </summary>
    [Serialized]
    [LocDisplayName("Mine Over Matter")]
    [LocDescription("Adds 20% damage to all mining related tools, does not require mining skill")]
    public partial class MiningToolEfficiencyTalentGroup : TalentGroup
    {
        public MiningToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MiningToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(MiningSkill);
            this.Level = 0;
        }
    }

    [Serialized]
    public partial class MiningToolEfficiencyTalent : ToolStrengthTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(MiningToolEfficiencyTalentGroup); } }

        public MiningToolEfficiencyTalent()
        {
            this.Value = 0.2f;
        }
    }

    /// <summary>
    /// Existing Gathering Tool Efficiency talent.
    /// Unchanged.
    /// </summary>
    [Serialized]
    [LocDisplayName("Cut to the Chase")]
    [LocDescription("Lowers the calorie cost of using scythes and sickles by 50 percent.")]
    public partial class GatheringToolEfficiencyTalentGroup : TalentGroup
    {
        public GatheringToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(GatheringToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 3;
        }
    }

    [Serialized]
    public partial class GatheringToolEfficiencyTalent : ToolEfficiencyTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(GatheringToolEfficiencyTalentGroup); } }

        public GatheringToolEfficiencyTalent()
        {
            this.Value = 0.5f;
        }
    }

    /// <summary>
    /// Existing Shovel Tool Efficiency talent.
    /// Unchanged.
    /// </summary>
    [Serialized]
    [LocDisplayName("Groundbreaking")]
    [LocDescription("Lowers the calorie cost of using shovels by 50 percent. Does not require the gathering skill")]
    public partial class ShovelToolEfficiencyTalentGroup : TalentGroup
    {
        public ShovelToolEfficiencyTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(ShovelToolEfficiencyTalent),
            };
            this.OwningSkill = typeof(GatheringSkill);
            this.Level = 0;
        }
    }

    [Serialized]
    public partial class ShovelToolEfficiencyTalent : ToolEfficiencyTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(ShovelToolEfficiencyTalentGroup); } }

        public ShovelToolEfficiencyTalent()
        {
            this.Value = 0.5f;
        }
    }
}
