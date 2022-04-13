using Bulochnaya.Class;
using MongoDB.Driver;
using System.Linq;
using System.Windows;

namespace Bulochnaya.Pages
{
    /// <summary>
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Login : Page
    {
        MongoClient client = new MongoClient();
        
        Users us = new Users();
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
        }

        public bool Auth(string nickname, string password)
        {
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Users>("Shakirov_DB");
            var listPerson = b.Find(Bulochnaya => Bulochnaya._name == nickname && Bulochnaya._password == password).ToList().FirstOrDefault();
            if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(password) || listPerson == null)
            {
                MessageBox.Show("Введите логин и пароль или неправильные данные");
                return false;
            }
            else if (listPerson != null)
            {
                MessageBox.Show($"Добро пожаловать {nickname}");
                MenuPage wd = new MenuPage();
                wd.Show();
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Auth(nickname.Text, password.Text);
        }
    }
}
