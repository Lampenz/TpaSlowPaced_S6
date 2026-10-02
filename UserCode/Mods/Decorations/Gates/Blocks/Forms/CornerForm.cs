namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class GateCornerFormGroup : FormGroup
    {
        public override string Name => "GateCorner";
        public override LocString DisplayName => Localizer.DoStr("Corner");
        public override LocString DisplayDescription => Localizer.DoStr("Fences with vertical bars");
        public override int SortOrder => 2;
    }

    public partial class GateCornerFenceFormType : FormType
    {
        public override string Name => "GateCornerFence";
        public override LocString DisplayName => Localizer.DoStr("Corner Fence");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerFormGroup);
        public override int SortOrder => 1;
        public override int MinTier => 1;
    }

    public partial class GateCornerFenceBarFormType : FormType
    {
        public override string Name => "GateCornerFenceBar";
        public override LocString DisplayName => Localizer.DoStr("Corner Fence Bar");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerFormGroup);
        public override int SortOrder => 2;
        public override int MinTier => 1;
    }

    public partial class GateCornerSpikeFormType : FormType
    {
        public override string Name => "GateCornerSpike";
        public override LocString DisplayName => Localizer.DoStr("Corner Spike");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerFormGroup);
        public override int SortOrder => 3;
        public override int MinTier => 1;
    }

    public partial class GateCornerSpikeHalfFormType : FormType
    {
        public override string Name => "GateCornerSpikeHalf";
        public override LocString DisplayName => Localizer.DoStr("Corner Spike Half");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerFormGroup);
        public override int SortOrder => 4;
        public override int MinTier => 1;
    }

    public partial class GateCornerSpikeLowFormType : FormType
    {
        public override string Name => "GateCornerSpikeLow";
        public override LocString DisplayName => Localizer.DoStr("Corner Spike Low");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with vertical bars");
        public override Type GroupType => typeof(GateCornerFormGroup);
        public override int SortOrder => 5;
        public override int MinTier => 1;
    }
}
