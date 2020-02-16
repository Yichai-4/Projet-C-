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

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour AddHostingUnit.xaml
    /// </summary>
    public partial class AddHostingUnit : Window
    {
        BE.GuestRequest guest;
        BL.IBL bl;

        public AddHostingUnit()
        {
            InitializeComponent();

            guest = new BE.GuestRequest();
            this.AddHUGrid.DataContext = guest;
            bl = BL.FactoryBL.Instance;

            typeComboBox.SelectedIndex = 0;
            subAreaComboBox.SelectedIndex = 0;
            areaComboBox.SelectedIndex = 0;

            areaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Location));
            subAreaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.SubArea));
            typeComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Type));

        }

        private void ButtonADD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddRequest(guest);
                guest = new BE.GuestRequest();
                this.AddHUGrid.DataContext = guest;

            }
            catch (FormatException)
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
