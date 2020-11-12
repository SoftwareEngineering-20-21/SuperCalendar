﻿using System;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
      
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string fullname = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string repeatPassword = Password1Box.Password;
            if (password == repeatPassword)
            {
                UserService userService = new UserService();
                userService.SignUp(fullname, email, password);
                MessageBox.Show("Registration successful!", "SuperCalendar", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Неправильний пароль");
            }
            this.Close();
        }
    }
}
