using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WpfAppADO_Autovermietung
{
    public class Autovermietung
    {
        private ObservableCollection<Kunde> listKunde;
        private ObservableCollection<Wagen> listWagen;

        public ObservableCollection<Kunde> ListKunde { get => listKunde; set => listKunde = value; }
        public ObservableCollection<Wagen> ListWagen { get => listWagen; set => listWagen = value; }

        public Autovermietung()
        {
            listKunde = new ObservableCollection<Kunde>();
            listWagen = new ObservableCollection<Wagen>();

            dbLesenKunde();
            dbLeseneWagen();
        }

        private void dbLeseneWagen()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DBPath);
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Abfrage1";
            cmd.CommandType = CommandType.TableDirect;
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string kennzeiche = reader.GetString(1);
                int kmStand = reader.GetInt32(2);
                string bauJahr = reader.GetString(3);
                bool vermietet = reader.GetBoolean(4);
                int kategorieNr = reader.GetInt32(5);
                string kategorieBez = reader.GetString(6);
                decimal kmPauschal = reader.GetDecimal(7);
                int typNr = reader.GetInt32(8);
                string typBez = reader.GetString(9);
                decimal tagPauschal = reader.GetDecimal(10);

                Wagen neu = new Wagen();

                neu.ID = id;
                neu.Kennzeiche = kennzeiche;
                neu.KmStand = kmStand;
                neu.BauJahr = bauJahr;
                neu.Vermietet = vermietet;
                neu.KategorieNr = kategorieNr;
                neu.KategorieBez = kategorieBez;
                neu.KmPauschal = kmPauschal;
                neu.TypNr = typNr;
                neu.TypBez = typBez;
                neu.TagPauschal = tagPauschal;

                ListWagen.Add(neu);
            }
            conn.Close();
            reader.Close();
        }

        private void dbLesenKunde()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DBPath);
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "tKunde";
            cmd.CommandType = CommandType.TableDirect;
            OleDbDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string nachname = reader.GetString(2);
                string strasse = reader.GetString(3);
                string plz = reader.GetString(4);
                string ort = reader.GetString(5);
                string telefon = reader.GetString(6);


                Kunde kunde = new Kunde();
                kunde.ID = id;
                kunde.Name = name;
                kunde.Nachname = nachname;
                kunde.Plz = plz;
                kunde.Ort = ort;
                kunde.Strasse = strasse;
                kunde.Telefon = telefon;
           
                listKunde.Add(kunde);
            }
            conn.Close();
            reader.Close();
        }
    }
}
