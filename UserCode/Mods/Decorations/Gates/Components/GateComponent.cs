using Eco.Core.Controller;
using Eco.Gameplay.Auth;
using Eco.Gameplay.Components;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Utils;
using Eco.Shared.IoC;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.Utils;
using System.Numerics;

namespace EcoPulse.Gates
{
    /// <summary>
    /// Component that manages gate opening/closing interactions and state.
    /// </summary>
    [Serialized]
    [NoIcon]
    public class GateComponent : WorldObjectComponent, IHasEnvVars
    {
        private DoorComponent? doorComponent;

        public override void Initialize()
        {
            base.Initialize();

            this.doorComponent = this.Parent.GetComponent<DoorComponent>();

            // Subscribe to door state changes to update animation
            if (this.doorComponent != null)
            {
                this.doorComponent.Subscribe(nameof(DoorComponent.IsOpen), OnDoorStateChanged);
                // Sync animation with persisted state on load (subscribe doesn't fire for the initial value)
                OnDoorStateChanged();
            }
        }

        private void OnDoorStateChanged()
        {
            if (this.doorComponent != null)
            {
                this.Parent.SetAnimatedState("IsOpen", this.doorComponent.IsOpen);
            }
        }
    }
}
