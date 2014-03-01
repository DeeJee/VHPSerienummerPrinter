using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class BatchLabelSettings
    {
        public UserPrinterSettings PrinterSettings { get; set; }
        public BatchLabelSettings()
        {
            PrinterSettings = new UserPrinterSettings();
        }
    }
}
