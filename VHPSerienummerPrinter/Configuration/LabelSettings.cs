using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class LabelSettings
    {
        public UserPrinterSettings PrinterSettings { get; set; }

        public float LinkerMarge { get; set; }
        public float RechterMarge { get; set; }
        public float BovenMarge { get; set; }
        public float OnderMarge { get; set; }
        public float LinkerMargeDrager { get; set; }
        public float RechterMargeDrager { get; set; }
        public float MaxBreedteLogo { get; set; }
        public FontSettings ItemFont{ get; set; }
        public FontSettings TitelFont { get; set; }
                
        public LabelSettings()
        {
            PrinterSettings = new UserPrinterSettings();
        }
    }
}
