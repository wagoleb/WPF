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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // InkEditingMode editingModes = new InkEditingMode();
        public MainWindow()
        {
            InitializeComponent();

           // this.DataContext = editingModes;
        }

        private void selection_Click(object sender, RoutedEventArgs e)
        {
            //  editingModes.editingMode = InkCanvasEditingMode.Select;
            (this.Resources["EditingModes"] as InkEditingMode).editingMode = InkCanvasEditingMode.Select;
        }

        private void drawing_Click(object sender, RoutedEventArgs e)
        {
            //  editingModes.editingMode = InkCanvasEditingMode.Ink;
            (this.Resources["EditingModes"] as InkEditingMode).editingMode = InkCanvasEditingMode.Ink;
        }
    }
}
