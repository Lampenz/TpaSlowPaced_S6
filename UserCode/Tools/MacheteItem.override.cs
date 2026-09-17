// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

#nullable enable
namespace Eco.Mods.TechTree
{
	using System;
    using Eco.Core.Items;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using System.ComponentModel;
    using Eco.Gameplay.Interactions.Interactors;
    using Eco.Shared.SharedTypes;
    using Eco.Gameplay.Players;
    using Eco.Shared.Items;
    using Eco.Gameplay.DynamicValues;

    [Tag("Harvester")]
    [Category("Hidden")]
    [Mower]
    public abstract partial class MacheteItem : WeaponItem, IInteractor
    {
        static readonly LocString ClearString    = Localizer.DoStr("Clear");
        private static SkillModifiedValue damage = CreateDamageValue(1, typeof(HuntingSkill), typeof(MacheteItem));
		
		private static IDynamicValue caloriesBurn           = new MultiDynamicValue(MultiDynamicOps.Multiply, new TalentModifiedValue(typeof(MacheteItem), typeof(ToolEfficiencyTalent)), CreateCalorieValue(20, typeof(HuntingSkill), typeof(MacheteItem)));
		public override Type ExperienceSkill            => typeof(HuntingSkill);
		
		private static readonly IDynamicValue perkDamage =
			new TalentModifiedValue(
				typeof(MacheteItem),
				typeof(MacheteStrengthTalent),
				0);

		private static readonly IDynamicValue unmodifiedAnimalDamage =
			new MultiDynamicValue(
				MultiDynamicOps.Sum,
				new ConstantValue(0.3f),
				perkDamage);

		private static readonly IDynamicValue skillMultiplier =
			CreateDamageValue(
				1f,
				typeof(HuntingSkill),
				typeof(MacheteItem));

		private static readonly IDynamicValue totalAnimalDamage =
			new MultiDynamicValue(
				MultiDynamicOps.Multiply,
				unmodifiedAnimalDamage,
				skillMultiplier);
		

        public override IDynamicValue Damage => damage;
		public override IDynamicValue AnimalDamage => totalAnimalDamage;

        public override bool CustomHighlight => true;

        [Interaction(InteractionTrigger.LeftClick, tags: BlockTags.Clearable, AnimationDriven = true)]
        public bool ClearVegetation(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target)
        {
            if (!this.TryCreateMultiblockContext(out var context, target, player, tagsTargetable: BlockTags.Clearable)) return false;

            return AtomicActions.DestroyPlantNow(context, notify: false).Success;
        }
    }
}
