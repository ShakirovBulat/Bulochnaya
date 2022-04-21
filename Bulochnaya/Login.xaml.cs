using System.Windows;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in MainWindow.db.Users)
            {
                if (user.Login == (nickname.Text = "nick") && user.Password == (password.Text = "gg"))
                {
                    MessageBox.Show($"Привет админ {user.Login}");
                    MenuPage menu = new MenuPage();
                    menu.menu.Visibility = Visibility.Visible;
                    menu.Show();
                }
                else if (user.Login == nickname.Text.Trim() && user.Password == password.Text.Trim())
                {
                    MessageBox.Show($"Привет Пользователь {user.Login}");
                    MainWindow.authUser = user;
                    MenuPage menu = new MenuPage();
                    menu.menu.Visibility = Visibility.Hidden;
                    menu.Show();
                }
            }
        }
    }
}
