using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Entities
{
    public class ExcelSheet
    {
        public bool CeLogo{ get; set; }
        public string Item1Label { get; set; }
        public string Item2Label { get; set; }
        public string Item3Label { get; set; }
        public string Item4Label { get; set; }

        public string Logo { get; set; }
        public string Product { get; set; }
        public bool PrintCeLogo { get; set; }

        public DataTable Data { get; set; }

        public List<DataRow> Rows { get; set; }
        public ExcelSheet()
        {
            Rows = new List<DataRow>();
            Data = new DataTable();
        }
    }
}
