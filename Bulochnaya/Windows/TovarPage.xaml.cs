using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Bulochnaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для TovarPage.xaml
    /// </summary>
    public partial class TovarPage : Window
    {
        public static Bakery2Entities db;
        Menu clickedMenu;
        public TovarPage(Menu menu)
        {
            InitializeComponent();
            clickedMenu = menu;
            db = new Bakery2Entities();
            MemoryStream byteStream = new MemoryStream(menu.ImageTovar);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = byteStream;
            image.EndInit();
            ggImg.Source = image;
            lbl1Img.Content = menu.Name;
            lbl2Img.Text = menu.Description;
        }

        private void review_Click(object sender, RoutedEventArgs e)
        {
            ReviewsPage rev = new ReviewsPage(clickedMenu);
            rev.Show();
            this.Close();
        }

        private void inorder_Click(object sender, RoutedEventArgs e)
        {
            inOrder.Projects.Add(clickedMenu);
        }
    }
}
