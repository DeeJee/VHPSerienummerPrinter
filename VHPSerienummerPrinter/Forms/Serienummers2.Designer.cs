namespace VHPSerienummerPrinter
{
    partial class Serienummers2
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
            this.Item1Selection = new System.Windows.Forms.ComboBox();
            this.Item2Selection = new System.Windows.Forms.ComboBox();
            this.Item3Selection = new System.Windows.Forms.ComboBox();
            this.Item4Selection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Afdrukken.Location = new System.Drawing.Point(12, 394);
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
            this.LabelAantalInSelectie.Location = new System.Drawing.Point(174, 399);
            this.LabelAantalInSelectie.Name = "LabelAantalInSelectie";
            this.LabelAantalInSelectie.Size = new System.Drawing.Size(125, 13);
            this.LabelAantalInSelectie.TabIndex = 21;
            this.LabelAantalInSelectie.Text = "geen labels geselecteerd";
            // 
            // Voorbeeld
            // 
            this.Voorbeeld.Location = new System.Drawing.Point(93, 394);
            this.Voorbeeld.Name = "Voorbeeld";
            this.Voorbeeld.Size = new System.Drawing.Size(75, 23);
            this.Voorbeeld.TabIndex = 22;
            this.Voorbeeld.Text = "Voorbeeld";
            this.Voorbeeld.UseVisualStyleBackColor = true;
            this.Voorbeeld.Click += new System.EventHandler(this.Voorbeeld_Click);
            // 
            // Item1Selection
            // 
            this.Item1Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item1Selection.FormattingEnabled = true;
            this.Item1Selection.Location = new System.Drawing.Point(128, 19);
            this.Item1Selection.Name = "Item1Selection";
            this.Item1Selection.Size = new System.Drawing.Size(121, 21);
            this.Item1Selection.TabIndex = 15;
            // 
            // Item2Selection
            // 
            this.Item2Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item2Selection.FormattingEnabled = true;
            this.Item2Selection.Location = new System.Drawing.Point(128, 46);
            this.Item2Selection.Name = "Item2Selection";
            this.Item2Selection.Size = new System.Drawing.Size(121, 21);
            this.Item2Selection.TabIndex = 23;
            // 
            // Item3Selection
            // 
            this.Item3Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item3Selection.FormattingEnabled = true;
            this.Item3Selection.Location = new System.Drawing.Point(128, 73);
            this.Item3Selection.Name = "Item3Selection";
            this.Item3Selection.Size = new System.Drawing.Size(121, 21);
            this.Item3Selection.TabIndex = 24;
            // 
            // Item4Selection
            // 
            this.Item4Selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item4Selection.FormattingEnabled = true;
            this.Item4Selection.Location = new System.Drawing.Point(128, 100);
            this.Item4Selection.Name = "Item4Selection";
            this.Item4Selection.Size = new System.Drawing.Size(121, 21);
            this.Item4Selection.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Item4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Item3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Item2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Item1Selection);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Item2Selection);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Item3Selection);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Item4Selection);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 131);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // Serienummers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Voorbeeld);
            this.Controls.Add(this.LabelAantalInSelectie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelAantalItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Afdrukken);
            this.Name = "Serienummers2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serienummerlabels";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Serienummers_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox Item1Selection;
        private System.Windows.Forms.ComboBox Item2Selection;
        private System.Windows.Forms.ComboBox Item3Selection;
        private System.Windows.Forms.ComboBox Item4Selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

