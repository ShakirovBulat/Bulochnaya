using Bulochnaya.Class;
using System.Linq;
using System.Windows;

namespace Bulochnaya.Windows
{
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
