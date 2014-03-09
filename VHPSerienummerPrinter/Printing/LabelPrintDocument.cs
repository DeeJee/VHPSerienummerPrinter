using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using VHPSerienummerPrinter;
using System.IO;
using VHPSierienummerPrinter;
using System.Drawing.Drawing2D;
using VHPSerienummerPrinter.Configuration;
using System.Windows.Forms;

namespace VHPSerienummerPrinter.Printing
{
    public class LabelPrintDocument : PrintDocument
    {
        const float schaalFactor = .8F;
        //38x23mm. Ze zitten met z'n tweeën naast elkaar op de rol.
        // breedte van beide labels samen: 8,51cm
        // Marges: links: 6mm, rest: 2mm
        //7,99 dpmm
        //factor 3,94
        private float breedteDrager = 338.84F;  //85.1mm
        private float breedteLabel = 149.72F;   //38mm
        private float hoogteLabel = 90.62F;     //23mm
        public float LabelMargeLinks { get { return ToCentiInches(Settings.Label.LinkerMarge); } }
        public float LabelMargeRechts { get { return ToCentiInches(Settings.Label.RechterMarge); } }
        public float LabelMargeBoven { get { return ToCentiInches(Settings.Label.BovenMarge); } }
        public float LabelMargeOnder { get { return ToCentiInches(Settings.Label.OnderMarge); } }
        private float DragerMargeLinks { get { return ToCentiInches(Settings.Label.LinkerMargeDrager); } }
        private float DragerMargeRechts { get { return ToCentiInches(Settings.Label.RechterMargeDrager); } }
        private float DragerMargeMidden { get { return breedteDrager - DragerMargeLinks - DragerMargeRechts - 2 * breedteLabel; } }

        private const float hoogteCeLogo = 23.64F;
        private const float breedteCeLogo = 31.52F;
        private const float margeTussenLogoEnTekst = 6F;

        private int labelIndex = -1;
        private int lastPageIndex;

        private FontSettings _titelFontSettings = new FontSettings("Arial", 9, FontStyle.Bold);
        public FontSettings TitelFont
        {
            get
            {
                return _titelFontSettings;
            }
            set
            {
                _titelFontSettings = value;
                _titleFont = new Font(value.Name, value.Size, value.Style);
            }
        }

        private FontSettings _itemFontSettings = new FontSettings("Arial", 6, FontStyle.Bold);
        public FontSettings ItemFont
        {
            get { return _itemFontSettings; }
            set
            {
                _itemFontSettings = value;
                _itemFont = new Font(value.Name, value.Size, value.Style);
            }
        }

        private Font _titleFont;
        private Font _itemFont;

        private SerienummerLijst stuklijst;
        public LabelPrintDocument(SerienummerLijst stuklijst)
        {
            _titleFont = new Font(_itemFontSettings.Name, _itemFontSettings.Size, _itemFontSettings.Style);
            _itemFont = new Font(_itemFontSettings.Name, _itemFontSettings.Size, _itemFontSettings.Style);
            this.stuklijst = stuklijst;
            //this.DefaultPageSettings.PaperSize = new PaperSelector().GetDefaultlabel();
            this.DefaultPageSettings.Landscape = false;
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);
        }

        // OnPrintPage is raised for each page to be printed.
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            PrintSerienummerLabels(e);
        }

        private void PrintSerienummerLabels(PrintPageEventArgs e)
        {
            if (labelIndex == -1)//init
            {
                Initialize(e);
            }

            base.OnPrintPage(e);

            float leftMargin = e.PageSettings.PrintableArea.X;
            float topMargin = e.PageSettings.PrintableArea.Y;

            //haal een label uit de lijst en print deze
            SerienummerInfo label = stuklijst.SelectedLabels[labelIndex];

            //PrintLabelBounds(e.Graphics);
            PrintSerienummerLabel(e.Graphics, label);

            // Als er nog meer labels in de lijst zitten komen die op een andere pagina.
            if (labelIndex < lastPageIndex)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            labelIndex++;
        }

        private void PrintSerienummerLabel(Graphics g, SerienummerInfo label)
        {
            var breedteLinkerKolom = BepaalBreedte(g, label);
            RectangleF rect = PrintLogo(g, DragerMargeLinks);
            rect = PrintString(stuklijst.Product, _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom linker label
            var leftRect = rect;
            leftRect = PrintString(stuklijst.Item1Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item2Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item3Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item4Label, _itemFont, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom linker label
            RectangleF rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", label.Item1), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item2), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item3), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item4), _itemFont, g, rightRect.Left, rightRect.Bottom);
            if (stuklijst.PrintCeLogo)
                PrintCELogo(g, breedteLabel + DragerMargeLinks, hoogteLabel);

            rect = PrintLogo(g, DragerMargeLinks + breedteLabel + DragerMargeMidden);
            rect = PrintString(stuklijst.Product, _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom rechter label
            leftRect = rect;
            leftRect = PrintString(stuklijst.Item1Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item2Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item3Label, _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString(stuklijst.Item4Label, _itemFont, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom rechter label
            rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", label.Item1), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item2), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item3), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", label.Item4), _itemFont, g, rightRect.Left, rightRect.Bottom);
            if (stuklijst.PrintCeLogo)
                PrintCELogo(g, breedteDrager - DragerMargeRechts, hoogteLabel);
        }

        private float BepaalBreedte(Graphics g, SerienummerInfo label)
        {
            List<float> breedtes = new List<float>();
            breedtes.Add(g.MeasureString(stuklijst.Item1Label, _itemFont).Width);
            breedtes.Add(g.MeasureString(stuklijst.Item2Label, _itemFont).Width);
            breedtes.Add(g.MeasureString(stuklijst.Item3Label, _itemFont).Width);
            breedtes.Add(g.MeasureString(stuklijst.Item4Label, _itemFont).Width);
            breedtes.Sort();
            return breedtes[breedtes.Count - 1];
        }

        private void PrintLabelBounds(Graphics g)
        {
            //drager
            g.FillRectangle(new SolidBrush(Color.LightYellow), 0, 0, breedteDrager, hoogteLabel);

            //labels
            float left = DragerMargeLinks;
            float top = 0;
            float breedte = breedteLabel;
            float hoogte = hoogteLabel;
            g.FillRectangle(new SolidBrush(Color.LightGray), left, top, breedte, hoogte);


            left += LabelMargeLinks;
            top += LabelMargeBoven;
            breedte -= LabelMargeLinks + LabelMargeRechts;
            hoogte -= LabelMargeBoven + LabelMargeOnder;
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot }, left, top, breedte, hoogte);

            left = DragerMargeLinks + breedteLabel + (breedteDrager - DragerMargeLinks - DragerMargeRechts - breedteLabel - breedteLabel);
            top = 0;
            breedte = breedteLabel;
            hoogte = hoogteLabel;
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

        private RectangleF PrintLogo(Graphics g, float leftOffsetLabel)
        {
            Bitmap logo = null;
            try
            {
                if (!string.IsNullOrEmpty(stuklijst.LogoImage))
                {
                    string file = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string theDirectory = Path.GetDirectoryName(file);
                    string path = Path.Combine(theDirectory, stuklijst.LogoImage);
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
                float height = hoogteLabel - LabelMargeBoven - LabelMargeOnder;
                height = height * schaalFactor;
                //schalen met behoud van aspect ratio
                var width = ((float)height / (float)logo.Height) * (float)logo.Width;

                float topMargin = LabelMargeBoven + (hoogteLabel - height) / 2;
                g.DrawImage(logo, leftMargin, topMargin, width, height);

                RectangleF rect = new RectangleF();
                rect.Height = height;
                rect.Width = width;
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

        private void Initialize(PrintPageEventArgs e)
        {
            int fromPage = e.PageSettings.PrinterSettings.FromPage;
            int toPage = e.PageSettings.PrinterSettings.ToPage;
            if (fromPage > toPage)
            {
                int temp = fromPage;
                fromPage = toPage;
                toPage = temp;
            }

            if (fromPage == 0 && toPage == 0)
            {
                //alles afdrukken
                labelIndex = 0;
                lastPageIndex = stuklijst.SelectedLabels.Count - 1;
            }
            else
            {
                if (fromPage <= stuklijst.Labels.Count)
                {
                    labelIndex = fromPage - 1; //zero based
                }
                else
                {
                    throw new Exception("Page from cannot be smaller than the number of pages.");
                }
                lastPageIndex = e.PageSettings.PrinterSettings.ToPage;
            }
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

        /// <summary>
        /// Vertaalt lengte in mm naar pixels
        /// </summary>
        /// <param name="lengte">de lengte in mm</param>
        /// <returns></returns>
        private int ToCentiInches(float lengteInMilimeter)
        {
            float lengteInInch = lengteInMilimeter / (float)25.4;

            return (int)(lengteInInch * 100);
        }

        public void PrintPreviewImage(Graphics g)
        {
            SerienummerInfo label = stuklijst.Labels[0];
            PrintLabelBounds(g);
            PrintSerienummerLabel(g, label);
        }
    }
}
