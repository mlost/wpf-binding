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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Ocena> gradesList = new ObservableCollection<Ocena>();
        Ocena dodaj;

        public MainWindow()
        {
            InitializeComponent();
            dodaj = new Ocena(5, "matematyka", "sprawdzian");
            gradesList.Add(dodaj);
            dodaj = new Ocena(3, "biologia", "kartkówka");
            gradesList.Add(dodaj);
            dodaj = new Ocena(2, "chemia", "kartkówka");
            gradesList.Add(dodaj);
            dodaj = new Ocena(6, "Informatyka", "sprawdzian");
            gradesList.Add(dodaj);
            listOfList.ItemsSource = gradesList;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dodaj = new Ocena(Int32.Parse(textBoxGrade.Text), textBoxSubject.Text, textBoxDescription.Text);
                gradesList.Add(dodaj);
            }
            catch
            {
                MessageBox.Show("wprowadzono błędne dane");
            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            int i = listOfList.SelectedIndex;
            dodaj = new lab6.Ocena(Int32.Parse(textBoxGrade.Text), textBoxSubject.Text, textBoxDescription.Text);
            gradesList[i] = dodaj;
        }

        private void listOfList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            try
            {
                int i = listOfList.SelectedIndex;
                textBoxGrade.Text = (gradesList[i].value).ToString();
                textBoxSubject.Text = (gradesList[i].subject).ToString();
                textBoxDescription.Text = (gradesList[i].description).ToString();
            }
            catch
            { }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            int i = listOfList.SelectedIndex;
            gradesList.RemoveAt(i);
        }
    }
}
