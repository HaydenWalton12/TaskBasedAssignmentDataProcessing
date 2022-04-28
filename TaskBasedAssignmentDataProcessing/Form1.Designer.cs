
namespace TaskBasedForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FolderSearchButton = new System.Windows.Forms.Button();
            this.DataPathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StoreCodeTextBox = new System.Windows.Forms.TextBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.StoreCodesList = new System.Windows.Forms.ListBox();
            this.OrderSearchResultsListView = new System.Windows.Forms.ListView();
            this.StoreCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchOrderButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TotalCostFilteredOrders = new System.Windows.Forms.Label();
            this.DeselectStoreCode = new System.Windows.Forms.Button();
            this.DeselectSupplierName = new System.Windows.Forms.Button();
            this.DeselectSupplierType = new System.Windows.Forms.Button();
            this.DeselectDateList = new System.Windows.Forms.Button();
            this.SearchOrderParameterLabel = new System.Windows.Forms.Label();
            this.SupplierNameSelectLabel = new System.Windows.Forms.Label();
            this.StoreCodeSelectLabel = new System.Windows.Forms.Label();
            this.SupplierTypeSelectLabel = new System.Windows.Forms.Label();
            this.DateselectLabel = new System.Windows.Forms.Label();
            this.SelectItemLabel1 = new System.Windows.Forms.Label();
            this.SelectItemSearchOrderParameterLabel = new System.Windows.Forms.Label();
            this.SelectItemLabel3 = new System.Windows.Forms.Label();
            this.SelectItemLabel4 = new System.Windows.Forms.Label();
            this.SaveOrderButton = new System.Windows.Forms.Button();
            this.ColumnChartTextBox = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StoreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SupplierTypeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SupplierNameChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierTypeChartResultList = new System.Windows.Forms.ListBox();
            this.SupplierNameChartResultList = new System.Windows.Forms.ListBox();
            this.StoreChartResultList = new System.Windows.Forms.ListBox();
            this.DateChartResultList = new System.Windows.Forms.ListBox();
            this.DateList = new System.Windows.Forms.ListBox();
            this.SupplierTypeList = new System.Windows.Forms.ListBox();
            this.SupplierNameList = new System.Windows.Forms.ListBox();
            this.SaveOrderFolder = new System.Windows.Forms.Button();
            this.StoreChartLabel = new System.Windows.Forms.Label();
            this.DateChartLabel = new System.Windows.Forms.Label();
            this.SupplierNameChartLabel = new System.Windows.Forms.Label();
            this.SupplierTypeChartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTypeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierNameChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderSearchButton
            // 
            this.FolderSearchButton.Location = new System.Drawing.Point(12, 14);
            this.FolderSearchButton.Name = "FolderSearchButton";
            this.FolderSearchButton.Size = new System.Drawing.Size(196, 30);
            this.FolderSearchButton.TabIndex = 0;
            this.FolderSearchButton.Text = "Data Folder";
            this.FolderSearchButton.UseVisualStyleBackColor = true;
            this.FolderSearchButton.Click += new System.EventHandler(this.FindDataPathClick);
            // 
            // DataPathTextBox
            // 
            this.DataPathTextBox.Location = new System.Drawing.Point(12, 50);
            this.DataPathTextBox.Multiline = true;
            this.DataPathTextBox.Name = "DataPathTextBox";
            this.DataPathTextBox.Size = new System.Drawing.Size(196, 27);
            this.DataPathTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadStoreCodeClick);
            // 
            // StoreCodeTextBox
            // 
            this.StoreCodeTextBox.Location = new System.Drawing.Point(214, 50);
            this.StoreCodeTextBox.Multiline = true;
            this.StoreCodeTextBox.Name = "StoreCodeTextBox";
            this.StoreCodeTextBox.Size = new System.Drawing.Size(198, 27);
            this.StoreCodeTextBox.TabIndex = 3;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(423, 14);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(198, 63);
            this.LoadDataButton.TabIndex = 4;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataClick);
            // 
            // StoreCodesList
            // 
            this.StoreCodesList.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.StoreCodesList.FormattingEnabled = true;
            this.StoreCodesList.ItemHeight = 12;
            this.StoreCodesList.Location = new System.Drawing.Point(10, 98);
            this.StoreCodesList.Name = "StoreCodesList";
            this.StoreCodesList.Size = new System.Drawing.Size(198, 280);
            this.StoreCodesList.TabIndex = 5;
            this.StoreCodesList.SelectedIndexChanged += new System.EventHandler(this.StoreCodesList_SelectedIndexChanged);
            // 
            // OrderSearchResultsListView
            // 
            this.OrderSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StoreCode,
            this.SupplierType,
            this.SupplierName,
            this.Date,
            this.Cost});
            this.OrderSearchResultsListView.FullRowSelect = true;
            this.OrderSearchResultsListView.GridLines = true;
            this.OrderSearchResultsListView.HideSelection = false;
            this.OrderSearchResultsListView.Location = new System.Drawing.Point(1025, 14);
            this.OrderSearchResultsListView.Name = "OrderSearchResultsListView";
            this.OrderSearchResultsListView.Size = new System.Drawing.Size(799, 364);
            this.OrderSearchResultsListView.TabIndex = 7;
            this.OrderSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.OrderSearchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // StoreCode
            // 
            this.StoreCode.Text = "Store";
            this.StoreCode.Width = 92;
            // 
            // SupplierType
            // 
            this.SupplierType.Text = "Supplier Type";
            this.SupplierType.Width = 141;
            // 
            // SupplierName
            // 
            this.SupplierName.Text = "Supplier Name";
            this.SupplierName.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 148;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 396;
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.Location = new System.Drawing.Point(835, 98);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(184, 63);
            this.SearchOrderButton.TabIndex = 10;
            this.SearchOrderButton.Text = "Search Order";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // TotalCostFilteredOrders
            // 
            this.TotalCostFilteredOrders.AutoSize = true;
            this.TotalCostFilteredOrders.Location = new System.Drawing.Point(833, 255);
            this.TotalCostFilteredOrders.Name = "TotalCostFilteredOrders";
            this.TotalCostFilteredOrders.Size = new System.Drawing.Size(70, 13);
            this.TotalCostFilteredOrders.TabIndex = 11;
            this.TotalCostFilteredOrders.Text = "Total Cost : £";
            // 
            // DeselectStoreCode
            // 
            this.DeselectStoreCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectStoreCode.Location = new System.Drawing.Point(10, 384);
            this.DeselectStoreCode.Name = "DeselectStoreCode";
            this.DeselectStoreCode.Size = new System.Drawing.Size(198, 29);
            this.DeselectStoreCode.TabIndex = 13;
            this.DeselectStoreCode.Text = "Deselect Store Code";
            this.DeselectStoreCode.UseVisualStyleBackColor = true;
            this.DeselectStoreCode.Click += new System.EventHandler(this.DeselectStoreCode_Click);
            // 
            // DeselectSupplierName
            // 
            this.DeselectSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectSupplierName.Location = new System.Drawing.Point(627, 384);
            this.DeselectSupplierName.Name = "DeselectSupplierName";
            this.DeselectSupplierName.Size = new System.Drawing.Size(199, 29);
            this.DeselectSupplierName.TabIndex = 14;
            this.DeselectSupplierName.Text = "Deselect Supplier Name";
            this.DeselectSupplierName.UseVisualStyleBackColor = true;
            this.DeselectSupplierName.Click += new System.EventHandler(this.DeselectSupplierName_Click);
            // 
            // DeselectSupplierType
            // 
            this.DeselectSupplierType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectSupplierType.Location = new System.Drawing.Point(423, 384);
            this.DeselectSupplierType.Name = "DeselectSupplierType";
            this.DeselectSupplierType.Size = new System.Drawing.Size(198, 29);
            this.DeselectSupplierType.TabIndex = 15;
            this.DeselectSupplierType.Text = "Deselect Supplier List";
            this.DeselectSupplierType.UseVisualStyleBackColor = true;
            this.DeselectSupplierType.Click += new System.EventHandler(this.DeselectSupplierType_Click);
            // 
            // DeselectDateList
            // 
            this.DeselectDateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectDateList.Location = new System.Drawing.Point(214, 384);
            this.DeselectDateList.Name = "DeselectDateList";
            this.DeselectDateList.Size = new System.Drawing.Size(198, 29);
            this.DeselectDateList.TabIndex = 16;
            this.DeselectDateList.Text = "Deselect Date List";
            this.DeselectDateList.UseVisualStyleBackColor = true;
            this.DeselectDateList.Click += new System.EventHandler(this.DeselectDateList_Click);
            // 
            // SearchOrderParameterLabel
            // 
            this.SearchOrderParameterLabel.AutoSize = true;
            this.SearchOrderParameterLabel.Location = new System.Drawing.Point(833, 165);
            this.SearchOrderParameterLabel.Name = "SearchOrderParameterLabel";
            this.SearchOrderParameterLabel.Size = new System.Drawing.Size(132, 13);
            this.SearchOrderParameterLabel.TabIndex = 19;
            this.SearchOrderParameterLabel.Text = "Order Search Parameters :";
            // 
            // SupplierNameSelectLabel
            // 
            this.SupplierNameSelectLabel.AutoSize = true;
            this.SupplierNameSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierNameSelectLabel.Location = new System.Drawing.Point(833, 197);
            this.SupplierNameSelectLabel.Name = "SupplierNameSelectLabel";
            this.SupplierNameSelectLabel.Size = new System.Drawing.Size(81, 13);
            this.SupplierNameSelectLabel.TabIndex = 20;
            this.SupplierNameSelectLabel.Text = "Supplier Name: ";
            // 
            // StoreCodeSelectLabel
            // 
            this.StoreCodeSelectLabel.AutoSize = true;
            this.StoreCodeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.StoreCodeSelectLabel.Location = new System.Drawing.Point(833, 184);
            this.StoreCodeSelectLabel.Name = "StoreCodeSelectLabel";
            this.StoreCodeSelectLabel.Size = new System.Drawing.Size(69, 13);
            this.StoreCodeSelectLabel.TabIndex = 20;
            this.StoreCodeSelectLabel.Text = "Store Code : ";
            // 
            // SupplierTypeSelectLabel
            // 
            this.SupplierTypeSelectLabel.AutoSize = true;
            this.SupplierTypeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierTypeSelectLabel.Location = new System.Drawing.Point(833, 210);
            this.SupplierTypeSelectLabel.Name = "SupplierTypeSelectLabel";
            this.SupplierTypeSelectLabel.Size = new System.Drawing.Size(79, 13);
            this.SupplierTypeSelectLabel.TabIndex = 21;
            this.SupplierTypeSelectLabel.Text = "Supplier Type : ";
            // 
            // DateselectLabel
            // 
            this.DateselectLabel.AutoSize = true;
            this.DateselectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.DateselectLabel.Location = new System.Drawing.Point(833, 223);
            this.DateselectLabel.Name = "DateselectLabel";
            this.DateselectLabel.Size = new System.Drawing.Size(36, 13);
            this.DateselectLabel.TabIndex = 22;
            this.DateselectLabel.Text = "Date :";
            // 
            // SelectItemLabel1
            // 
            this.SelectItemLabel1.AutoSize = true;
            this.SelectItemLabel1.Location = new System.Drawing.Point(8, 82);
            this.SelectItemLabel1.Name = "SelectItemLabel1";
            this.SelectItemLabel1.Size = new System.Drawing.Size(60, 13);
            this.SelectItemLabel1.TabIndex = 23;
            this.SelectItemLabel1.Text = "Select Item";
            // 
            // SelectItemSearchOrderParameterLabel
            // 
            this.SelectItemSearchOrderParameterLabel.AutoSize = true;
            this.SelectItemSearchOrderParameterLabel.Location = new System.Drawing.Point(211, 82);
            this.SelectItemSearchOrderParameterLabel.Name = "SelectItemSearchOrderParameterLabel";
            this.SelectItemSearchOrderParameterLabel.Size = new System.Drawing.Size(60, 13);
            this.SelectItemSearchOrderParameterLabel.TabIndex = 24;
            this.SelectItemSearchOrderParameterLabel.Text = "Select Item";
            // 
            // SelectItemLabel3
            // 
            this.SelectItemLabel3.AutoSize = true;
            this.SelectItemLabel3.Location = new System.Drawing.Point(420, 82);
            this.SelectItemLabel3.Name = "SelectItemLabel3";
            this.SelectItemLabel3.Size = new System.Drawing.Size(60, 13);
            this.SelectItemLabel3.TabIndex = 25;
            this.SelectItemLabel3.Text = "Select Item";
            // 
            // SelectItemLabel4
            // 
            this.SelectItemLabel4.AutoSize = true;
            this.SelectItemLabel4.Location = new System.Drawing.Point(624, 82);
            this.SelectItemLabel4.Name = "SelectItemLabel4";
            this.SelectItemLabel4.Size = new System.Drawing.Size(60, 13);
            this.SelectItemLabel4.TabIndex = 26;
            this.SelectItemLabel4.Text = "Select Item";
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SaveOrderButton.Location = new System.Drawing.Point(835, 283);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(184, 95);
            this.SaveOrderButton.TabIndex = 29;
            this.SaveOrderButton.Text = "Save Filtered Order Results";
            this.SaveOrderButton.UseVisualStyleBackColor = true;
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // ColumnChartTextBox
            // 
            this.ColumnChartTextBox.AutoSize = true;
            this.ColumnChartTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColumnChartTextBox.Location = new System.Drawing.Point(825, 229);
            this.ColumnChartTextBox.Name = "ColumnChartTextBox";
            this.ColumnChartTextBox.Size = new System.Drawing.Size(0, 13);
            this.ColumnChartTextBox.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(703, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 44;
            // 
            // DateChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DateChart.ChartAreas.Add(chartArea1);
            this.DateChart.Location = new System.Drawing.Point(835, 425);
            this.DateChart.Name = "DateChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DateChart.Series.Add(series1);
            this.DateChart.Size = new System.Drawing.Size(774, 264);
            this.DateChart.TabIndex = 40;
            this.DateChart.Text = "DateChart";
            // 
            // StoreChart
            // 
            this.StoreChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.StoreChart.ChartAreas.Add(chartArea2);
            this.StoreChart.Location = new System.Drawing.Point(836, 724);
            this.StoreChart.Name = "StoreChart";
            this.StoreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StoreChart.Series.Add(series2);
            this.StoreChart.Size = new System.Drawing.Size(773, 264);
            this.StoreChart.TabIndex = 18;
            this.StoreChart.Text = "Store Chart";
            // 
            // SupplierTypeChart
            // 
            chartArea3.Name = "ChartArea1";
            this.SupplierTypeChart.ChartAreas.Add(chartArea3);
            this.SupplierTypeChart.Location = new System.Drawing.Point(10, 425);
            this.SupplierTypeChart.Name = "SupplierTypeChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.SupplierTypeChart.Series.Add(series3);
            this.SupplierTypeChart.Size = new System.Drawing.Size(573, 264);
            this.SupplierTypeChart.TabIndex = 47;
            this.SupplierTypeChart.Text = "SupplierTypeChart";
            // 
            // SupplierNameChart
            // 
            chartArea4.Name = "ChartArea1";
            this.SupplierNameChart.ChartAreas.Add(chartArea4);
            this.SupplierNameChart.Location = new System.Drawing.Point(10, 724);
            this.SupplierNameChart.Name = "SupplierNameChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.SupplierNameChart.Series.Add(series4);
            this.SupplierNameChart.Size = new System.Drawing.Size(573, 264);
            this.SupplierNameChart.TabIndex = 48;
            this.SupplierNameChart.Text = "SupplierNameChart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(615, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 52;
            // 
            // SupplierTypeChartResultList
            // 
            this.SupplierTypeChartResultList.FormattingEnabled = true;
            this.SupplierTypeChartResultList.Location = new System.Drawing.Point(606, 429);
            this.SupplierTypeChartResultList.Name = "SupplierTypeChartResultList";
            this.SupplierTypeChartResultList.Size = new System.Drawing.Size(207, 251);
            this.SupplierTypeChartResultList.TabIndex = 53;
            // 
            // SupplierNameChartResultList
            // 
            this.SupplierNameChartResultList.FormattingEnabled = true;
            this.SupplierNameChartResultList.Location = new System.Drawing.Point(606, 733);
            this.SupplierNameChartResultList.Name = "SupplierNameChartResultList";
            this.SupplierNameChartResultList.Size = new System.Drawing.Size(207, 238);
            this.SupplierNameChartResultList.TabIndex = 56;
            // 
            // StoreChartResultList
            // 
            this.StoreChartResultList.FormattingEnabled = true;
            this.StoreChartResultList.Location = new System.Drawing.Point(1632, 737);
            this.StoreChartResultList.Name = "StoreChartResultList";
            this.StoreChartResultList.Size = new System.Drawing.Size(207, 238);
            this.StoreChartResultList.TabIndex = 62;
            // 
            // DateChartResultList
            // 
            this.DateChartResultList.FormattingEnabled = true;
            this.DateChartResultList.Location = new System.Drawing.Point(1632, 429);
            this.DateChartResultList.Name = "DateChartResultList";
            this.DateChartResultList.Size = new System.Drawing.Size(207, 251);
            this.DateChartResultList.TabIndex = 59;
            // 
            // DateList
            // 
            this.DateList.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.DateList.FormattingEnabled = true;
            this.DateList.ItemHeight = 12;
            this.DateList.Location = new System.Drawing.Point(214, 98);
            this.DateList.Name = "DateList";
            this.DateList.Size = new System.Drawing.Size(198, 280);
            this.DateList.TabIndex = 63;
            this.DateList.SelectedIndexChanged += new System.EventHandler(this.DateList_SelectedIndexChanged);
            // 
            // SupplierTypeList
            // 
            this.SupplierTypeList.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.SupplierTypeList.FormattingEnabled = true;
            this.SupplierTypeList.ItemHeight = 12;
            this.SupplierTypeList.Location = new System.Drawing.Point(423, 98);
            this.SupplierTypeList.Name = "SupplierTypeList";
            this.SupplierTypeList.Size = new System.Drawing.Size(198, 280);
            this.SupplierTypeList.TabIndex = 64;
            this.SupplierTypeList.SelectedIndexChanged += new System.EventHandler(this.SupplierTypeList_SelectedIndexChanged);
            // 
            // SupplierNameList
            // 
            this.SupplierNameList.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.SupplierNameList.FormattingEnabled = true;
            this.SupplierNameList.ItemHeight = 12;
            this.SupplierNameList.Location = new System.Drawing.Point(628, 98);
            this.SupplierNameList.Name = "SupplierNameList";
            this.SupplierNameList.Size = new System.Drawing.Size(198, 280);
            this.SupplierNameList.TabIndex = 65;
            this.SupplierNameList.SelectedIndexChanged += new System.EventHandler(this.SupplierNameList_SelectedIndexChanged);
            // 
            // SaveOrderFolder
            // 
            this.SaveOrderFolder.Location = new System.Drawing.Point(628, 12);
            this.SaveOrderFolder.Name = "SaveOrderFolder";
            this.SaveOrderFolder.Size = new System.Drawing.Size(198, 63);
            this.SaveOrderFolder.TabIndex = 66;
            this.SaveOrderFolder.Text = "Saved Order Results Folder";
            this.SaveOrderFolder.UseVisualStyleBackColor = true;
            this.SaveOrderFolder.Click += new System.EventHandler(this.SaveOrderFolder_Click);
            // 
            // StoreChartLabel
            // 
            this.StoreChartLabel.AutoSize = true;
            this.StoreChartLabel.Location = new System.Drawing.Point(842, 708);
            this.StoreChartLabel.Name = "StoreChartLabel";
            this.StoreChartLabel.Size = new System.Drawing.Size(60, 13);
            this.StoreChartLabel.TabIndex = 67;
            this.StoreChartLabel.Text = "Store Chart";
            // 
            // DateChartLabel
            // 
            this.DateChartLabel.AutoSize = true;
            this.DateChartLabel.Location = new System.Drawing.Point(833, 409);
            this.DateChartLabel.Name = "DateChartLabel";
            this.DateChartLabel.Size = new System.Drawing.Size(58, 13);
            this.DateChartLabel.TabIndex = 68;
            this.DateChartLabel.Text = "Date Chart";
            // 
            // SupplierNameChartLabel
            // 
            this.SupplierNameChartLabel.AutoSize = true;
            this.SupplierNameChartLabel.Location = new System.Drawing.Point(12, 708);
            this.SupplierNameChartLabel.Name = "SupplierNameChartLabel";
            this.SupplierNameChartLabel.Size = new System.Drawing.Size(104, 13);
            this.SupplierNameChartLabel.TabIndex = 69;
            this.SupplierNameChartLabel.Text = "Supplier Name Chart";
            // 
            // SupplierTypeChartLabel
            // 
            this.SupplierTypeChartLabel.AutoSize = true;
            this.SupplierTypeChartLabel.Location = new System.Drawing.Point(8, 416);
            this.SupplierTypeChartLabel.Name = "SupplierTypeChartLabel";
            this.SupplierTypeChartLabel.Size = new System.Drawing.Size(100, 13);
            this.SupplierTypeChartLabel.TabIndex = 70;
            this.SupplierTypeChartLabel.Text = "Supplier Type Chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 1000);
            this.Controls.Add(this.SupplierTypeChartLabel);
            this.Controls.Add(this.SupplierNameChartLabel);
            this.Controls.Add(this.DateChartLabel);
            this.Controls.Add(this.StoreChartLabel);
            this.Controls.Add(this.SaveOrderFolder);
            this.Controls.Add(this.SupplierNameList);
            this.Controls.Add(this.SupplierTypeList);
            this.Controls.Add(this.DateList);
            this.Controls.Add(this.StoreChartResultList);
            this.Controls.Add(this.DateChartResultList);
            this.Controls.Add(this.SupplierNameChartResultList);
            this.Controls.Add(this.SupplierTypeChartResultList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierNameChart);
            this.Controls.Add(this.SupplierTypeChart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateChart);
            this.Controls.Add(this.ColumnChartTextBox);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.SelectItemLabel4);
            this.Controls.Add(this.SelectItemLabel3);
            this.Controls.Add(this.SelectItemSearchOrderParameterLabel);
            this.Controls.Add(this.SelectItemLabel1);
            this.Controls.Add(this.DateselectLabel);
            this.Controls.Add(this.SupplierTypeSelectLabel);
            this.Controls.Add(this.StoreCodeSelectLabel);
            this.Controls.Add(this.SupplierNameSelectLabel);
            this.Controls.Add(this.SearchOrderParameterLabel);
            this.Controls.Add(this.StoreChart);
            this.Controls.Add(this.DeselectDateList);
            this.Controls.Add(this.DeselectSupplierType);
            this.Controls.Add(this.DeselectSupplierName);
            this.Controls.Add(this.DeselectStoreCode);
            this.Controls.Add(this.TotalCostFilteredOrders);
            this.Controls.Add(this.SearchOrderButton);
            this.Controls.Add(this.OrderSearchResultsListView);
            this.Controls.Add(this.StoreCodesList);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.StoreCodeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataPathTextBox);
            this.Controls.Add(this.FolderSearchButton);
            this.Name = "Form1";
            this.Text = "DataProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.DateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTypeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierNameChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Button FolderSearchButton;
        public System.Windows.Forms.TextBox DataPathTextBox;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox StoreCodeTextBox;
        public System.Windows.Forms.Button LoadDataButton;
        public System.Windows.Forms.ListBox StoreCodesList;
        public System.Windows.Forms.ListView OrderSearchResultsListView;
        public System.Windows.Forms.Button SearchOrderButton;
        public System.Windows.Forms.ColumnHeader SupplierType;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ColumnHeader StoreCode;
        public System.Windows.Forms.ColumnHeader SupplierName;
        public System.Windows.Forms.ColumnHeader Date;
        public System.Windows.Forms.ColumnHeader Cost;

        public System.Windows.Forms.Label TotalCostFilteredOrders;
        public System.Windows.Forms.Button DeselectStoreCode;
        public System.Windows.Forms.Button DeselectSupplierName;
        public System.Windows.Forms.Button DeselectSupplierType;
        public System.Windows.Forms.Button DeselectDateList;
        public System.Windows.Forms.Label SearchOrderParameterLabel;
        public System.Windows.Forms.Label SupplierNameSelectLabel;
        public System.Windows.Forms.Label StoreCodeSelectLabel;
        public System.Windows.Forms.Label SupplierTypeSelectLabel;
        public System.Windows.Forms.Label DateselectLabel;
        public System.Windows.Forms.Label SelectItemLabel1;
        public System.Windows.Forms.Label SelectItemSearchOrderParameterLabel;
        public System.Windows.Forms.Label SelectItemLabel3;
        public System.Windows.Forms.Label SelectItemLabel4;
        public System.Windows.Forms.Button SaveOrderButton;
        public System.Windows.Forms.Label ColumnChartTextBox;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataVisualization.Charting.Chart DateChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart StoreChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart SupplierTypeChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart SupplierNameChart;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox SupplierTypeChartResultList;
        public System.Windows.Forms.ListBox SupplierNameChartResultList;
        public System.Windows.Forms.ListBox StoreChartResultList;
        public System.Windows.Forms.ListBox DateChartResultList;
        public System.Windows.Forms.ListBox DateList;
        public System.Windows.Forms.ListBox SupplierTypeList;
        public System.Windows.Forms.ListBox SupplierNameList;
        public System.Windows.Forms.Button SaveOrderFolder;

        private System.Windows.Forms.Label StoreChartLabel;
        private System.Windows.Forms.Label DateChartLabel;
        private System.Windows.Forms.Label SupplierNameChartLabel;
        private System.Windows.Forms.Label SupplierTypeChartLabel;
    }
}

