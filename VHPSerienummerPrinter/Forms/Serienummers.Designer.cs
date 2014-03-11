namespace VHPSerienummerPrinter
{
    partial class Serienummers
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.LabelTotEnMet = new System.Windows.Forms.Label();
            this.LabelAfdrukkenVan = new System.Windows.Forms.Label();
            this.DdlVan = new System.Windows.Forms.ComboBox();
            this.DdlTotEnMet = new System.Windows.Forms.ComboBox();
            this.Afdrukken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelAantalItems = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelAantalInSelectie = new System.Windows.Forms.Label();
            this.Voorbeeld = new System.Windows.Forms.Button();
            this.LabelPreview = new VhpControls.PreviewControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // LabelTotEnMet
            // 
            this.LabelTotEnMet.AutoSize = true;
            this.LabelTotEnMet.Location = new System.Drawing.Point(9, 51);
            this.LabelTotEnMet.Name = "LabelTotEnMet";
            this.LabelTotEnMet.Size = new System.Drawing.Size(58, 13);
            this.LabelTotEnMet.TabIndex = 8;
            this.LabelTotEnMet.Text = "Tot en met";
            // 
            // LabelAfdrukkenVan
            // 
            this.LabelAfdrukkenVan.AutoSize = true;
            this.LabelAfdrukkenVan.Location = new System.Drawing.Point(9, 27);
            this.LabelAfdrukkenVan.Name = "LabelAfdrukkenVan";
            this.LabelAfdrukkenVan.Size = new System.Drawing.Size(26, 13);
            this.LabelAfdrukkenVan.TabIndex = 7;
            this.LabelAfdrukkenVan.Text = "Van";
            // 
            // DdlVan
            // 
            this.DdlVan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlVan.FormattingEnabled = true;
            this.DdlVan.Location = new System.Drawing.Point(128, 19);
            this.DdlVan.Name = "DdlVan";
            this.DdlVan.Size = new System.Drawing.Size(121, 21);
            this.DdlVan.TabIndex = 13;
            this.DdlVan.SelectedIndexChanged += new System.EventHandler(this.VanSelectedIndexChanged);
            // 
            // DdlTotEnMet
            // 
            this.DdlTotEnMet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlTotEnMet.FormattingEnabled = true;
            this.DdlTotEnMet.Location = new System.Drawing.Point(128, 46);
            this.DdlTotEnMet.Name = "DdlTotEnMet";
            this.DdlTotEnMet.Size = new System.Drawing.Size(121, 21);
            this.DdlTotEnMet.TabIndex = 14;
            this.DdlTotEnMet.SelectedIndexChanged += new System.EventHandler(this.TotEnMetSelectedIndexChanged);
            // 
            // Afdrukken
            // 
            this.Afdrukken.Location = new System.Drawing.Point(12, 272);
            this.Afdrukken.Name = "Afdrukken";
            this.Afdrukken.Size = new System.Drawing.Size(75, 23);
            this.Afdrukken.TabIndex = 15;
            this.Afdrukken.Text = "Afdrukken";
            this.Afdrukken.UseVisualStyleBackColor = true;
            this.Afdrukken.Click += new System.EventHandler(this.Afdrukken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product:";
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Location = new System.Drawing.Point(128, 115);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(10, 13);
            this.LabelProduct.TabIndex = 17;
            this.LabelProduct.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aantal items";
            // 
            // LabelAantalItems
            // 
            this.LabelAantalItems.AutoSize = true;
            this.LabelAantalItems.Location = new System.Drawing.Point(126, 132);
            this.LabelAantalItems.Name = "LabelAantalItems";
            this.LabelAantalItems.Size = new System.Drawing.Size(10, 13);
            this.LabelAantalItems.TabIndex = 19;
            this.LabelAantalItems.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DdlVan);
            this.groupBox1.Controls.Add(this.LabelAfdrukkenVan);
            this.groupBox1.Controls.Add(this.LabelTotEnMet);
            this.groupBox1.Controls.Add(this.DdlTotEnMet);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 77);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "bereik";
            // 
            // LabelAantalInSelectie
            // 
            this.LabelAantalInSelectie.AutoSize = true;
            this.LabelAantalInSelectie.Location = new System.Drawing.Point(174, 277);
            this.LabelAantalInSelectie.Name = "LabelAantalInSelectie";
            this.LabelAantalInSelectie.Size = new System.Drawing.Size(125, 13);
            this.LabelAantalInSelectie.TabIndex = 21;
            this.LabelAantalInSelectie.Text = "geen labels geselecteerd";
            // 
            // Voorbeeld
            // 
            this.Voorbeeld.Location = new System.Drawing.Point(93, 272);
            this.Voorbeeld.Name = "Voorbeeld";
            this.Voorbeeld.Size = new System.Drawing.Size(75, 23);
            this.Voorbeeld.TabIndex = 22;
            this.Voorbeeld.Text = "Voorbeeld";
            this.Voorbeeld.UseVisualStyleBackColor = true;
            this.Voorbeeld.Click += new System.EventHandler(this.Voorbeeld_Click);
            // 
            // LabelPreview
            // 
            this.LabelPreview.DragerMargeLinks = 0F;
            this.LabelPreview.DragerMargeRechts = 0F;
            this.LabelPreview.ItemFont = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.LabelPreview.LabelMargeBoven = 0F;
            this.LabelPreview.LabelMargeLinks = 0F;
            this.LabelPreview.LabelMargeOnder = 0F;
            this.LabelPreview.LabelMargeRechts = 0F;
            this.LabelPreview.Location = new System.Drawing.Point(0, 0);
            this.LabelPreview.MaxBreedteLogo = 0F;
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Product = null;
            this.LabelPreview.Size = new System.Drawing.Size(340, 92);
            this.LabelPreview.TabIndex = 23;
            this.LabelPreview.Text = "previewControl1";
            this.LabelPreview.TitelFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            // 
            // Serienummers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 329);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.Voorbeeld);
            this.Controls.Add(this.LabelAantalInSelectie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelAantalItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Afdrukken);
            this.Name = "Serienummers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serienummerlabels";
            this.Load += new System.EventHandler(this.Serienummers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label LabelTotEnMet;
        private System.Windows.Forms.Label LabelAfdrukkenVan;
        private System.Windows.Forms.ComboBox DdlVan;
        private System.Windows.Forms.ComboBox DdlTotEnMet;
        private System.Windows.Forms.Button Afdrukken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelAantalItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelAantalInSelectie;
        private System.Windows.Forms.Button Voorbeeld;
        private VhpControls.PreviewControl LabelPreview;
    }
}

