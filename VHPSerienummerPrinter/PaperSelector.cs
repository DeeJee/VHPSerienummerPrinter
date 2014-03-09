using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using VHPSerienummerPrinter.Configuration;

namespace VHPSerienummerPrinter
{
    public class PaperSelector
    {
        public PaperSize GetDefaultlabel()
        {
            //Lijst met beschikbare printers vullen
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer == Settings.Label.PrinterSettings.Printer)
                {
                    PrinterSettings selectedPrinter = new PrinterSettings();
                    selectedPrinter.PrinterName = printer;

                    //vult lijst met papierformaten die bij de geselecteerde printer horen
                    foreach (PaperSize paperSize in selectedPrinter.PaperSizes)
                    {
                        if (paperSize.PaperName == Settings.Label.PrinterSettings.Paper)
                        {
                            return paperSize;
                        }
                    }
                    
                }
            }
            return null;
        }
    }
}