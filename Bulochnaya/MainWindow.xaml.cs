using System.Windows;

namespace Bulochnaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BakeryEntities db = new BakeryEntities();
        public static Users authUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Vhod(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

    private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }
    }
}
