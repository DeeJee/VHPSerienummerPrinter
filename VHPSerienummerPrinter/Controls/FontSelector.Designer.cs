namespace VHPSierienummerPrinter.Controls
{
    partial class FontSelector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fonts = new System.Windows.Forms.ComboBox();
            this.Sizes = new System.Windows.Forms.ComboBox();
            this.Styles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Fonts
            // 
            this.Fonts.FormattingEnabled = true;
            this.Fonts.Location = new System.Drawing.Point(4, 4);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(137, 21);
            this.Fonts.TabIndex = 0;
            this.Fonts.SelectedValueChanged += new System.EventHandler(this.Fonts_SelectedValueChanged);
            // 
            // Sizes
            // 
            this.Sizes.FormattingEnabled = true;
            this.Sizes.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.Sizes.Location = new System.Drawing.Point(147, 3);
            this.Sizes.Name = "Sizes";
            this.Sizes.Size = new System.Drawing.Size(45, 21);
            this.Sizes.TabIndex = 1;
            this.Sizes.SelectedValueChanged += new System.EventHandler(this.Sizes_SelectedValueChanged);
            // 
            // Styles
            // 
            this.Styles.FormattingEnabled = true;
            this.Styles.Location = new System.Drawing.Point(198, 3);
            this.Styles.Name = "Styles";
            this.Styles.Size = new System.Drawing.Size(68, 21);
            this.Styles.TabIndex = 2;
            this.Styles.SelectedValueChanged += new System.EventHandler(this.Styles_SelectedValueChanged);
            // 
            // FontSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Styles);
            this.Controls.Add(this.Sizes);
            this.Controls.Add(this.Fonts);
            this.Name = "FontSelector";
            this.Size = new System.Drawing.Size(280, 30);
            this.Load += new System.EventHandler(this.FontSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Fonts;
        private System.Windows.Forms.ComboBox Sizes;
        private System.Windows.Forms.ComboBox Styles;
    }
}
