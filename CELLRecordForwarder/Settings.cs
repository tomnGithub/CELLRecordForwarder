using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace CELLRecordForwarder;

public record Settings
{
    [SettingName("Lighting Mod Plugin")]
    public ModKey LightingModPlugin { get; set; } = ModKey.FromFileName("Lux.esp");
}
