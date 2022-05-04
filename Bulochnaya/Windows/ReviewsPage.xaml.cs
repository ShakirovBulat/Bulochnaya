using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Bulochnaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReviewsPage.xaml
    /// </summary>
    public partial class ReviewsPage : Window
    {
        Bakery2Entities db = new Bakery2Entities();
        Menu clickedmenu;
        public ReviewsPage(Menu menu)
        {
            InitializeComponent();
            clickedmenu = menu;
            Grof.ItemsSource = db.ReviewsTovar.Where(c => c.Id_Tovar == menu.Id_Tovar).ToList();
        }

        private void review_Click(object sender, RoutedEventArgs e)
        {

            AddReviewPage rev = new AddReviewPage(clickedmenu);
            rev.Show();
            this.Close();
        }

        private void Grof_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = (ReviewsTovar)Grof.SelectedItem;
            ReviewsTovarPage rov = new ReviewsTovarPage(gg);
            rov.Show();
        }
    }
}
