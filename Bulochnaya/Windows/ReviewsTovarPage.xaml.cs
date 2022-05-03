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
    /// Логика взаимодействия для ReviewsTovarPage.xaml
    /// </summary>
    public partial class ReviewsTovarPage : Window
    {
        ReviewsTovar revclick;
        public ReviewsTovarPage(ReviewsTovar rev)
        {
            InitializeComponent();
            revclick = rev;
            rating.Value = Convert.ToInt32(revclick.Reviews.Rating);
            labl.Content = revclick.Reviews.Review;
        }
    }
}
