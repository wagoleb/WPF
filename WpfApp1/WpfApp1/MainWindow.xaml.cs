﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp1;

namespace ListBoxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pokazWybrane(object sender, SelectionChangedEventArgs e)
        {
            Calendar kalendarz = (Calendar)sender;
            wartosci.Text = "";
            foreach (var item in kalendarz.SelectedDates)
            {
                wartosci.Text += String.Format("{0}\n", item.ToString());
            }
            kombo.ItemsSource = kalendarz.SelectedDates;
        }
    }
}
