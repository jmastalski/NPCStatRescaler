using Mutagen.Bethesda.Synthesis.Settings;

namespace NPCStatRescaler.Settings
{
    public enum ChildVampire
    {
        Child,
        Vampire
    }

    public class CommonStats
    {
        [SynthesisSettingName("Health Shift")]
        [SynthesisTooltip("Flat value added to fallback race health after scaling.")]
        public int HealthShift { get; set; } = 50;

        [SynthesisSettingName("Health Scale")]
        [SynthesisTooltip("Multiplier used for fallback race health.")]
        public float HealthScale { get; set; } = 0.5f;

        [SynthesisSettingName("Stamina Shift")]
        [SynthesisTooltip("Flat value added to fallback race stamina after scaling.")]
        public int StaminaShift { get; set; } = 0;

        [SynthesisSettingName("Stamina Scale")]
        [SynthesisTooltip("Multiplier used for fallback race stamina.")]
        public float StaminaScale { get; set; } = 1;

        [SynthesisSettingName("Magicka Shift")]
        [SynthesisTooltip("Flat value added to fallback race magicka after scaling.")]
        public int MagickaShift { get; set; } = 0;

        [SynthesisSettingName("Magicka Scale")]
        [SynthesisTooltip("Multiplier used for fallback race magicka.")]
        public float MagickaScale { get; set; } = 1;
    }

    public record Stats
    {
        [SynthesisSettingName("Health")]
        [SynthesisTooltip("Base starting health.")]
        public int Health { get; set; } = 100;

        [SynthesisSettingName("Stamina")]
        [SynthesisTooltip("Base starting stamina.")]
        public int Stamina { get; set; } = 100;

        [SynthesisSettingName("Magicka")]
        [SynthesisTooltip("Base starting magicka.")]
        public int Magicka { get; set; } = 100;

        [SynthesisSettingName("Carry Weight")]
        [SynthesisTooltip("Base carry weight before child/vampire multipliers and Survival Mode bonus.")]
        public int CarryWeight { get; set; } = 200;
    }

    public record StatScales
    {
        [SynthesisSettingName("Health Scale")]
        [SynthesisTooltip("Multiplier applied to health.")]
        public float HealthScale { get; set; }

        [SynthesisSettingName("Stamina Scale")]
        [SynthesisTooltip("Multiplier applied to stamina.")]
        public float StaminaScale { get; set; }

        [SynthesisSettingName("Magicka Scale")]
        [SynthesisTooltip("Multiplier applied to magicka.")]
        public float MagickaScale { get; set; }

        [SynthesisSettingName("Carry Weight Scale")]
        [SynthesisTooltip("Multiplier applied to carry weight.")]
        public float CarryWeightScale { get; set; }
    }

    public record ClassScales
    {
        [SynthesisSettingName("Health Weight Scale")]
        [SynthesisTooltip("Multiplier for class health stat weight.")]
        public float HealthScale { get; set; } = 1f;

        [SynthesisSettingName("Stamina Weight Scale")]
        [SynthesisTooltip("Multiplier for class stamina stat weight.")]
        public float StaminaScale { get; set; } = 1.5f;

        [SynthesisSettingName("Magicka Weight Scale")]
        [SynthesisTooltip("Multiplier for class magicka stat weight.")]
        public float MagickaScale { get; set; } = 1.5f;
    }

    public record NpcOffsetMults
    {
        [SynthesisSettingName("Health Offset Multiplier")]
        [SynthesisTooltip("Multiplier for NPC health offset.")]
        public float HealthOffsetMult { get; set; } = 0.2f;

        [SynthesisSettingName("Stamina Offset Multiplier")]
        [SynthesisTooltip("Multiplier for NPC stamina offset.")]
        public float StaminaOffsetMult { get; set; } = 1f;

        [SynthesisSettingName("Magicka Offset Multiplier")]
        [SynthesisTooltip("Multiplier for NPC magicka offset.")]
        public float MagickaOffsetMult { get; set; } = 1f;
    }

    public record HealthRegen
    {
        [SynthesisSettingName("Health Regen Scale")]
        [SynthesisTooltip("Multiplier for race health regen.")]
        public float Scale { get; set; } = 1f;

        [SynthesisSettingName("Health Regen Shift")]
        [SynthesisTooltip("Flat value added to race health regen after scaling.")]
        public int Shift { get; set; } = 0;

        [SynthesisSettingName("Playable Race Health Regen Debuff")]
        [SynthesisTooltip("Multiplier used by the added health regen ability. Forced to 0 when Using Survival Mode is enabled.")]
        public float PlayableRaceHealthRegenDebuff { get; set; } = 1f;

        [SynthesisSettingName("Apply Debuff to Vampire Races")]
        [SynthesisTooltip("When enabled, non-DLC1 vampire race variants also get the health regen ability debuff.")]
        public bool DebuffVampires { get; set; } = false;
    }

    public record StaminaRegen
    {
        [SynthesisSettingName("Stamina Regen Scale")]
        [SynthesisTooltip("Multiplier for race stamina regen.")]
        public float Scale { get; set; } = 1f;

        [SynthesisSettingName("Stamina Regen Shift")]
        [SynthesisTooltip("Flat value added to race stamina regen after scaling.")]
        public int Shift { get; set; } = 0;
    }

    public record MagickaRegen
    {
        [SynthesisSettingName("Magicka Regen Scale")]
        [SynthesisTooltip("Multiplier for race magicka regen.")]
        public float Scale { get; set; } = 0.3f;

        [SynthesisSettingName("Magicka Regen Shift")]
        [SynthesisTooltip("Flat value added to race magicka regen after scaling.")]
        public int Shift { get; set; } = 0;

        [SynthesisSettingName("Scale Vokrii Additive Magicka Buffs")]
        [SynthesisTooltip("If enabled, scales Vokrii's additive magicka regen effect magnitude with Magicka Regen Scale.")]
        public bool ScaleVokriiAdditiveBuffs { get; set; } = false;
    }

    public record PlayerRegenPenalties
    {
        [SynthesisSettingName("Health Combat Regen Multiplier")]
        [SynthesisTooltip("Sets fCombatHealthRegenRateMult.")]
        public float HealthCombatRegenPenalty { get; set; } = 1;

        [SynthesisSettingName("Stamina Combat Regen Multiplier")]
        [SynthesisTooltip("Sets fCombatStaminaRegenRateMult.")]
        public float StaminaCombatRegenPenalty { get; set; } = 1;

        [SynthesisSettingName("Magicka Combat Regen Multiplier")]
        [SynthesisTooltip("Sets fCombatMagickaRegenRateMult.")]
        public float MagickaCombatRegenPenalty { get; set; } = 1;
    }
}
