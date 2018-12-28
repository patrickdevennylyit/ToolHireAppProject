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
    /// Interaction logic for Manager.xamland references to the DB in use and the stock table 
    /// </summary>
    public partial class Manager : Page
    {
        DBlibraryTH.ToolHireDBEntities1 db = new DBlibraryTH.ToolHireDBEntities1("metadata=res://*/ToolHireModel.csdl|res://*/ToolHireModel.ssdl|res://*/ToolHireModel.msl;provider=System.Data.SqlClient;provider connection string='data source=192.168.109.128;initial catalog=ToolHireDB;persist security info=True;user id=paddy;password=Ccesmo.13;pooling=False;MultipleActiveResultSets=True;App=EntityFramework'");

        List<DBlibraryTH.Stock> stockList = new List<DBlibraryTH.Stock>();
        public Manager()
        {
            InitializeComponent();
        }

        private void TbxStockQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SubmnuAddNewTool_Click(object sender, RoutedEventArgs e)
        {
            stkToolDetails.Visibility = Visibility.Visible;
        }

        private void BtnToolUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshToolList();
        }
        private void RefreshToolList()
        {
            lstToolList.ItemsSource = stockList;
            foreach (var stock in db.Stocks)
                stockList.Add(stock);
        }

        private void LstToolList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnCustomerUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
