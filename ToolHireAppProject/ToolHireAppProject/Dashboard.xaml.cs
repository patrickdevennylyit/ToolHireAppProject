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

            }
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e) => frnMain.Navigate(new Admin());

        private void FrnMain_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
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

        private void BtnManager_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTool_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckUserAccess(user);
        }
    }
}
