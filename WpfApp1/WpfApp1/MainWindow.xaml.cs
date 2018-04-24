using System.Collections.Generic;
using System.Windows;
using MyImagesNS;


namespace WpfApp1
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

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // MessageBox.Show(ListaImion.SelectedItems.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((string)noweImie.Text != "")
                ListaImion.Items.Add((string)noweImie.Text);
            noweImie.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListaImion.SelectedIndex > 0)
                ListaImion.Items.RemoveAt(ListaImion.SelectedIndex);
        }
    }
}
