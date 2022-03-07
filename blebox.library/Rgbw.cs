using System;
using Newtonsoft.Json;

namespace blebox.library
{
    public class Rgbw
    {
        public int ColorMode { get; set; } = 0;
        public EffectNames EffectID { get; set; } = EffectNames.NONE;
        public string DesiredColor { get; set; } = "0000000000";
        public string CurrentColor { get; set; } = "0000000000";
        public string LastOnColor { get; set; } = "0000000000";
        public DurationsMs DurationsMs { get; set; } = new DurationsMs();
    }
}
