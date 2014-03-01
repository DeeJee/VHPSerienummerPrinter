using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public float LabelMargeLinks { get; set; }
        public float LabelMargeRechts { get; set; }
        public float LabelMargeBoven { get; set; }
        public float LabelMargeOnder { get; set; }
        public float DragerMargeLinks { get; set; }
        public float DragerMargeRechts { get; set; }
        private float DragerMargeMidden { get { return breedteDrager - DragerMargeLinks - DragerMargeRechts - 2 * breedteLabel; } }

        private const float hoogteCeLogo = 23.64F;
        private const float breedteCeLogo = 31.52F;
        private const float margeTussenLogoEnTekst = 6F;

        private Font _titleFont = new Font("Arial", 9, FontStyle.Bold);
        //public Font TitleFont { get { return _titleFont; } set { _titleFont = value; } }

        private Font _font = new Font("Arial", 6, FontStyle.Bold);

        private string _fontFamily;
        public string FontFamily
        {
            get
            {
                return _fontFamily;
            }
            set
            {
                _fontFamily = value;
                _titleFont = new Font(_fontFamily, 9, FontStyle.Bold);
                _font = new Font(_fontFamily, 6, FontStyle.Bold);
            }
        }

        //public Font Font {get { return _font; }set { _font = value; }}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            PrintLabelBounds(e.Graphics);
            PrintSerienummerLabel(e.Graphics);
        }

        private void PrintSerienummerLabel(Graphics g)
        {
            var breedteLinkerKolom = BepaalBreedte(g);
            RectangleF rect = PrintVHPLogo(g, DragerMargeLinks);
            rect = PrintString("Lightning series", _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom linker label
            var leftRect = rect;
            leftRect = PrintString("type", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("SN", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("HW", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("FW", Font, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom linker label
            RectangleF rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", "Lightning Mini 10"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "080808LS0001"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.1.0"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.0.0"), Font, g, rightRect.Left, rightRect.Bottom);
            PrintCELogo(g, breedteLabel + DragerMargeLinks, hoogteLabel);

            rect = PrintVHPLogo(g, DragerMargeLinks + breedteLabel + DragerMargeMidden);
            rect = PrintString("Lightning series", _titleFont, g, rect.Right + margeTussenLogoEnTekst, rect.Top);

            //linker kolom rechter label
            leftRect = rect;
            leftRect = PrintString("type", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("SN", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("HW", Font, g, leftRect.Left, leftRect.Bottom);
            leftRect = PrintString("FW", Font, g, leftRect.Left, leftRect.Bottom);

            //rechter kolom rechter label
            rightRect = new RectangleF(rect.Left + breedteLinkerKolom, rect.Top, rect.Width, rect.Height);
            rightRect = PrintString(string.Format(": {0}", "Lightning Mini 10"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "080808LS0001"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.1.0"), Font, g, rightRect.Left, rightRect.Bottom);
            rightRect = PrintString(string.Format(": {0}", "V1.0.0"), Font, g, rightRect.Left, rightRect.Bottom);
            PrintCELogo(g, breedteDrager - DragerMargeRechts, hoogteLabel);
        }


        private float BepaalBreedte(Graphics g)
        {
            List<float> breedtes = new List<float>();
            breedtes.Add(g.MeasureString("type", Font).Width);
            breedtes.Add(g.MeasureString("SN", Font).Width);
            breedtes.Add(g.MeasureString("HW", Font).Width);
            breedtes.Add(g.MeasureString("FW", Font).Width);
            breedtes.Sort();
            return breedtes[breedtes.Count - 1];
        }

        private void PrintCELogo(Graphics g, float right, float bottom)
        {
            float height = hoogteCeLogo;
            var width = ((float)height / (float)Afbeeldingen.CE_symbool.Height) * (float)Afbeeldingen.CE_symbool.Width;
            float left = right - width - LabelMargeRechts;
            float top = bottom - height - LabelMargeBoven;
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
    }
}
