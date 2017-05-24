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
using System.IO;

namespace System_of_airport_flights
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AirPortTemp";
        private string adm = @"\admin.txt";
        private string data = @"\data.txt";

        public MainWindow()
        {
            InitializeComponent();

            Directory.CreateDirectory(path);

            if (!File.Exists(path + adm))
            {

                using (FileStream fs = File.Create(path + adm))
                {
                    
                }

            }

            if (!File.Exists(path + data))
            {

                using (FileStream fs = File.Create(path + data))
                {

                }

            }

            Flight.GetFlight(path + data);

            Admin.GetLoginPass(path + adm);
            
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {

            var admin = new AdminWindow1();
            this.Close();
            admin.Show();

            

        }
    }
}
