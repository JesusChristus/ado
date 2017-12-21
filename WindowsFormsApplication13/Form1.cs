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
    public partial class Form1 : Form
    {
        
        OleDbConnection con;
        List<Artikel> artikelListe;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = Properties.Settings.Default.DBPfad;
        }

        private void buttonConnectionÖffnen_Click(object sender, EventArgs e)
        {
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand com;
            com = con.CreateCommand();
            com.CommandText = "tArtikel";
            com.CommandType = CommandType.TableDirect;
            toolStripLabel1.Text = "Command abgesetzt";
            OleDbDataReader dr = com.ExecuteReader();
            artikelListe = new List<Artikel>();
            while (dr.Read())
            {
                artikelListe.Add(new Artikel(Convert.ToInt32(check(dr[0])), Convert.ToInt32(check(dr[1])), Convert.ToString(check(dr[2])), Convert.ToString(check(dr[3])), Convert.ToInt32(check(dr[4])), Convert.ToInt32(check(dr[5])), Convert.ToString(check(dr[6])), Convert.ToDecimal(check(dr[7])), Convert.ToDateTime(check(dr[8]))));
                
            }
            listBox1.DataSource = artikelListe;
        }
        
        private object check(object o)
        {
            if (o != DBNull.Value)
            {
                return o;
            }
            else
            {
                return null;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddObjekt_Click(object sender, EventArgs e)
        {
            NeueArtikelGruppe frmArtGrp = new NeueArtikelGruppe(this.con);
            frmArtGrp.Show();
        }
    }
}
