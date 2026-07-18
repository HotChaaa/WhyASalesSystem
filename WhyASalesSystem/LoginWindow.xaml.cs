using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WhyASalesSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            if (username == "test" && password == "1234")
            {
                MainWindow mainWindow = new MainWindow(username);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง",
                                "Login Failed",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}
