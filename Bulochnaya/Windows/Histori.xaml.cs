﻿using System;
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
    /// Логика взаимодействия для Histori.xaml
    /// </summary>
    public partial class Histori : Window
    {

        public Histori()
        {
            InitializeComponent();
            Grof.ItemsSource = inHistori.Projects.ToList();
            string lol = DateTime.Now.ToString();
        }
    }
}
