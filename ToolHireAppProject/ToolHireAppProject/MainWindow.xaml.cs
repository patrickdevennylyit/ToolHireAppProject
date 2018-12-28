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

namespace ToolHireAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml this loging process will reference the username and password entered against the DB 
    /// if a match is found it will authenticate via the DB if not it will return an error.
    /// </summary>
    public partial class MainWindow : Window
    {
        DBlibraryTH.ToolHireDBEntities1 db = new DBlibraryTH.ToolHireDBEntities1("metadata=res://*/ToolHireModel.csdl|res://*/ToolHireModel.ssdl|res://*/ToolHireModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.109.128;initial catalog=ToolHireDB;persist security info=True;user id=paddy;password=pa55word;pooling=False;MultipleActiveResultSets=True;App=EntityFramework'");

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is whats processed when the logon button is clicked ie this is the code behind the event handler it routes the entered user name and password 
        /// arguemwnts and checks them against the entries in the users DB if the user name and and password match then they get authenticated if they dont match
        /// the specified error is displayed on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    dashboard.Owner = this;
                    dashboard.ShowDialog();
                    this.Hide();

                }
                else
                {
                    lblErrorMessage.Content = "Please check your username and password";
                }
                
            }

        }
        /// <summary>
        /// This part deals with the closing of the app from the login sceen when thew clse button is selected
        /// It prompts the user to select a yes or no option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Environment.Exit(0);

            }
        }
    }
}
