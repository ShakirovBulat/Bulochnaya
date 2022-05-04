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
using System.Windows.Shapes;

namespace Bulochnaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        Menu clickedMenu;
        public Order(Menu menu)
        {
            InitializeComponent();
            clickedMenu = menu;
            Grof.ItemsSource = inOrder.Projects.ToList();
            
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            inHistori.Projects = inOrder.Projects;
            MessageBox.Show("Заказ обрабатывается");
        }
    }
}
