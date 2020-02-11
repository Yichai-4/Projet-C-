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
    /// Logique d'interaction pour AddHostingUnit.xaml
    /// </summary>
    public partial class AddHostingUnit : Window
    {
        public AddHostingUnit()
        {
            InitializeComponent();

            areaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Location));
            subAreaComboBox.ItemsSource = Enum.GetValues(typeof(Enums.SubArea));
            typeComboBox.ItemsSource = Enum.GetValues(typeof(Enums.Type));

        }
    }
}
