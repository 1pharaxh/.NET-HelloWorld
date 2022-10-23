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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            People.Add(new Person { FirstName = "Nathan", lastName = "Tape" });
            People.Add(new Person { FirstName = "Daniel", lastName = "Taylor" });
            People.Add(new Person { FirstName = "Rick", lastName = "Floss" });
            myComboBox.ItemsSource = People;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstTextBox.Text}");
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
    }
}
