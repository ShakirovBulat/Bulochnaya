using Bulochnaya.Class;
using Bulochnaya.Windows;
using System.Windows;

namespace Bulochnaya
{
    public partial class MainWindow : Window
    {
        public static InProcess proc = new InProcess();
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
