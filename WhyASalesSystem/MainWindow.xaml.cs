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
using WhyASalesSystem.Views;

namespace WhyASalesSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string username)
        {
            InitializeComponent();

            txtCurrentUser.Text = username;

            MainContent.Content = new DashboardView();
        }
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();

            this.Close();
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DashboardView();
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SaleView();
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new InventoryView();
        }
    }
}