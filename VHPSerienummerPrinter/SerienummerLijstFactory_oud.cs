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
    public class SerienummerLijstFactory_oud
    {
        private const string booleanYes = "\"Y\"";


        private const int kolomJaar = 0;
        private const int kolomBatch = 1;
        private const int kolomVolgnummer = 2;
        //private const int kolomSerieNummer = 3;
        private const int kolomProduct = 13;
        //private const int kolomFirmware = 6;
        //private const int kolomType = 8;
        private const int dataStartReadRow = 17;
        private const int itemsLabelColumn = 12;

        private const int dataHeaderRow = 15;
        private const int logoRow = 6;
        private const int ceMarkRow = 7;
        private const int rijProduct = 4;
        private const int item1LabelRow = 5;
        private const int item2LabelRow = 6;
        private const int item3LabelRow = 7;
        private const int item4LabelRow = 8;


        private const int cemarkTitleColumn = 2;
        private const int cemarkValueColumn = 3;
        private const int logoTitleColumn = 2;
        private const int logovalueColumn = 3;

        private int item1Column;
        private int item2Column;
        private int item3Column;
        private int item4Column;

        public string Message { get; set; }
        public SerienummerLijst serienummerLijst { get; set; }
        private char? separator;

        /// <summary>
        /// Creates a stuklijst. Once the stuklijst has been created it can be accessed from the Stuklijst property.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool Create(string file)
        {
            serienummerLijst = new SerienummerLijst();
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
                string[] cells = lines[rijProduct].Split(separator.Value);
                serienummerLijst.Product = cells[kolomProduct].Replace("\"", string.Empty);

                //logo bepalen
                string cell = lines[logoRow].Split(separator.Value)[logoTitleColumn];
                if (cell.ToLower() == "logo")
                {
                    serienummerLijst.LogoImage = lines[logoRow].Split(separator.Value)[logovalueColumn];
                }

                //bepalen of het CE logo afgedrukt moet worden
                cell = lines[ceMarkRow].Split(separator.Value)[cemarkTitleColumn];
                if (cell.ToLower() == "ce-mark")
                {
                    serienummerLijst.PrintCeLogo = lines[ceMarkRow].Split(separator.Value)[cemarkValueColumn].ToLower() == "yes";
                }
                else
                {
                    serienummerLijst.PrintCeLogo = true;
                }

                BepaalItems(lines);


                //labels bepalen
                for (int lineNumber = dataStartReadRow; lineNumber < lines.Count; lineNumber++)
                {
                    string line = lines[lineNumber];
                    if (LineIsEmpty(line))
                    {
                        break;
                    }
                    //de artikelen lezen
                    cells = line.Split(separator.Value);
                    string jaar = cells[kolomJaar].Replace("\"", string.Empty);
                    string batch = cells[kolomBatch].Replace("\"", string.Empty);
                    string volgNummer = cells[kolomVolgnummer].Replace("\"", string.Empty);

                    string item1 = cells[item1Column].Replace("\"", string.Empty);
                    string item2 = cells[item2Column].Replace("\"", string.Empty);
                    string item3 = cells[item3Column].Replace("\"", string.Empty);
                    string item4 = cells[item4Column].Replace("\"", string.Empty);

                    serienummerLijst.AddSerienummer(jaar, batch, volgNummer, item1, item2, item3, item4);
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

        private bool LineIsEmpty(string line)
        {
            string temp=line.Replace(separator.Value.ToString(),string.Empty);
            return temp.Trim().Length == 0;
        }

        private void BepaalItems(List<string> lines)
        {
            serienummerLijst.Item1Label = lines[item1LabelRow].Split(separator.Value)[itemsLabelColumn];
            serienummerLijst.Item2Label = lines[item2LabelRow].Split(separator.Value)[itemsLabelColumn];
            serienummerLijst.Item3Label = lines[item3LabelRow].Split(separator.Value)[itemsLabelColumn];
            serienummerLijst.Item4Label = lines[item4LabelRow].Split(separator.Value)[itemsLabelColumn];

            string[] cells = lines[dataHeaderRow].Split(separator.Value);
            for (int index = 0; index < cells.Length; index++)
            {
                string waarde = cells[index];
                if (waarde == serienummerLijst.Item1Label)
                {
                    item1Column = index;
                }
                if (waarde == serienummerLijst.Item2Label)
                {
                    item2Column = index;
                }
                if (waarde == serienummerLijst.Item3Label)
                {
                    item3Column = index;
                }
                if (waarde == serienummerLijst.Item4Label)
                {
                    item4Column = index;
                }
            }
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
