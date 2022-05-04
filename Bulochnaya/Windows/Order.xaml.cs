using System.Linq;
using System.Windows;

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
