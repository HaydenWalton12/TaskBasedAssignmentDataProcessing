using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TaskBasedForms
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// When creating the data processing segment, remember to allow differetn data to be processed at once, remember the "Allow the Finances team to find the following data:"
        ///Segmenet , e.g if a supplier type is only chosen for data porocessing , only process the totla that type has made all time  , or if a date is chosen too , show how much
        ///that ssupplier type has made in  a week too . 
        ///The total cost of all orders available in the supplied data

//        o The total cost of all orders for a single store

//        o The total cost of orders in a week for all stores

//o The total cost of orders in a week for a single store

//o The total cost of all orders to a supplier

//o The cost of all orders from a supplier type

//o The cost of orders in a week for a supplier type

//o The cost of orders for a supplier type for a store

//o The cost of orders in a week for a supplier type for a store
        /// </summary>


        //To locate the queried filtered data at this point , we use ints to access the elementat from the query.
        int SelectedStoreCodeIndex;
        int SelectedSupplierNameIndex;
        int SelectedSupplierTypeIndex;
        int SelectedDateIndex;

        //Will be used in the future as a method of selcting a specfic type of data processing
        //Fullfilling different data processing methods
        int SelectedNum;

        public string[] fileNames = new string[0];
        string[] stores = new string[250];

        List<Order> orders = new List<Order>();
        List<string> supplier_types = new List<string>();
        HashSet<Date> dates = new HashSet<Date>();
        List<string> supplier_names = new List<string>();
        public Application _App;

        public string DataDirectoryPath;
        public string StoreCodesFile;

        public Form1(Application application)
        {
            _App = application;
            InitializeComponent();
        }


        private void FindDataPathClick(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            DataDirectoryPath = folderBrowser.SelectedPath;
            DataPathTextBox.Text = folderBrowser.SelectedPath;


        }



        //Instead of storing code into seperate lists , we directly store everything using the winforms list boxes and such
        public void LoadDataClick(object sender, EventArgs e)
        {


            fileNames = Directory.GetFiles(DataDirectoryPath);
            int whole_size = fileNames.Length;
            int half_size = fileNames.Length / 2;



            Task task1 = new Task(() => { LoadData(0, whole_size); });

            task1.Start();
            Task.WaitAll(task1);

            //Gets All Supply Names from each order, the processes them into a distinct list, containing only each instance of a supplier sname , 
            List<string> supplier_names_dupes = new List<string>();
            foreach (Order order in orders)
            {
                string supplier_name = order.SupplierName;
                supplier_names_dupes.Add(supplier_name);
            }
            supplier_names = supplier_names_dupes.Distinct().ToList();

            //Same thing we did above for the supplier names
            List<string> supplier_types_dupes = new List<string>();
            foreach (Order order in orders)
            {
                string supplier_type = order.SupplierType;
                supplier_types_dupes.Add(supplier_type);
            }

            supplier_types = supplier_types_dupes.Distinct().ToList();

            //Lods Selection lists for data processing , data processing of filtering threw orders is done via c# query system
            LoadList();
        }


        //Similar to the old load data method ,segrating data into adding into lists and using .split method ,can find old version on other gitrepos or bb
        public void LoadData(int start, int end)
        {


            for (int i = start; i < end; i++)
            {
                Console.WriteLine(fileNames[i]);
                string fileNameExt = Path.GetFileName(fileNames[i]);
                string fileName = Path.GetFileNameWithoutExtension(fileNames[i]);
                string[] fileNameSplit = fileName.Split('_');

                string[] orderData = File.ReadAllLines(fileNames[i]);
                Date date = new Date { Week = Convert.ToInt32(fileNameSplit[1]), Year = Convert.ToInt32(fileNameSplit[2]) };
                dates.Add(date);


                foreach (var orderInfo in orderData)
                {
                    string[] orderSplit = orderInfo.Split(',');

                    Order order = new Order
                    {
                        StoreCode = fileNameSplit[0],

                        Date = date,
                        SupplierName = orderSplit[0],
                        SupplierType = orderSplit[1],
                        Cost = Convert.ToDouble(orderSplit[2])
                    };

                    orders.Add(order);

                }



            }
        }

        private void LoadStoreCodeClick(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                StoreCodesFile = ofd.FileName;
                StoreCodeTextBox.Text = ofd.FileName;
            }
        }


        /// <summary>
        /// Loads Selection Lists To Aquire Filtered Data
        /// </summary>
        public void LoadList()
        {
            string[] _StoreCodeData = File.ReadAllLines(StoreCodesFile);
            int i = 0;

            foreach (var StoreData in _StoreCodeData.AsParallel())
            {
                //Splits data using ".split" , creating and storing into string array , the string code is split into two strings.
                //split determined by single unicode character ',' , will split from this considered middle point. E.G Hello =  .split('l') , s1(he) s2(lo)
                //This splits up the StoreCode data into two , the store code in s1 , then store location in s2
                string[] storeDataSplit = StoreData.Split(',');

                StoreCodesList.Items.Add(storeDataSplit[0] + " : " + storeDataSplit[1]);

                stores[i] = storeDataSplit[0];
                i++;
            }

            foreach (var suppliertype in supplier_types.AsParallel())
            {
                SupplierTypeList.Items.Add(suppliertype.ToString());
            }
            foreach (var suppliername in supplier_names.AsParallel())
            {
                SupplierNameList.Items.Add(suppliername.ToString());
            }
            foreach (var date in dates.AsParallel())
            {
                DatesListBox.Items.Add("Week : " + date.Week.ToString() + " Year : " + date.Year.ToString());
            }

        }



        //Upon Selecting element , ot stores the element value in in variable , used for seartching "ElemementAt" Queries function
        private void SupplierTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSupplierTypeIndex = SupplierTypeList.SelectedIndex;
        }
        private void SupplierNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSupplierNameIndex = SupplierNameList.SelectedIndex;
        }
        private void StoreCodesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStoreCodeIndex = StoreCodesList.SelectedIndex;
        }
        private void DatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDateIndex = DatesListBox.SelectedIndex;
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            if (SelectedDateIndex == null || SelectedStoreCodeIndex == null || SelectedSupplierNameIndex == null || SelectedSupplierTypeIndex == null)
            {
                MessageBox.Show("Unable to find any orders with specified parameters", "No orders found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                //Query - Used to store filtered data. We get the data "from" order class,
                //"in" the orders list, this allows us to chose the data we want to
                //"select" "from" "in" a specfic peice of data.

                var order_query = from order in orders select order;


                order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                order_query = order_query.Where(order => order.SupplierName == supplier_names.ElementAt(SelectedSupplierNameIndex));
                order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);


                //Count<TSource> - TSource Is the Type of Elements you want to get from the source, the source being order_query , the type being Order
                if (order_query.Count<Order>() == 0)
                {
                    MessageBox.Show("Unable to find any orders with specified parameters", "No orders found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    UpdateQueryListView(order_query);
                }

            }

        }

        //Updates the query filtering results, and some minor data
        private void UpdateQueryListView(IEnumerable<Order> orders)
        {

            OrderSerchResultsListView.Items.Clear();
            foreach (var order in orders)
            {

                string[] subitem = new string[5];

                subitem[0] = order.StoreCode;
                subitem[1] = order.SupplierName;
                subitem[2] = order.SupplierType;
                subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
                subitem[4] = order.Cost.ToString();

                ListViewItem item = new ListViewItem(subitem);
                OrderSerchResultsListView.Items.Add(item);
            }
            double Order_Query_Total = orders.Sum(item => item.Cost);
            TotalCostFilteredOrders.Text = "Total Cost >> " + Order_Query_Total.ToString();
        }


        //Deslect of options function
        private void DeselectSupplierType_Click(object sender, EventArgs e)
        {
            SupplierTypeList.SelectedIndex = -1;
            SelectedSupplierTypeIndex = -1;
        }

        private void DeselectSupplierName_Click(object sender, EventArgs e)
        {
            SupplierNameList.SelectedIndex = -1;
            SelectedSupplierNameIndex = -1;

        }

        private void DeselectStoreCode_Click(object sender, EventArgs e)
        {
            StoreCodesList.SelectedIndex = -1;
            SelectedStoreCodeIndex = -1;
        }

        private void DeselectDateList_Click(object sender, EventArgs e)
        {
            DatesListBox.SelectedIndex = -1;
            SelectedDateIndex = -1;
        }

    }

}


