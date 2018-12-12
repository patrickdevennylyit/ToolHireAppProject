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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToolHireAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBlibraryTH.ToolHireDBEntities1 db = new DBlibraryTH.ToolHireDBEntities1("metadata=res://*/ToolHireModel.csdl|res://*/ToolHireModel.ssdl|res://*/ToolHireModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.109.128;initial catalog=ToolHireDB;persist security info=True;user id=paddy;password=Ccesmo.13;pooling=False;MultipleActiveResultSets=True;App=EntityFramework'");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLOGON_Click(object sender, RoutedEventArgs e)
        {
            string currentUser = tbxUsername.Text;
            string currentPassword = tbxPassword.Password;
            foreach (DBlibraryTH.User user in db.Users)

            {
                if (user.Username == currentUser && user.Password == currentPassword)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.user = user;
                    dashboard.ShowDialog();
                    this.Hide();
                }
                else
                {
                    lblErrorMessage.Content = "Please check your username and password";
                }
                
            }

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
    "Are you sure?",
    "Please chose an option",
    MessageBoxButton.YesNo,
    MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();

            }
        }
    }
}
