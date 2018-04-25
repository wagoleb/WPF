using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxControl
{
    class PersonData
    {
        static public int counter = 0;
        private int _index;
        public int index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool isSubscribed { get; set; }
        public Uri webSite { get; set; }
        public gender genderType { get; set; }
        public enum gender
        {
            male,
            female
        }
        public PersonData()
        {
            index = ++counter;
        }
    }
}
