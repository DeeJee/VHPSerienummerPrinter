using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class UserPrinterSettings
    {
        public UserPrinterSettings()
        {
            Console.WriteLine("printersettings: " + this.GetHashCode());
        }

        private bool alwaysShowPrintDialog;
        public bool AlwaysShowPrintDialog 
        {
            get { return alwaysShowPrintDialog; }
            set { alwaysShowPrintDialog = value; } 
        }
        public string Printer { get; set; }
        public string Paper { get; set; }

        public override string ToString()
        {
            return string.Format("ShowDialog: {0}, Printer: {1}, Paper: {2}",alwaysShowPrintDialog, Printer, Paper);
        }
    }
}
