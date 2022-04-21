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
            
        }
    }
}
