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
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {

        static private List<Flight> findResult = new List<Flight>();

        public SearchWindow()
        {
            InitializeComponent();

            listViewFind.ItemsSource = findResult;

        }

        private void find_Click(object sender, RoutedEventArgs e)
        {

            string searchNumber = this.search.Text;

            Flight search = Flight.flights.Find(x=>x.Number.Contains(searchNumber));

            if (search == null)
            {
                MessageBox.Show("Ничего не найдено!");
                return;
            }

            findResult.Add(search);

            listViewFind.Items.Refresh();

        }
    }
}
