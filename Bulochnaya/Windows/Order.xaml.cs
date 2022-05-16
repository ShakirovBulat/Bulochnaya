using Bulochnaya.Class;
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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        Izdelia izdclicked;
        InProcess us = new InProcess();
        public Order(Izdelia izd)
        {
            InitializeComponent();
            izdclicked = izd;
            Grof.ItemsSource = Orders.Projects.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            InProcess us = new InProcess(MainWindow.proc._name,
                MainWindow.proc._email,
                MainWindow.proc._nametovar,
                MainWindow.proc._costtovar,
                MainWindow.proc._phone);
            us.Add(us);
            MessageBox.Show("Заказ обрабатывается");
        }
    }
}
