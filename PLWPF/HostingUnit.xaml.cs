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
    /// Logique d'interaction pour HostingUnit.xaml
    /// </summary>
    public partial class HostingUnit : Window
    {
        public HostingUnit()
        {
            InitializeComponent();
            //cbHostingUnit.ItemsSource = Enum.GetValues(typeof(Enums.HostingUnit));
        }

        private void buttonAddHU_Click(object sender, RoutedEventArgs e)
        {
            new Password().ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new PersonalArea().ShowDialog();
            //new Password().ShowDialog();
        }

        private void buttonAddHost_Click(object sender, RoutedEventArgs e)
        {
            new AddHost().ShowDialog();
        }
    }

}
