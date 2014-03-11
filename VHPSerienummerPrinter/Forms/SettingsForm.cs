using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Text;
using VHPSerienummerPrinter.Configuration;
using VHPSerienummerPrinter.Converters;

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
            titelFontSelector.SelectedFont = Settings.Label.TitelFont;
            titelFontSelector.OnSelectionChanged += titelFont_OnSelectionChanged;

            itemFontSelector.SelectedFont = Settings.Label.ItemFont;
            itemFontSelector.OnSelectionChanged += itemFont_OnSelectionChanged;


            tbxLinks.Text = Settings.Label.LinkerMarge.ToString();
            tbxRechts.Text = Settings.Label.RechterMarge.ToString();
            tbxBoven.Text = Settings.Label.BovenMarge.ToString();
            tbxOnder.Text = Settings.Label.OnderMarge.ToString();
            tbxDragerMargeLinks.Text = Settings.Label.LinkerMargeDrager.ToString();
            tbxDragerMargeRechts.Text = Settings.Label.RechterMargeDrager.ToString();
            MaxBreedteLogo.Text = Settings.Label.MaxBreedteLogo.ToString();

            LabelPreview.LabelMargeLinks = (float)tbxLinks.Value;
            LabelPreview.LabelMargeRechts = (float)tbxRechts.Value;
            LabelPreview.LabelMargeBoven = (float)tbxBoven.Value;
            LabelPreview.LabelMargeOnder = (float)tbxOnder.Value;
            LabelPreview.DragerMargeLinks = float.Parse(tbxDragerMargeLinks.Text);
            LabelPreview.DragerMargeRechts = float.Parse(tbxDragerMargeRechts.Text);
        }

        void titelFont_OnSelectionChanged()
        {
            LabelPreview.TitelFont = titelFontSelector.SelectedFont.ToFont();
            LabelPreview.Invalidate();
        }
        void itemFont_OnSelectionChanged()
        {
            LabelPreview.ItemFont = itemFontSelector.SelectedFont.ToFont();
            LabelPreview.Invalidate();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Label.PrinterSettings = LabelPrinterSelector.Settings;
            Settings.Label.BovenMarge = (float)tbxBoven.Value;
            Settings.Label.OnderMarge = (float)tbxOnder.Value;
            Settings.Label.LinkerMarge = (float)tbxLinks.Value;
            Settings.Label.RechterMarge = (float)tbxRechts.Value;
            Settings.Label.LinkerMargeDrager = (float)tbxDragerMargeLinks.Value;
            Settings.Label.RechterMargeDrager = (float)tbxDragerMargeRechts.Value;
            Settings.Label.MaxBreedteLogo = (float)MaxBreedteLogo.Value;

            Settings.Label.TitelFont = titelFontSelector.SelectedFont;
            Settings.Label.ItemFont = itemFontSelector.SelectedFont;
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
            LabelPreview.LabelMargeOnder = (float)tbxOnder.Value;
            LabelPreview.Invalidate();
        }

        private void tbxDragerMargeLinks_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.DragerMargeLinks = (float)tbxDragerMargeLinks.Value;
            LabelPreview.Invalidate();
        }

        private void tbxDaragerMargeRechts_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.DragerMargeRechts = (float)tbxDragerMargeRechts.Value;
            LabelPreview.Invalidate();
        }

        private void DdlFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            //LabelPreview.FontFamily = DdlFonts.SelectedItem.ToString();
            //LabelPreview.Invalidate();
        }

        private void MaxBreedteLogo_ValueChanged(object sender, EventArgs e)
        {
            LabelPreview.MaxBreedteLogo= (float)MaxBreedteLogo.Value;
            LabelPreview.Invalidate();
        }

    }
}
