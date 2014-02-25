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
            this.DdlAvailablePrinters = new System.Windows.Forms.ComboBox();
            this.LabelPrinterNotFound = new System.Windows.Forms.Label();
            this.LabelOverleveringAbsoluut = new System.Windows.Forms.Label();
            this.LabelOverleveringRelatief = new System.Windows.Forms.Label();
            this.tbxBoven = new System.Windows.Forms.TextBox();
            this.tbxOnder = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonAnnuleren = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelLabelNotFound = new System.Windows.Forms.Label();
            this.CbUseCustomPrinter = new System.Windows.Forms.CheckBox();
            this.DdlAvailableLabels = new System.Windows.Forms.ComboBox();
            this.CbUseCustomLabel = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbxLinks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRechts = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxDragerMargeLinks = new System.Windows.Forms.TextBox();
            this.tbxDragerMargeRechts = new System.Windows.Forms.TextBox();
            this.DdlFonts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DdlAvailablePrinters
            // 
            this.DdlAvailablePrinters.FormattingEnabled = true;
            this.DdlAvailablePrinters.Location = new System.Drawing.Point(36, 43);
            this.DdlAvailablePrinters.Name = "DdlAvailablePrinters";
            this.DdlAvailablePrinters.Size = new System.Drawing.Size(168, 21);
            this.DdlAvailablePrinters.TabIndex = 1;
            this.toolTip1.SetToolTip(this.DdlAvailablePrinters, "Deze printer staat ingesteld in het print dialoog venster.");
            this.DdlAvailablePrinters.SelectedIndexChanged += new System.EventHandler(this.DdlAvailablePrinters_SelectedIndexChanged);
            // 
            // LabelPrinterNotFound
            // 
            this.LabelPrinterNotFound.AutoSize = true;
            this.LabelPrinterNotFound.ForeColor = System.Drawing.Color.Red;
            this.LabelPrinterNotFound.Location = new System.Drawing.Point(210, 43);
            this.LabelPrinterNotFound.Name = "LabelPrinterNotFound";
            this.LabelPrinterNotFound.Size = new System.Drawing.Size(188, 13);
            this.LabelPrinterNotFound.TabIndex = 2;
            this.LabelPrinterNotFound.Text = "De ingestelde printer is niet gevonden.";
            this.LabelPrinterNotFound.Visible = false;
            // 
            // LabelOverleveringAbsoluut
            // 
            this.LabelOverleveringAbsoluut.AutoSize = true;
            this.LabelOverleveringAbsoluut.Location = new System.Drawing.Point(11, 62);
            this.LabelOverleveringAbsoluut.Name = "LabelOverleveringAbsoluut";
            this.LabelOverleveringAbsoluut.Size = new System.Drawing.Size(38, 13);
            this.LabelOverleveringAbsoluut.TabIndex = 3;
            this.LabelOverleveringAbsoluut.Text = "Boven";
            // 
            // LabelOverleveringRelatief
            // 
            this.LabelOverleveringRelatief.AutoSize = true;
            this.LabelOverleveringRelatief.Location = new System.Drawing.Point(11, 82);
            this.LabelOverleveringRelatief.Name = "LabelOverleveringRelatief";
            this.LabelOverleveringRelatief.Size = new System.Drawing.Size(36, 13);
            this.LabelOverleveringRelatief.TabIndex = 4;
            this.LabelOverleveringRelatief.Text = "Onder";
            // 
            // tbxBoven
            // 
            this.tbxBoven.Location = new System.Drawing.Point(67, 58);
            this.tbxBoven.Name = "tbxBoven";
            this.tbxBoven.Size = new System.Drawing.Size(50, 20);
            this.tbxBoven.TabIndex = 5;
            this.tbxBoven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureNumericValue);
            // 
            // tbxOnder
            // 
            this.tbxOnder.Location = new System.Drawing.Point(67, 78);
            this.tbxOnder.Name = "tbxOnder";
            this.tbxOnder.Size = new System.Drawing.Size(50, 20);
            this.tbxOnder.TabIndex = 6;
            this.tbxOnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureNumericValue);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 292);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonAnnuleren
            // 
            this.ButtonAnnuleren.Location = new System.Drawing.Point(93, 292);
            this.ButtonAnnuleren.Name = "ButtonAnnuleren";
            this.ButtonAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnnuleren.TabIndex = 8;
            this.ButtonAnnuleren.Text = "Annuleren";
            this.ButtonAnnuleren.UseVisualStyleBackColor = true;
            this.ButtonAnnuleren.Click += new System.EventHandler(this.ButtonAnnuleren_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelLabelNotFound);
            this.groupBox1.Controls.Add(this.CbUseCustomPrinter);
            this.groupBox1.Controls.Add(this.DdlAvailableLabels);
            this.groupBox1.Controls.Add(this.CbUseCustomLabel);
            this.groupBox1.Controls.Add(this.LabelPrinterNotFound);
            this.groupBox1.Controls.Add(this.DdlAvailablePrinters);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer";
            // 
            // LabelLabelNotFound
            // 
            this.LabelLabelNotFound.AutoSize = true;
            this.LabelLabelNotFound.ForeColor = System.Drawing.Color.Red;
            this.LabelLabelNotFound.Location = new System.Drawing.Point(210, 97);
            this.LabelLabelNotFound.Name = "LabelLabelNotFound";
            this.LabelLabelNotFound.Size = new System.Drawing.Size(184, 13);
            this.LabelLabelNotFound.TabIndex = 15;
            this.LabelLabelNotFound.Text = "Het ingestelde label is niet gevonden.";
            this.LabelLabelNotFound.Visible = false;
            // 
            // CbUseCustomPrinter
            // 
            this.CbUseCustomPrinter.AutoSize = true;
            this.CbUseCustomPrinter.Location = new System.Drawing.Point(7, 20);
            this.CbUseCustomPrinter.Name = "CbUseCustomPrinter";
            this.CbUseCustomPrinter.Size = new System.Drawing.Size(157, 17);
            this.CbUseCustomPrinter.TabIndex = 14;
            this.CbUseCustomPrinter.Text = "Standaard printer gebruiken";
            this.toolTip1.SetToolTip(this.CbUseCustomPrinter, "Selecteer als je een standaard printer wilt definieren. Deze staat geselecteerd i" +
                    "n het print dialoogvenster.");
            this.CbUseCustomPrinter.UseVisualStyleBackColor = true;
            this.CbUseCustomPrinter.CheckedChanged += new System.EventHandler(this.PrinterCheckedChanged);
            // 
            // DdlAvailableLabels
            // 
            this.DdlAvailableLabels.FormattingEnabled = true;
            this.DdlAvailableLabels.Location = new System.Drawing.Point(36, 94);
            this.DdlAvailableLabels.Name = "DdlAvailableLabels";
            this.DdlAvailableLabels.Size = new System.Drawing.Size(168, 21);
            this.DdlAvailableLabels.TabIndex = 13;
            // 
            // CbUseCustomLabel
            // 
            this.CbUseCustomLabel.AutoSize = true;
            this.CbUseCustomLabel.Location = new System.Drawing.Point(6, 70);
            this.CbUseCustomLabel.Name = "CbUseCustomLabel";
            this.CbUseCustomLabel.Size = new System.Drawing.Size(154, 17);
            this.CbUseCustomLabel.TabIndex = 12;
            this.CbUseCustomLabel.Text = "Standaard etiket gebruiken";
            this.CbUseCustomLabel.UseVisualStyleBackColor = true;
            this.CbUseCustomLabel.CheckedChanged += new System.EventHandler(this.CbUseCustomLabel_CheckedChanged);
            // 
            // tbxLinks
            // 
            this.tbxLinks.Location = new System.Drawing.Point(67, 18);
            this.tbxLinks.Name = "tbxLinks";
            this.tbxLinks.Size = new System.Drawing.Size(50, 20);
            this.tbxLinks.TabIndex = 12;
            this.tbxLinks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureNumericValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Links";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rechts";
            // 
            // tbxRechts
            // 
            this.tbxRechts.Location = new System.Drawing.Point(67, 38);
            this.tbxRechts.Name = "tbxRechts";
            this.tbxRechts.Size = new System.Drawing.Size(50, 20);
            this.tbxRechts.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxLinks);
            this.groupBox2.Controls.Add(this.tbxRechts);
            this.groupBox2.Controls.Add(this.LabelOverleveringAbsoluut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LabelOverleveringRelatief);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxBoven);
            this.groupBox2.Controls.Add(this.tbxOnder);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 108);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Links";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rechts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxDragerMargeLinks);
            this.groupBox3.Controls.Add(this.tbxDragerMargeRechts);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(183, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 108);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drager";
            // 
            // tbxDragerMargeLinks
            // 
            this.tbxDragerMargeLinks.Location = new System.Drawing.Point(55, 18);
            this.tbxDragerMargeLinks.Name = "tbxDragerMargeLinks";
            this.tbxDragerMargeLinks.Size = new System.Drawing.Size(50, 20);
            this.tbxDragerMargeLinks.TabIndex = 20;
            // 
            // tbxDragerMargeRechts
            // 
            this.tbxDragerMargeRechts.Location = new System.Drawing.Point(55, 38);
            this.tbxDragerMargeRechts.Name = "tbxDragerMargeRechts";
            this.tbxDragerMargeRechts.Size = new System.Drawing.Size(50, 20);
            this.tbxDragerMargeRechts.TabIndex = 21;
            // 
            // DdlFonts
            // 
            this.DdlFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlFonts.FormattingEnabled = true;
            this.DdlFonts.Location = new System.Drawing.Point(79, 151);
            this.DdlFonts.Name = "DdlFonts";
            this.DdlFonts.Size = new System.Drawing.Size(168, 21);
            this.DdlFonts.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lettertype";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DdlFonts);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonAnnuleren);
            this.Controls.Add(this.ButtonOk);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DdlAvailablePrinters;
        private System.Windows.Forms.Label LabelPrinterNotFound;
        private System.Windows.Forms.Label LabelOverleveringAbsoluut;
        private System.Windows.Forms.Label LabelOverleveringRelatief;
        private System.Windows.Forms.TextBox tbxBoven;
        private System.Windows.Forms.TextBox tbxOnder;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonAnnuleren;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DdlAvailableLabels;
        private System.Windows.Forms.CheckBox CbUseCustomLabel;
        private System.Windows.Forms.CheckBox CbUseCustomPrinter;
        private System.Windows.Forms.Label LabelLabelNotFound;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbxLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRechts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxDragerMargeLinks;
        private System.Windows.Forms.TextBox tbxDragerMargeRechts;
        private System.Windows.Forms.ComboBox DdlFonts;
        private System.Windows.Forms.Label label5;
    }
}