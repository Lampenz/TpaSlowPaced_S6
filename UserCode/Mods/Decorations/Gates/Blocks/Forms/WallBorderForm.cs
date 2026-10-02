namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class GateWallBorderFormGroup : FormGroup
    {
        public override string Name => "GateWallBorder";
        public override LocString DisplayName => Localizer.DoStr("Wall Border");
        public override LocString DisplayDescription => Localizer.DoStr("Fences with vertical bars");
        public override int SortOrder => 4;
    }

    public partial class GateWallBorderFenceFormType : FormType
    {
        public override string Name => "GateWallBorderFence";
        public override LocString DisplayName => Localizer.DoStr("Wall Border Fence");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallBorderFormGroup);
        public override int SortOrder => 1;
        public override int MinTier => 1;
    }

    public partial class GateWallBorderFenceBarFormType : FormType
    {
        public override string Name => "GateWallBorderFenceBar";
        public override LocString DisplayName => Localizer.DoStr("Wall Border Fence Bar");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallBorderFormGroup);
        public override int SortOrder => 2;
        public override int MinTier => 1;
    }

    public partial class GateWallBorderSpikeFormType : FormType
    {
        public override string Name => "GateWallBorderSpike";
        public override LocString DisplayName => Localizer.DoStr("Wall Border Spike");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallBorderFormGroup);
        public override int SortOrder => 3;
        public override int MinTier => 1;
    }

    public partial class GateWallBorderSpikeHalfFormType : FormType
    {
        public override string Name => "GateWallBorderSpikeHalf";
        public override LocString DisplayName => Localizer.DoStr("Wall Border Spike Half");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallBorderFormGroup);
        public override int SortOrder => 4;
        public override int MinTier => 1;
    }

    public partial class GateWallBorderSpikeLowFormType : FormType
    {
        public override string Name => "GateWallBorderSpikeLow";
        public override LocString DisplayName => Localizer.DoStr("Wall Border Spike Low");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateWallBorderFormGroup);
        public override int SortOrder => 5;
        public override int MinTier => 1;
    }
}
