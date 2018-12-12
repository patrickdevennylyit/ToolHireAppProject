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
    }
}
