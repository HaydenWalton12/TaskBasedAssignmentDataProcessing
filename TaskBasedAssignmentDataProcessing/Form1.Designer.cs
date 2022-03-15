
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            this.LoadDataButton.Location = new System.Drawing.Point(565, 10);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(179, 44);
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
            this.StoreCodesList.Location = new System.Drawing.Point(10, 70);
            this.StoreCodesList.Name = "StoreCodesList";
            this.StoreCodesList.Size = new System.Drawing.Size(121, 160);
            this.StoreCodesList.TabIndex = 5;
            this.StoreCodesList.SelectedIndexChanged += new System.EventHandler(this.StoreCodesList_SelectedIndexChanged);
            // 
            // SupplierTypeList
            // 
            this.SupplierTypeList.FormattingEnabled = true;
            this.SupplierTypeList.Location = new System.Drawing.Point(287, 70);
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
            this.OrderSerchResultsListView.Location = new System.Drawing.Point(10, 284);
            this.OrderSerchResultsListView.Name = "OrderSerchResultsListView";
            this.OrderSerchResultsListView.Size = new System.Drawing.Size(534, 187);
            this.OrderSerchResultsListView.TabIndex = 7;
            this.OrderSerchResultsListView.UseCompatibleStateImageBehavior = false;
            this.OrderSerchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // StoreCode
            // 
            this.StoreCode.Text = "Store";
            this.StoreCode.Width = 140;
            // 
            // SupplierType
            // 
            this.SupplierType.Text = "Supplier Type";
            this.SupplierType.Width = 130;
            // 
            // SupplierName
            // 
            this.SupplierName.Text = "Supplier";
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
            this.SupplierNameList.Location = new System.Drawing.Point(152, 70);
            this.SupplierNameList.Name = "SupplierNameList";
            this.SupplierNameList.Size = new System.Drawing.Size(121, 173);
            this.SupplierNameList.TabIndex = 8;
            this.SupplierNameList.SelectedIndexChanged += new System.EventHandler(this.SupplierNameList_SelectedIndexChanged);
            // 
            // DatesListBox
            // 
            this.DatesListBox.FormattingEnabled = true;
            this.DatesListBox.Location = new System.Drawing.Point(422, 70);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(121, 173);
            this.DatesListBox.TabIndex = 9;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.Location = new System.Drawing.Point(565, 70);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(179, 185);
            this.SearchOrderButton.TabIndex = 10;
            this.SearchOrderButton.Text = "Search Order";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // TotalCostFilteredOrders
            // 
            this.TotalCostFilteredOrders.AutoSize = true;
            this.TotalCostFilteredOrders.Location = new System.Drawing.Point(10, 481);
            this.TotalCostFilteredOrders.Name = "TotalCostFilteredOrders";
            this.TotalCostFilteredOrders.Size = new System.Drawing.Size(55, 13);
            this.TotalCostFilteredOrders.TabIndex = 11;
            this.TotalCostFilteredOrders.Text = "Total Cost";
            // 
            // DeselectStoreCode
            // 
            this.DeselectStoreCode.Location = new System.Drawing.Point(10, 245);
            this.DeselectStoreCode.Name = "DeselectStoreCode";
            this.DeselectStoreCode.Size = new System.Drawing.Size(122, 18);
            this.DeselectStoreCode.TabIndex = 13;
            this.DeselectStoreCode.Text = "Deselect Store Code";
            this.DeselectStoreCode.UseVisualStyleBackColor = true;
            this.DeselectStoreCode.Click += new System.EventHandler(this.DeselectStoreCode_Click);
            // 
            // DeselectSupplierName
            // 
            this.DeselectSupplierName.Location = new System.Drawing.Point(152, 245);
            this.DeselectSupplierName.Name = "DeselectSupplierName";
            this.DeselectSupplierName.Size = new System.Drawing.Size(122, 18);
            this.DeselectSupplierName.TabIndex = 14;
            this.DeselectSupplierName.Text = "Deselect Supplier Name";
            this.DeselectSupplierName.UseVisualStyleBackColor = true;
            this.DeselectSupplierName.Click += new System.EventHandler(this.DeselectSupplierName_Click);
            // 
            // DeselectSupplierType
            // 
            this.DeselectSupplierType.Location = new System.Drawing.Point(287, 248);
            this.DeselectSupplierType.Name = "DeselectSupplierType";
            this.DeselectSupplierType.Size = new System.Drawing.Size(120, 18);
            this.DeselectSupplierType.TabIndex = 15;
            this.DeselectSupplierType.Text = "Deselect Supplier List";
            this.DeselectSupplierType.UseVisualStyleBackColor = true;
            this.DeselectSupplierType.Click += new System.EventHandler(this.DeselectSupplierType_Click);
            // 
            // DeselectDateList
            // 
            this.DeselectDateList.Location = new System.Drawing.Point(422, 248);
            this.DeselectDateList.Name = "DeselectDateList";
            this.DeselectDateList.Size = new System.Drawing.Size(120, 19);
            this.DeselectDateList.TabIndex = 16;
            this.DeselectDateList.Text = "Deselect Date List";
            this.DeselectDateList.UseVisualStyleBackColor = true;
            this.DeselectDateList.Click += new System.EventHandler(this.DeselectDateList_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(767, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 232);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(767, 275);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 187);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 520);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button FolderSearchButton;
        private System.Windows.Forms.TextBox DataPathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StoreCodeTextBox;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.ListBox StoreCodesList;
        private System.Windows.Forms.ListBox SupplierTypeList;
        private System.Windows.Forms.ListView OrderSerchResultsListView;
        private System.Windows.Forms.ListBox SupplierNameList;
        private System.Windows.Forms.ListBox DatesListBox;
        private System.Windows.Forms.Button SearchOrderButton;
        private System.Windows.Forms.ColumnHeader SupplierType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader StoreCode;
        private System.Windows.Forms.ColumnHeader SupplierName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Cost;

        private System.Windows.Forms.Label TotalCostFilteredOrders;
        private System.Windows.Forms.Button DeselectStoreCode;
        private System.Windows.Forms.Button DeselectSupplierName;
        private System.Windows.Forms.Button DeselectSupplierType;
        private System.Windows.Forms.Button DeselectDateList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

