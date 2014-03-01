using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VHPSerienummerPrinter.Configuration
{
    public class FontSettings
    {
        public string Name{ get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }

        public FontSettings(){}
        public FontSettings(string name, float size, FontStyle style)
        {
            Name = name; 
            Size = size;
            Style = style;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}pt, {2}",Name, Size, Style);
        }
    }
}
