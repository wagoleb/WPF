using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImages
{
    class MyImages
    {
        public string pathToImage { get; set; }
        public string nameOfImage { get; set; }
        public bool isFound { get; set; }

        public MyImages()
        {
            this.pathToImage = @"C:\repos\WPF\WpfApp1\WpfApp1\ubuntu.jpg";
            this.nameOfImage = "UBUNTU";
        }
    }
}
