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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter
        { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            counter = 0;

            Button a = new Button();
            a.Content = "Testowy";
            DefaultGrid.Children.Add(a);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            labelText.Content = counter++;

        }
    }
}
