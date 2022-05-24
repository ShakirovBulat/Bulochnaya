using Bulochnaya.Class;
using MongoDB.Driver;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Bulochnaya.Windows
{
    public partial class TovarPage : Window
    {
        MongoClient client = new MongoClient();
        Izdelia izdclicked;
        public TovarPage(Izdelia izd)
        {
            InitializeComponent();
            izdclicked = izd;
            MemoryStream byteStream = new MemoryStream(izd._image);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = byteStream;
            image.EndInit();
            ggImg.Source = image;
            lbl1Img.Content = izd._name;
            lbl2Img.Text = izd._description;
            Cost.Content = izd._cost;
        }

        private void inorder_Click(object sender, RoutedEventArgs e)
        {
            Orders.Projects.Add(izdclicked);
            MainWindow.proc._nametovar = izdclicked._name;
            MainWindow.proc._costtovar = izdclicked._cost;
        }

    }
}
