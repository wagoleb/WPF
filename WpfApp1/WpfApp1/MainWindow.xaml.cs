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

            List<MyImages> images = new List<MyImages>();

            images.Add(new MyImages("ubuntu.jpg", "Ubuntu"));
            images.Add(new MyImages("mint.jpg", "Mint"));
            images.Add(new MyImages("niema.jpg", "Mint"));
            images.Add(new MyImages("mint.jpg", "Mint"));
            images.Add(new MyImages("niema.jpg", "Mint"));
            images.Add(new MyImages("ubuntu.jpg", "Ubuntu"));
            images.Add(new MyImages("mint.jpg", "Mint"));
            images.Add(new MyImages("niema.jpg", "Mint"));

            this.DataContext = images;
        }
    }
}
