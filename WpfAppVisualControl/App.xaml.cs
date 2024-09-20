using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfAppVisualControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User CurentUserApp { get;  set; }  
    }

}
