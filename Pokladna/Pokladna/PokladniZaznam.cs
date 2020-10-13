using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
     public class PokladniZaznam
    {
        public int IdPokladniZaznam { get; set; }

        public int CisloDokladu { get; set; }

        public DateTime Datum { get; set; }

        public string Popis { get; set; }

        public double Castka { get; set; }

        public double Zustatek { get; set; }

        public string Poznamka { get; set; }

        public PokladniZaznam()
        {

        }

        public PokladniZaznam(int idPokladniZaznam, int cisloDokladu, DateTime datum, string popis, double castka, double zustatek, string poznamka)
        {
            IdPokladniZaznam = idPokladniZaznam;
            CisloDokladu = cisloDokladu;
            Datum = datum;
            Popis = popis;
            Castka = castka;
            Zustatek = zustatek;
            Poznamka = poznamka;
        }

        public ListViewItem DolvItem()
        {
            if(Castka>0)
            {
                return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy"), CisloDokladu.ToString(),Popis,Castka.ToString(),"",Zustatek.ToString(),Poznamka});
            }
            else
            {
                return new ListViewItem(new string[] { Datum.ToString("dd.MM.yyyy"), CisloDokladu.ToString(), Popis,"", Math.Abs(Castka).ToString(), Zustatek.ToString(), Poznamka });
            }
        }
    }
}
