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

namespace WpfAppVisualControl
{
    /// <summary>
    /// Логика взаимодействия для WindowFromUsers.xaml
    /// </summary>
    public partial class WindowFromUsers : Window
    {
        public WindowFromUsers()
        {
            InitializeComponent();
            this.DataContext = App.CurentUserApp;
        }
    }
}
