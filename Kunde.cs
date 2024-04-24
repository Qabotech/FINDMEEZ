using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppADO_Autovermietung
{
    public class Kunde
    {
        private int id;
        private string name;
        private string nachname;
        private string strasse;
        private string plz;
        private string ort;
        private string telefon;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return name + " " + nachname;
        }
    }
}
