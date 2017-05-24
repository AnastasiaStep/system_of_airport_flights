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

namespace System_of_airport_flights
{
    /// <summary>
    /// Логика взаимодействия для AdminPage1.xaml
    /// </summary>
    public partial class AdminPage1 : Page
    {
        public AdminPage1()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, RoutedEventArgs e)
        {

            if (Admin.registered)
            {

                MessageBox.Show("Первичная регистрация проведена!");

            }
            else
            {

                NavigationService.Navigate(new AdminSignUp());

            }

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {

            string login = this.login.Text;
            string password = this.passsword.Password;

            if (Admin.CheckIfCorrect(login, password))
            {

                NavigationService.Navigate(new MainAdminPage());

            }

            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }
    }
}
