namespace VHPSerienummerPrinter.Forms
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            VHPSerienummerPrinter.Configuration.FontSettings fontSettings1 = new VHPSerienummerPrinter.Configuration.FontSettings();
            VHPSerienummerPrinter.Configuration.FontSettings fontSettings2 = new VHPSerienummerPrinter.Configuration.FontSettings();
            this.LabelOverleveringAbsoluut = new System.Windows.Forms.Label();
            this.LabelOverleveringRelatief = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonAnnuleren = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOnder = new System.Windows.Forms.NumericUpDown();
            this.tbxLinks = new System.Windows.Forms.NumericUpDown();
            this.tbxBoven = new System.Windows.Forms.NumericUpDown();
            this.tbxRechts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDragerMargeRechts = new System.Windows.Forms.NumericUpDown();
            this.tbxDragerMargeLinks = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLabel = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemFontSelector = new VHPSierienummerPrinter.Controls.FontSelector();
            this.titelFontSelector = new VHPSierienummerPrinter.Controls.FontSelector();
            this.LabelPreview = new VhpControls.PreviewControl();
            this.tabPrinting = new System.Windows.Forms.TabPage();
            this.LabelPrinterSelector = new VHPSerienummerPrinter.Controls.PrinterSelector();
            ((System.ComponentModel.ISupportInitialize)(this.tbxOnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBoven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeLinks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLabel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPrinting.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelOverleveringAbsoluut
            // 
            this.LabelOverleveringAbsoluut.AutoSize = true;
            this.LabelOverleveringAbsoluut.Location = new System.Drawing.Point(16, 91);
            this.LabelOverleveringAbsoluut.Name = "LabelOverleveringAbsoluut";
            this.LabelOverleveringAbsoluut.Size = new System.Drawing.Size(38, 13);
            this.LabelOverleveringAbsoluut.TabIndex = 3;
            this.LabelOverleveringAbsoluut.Text = "Boven";
            // 
            // LabelOverleveringRelatief
            // 
            this.LabelOverleveringRelatief.AutoSize = true;
            this.LabelOverleveringRelatief.Location = new System.Drawing.Point(16, 111);
            this.LabelOverleveringRelatief.Name = "LabelOverleveringRelatief";
            this.LabelOverleveringRelatief.Size = new System.Drawing.Size(36, 13);
            this.LabelOverleveringRelatief.TabIndex = 4;
            this.LabelOverleveringRelatief.Text = "Onder";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 405);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonAnnuleren
            // 
            this.ButtonAnnuleren.Location = new System.Drawing.Point(93, 405);
            this.ButtonAnnuleren.Name = "ButtonAnnuleren";
            this.ButtonAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnnuleren.TabIndex = 8;
            this.ButtonAnnuleren.Text = "Annuleren";
            this.ButtonAnnuleren.UseVisualStyleBackColor = true;
            this.ButtonAnnuleren.Click += new System.EventHandler(this.ButtonAnnuleren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rechts";
            // 
            // tbxOnder
            // 
            this.tbxOnder.Location = new System.Drawing.Point(72, 107);
            this.tbxOnder.Name = "tbxOnder";
            this.tbxOnder.Size = new System.Drawing.Size(50, 20);
            this.tbxOnder.TabIndex = 25;
            this.tbxOnder.ValueChanged += new System.EventHandler(this.tbxOnder_ValueChanged);
            // 
            // tbxLinks
            // 
            this.tbxLinks.Location = new System.Drawing.Point(72, 47);
            this.tbxLinks.Name = "tbxLinks";
            this.tbxLinks.Size = new System.Drawing.Size(50, 20);
            this.tbxLinks.TabIndex = 23;
            this.tbxLinks.ValueChanged += new System.EventHandler(this.tbxLinks_ValueChanged);
            // 
            // tbxBoven
            // 
            this.tbxBoven.Location = new System.Drawing.Point(72, 87);
            this.tbxBoven.Name = "tbxBoven";
            this.tbxBoven.Size = new System.Drawing.Size(50, 20);
            this.tbxBoven.TabIndex = 24;
            this.tbxBoven.ValueChanged += new System.EventHandler(this.tbxBoven_ValueChanged);
            // 
            // tbxRechts
            // 
            this.tbxRechts.Location = new System.Drawing.Point(72, 67);
            this.tbxRechts.Name = "tbxRechts";
            this.tbxRechts.Size = new System.Drawing.Size(50, 20);
            this.tbxRechts.TabIndex = 23;
            this.tbxRechts.ValueChanged += new System.EventHandler(this.tbxRechts_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Links";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rechts";
            // 
            // tbxDragerMargeRechts
            // 
            this.tbxDragerMargeRechts.DecimalPlaces = 1;
            this.tbxDragerMargeRechts.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbxDragerMargeRechts.Location = new System.Drawing.Point(206, 69);
            this.tbxDragerMargeRechts.Name = "tbxDragerMargeRechts";
            this.tbxDragerMargeRechts.Size = new System.Drawing.Size(50, 20);
            this.tbxDragerMargeRechts.TabIndex = 24;
            this.tbxDragerMargeRechts.ValueChanged += new System.EventHandler(this.tbxDaragerMargeRechts_ValueChanged);
            // 
            // tbxDragerMargeLinks
            // 
            this.tbxDragerMargeLinks.DecimalPlaces = 1;
            this.tbxDragerMargeLinks.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbxDragerMargeLinks.Location = new System.Drawing.Point(206, 49);
            this.tbxDragerMargeLinks.Name = "tbxDragerMargeLinks";
            this.tbxDragerMargeLinks.Size = new System.Drawing.Size(50, 20);
            this.tbxDragerMargeLinks.TabIndex = 25;
            this.tbxDragerMargeLinks.ValueChanged += new System.EventHandler(this.tbxDragerMargeLinks_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxOnder);
            this.groupBox1.Controls.Add(this.tbxDragerMargeLinks);
            this.groupBox1.Controls.Add(this.tbxLinks);
            this.groupBox1.Controls.Add(this.tbxDragerMargeRechts);
            this.groupBox1.Controls.Add(this.tbxBoven);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelOverleveringAbsoluut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxRechts);
            this.groupBox1.Controls.Add(this.LabelOverleveringRelatief);
            this.groupBox1.Location = new System.Drawing.Point(20, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marges";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Drager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Labels";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLabel);
            this.tabControl1.Controls.Add(this.tabPrinting);
            this.tabControl1.Location = new System.Drawing.Point(12, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 391);
            this.tabControl1.TabIndex = 26;
            // 
            // tabLabel
            // 
            this.tabLabel.Controls.Add(this.groupBox2);
            this.tabLabel.Controls.Add(this.LabelPreview);
            this.tabLabel.Controls.Add(this.groupBox1);
            this.tabLabel.Location = new System.Drawing.Point(4, 22);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Padding = new System.Windows.Forms.Padding(3);
            this.tabLabel.Size = new System.Drawing.Size(384, 365);
            this.tabLabel.TabIndex = 0;
            this.tabLabel.Text = "Label";
            this.tabLabel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.itemFontSelector);
            this.groupBox2.Controls.Add(this.titelFontSelector);
            this.groupBox2.Location = new System.Drawing.Point(20, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 93);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lettertype";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Titel";
            // 
            // itemFontSelector
            // 
            this.itemFontSelector.Location = new System.Drawing.Point(45, 55);
            this.itemFontSelector.Name = "itemFontSelector";
            this.itemFontSelector.Size = new System.Drawing.Size(280, 30);
            this.itemFontSelector.TabIndex = 28;
            // 
            // titelFontSelector
            // 
            this.titelFontSelector.Location = new System.Drawing.Point(46, 20);
            this.titelFontSelector.Name = "titelFontSelector";
            this.titelFontSelector.Size = new System.Drawing.Size(279, 30);
            this.titelFontSelector.TabIndex = 27;
            // 
            // LabelPreview
            // 
            this.LabelPreview.DragerMargeLinks = 3.3F;
            this.LabelPreview.DragerMargeRechts = 3.3F;
            fontSettings1.Name = "Arial";
            fontSettings1.Size = 6F;
            fontSettings1.Style = System.Drawing.FontStyle.Bold;
            this.LabelPreview.ItemFont = fontSettings1;
            this.LabelPreview.LabelMargeBoven = 1F;
            this.LabelPreview.LabelMargeLinks = 2F;
            this.LabelPreview.LabelMargeOnder = 1F;
            this.LabelPreview.LabelMargeRechts = 2F;
            this.LabelPreview.Location = new System.Drawing.Point(20, 13);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(340, 92);
            this.LabelPreview.TabIndex = 22;
            this.LabelPreview.Text = "previewControl1";
            fontSettings2.Name = "Arial";
            fontSettings2.Size = 9F;
            fontSettings2.Style = System.Drawing.FontStyle.Bold;
            this.LabelPreview.TitelFont = fontSettings2;
            // 
            // tabPrinting
            // 
            this.tabPrinting.Controls.Add(this.LabelPrinterSelector);
            this.tabPrinting.Location = new System.Drawing.Point(4, 22);
            this.tabPrinting.Name = "tabPrinting";
            this.tabPrinting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrinting.Size = new System.Drawing.Size(384, 365);
            this.tabPrinting.TabIndex = 1;
            this.tabPrinting.Text = "Printer";
            this.tabPrinting.UseVisualStyleBackColor = true;
            // 
            // LabelPrinterSelector
            // 
            this.LabelPrinterSelector.Location = new System.Drawing.Point(6, 6);
            this.LabelPrinterSelector.Name = "LabelPrinterSelector";
            this.LabelPrinterSelector.Settings = null;
            this.LabelPrinterSelector.Size = new System.Drawing.Size(198, 155);
            this.LabelPrinterSelector.TabIndex = 23;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 447);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonAnnuleren);
            this.Controls.Add(this.ButtonOk);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxOnder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBoven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeLinks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabLabel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPrinting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelOverleveringAbsoluut;
        private System.Windows.Forms.Label LabelOverleveringRelatief;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonAnnuleren;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private VhpControls.PreviewControl LabelPreview;
        private System.Windows.Forms.NumericUpDown tbxOnder;
        private System.Windows.Forms.NumericUpDown tbxLinks;
        private System.Windows.Forms.NumericUpDown tbxBoven;
        private System.Windows.Forms.NumericUpDown tbxRechts;
        private Controls.PrinterSelector LabelPrinterSelector;
        private System.Windows.Forms.NumericUpDown tbxDragerMargeLinks;
        private System.Windows.Forms.NumericUpDown tbxDragerMargeRechts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLabel;
        private System.Windows.Forms.TabPage tabPrinting;
        private System.Windows.Forms.GroupBox groupBox2;
        private VHPSierienummerPrinter.Controls.FontSelector titelFontSelector;
        private VHPSierienummerPrinter.Controls.FontSelector itemFontSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}