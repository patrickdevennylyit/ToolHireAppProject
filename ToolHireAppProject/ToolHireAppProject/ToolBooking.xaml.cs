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
    /// Interaction logic for ToolBooking.xaml
    /// </summary>
    public partial class ToolBooking : Page
    {
        public ToolBooking()
        {
            InitializeComponent();
        }

        private void SubmnuAddNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            stkCustomerDetails.Visibility = Visibility.Visible;
        }

        private void BtnCustomerUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbxCusTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
