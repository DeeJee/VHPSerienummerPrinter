using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VHPSerienummerPrinter;
using VHPSerienummerPrinter.Configuration;
using VHPSerienummerPrinter.Converters;
using VHPSerienummerPrinter.Printing;
using VHPSierienummerPrinter;

namespace VhpControls
{
    public class PreviewControl : Control
    {
        LabelStencil stencil = new LabelStencil();

        //private float breedteDrager = 338.84F;  //85.1mm
        //private float breedteLabel = 149.72F;   //38mm


        private float _labelMargeLinks;
        private float _labelMargeLinksInPixels;
        public float LabelMargeLinks
        {
            get { return stencil.LabelMargeLinks; }
            set
            {
                _labelMargeLinks = value;
                _labelMargeLinksInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.LabelMargeLinks = _labelMargeLinksInPixels;
            }
        }

        private float _labelMargeRechts;
        private float _labelMargeRechtsInPixels;
        public float LabelMargeRechts
        {
            get { return _labelMargeRechts; }
            set
            {
                _labelMargeRechts = value;
                _labelMargeRechtsInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.LabelMargeRechts = _labelMargeRechtsInPixels;
            }
        }

        private float _labelMargeBovenInPixels;
        private float _labelMargeBoven;
        public float LabelMargeBoven
        {
            get { return _labelMargeBoven; }
            set
            {
                _labelMargeBoven = value;
                _labelMargeBovenInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.LabelMargeBoven = _labelMargeBovenInPixels;
            }
        }

        private float _labelMargeOnder;
        private float _labelMargeOnderInPixels;
        public float LabelMargeOnder
        {
            get { return _labelMargeOnder; }
            set
            {
                _labelMargeOnder = value;
                _labelMargeOnderInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.LabelMargeOnder = _labelMargeOnderInPixels;
            }
        }

        private float _dragerMargeLinks;
        private float _dragerMargeLinksInPixels;
        public float DragerMargeLinks
        {
            get { return _dragerMargeLinks; }
            set
            {
                _dragerMargeLinks = value;
                _dragerMargeLinksInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.DragerMargeLinks = _dragerMargeLinksInPixels;
            }
        }

        private float _dragerMargeRechts;
        private float _dragerMargeRechtsInPixels;
        public float DragerMargeRechts
        {
            get { return _dragerMargeRechts; }
            set
            {
                _dragerMargeRechts = value;
                _dragerMargeRechtsInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.DragerMargeRechts = _dragerMargeRechtsInPixels;
            }
        }

        private float _maxBreedteLogo;
        private float _maxBreedteLogoInPixels;
        public float MaxBreedteLogo
        {
            get { return _maxBreedteLogo; }
            set
            {
                _maxBreedteLogo = value;
                _maxBreedteLogoInPixels = PixelConverter.MilimeterToPixels(value);
                stencil.MaxBreedteLogo = _maxBreedteLogoInPixels;
            }
        }

        public Font TitelFont
        {
            get { return stencil.TitelFont; }
            set { stencil.TitelFont = value; }
        }
        public Font ItemFont
        {
            get { return stencil.ItemFont; }
            set { stencil.ItemFont = value; }
        }
        public string Product { get; set; }

        public PreviewControl()
        {
            stencil = new LabelStencil();
            stencil.Item1Label = "type";
            stencil.Item2Label = "SN";
            stencil.Item3Label = "HW";
            stencil.Item4Label = "FW";
            stencil.LogoImage = "";
            stencil.PrintCeLogo = true;
            stencil.LabelMargeBoven = PixelConverter.MilimeterToPixels(Settings.Label.BovenMarge);
            stencil.LabelMargeOnder = PixelConverter.MilimeterToPixels(Settings.Label.OnderMarge);
            stencil.LabelMargeLinks = PixelConverter.MilimeterToPixels(Settings.Label.LinkerMarge);
            stencil.LabelMargeRechts = PixelConverter.MilimeterToPixels(Settings.Label.RechterMarge);
            stencil.DragerMargeLinks = PixelConverter.MilimeterToPixels(Settings.Label.LinkerMargeDrager);
            stencil.DragerMargeRechts = PixelConverter.MilimeterToPixels(Settings.Label.RechterMargeDrager);
            stencil.MaxBreedteLogo = PixelConverter.MilimeterToPixels(Settings.Label.MaxBreedteLogo);
            stencil.Product = "Lightning series";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            stencil.Product = Product;
            SerienummerInfo label = new SerienummerInfo("", "", "",
                "Lightning Mini 10",
                "080808LS0001",
                "V1.1.0",
                "V1.0.0");
            stencil.PrintPreviewImage(e.Graphics, label);
        }

        
    }
}
