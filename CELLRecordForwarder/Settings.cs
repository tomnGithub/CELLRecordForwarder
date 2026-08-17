using System.Collections.Generic;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace CELLRecordForwarder;

public record Settings
{
    [SettingName("Enable Lighting")]
    public bool EnableLighting = true;

    [SettingName("Lighting Mod Plugin")]
    public List<ModKey> LightingModPlugin = new List<ModKey>();

    [SettingName("Enable Water")]
    public bool EnableWater = true;

    [SettingName("Water Mod Plugin")]
    public List<ModKey> WaterModPlugin = new List<ModKey>();
}
