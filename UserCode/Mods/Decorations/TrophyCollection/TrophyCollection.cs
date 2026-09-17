 using Eco.Core.Plugins.Interfaces;
    
    public class TrophyCollectionMod : IModInit
    {
        public static ModRegistration Register() => new() 
        { 
            ModName = "TrophyCollection",
            ModDescription = "Add customizable trophie on your Eco server to reward players for achievements and competitions.",
            ModDisplayName = "Trophy Collection",
        };
    }