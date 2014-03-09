using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Timers;
using System.Diagnostics;
using System.IO;
using VHPSerienummerPrinter;
using VHPSierienummerPrinter;
using VHPSerienummerPrinter.Entities;

namespace VHPSerienummerPrinter
{
    public class SerienummerLijstFactory
    {
        public string Message { get; set; }
        public SerienummerLijst serienummerLijst { get; set; }
        
        /// <summary>
        /// Creates a stuklijst. Once the stuklijst has been created it can be accessed from the Stuklijst property.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool Create(ExcelSheet sheet)
        {
            try
            {
                serienummerLijst = new SerienummerLijst();
                List<string> lines = new List<string>();

                serienummerLijst.Product = sheet.Product;
                serienummerLijst.LogoImage = sheet.Logo;
                serienummerLijst.PrintCeLogo = sheet.PrintCeLogo;
                serienummerLijst.Item1Label = sheet.Item1Label;
                serienummerLijst.Item2Label = sheet.Item2Label;
                serienummerLijst.Item3Label = sheet.Item3Label;
                serienummerLijst.Item4Label = sheet.Item4Label;
                serienummerLijst.Data = sheet.Data;

                //labels bepalen
                foreach (DataRow row in sheet.Rows)
                {
                    serienummerLijst.AddSerienummer(row.Jaar, row.Batch, row.VolgNummer, row.Item1, row.Item2, row.Item3, row.Item4);
                }

                FileFinder finder = new FileFinder();
                finder.Find(serienummerLijst.LogoImage);
            }
            catch (IOException ex)
            {
                Message = ex.Message;
                return false;
            }

            return true;
        }
    }
}
