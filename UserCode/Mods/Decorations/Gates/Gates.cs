using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Shared.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPulse.Gates
{
    internal class Gates : IModInit
    {
        public static readonly string Version = "1.4.0";
        public Gates()
        {
            Log.WriteLine(Localizer.Do($"Gates {Version}"));
        }
        public static ModRegistration Register() => new()
        {
            ModName = "Gates",
            ModDescription = "Adds craftable double doors (Lumber & Hewn wood variants), metal grills (Iron, Copper, Gold), straight and gothic garden doors, drawbridges, and decorative metal fences with different forms.",
            ModDisplayName = "Gates",
        };
    }
}
