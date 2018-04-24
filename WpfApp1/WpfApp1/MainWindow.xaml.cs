using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using MyImagesNS;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> listaImion = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            listaImion.Add("aaa");
            listaImion.Add("bbb");
            listaImion.Add("ccc");
            listaImion.Add("ddd");
            listaImion.Add("eee");

            ListaImion.ItemsSource = listaImion;
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // MessageBox.Show(ListaImion.SelectedItems.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)noweImie.Text != "" && !ListaImion.Items.Contains(noweImie.Text))
                listaImion.Add((string)noweImie.Text);
            // ListaImion.Items.Add((string)noweImie.Text);
            noweImie.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListaImion.SelectedIndex > 0)
                listaImion.RemoveAt(ListaImion.SelectedIndex);
            // ListaImion.Items.RemoveAt(ListaImion.SelectedIndex);
        }
    }
}
