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
        BakeryEntities2 db = new BakeryEntities2();
        public ReviewsPage()
        {
            InitializeComponent();
            db = new BakeryEntities2();
            Grof.ItemsSource = db.Reviews.ToList();
            Grof.ItemsSource = db.Menu.ToList();
        }

        private void review_Click(object sender, RoutedEventArgs e)
        {
            AddReviewPage rev = new AddReviewPage();
            rev.Show();
        }
    }
}
