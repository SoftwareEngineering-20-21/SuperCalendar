using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
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
        private IKernel kernel;

        public MainWindow(IKernel kernel)
        {
            InitializeComponent();
            this.kernel = kernel;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Registration register = new Registration(kernel);
            register.ShowDialog();
            register.Close();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            Login logIn = new Login();
            logIn.ShowDialog();
            logIn.Close();
        }
    }
}
