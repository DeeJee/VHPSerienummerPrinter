using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace VHPSerienummerPrinter
{
    public class TextFormatter
    {
        RectangleF bounds;
        Font font;
        Graphics g;
        string[] result = new string[2];

        public TextFormatter(Graphics graphics, RectangleF printableArea, Font defaultFont)
        {
            bounds = printableArea;
            font = defaultFont;
            g = graphics;
        }
        public string[] Format(string text)
        {
            FitToLine(text, text.Length);
            return new string[0];
        }

        private bool FitToLine(string text, int endIndex)
        {
            string substring = text.Substring(0, endIndex);
            SizeF size = g.MeasureString(substring, font);
            if (size.Width > bounds.Width)
            {
                return FitToLine(text, --endIndex);
            }

            result[0] = substring;
            result[1] = text.Substring(endIndex, text.Length-endIndex);
            return true;
        }

        public string[] Result { get { return result; } }

    }
}
