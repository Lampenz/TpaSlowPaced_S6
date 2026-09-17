
namespace TPA_Mods
{
    using Eco.Mods.TechTree;
    using RecipePatchFramework;
	using Eco.Shared.Localization;

    public sealed class NettingSteamTruck : SimpleRecipePatch<SteamTruckRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<OutpostNettingItem>(2);
        }
    }

    public sealed class NettingSteamTractor : SimpleRecipePatch<SteamTractorRecipe>
    {
        protected override void Modify()
        {
            AddIngredient<OutpostNettingItem>(2);
        }
    }
}