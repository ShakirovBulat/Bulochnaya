using Bulochnaya.Class;
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

namespace Bulochnaya
{
    /// <summary>
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
        }

        private bool Auth(string nickname, string password)
        {
            if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин или пароль");
                return false;
            }
            else
            {
                Users us = new Users(Convert.ToString(nickname), Convert.ToString(password));
                us.FindFrom(us);
                MessageBox.Show($"Добро пожаловать {nickname}");
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auth(nickname.Text, password.Text);
        }
    }
}
