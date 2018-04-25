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
        ObservableCollection<PersonData> listOfNames = new ObservableCollection<PersonData>();

        public MainWindow()
        {
            InitializeComponent();

            listOfNames.Add(new PersonData() { Name = "Arek", Age = 26, Email = "videokurspl@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Arek", Age = 20, Email = "videokurspl@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Wiola", Age = 20, Email = "asdfasdf@gmail.com" });
            listOfNames.Add(new PersonData() { Name = "Karol", Age = 23, Email = "asdfasdg@gmail.com" });

            ListaImion.ItemsSource = listOfNames;

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(ListaImion.SelectedIndex.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfNames.Add(new PersonData() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = EmailToAdd.Text });
            //   ListaImion.Items.Add(NameToAdd.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PersonData selectedName = (PersonData)ListaImion.SelectedItem;

            if (selectedName != null)
                listOfNames.Remove(selectedName);

            //ListaImion.Items.RemoveAt(selectedNameIndex);
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = (sender as GridViewColumnHeader);
            string columnNameToSort = header.Content.ToString();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListaImion.ItemsSource);
            ListSortDirection howToSort = ListSortDirection.Ascending;

            if (view.SortDescriptions.Any())
            {
                SortDescription item = view.SortDescriptions.ElementAt(0);

                if (columnNameToSort == item.PropertyName.ToString())
                    if (item.Direction == ListSortDirection.Ascending)
                        howToSort = ListSortDirection.Descending;
                    else
                        howToSort = ListSortDirection.Ascending;

            }

            view.SortDescriptions.Clear();

            view.SortDescriptions.Add(new SortDescription(columnNameToSort, howToSort));
        }


    }
}
