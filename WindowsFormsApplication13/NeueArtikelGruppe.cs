using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication13
{
    public partial class NeueArtikelGruppe : Form
    {
        OleDbConnection con;
        public NeueArtikelGruppe(OleDbConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void NeueArtikelGruppe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand com;
            com = con.CreateCommand();
            com.CommandText =
                "UPDATE tArtikel SET ArtikelNr = '" + textBox1.Text + "'WHERE ArtikelOid = " + Convert.ToInt32(textBoxArtikelOid.Text)
                ;

            /*          (ArtikelNr, ArtikelGruppe, Bezeichnung, Bestand, Meldebestand, Verpackung, VkPreis, letzteEntnahme)Values('" + textBox1.Text +"','" + textBoxArtikelGruppe.Text + "','" + textBoxBezeichnung.Text + "','" + textBoxBestand.Text + "','" + textBoxMeldebestand.Text + "','" + textBoxVerpackung.Text + "','" + textBoxVkPreis.Text + "','" + textBoxletzteEntnahme.Text + "');";*/
            com.ExecuteNonQuery();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
