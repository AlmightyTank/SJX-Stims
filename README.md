# SJX-Stims

An addon pack of custom stims/consumables for [Consumables Galore](https://github.com/AlmightyTank/ConsumablesGalore).
This mod contains no logic of its own — on load it hands its `items/*.json`
definitions to Consumables Galore's item pipeline (clone, buffs, trader, quest
hookups, spawns), the same as Consumables Galore's own `items/` folder.

## Requirements

- SPT `~4.1.1`
- **Consumables Galore v3.0.0+** installed and enabled — this mod will not load
  without it.

## Items

| File | Item |
|------|------|
| `items/SJX-1-Sprinter.json` | SJX-1 Sprinter Injector |
| `items/SJX-2-Sharpshooter.json` | SJX-2 Sharpshooter Injector |
| `items/SJX-3-Berserker.json` | SJX-3 Berserker Injector |
| `items/SJX-4-Fortifier.json` | SJX-4 Fortifier Injector |
| `items/SJX-5-Stealth.json` | SJX-5 Stealth Injector |
| `items/SJX-Hydra-Mix.json` | SJX-Hydra Mix |
| `items/SJX-RationBar.json` | SJX-Ration Bar |
| `items/SJX-Recovery-Stew.json` | SJX-Recovery Stew |

Field reference and how to add more items: see Consumables Galore's
[`docs/ADDING_ITEMS.md`](../ConsumablesGalore-Ported/docs/ADDING_ITEMS.md).

## Building / deploying

```
dotnet build -c Release
```

Copy `bin/Release/SJX-Stims/` to `SPT/user/mods/`, alongside (not inside)
Consumables Galore's own mod folder.
