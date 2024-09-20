using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppVisualControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty CurrentUserProperty;
        public User CurrentUser
        {
            get { return (User)GetValue(CurrentUserProperty); }
            set { SetValue(CurrentUserProperty, value); }
        }

        static MainWindow()
        {
            CurrentUserProperty = DependencyProperty.Register(
                "User",
                typeof(User),
                typeof(MainWindow));
        }

        public MainWindow()
        {
            InitializeComponent();
            CurrentUser = new User { Id = 1, IdRolle = 2, Name = "Сергей", RolleName = "Adm" };
            this.DataContext = CurrentUser;
            
            
        }

        private void CbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentUser =(User)(sender as ComboBox).SelectedItem;
            App.CurentUserApp = CurrentUser;
            WindowFromUsers win = new WindowFromUsers();
            win.Show();
        }

        
    }
    public class User
    { 
        public int Id { get; set; }
        public int IdRolle { get; set; }
        public string Name { get; set; }
        public string RolleName { get; set; }
    }
    public class Users : ObservableCollection<User>
    {
        public Users()
        {
            Add(new User { Id = 1, IdRolle = 1, Name = "Сергей", RolleName = "Adm" });
            Add(new User { Id = 2, IdRolle = 2, Name = "Николай", RolleName = "User" });
            Add(new User { Id = 3, IdRolle = 3, Name = "Иван", RolleName = "Guest" });
        }
        
        
    }


    public class VisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int val = (int)value;
            int par = int.Parse(parameter.ToString());
            if (val > par) return Visibility.Collapsed; 
            else return Visibility.Visible; ;



            
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            return value;
        }
    }

}