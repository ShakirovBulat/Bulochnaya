using System.Linq;
using System.Windows;

namespace Bulochnaya.Windows
{
    public partial class Histori : Window
    {

        public Histori()
        {
            InitializeComponent();
            Grof.ItemsSource = inHistori.Projects.ToList();
            Grof.CanUserAddRows = false;
        }
    }
}
