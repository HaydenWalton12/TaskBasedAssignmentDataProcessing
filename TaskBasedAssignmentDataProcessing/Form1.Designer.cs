
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.FolderSearchButton = new System.Windows.Forms.Button();
            this.DataPathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StoreCodeTextBox = new System.Windows.Forms.TextBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.StoreCodesList = new System.Windows.Forms.ListBox();
            this.SupplierTypeList = new System.Windows.Forms.ListBox();
            this.OrderSerchResultsListView = new System.Windows.Forms.ListView();
            this.StoreCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierNameList = new System.Windows.Forms.ListBox();
            this.DatesListBox = new System.Windows.Forms.ListBox();
            this.SearchOrderButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TotalCostFilteredOrders = new System.Windows.Forms.Label();
            this.DeselectStoreCode = new System.Windows.Forms.Button();
            this.DeselectSupplierName = new System.Windows.Forms.Button();
            this.DeselectSupplierType = new System.Windows.Forms.Button();
            this.DeselectDateList = new System.Windows.Forms.Button();
            this.ColumnChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierNameSelectLabel = new System.Windows.Forms.Label();
            this.StoreCodeSelectLabel = new System.Windows.Forms.Label();
            this.SupplierTypeSelectLabel = new System.Windows.Forms.Label();
            this.DateSelectLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearOrderList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColumnChartLabel = new System.Windows.Forms.Label();
            this.ColumnChartTextBox = new System.Windows.Forms.Label();
            this.ColumnChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ResultsListBox1 = new System.Windows.Forms.ListBox();
            this.ResultsListBox2 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OrderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderSearchButton
            // 
            this.FolderSearchButton.Location = new System.Drawing.Point(287, 10);
            this.FolderSearchButton.Name = "FolderSearchButton";
            this.FolderSearchButton.Size = new System.Drawing.Size(82, 44);
            this.FolderSearchButton.TabIndex = 0;
            this.FolderSearchButton.Text = "Data Folder";
            this.FolderSearchButton.UseVisualStyleBackColor = true;
            this.FolderSearchButton.Click += new System.EventHandler(this.FindDataPathClick);
            // 
            // DataPathTextBox
            // 
            this.DataPathTextBox.Location = new System.Drawing.Point(375, 10);
            this.DataPathTextBox.Multiline = true;
            this.DataPathTextBox.Name = "DataPathTextBox";
            this.DataPathTextBox.Size = new System.Drawing.Size(180, 45);
            this.DataPathTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadStoreCodeClick);
            // 
            // StoreCodeTextBox
            // 
            this.StoreCodeTextBox.Location = new System.Drawing.Point(98, 10);
            this.StoreCodeTextBox.Multiline = true;
            this.StoreCodeTextBox.Name = "StoreCodeTextBox";
            this.StoreCodeTextBox.Size = new System.Drawing.Size(176, 45);
            this.StoreCodeTextBox.TabIndex = 3;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(561, 11);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(237, 44);
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
            this.StoreCodesList.Location = new System.Drawing.Point(13, 80);
            this.StoreCodesList.Name = "StoreCodesList";
            this.StoreCodesList.Size = new System.Drawing.Size(121, 172);
            this.StoreCodesList.TabIndex = 5;
            this.StoreCodesList.SelectedIndexChanged += new System.EventHandler(this.StoreCodesList_SelectedIndexChanged);
            // 
            // SupplierTypeList
            // 
            this.SupplierTypeList.FormattingEnabled = true;
            this.SupplierTypeList.Location = new System.Drawing.Point(288, 79);
            this.SupplierTypeList.Name = "SupplierTypeList";
            this.SupplierTypeList.Size = new System.Drawing.Size(121, 173);
            this.SupplierTypeList.TabIndex = 6;
            this.SupplierTypeList.SelectedIndexChanged += new System.EventHandler(this.SupplierTypeList_SelectedIndexChanged);
            // 
            // OrderSerchResultsListView
            // 
            this.OrderSerchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StoreCode,
            this.SupplierType,
            this.SupplierName,
            this.Date,
            this.Cost});
            this.OrderSerchResultsListView.FullRowSelect = true;
            this.OrderSerchResultsListView.GridLines = true;
            this.OrderSerchResultsListView.HideSelection = false;
            this.OrderSerchResultsListView.Location = new System.Drawing.Point(16, 293);
            this.OrderSerchResultsListView.Name = "OrderSerchResultsListView";
            this.OrderSerchResultsListView.Size = new System.Drawing.Size(529, 347);
            this.OrderSerchResultsListView.TabIndex = 7;
            this.OrderSerchResultsListView.UseCompatibleStateImageBehavior = false;
            this.OrderSerchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // StoreCode
            // 
            this.StoreCode.Text = "Store";
            this.StoreCode.Width = 100;
            // 
            // SupplierType
            // 
            this.SupplierType.Text = "Supplier Type";
            this.SupplierType.Width = 130;
            // 
            // SupplierName
            // 
            this.SupplierName.Text = "Supplier Name";
            this.SupplierName.Width = 130;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 110;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 110;
            // 
            // SupplierNameList
            // 
            this.SupplierNameList.FormattingEnabled = true;
            this.SupplierNameList.Location = new System.Drawing.Point(153, 79);
            this.SupplierNameList.Name = "SupplierNameList";
            this.SupplierNameList.Size = new System.Drawing.Size(121, 173);
            this.SupplierNameList.TabIndex = 8;
            this.SupplierNameList.SelectedIndexChanged += new System.EventHandler(this.SupplierNameList_SelectedIndexChanged);
            // 
            // DatesListBox
            // 
            this.DatesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DatesListBox.FormattingEnabled = true;
            this.DatesListBox.ItemHeight = 9;
            this.DatesListBox.Location = new System.Drawing.Point(424, 79);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(121, 166);
            this.DatesListBox.TabIndex = 9;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.Location = new System.Drawing.Point(561, 79);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(85, 51);
            this.SearchOrderButton.TabIndex = 10;
            this.SearchOrderButton.Text = "Search Order";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // TotalCostFilteredOrders
            // 
            this.TotalCostFilteredOrders.AutoSize = true;
            this.TotalCostFilteredOrders.Location = new System.Drawing.Point(675, 157);
            this.TotalCostFilteredOrders.Name = "TotalCostFilteredOrders";
            this.TotalCostFilteredOrders.Size = new System.Drawing.Size(70, 13);
            this.TotalCostFilteredOrders.TabIndex = 11;
            this.TotalCostFilteredOrders.Text = "Total Cost : £";
            // 
            // DeselectStoreCode
            // 
            this.DeselectStoreCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectStoreCode.Location = new System.Drawing.Point(14, 258);
            this.DeselectStoreCode.Name = "DeselectStoreCode";
            this.DeselectStoreCode.Size = new System.Drawing.Size(122, 29);
            this.DeselectStoreCode.TabIndex = 13;
            this.DeselectStoreCode.Text = "Deselect Store Code";
            this.DeselectStoreCode.UseVisualStyleBackColor = true;
            this.DeselectStoreCode.Click += new System.EventHandler(this.DeselectStoreCode_Click);
            // 
            // DeselectSupplierName
            // 
            this.DeselectSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectSupplierName.Location = new System.Drawing.Point(153, 258);
            this.DeselectSupplierName.Name = "DeselectSupplierName";
            this.DeselectSupplierName.Size = new System.Drawing.Size(122, 29);
            this.DeselectSupplierName.TabIndex = 14;
            this.DeselectSupplierName.Text = "Deselect Supplier Name";
            this.DeselectSupplierName.UseVisualStyleBackColor = true;
            this.DeselectSupplierName.Click += new System.EventHandler(this.DeselectSupplierName_Click);
            // 
            // DeselectSupplierType
            // 
            this.DeselectSupplierType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectSupplierType.Location = new System.Drawing.Point(288, 258);
            this.DeselectSupplierType.Name = "DeselectSupplierType";
            this.DeselectSupplierType.Size = new System.Drawing.Size(120, 29);
            this.DeselectSupplierType.TabIndex = 15;
            this.DeselectSupplierType.Text = "Deselect Supplier List";
            this.DeselectSupplierType.UseVisualStyleBackColor = true;
            this.DeselectSupplierType.Click += new System.EventHandler(this.DeselectSupplierType_Click);
            // 
            // DeselectDateList
            // 
            this.DeselectDateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectDateList.Location = new System.Drawing.Point(425, 258);
            this.DeselectDateList.Name = "DeselectDateList";
            this.DeselectDateList.Size = new System.Drawing.Size(120, 29);
            this.DeselectDateList.TabIndex = 16;
            this.DeselectDateList.Text = "Deselect Date List";
            this.DeselectDateList.UseVisualStyleBackColor = true;
            this.DeselectDateList.Click += new System.EventHandler(this.DeselectDateList_Click);
            // 
            // ColumnChart1
            // 
            this.ColumnChart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.ColumnChart1.ChartAreas.Add(chartArea1);
            this.ColumnChart1.Location = new System.Drawing.Point(953, 12);
            this.ColumnChart1.Name = "ColumnChart1";
            this.ColumnChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            this.ColumnChart1.Size = new System.Drawing.Size(521, 288);
            this.ColumnChart1.TabIndex = 18;
            this.ColumnChart1.Text = "Column Chart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Order Search Parameters :";
            // 
            // SupplierNameSelectLabel
            // 
            this.SupplierNameSelectLabel.AutoSize = true;
            this.SupplierNameSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierNameSelectLabel.Location = new System.Drawing.Point(675, 117);
            this.SupplierNameSelectLabel.Name = "SupplierNameSelectLabel";
            this.SupplierNameSelectLabel.Size = new System.Drawing.Size(81, 13);
            this.SupplierNameSelectLabel.TabIndex = 20;
            this.SupplierNameSelectLabel.Text = "Supplier Name: ";
            // 
            // StoreCodeSelectLabel
            // 
            this.StoreCodeSelectLabel.AutoSize = true;
            this.StoreCodeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.StoreCodeSelectLabel.Location = new System.Drawing.Point(675, 104);
            this.StoreCodeSelectLabel.Name = "StoreCodeSelectLabel";
            this.StoreCodeSelectLabel.Size = new System.Drawing.Size(69, 13);
            this.StoreCodeSelectLabel.TabIndex = 20;
            this.StoreCodeSelectLabel.Text = "Store Code : ";
            // 
            // SupplierTypeSelectLabel
            // 
            this.SupplierTypeSelectLabel.AutoSize = true;
            this.SupplierTypeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierTypeSelectLabel.Location = new System.Drawing.Point(675, 130);
            this.SupplierTypeSelectLabel.Name = "SupplierTypeSelectLabel";
            this.SupplierTypeSelectLabel.Size = new System.Drawing.Size(79, 13);
            this.SupplierTypeSelectLabel.TabIndex = 21;
            this.SupplierTypeSelectLabel.Text = "Supplier Type : ";
            // 
            // DateSelectLabel
            // 
            this.DateSelectLabel.AutoSize = true;
            this.DateSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.DateSelectLabel.Location = new System.Drawing.Point(675, 143);
            this.DateSelectLabel.Name = "DateSelectLabel";
            this.DateSelectLabel.Size = new System.Drawing.Size(36, 13);
            this.DateSelectLabel.TabIndex = 22;
            this.DateSelectLabel.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Select Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Select Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Select Item";
            // 
            // ClearOrderList
            // 
            this.ClearOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ClearOrderList.Location = new System.Drawing.Point(561, 193);
            this.ClearOrderList.Name = "ClearOrderList";
            this.ClearOrderList.Size = new System.Drawing.Size(86, 52);
            this.ClearOrderList.TabIndex = 27;
            this.ClearOrderList.Text = "Clear List";
            this.ClearOrderList.UseVisualStyleBackColor = true;
            this.ClearOrderList.Click += new System.EventHandler(this.ClearOrderList_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(1495, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear Chart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(561, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 51);
            this.button3.TabIndex = 29;
            this.button3.Text = "Save Filtered Order Results";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(1495, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 246);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // ColumnChartLabel
            // 
            this.ColumnChartLabel.AutoSize = true;
            this.ColumnChartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColumnChartLabel.Location = new System.Drawing.Point(1578, 13);
            this.ColumnChartLabel.Name = "ColumnChartLabel";
            this.ColumnChartLabel.Size = new System.Drawing.Size(70, 13);
            this.ColumnChartLabel.TabIndex = 38;
            this.ColumnChartLabel.Text = "Column Chart";
            // 
            // ColumnChartTextBox
            // 
            this.ColumnChartTextBox.AutoSize = true;
            this.ColumnChartTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColumnChartTextBox.Location = new System.Drawing.Point(1515, 47);
            this.ColumnChartTextBox.Name = "ColumnChartTextBox";
            this.ColumnChartTextBox.Size = new System.Drawing.Size(0, 13);
            this.ColumnChartTextBox.TabIndex = 39;
            // 
            // ColumnChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.ColumnChart2.ChartAreas.Add(chartArea2);
            this.ColumnChart2.Location = new System.Drawing.Point(953, 324);
            this.ColumnChart2.Name = "ColumnChart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ColumnChart2.Series.Add(series2);
            this.ColumnChart2.Size = new System.Drawing.Size(521, 300);
            this.ColumnChart2.TabIndex = 40;
            this.ColumnChart2.Text = "ColumnChart2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(1515, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(1578, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Column Chart";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(1495, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 246);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(1495, 587);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 26);
            this.button4.TabIndex = 41;
            this.button4.Text = "Clear Chart";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ResultsListBox1
            // 
            this.ResultsListBox1.FormattingEnabled = true;
            this.ResultsListBox1.Location = new System.Drawing.Point(1518, 33);
            this.ResultsListBox1.Name = "ResultsListBox1";
            this.ResultsListBox1.Size = new System.Drawing.Size(199, 212);
            this.ResultsListBox1.TabIndex = 46;
            // 
            // ResultsListBox2
            // 
            this.ResultsListBox2.FormattingEnabled = true;
            this.ResultsListBox2.Location = new System.Drawing.Point(1518, 344);
            this.ResultsListBox2.Name = "ResultsListBox2";
            this.ResultsListBox2.Size = new System.Drawing.Size(199, 212);
            this.ResultsListBox2.TabIndex = 47;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(551, 324);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(389, 169);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // OrderColumn
            // 
            this.OrderColumn.Text = "Order";
            this.OrderColumn.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 749);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ResultsListBox2);
            this.Controls.Add(this.ResultsListBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ColumnChart2);
            this.Controls.Add(this.ColumnChartTextBox);
            this.Controls.Add(this.ColumnChartLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearOrderList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateSelectLabel);
            this.Controls.Add(this.SupplierTypeSelectLabel);
            this.Controls.Add(this.StoreCodeSelectLabel);
            this.Controls.Add(this.SupplierNameSelectLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColumnChart1);
            this.Controls.Add(this.DeselectDateList);
            this.Controls.Add(this.DeselectSupplierType);
            this.Controls.Add(this.DeselectSupplierName);
            this.Controls.Add(this.DeselectStoreCode);
            this.Controls.Add(this.TotalCostFilteredOrders);
            this.Controls.Add(this.SearchOrderButton);
            this.Controls.Add(this.DatesListBox);
            this.Controls.Add(this.SupplierNameList);
            this.Controls.Add(this.OrderSerchResultsListView);
            this.Controls.Add(this.SupplierTypeList);
            this.Controls.Add(this.StoreCodesList);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.StoreCodeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataPathTextBox);
            this.Controls.Add(this.FolderSearchButton);
            this.Name = "Form1";
            this.Text = "DataProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        public System.Windows.Forms.ListBox SupplierTypeList;
        public System.Windows.Forms.ListView OrderSerchResultsListView;
        public System.Windows.Forms.ListBox SupplierNameList;
        public System.Windows.Forms.ListBox DatesListBox;
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
        public System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label SupplierNameSelectLabel;
        public System.Windows.Forms.Label StoreCodeSelectLabel;
        public System.Windows.Forms.Label SupplierTypeSelectLabel;
        public System.Windows.Forms.Label DateSelectLabel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button ClearOrderList;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ColumnChartLabel;
        public System.Windows.Forms.Label ColumnChartTextBox;
        public System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart2;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListBox ResultsListBox1;
        public System.Windows.Forms.ListBox ResultsListBox2;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader OrderColumn;
    }
}

