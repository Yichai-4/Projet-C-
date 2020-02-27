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
    /// Logique d'interaction pour DeleteHostingUnit.xaml
    /// </summary>
    public partial class DeleteHostingUnit : Window
    {
        HostingUnit unit;
        IBL bl;
        public HostingUnit currentUnit;
        public Host currentHost;
        Host host;

        public DeleteHostingUnit()
        {
            InitializeComponent();
            unit = new HostingUnit();
            currentHost = new Host();
            currentHost = host;
            this.DataContext = currentUnit;
            bl = FactoryBL.Instance;
        }

    }
}
