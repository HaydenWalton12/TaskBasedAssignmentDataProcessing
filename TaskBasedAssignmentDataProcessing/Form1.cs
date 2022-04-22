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
using System.Windows.Forms.DataVisualization.Charting;
namespace TaskBasedForms
{
    public partial class Form1 : Form
    {


        //To locate the queried filtered data at this point , we use ints to access the elementat from the query.
        int SelectedStoreCodeIndex;
        int SelectedSupplierNameIndex;
        int SelectedSupplierTypeIndex;
        int SelectedDateIndex;

        bool StoreCodeActive;
        bool SupplierTypeActive;
        bool SupplierNameActive;
        bool DateActive;


        int StoreSelectCode = 10;
        int DateCode = 20;
        int SupplierTypeCode = 50;
        int SupplierNameCode = 100;

        int SelectionCode = 0;
        
        
        bool DataLoaded;
        //Will be used in the future as a method of selcting a specfic type of data processing
        //Fullfilling different data processing methods
        int SelectedNum;

        public string[] fileNames = new string[0];
        string[] stores = new string[250];

        List<Order> orders = new List<Order>();
        List<string> supplier_types = new List<string>();
        List<Date> dates = new List<Date>();    
        List<string> supplier_names = new List<string>();
       
        public Application _App;
        FormCharting _Charting;
        public string DataDirectoryPath;
        public string StoreCodesFile;

        public Form1(Application application)
        {
            Form1 form1 = this;
            _App = application;
            InitializeComponent();
            StoreCodeActive = false;
            SupplierTypeActive = false;
            SupplierNameActive = false;
            DateActive = false;
            DataLoaded = false;
            _Charting = new FormCharting(form1);
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

            if(DataLoaded == false)
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
            else
            {
                MessageBox.Show("Unable To Load In Data", "Data Already Loaded", MessageBoxButtons.OK);
            }
            DataLoaded = true;

        }


        //Similar to the old load data method ,segrating data into adding into lists and using .split method ,can find old version on other gitrepos or bb
        public void LoadData(int start, int end)
        {
            string[] arr = new string[100000];

            for (int i = start; i < end; i++)
            {
                Console.WriteLine(fileNames[i]);
                string fileNameExt = Path.GetFileName(fileNames[i]);
                string fileName = Path.GetFileNameWithoutExtension(fileNames[i]);
                string[] fileNameSplit = fileName.Split('_');

                string[] orderData = File.ReadAllLines(fileNames[i]);

                Date date = new Date { Week = Convert.ToInt32(fileNameSplit[1]), Year = Convert.ToInt32(fileNameSplit[2]) };
               
                    arr[i] = date.Week.ToString()  + '_' + date.Year.ToString(); 
             
                
              
               
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
            string[] arr1 = arr.Distinct().ToArray();
            for (int i = 0; i < arr1.Count() - 1; i++)
            {
                string[] tempdate = arr1[i].Split('_');

                Date date1 = new Date();
                date1.Week = date1.Week = Convert.ToInt32(tempdate[0]);
                date1.Year = date1.Year = Convert.ToInt32(tempdate[1]);

                dates.Add(date1);

            }


            List<Date> date_dis = dates.Distinct().ToList();
            File.WriteAllLines("PP1.txt", arr1);

            File.WriteAllLines("PP.txt", arr);
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
        


        //CHarting Functionality Will need to be located within this function , since this where data for order results is queried
        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            var order_query = from order in orders select order;

            switch (SelectionCode)
            {

                //Total Of Orders/Cost From A Single Store
                case 10:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    CheckQuery(order_query);
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);


                    break;

                //Total Of Orders From All Stores At A Specfic Date
                case 20:
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    CheckQuery(order_query);
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                    break;

                //Total Of Order/Cost From A Specfic Store At A Specfic Date
                case 30:

                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    CheckQuery(order_query);
                    break;

                //Total Of Orders/Cost From A Specfic SupplierType From All Stores
                case 50:
                    order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                    CheckQuery(order_query);
                    break;

                //Total Of Orders/Cost From A Specfic SupplierType From A Specfic Store
                case 60:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                    CheckQuery(order_query);
                    break;

                //Total Of Orders/Cost From A Specific SupplierType From A Specific Date
                case 70:

                    order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    CheckQuery(order_query);
                    break;

                //Total Of Orders/Cost From A Specific SupplierType From A Specific Store At A Specific Date
                case 80:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    CheckQuery(order_query);
                    break;

                //Total Of Orders/Cost From A Specific Supplier Name
                case 100:
                    order_query = order_query.Where(order => order.SupplierName == supplier_names.ElementAt(SelectedSupplierNameIndex));
                    UpdateQueryListView(order_query);
                  
                    break;

                //Total Of Orders/Cost From A Specific SupplierName From A Specfic Store
                case 110:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierName == supplier_names.ElementAt(SelectedSupplierNameIndex));
                    UpdateQueryListView(order_query);
                    break;

                //Total Of Orders/Cost From A Specific SupplierName From A Specfic Store At A Specific Date
                case 130:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierName == supplier_names.ElementAt(SelectedSupplierNameIndex));
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    UpdateQueryListView(order_query);
                    break;

                //Total Orders/Cost From A Specific Store, From A Specific SupplierName & Type Within A Specific Date
                case 180:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == supplier_types.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.SupplierName == supplier_names.ElementAt(SelectedSupplierNameIndex));
                    order_query = order_query.Where(order => order.Date.Week == dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == dates.ElementAt(SelectedDateIndex).Year);
                    UpdateQueryListView(order_query);
                    break;

                default:
                    break;

            }

            //SelectionCode = 0;
            //SelectedSupplierNameIndex = -1;
            //SelectedSupplierTypeIndex = -1;
            //SelectedDateIndex = -1;
            //SelectedStoreCodeIndex = -1;
            
            //StoreCodesList.SelectedIndex = -1;
            //SupplierNameList.SelectedIndex = -1;
            //SupplierTypeList.SelectedIndex = -1;
            //DatesListBox.SelectedIndex = -1;
            //DateActive = false;
            //StoreCodeActive = false;
            //SupplierNameActive = false;
            //SupplierTypeActive = false;
        }

        //Updates the query filtering results, and some minor data
        private void UpdateQueryListView(IEnumerable<Order> orders)
        {

            //Stores The Type & Cost
            Dictionary<string, double> SupplierTypeGraphData = new Dictionary<string, double>();
            
            


            foreach (var order in orders)
            {
                string[] subitem = new string[5];

                subitem[0] = order.StoreCode;
                subitem[1] = order.SupplierName;
                subitem[2] = order.SupplierType;
                subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
                subitem[4] = "£ " + order.Cost.ToString();

                ListViewItem item = new ListViewItem(subitem);

                if(OrderSerchResultsListView.InvokeRequired)
                {
                    //OrderSerchResultsListView.Invoke(new MethodInvoker(delegate { OrderSerchResultsListView.Items.Clear(); }));
                    OrderSerchResultsListView.Invoke(new MethodInvoker(delegate{ OrderSerchResultsListView.Items.Add(item); }));
           

                }

            }
        }


        private void CheckQuery(IEnumerable<Order> queried_orders)
        {
            //Count<TSource> - TSource Is the Type of Elements you want to get from the source, the source being order_query , the type being Order
            if (queried_orders.Count<Order>() == 0)
            {
                MessageBox.Show("Unable to find any orders with specified parameters", "No orders found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int count = orders.Count();
                int half_count = count / 2;

                IEnumerable<Order> split_order_1 = queried_orders.Take(half_count);
                queried_orders =  queried_orders.Skip(half_count);
                IEnumerable<Order> split_order_2 = queried_orders.Take(half_count);
                Task task1 = new Task(() => { UpdateQueryListView(split_order_1); });
                Task task2 = new Task(() => { UpdateQueryListView(split_order_2); });
                task1.Start();
                task2.Start();
            }
        }
        //Upon Selecting element , ot stores the element value in in variable , used for seartching "ElemementAt" Queries function
        private void SupplierTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierTypeActive == true)
            {
                SelectedSupplierTypeIndex = SupplierTypeList.SelectedIndex;
                SupplierTypeSelectLabel.Text = "Supplier Type : " + SupplierTypeList.Text;
            }
            else
            {
                SelectedSupplierTypeIndex = SupplierTypeList.SelectedIndex;
                SupplierTypeSelectLabel.Text = "Supplier Type : " + SupplierTypeList.Text;
              
                if (SupplierTypeActive == false)
                {
                    AddToSelectionCode(SupplierTypeCode);
                }
            }

            SupplierTypeActive = true;
        }

        private void SupplierNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierNameActive == true)
            {
                SelectedSupplierNameIndex =  SupplierNameList.SelectedIndex ;
                SupplierNameSelectLabel.Text = "Supplier Name :" + SupplierNameList.Text;
            }
            else
            {
                SelectedSupplierNameIndex = SupplierNameList.SelectedIndex;
                SupplierNameSelectLabel.Text = "Supplier Name :" + SupplierNameList.Text;

                if (SupplierNameActive == false)
                {
                    AddToSelectionCode(SupplierNameCode);
                }
            }
                SupplierNameActive = true;
            }

            private void StoreCodesList_SelectedIndexChanged(object sender, EventArgs e)
            {           
            //If we already Selected an  option, this simply changed the option and doesnt add to the code.
            if (StoreCodeActive == true)
            {
                SelectedStoreCodeIndex = StoreCodesList.SelectedIndex;
                StoreCodeSelectLabel.Text = "Store Code : " + StoreCodesList.Text;
            }
            else
            {

                    SelectedStoreCodeIndex = StoreCodesList.SelectedIndex;
                    StoreCodeSelectLabel.Text = "Store Code : " + StoreCodesList.Text;
                   
                    if (StoreCodeActive == false)
                    {
                        AddToSelectionCode(StoreSelectCode);
                    }
                       StoreCodeActive = true;
            }
 
        }
        private void DatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateActive == true)
            {
                SelectedDateIndex =  DatesListBox.SelectedIndex;
                DateSelectLabel.Text = "Date :" + DatesListBox.Text;
            }
            else
            {
                if (DateActive == false)
                {
                    SelectedDateIndex = DatesListBox.SelectedIndex;
                    DateSelectLabel.Text = "Date :" + DatesListBox.Text;
                    AddToSelectionCode(DateCode);
                }
            }

            DateActive = true;
        }

        private void DeselectSupplierType_Click(object sender, EventArgs e)
        {
            if (SupplierTypeList.SelectedIndex == -1)
            {
                MessageBox.Show("Already Deselected", "Select Something To Deselect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SelectedSupplierTypeIndex = -1;
                SupplierTypeList.SelectedIndex = -1;
                SupplierTypeSelectLabel.Text = "Supplier Type : ";
                SelectionCode -= SupplierTypeCode;
                SupplierTypeActive = false;
            }
        }

        private void DeselectSupplierName_Click(object sender, EventArgs e)
        {
            if (SupplierNameList.SelectedIndex == -1)
            {
                MessageBox.Show("Already Deselected", "Select Something To Deselect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SelectedSupplierNameIndex = -1;
                SupplierNameList.SelectedIndex = -1;
                SupplierNameSelectLabel.Text = "Supplier Name :";
                SelectionCode -= SupplierNameCode;
                SupplierNameActive = false;
            }
        }

        private void DeselectStoreCode_Click(object sender, EventArgs e)
        {
            if (StoreCodesList.SelectedIndex == -1)
            {
                MessageBox.Show("Already Deselected", "Select Something To Deselect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SelectedStoreCodeIndex = -1;
                StoreCodesList.SelectedIndex = -1;
                StoreCodeSelectLabel.Text = "Store Code : ";
                SelectionCode -= StoreSelectCode;
                StoreCodeActive = false;

            }
        }

        private void DeselectDateList_Click(object sender, EventArgs e)
        {
            if (DatesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Already Deselected", "Select Something To Deselect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SelectedDateIndex = -1;
                DatesListBox.SelectedIndex = -1;
                DateSelectLabel.Text = "Date :";
                SelectionCode -= DateCode;
                DateActive = false;
            }
        }
       


    
        private void ClearOrderList_Click(object sender, EventArgs e)
        {
            OrderSerchResultsListView.Items.Clear();
        }

        private void AddToSelectionCode(int num1)
        {   
                SelectionCode += num1;
        }
     
        private void GraphResults()
        {



        }

        private void LoadSupplierTypeChart_Click(object sender, EventArgs e)
        {
            List<GraphData> ChartData = new List<GraphData>();
            foreach (var Type in DatesListBox.Items)
            {
                string Temp = Type.ToString();
                //if(Temp.Contains())
                //{ }
                GraphData data = new GraphData
                {
                   

                    Field = Type.ToString(),
                    Count = 0
                };
                ChartData.Add(data);
            }
            StoreChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var data in ChartData)
            { StoreChart.Series[0].Points.AddXY(data.Field, data.Count); }

        }


    }

}

