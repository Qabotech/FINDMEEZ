using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.ComponentModel;


namespace WpfAppApotheke
{
    public class Kauf : INotifyPropertyChanged
    {
        private ObservableCollection<Medikament> alleMedikamente;
        private ObservableCollection<Medikament> auswahlMedikamente;
        public event PropertyChangedEventHandler PropertyChanged;
        public decimal Gesamtpreis { get => gesamtpreis;
            set  { gesamtpreis = value;   }
        }

        private decimal gesamtpreis;

        public ObservableCollection<Medikament> AlleMedikamente
        {
            get { return alleMedikamente; }   
            set { alleMedikamente = value; OnPropertyChanged(new PropertyChangedEventArgs( "AlleMedikamente")); }
        }

        public ObservableCollection<Medikament> AuswahlMedikamente 
        { get => auswahlMedikamente; set => auswahlMedikamente = value; }

        public Kauf ()
        {
            Gesamtpreis = 0;
            AlleDeserialisieren();
            auswahlMedikamente = new ObservableCollection<Medikament>();
        }
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
        public void MedikamentHinzufuegen(Medikament m, bool kassenrezept, bool privatrezept)
        {
            Gesamtpreis += m.ZuzahlungBerechnen(kassenrezept);
            auswahlMedikamente.Add(m);
            OnPropertyChanged(new PropertyChangedEventArgs ("Gesamtpreis"));
        }

        public decimal Kaufen()
        {
            return gesamtpreis;
        }

        public ObservableCollection<Medikament> AlleDeserialisieren()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Medikament>));
            StreamReader reader = new StreamReader("Auswahl.xml");
            alleMedikamente = (ObservableCollection<Medikament>)serializer.Deserialize(reader);
            return alleMedikamente;
        }
    }
}
