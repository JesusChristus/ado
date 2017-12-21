using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication13
{
    class Artikel
    {
        private int id;
        private int nummer;
        private string artgp;
        private string bezeichnung;
        private int bestand;
        private int meldeBestand;
        private string verpackung;
        private decimal verkufspreis;
        private DateTime letzteEntnahme;

        public Artikel(int id, int nummer, string artgp, string bezeichnung, int bestand, int meldeBestand, string verpackung, decimal verkufspreis, DateTime letzteEntnahme)
        {
            this.id = id;
            this.nummer = nummer;
            this.artgp = artgp;
            this.bezeichnung = bezeichnung;
            this.bestand = bestand;
            this.meldeBestand = meldeBestand;
            this.verpackung = verpackung;
            this.verkufspreis = verkufspreis;
            this.letzteEntnahme = letzteEntnahme;
        }

        public override string ToString()
        {
            return bezeichnung;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Nummer
        {
            get
            {
                return nummer;
            }

            set
            {
                nummer = value;
            }
        }

        public string Artgp
        {
            get
            {
                return artgp;
            }

            set
            {
                artgp = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public int Bestand
        {
            get
            {
                return bestand;
            }

            set
            {
                bestand = value;
            }
        }

        public int MeldeBestand
        {
            get
            {
                return meldeBestand;
            }

            set
            {
                meldeBestand = value;
            }
        }

        public string Verpackung
        {
            get
            {
                return verpackung;
            }

            set
            {
                verpackung = value;
            }
        }

        public decimal Verkufspreis
        {
            get
            {
                return verkufspreis;
            }

            set
            {
                verkufspreis = value;
            }
        }

        public DateTime LetzteEntnahme
        {
            get
            {
                return letzteEntnahme;
            }

            set
            {
                letzteEntnahme = value;
            }
        }
    }
}
