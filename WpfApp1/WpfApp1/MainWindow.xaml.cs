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
using System.Windows.Threading;
using WpfApp1;

namespace ListBoxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer positionTimer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayFunc(object sender, RoutedEventArgs e)
        {
            videoClip.Play();
        }

        private void PauseFunc(object sender, RoutedEventArgs e)
        {
            videoClip.Pause();
        }

        private void StopFunc(object sender, RoutedEventArgs e)
        {
            videoClip.Stop();
        }

        private void videoClipMediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }

        private void startScreen(object sender, RoutedEventArgs e)
        {
            videoClip.ScrubbingEnabled = true;
            videoClip.Stop();
        }

        private void videoClipOpened(object sender, RoutedEventArgs e)
        {
            position.Maximum = videoClip.NaturalDuration.TimeSpan.TotalSeconds;
            positionTimer = new DispatcherTimer();
            positionTimer.Interval = TimeSpan.FromSeconds(1);
            positionTimer.Tick += PositionTimer_Tick;
            positionTimer.Start();
        }

        private void PositionTimer_Tick(object sender, EventArgs e)
        {
            position.Value = videoClip.Position.TotalSeconds;
        }

        private void changeVideoPostion(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            videoClip.Position = TimeSpan.FromSeconds(position.Value);
        }
    }
}
