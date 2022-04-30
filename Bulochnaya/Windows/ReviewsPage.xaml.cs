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
    /// Логика взаимодействия для ReviewsPage.xaml
    /// </summary>
    public partial class ReviewsPage : Window
    {
        Bakery2Entities db = new Bakery2Entities();
        public ReviewsPage(Menu menu)
        {
            InitializeComponent();
            Grof.ItemsSource = db.ReviewsTovar.Where(c => c.Id_Tovar == menu.Id_Tovar).ToList();
        }

        private void review_Click(object sender, RoutedEventArgs e)
        {
            AddReviewPage rev = new AddReviewPage();
            rev.Show();
            this.Close();
        }

        private void Grof_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReviewsTovarPage rov = new ReviewsTovarPage();
            rov.Show();
        }
    }
}
