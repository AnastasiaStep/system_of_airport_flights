using System;
using System.Collections.Generic;
using System.IO;
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

namespace System_of_airport_flights
{
    /// <summary>
    /// Логика взаимодействия для AdminSignUp.xaml
    /// </summary>
    public partial class AdminSignUp : Page
    {

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AirPortTemp\admin.txt";

        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new AdminPage1());

        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {

            

            string login = this.login.Text;
            string password = this.password.Password;

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {

                sw.WriteLine(login);
                sw.WriteLine(password);

            }

            Admin adm = new Admin(login, password);

            Admin.admin.Add(adm);

            NavigationService.Navigate(new AdminPage1());

        }
    }
}
