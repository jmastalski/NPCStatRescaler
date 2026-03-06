using System.Collections.Generic;
using Mutagen.Bethesda.Synthesis.Settings;

namespace NPCStatRescaler.Settings
{
    public enum Races
    {
        Argonian,
        Breton,
        DarkElf,
        HighElf,
        Imperial,
        Khajiit,
        Nord,
        Orc,
        Redguard,
        WoodElf
    }

    public class Config
    {
        [SynthesisSettingName("Using Survival Mode?")]
        [SynthesisTooltip("Adds +100 carry weight to every patched race and forces Playable Race Health Regen Debuff to 0.")]
        [SynthesisDescription("Use this when Skyrim Survival Mode is active to offset carry weight penalty and avoid regen food buff conflicts.")]
        public bool UsingSurvivalMode { get; set; } = false;

        [SynthesisSettingName("Races to Skip")]
        [SynthesisTooltip("Patterns of race EditorID that should be skipped by the patcher. Case-insensitive.")]
        [SynthesisDescription("Supports multiple entries and comma-separated values in one entry.")]
        public List<string> RacesToInclude { get; set; } = new();

        [SynthesisSettingName("Races Skip Exceptions")]
        [SynthesisTooltip("If a race matches this list, it will still be patched even when it matches the skip list.")]
        [SynthesisDescription("Use this for exceptions like DragonPriest when \"Dragon\" is in the skip list.")]
        public List<string> RacesToExclude { get; set; } = new();

        [SynthesisSettingName("NPCs to Skip")]
        [SynthesisTooltip("Patterns of NPC EditorID that should be skipped by the patcher. Case-insensitive.")]
        [SynthesisDescription("Supports multiple entries and comma-separated values in one entry.")]
        public List<string> NpcsToInclude { get; set; } = new();

        [SynthesisSettingName("NPCs Skip Exceptions")]
        [SynthesisTooltip("If an NPC matches this list, it will still be patched even when it matches the skip list.")]
        [SynthesisDescription("Use this for exceptions such as DragonPriest when \"Dragon\" is skipped.")]
        public List<string> NpcsToExclude { get; set; } = new();

        [SynthesisSettingName("Classes to Skip")]
        [SynthesisTooltip("Patterns of class EditorID that should be skipped by the patcher. Case-insensitive.")]
        [SynthesisDescription("Supports multiple entries and comma-separated values in one entry.")]
        public List<string> ClassesToInclude { get; set; } = new();

        [SynthesisSettingName("Classes Skip Exceptions")]
        [SynthesisTooltip("If a class matches this list, it will still be patched even when it matches the skip list.")]
        [SynthesisDescription("Use this for exceptions to broad skip patterns.")]
        public List<string> ClassesToExclude { get; set; } = new();

        [SynthesisSettingName("Playable Race Base Stats")]
        [SynthesisTooltip("Default starting Health/Stamina/Magicka/Carry Weight for playable races.")]
        [SynthesisDescription("You can edit every race value. These defaults are intentionally different per race.")]
        public Dictionary<Races, Stats> RacesStats { get; set; } = new()
        {
            {Races.Argonian, new Stats { Health = 90, Stamina = 110, Magicka = 105, CarryWeight = 90 }},
            {Races.Breton, new Stats { Health = 90, Stamina = 90, Magicka = 120, CarryWeight = 85 }},
            {Races.DarkElf, new Stats { Health = 80, Stamina = 110, Magicka = 110, CarryWeight = 95 }},
            {Races.HighElf, new Stats { Health = 75, Stamina = 75, Magicka = 150, CarryWeight = 85 }},
            {Races.Imperial, new Stats { Health = 100, Stamina = 100, Magicka = 100, CarryWeight = 100 }},
            {Races.Khajiit, new Stats { Health = 85, Stamina = 120, Magicka = 95, CarryWeight = 90 }},
            {Races.Nord, new Stats { Health = 125, Stamina = 115, Magicka = 60, CarryWeight = 120 }},
            {Races.Orc, new Stats { Health = 125, Stamina = 105, Magicka = 70, CarryWeight = 120 }},
            {Races.Redguard, new Stats { Health = 90, Stamina = 120, Magicka = 90, CarryWeight = 120 }},
            {Races.WoodElf, new Stats { Health = 85, Stamina = 110, Magicka = 105, CarryWeight = 85 }}
        };

        [SynthesisSettingName("Fallback Race Stats (Scale/Shift)")]
        [SynthesisTooltip("Used only for races that are not in the Playable Race Base Stats table.")]
        [SynthesisDescription("If a race does not map to Argonian/Breton/etc., these multipliers and shifts are used.")]
        public CommonStats CommonStats { get; set; } = new();

        [SynthesisSettingName("Child and Vampire Multipliers")]
        [SynthesisTooltip("Extra multipliers applied after base race stats are set.")]
        [SynthesisDescription("Child and non-DLC1 vampire races are scaled with these values.")]
        public Dictionary<ChildVampire, StatScales> StatScales { get; set; } = new()
        {
            {ChildVampire.Child, new StatScales
            {
                HealthScale = 0.75f,
                MagickaScale = 0.5f,
                StaminaScale = 1f,
                CarryWeightScale = 0.5f
            }},
            {ChildVampire.Vampire, new StatScales
            {
                HealthScale = 1f,
                MagickaScale = 1.5f,
                StaminaScale = 1.25f,
                CarryWeightScale = 1f
            }}
        };

        [SynthesisSettingName("Class Stat Multipliers")]
        [SynthesisTooltip("Multiplies Health/Stamina/Magicka class stat weights.")]
        public ClassScales Class { get; set; } = new();

        [SynthesisSettingName("NPC Offset Multipliers")]
        [SynthesisTooltip("Multiplies NPC Health/Stamina/Magicka offsets.")]
        public NpcOffsetMults NpcOffsetMults { get; set; } = new();

        [SynthesisSettingName("NPC Health Bonus Per Level")]
        [SynthesisTooltip("Sets fNPCHealthLevelBonus game setting.")]
        public int NpcHealthBonusPerLevel { get; set; } = 0;

        [SynthesisSettingName("Health Regen Settings")]
        [SynthesisTooltip("Controls race health regeneration scaling and vampire behavior.")]
        public HealthRegen HealthRegen { get; set; } = new();

        [SynthesisSettingName("Magicka Regen Settings")]
        [SynthesisTooltip("Controls race magicka regeneration scaling and optional Vokrii additive buff scaling.")]
        public MagickaRegen MagickaRegen { get; set; } = new();

        [SynthesisSettingName("Stamina Regen Settings")]
        [SynthesisTooltip("Controls race stamina regeneration scaling.")]
        public StaminaRegen StaminaRegen { get; set; } = new();

        [SynthesisSettingName("Player Combat Regen Penalties")]
        [SynthesisTooltip("Sets player combat regen multipliers for health, stamina, and magicka.")]
        public PlayerRegenPenalties PlayerCombatRegenPenalties { get; set; } = new();
    }
}
