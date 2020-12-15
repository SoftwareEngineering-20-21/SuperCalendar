using Calendar.BLL.Services;
using Calendar.DAL.Context;
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
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        User user;
        public Window1(User user)
        {
            this.user = user;
            InitializeComponent();

        }
        private void Add_Event(object sender, RoutedEventArgs e)
        {
            AddEvent a = new AddEvent(this.user);
            a.ShowDialog();
            a.Close();
        }

        private void Delete_Event(object sender, RoutedEventArgs e)
        {

        }
    }
}
