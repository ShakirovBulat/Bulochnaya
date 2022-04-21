using System;
using System.Windows;

namespace Bulochnaya
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
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
            if (Nickname.Text == "" || email.Text == "" || password.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                try
                {
                    Users client = new Users();
                    client.Login = Nickname.Text.ToString();
                    client.Email = email.Text.ToString();
                    client.Password = password.Text.ToString();
                    client.Phone = Convert.ToInt32(phone.Text);

                    MainWindow.db.Users.Add(client);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Succesfull");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
