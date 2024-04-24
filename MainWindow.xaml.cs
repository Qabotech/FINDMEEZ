using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppADO_Autovermietung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listBoxKunden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Kunde auswahl = (Kunde)listBoxKunden.SelectedItem;

            Tvorname.Text = auswahl.Name;
            Tnachname.Text = auswahl.Nachname;
            Tstrasse.Text = auswahl.Strasse;
            Tplz.Text = auswahl.Plz;
            Tort.Text = auswahl.Ort;
            Ttelefon.Text = auswahl.Telefon;
        }
    }
}
