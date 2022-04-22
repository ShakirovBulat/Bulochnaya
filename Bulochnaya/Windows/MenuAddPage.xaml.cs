using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Bulochnaya.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuAddPage.xaml
    /// </summary>
    public partial class MenuAddPage : Window
    {
        public MenuAddPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                img.Source = new BitmapImage(fileUri);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Name = name.Text.ToString();
            menu.Description = description.Text.ToString();
            menu.ImageTovar = System.Text.Encoding.Default.GetBytes(img.ToString());

            MainWindow.db.Menu.Add(menu);
            MainWindow.db.SaveChanges();
            MessageBox.Show("Succesfull");
        }
    }
}
