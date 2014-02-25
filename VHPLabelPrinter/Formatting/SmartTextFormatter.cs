using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace VHPSerienummerPrinter
{
    public class SmartTextFormatter
    {
        const string lineSeparator = " ";
        RectangleF bounds;
        Font font;
        Graphics g;
        string[] result = new string[2];

        public SmartTextFormatter(Graphics graphics, RectangleF printableArea, Font defaultFont)
        {
            bounds = printableArea;
            font = defaultFont;
            g = graphics;
        }
        public string[] Format(string text)
        {
            if (text.Contains(" "))
            {
                FitToLineUsingSeparator(text, text.Length);
            }
            else
            {
                FitToLine(text, text.Length);
            }
            return new string[0];
        }

        private void FitToLineUsingSeparator(string text, int p)
        {
            //spaties opzoeken
            List<int> indices = new List<int>();
            int index = text.Length;
            do
            {
                index--;
                index = text.LastIndexOf(' ', index);
                if (index != -1)
                    indices.Add(index);
            }
            while (index > 0);

            //proberen af te kappen vanaf de laatste spatie en kijken of het past.
            foreach (int indexje in indices)
            {
                string substring = text.Substring(0, indexje);
                SizeF size = g.MeasureString(substring, font);
                if (size.Width <= bounds.Width)
                {
                    //klaar
                    result[0] = substring;
                    result[1] = text.Substring(indexje, text.Length - indexje).Trim();
                    break;
                }
            }
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
            result[1] = text.Substring(endIndex, text.Length - endIndex);
            return true;
        }

        public string[] Result { get { return result; } }

    }
}
