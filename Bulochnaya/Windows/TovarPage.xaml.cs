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
            lbl2Img.Content = menu.Description;

        }

        private void review_Click(object sender, RoutedEventArgs e)
        {
            
            ReviewsPage rev = new ReviewsPage(clickedMenu);
            rev.Show();
            this.Close();
        }
    }
}
