using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Drawing.Printing;
using VHPSerienummerPrinter.Forms;
using VHPSerienummerPrinter;
using System.Diagnostics;
using VHPSerienummerPrinter.RecentlyOpenedFiles;
using VHPSerienummerPrinter.Validators;
using VHPSerienummerPrinter.Printing;
using VHPSierienummerPrinter.Properties;
using VHPSerienummerPrinter.Configuration;

namespace VHPSerienummerPrinter
{
    public partial class Serienummers : Form
    {
        public bool LoadSuccesful { get; set; }

        private SerienummerLijst serienummers;
        public Serienummers(string path)
        {
            InitializeComponent();

            SerienummerLijstFactory factory = new SerienummerLijstFactory();
            Init(factory, path);
        }

        private bool Init(SerienummerLijstFactory factory, string path)
        {
            bool gelukt = factory.Create(path);
            if (gelukt)
            {
                serienummers = factory.serienummerLijst;
                LoadSuccesful = true;
            }
            else
            {
                DialogResult result = MessageBox.Show(factory.Message, "problemen", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    gelukt = Init(factory, path);
                }
                else
                {
                    //annuleren
                    LoadSuccesful = false;
                }
            }
            return gelukt;
        }

        public void Print()
        {
            if (!ValidateInput())
            {
                return;
            }

            //setup page size
            PageSetupDialog pageDialog1 = new PageSetupDialog();
            serienummers.StartIndex = DdlVan.SelectedIndex;
            serienummers.EindIndex = DdlTotEnMet.SelectedIndex;
            PrintEngine engine = new PrintEngine(serienummers);
            engine.TitelFont = Settings.Label.TitelFont;
            engine.ItemFont = Settings.Label.ItemFont;
            pageDialog1.Document = engine;

            //standaard printer instellen
            engine.PrinterSettings.PrinterName = Settings.Label.PrinterSettings.Printer;

            //eventueel standaard papier instellen
            SelectCustomPaper(engine, pageDialog1);

            printDialog1.Document = engine;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            printDialog1.Document.DocumentName = string.Format("Serienummer labels {0}", serienummers.Product);
            if (Settings.Label.PrinterSettings.AlwaysShowPrintDialog)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    engine.Print();
                }
            }
            else
            {
                engine.Print();
            }
        }

        private void SelectCustomPaper(PrintEngine engine, PageSetupDialog pageDialog1)
        {
            for (int index = 0; index < engine.PrinterSettings.PaperSizes.Count; index++)
            {
                if (engine.PrinterSettings.PaperSizes[index].PaperName == Settings.Label.PrinterSettings.Paper)
                {
                    PaperSize size = engine.PrinterSettings.PaperSizes[index];
                    pageDialog1.PageSettings.PaperSize = size;
                }
            }
        }

        private bool ValidateInput()
        {
            var van = DdlVan.SelectedItem;
            var totEnMet = DdlTotEnMet.SelectedItem;
            InputValidator validator = new InputValidator(van == null ? null : van.ToString(), totEnMet == null ? null : totEnMet.ToString());
            bool isValid = validator.Validate();
            if (!isValid)
            {
                MessageBox.Show(validator.Messages[0]);
            }

            return isValid;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LabelProduct.Text = serienummers.Product;
            LabelAantalItems.Text = serienummers.Labels.Count.ToString();
            foreach (SerienummerInfo info in serienummers.Labels)
            {
                //TODO: je kunt hier niet weten welke van de serienummers is
                DdlVan.Items.Add(info.Item2);
                DdlTotEnMet.Items.Add(info.Item2);
            }
        }

        public void PrintPreview()
        {
            if (!ValidateInput())
            {
                return;
            }

            ///setup page size
            PageSetupDialog pageDialog1 = new PageSetupDialog();

            serienummers.StartIndex = DdlVan.SelectedIndex;
            serienummers.EindIndex = DdlTotEnMet.SelectedIndex;

            PrintEngine engine = new PrintEngine(serienummers);
            engine.TitelFont= Settings.Label.TitelFont;
            engine.ItemFont = Settings.Label.ItemFont;
            pageDialog1.Document = engine;

            //standaard printer instellen
            engine.PrinterSettings.PrinterName = Settings.Label.PrinterSettings.Printer;

            //standaard papier instellen
            SelectCustomPaper(engine, pageDialog1);

            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog(); // instantiate new print preview dialog
            printPreviewDialog1.Document = engine;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                engine.Print();
            }
        }

        private void AddToRecentlyOpenedFiles(string fileName)
        {
            RecentFilesHandler.Add(fileName);
        }

        private void EnsureNumericValue(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VanSelectedIndexChanged(object sender, EventArgs e)
        {
            int startIndex = 0;
            if (DdlVan.SelectedIndex > -1)
            {
                startIndex = DdlVan.SelectedIndex;
            }

            DdlTotEnMet.Items.Clear();

            for (int index = startIndex; index < serienummers.Labels.Count; index++)
            {
                DdlTotEnMet.Items.Add(serienummers.Labels[index].Item2);
            }
        }

        private void TotEnMetSelectedIndexChanged(object sender, EventArgs e)
        {
            int startIndex = 0;
            int eindIndex = 0;

            eindIndex = DdlTotEnMet.Items.Count - 1;
            if (DdlTotEnMet.SelectedIndex > -1)
            {
                eindIndex = DdlTotEnMet.SelectedIndex;
            }

            int aantal = eindIndex - startIndex + 1;
            if (aantal == 1)
            {
                LabelAantalInSelectie.Text = string.Format("{0} label geselecteerd", aantal);
            }
            else
            {
                LabelAantalInSelectie.Text = string.Format("{0} labels geselecteerd", aantal);
            }

        }

        private void Voorbeeld_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void Afdrukken_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Serienummers_Paint(object sender, PaintEventArgs e)
        {
            PrintEngine engine = new PrintEngine(serienummers);
            engine.TitelFont= Settings.Label.TitelFont;
            engine.ItemFont = Settings.Label.ItemFont;
            try
            {
                engine.PrintPreviewImage(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
