# Licences

## This mod

The C# source, Unity editor scripts, Python tooling and documentation in this repository
are the mod author's own work, MIT licensed. See [LICENSE](LICENSE).

## Eco game assets: permitted, confirmed by Strange Loop Games

This mod is built on Eco's own `TrailerTruckObject` prefab and reuses Strange Loop Games'
shipping container art. **That is permitted.**

Asked directly of SLG's support line in August 2026, and answered:

- SLG does **not** manually approve mods. There is no review process.
- **All mods are allowed by default**, including ones using their source code and assets.
- **The only condition is commercial use.** A free mod may use both freely.

**The free condition is load-bearing.** This permission does not carry over to a paid or
monetised mod. If that ever changes, the question has to be asked again.

The Farm Truck project's `LICENSES.md` holds the longer history, including the reasoning
used before SLG were asked.

## Rule for other third-party assets

**No asset enters this repository until its licence has been read and confirmed to permit
redistribution inside a freely-published mod.** Record it below when it is added, not later.

SLG's confirmation covers SLG's content. It says nothing about anyone else's.

Things to confirm for each asset:

- Redistribution permitted, not merely "free to download"
- Commercial use permitted, or the mod confirmed non-commercial forever
- Attribution requirements, and where the attribution must appear
- Whether modifications are permitted, and under what terms

Unity Asset Store licences in particular usually **forbid** redistributing the raw asset in
a form others can extract, which an asset bundle is. Treat store purchases as suspect until
proven otherwise.

## Assets in use

| Asset | Source | Licence | Attribution | Added |
|---|---|---|---|---|
| `TrailerTruckObject` prefab - cab, trailer, wheels, rig and materials (`Truck`, `TruckTrailer`, `Truck_Albedo`) | Eco 0.14 game assets, Strange Loop Games | SLG permission above: free mods may use their assets | Credited to SLG in `README.md` | 2026-08 |
| Shipping container mesh and `ShippingContainerRedMaterial` | Eco 0.14 game assets, Strange Loop Games | as above | as above | 2026-08 |

Both are SLG's own content, so they are covered by the confirmation above and by nothing
else. **They are the reason the free condition matters** - this mod cannot be sold or
monetised while it ships them.

## Not redistributed

- **Realistic Car Controller V2** - BoneCracker Games, a commercial asset. `tools/` holds
  only name- and GUID-matched **stubs** so the prefab binds to the client's real
  implementation at runtime. No RCC implementation is reproduced. SLG's permission does not
  extend to this; it is not theirs to give.
- **Eco ModKit** - downloaded per-developer from [play.eco/account](https://play.eco/account).
  Excluded via `.gitignore`.
- **Eco Dev Pack** - Strange Loop Games' proprietary source. Read locally for reference,
  never copied into this repo and never quoted at length.
