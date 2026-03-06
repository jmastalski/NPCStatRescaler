NPC STAT RESCALER (SYNTHESIS FORK)

:: SUMMARY ::
Synthesis patcher fork of tjhm4's NPC Stat Rescaler (zEdit), updated to match zEdit v2.1.1 behavior.
Original Synthesis port by theSkyseS.
This version adds better filtering, Survival Mode handling, and diversified playable race defaults.

:: REQUIREMENTS ::
- Skyrim Special Edition / Anniversary Edition
- Synthesis: https://github.com/Mutagen-Modding/Synthesis

:: FEATURES ::
- Patches race base stats and regen rates
- Patches class stat weights
- Patches NPC stat offsets
- Patches NPC bonus health per level (GMST)
- Patches player combat regen penalties (GMST)
- Optional Vokrii additive magicka regen scaling toggle
- EditorID-based Skip + Exception filters for Races / NPCs / Classes
- Survival Mode option (+100 carry weight to patched races, forces playable regen debuff to 0)

:: HOW TO USE ::
1. Run Synthesis.
2. Add/import this patcher (.synth recommended).
3. Configure settings.
4. Run patcher.
5. Enable generated patch: NPC Stat Rescaler.esp

:: FILTER EXAMPLE ::
Skip: Dragon,Paarthurnax,Alduin
Skip Exceptions: DragonPriest
Result: dragon entries are skipped, DragonPriest is still patched.

:: SHEOGORATH NOTE ::
Original zEdit hardcoded these two NPCs to skip:
- dunBluePalacePelagiusSuspicious
- dunBluePalacePelagiusNightmare
This fork does not hardcode them.
Add them to "NPCs to Skip" if you want legacy behavior.

:: CREDITS ::
- Original mod/formulas: tjhm4
  https://www.nexusmods.com/skyrimspecialedition/mods/24254
- Original Synthesis port: theSkyseS
  https://github.com/theSkyseS/NPCStatRescaler
- Diversified stat inspiration:
  BlessingS91, MrMoonSugar, revenant0713
