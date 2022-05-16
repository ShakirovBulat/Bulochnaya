using Bulochnaya.Class;
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
