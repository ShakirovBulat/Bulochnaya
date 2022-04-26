using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Bulochnaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuAddPage.xaml
    /// </summary>
    public partial class MenuAddPage : Window
    {
        OpenFileDialog ofdImage1 = new OpenFileDialog();
        public MenuAddPage()
        {
            InitializeComponent();
        }

        public void download_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            ofdImage.FilterIndex = 1;
            if (ofdImage.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdImage.FileName);
                image.EndInit();
                ofdImage1 = ofdImage;
                img.Source = image;
            }
        }

        public void add_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Name = name.Text.ToString();
            menu.Description = description.Text.ToString();
            
            menu.ImageTovar = File.ReadAllBytes(ofdImage1.FileName);

            MainWindow.db.Menu.Add(menu);
            MainWindow.db.SaveChanges();
            MessageBox.Show("Succesfull");
        }

        
    }
}
