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
    /// Logique d'interaction pour AddHost.xaml
    /// </summary>
    public partial class AddHost : Window
    {
        BE.Host host;
        BL.IBL bl;

        public AddHost()
        {
            InitializeComponent();

            host = new BE.Host();
            this.AddHostGrid.DataContext = host;
            bl = BL.FactoryBL.Instance;
        }

        private void AddHU_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //bl.AddHost(host);
                MessageBox.Show("Your inscription has been successfully registered !  " +
                                "This is your Hostt Key: " + Convert.ToString(host.HostKey), "INFORMATION");
                host = new BE.Host();
                this.AddHostGrid.DataContext = host;

            }
            catch (FormatException)
            {
                MessageBox.Show("check your input and try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
