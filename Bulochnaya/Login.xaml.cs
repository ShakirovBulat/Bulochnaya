using System.Windows;

namespace Bulochnaya
{
    /// <summary>
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Login : Window
    {
      
        public static Users logUser = new Users();
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in MainWindow.db.Users)
            {
                if (nickname.Text.Trim() == user.Name && nickname.Text == "nick" && user.Password == password.Text.Trim() && password.Text == "gg")
                {
                    logUser = user;
                    MessageBox.Show($"Привет админ {user.Name}");
                    MenuPage menu = new MenuPage();
                    menu.menu.Visibility = Visibility.Visible;
                    menu.Show();
                }
                else if (user.Name == nickname.Text.Trim() && user.Password == password.Text.Trim())
                {
                    logUser = user;
                    MessageBox.Show($"Привет Пользователь {user.Name}");
                    MainWindow.authUser = user;
                    MenuPage menu = new MenuPage();
                    menu.menu.Visibility = Visibility.Hidden;
                    menu.Show();
                }
                else if (user.Name != nickname.Text.Trim() && user.Password != password.Text.Trim())
                {
                    MessageBox.Show($"Неправильный логин или пароль!");
                    nickname.Text = null;
                    password.Text = null;
                }
            }
        }
    }
}
