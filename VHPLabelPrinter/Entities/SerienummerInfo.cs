using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter
{
    public class SerienummerInfo
    {
        public string Jaar { get; set; }
        public string Batch { get; set; }
        public string Volgnummer { get; set; }
        public string SerieNummer { get; set; }
        public string Product { get; set; }
        public string Firmware { get; set; }
        public string Type { get; set; }

        public KeyValuePair<string,string> Item1{ get; set; }
        public KeyValuePair<string,string> Item2{ get; set; }
        public KeyValuePair<string,string> Item3{ get; set; }
        public KeyValuePair<string,string> Item4{ get; set; }

        public SerienummerInfo(string jaar, string batch, string volgNummer, string serienummer, string product, string firmware, string type)
        {
            Jaar = jaar;
            Batch = batch;
            Volgnummer=volgNummer;
            SerieNummer = serienummer;
            Product = product;
            Firmware = firmware;
            Type = type;
        }

        public SerienummerInfo( string jaar, 
                                string batch, 
                                string volgNummer, 
                                KeyValuePair<string,string> item1,
                                KeyValuePair<string,string> item2,
                                KeyValuePair<string,string> item3,
                                KeyValuePair<string,string> item4)
        {
            Jaar = jaar;
            Batch = batch;
            Volgnummer = volgNummer;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }
}
