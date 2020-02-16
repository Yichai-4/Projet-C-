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
using BE;
using BL;

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour AddGuestRequest.xaml
    /// </summary>
    public partial class GuestRequest : Window
    {

        BE.GuestRequest guest;
        BL.IBL bl;

        public GuestRequest()
        {
            InitializeComponent();

            guest = new BE.GuestRequest();
            this.AddGRGrid.DataContext = guest;
            bl = BL.FactoryBL.Instance;

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
            try
            {
                bl.AddRequest(guest);
                MessageBox.Show("Your request has been successfully registered !  " +
                                "This is your Guest Request Key: " + Convert.ToString(guest.GuestRequestKey), "INFORMATION");
                guest = new BE.GuestRequest();
                this.AddGRGrid.DataContext = guest;

            }
            catch(FormatException)
            {
                MessageBox.Show("check your input and try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if (int.Parse(tbAdults.Text) < 0 || int.Parse(tbChildren.Text) < 0)
            //    MessageBox.Show("Number of adults can't be negative", "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            this.Close();
        }

    }
}
