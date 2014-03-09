using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter
{
    public class ListItem
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ListItem(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }
}
