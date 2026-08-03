# Changelog

## v1.0.0

**Now a Consumables Galore addon mod** - SJX-Stims is no longer a set of loose `.json`
files dropped into Consumables Galore's own `items/` folder. It's now its own compiled
SPT mod that registers through Consumables Galore's `LoadAdditionalItems` extension
point.

**Requires Consumables Galore v3.0.0+ and SPT ~4.1.1** - install Consumables Galore
first; SJX-Stims will not load without it.

### Changed

- Packaged as a standalone mod (`AlmightyTank-SJXStims.dll`) instead of raw item files
- Item definitions moved to this mod's own `items/` folder (same file contents, no
  balance/stat changes)

### Items

- SJX-1 Sprinter Injector
- SJX-2 Sharpshooter Injector
- SJX-3 Berserker Injector
- SJX-4 Fortifier Injector
- SJX-5 Stealth Injector
- SJX-Hydra Mix
- SJX-Ration Bar
- SJX-Recovery Stew
