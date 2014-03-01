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
            this.DdlFonts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPreview = new VhpControls.PreviewControl();
            this.tbxDragerMargeRechts = new System.Windows.Forms.NumericUpDown();
            this.tbxDragerMargeLinks = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelPrinterSelector = new VHPSerienummerPrinter.Controls.PrinterSelector();
            ((System.ComponentModel.ISupportInitialize)(this.tbxOnder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxBoven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDragerMargeLinks)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.ButtonOk.Location = new System.Drawing.Point(12, 451);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonAnnuleren
            // 
            this.ButtonAnnuleren.Location = new System.Drawing.Point(93, 451);
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
            // DdlFonts
            // 
            this.DdlFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlFonts.FormattingEnabled = true;
            this.DdlFonts.Location = new System.Drawing.Point(75, 279);
            this.DdlFonts.Name = "DdlFonts";
            this.DdlFonts.Size = new System.Drawing.Size(168, 21);
            this.DdlFonts.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lettertype";
            // 
            // LabelPreview
            // 
            this.LabelPreview.DragerMargeLinks = 0F;
            this.LabelPreview.DragerMargeRechts = 0F;
            this.LabelPreview.LabelMargeBoven = 0F;
            this.LabelPreview.LabelMargeLinks = 0F;
            this.LabelPreview.LabelMargeOnder = 0F;
            this.LabelPreview.LabelMargeRechts = 0F;
            this.LabelPreview.Location = new System.Drawing.Point(12, 10);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(357, 108);
            this.LabelPreview.TabIndex = 22;
            this.LabelPreview.Text = "previewControl1";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 139);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Labels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Drager";
            // 
            // LabelPrinterSelector
            // 
            this.LabelPrinterSelector.Location = new System.Drawing.Point(12, 124);
            this.LabelPrinterSelector.Name = "LabelPrinterSelector";
            this.LabelPrinterSelector.Settings = null;
            this.LabelPrinterSelector.Size = new System.Drawing.Size(198, 155);
            this.LabelPrinterSelector.TabIndex = 23;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelPrinterSelector);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DdlFonts);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox DdlFonts;
        private System.Windows.Forms.Label label5;
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
    }
}