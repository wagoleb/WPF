using System.Windows.Controls;

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
