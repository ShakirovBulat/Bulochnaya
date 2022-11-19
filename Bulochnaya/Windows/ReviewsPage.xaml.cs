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
        BakeryEntities db = new BakeryEntities();
        ReviewsTovar revclick;
        Menu clickedmenu;
        public ReviewsPage(Menu menu, ReviewsTovar rev)
        {
            InitializeComponent();
            clickedmenu = menu;
            revclick = rev;
            Grof.ItemsSource = (from re in db.Reviews join reto in db.ReviewsTovar on re.Id_Review equals reto.Id_review 
                                where re.Id_Review == reto.Id_review
                                where reto.Id_Tovar == clickedmenu.Id_Tovar
                                select re).ToList();
        }

        private void review_Click(object sender, RoutedEventArgs e)
        {

            AddReviewPage rev = new AddReviewPage(clickedmenu);
            rev.Show();
            this.Close();
        }
    }
}
