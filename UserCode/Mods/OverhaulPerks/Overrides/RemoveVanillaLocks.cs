namespace Eco.Mods.TechTree
{
	using System.Collections.Generic;
    using Eco.Gameplay.Blocks;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.SearchAndSelect;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.Time;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Players;
    using System.ComponentModel;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
	
	public partial class CampfireRoastRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = false;
        }
    }
	public partial class RenderFatRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = false;
        }
    }
	public partial class JungleCampfireStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	public partial class MeatyStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	public partial class RootCampfireStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	public partial class FieldCampfireStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	public partial class WildStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	public partial class FishStewRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	
	public partial class SulfurcreteRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
			this.RequiredSkills = RequiresSkillAttribute.Cache.Get(typeof(ShaleCementRecipe));
        }
    }
	
	public partial class FiberReinforcedConcreteRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
			this.RequiredSkills = RequiresSkillAttribute.Cache.Get(typeof(ShaleCementRecipe));
        }
    }
	
	public partial class ShaleBrickRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
			this.RequiredSkills = RequiresSkillAttribute.Cache.Get(typeof(StandingSteelBrickSignRecipe));
        }
    }
	
	public partial class SteamTractorRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	
	public partial class SteamTruckRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = true;
        }
    }
	
	
	
	
	
	
	
    public partial class AsphaltConcreteRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = false;
        }
    }
	
	public partial class CharcoalSteelRecipe
    {
        partial void ModsPostInitialize()
        {
            this.RequiresTalentUnlock = false;
        }
    }
}