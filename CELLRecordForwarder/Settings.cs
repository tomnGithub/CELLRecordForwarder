using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;
namespace CELLRecordForwarder;

public record Settings
{
    [SettingName("Lighting Mod Plugin")]
    public List<ModKey> LightingModPlugin = new List<ModKey>();
}
