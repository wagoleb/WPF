using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MyImagesNS;

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

        private List<MyImages> _imagesPaths;

        public List<MyImages> ImagesPathes
        {
            get
            {
                return this._imagesPaths;
            }
            set
            {
                this._imagesPaths = value;
            }
        }

        public static readonly DependencyProperty ImagesPathesProperty = DependencyProperty.Register(
            "ImagesPathes", // wyslana nazwa property
            typeof(List<MyImages>), //typ 
            typeof(ImagesWithTitles),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback((s, e) => 
                {
                    var source = s as ImagesWithTitles;
                    source.itemsCControl.ItemsSource = (List<MyImages>)e.NewValue;
                }
    ))
            );

        public ImagesWithTitles()
        {
            InitializeComponent();
        }
    }
}
