using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Bulochnaya.Windows
{
    public partial class MenuIzd : Window
    {
        public static BakeryEntities db = new BakeryEntities();
        public MenuIzd()
        {
            InitializeComponent();
            db = new BakeryEntities();
            Grof.ItemsSource = db.Menu.ToList();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(Grof.ItemsSource);
            view.Filter = UserFilter;
        }

        private void Grof_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = (Menu)Grof.SelectedItem;
            TovarPage tp = new TovarPage(gg);
            tp.Show();
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtName.Text))
                return true;
            else
                return ((item as Menu).Name.IndexOf(txtName.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Grof.ItemsSource).Refresh();
        }
    }
}
