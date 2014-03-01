using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class LabelSettings
    {
        public UserPrinterSettings PrinterSettings { get; set; }

        public int  LinkerMarge { get; set; }
        public int RechterMarge { get; set; }
        public int BovenMarge { get; set; }
        public int OnderMarge { get; set; }
        public float LinkerMargeDrager { get; set; }
        public float RechterMargeDrager { get; set; }
        public string FontFamily { get; set; }
        
        public LabelSettings()
        {
            PrinterSettings = new UserPrinterSettings();
        }
    }
}
