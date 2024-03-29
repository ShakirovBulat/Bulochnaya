﻿using Bulochnaya.Class;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Bulochnaya.Windows
{

    public partial class MenuAddPage : Window
    {
        OpenFileDialog ofdImage1 = new OpenFileDialog();
        public MenuAddPage()
        {
            InitializeComponent();
        }
        private void download_Click_1(object sender, RoutedEventArgs e)
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                Izdelia us = new Izdelia(Convert.ToString(name.Text),
                                     Convert.ToString(description.Text),
                                     double.Parse(cost.Text),
                                     File.ReadAllBytes(ofdImage1.FileName));
                us.Add(us);
                MessageBox.Show("Занесено в базу!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Заполните все данные!");
            }
        }
    }
}
