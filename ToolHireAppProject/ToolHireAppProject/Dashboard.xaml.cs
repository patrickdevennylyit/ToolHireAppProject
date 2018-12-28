using DBlibraryTH;
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

namespace ToolHireAppProject
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public User user = new User();
        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This part is whats run when the exit button is clicked it wil lclose the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
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
        /// <summary>
        ///  this is what is instructed to do when the "Admin" button is selected it will mavigate to the "Admin" page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdmin_Click(object sender, RoutedEventArgs e) => frnMain.Navigate(new Admin());

        private void FrnMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
        
        /// <summary>
        /// This section deals with checking the user access leve upon login then it allocates the allowed buttons for each level, additionally it will
        /// display only certain buttons for each user depending on their access level see corresponding LevelIDs 0, 1, & 2 below where 0, 1, & 2 are 
        /// Admin, Manager & User respectively/// </summary>
        /// <param name="user"></param>
        private void CheckUserAccess(User user)
        {
            if (user.LevelID == 0)
            {
                btnAdmin.Visibility = Visibility.Visible;
                btnManager.Visibility = Visibility.Visible;
                btnTool.Visibility = Visibility.Visible;        
            }
            if (user.LevelID == 1)
            {
                btnManager.Visibility = Visibility.Visible;
                btnTool.Visibility = Visibility.Visible;
            }
            if (user.LevelID == 2)
            {
                btnTool.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// This is the method run upon authentication it links back to the xaml loaded command it check access before building the dasboard screen 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckUserAccess(user);
        }
        /// <summary>
        /// this is what is instructed to do when the "Manager" button is selected it will mavigate to the "Manager" page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnManager_Click(object sender, RoutedEventArgs e)
        {
            frnMain.Navigate(new Manager());
        {
}
    }
        /// <summary>
        /// this is what is instructed to do when the "Tool" button is selected it will mavigate to the "Tool" page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTool_Click(object sender, RoutedEventArgs e)
        {
            frnMain.Navigate(new ToolBooking());
        }
    }
}
