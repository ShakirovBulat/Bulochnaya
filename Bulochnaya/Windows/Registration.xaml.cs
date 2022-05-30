using Bulochnaya.Class;
using System;
using System.Windows;

namespace Bulochnaya.Windows
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Users us = new Users(Convert.ToString(Nickname.Text),
                                     Convert.ToString(email.Text),
                                     Convert.ToString(password.Text),
                                     double.Parse(phone.Text),
                                     Convert.ToString("2"));
                us.Add(us);
                MessageBox.Show("Занесено в базу!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Неправильные данные!");
            }
        }
    }
}
