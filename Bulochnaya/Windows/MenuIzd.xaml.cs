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
        public static BakeryEntities2 db = new BakeryEntities2();
        public MenuIzd()
        {
            InitializeComponent();
            Grof.ItemsSource = db.Menu.ToList();
        }
    }
}
