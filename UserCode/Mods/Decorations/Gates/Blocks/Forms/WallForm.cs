namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class GateWallFormGroup : FormGroup
    {
        public override string Name => "GateWall";
        public override LocString DisplayName => Localizer.DoStr("Wall");
        public override LocString DisplayDescription => Localizer.DoStr("Fences with vertical bars");
        public override int SortOrder => 1;
    }

    public partial class GateWallFenceFormType : FormType
    {
        public override string Name => "GateWallFence";
        public override LocString DisplayName => Localizer.DoStr("Fence");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 1;
        public override int MinTier => 1;
    }

    public partial class GateWallFenceBarFormType : FormType
    {
        public override string Name => "GateWallFenceBar";
        public override LocString DisplayName => Localizer.DoStr("Fence Bar");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 2;
        public override int MinTier => 1;
    }

    public partial class GateWallSpikeFormType : FormType
    {
        public override string Name => "GateWallSpike";
        public override LocString DisplayName => Localizer.DoStr("Spike");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 3;
        public override int MinTier => 1;
    }

    public partial class GateWallSpikeHalfFormType : FormType
    {
        public override string Name => "GateWallSpikeHalf";
        public override LocString DisplayName => Localizer.DoStr("Spike Half");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 4;
        public override int MinTier => 1;
    }

    public partial class GateWallSpikeLowFormType : FormType
    {
        public override string Name => "GateWallSpikeLow";
        public override LocString DisplayName => Localizer.DoStr("Spike Low");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 5;
        public override int MinTier => 1;
    }

    public partial class GateWallSpikeAscending1FormType : FormType
    {
        public override string Name => "GateWallSpikeAscending1";
        public override LocString DisplayName => Localizer.DoStr("Spike Ascending1");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 6;
        public override int MinTier => 1;
    }

    public partial class GateWallSpikeAscending2FormType : FormType
    {
        public override string Name => "GateWallSpikeAscending2";
        public override LocString DisplayName => Localizer.DoStr("Spike Ascending2");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallFormGroup);
        public override int SortOrder => 7;
        public override int MinTier => 1;
    }
}
