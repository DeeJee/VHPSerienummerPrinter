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
using VHPSerienummerPrinter.Configuration;

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
            LabelPrinterSelector.Settings = Settings.Label.PrinterSettings;
                        
            tbxLinks.Text = Settings.Label.LinkerMarge.ToString();
            tbxRechts.Text = Settings.Label.RechterMarge.ToString();
            tbxBoven.Text = Settings.Label.BovenMarge.ToString();
            tbxOnder.Text = Settings.Label.OnderMarge.ToString();
            tbxDragerMargeLinks.Text = Settings.Label.LinkerMargeDrager.ToString();
            tbxDragerMargeRechts.Text = Settings.Label.RechterMargeDrager.ToString();


            LabelPreview.LabelMargeLinks = (float)tbxLinks.Value;
            LabelPreview.LabelMargeRechts = (float)tbxRechts.Value;
            LabelPreview.LabelMargeBoven = (float)tbxBoven.Value;
            LabelPreview.LabelMargeOnder = (float)tbxOnder.Value;
            LabelPreview.DragerMargeLinks = float.Parse(tbxDragerMargeLinks.Text);
            LabelPreview.DragerMargeRechts = float.Parse(tbxDragerMargeRechts.Text);
            LabelPreview.FontFamily = "Arial";
            HandleSelectedFont();
        }

        private void HandleSelectedFont()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {                
                DdlFonts.Items.Add(font.Name);
                if (font.Name == Settings.Label.FontFamily)
                {
                    DdlFonts.SelectedItem = DdlFonts.Items[DdlFonts.Items.Count - 1];
                }
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Label.PrinterSettings = LabelPrinterSelector.Settings;
            Settings.Label.BovenMarge = Convert.ToInt32(tbxBoven.Text);
            Settings.Label.OnderMarge = Convert.ToInt32(tbxOnder.Text);
            Settings.Label.LinkerMarge = Convert.ToInt32(tbxLinks.Text);
            Settings.Label.RechterMarge = Convert.ToInt32(tbxRechts.Text);
            Settings.Label.LinkerMargeDrager = float.Parse(tbxDragerMargeLinks.Text);
            Settings.Label.RechterMargeDrager = float.Parse(tbxDragerMargeRechts.Text);
            //Settings.Default.FontFamily = DdlFonts.SelectedItem.ToString();

            Settings.Save();
            Close();
        }

        private void ButtonAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnsureNumericValue(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxLinks_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.LabelMargeLinks = (float)tbxLinks.Value;
            LabelPreview.Invalidate();
        }

        private void tbxRechts_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.LabelMargeRechts = (float)tbxRechts.Value;
            LabelPreview.Invalidate();
        }

        private void tbxBoven_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.LabelMargeBoven = (float)tbxBoven.Value;
            LabelPreview.Invalidate();
        }

        private void tbxOnder_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.LabelMargeOnder= (float)tbxOnder.Value;
            LabelPreview.Invalidate();
        }

        private void tbxDragerMargeLinks_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.DragerMargeLinks = (float)tbxDragerMargeLinks.Value;
            LabelPreview.Invalidate();
        }

        private void tbxDaragerMargeRechts_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.DragerMargeRechts= (float)tbxDragerMargeRechts.Value;
            LabelPreview.Invalidate();
        }
    }
}
