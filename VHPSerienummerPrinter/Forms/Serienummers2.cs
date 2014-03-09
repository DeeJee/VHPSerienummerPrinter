﻿using System;
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
using VHPSerienummerPrinter.Configuration;
using VHPSerienummerPrinter.Entities;

namespace VHPSerienummerPrinter
{
    public partial class Serienummers2 : Form
    {
        public bool LoadSuccesful { get; set; }

        private SerienummerLijst serienummers;
        SerienummerLijstFactory factory;
        ExcelSheetReader reader;
        public Serienummers2(string path)
        {
            InitializeComponent();

            reader = new ExcelSheetReader();
            factory = new SerienummerLijstFactory();
            
            Init(path);
        }

        //private bool Init_oud(SerienummerLijstFactory_oud factory, string path)
        //{

        //    bool gelukt = factory.Create(path);
        //    if (gelukt)
        //    {
        //        serienummers = factory.serienummerLijst;
        //        LoadSuccesful = true;
        //    }
        //    else
        //    {
        //        DialogResult result = MessageBox.Show(factory.Message, "problemen", MessageBoxButtons.RetryCancel);
        //        if (result == DialogResult.Retry)
        //        {
        //            gelukt = Init(factory, path);
        //        }
        //        else
        //        {
        //            //annuleren
        //            LoadSuccesful = false;
        //        }
        //    }
        //    return gelukt;
        //}
        private bool Init(string path)
        {
            bool gelukt = reader.Read(path);
            if (gelukt)
            {
                factory.Create(reader.Sheet);
                serienummers = factory.serienummerLijst;
                LoadSuccesful = true;
            }
            else
            {
                DialogResult result = MessageBox.Show(reader.Message, "problemen", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    gelukt = Init(path);
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

            SetSelection();

            LabelPrintDocument engine = new LabelPrintDocument(serienummers);
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

        private void SetSelection()
        {
            if (DdlVan.SelectedItem != null)
            {
                serienummers.StartIndex = ((ListItem)DdlVan.SelectedItem).Value;
            }
            if (DdlTotEnMet.SelectedItem != null)
            {
                serienummers.EindIndex = ((ListItem)DdlTotEnMet.SelectedItem).Value;
            }
        }

        private void SelectCustomPaper(LabelPrintDocument engine, PageSetupDialog pageDialog1)
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

            //if (!File.Exists(serienummers.LogoImage))
            //{
            //    MessageBox.Show(string.Format("Kan logo niet vinden: {0}", serienummers.LogoImage), "Bestand niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            FillComboBox(0, DdlVan);
            FillComboBox(0, DdlTotEnMet);

            //DdlVan.DataSource = new BindingSource( dict,null);
            DdlVan.DisplayMember = "Text";
            DdlVan.ValueMember = "Value";
            //DdlTotEnMet.DataSource = new BindingSource(dict, null);
            DdlTotEnMet.DisplayMember = "Text";
            DdlTotEnMet.ValueMember = "Value";

            foreach(DataColumn column in serienummers.Data.Columns        ){
                Item1Selection.Items.Add(column.Caption);
                Item2Selection.Items.Add(column.Caption);
                Item3Selection.Items.Add(column.Caption);
                Item4Selection.Items.Add(column.Caption);
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

            SetSelection();

            LabelPrintDocument engine = new LabelPrintDocument(serienummers);
            engine.TitelFont = Settings.Label.TitelFont;
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
            string valueTotEnMet = null;
            if (DdlTotEnMet.SelectedItem != null)
            {
                valueTotEnMet = ((ListItem)DdlTotEnMet.SelectedItem).Text;
            }

            startIndex = ((ListItem)DdlVan.SelectedItem).Value;
            FillComboBox(startIndex, DdlTotEnMet);

            if (valueTotEnMet != null)
            {
                var index = DdlTotEnMet.FindString(valueTotEnMet);
                DdlTotEnMet.SelectedIndex = index;
            }
            CalculateNumberOfLabelsSelected();
        }

        private void FillComboBox(int startIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            for (int index = startIndex; index < serienummers.Labels.Count; index++)
            {
                var label = serienummers.Labels[index];
                comboBox.Items.Add(new ListItem(label.Item2, index));
            }
        }

        private void TotEnMetSelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateNumberOfLabelsSelected();
        }

        private void CalculateNumberOfLabelsSelected()
        {
            int startIndex = 0;
            int eindIndex;

            if (DdlVan.SelectedItem != null)
            {
                startIndex = ((ListItem)DdlVan.SelectedItem).Value;
            }

            if (DdlTotEnMet.SelectedIndex > -1)
            {
                eindIndex = ((ListItem)DdlTotEnMet.SelectedItem).Value;
            }
            else
            {
                eindIndex = ((ListItem)DdlTotEnMet.Items[DdlTotEnMet.Items.Count - 1]).Value;
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
            LabelPrintDocument engine = new LabelPrintDocument(serienummers);
            engine.TitelFont = Settings.Label.TitelFont;
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
