using Calendar.BLL.Services;
using Calendar.DAL.Context;
using Calendar.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for AddEvent.xaml
    /// </summary>
    public partial class AddEvent : Window
    {

        User user;
        public AddEvent(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string description = Description.Text;
            string startAt = Start.Text;
            string endAt = End.Text;
            
                try
                {
                    Event ev = new Event { subject = name, description = description, start = DateTime.ParseExact(startAt, "dd.mm.yyyy", CultureInfo.CurrentCulture), end = DateTime.ParseExact(endAt, "dd.mm.yyyy", CultureInfo.CurrentCulture) };
                    CalendarContext con = new CalendarContext();
                    EventService usev = new EventService(con);
                    usev.Save(ev, this.user.Id);
                    Window1 w1 = new Window1(this.user);
                    w1.Show();
                    this.Close();
                }
                catch (PostgresException pexp)
                {
                    MessageBox.Show("Error has been occured\nMessage = " + pexp.Message);
                }
                catch (EntityException eexp)
                {
                    MessageBox.Show("Error has been occured\nMessage = " + eexp.Message);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error has been occured\nMessage = " + exp.Message);
                }
            
        }
    
       
            
    }
}
