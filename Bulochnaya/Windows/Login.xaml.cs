using Bulochnaya.Class;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows;

namespace Bulochnaya.Windows
{
    public partial class Login : Window
    {

        MongoClient client = new MongoClient();
        
        public Login()
        {
            InitializeComponent();
        }

        public bool Auth(string nickname, string password)
        {
            var abase = client.GetDatabase("111");
            var b = abase.GetCollection<Users>("Shakirov_DB");
            var listPerson = b.Find(Bulochnaya => Bulochnaya._name == nickname && Bulochnaya._password == password ).ToList().FirstOrDefault();
            try
            {
                if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(password) || listPerson == null)
                {
                    MessageBox.Show("Введите логин и пароль или введены неправильные данные");
                    return false;
                }
                else if (listPerson._name == nickname && listPerson._password == password && listPerson._role == "1")
                {
                    MainWindow.proc._name = listPerson._name;
                    MainWindow.proc._email = listPerson._email;
                    MainWindow.proc._phone = listPerson._phone;
                    MessageBox.Show($"Добро пожаловать Администратор");
                    MenuPage wd = new MenuPage();
                    wd.Show();
                    wd.menu.Visibility = Visibility.Visible;
                    this.Close();
                }
                
                else if (listPerson._name == nickname && listPerson._password == password && listPerson._role == "2")
                {
                    MainWindow.proc._name = listPerson._name;
                    MainWindow.proc._email = listPerson._email;
                    MainWindow.proc._phone = listPerson._phone;
                    MessageBox.Show($"Добро пожаловать {nickname}");
                    MenuPage wd = new MenuPage();
                    wd.Show();
                    wd.menu.Visibility = Visibility.Hidden;
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Введите логин и пароль или введены неправильные данные");
            }
            
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auth(nickname.Text, password.Text);
        }
    }
}
