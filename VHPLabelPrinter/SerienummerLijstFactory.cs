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

namespace VHPSerienummerPrinter
{
    public class SerienummerLijstFactory
    {
        private const string booleanYes = "\"Y\"";


        private const int kolomJaar = 0;
        private const int kolomBatch = 1;
        private const int kolomVolgnummer = 2;
        private const int kolomSerieNummer = 3;
        private const int kolomProduct = 5;
        private const int kolomFirmware = 6;
        private const int kolomType = 8;
        private const int dataStartReadRow = 17;
        private const int logoRow = 6;
        private const int ceMarkRow = 7;


        private const int cemarkTitleColumn = 2;
        private const int cemarkValueColumn = 3;
        private const int logoTitleColumn = 2;
        private const int logovalueColumn = 3;

        public string Message { get; set; }
        public SerienummerLijst SerienummerLijst { get; set; }
        private char? separator;

        /// <summary>
        /// Creates a stuklijst. Once the stuklijst has been created it can be accessed from the Stuklijst property.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool Create(string file)
        {
            SerienummerLijst = new SerienummerLijst();
            List<string> lines = new List<string>();

            try
            {
                //csv bestand inlezen
                using (StreamReader rdr = new StreamReader(file))
                {
                    while (!rdr.EndOfStream)
                    {
                        lines.Add(rdr.ReadLine().Replace("\"", string.Empty));
                    }
                }

                //lineseparator bepalen
                separator = DetermineSeparator(lines[0]);

                //product bepalen
                string[] cells = lines[1].Split(separator.Value);
                SerienummerLijst.Product = cells[4].Replace("\"", string.Empty);

                //logo bepalen
                string cell = lines[logoRow].Split(separator.Value)[logoTitleColumn];
                if (cell.ToLower() == "logo")
                {
                    SerienummerLijst.LogoImage = lines[logoRow].Split(separator.Value)[logovalueColumn];
                }

                //bepalen of het CE logo afgedrukt moet worden
                cell = lines[ceMarkRow].Split(separator.Value)[cemarkTitleColumn];
                if (cell.ToLower() == "ce-mark")
                {
                    SerienummerLijst.PrintCeLogo = lines[ceMarkRow].Split(separator.Value)[cemarkValueColumn].ToLower() == "yes";
                }
                else
                {
                    SerienummerLijst.PrintCeLogo = true;
                }
                //labels bepalen
                for (int lineNumber = dataStartReadRow; lineNumber < lines.Count; lineNumber++)
                {
                    //de artikelen lezen
                    if (lineNumber < lines.Count)
                    {
                        cells = lines[lineNumber].Split(separator.Value);
                        string jaar = cells[kolomJaar].Replace("\"", string.Empty); ;
                        string batch = cells[kolomBatch].Replace("\"", string.Empty); ;
                        string volgNummer = cells[kolomVolgnummer].Replace("\"", string.Empty); ;
                        string serieNummer = cells[kolomSerieNummer].Replace("\"", string.Empty); ;
                        string product = cells[kolomProduct].Replace("\"", string.Empty); ;
                        string firmware = cells[kolomFirmware].Replace("\"", string.Empty); ;
                        string type = cells[kolomType].Replace("\"", string.Empty); ;

                        SerienummerLijst.AddSerienummer(jaar, batch, volgNummer, serieNummer, product, firmware, type);

                        SerienummerLijst.AddSerienummer(jaar, batch, volgNummer, serieNummer, product, firmware, type);
                    }
                }

                FileFinder finder = new FileFinder();
                finder.Find(SerienummerLijst.LogoImage);
            }
            catch (IOException ex)
            {
                Message = ex.Message;
                return false;
            }

            return true;
        }

        private char? DetermineSeparator(string line)
        {
            string[] cellen = line.Split(';');
            if (cellen.Length >= 13)
            {
                return ';';
            }

            cellen = line.Split(',');
            if (cellen.Length >= 13)
            {
                return ',';
            }
            return null;
        }

        private string GetAdvise(string numberNeeded, int overleveringAbsoluut, int overleveringRelatief)
        {
            int needed = Convert.ToInt32(numberNeeded);
            double advised = Math.Round(needed + overleveringAbsoluut + 0.01 * overleveringRelatief * needed, 0);

            return advised.ToString();
        }
    }
}
