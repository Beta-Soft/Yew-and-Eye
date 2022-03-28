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
using Microsoft.Maps.MapControl.WPF;
namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MapsWindow.xaml
    /// </summary>
    public partial class MapsWindow : Window
    {
        public MapsWindow()
        {
            InitializeComponent();

            PlansMap.Mode = new AerialMode(true);
            //MapsWindow mapsWindows = new MapsWindow();
            //this.Hide();
            //mapsWindows.ShowDialog();
        }


    }
}
