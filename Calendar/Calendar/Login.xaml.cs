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
using Calendar.BLL.Services;
using Calendar.DAL.Interfaces;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
          
            string login = LogTextBox.Text;
            string password = PasswordBox.Password;
          
            UserService userService = new UserService();
            userService.Login(login, password);
           
           
            this.Close();
        }
    }
}
