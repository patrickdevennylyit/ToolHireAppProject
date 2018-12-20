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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToolHireAppProject
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        DBlibraryTH.ToolHireDBEntities1 db = new DBlibraryTH.ToolHireDBEntities1("metadata=res://*/ToolHireModel.csdl|res://*/ToolHireModel.ssdl|res://*/ToolHireModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.109.128;initial catalog=ToolHireDB;persist security info=True;user id=paddy;password=Ccesmo.13;pooling=False;MultipleActiveResultSets=True;App=EntityFramework'");

        List<DBlibraryTH.User> userList = new List<DBlibraryTH.User>();

        public Admin()
        {
            InitializeComponent();
        }

        private void TbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void submnuAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            stkUserDetails.Visibility = Visibility.Visible;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            stkUserDetails.Visibility = Visibility.Collapsed;
        }

        private void LstUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)

        {
            RefreshUserList();
        }
        private void RefreshUserList ()
        {
            lstUserList.ItemsSource = userList;
            foreach (var user in db.Users)
            {
                userList.Add(user);
            }
        }
    }
}
