using Calendar.DAL.Entities;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User user;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Registration register = new Registration();
            register.ShowDialog();
            register.Close();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            Login logIn = new Login();
            logIn.ShowDialog();
            logIn.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 W1 = new Window1(this.user);
            W1.ShowDialog();
            W1.Close();
            SystemCommands.CloseWindow(this);


        }
    }
}
