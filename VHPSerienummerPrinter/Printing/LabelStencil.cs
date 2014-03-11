using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using VHPSerienummerPrinter.Configuration;

namespace VHPSerienummerPrinter.Printing
{
    public class LabelStencil
    {

    #region fields and properties
        //const float schaalFactor = .8F;
        //38x23mm. Ze zitten met z'n tweeën naast elkaar op de rol.
        // breedte van beide labels samen: 8,51cm
        // Marges: links: 6mm, rest: 2mm
        //7,99 dpmm
        //factor 3,94
        private float breedteDrager = 338.84F;  //85.1mm
        private float breedteLabel = 149.72F;   //38mm
        private float labelHeight = 90.62F;     //23mm
        /// <summary>
        /// Linker marge van het label in pixels
        /// </summary>
        public float LabelMargeLinks {get;set;}
        /// <summary>
        /// Rechter marge van het label in pixels
        /// </summary>
        public float LabelMargeRechts { get; set; }
        public float LabelMargeBoven { get; set; }
        public float LabelMargeOnder { get; set; }
        public float DragerMargeLinks { get; set; }
        public float DragerMargeRechts { get; set; }
        private float DragerMargeMidden { get { return breedteDrager - DragerMargeLinks - DragerMargeRechts - 2 * breedteLabel; } }

        public float MaxBreedteLogo { get; set; }

        private const float hoogteCeLogo = 23.64F;
        private const float breedteCeLogo = 31.52F;
        private const float margeTussenLogoEnTekst = 6F;

        public Font TitelFont { get; set; }

        public Font ItemFont { get; set; }
        
        public bool PrintCeLogo { get; set; }
        public string Item1Label{ get; set; }
        public string Item2Label { get; set; }
        public string Item3Label { get; set; }
        public string Item4Label { get; set; }

        public string Product { get; set; }
        public string LogoImage{ get; set; }

#endregion
        public LabelStencil()
        {
            TitelFont = new Font("Arial", 9, FontStyle.Bold);
            ItemFont = new Font("Arial", 6, FontStyle.Bold);
        }

        public void PrintSerienummerLabel(Graphics g, SerienummerInfo label)
        {
            var breedteLinkerKolom = BepaalBreedte(g, label);
            RectangleF rect = PrintCompanyLogo(g, DragerMargeLinks);
            rect = PrintString(Product, TitelFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom linker label
            var leftRect = rect;
            leftRect = PrintString(Item1Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item2Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item3Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item4Label, ItemFont, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom linker label
            RectangleF rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", label.Item1), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item2), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item3), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item4), ItemFont, g, rightRect.Left, rightRect.Bottom);
            if (PrintCeLogo)
                PrintCELogo(g, breedteLabel + DragerMargeLinks, labelHeight);

            rect = PrintCompanyLogo(g, DragerMargeLinks + breedteLabel + DragerMargeMidden);
            rect = PrintString(Product, TitelFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom rechter label
            leftRect = rect;
            leftRect = PrintString(Item1Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item2Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item3Label, ItemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(Item4Label, ItemFont, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom rechter label
            rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", label.Item1), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item2), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item3), ItemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item4), ItemFont, g, rightRect.Left, rightRect.Bottom);
            if (PrintCeLogo)
                PrintCELogo(g, breedteDrager - DragerMargeRechts, labelHeight);
        }

        private float BepaalBreedte(Graphics g, SerienummerInfo label)
        {
            List<float> breedtes = new List<float>();
            breedtes.Add(g.MeasureString(Item1Label, ItemFont).Width);
            breedtes.Add(g.MeasureString(Item2Label, ItemFont).Width);
            breedtes.Add(g.MeasureString(Item3Label, ItemFont).Width);
            breedtes.Add(g.MeasureString(Item4Label, ItemFont).Width);
            breedtes.Sort();
            return breedtes[breedtes.Count - 1];
        }

        private void PrintLabelBounds(Graphics g)
        {
            //drager
            g.FillRectangle(new SolidBrush(Color.LightYellow), 0, 0, breedteDrager, labelHeight);

            //labels
            float left = DragerMargeLinks;
            float top = 0;
            float breedte = breedteLabel;
            float hoogte = labelHeight;
            g.FillRectangle(new SolidBrush(Color.LightGray), left, top, breedte, hoogte);


            left += LabelMargeLinks;
            top += LabelMargeBoven;
            breedte -= LabelMargeLinks + LabelMargeRechts;
            hoogte -= LabelMargeBoven + LabelMargeOnder;
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot }, left, top, breedte, hoogte);

            left = DragerMargeLinks + breedteLabel + (breedteDrager - DragerMargeLinks - DragerMargeRechts - breedteLabel - breedteLabel);
            top = 0;
            breedte = breedteLabel;
            hoogte = labelHeight;
            g.FillRectangle(new SolidBrush(Color.LightGray), left, top, breedte, hoogte);

            left += LabelMargeLinks;
            top += LabelMargeBoven;
            breedte -= LabelMargeLinks + LabelMargeRechts;
            hoogte -= LabelMargeBoven + LabelMargeOnder;
            Pen stippellijn = new Pen(Color.Black);
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot }, left, top, breedte, hoogte);
        }

        private void PrintCELogo(Graphics g, float right, float bottom)
        {
            float height = hoogteCeLogo;
            var width = ((float)height / (float)Afbeeldingen.CE_symbool.Height) * (float)Afbeeldingen.CE_symbool.Width;
            float left = right - width - LabelMargeRechts;
            float top = bottom - height - LabelMargeOnder;
            g.DrawImage(Afbeeldingen.CE_symbool, left, top, width, height);
        }

        private RectangleF PrintCompanyLogo(Graphics g, float leftOffsetLabel)
        {
            Bitmap logo = null;
            try
            {
                if (!string.IsNullOrEmpty(LogoImage))
                {
                    string file = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string theDirectory = Path.GetDirectoryName(file);
                    string path = Path.Combine(theDirectory, LogoImage);
                    if (File.Exists(path))
                    {
                        logo = (Bitmap)Bitmap.FromFile(path);
                    }
                    else
                    {
                        logo = Afbeeldingen.Logo_CDR13;
                    }
                }
                else
                {
                    logo = Afbeeldingen.Logo_CDR13;
                }

                //95 x 212 px
                float leftMargin = leftOffsetLabel + LabelMargeLinks;
                float maxHeight = labelHeight - LabelMargeBoven - LabelMargeOnder;

                //schalen met behoud van aspect ratio
                SizeF imageSize = ScaleImage(logo, maxHeight);

                float topMargin = (labelHeight - imageSize.Height) / 2;
                g.DrawImage(logo, leftMargin, topMargin, imageSize.Width, imageSize.Height);

                RectangleF rect = new RectangleF();
                rect.Height = imageSize.Height;
                rect.Width = imageSize.Width;
                rect.X = leftMargin;
                rect.Y = topMargin;
                return rect;
            }
            finally
            {
                if (logo != null)
                {
                    logo.Dispose();
                }
            }
        }

        
        private SizeF ScaleImage(Bitmap logo, float maxHeight)
        {
            SizeF imageSize = new SizeF();

            imageSize.Height = maxHeight;
            imageSize.Width = ((float)imageSize.Height / (float)logo.Height) * (float)logo.Width;

            if (imageSize.Width > MaxBreedteLogo)
            {
                //schalen op breedte
                imageSize.Width = MaxBreedteLogo;
                imageSize.Height = ((float)imageSize.Width / (float)logo.Width) * (float)logo.Height;
            }

            return imageSize;
        }

        private RectangleF PrintString(string text, Font font, Graphics g, float left, float top)
        {
            g.DrawString(text, font, Brushes.Black, left, top, new StringFormat());

            RectangleF rect = new RectangleF(new PointF { X = left, Y = top }, g.MeasureString(text, font));
            return rect;
        }

        private RectangleF MeetString(string text, Font font, Graphics g, float left, float top)
        {
            RectangleF rect = new RectangleF(new PointF { X = left, Y = top }, g.MeasureString(text, font));
            return rect;
        }

        ///// <summary>
        ///// Vertaalt lengte in mm naar pixels
        ///// </summary>
        ///// <param name="lengte">de lengte in mm</param>
        ///// <returns></returns>
        //private int ToCentiInches(float lengteInMilimeter)
        //{
        //    float lengteInInch = lengteInMilimeter / (float)25.4;

        //    return (int)(lengteInInch * 100);
        //}

        public void PrintPreviewImage(Graphics g, SerienummerInfo label)
        {
            PrintLabelBounds(g);
            PrintSerienummerLabel(g, label);
        }
    }
}
