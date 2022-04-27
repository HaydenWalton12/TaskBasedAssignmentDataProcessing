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
        //To Locate The Queried Filter Data At This Point , We Use These Variables To Access The Element At The Query
        int SelectedStoreCodeIndex;
        int SelectedSupplierNameIndex;
        int SelectedSupplierTypeIndex;
        int SelectedDateIndex;

        //When We Store Query Results - This Mutable Variable Will Increment By One , So When We Store Query We Can Have A New Individual File
        //It Doesnt Overide Last Instance And Store Current Query Results In New File (E.G SavedOrders_1.txt , SavedOrders_2.txt)
        int FileNameSaveInt = 0;
        
        //When A Query List Is Selected Depending On The Query List Selected, 1 - 4 Codes Is Added To "SelectionCode" , When We Then Search , The Total Selection Value
        //Will Determine What Query Mode Is Applied , The Query Mode Applied From Resultant Selection Is Briefed In Swit
        int StoreSelectCode = 10;
        int DateCode = 20;
        int SupplierTypeCode = 50;
        int SupplierNameCode = 100;

        int SelectionCode = 0;

        //Directory Variables - Used To Correctly Locate The Project Directories , To Store And Open Files & Folder
        //Solution Found From - https://stackoverflow.com/questions/816566/how-do-you-get-the-current-project-directory-from-c-sharp-code-when-creating-a-c

        string WorkingDirectory;
        string ProjectDirectory;

        bool DataLoaded;
        //Will be used in the future as a method of selcting a specfic type of data processing
        //Fullfilling different data processing methods
        int SelectedNum;

        public string[] fileNames = new string[0];
        string[] stores = new string[250];

        List<Order>  Orders = new List<Order>();
        List<string> SupplierTypes = new List<string>();
        List<Date>   Dates = new List<Date>();    
        List<string> SupplierNames = new List<string>();
        List<Order>  QueriedOrders = new List<Order>();
        public Application _Application;
       
        FormCharting _Charting;
        
        public string DataDirectoryPath;
        public string StoreCodesFile;

        public Form1(Application application)
        {
            Form1 form1 = this;
            InitializeComponent();

            //Initialise Application
            _Application = application;

            DataLoaded = false;
            
            //Initialise Charting
            _Charting = new FormCharting(form1);

            WorkingDirectory = Environment.CurrentDirectory;
            ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;
        

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
                Task task1 = new Task(() => { LoadData(0, whole_size); });
                task1.Start();
                Task.WaitAll(task1);

                //Gets All Supply Names from each order, the processes them into a distinct list, containing only each instance of a supplier sname , 
                List<string> supplier_name_dupes = new List<string>();
                List<string> supplier_type_dupes = new List<string>();

                foreach (Order order in Orders)
                {
                     supplier_name_dupes.Add(order.SupplierName);
                     supplier_type_dupes.Add(order.SupplierType);
                }

                //Retrives Distinct Elements From The Duplicated Lists , One Of Each Element Stored In Main Lists
                SupplierNames = supplier_name_dupes.Distinct().ToList();
                SupplierTypes = supplier_type_dupes.Distinct().ToList();
                
                //Lods Selection lists for data processing , data processing of filtering threw Orders is done via c# query system
                //Loads Lists For Querying Data , Possible Since The WinForm Lists Allow Selection Of Data At Index
                LoadList();
            }
            //Quick Check To Allow Data To Be Loaded Once
            else
            {
                MessageBox.Show("Unable To Load In Data", "Data Already Loaded", MessageBoxButtons.OK);
            }

            //Confirms Data Loading
            DataLoaded = true;

        }


        //Similar to the old load data method ,segrating data into adding into lists and using .split method ,can find old version on other gitrepos or bb
        //Similar TO Old Data Loading Method ,Segrating Data Into Adding  Lists Using .Split Method , Can Find Old Version On Other GitRepo Or BlackBoard
        //Logic Is The Same Just Translated Further For The F# Project, That Said , This Code Is Self-Explanatory
        public void LoadData(int start, int end)
        {
            string[] arr = new string[100000];

            for (int i = start; i < end; i++)
            {
               
                //Gets FileName , Removes Directories To Give Just FileName
                string fileNameExt = Path.GetFileName(fileNames[i]);
                
                //Removes FileName Extension ".csv"
                string fileName = Path.GetFileNameWithoutExtension(fileNames[i]);
                
                //Splits FileName , Containing Data And StoreCode, Used Reference Orders Correctly
                string[] fileNameSplit = fileName.Split('_');

                //Reads All Order Data From File from current foreach instance, we then next store this order data in foreach below
                string[] orderData = File.ReadAllLines(fileNames[i]);

                Date date = new Date { Week = Convert.ToInt32(fileNameSplit[1]), Year = Convert.ToInt32(fileNameSplit[2]) };


                //From The Current File Instance , Loads All Order Data , We Then Use This ForEach To Fill In Local Data , This
                //Data Then Gets Added To A List That Stores All Orders From All Files , Store Each Order Using Order Structure
                foreach (var orderInfo in orderData)
                {
                    string[] Ordersplit = orderInfo.Split(',');

                    Order order = new Order
                    {
                        StoreCode = fileNameSplit[0],
                        Date = date,
                        SupplierName = Ordersplit[0],
                        SupplierType = Ordersplit[1],
                        Cost = Convert.ToDouble(Ordersplit[2])
                    };

                    Orders.Add(order);

                }
            }
        }

        //
        private void LoadStoreCodeClick(object sender, EventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog();

            //Set Filter To Show Specfic Type Of Files
            open_file_dialog.Filter = "CSV files (*.csv)|*.csv";
            
            DialogResult result = open_file_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Store File Choice Into Variables
                StoreCodesFile = open_file_dialog.FileName;
                StoreCodeTextBox.Text = open_file_dialog.FileName;
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




            foreach (var suppliertype in SupplierTypes.AsParallel())
            {
                SupplierTypeList.Items.Add(suppliertype.ToString());
            }

            foreach (var suppliername in SupplierNames.AsParallel())
            {
                SupplierNameList.Items.Add(suppliername.ToString());
            }
            foreach (var date in Dates.AsParallel())
            {
                DateList.Items.Add("Week : " + date.Week.ToString() + " Year : " + date.Year.ToString());
            }
        }
        


        //Charting Functionality Will need to be located within this function , since this where data for order results is queried
        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            var order_query = from order in Orders select order;


            //Clear Previous Chart Data
            DateChart.Series[0].Points.Clear();
            StoreChart.Series[0].Points.Clear();
            SupplierNameChart.Series[0].Points.Clear();
            SupplierTypeChart.Series[0].Points.Clear();

            //Clear Previous ChartList Results
            OrderserchResultsListView1.Items.Clear();
            StoreChartResultList.Items.Clear();
            DateChartResultList.Items.Clear();
            SupplierTypeChartResultList.Items.Clear();
            SupplierTypeChartResultList.Items.Clear();

            //Clear Previous Queried Orders
            QueriedOrders.Clear();


            //Based Upon Queried List Filters From Lists Selected, This Determines Queried Response
            switch (SelectionCode)
            {
                //Each One Of These Works Similar ,Just At Different Degrees To How Much Filtering/Querying Goes On . Each One By Order
                //Does The Following Things
                //1. Applies Fitering Using Querying Function 
                //   - Links 1.)(https://stackoverflow.com/questions/4574692/linq-query-to-ienumerablet-extension-method) ,  2.)(https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-6.0)
                //2. We Use The CheckQuery Function , Passing New Queried Results, This Function Checks For Any Remaining Queries , Returns 
                //Message If True, IF Queried Results Remain , We Then Pass Queried Results To Update OrderResultListView To Present Search Results
                //3. We Further Supply The Charts With Queried Results, This Will Be Broken Down ,Extrapolating Data Relevant To The Chart Name
                //Supplying The Chart With Said Data
                //4. Store results In Queried , primarily used to be able to store results in txt
                //Total Of Orders/Cost From A Single Store
                case 10:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
             
                    CheckQuery(order_query);

                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);

                    QueriedOrders = order_query.ToList();
                    break;

                //Total Of Orders From All Stores At A Specfic Date
                case 20:
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
               
                    CheckQuery(order_query);
              
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);

                    QueriedOrders = order_query.ToList();
                  
                    break;

                //Total Of Order/Cost From A Specfic Store At A Specfic Date
                case 30:

                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
                   
                    CheckQuery(order_query);
                  
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                 
                    QueriedOrders = order_query.ToList();
                
                    break;

                //Total Of Orders/Cost From A Specfic SupplierType From All Stores
                case 50:
                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                  
                    CheckQuery(order_query);
                  
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                 
                    QueriedOrders = order_query.ToList();
                 
                    break;

                //Total Of Orders/Cost From A Specfic SupplierType From A Specfic Store
                case 60:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                  
                    CheckQuery(order_query);
                
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                    QueriedOrders = order_query.ToList();
                    break;

                //Total Of Orders/Cost From A Specific SupplierType From A Specific Date
                case 70:

                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
                   
                    CheckQuery(order_query);
                    
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                  
                    QueriedOrders = order_query.ToList();
                    break;

                //Total Of Orders/Cost From A Specific SupplierType From A Specific Store At A Specific Date
                case 80:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
                   
                    CheckQuery(order_query);
                   
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);

                    QueriedOrders = order_query.ToList();
                    break;

                //Total Of Orders/Cost From A Specific Supplier Name
                case 100:
                    order_query = order_query.Where(order => order.SupplierName == SupplierNames.ElementAt(SelectedSupplierNameIndex));
                   
                    CheckQuery(order_query);
                    
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                  
                    QueriedOrders = order_query.ToList();
                 
                    break;

                //Total Of Orders/Cost From A Specific SupplierName From A Specfic Store
                case 110:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierName == SupplierNames.ElementAt(SelectedSupplierNameIndex));
                   
                    CheckQuery(order_query);
                    
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                   
                    QueriedOrders = order_query.ToList();
                    
                    break;

                //Total Of Orders/Cost From A Specific SupplierName From A Specfic Store At A Specific Date
                case 130:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierName == SupplierNames.ElementAt(SelectedSupplierNameIndex));
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
                  
                    CheckQuery(order_query);
                   
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                  
                    QueriedOrders = order_query.ToList();
                  
                    break;
               
                    //Total Orders/Cost From A Specfic Store , From a Specfic SupplierName & Specific Type (This one makes no sense but ohwell)
                case 160:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.SupplierName == SupplierNames.ElementAt(SelectedSupplierNameIndex));
                  
                    CheckQuery(order_query);
                   
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                   
                    QueriedOrders = order_query.ToList();
                  
                    break;

                //Total Orders/Cost From A Specific Store, From A Specific SupplierName & Type Within A Specific Date
                case 180:
                    order_query = order_query.Where(order => order.StoreCode == stores.ElementAt(SelectedStoreCodeIndex));
                    order_query = order_query.Where(order => order.SupplierType == SupplierTypes.ElementAt(SelectedSupplierTypeIndex));
                    order_query = order_query.Where(order => order.SupplierName == SupplierNames.ElementAt(SelectedSupplierNameIndex));
                    order_query = order_query.Where(order => order.Date.Week == Dates.ElementAt(SelectedDateIndex).Week);
                    order_query = order_query.Where(order => order.Date.Year == Dates.ElementAt(SelectedDateIndex).Year);
                  
                    CheckQuery(order_query);
                    
                    _Charting.StoreChart(order_query);
                    _Charting.SupplierName(order_query);
                    _Charting.SupplierType(order_query);
                    _Charting.DateChart(order_query);
                   
                    QueriedOrders = order_query.ToList();
                   
                    break;

                default:
                    break;

            }

            //Clear Data For Next Queried Search
            SelectionCode = 0;

            SelectedSupplierNameIndex = -1;
            SelectedSupplierTypeIndex = -1;
            SelectedDateIndex = -1;
            SelectedStoreCodeIndex = -1;
            
            StoreCodesList.SelectedIndex = -1;
            SupplierNameList.SelectedIndex = -1;
            SupplierTypeList.SelectedIndex = -1;
            DateList.SelectedIndex = -1;

        }

        //UpDates the query filtering results, and some minor data
        private void UpdateQueryListView(IEnumerable<Order> Orders)
        {

            //Stores The Type & Cost
          
            OrderserchResultsListView1.Items.Clear();
      
            int Ordersize = Orders.Count();
            int orderhalfsize = Ordersize / 2;

            IEnumerable<Order> splitOrder1 = Orders.Take(orderhalfsize);
            Orders = Orders.Skip(orderhalfsize);

            IEnumerable<Order> splitOrder2 = Orders.Take(orderhalfsize - 1);
            List<ListViewItem> items1 = new List<ListViewItem>(); 
            List<ListViewItem> items2 = new List<ListViewItem>(); 
            Task task1 = new Task(() => { items1 = LoadData1(splitOrder1); });
            Task task2 = new Task(() => { items2 = LoadData2(splitOrder2); });
          
            task1.Start();
            task2.Start();
            task2.Wait();

            //foreach (var item in items1)
            //{

            //        OrderserchResultsListView1.Items.Add(item);

            //}
            //foreach (var item in items2)
            //{

            //    OrderserchResultsListView2.Items.Add(item);

            //}
            //int orderquarter = Ordersize / 4;
            //int k = 1;
            //int j = 2;
            //int f = 3;
            //for (int i = 0; i < orderquarter; i++)
            //{
            //    //OrderserchResultsListView1.Items.Add(items1[i]);
            //    //if (i < orderhalfsize - 1)
            //    //{
            //    //    OrderserchResultsListView2.Items.Add(items2[i]);
            //    //}

            //    OrderserchResultsListView1.Items.Add(items1[i]);
            //    OrderserchResultsListView1.Items.Add(items1[k]);
            //    OrderserchResultsListView1.Items.Add(items1[j]);
            //    OrderserchResultsListView1.Items.Add(items1[f]);

            //    if (k < items2.Count || i < items2.Count - 1)
            //    {
            //        OrderserchResultsListView2.Items.Add(items2[i]);
            //        OrderserchResultsListView1.Items.Add(items2[k]);
            //    }
            //    i = i + 3;
            //    k =  k + 4;
            //    j = j + 4;
            //    f = f + 4;

            //}
            OrderserchResultsListView1.Items.AddRange(items1.ToArray());
            OrderserchResultsListView1.Items.AddRange(items2.ToArray());
            //Task task3 = new Task(() => {  LoadList1(items1); });
            //Task task4 = new Task(() => { LoadList2(items2); });

            //task3.Start();
            //task4.Start();
            //task4.Wait();
            //foreach (var order in Orders)
            //{
            //    string[] subitem = new string[5];

            //    subitem[0] = order.StoreCode;
            //    subitem[1] = order.SupplierName;
            //    subitem[2] = order.SupplierType;
            //    subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
            //    subitem[4] = "£ " + order.Cost.ToString();

            //    ListViewItem item = new ListViewItem(subitem);

            //    OrderserchResultsListView1.Items.Add(item);
            //}



            //foreach (var item in orderchunk1)
            //{

            //    if (item != null)
            //    {
            //        OrderserchResultsListView1.Items.Add(item[0]);
            //    }
            //}
            //foreach (var item in orderchunk2)
            //{
            //    if (item != null)
            //    {
            //        OrderserchResultsListView2.Items.Add(item[0]);
            //    }
            //}
        }
        //private void LoadList1(List<ListViewItem> data)
        //{
        //    foreach(var item in data)
        //    {
        //        Invoke(new Action(() =>
        //     {
        //        OrderserchResultsListView1.Items.Add(item);
        //      }));
        //    }
           

        //}
        //private void LoadList2(List<ListViewItem> data)
        //{
        //    foreach (var item in data)
        //    {
        //        Invoke(new Action(() =>
        //        {
        //            OrderserchResultsListView2.Items.Add(item);
        //        }));
        //    }


        //}
        private List<ListViewItem> LoadData1(IEnumerable<Order> data)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
         
            foreach (var order in data)
            {
             
                string[] subitem = new string[5];

            subitem[0] = order.StoreCode;
            subitem[1] = order.SupplierName;
            subitem[2] = order.SupplierType;
            subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
            subitem[4] = "£ " + order.Cost.ToString();

                ListViewItem item = new ListViewItem(subitem);

                listViewItems.Add(item);
               
            }
            return listViewItems;
        }
        private List<ListViewItem> LoadData2(IEnumerable<Order> data)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            int i = 0;
            foreach (var order in data)
            {
         
                string[] subitem = new string[5];

                subitem[0] = order.StoreCode;
                subitem[1] = order.SupplierName;
                subitem[2] = order.SupplierType;
                subitem[3] = order.Date.Week.ToString() + " , " + order.Date.Year.ToString();
                subitem[4] = "£ " + order.Cost.ToString();

                ListViewItem item = new ListViewItem(subitem);
                listViewItems.Add(item);
            }
            return listViewItems;

        }
        private void CheckQuery(IEnumerable<Order> QueriedOrders)
        {
            //Count<TSource> - TSource Is the Type of Elements you want to get from the source, the source being order_query , the type being Order
            if (QueriedOrders.Count<Order>() == 0)
            {
                MessageBox.Show("Unable to find any Orders with specified parameters", "No Orders found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UpdateQueryListView(QueriedOrders);
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
        private void DateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateActive == true)
            {
                SelectedDateIndex =  DateList.SelectedIndex;
                DateselectLabel.Text = "Date :" + DateList.Text;
            }
            else
            {
                if (DateActive == false)
                {
                    SelectedDateIndex = DateList.SelectedIndex;
                    DateselectLabel.Text = "Date :" + DateList.Text;
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
            if (DateList.SelectedIndex == -1)
            {
                MessageBox.Show("Already Deselected", "Select Something To Deselect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SelectedDateIndex = -1;
                DateList.SelectedIndex = -1;
                DateselectLabel.Text = "Date :";
                SelectionCode -= DateCode;
                DateActive = false;
            }
        }
       


    
        private void ClearOrderList_Click(object sender, EventArgs e)
        {
            OrderserchResultsListView1.Items.Clear();
        }

        private void AddToSelectionCode(int num1)
        {   
                SelectionCode += num1;
        }
     
        private void LoadSupplierTypeChart_Click(object sender, EventArgs e)
        {
            List<GraphData> ChartData = new List<GraphData>();
            foreach (var Type in DateList.Items)
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

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
       
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            //string Folder = System.IO.Directory.GetCurrentDirectory();
            Directory.GetDirectories(projectDirectory);
     
            string FileName = "SavedOrder_" + FileNameSaveInt.ToString()+".txt";
          
            string[] orderContents = new string[QueriedOrders.Count()];
            for(int i = 0; i < QueriedOrders.Count(); i++)
            {
                orderContents[i] = "Order " + i.ToString() + "\nStoreCode :" +QueriedOrders[i].StoreCode + 
                "\nDate - Week" + QueriedOrders[i].Date.Week.ToString() + " Year - " +QueriedOrders[i].Date.Year.ToString() +
                "\nSupplier Type - " + QueriedOrders[i].SupplierType.ToString() +
                "\nSupplier Name - " + QueriedOrders[i].SupplierName.ToString() +
                "\nCost - " + QueriedOrders[i].Cost.ToString() + "\n";    
            }
            string filepath = projectDirectory + "\\TaskBasedAssignmentDataProcessing\\SavedOrders\\" + FileName;
            File.WriteAllLines(filepath, orderContents);


            FileNameSaveInt++;
        }

        private void SaveOrderFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ProjectDirectory + "\\SavedOrders");
        }
    }
}

