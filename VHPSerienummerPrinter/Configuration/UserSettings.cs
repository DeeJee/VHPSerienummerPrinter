using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class UserSettings
    {
        public UserPrinterSettings PrinterSettings{ get; set; }
        public LabelSettings Label { get; set; }
        public BatchLabelSettings Titellabel { get; set; }
        public UserSettings()
        {
            PrinterSettings = new UserPrinterSettings();
            Label = new LabelSettings();
            Titellabel = new BatchLabelSettings();
        }
    }
}