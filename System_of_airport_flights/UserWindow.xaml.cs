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
using System.Windows.Shapes;

namespace System_of_airport_flights
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

            List<Flight> flight = Flight.flights;

            listView.ItemsSource = flight;

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {

            var findFlight = new SearchWindow();
            findFlight.Show();

        }

        private void main_Click(object sender, RoutedEventArgs e)
        {

            var main = new MainWindow();
            this.Close();
            main.Show();

        }
    }
}
