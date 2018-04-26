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

namespace ListBoxControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> listOfPeople = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();

            listOfPeople.Add(new PersonData() { Name = "Arek", Age = 26, Email = "arek@gmail.com", genderType = PersonData.gender.female, description = "Desc for Arek, age 26, arek@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Michal", Age = 18, Email = "michal@gmail.com", Image = "ubuntu.jpg", description = "Desc for Michal, age 18, email: michal@google.com" });
            listOfPeople.Add(new PersonData() { Name = "Bolek", Age = 36, Email = "bolek@wp.pl", genderType = PersonData.gender.female, isSubscribed = true, Image = "mint.jpg", description = "Desc for Bolek." });
            listOfPeople.Add(new PersonData() { Name = "Wiola", Age = 20, Email = "wiola@onet.pl", webSite = new Uri("http://google.pl"), description = "Sorry, no description." });
            dataGridOfPeople.ItemsSource = listOfPeople;
            genderTypeColumn.ItemsSource = Enum.GetValues(typeof(PersonData.gender));
        }
    }
}
