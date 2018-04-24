﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MyImagesNS;
using System.ComponentModel;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> listaImion = new ObservableCollection<PersonData>();

        public MainWindow()
        {
            InitializeComponent();

            listaImion.Add(new PersonData("wojtke", "golebiewski", "male", 39));
            listaImion.Add(new PersonData("adam", "solski", "female", 12));
            listaImion.Add(new PersonData("karol", "kowalski", "male", 23));
            listaImion.Add(new PersonData("michal", "minke", "female", 56));
            listaImion.Add(new PersonData("lukasz", "radtke", "male", 19));

            ListaImion.ItemsSource = listaImion;
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // MessageBox.Show(ListaImion.SelectedItems.ToString());
            Console.WriteLine("w pizde jebana czemu tu?");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (noweImie.Text != "" && noweNazwisko.Text != "" && nowaPlec.Text != "" && nowyWiek.Text != "")
                listaImion.Add(new PersonData(noweImie.Text, noweNazwisko.Text, nowaPlec.Text, Convert.ToInt32(nowyWiek.Text)));
            // ListaImion.Items.Add((string)noweImie.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListaImion.SelectedIndex >= 0)
                listaImion.RemoveAt(ListaImion.SelectedIndex);
            // ListaImion.Items.RemoveAt(ListaImion.SelectedIndex);
        }

        private void LetsSortThisShit(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("KURWA CHUJ");
            GridViewColumnHeader header = (sender as GridViewColumnHeader);
            string columnToSort = header.Content.ToString();

            CollectionView defaultView = (CollectionView)CollectionViewSource.GetDefaultView(ListaImion.ItemsSource);
            ListSortDirection howToSort = ListSortDirection.Ascending;

            Console.WriteLine(defaultView.SortDescriptions.Count);

            defaultView.SortDescriptions.Clear();
            defaultView.SortDescriptions.Add(new SortDescription(columnToSort, howToSort));
        }
    }
}
