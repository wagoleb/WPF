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
    /// Interaction logic for ImagesWithTitles.xaml
    /// </summary>
    public partial class ImagesWithTitles : UserControl
    {
        private double _szerokosc;
        public double szerokosc
        {
            get
            {
                return _szerokosc;
            }
            set
            {
                this._szerokosc = value;
                this.Width = this.szerokosc / 4;
            }
        }
        public ImagesWithTitles()
        {
            InitializeComponent();
        }
    }
}
