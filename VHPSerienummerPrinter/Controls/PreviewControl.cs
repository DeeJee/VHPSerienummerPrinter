using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VHPSerienummerPrinter;
using VHPSerienummerPrinter.Configuration;
using VHPSerienummerPrinter.Printing;
using VHPSierienummerPrinter;

namespace VhpControls
{
    public class PreviewControl : Control
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

        private float _labelMargeLinks;
        private float _labelMargeLinksInCentiInches;
        public float LabelMargeLinks
        {
            get { return _labelMargeLinks; }
            set
            {
                _labelMargeLinks = value;
                _labelMargeLinksInCentiInches = ToCentiInches(value);
            }
        }

        private float _labelMargeRechts;
        private float _labelMargeRechtsInCentiInches;
        public float LabelMargeRechts
        {
            get { return _labelMargeRechts; }
            set
            {
                _labelMargeRechts = value;
                _labelMargeRechtsInCentiInches = ToCentiInches(value);
            }
        }

        private float _labelMargeBovenInCentiInches;
        private float _labelMargeBoven;
        public float LabelMargeBoven
        {
            get { return _labelMargeBoven; }
            set
            {
                _labelMargeBoven = value;
                _labelMargeBovenInCentiInches = ToCentiInches(value);
            }
        }

        private float _labelMargeOnder;
        private float _labelMargeOnderInCentiInches;
        public float LabelMargeOnder
        {
            get { return _labelMargeOnder; }
            set
            {
                _labelMargeOnder = value;
                _labelMargeOnderInCentiInches = ToCentiInches(value);
            }
        }

        private float _dragerMargeLinks;
        private float _dragerMargeLinksInCentiInches;
        public float DragerMargeLinks
        {
            get { return _dragerMargeLinks; }
            set
            {
                _dragerMargeLinks = value;
                _dragerMargeLinksInCentiInches = ToCentiInches(value);
            }
        }

        private float _dragerMargeRechts;
        private float _dragerMargeRechtsInCentiInches;
        public float DragerMargeRechts
        {
            get { return _dragerMargeRechts; }
            set
            {
                _dragerMargeRechts = value;
                _dragerMargeRechtsInCentiInches = ToCentiInches(value);
            }
        }


        private float _maxBreedteLogo;
        private float _maxBreedteLogoInCentiInches;
        public float MaxBreedteLogo
        {
            get { return _maxBreedteLogo; }
            set
            {
                _maxBreedteLogo = value;
                _maxBreedteLogoInCentiInches = ToCentiInches(value);
            }
        }

        private float DragerMargeMidden { get { return breedteDrager - _dragerMargeLinksInCentiInches - _dragerMargeRechtsInCentiInches - 2 * breedteLabel; } }


        private const float hoogteCeLogo = 23.64F;
        private const float breedteCeLogo = 31.52F;
        private const float margeTussenLogoEnTekst = 6F;

        private FontSettings _titelFontSettings=new FontSettings("Arial",9,FontStyle.Bold);
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

        private FontSettings _itemFontSettings=new FontSettings("Arial", 6,FontStyle.Bold);
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

        public PreviewControl()
        {
            _titleFont = new Font(_itemFontSettings.Name, _itemFontSettings.Size, _itemFontSettings.Style);
            _itemFont = new Font(_itemFontSettings.Name, _itemFontSettings.Size, _itemFontSettings.Style);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PrintLabelBounds(e.Graphics);
            PrintSerienummerLabel(e.Graphics);
        }

        private void PrintSerienummerLabel(Graphics g)
        {
            var breedteLinkerKolom = BepaalBreedte(g);
            RectangleF rect = PrintVHPLogo(g, _dragerMargeLinksInCentiInches);
            rect = PrintString("Lightning series", _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom linker label
            var leftRect = rect;
            leftRect = PrintString("type", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("SN", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("HW", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("FW", Font, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom linker label
            RectangleF rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", "Lightning Mini 10"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "080808LS0001"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.1.0"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.0.0"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            PrintCELogo(g, breedteLabel + _dragerMargeLinksInCentiInches, hoogteLabel);

            rect = PrintVHPLogo(g, _dragerMargeLinksInCentiInches + breedteLabel + DragerMargeMidden);
            rect = PrintString("Lightning series", _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom rechter label
            leftRect = rect;
            leftRect = PrintString("type", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("SN", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("HW", _itemFont, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("FW", _itemFont, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom rechter label
            rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", "Lightning Mini 10"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "080808LS0001"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.1.0"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.0.0"), _itemFont, g, rightRect.Left, rightRect.Bottom);
            PrintCELogo(g, right: breedteDrager - _dragerMargeRechtsInCentiInches, bottom: hoogteLabel);
        }


        private float BepaalBreedte(Graphics g)
        {
            List<float> breedtes = new List<float>();
            breedtes.Add(g.MeasureString("type", _itemFont).Width);
            breedtes.Add(g.MeasureString("SN", _itemFont).Width);
            breedtes.Add(g.MeasureString("HW", _itemFont).Width);
            breedtes.Add(g.MeasureString("FW", _itemFont).Width);
            breedtes.Sort();
            return breedtes[breedtes.Count - 1];
        }

        private void PrintCELogo(Graphics g, float right, float bottom)
        {
            float height = hoogteCeLogo;
            var width = ((float)height / (float)Afbeeldingen.CE_symbool.Height) * (float)Afbeeldingen.CE_symbool.Width;
            float left = right - width - _labelMargeRechtsInCentiInches;
            float top = bottom - height - _labelMargeOnderInCentiInches;
            g.DrawImage(Afbeeldingen.CE_symbool, left, top, width, height);
            
        }

        private RectangleF PrintString(string text, Font font, Graphics g, float left, float top)
        {
            g.DrawString(text, font, Brushes.Black, left, top, new StringFormat());

            RectangleF rect = new RectangleF(new PointF { X = left, Y = top }, g.MeasureString(text, font));
            return rect;
        }

        private RectangleF PrintVHPLogo(Graphics g, float leftOffsetLabel)
        {
            Bitmap logo = Afbeeldingen.Logo_CDR13;

            //95 x 212 px
            float leftMargin = leftOffsetLabel + _labelMargeLinksInCentiInches;
            float height = hoogteLabel - _labelMargeBovenInCentiInches - _labelMargeOnderInCentiInches;
            height = height * schaalFactor;
            //schalen met behoud van aspect ratio
            var width = ((float)height / (float)logo.Height) * (float)logo.Width;

            float topMargin = _labelMargeBovenInCentiInches + (hoogteLabel - height) / 2;
            g.DrawImage(logo, leftMargin, topMargin, width, height);

            RectangleF rect = new RectangleF();
            rect.Height = height;
            rect.Width = width;
            rect.X = leftMargin;
            rect.Y = topMargin;
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

        private void PrintLabelBounds(Graphics g)
        {
            //drager
            g.FillRectangle(new SolidBrush(Color.LightYellow), 0, 0, breedteDrager, hoogteLabel);

            //labels
            float left = _dragerMargeLinksInCentiInches;
            float top = 0;
            float breedte = breedteLabel;
            float hoogte = hoogteLabel;
            g.FillRectangle(new SolidBrush(Color.LightGray), left, top, breedte, hoogte);


            left += _labelMargeLinksInCentiInches;
            top += _labelMargeBovenInCentiInches;
            breedte -= _labelMargeLinksInCentiInches + _labelMargeRechtsInCentiInches;
            hoogte -= _labelMargeBovenInCentiInches + _labelMargeOnderInCentiInches;
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot }, left, top, breedte, hoogte);

            left = _dragerMargeLinksInCentiInches + breedteLabel + (breedteDrager - _dragerMargeLinksInCentiInches - _dragerMargeRechtsInCentiInches - breedteLabel - breedteLabel);
            top = 0;
            breedte = breedteLabel;
            hoogte = hoogteLabel;
            g.FillRectangle(new SolidBrush(Color.LightGray), left, top, breedte, hoogte);

            left += _labelMargeLinksInCentiInches;
            top += _labelMargeBovenInCentiInches;
            breedte -= _labelMargeLinksInCentiInches + _labelMargeRechtsInCentiInches;
            hoogte -= _labelMargeBovenInCentiInches + _labelMargeOnderInCentiInches;
            Pen stippellijn = new Pen(Color.Black);
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot }, left, top, breedte, hoogte);

            //this.Height = (int)hoogteLabel;
            //this.Width = (int)breedteDrager;
        }
    }
}
