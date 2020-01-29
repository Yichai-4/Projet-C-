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
    /// Logique d'interaction pour AddGuestRequest.xaml
    /// </summary>
    public partial class GuestRequest : Window
    {
        public GuestRequest()
        {
            InitializeComponent();
            cbPool.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            cbJacuzzi.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            cbGarden.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            cbAttractions.ItemsSource = Enum.GetValues(typeof(Enums.Pool));
            cbArea.ItemsSource = Enum.GetValues(typeof(Enums.Area));
            cbType.ItemsSource = Enum.GetValues(typeof(Enums.Type));
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            //if (int.Parse(tbAdults.Text) < 0 || int.Parse(tbChildren.Text) < 0)
            //    MessageBox.Show("Number of adults can't be negative", "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            this.Close();
        }


    }
}
