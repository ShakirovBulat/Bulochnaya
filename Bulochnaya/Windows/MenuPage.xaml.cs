using Bulochnaya.Class;
using Bulochnaya.Windows;
using System.Windows;

namespace Bulochnaya.Windows
{
    public partial class MenuPage : Window
    {
        Izdelia izdclicked;
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_To_Order(object sender, RoutedEventArgs e)
        {
            Order ord = new Order(izdclicked);
            ord.Show();
        }

        private void MenuItem_Click_To_News(object sender, RoutedEventArgs e)
        {
            News s = new News();
            s.Show();
        }

        private void MenuItem_Click_To_Menu(object sender, RoutedEventArgs e)
        {
            MenuIzd menu = new MenuIzd();
            if(MainWindow.proc._role == "2")
            {
                menu.inorder.Visibility = Visibility.Hidden;
            }
            menu.Show();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            MenuAddPage menu = new MenuAddPage();
            menu.Show();
        }
    }
}
