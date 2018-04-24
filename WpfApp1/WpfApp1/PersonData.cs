using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class PersonData
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string sex { get; set; }
        public int age { get; set; }

        public PersonData(string name, string surname, string sex, int age)
        {
            this.name = name;
            this.surName = surname;
            this.sex = sex;
            this.age = age;
        }
    }
}
