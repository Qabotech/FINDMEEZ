using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppApotheke
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kauf kauf;
        public MainWindow()
        {

            InitializeComponent();
            kauf = (Kauf)this.DataContext;
        }



        private void buttonHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Medikament m = (Medikament)comboBoxAlleMedikamente.SelectedItem;
            bool k = (bool)radioKassenrezept.IsChecked;
            bool p = (bool)radioPrivatrezept.IsChecked;
            kauf.MedikamentHinzufuegen(m, k, p);
        }

        private void buttonKaufen_Click(object sender, RoutedEventArgs e)
        {
            kauf.AuswahlMedikamente.Clear();
            
            MessageBox.Show("Danke Für Ihren Kauf. \n Gesamtpreis: "+kauf.Gesamtpreis, "Apotheke");
        }
    }
}
