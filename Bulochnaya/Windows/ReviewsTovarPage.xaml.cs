using System;
using System.Windows;

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
