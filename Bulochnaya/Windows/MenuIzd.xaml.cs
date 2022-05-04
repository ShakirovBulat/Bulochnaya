using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Bulochnaya.Windows
{
    public partial class MenuIzd : Window
    {
        public static Bakery2Entities db = new Bakery2Entities();
        public MenuIzd()
        {
            InitializeComponent();
            db = new Bakery2Entities();
            Grof.ItemsSource = db.Menu.ToList();
        }

        private void Grof_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = (Menu)Grof.SelectedItem;
            TovarPage tp = new TovarPage(gg);
            tp.Show();
        }
    }
}
