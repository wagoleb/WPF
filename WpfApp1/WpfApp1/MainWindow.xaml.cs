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
using INotifyPropertychangedOrazInkCanvas;
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

            List<MyImages> images = new List<MyImages>();

            images.Add(new MyImages("ubuntu.jpg", "Ubuntu"));
            images.Add(new MyImages("mint.jpg", "Mint"));
            images.Add(new MyImages("niema.jpg", "Mint"));

            this.DataContext = images;
        }
    }
}
