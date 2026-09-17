// ⚠️ CE FICHIER DOIT EXISTER EN DOUBLE :
//   1) Inclus normalement dans GoodPrice.csproj, pour compiler sans erreur dans Visual Studio.
//   2) Copié TEL QUEL (non compilé) dans Mods\UserCode\GoodPrice\ sur le serveur, à côté
//      de GoodPrice.dll, pour qu'Eco le compile lui-même et fusionne réellement
//      "partial class StoreObject" avec le vrai StoreObject du jeu.
//
// Les deux compilations (celle de GoodPrice.dll et celle que fait Eco depuis UserCode) sont
// INDÉPENDANTES : même un type au nom identique déclaré dans les deux n'est PAS le même type
// pour le CLR (donc un registre statique partagé ne fonctionne PAS d'une compilation à l'autre).
// On appelle donc GoodPrice.dll par RÉFLEXION, en cherchant l'assembly déjà chargée en mémoire
// par Eco, plutôt que de compter sur un type/interface partagé entre les deux compilations.
namespace Eco.Mods.TechTree
{
    using Eco.Core.Controller;
    using Eco.Core.Utils;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Logging;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;
    using Eco.Shared.SharedTypes;
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;

    [Serialized]
    [CreateComponentTabLoc("GoodPrice", true)]
    [HasIcon("StoreComponent")]
    [Priority(1001)]
    public class GoodPriceSyncComponent : WorldObjectComponent
    {
        public override WorldObjectComponentClientAvailability Availability => WorldObjectComponentClientAvailability.Always;

        [SyncToView]
        public override string IconName => "StoreComponent";

        [SyncToView]
        [Autogen]
        [Sort(0)]
        [UITypeName("GeneralHeader")]
        public string Title => "GoodPrice";

        [Autogen]
        [RPC]
        [Sort(1)]
        [UITypeName("BigButton")]
        [Description("Applique dans cette boutique les prix (achat et vente) définis pour vous dans l'interface GoodPrice, pour la devise de cette boutique. Ne crée pas de nouvelle offre : seules les offres déjà présentes sont mises à jour.")]
        public void SyncFromGoodPrice(Player player)
        {
            GoodPriceReflectionBridge.Invoke("SyncFromGoodPrice", player, this.Parent);
        }

        [Autogen]
        [RPC]
        [Sort(2)]
        [UITypeName("BigButton")]
        [Description("Enregistre dans GoodPrice les prix (achat et vente) actuellement affichés dans cette boutique, pour vous, pour la devise de cette boutique.")]
        public void SyncToGoodPrice(Player player)
        {
            GoodPriceReflectionBridge.Invoke("SyncToGoodPrice", player, this.Parent);
        }
    }

    /// <summary>
    /// Pont vers GoodPrice.dll par réflexion. Cherche l'assembly "GoodPrice" déjà chargée en
    /// mémoire par Eco (chargée en tant que plugin bien avant qu'un joueur ne clique un bouton),
    /// et invoque la méthode statique demandée sur GoodPriceStoreSyncHandler.
    /// </summary>
    internal static class GoodPriceReflectionBridge
    {
        private static Type _handlerType;
        private static bool _resolved;

        public static void Invoke(string methodName, Player player, WorldObject worldObject)
        {
            try
            {
                var type = GetHandlerType();
                if (type == null)
                {
                    Log.WriteLine(Localizer.DoStr("[GoodPrice] Impossible de trouver GoodPrice.dll en mémoire (le plugin GoodPrice est-il bien chargé et activé ?)."));
                    return;
                }

                var method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static);
                if (method == null)
                {
                    Log.WriteLine(Localizer.DoStr($"[GoodPrice] Méthode '{methodName}' introuvable sur GoodPriceStoreSyncHandler."));
                    return;
                }

                method.Invoke(null, new object[] { player, worldObject });
            }
            catch (Exception ex)
            {
                Log.WriteLine(Localizer.DoStr($"[GoodPrice] Erreur lors de l'appel à {methodName} : {ex.Message}"));
            }
        }

        private static Type GetHandlerType()
        {
            if (_resolved) return _handlerType;
            _resolved = true;

            var matches = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.GetName().Name == "GoodPrice")
                .ToList();

            // 🔎 Diagnostic : si plusieurs copies de l'assembly GoodPrice sont chargées en
            // mémoire simultanément (rechargement à chaud d'Eco), chacune a SON PROPRE
            // singleton Config.Instance, avec ses propres données en mémoire — ce qui peut
            // expliquer un comptage "correct" côté log mais des données qui n'apparaissent
            // jamais dans l'interface web (qui, elle, utilise une autre copie).
            Log.WriteLine(Localizer.DoStr($"[GoodPrice] Assemblies 'GoodPrice' trouvées en mémoire : {matches.Count}"));
            foreach (var a in matches)
            {
                Log.WriteLine(Localizer.DoStr($"[GoodPrice]   -> {a.Location} (chargée: {a.FullName})"));
            }

            var asm = matches.LastOrDefault();
            _handlerType = asm?.GetType("Eco.Plugins.GoodPrice.GoodPriceStoreSyncHandler");

            if (_handlerType != null)
                Log.WriteLine(Localizer.DoStr($"[GoodPrice] GoodPriceStoreSyncHandler résolu depuis : {asm.Location}"));

            return _handlerType;
        }
    }

    /// <summary>
    /// 🔥 Ajoute le composant à StoreObject
    /// </summary>
    [RequireComponent(typeof(GoodPriceSyncComponent))]
    public partial class StoreObject { }

    /// <summary>
    /// 🔥 Ajoute le composant à WoodShopCartObject
    /// </summary>
    [RequireComponent(typeof(GoodPriceSyncComponent))]
    public partial class WoodShopCartObject { }
}
