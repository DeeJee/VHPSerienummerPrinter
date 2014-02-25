using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using VHPSierienummerPrinter.Properties;
using System.Drawing.Text;

namespace VHPSerienummerPrinter.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            HandleDefaultPrinter();
            HandleDefaultLabel();
            tbxLinks.Text = Settings.Default.LinkerMarge.ToString();
            tbxRechts.Text = Settings.Default.RechterMarge.ToString();
            tbxBoven.Text = Settings.Default.BovenMarge.ToString();
            tbxOnder.Text = Settings.Default.OnderMarge.ToString();
            tbxDragerMargeLinks.Text = Settings.Default.LinkerMargeDrager.ToString();
            tbxDragerMargeRechts.Text = Settings.Default.RechterMargeDrager.ToString();
            //HandleSelectedFont();
        }

        private void HandleSelectedFont()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {                
                DdlFonts.Items.Add(font.Name);
                if (font.Name == Settings.Default.FontFamily)
                {
                    DdlFonts.SelectedItem = DdlFonts.Items[DdlFonts.Items.Count - 1];
                }
            }
        }

        private void HandleDefaultLabel()
        {
            bool isEnabled = Settings.Default.UseCustomPaper && Settings.Default.UseCustomPrinter;
            CbUseCustomLabel.Checked = isEnabled;
            DdlAvailableLabels.Enabled = isEnabled;

            VulLijstMetLabels();
        }

        private void VulLijstMetLabels()
        {
            DdlAvailableLabels.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                //Zoekt geselecteerde printer op
                if (printer == (string)DdlAvailablePrinters.SelectedItem)
                {
                    PrinterSettings selectedPrinter = new PrinterSettings();
                    selectedPrinter.PrinterName = printer;

                    //vult lijst met papierformaten die bij de geselecteerde printer horen
                    foreach (PaperSize paperSize in selectedPrinter.PaperSizes)
                    {
                        DdlAvailableLabels.Items.Add(paperSize.PaperName);
                    }
                }
            }

            //selectie tonen op scherm
            DdlAvailableLabels.SelectedItem = Settings.Default.CustomLabel;
            if (DdlAvailableLabels.SelectedItem == null)
            {
                //label niet gevonden
                LabelLabelNotFound.Visible = true;
                DdlAvailableLabels.SelectedText = Settings.Default.CustomLabel;
            }
        }

        private void HandleDefaultPrinter()
        {
            CbUseCustomPrinter.Checked = Settings.Default.UseCustomPrinter;
            DdlAvailablePrinters.Enabled = Settings.Default.UseCustomPrinter;

            //Lijst met beschikbare printers vullen
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                DdlAvailablePrinters.Items.Add(printer);
            }

            //selectie op het scherm tonen
            DdlAvailablePrinters.SelectedItem = Settings.Default.CustomPrinter;

            //Controleren of de standaardprinter nog steeds aanwezig is
            if (DdlAvailablePrinters.SelectedItem == null)
            {
                LabelPrinterNotFound.Visible = true;
                //labels wissen ?
                DdlAvailablePrinters.SelectedText = Settings.Default.CustomPrinter;                
            }            
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Default.UseCustomPrinter = CbUseCustomPrinter.Checked;
            if (CbUseCustomPrinter.Checked)
            {
                Settings.Default.CustomPrinter = (string)DdlAvailablePrinters.SelectedItem;
            }

            Settings.Default.UseCustomPaper = CbUseCustomLabel.Checked;
            if (CbUseCustomLabel.Checked)
            {
                Settings.Default.CustomLabel = (string)DdlAvailableLabels.SelectedItem;
            }

            Settings.Default.BovenMarge = Convert.ToInt32(tbxBoven.Text);
            Settings.Default.OnderMarge = Convert.ToInt32(tbxOnder.Text);
            Settings.Default.LinkerMarge = Convert.ToInt32(tbxLinks.Text);
            Settings.Default.RechterMarge = Convert.ToInt32(tbxRechts.Text);
            Settings.Default.LinkerMargeDrager = float.Parse(tbxDragerMargeLinks.Text);
            Settings.Default.RechterMargeDrager = float.Parse(tbxDragerMargeRechts.Text);
            //Settings.Default.FontFamily = DdlFonts.SelectedItem.ToString();

            Settings.Default.Save();
            Close();
        }

        private void ButtonAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrinterCheckedChanged(object sender, EventArgs e)
        {
            DdlAvailablePrinters.Enabled = CbUseCustomPrinter.Checked;
            CbUseCustomLabel.Enabled = CbUseCustomPrinter.Checked;
            DdlAvailableLabels.Enabled = CbUseCustomPrinter.Checked && CbUseCustomLabel.Checked;          
        }

        private void CbUseCustomLabel_CheckedChanged(object sender, EventArgs e)
        {
            DdlAvailableLabels.Enabled = CbUseCustomLabel.Checked;
        }

        private void DdlAvailablePrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lijst met beschikbare labels updaten
            if (CbUseCustomLabel.Checked)
            {
                VulLijstMetLabels();
            }
        }

        private void EnsureNumericValue(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
