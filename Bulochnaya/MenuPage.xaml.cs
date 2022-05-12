using Bulochnaya.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bulochnaya
{
    public partial class MenuPage : Window
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_To_Order(object sender, RoutedEventArgs e)
        {
            Order ord = new Order();
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
            menu.Show();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            MenuAddPage menu = new MenuAddPage();
            menu.Show();
        }
    }
}
