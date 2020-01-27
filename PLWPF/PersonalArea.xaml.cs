﻿using System;
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
    /// Logique d'interaction pour PersonalArea.xaml
    /// </summary>
    public partial class PersonalArea : Window
    {
        public PersonalArea()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, RoutedEventArgs e)
        {
            new Order().ShowDialog();
        }
    }
}
