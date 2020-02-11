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
using BL;

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour AddGuestRequest.xaml
    /// </summary>
    public partial class GuestRequest : Window
    {
        IBL instance = Factory.Instance;

        private GuestRequest myVar;

        public GuestRequest MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public GuestRequest()
        {
            InitializeComponent();
            this.DataContext = myVar;

            typeComboBox.SelectedIndex = 0;
            subAreaComboBox.SelectedIndex = 0;
            fitnessRoomComboBox.SelectedIndex = 0;
            synagogueComboBox.SelectedIndex = 0;
            jacuzziComboBox.SelectedIndex = 0;
            gardenComboBox.SelectedIndex = 0;
            poolComboBox.SelectedIndex = 0;
            areaComboBox.SelectedIndex = 0;
            childrenAttractionsComboBox.SelectedIndex = 0;
            poolComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            jacuzziComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            gardenComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            childrenAttractionsComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            areaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Area));
            typeComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Type));
            subAreaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.SubArea));
            synagogueComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            fitnessRoomComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            instance.addrequest(myVar);
            //if (int.Parse(tbAdults.Text) < 0 || int.Parse(tbChildren.Text) < 0)
            //    MessageBox.Show("Number of adults can't be negative", "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // guestRequestViewSource.Source = [source de données générique]
            //System.Windows.Data.CollectionViewSource guestRequestViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("guestRequestViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // guestRequestViewSource.Source = [source de données générique]
        }
    }
}
