using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppADO_Autovermietung
{
    public class Wagen
    {
        private int id;
        private string kennzeiche;
        private int kmStand;
        private string bauJahr;
        private bool vermietet;
        private int kategorieNr;
        private string kategorieBez;
        private decimal kmPauschal;
        private int typNr;
        private string typBez;
        private decimal tagPauschal;

        public int ID { get => id; set => id = value; }
        public string Kennzeiche { get => kennzeiche; set => kennzeiche = value; }
        public int KmStand { get => kmStand; set => kmStand = value; }
        public string BauJahr { get => bauJahr; set => bauJahr = value; }
        public bool Vermietet { get => vermietet; set => vermietet = value; }
        public int KategorieNr { get => kategorieNr; set => kategorieNr = value; }
        public string KategorieBez { get => kategorieBez; set => kategorieBez = value; }
        public decimal KmPauschal { get => kmPauschal; set => kmPauschal = value; }
        public int TypNr { get => typNr; set => typNr = value; }
        public string TypBez { get => typBez; set => typBez = value; }
        public decimal TagPauschal { get => tagPauschal; set => tagPauschal = value; }
    }
}
