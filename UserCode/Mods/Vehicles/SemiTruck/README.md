# Semi Truck

A vehicle mod for [Eco](https://play.eco) 0.14, adding a semi truck that carries shipping
containers you can place, fill, and load onto the truck with their cargo still inside.

Built on Eco's own `TrailerTruckObject` prefab and shipping container art.

## What it adds

Three items, all crafted at the Robotic Assembly Line:

| Item | Skill | What it is |
|---|---|---|
| **Semi Truck** | Industry 4 | The vehicle. Two seats, one module slot, liquid fuel. |
| **Semi Container** | Industry 2 | A placeable storage box. 40 slots, 10 t. |
| **Semi Container Loader** | Industry 3 | The module that fits the truck's slot and lifts containers. |

The container is a normal world object: place it, fill it, take goods out of it. It is not a
vehicle module — you fit the *loader* to the truck, and the loader picks containers up.

## How it works in game

1. Craft a truck and a loader. Fit the loader in the truck's module slot.
2. Craft containers — you are meant to own several. Place them where you load and unload.
3. Fill a container by hand, like any storage.
4. Back the truck up to a container and press the vehicle tool key (shown in the driver's
   control hints as **Load / Unload Container**). The container is lifted onto the trailer
   with its cargo. The same key sets it back down.
5. While a container is aboard, its cargo sits in a 40-slot hold on the truck, so you can
   still work the load on the road.

A container that has anything in it **cannot** be picked up by hand — empty it, or move it
with a truck. Right-clicking the truck offers the same load/unload action for when you are
on foot.

## Known limits

- **No jackknife.** The trailer is rigid with the cab. Eco's client vehicle runtime is built
  around a single Rigidbody, and a jointed trailer shakes itself apart the moment you drive.
  Articulation would need a client-side visualiser over one physics body; see
  `docs/PHYSICS-INVESTIGATION.md`.
- **No lift animation.** The container appears on the trailer rather than being craned onto
  it. Vanilla's arm rig is driven by client code, which a mod cannot ship.
- A **placed** container does not show its cargo on the outside yet. One on the trailer does.
- **The trailer's rear corner lights sit slightly off the model.** They switch on and off
  correctly with the rest of the truck's lights, just not lined up inside the lamp housings
  themselves. Cosmetic only.

## Install

Copy `SemiTruck.cs` and `SemiTruck.unity3d` into your server's

```
Eco_Data\Server\Mods\UserCode\SemiTruck\
```

Both files must be present, and clients need the bundle too. Restart the server and the
client fully — Eco does not hot-reload bundles.

## Building from source

```powershell
powershell -ExecutionPolicy Bypass -File .\build.ps1 -SkipImport
powershell -ExecutionPolicy Bypass -File .\deploy.ps1
```

Needs Unity 6000.3.6f1, the Eco ModKit, and a local Eco install for the reference
assemblies. A full build runs past ten minutes. Unity batch mode only prints
`Aborting batchmode due to failure:` on stdout — the real error is in `build\logs\3-build.log`.

`docs/HANDOFF.md` is the current state of the project and the place to start. The approach
and traps this build stands on are documented in the FarmTruck project's `docs/RESEARCH.md`.

## Licence

MIT for the mod's own code and tooling. Eco's assets are reused with Strange Loop Games'
confirmed permission, which covers **free** mods only. See [LICENSES.md](LICENSES.md).
