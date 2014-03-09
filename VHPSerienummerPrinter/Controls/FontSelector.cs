using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using VHPSerienummerPrinter.Configuration;

namespace VHPSierienummerPrinter.Controls
{
    public partial class FontSelector : UserControl
    {
        public delegate void SelectionChanged();
        public event SelectionChanged OnSelectionChanged;

        public FontSelector()
        {
            InitializeComponent();
        }

        private void FontSelector_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                Fonts.Items.Add(font.Name);
            }

            foreach (string fonStyle in Enum.GetNames(typeof(FontStyle)))
            {
                Styles.Items.Add(fonStyle);
            }
        }

        private void Fonts_SelectedValueChanged(object sender, EventArgs e)
        {
            ThrowEvent();
        }

        private void Sizes_SelectedValueChanged(object sender, EventArgs e)
        {
            ThrowEvent();
        }

        private void Styles_SelectedValueChanged(object sender, EventArgs e)
        {
            ThrowEvent();
        }

        private void ThrowEvent()
        {
            if (OnSelectionChanged != null && FontComplete())
            {
                OnSelectionChanged();
            }
        }

        private bool FontComplete()
        {
            return (Fonts.SelectedItem != null && Sizes.SelectedItem != null && Styles.SelectedItem != null);
        }

        public FontSettings SelectedFont
        {
            get
            {
                string font = Fonts.SelectedItem.ToString();
                float size = float.Parse((string)Sizes.SelectedItem);
                FontStyle style = (FontStyle)Enum.Parse(typeof(FontStyle), (string)Styles.SelectedItem);
                return new FontSettings(font, size, style);
            }
            set
            {
                Fonts.SelectedItem = value.Name;
                Sizes.SelectedItem = ((int)value.Size).ToString();
                Styles.SelectedItem = value.Style.ToString();
            }
        }
    }
}
