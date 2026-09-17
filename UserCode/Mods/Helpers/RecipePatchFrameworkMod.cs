namespace RecipePatchFramework
{
    using Eco.Core.Plugins.Interfaces;

    /// <summary>
    /// Eco discovers IModInit implementations automatically.
    ///
    /// Other mods register/discover their patches during the normal mod loading
    /// phase. The actual changes are applied after RecipeManager.Initialize().
    /// </summary>
    public sealed class RecipePatchFrameworkMod : IModInit
    {
        public static ModRegistration Register() => new()
        {
            ModName = "RecipePatchFramework",
            ModDisplayName = "Recipe Patch Framework",
            ModDescription =
                "Shared helper API for safely patching existing Eco recipes."
        };

        public static void Initialize()
        {
        }

        public static void PostInitialize()
        {
            RecipePatches.ApplyAll();
        }
    }
}
