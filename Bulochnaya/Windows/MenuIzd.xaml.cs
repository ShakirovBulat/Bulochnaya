﻿using Bulochnaya.Class;
using MongoDB.Driver;
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
    /// Логика взаимодействия для MenuIzd.xaml
    /// </summary>
    public partial class MenuIzd : Window
    {
        MongoClient client = new MongoClient();

        Izdelia us = new Izdelia();
        public MenuIzd()
        {
            InitializeComponent();
            var abase = client.GetDatabase("111");
            Grof.ItemsSource = abase.GetCollection<Izdelia>("111").AsQueryable();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(Grof.ItemsSource);
            view.Filter = UserFilter;
        }
        private void Grof_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var gg = (Izdelia)Grof.SelectedItem;
            TovarPage tp = new TovarPage(gg);
            tp.Show();
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtName.Text))
                return true;
            else
                return ((item as Izdelia)._name.IndexOf(txtName.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Grof.ItemsSource).Refresh();
        }
    }
}
