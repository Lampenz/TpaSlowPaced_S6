// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Bonuses;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;
    using Eco.Shared.Serialization;
    using System.Collections.Generic;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Systems.TextLinks;


    #region Engineer Profession

    // Mechanics Talents
    // Level 3 - Shaping up - Reduces costs of Shaper recipes by 10% and increases craft speed by 50%
    // Level 3 - Press on - Reduces costs of screw press recipes by 20% and increases craft speed by 50%
    // Level 6 - Partial Quality - Increased Durability of parts by 10% and increased integrity by 5% per level
    // Level 6 - Improved Assembly - Reduced cost of items produced by the assembly line 5% per level
    #region Mechanics draft
    public partial class ShapingUpTalent : Talent
    {
        public ShapingUpTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Shaping Up"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, CraftStationTypes = new HashSet<Type> { typeof(ShaperObject) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Shaping Up"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, CraftStationTypes = new HashSet<Type> { typeof(ShaperObject) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
        }
    }

    public partial class PressOnTalent : Talent
    {
        public PressOnTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Press On"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, CraftStationTypes = new HashSet<Type> { typeof(ScrewPressObject) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Press On"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, CraftStationTypes = new HashSet<Type> { typeof(ScrewPressObject) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
        }
    }

    public partial class PartialQualityTalent : Talent
    {
        public PartialQualityTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Partial Quality"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Durability, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(MechanicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.1f, Cap = 1.5f, LowerIsBetter = false } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Partial Quality"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Integrity, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(MechanicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.05f, Cap = 1.25f, LowerIsBetter = false } },
            });
        }
    }

    public partial class ImprovedAssemblyTalent : Talent
    {
        public ImprovedAssemblyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Improved Assembly"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, CraftStationTypes = new HashSet<Type> { typeof(AssemblyLineObject)  }, SkillTypes = new HashSet<Type> { typeof(MechanicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.95f, Cap = 0.75f, LowerIsBetter = true } },
            });
        }
    }
    #endregion

    // Industry Talents
    // Level 3 - Skilled Labor - Reduce resource cost of "vehicles" by 10% but increasing labor cost by 30% per level (max 4)
    // Level 3 - Precision Tooling - Reduce resource cost of parts recipes in Industry skill by 10% and increase durability + integrity by 25% (max 4)
    // Level 6 - Robotic Assistance - Robotic Assembly Line recipes Cost -10%, craft speed + 20%, power cost +100%
    // Level 6 - Electrical Efficiency - Power Requirement -50% (IndustrySkill) and Electronics Assembly recipes has -10% resource cost and +15% craft speed.
    #region Industry

    public partial class SkilledLaborTalent : Talent
    {
        public SkilledLaborTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Skilled Labor"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Vehicles" }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.9f, Cap = 0.6f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Skilled Labor"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.LaborCost, ItemTags = new HashSet<string> { "Vehicles" }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.3f, Cap = 2.2f, LowerIsBetter = true } },
            });
        }
    }

    public partial class ElectricalEfficiencyTalent : Talent
    {
        public ElectricalEfficiencyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Electrical Efficiency"),
                EffectDescription = Localizer.Do($"Reduce power usage for Industry recipes. {Text.Positive("-50%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Power, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.5f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Electrical Efficiency"),
                EffectDescription = Localizer.Do($"Reduce resource cost of Industry recipes inside the Electronics Assembly by {Text.Positive("-10%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, CraftStationTypes = new HashSet<Type> { typeof(ElectronicsAssemblyObject)} ,SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Electrical Efficiency"),
                EffectDescription = Localizer.Do($"Increases craft time of Industry recipes inside the Electronics Assembly by {Text.Positive("-15%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, CraftStationTypes = new HashSet<Type> { typeof(ElectronicsAssemblyObject) }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    public partial class PrecisionToolingTalent : Talent
    {
        public PrecisionToolingTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Precision Tooling"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 0.9f, Cap = 0.6f,LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Precision Tooling"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Durability, ItemTags = new HashSet<string> { "Parts"}, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.25f, Cap = 2f, LowerIsBetter = false } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Precision Tooling"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Integrity, ItemTags = new HashSet<string> { "Parts" }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectCappedMultiplicative { Value = 1.25f, Cap = 2f ,LowerIsBetter = false } },
            });
        }
    }

    public partial class RoboticAssistanceTalent : Talent
    {
        public RoboticAssistanceTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Robotic Assistance"),
                EffectDescription = Localizer.Do($"Reduce resource cost of Industry recipes inside the Robotic Assembly Line by {Text.Positive("-10%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, CraftStationTypes = new HashSet<Type> { typeof(RoboticAssemblyLineObject) }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Robotic Assistance"),
                EffectDescription = Localizer.Do($"Increase craft speed of Industry recipes inside the Robotic Assembly Line by {Text.Positive("20%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, CraftStationTypes = new HashSet<Type> { typeof(RoboticAssemblyLineObject) }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.8f, LowerIsBetter = true } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Robotic Assistance"),
                EffectDescription = Localizer.Do($"Increases power consumption of the Robotic Assembly Line by {Text.Negative("100%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Power, CraftStationTypes = new HashSet<Type> { typeof(RoboticAssemblyLineObject) }, SkillTypes = new HashSet<Type> { typeof(IndustrySkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 2f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Electronics Talents
    // Level 3 - Ceramic Safety - Unlocks recipe for Ceramic Fuse and increases craft speed by 25%.
    // Level 3 - Etching Techniques - Unlocks recipes for Basic & Adv Circuits
    // Level 6 - Quality of life - Reduce cost for Housing tag items 25%
    // Level 6 - Heavy Equipment - Reduce cost for Crafting tables by 15% 
    #region Electronics

    public partial class CeramicSafetyTalent : Talent
    {
        public CeramicSafetyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Ceramic Safety"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(CeramicFuseRecipe) } }, },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Ceramic Safety"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, SkillTypes = new HashSet<Type> {typeof(ElectronicsSkill) } }, },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    public partial class EtchingTechniquesTalent : Talent
    {
        public EtchingTechniquesTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Etching Techniques"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(EtchedBasicCircuitRecipe), typeof(EtchedAdvancedCircuitRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    public partial class QualityOfLifeTalent : Talent
    {
        public QualityOfLifeTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Quality of Life"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Housing" }, SkillTypes = new HashSet<Type> { typeof(ElectronicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    public partial class HeavyEquipmentTalent : Talent
    {
        public HeavyEquipmentTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Heavy Equipment"),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, ItemTags = new HashSet<string> { "Crafting Table" }, SkillTypes = new HashSet<Type> { typeof(ElectronicsSkill) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    // Basic Engineering Talents
    // Level 3 - Reduce resource cost of Waterwheels by 10% and increases craft speed by 25%.
    // Level 3 - Reduce resource cost of Windmills by 10% and increases craft speed by 25%.
    // Level 6 - Unlocks Asphalt roads. 
    // Level 6 - Reduce resource cost of gears and wheels by 15% and increased craft speed by 25%.
    #region Basic Engineering Draft

    /// <summary> Reduce resource cost of Waterwheels by 10% and increases craft speed by 25%. </summary>
    public partial class WateristhewayTalent : Talent
    {
        public WateristhewayTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Water is the way!"),
                EffectDescription = Localizer.Do($"Reduce resource cost of waterwheels by {Text.Positive("10%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(WaterwheelRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });

            this.Bonuses.Add(new Bonus
            {
                EffectDescription = Localizer.Do($"Increase craft speed of waterwheels by {Text.Positive("25%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(WaterwheelRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    /// <summary> Reduce cost for Windmill while increasing waterwheels costs. </summary>
    public partial class WindequalsenergyTalent : Talent
    {
        public WindequalsenergyTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Wind equals energy!"),
                EffectDescription = Localizer.Do($"Reduce resource cost of windmills by {Text.Positive("10%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(WindmillRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.9f, LowerIsBetter = true } },
            });

            this.Bonuses.Add(new Bonus
            {
                EffectDescription = Localizer.Do($"Increase craft speed of windmills by {Text.Positive("25%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(WindmillRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    /// <summary> Unlocks Asphalt roads. </summary>
    public partial class RoadworksTalent : Talent
    {
        public RoadworksTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Roadworks!"),
                EffectDescription = Localizer.Do($"Unlocks the Asphalt recipe."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.Unlock, Recipes = new HashSet<Type> { typeof(AsphaltConcreteRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectOverride { Value = 1f } },
            });
        }
    }

    /// <summary> Reduce resource cost of gears and wheels and increases craft speed. </summary>
    public partial class VehicularDesignTalent : Talent
    {
        public VehicularDesignTalent()
        {
            this.Bonuses.Add(new Bonus
            {
                Name = Localizer.DoStr("Vehicular Design"),
                EffectDescription = Localizer.Do($"Reduce resource cost of Wooden gears and Iron, Wood wheels by {Text.Positive("15%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.ResourceCost, Recipes = new HashSet<Type> { typeof(WoodenGearRecipe), typeof(IronWheelRecipe), typeof(WoodenWheelRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.85f, LowerIsBetter = true } },
            });

            this.Bonuses.Add(new Bonus
            {
                EffectDescription = Localizer.Do($"Increase craft speed of Wooden gears and Iron, Wood wheels by {Text.Positive("25%")}."),
                Causes = new List<BonusCause> { new CraftBonusCause { Action = BonusAction.CraftTime, Recipes = new HashSet<Type> { typeof(WoodenGearRecipe), typeof(IronWheelRecipe), typeof(WoodenWheelRecipe) } } },
                Effects = new List<BonusEffect> { new BonusEffectMultiplicative { Value = 0.75f, LowerIsBetter = true } },
            });
        }
    }

    #endregion

    #endregion
}
