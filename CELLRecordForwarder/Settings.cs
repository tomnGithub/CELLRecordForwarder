using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace CELLRecordForwarder;

public record Settings
{
    [SettingName("Lighting Mod Plugin")]
    public List<ModKey> LightingModPlugin = new List<ModKey>();
}
