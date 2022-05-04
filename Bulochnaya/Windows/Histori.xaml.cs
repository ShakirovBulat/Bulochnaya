using System.Linq;
using System.Windows;

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
        }
    }
}
