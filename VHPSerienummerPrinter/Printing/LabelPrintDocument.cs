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
using VHPSerienummerPrinter.Converters;

namespace VHPSerienummerPrinter.Printing
{
    public class LabelPrintDocument : PrintDocument
    {
        LabelStencil stencil;

        private int labelIndex = -1;
        private int lastPageIndex;

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

        private SerienummerLijst stuklijst;

        public string Product
        {
            get { return stencil.Product; }
            set { stencil.Product = value; }
        }

        public LabelPrintDocument(SerienummerLijst stuklijst)
        {
            this.stuklijst = stuklijst;
            this.DefaultPageSettings.Landscape = false;

            stencil = new LabelStencil();
            stencil.Item1Label = stuklijst.Item1Label;
            stencil.Item2Label = stuklijst.Item2Label;
            stencil.Item3Label = stuklijst.Item3Label;
            stencil.Item4Label = stuklijst.Item4Label;
            stencil.LogoImage = stuklijst.LogoImage;
            stencil.PrintCeLogo = stuklijst.PrintCeLogo;
            stencil.LabelMargeBoven = PixelConverter.MilimeterToPixels(Settings.Label.BovenMarge);
            stencil.LabelMargeOnder = PixelConverter.MilimeterToPixels(Settings.Label.OnderMarge);
            stencil.LabelMargeLinks = PixelConverter.MilimeterToPixels(Settings.Label.LinkerMarge);
            stencil.LabelMargeRechts = PixelConverter.MilimeterToPixels(Settings.Label.RechterMarge);
            stencil.DragerMargeLinks = PixelConverter.MilimeterToPixels(Settings.Label.LinkerMargeDrager);
            stencil.DragerMargeRechts = PixelConverter.MilimeterToPixels(Settings.Label.RechterMargeDrager);
            stencil.MaxBreedteLogo = PixelConverter.MilimeterToPixels(Settings.Label.MaxBreedteLogo);
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

            stencil.PrintSerienummerLabel(e.Graphics, label);

            // Als er nog meer labels in de lijst zitten komen die op een andere pagina.
            if (labelIndex < lastPageIndex)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            labelIndex++;
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

        public void PrintPreviewImage(Graphics g)
        {
            SerienummerInfo label = stuklijst.Labels[0];
            stencil.Product = stuklijst.Product;
            stencil.PrintPreviewImage(g, label);
        }
    }
}
