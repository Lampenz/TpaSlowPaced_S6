namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
	using Eco.Gameplay.Housing.PropertyValues;
    
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Shipping Research Paper Basic")] // Defines the localized name of the item.
    [Weight(10)] // Defines how heavy ShippingResearchPaperBasic is.
    [Ecopedia("Items", "Research Papers", createAsSubPage: true)]
    [Tag("Basic Research")]
    [Tag("Research")]
    [LocDescription("A document containing important research information. Used to discover new skills at the research table.")] //The tooltip description for the item.
    public partial class ShippingResearchPaperBasicItem : Item    {
    }

}
