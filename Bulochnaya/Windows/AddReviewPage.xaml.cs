using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddReviewPage.xaml
    /// </summary>
    public partial class AddReviewPage : Window
    {
        public AddReviewPage()
        {
            InitializeComponent();
        }

        private void inorder_Click(object sender, RoutedEventArgs e)
        {
            Reviews rev = new Reviews();
            Menu menu = new Menu();
            rev.Review = review.Text.ToString();
            rev.Rating = BasicRatingBar.Value;
            rev.Id = Login.logUser.Id;
            menu.Id_review = rev.Id_review;

            MainWindow.db.Reviews.Add(rev);
            MainWindow.db.SaveChanges();
            MessageBox.Show("Succesfull");
        }
    }
}
