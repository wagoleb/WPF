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

        public List<MyImages> ImagesPathes
        {
            get
            {
                return (List<MyImages>)GetValue(ImagesPathesProperty);
            }
            set
            {
                SetValue(ImagesPathesProperty, value);
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


        /* dep prop z automatu ze snipetu propd

        public List<MyImages> myImages
        {
            get { return (List<MyImages>)GetValue(myImagesProperty); }
            set { SetValue(myImagesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myImages.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty myImagesProperty =
            DependencyProperty.Register("myImages", typeof(List<MyImages>), typeof(ImagesWithTitles), new PropertyMetadata(0));

        */

        public ImagesWithTitles()
        {
            InitializeComponent();
        }
    }
}
