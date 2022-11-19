using Bulochnaya.Windows;
using System.Windows;

namespace Bulochnaya
{
    public partial class MenuPage : Window
    {
        Menu clickedMenu;
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_To_Order(object sender, RoutedEventArgs e)
        {
            Order ord = new Order(clickedMenu);
            ord.Show();
        }



        private void MenuItem_Click_To_Menu(object sender, RoutedEventArgs e)
        {
            MenuIzd menu = new MenuIzd();
            menu.Show();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            MenuAddPage menu = new MenuAddPage();
            menu.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Histori hist = new Histori();
            hist.Show();
        }
    }
}
