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
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour exemple.xaml
    /// </summary>
    public partial class exemple : Window
    {
       //ecrire instance  
       // IBl instance= bl.getinstance();
        private GuestRequest myVar;

        public GuestRequest MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public exemple()
        {
            InitializeComponent();
            this.DataContext = myVar;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
             //try catch que si jamais le bl renvoi une erreur 
             instance.addGuestrequest //ca veut dire va dans bl et soit mafil la fonction add guest request qui elle mm appelle la fonction add guest request de dal 

             */
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource bankBranchViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bankBranchViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // bankBranchViewSource.Source = [source de données générique]
            System.Windows.Data.CollectionViewSource guestRequestViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("guestRequestViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // guestRequestViewSource.Source = [source de données générique]
        }
    }
}
