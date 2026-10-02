namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class GateDiagonalFormGroup : FormGroup
    {
        public override string Name => "GateDiagonal";
        public override LocString DisplayName => Localizer.DoStr("Diagonal");
        public override LocString DisplayDescription => Localizer.DoStr("Fences with vertical bars");
        public override int SortOrder => 3;
    }

    public partial class GateDiagonalFenceFormType : FormType
    {
        public override string Name => "GateDiagonalFence";
        public override LocString DisplayName => Localizer.DoStr("Diagonal Fence");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with diagonal bars from corner to corner");
        public override Type GroupType => typeof(GateDiagonalFormGroup);
        public override int SortOrder => 1;
        public override int MinTier => 1;
    }

    public partial class GateDiagonalFenceBarFormType : FormType
    {
        public override string Name => "GateDiagonalFenceBar";
        public override LocString DisplayName => Localizer.DoStr("Diagonal Fence Bar");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with diagonal bars from corner to corner");
        public override Type GroupType => typeof(GateDiagonalFormGroup);
        public override int SortOrder => 2;
        public override int MinTier => 1;
    }

    public partial class GateDiagonalSpikeFormType : FormType
    {
        public override string Name => "GateDiagonalSpike";
        public override LocString DisplayName => Localizer.DoStr("Diagonal Spike");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with diagonal bars from corner to corner");
        public override Type GroupType => typeof(GateDiagonalFormGroup);
        public override int SortOrder => 3;
        public override int MinTier => 1;
    }

    public partial class GateDiagonalSpikeHalfFormType : FormType
    {
        public override string Name => "GateDiagonalSpikeHalf";
        public override LocString DisplayName => Localizer.DoStr("Diagonal Spike Half");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with diagonal bars from corner to corner");
        public override Type GroupType => typeof(GateDiagonalFormGroup);
        public override int SortOrder => 4;
        public override int MinTier => 1;
    }

    public partial class GateDiagonalSpikeLowFormType : FormType
    {
        public override string Name => "GateDiagonalSpikeLow";
        public override LocString DisplayName => Localizer.DoStr("Diagonal Spike Low");
        public override LocString DisplayDescription => Localizer.DoStr("Fence with diagonal bars from corner to corner");
        public override Type GroupType => typeof(GateDiagonalFormGroup);
        public override int SortOrder => 5;
        public override int MinTier => 1;
    }
}
