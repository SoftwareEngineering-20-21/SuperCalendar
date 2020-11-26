using System;
using Ninject;
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
using Calendar.BLL.Interfaces;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private IKernel kernel;

        public Login()
        {
            InitializeComponent();
            this.kernel = kernel;
        }

        private void CencelButton_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
          
            string login = LogTextBox.Text;
            string password = PasswordBox.Password;

            IUserService userService = kernel.Get<IUserService>();
            userService.Login(login, password);
           
           
            this.Close();
        }
    }
}
