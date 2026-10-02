using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Mods.TechTree;
using Eco.Shared.Serialization;

namespace EcoPulse.Gates
{
    /// <summary>
    /// Base class for gate-type objects that can be opened and closed.
    /// Uses native DoorComponent for door logic, with custom animation handling.
    /// </summary>
    [Serialized]
    [RequireComponent(typeof(GateComponent))]
    public partial class GateBaseObject : DoorObject
    {
        
    }
}
