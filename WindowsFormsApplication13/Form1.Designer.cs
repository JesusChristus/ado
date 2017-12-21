namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnectionÖffnen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.command = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.buttonAddObjekt = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnectionÖffnen
            // 
            this.buttonConnectionÖffnen.Location = new System.Drawing.Point(12, 42);
            this.buttonConnectionÖffnen.Name = "buttonConnectionÖffnen";
            this.buttonConnectionÖffnen.Size = new System.Drawing.Size(260, 23);
            this.buttonConnectionÖffnen.TabIndex = 0;
            this.buttonConnectionÖffnen.Text = "open datasource";
            this.buttonConnectionÖffnen.UseVisualStyleBackColor = true;
            this.buttonConnectionÖffnen.Click += new System.EventHandler(this.buttonConnectionÖffnen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "close datasource";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(13, 136);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(258, 23);
            this.command.TabIndex = 3;
            this.command.Text = "buttonCommand";
            this.command.UseVisualStyleBackColor = true;
            this.command.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 69);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // buttonAddObjekt
            // 
            this.buttonAddObjekt.Location = new System.Drawing.Point(12, 71);
            this.buttonAddObjekt.Name = "buttonAddObjekt";
            this.buttonAddObjekt.Size = new System.Drawing.Size(260, 23);
            this.buttonAddObjekt.TabIndex = 6;
            this.buttonAddObjekt.Text = "objekt bearbeiten";
            this.buttonAddObjekt.UseVisualStyleBackColor = true;
            this.buttonAddObjekt.Click += new System.EventHandler(this.buttonAddObjekt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 261);
            this.Controls.Add(this.buttonAddObjekt);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.command);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConnectionÖffnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectionÖffnen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button command;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button buttonAddObjekt;
    }
}

