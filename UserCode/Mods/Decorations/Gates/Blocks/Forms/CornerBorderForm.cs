namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class GateCornerBorderFormGroup : FormGroup
    {
        public override string Name => "GateCornerBorder";
        public override LocString DisplayName => Localizer.DoStr("Corner Border");
        public override LocString DisplayDescription => Localizer.DoStr("Fences with vertical bars");
        public override int SortOrder => 5;
    }

    public partial class GateCornerBorderFenceFormType : FormType
    {
        public override string Name => "GateCornerBorderFence";
        public override LocString DisplayName => Localizer.DoStr("Corner Border Fence");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerBorderFormGroup);
        public override int SortOrder => 1;
        public override int MinTier => 1;
    }

    public partial class GateCornerBorderFenceBarFormType : FormType
    {
        public override string Name => "GateCornerBorderFenceBar";
        public override LocString DisplayName => Localizer.DoStr("Corner Border Fence Bar");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerBorderFormGroup);
        public override int SortOrder => 2;
        public override int MinTier => 1;
    }

    public partial class GateCornerBorderSpikeFormType : FormType
    {
        public override string Name => "GateCornerBorderSpike";
        public override LocString DisplayName => Localizer.DoStr("Corner Border Spike");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerBorderFormGroup);
        public override int SortOrder => 3;
        public override int MinTier => 1;
    }

    public partial class GateCornerBorderSpikeHalfFormType : FormType
    {
        public override string Name => "GateCornerBorderSpikeHalf";
        public override LocString DisplayName => Localizer.DoStr("Corner Border Spike Half");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerBorderFormGroup);
        public override int SortOrder => 4;
        public override int MinTier => 1;
    }

    public partial class GateCornerBorderSpikeLowFormType : FormType
    {
        public override string Name => "GateCornerBorderSpikeLow";
        public override LocString DisplayName => Localizer.DoStr("Corner Border Spike Low");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerBorderFormGroup);
        public override int SortOrder => 5;
        public override int MinTier => 1;
    }
}
