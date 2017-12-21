namespace WindowsFormsApplication13
{
    partial class NeueArtikelGruppe
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArtikelNr = new System.Windows.Forms.Label();
            this.textBoxArtikelGruppe = new System.Windows.Forms.TextBox();
            this.textBoxBestand = new System.Windows.Forms.TextBox();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxVerpackung = new System.Windows.Forms.TextBox();
            this.textBoxMeldebestand = new System.Windows.Forms.TextBox();
            this.textBoxVkPreis = new System.Windows.Forms.TextBox();
            this.textBoxletzteEntnahme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArtikelOid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "ändern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ArtikelNr
            // 
            this.ArtikelNr.AutoSize = true;
            this.ArtikelNr.Location = new System.Drawing.Point(207, 69);
            this.ArtikelNr.Name = "ArtikelNr";
            this.ArtikelNr.Size = new System.Drawing.Size(47, 13);
            this.ArtikelNr.TabIndex = 2;
            this.ArtikelNr.Text = "ArtikelNr";
            this.ArtikelNr.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxArtikelGruppe
            // 
            this.textBoxArtikelGruppe.Location = new System.Drawing.Point(306, 92);
            this.textBoxArtikelGruppe.Name = "textBoxArtikelGruppe";
            this.textBoxArtikelGruppe.Size = new System.Drawing.Size(131, 20);
            this.textBoxArtikelGruppe.TabIndex = 12;
            // 
            // textBoxBestand
            // 
            this.textBoxBestand.Location = new System.Drawing.Point(306, 145);
            this.textBoxBestand.Name = "textBoxBestand";
            this.textBoxBestand.Size = new System.Drawing.Size(131, 20);
            this.textBoxBestand.TabIndex = 13;
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(306, 118);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(131, 20);
            this.textBoxBezeichnung.TabIndex = 14;
            // 
            // textBoxVerpackung
            // 
            this.textBoxVerpackung.Location = new System.Drawing.Point(306, 194);
            this.textBoxVerpackung.Name = "textBoxVerpackung";
            this.textBoxVerpackung.Size = new System.Drawing.Size(131, 20);
            this.textBoxVerpackung.TabIndex = 15;
            // 
            // textBoxMeldebestand
            // 
            this.textBoxMeldebestand.Location = new System.Drawing.Point(306, 168);
            this.textBoxMeldebestand.Name = "textBoxMeldebestand";
            this.textBoxMeldebestand.Size = new System.Drawing.Size(131, 20);
            this.textBoxMeldebestand.TabIndex = 16;
            // 
            // textBoxVkPreis
            // 
            this.textBoxVkPreis.Location = new System.Drawing.Point(306, 220);
            this.textBoxVkPreis.Name = "textBoxVkPreis";
            this.textBoxVkPreis.Size = new System.Drawing.Size(131, 20);
            this.textBoxVkPreis.TabIndex = 18;
            // 
            // textBoxletzteEntnahme
            // 
            this.textBoxletzteEntnahme.Location = new System.Drawing.Point(306, 246);
            this.textBoxletzteEntnahme.Name = "textBoxletzteEntnahme";
            this.textBoxletzteEntnahme.Size = new System.Drawing.Size(131, 20);
            this.textBoxletzteEntnahme.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ArtikelGruppe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bezeichnung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bestand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Meldebestand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Verpackung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "letzteEntnahme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "VkPreis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ArtikelOid";
            // 
            // textBoxArtikelOid
            // 
            this.textBoxArtikelOid.Location = new System.Drawing.Point(306, 41);
            this.textBoxArtikelOid.Name = "textBoxArtikelOid";
            this.textBoxArtikelOid.Size = new System.Drawing.Size(131, 20);
            this.textBoxArtikelOid.TabIndex = 28;
            // 
            // NeueArtikelGruppe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 402);
            this.Controls.Add(this.textBoxArtikelOid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxletzteEntnahme);
            this.Controls.Add(this.textBoxVkPreis);
            this.Controls.Add(this.textBoxMeldebestand);
            this.Controls.Add(this.textBoxVerpackung);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.textBoxBestand);
            this.Controls.Add(this.textBoxArtikelGruppe);
            this.Controls.Add(this.ArtikelNr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "NeueArtikelGruppe";
            this.Text = "NeueArtikelGruppe";
            this.Load += new System.EventHandler(this.NeueArtikelGruppe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ArtikelNr;
        private System.Windows.Forms.TextBox textBoxArtikelGruppe;
        private System.Windows.Forms.TextBox textBoxBestand;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxVerpackung;
        private System.Windows.Forms.TextBox textBoxMeldebestand;
        private System.Windows.Forms.TextBox textBoxVkPreis;
        private System.Windows.Forms.TextBox textBoxletzteEntnahme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtikelOid;
    }
}