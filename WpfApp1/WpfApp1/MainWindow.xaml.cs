using System;
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
            /*
            ApplicationCommands.Close.InputGestures.Add(new KeyGesture(Key.D, ModifierKeys.Control));
            */
            /* ApplicationCommands.Copy.InputGestures.Clear();
            ApplicationCommands.Copy.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control)); */
            EditingCommands.IncreaseFontSize.InputGestures.Add(new KeyGesture(Key.F3, ModifierKeys.Shift | ModifierKeys.Control));
            InitializeComponent();
        }

        private void NewAction(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New file action");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CanExecuteHelpCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExecutedHelpCommand(object sender, ExecutedRoutedEventArgs e)
        {
            HelpWindow helpWindowInst = new HelpWindow();
            helpWindowInst.ShowDialog();
            poleEdycji.AppendText(helpWindowInst.prompt());
        }
    }
}
