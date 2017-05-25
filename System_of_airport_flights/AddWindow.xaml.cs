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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {

        private string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AirPortTemp\data.txt";

        public AddWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            string date = this.date.Text;

            string[] res = date.Split(' ');

            try
            {

                int.Parse(res[0]);
                int.Parse(res[1]);
                int.Parse(res[2]);
                int.Parse(res[3]);
                int.Parse(res[4]);

            } catch
            {

                MessageBox.Show("Дата введена некорректно, посмотрите подсказку!");
                return;

            }
            

            int year = int.Parse(res[0]);
            int month = int.Parse(res[1]);
            int day = int.Parse(res[2]);
            int hour = int.Parse(res[3]);
            int minute = int.Parse(res[4]);

            DateTime date_time = new DateTime(year, month, day, hour, minute, 0);

            Flight flight = new Flight(date_time, this.num.Text, this.airline.Text, this.city.Text, this.terminal.Text, this.status.Text);

            Flight.AddFlight(flight, doc);

            this.Close();

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = new AdminWindow1();
            this.Close();
        }
    }
}
