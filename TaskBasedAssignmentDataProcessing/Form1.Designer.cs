﻿
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
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.StoreCodesList.Location = new System.Drawing.Point(12, 325);
            this.StoreCodesList.Name = "StoreCodesList";
            this.StoreCodesList.Size = new System.Drawing.Size(121, 172);
            this.StoreCodesList.TabIndex = 5;
            this.StoreCodesList.SelectedIndexChanged += new System.EventHandler(this.StoreCodesList_SelectedIndexChanged);
            // 
            // SupplierTypeList
            // 
            this.SupplierTypeList.FormattingEnabled = true;
            this.SupplierTypeList.Location = new System.Drawing.Point(287, 324);
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
            this.OrderSerchResultsListView.Location = new System.Drawing.Point(10, 61);
            this.OrderSerchResultsListView.Name = "OrderSerchResultsListView";
            this.OrderSerchResultsListView.Size = new System.Drawing.Size(545, 171);
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
            this.SupplierNameList.Location = new System.Drawing.Point(152, 324);
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
            this.DatesListBox.Location = new System.Drawing.Point(423, 324);
            this.DatesListBox.Name = "DatesListBox";
            this.DatesListBox.Size = new System.Drawing.Size(121, 166);
            this.DatesListBox.TabIndex = 9;
            this.DatesListBox.SelectedIndexChanged += new System.EventHandler(this.DatesListBox_SelectedIndexChanged);
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.Location = new System.Drawing.Point(10, 257);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(545, 43);
            this.SearchOrderButton.TabIndex = 10;
            this.SearchOrderButton.Text = "Search Order";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // TotalCostFilteredOrders
            // 
            this.TotalCostFilteredOrders.AutoSize = true;
            this.TotalCostFilteredOrders.Location = new System.Drawing.Point(577, 325);
            this.TotalCostFilteredOrders.Name = "TotalCostFilteredOrders";
            this.TotalCostFilteredOrders.Size = new System.Drawing.Size(70, 13);
            this.TotalCostFilteredOrders.TabIndex = 11;
            this.TotalCostFilteredOrders.Text = "Total Cost : £";
            // 
            // DeselectStoreCode
            // 
            this.DeselectStoreCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DeselectStoreCode.Location = new System.Drawing.Point(13, 503);
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
            this.DeselectSupplierName.Location = new System.Drawing.Point(152, 503);
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
            this.DeselectSupplierType.Location = new System.Drawing.Point(287, 503);
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
            this.DeselectDateList.Location = new System.Drawing.Point(424, 503);
            this.DeselectDateList.Name = "DeselectDateList";
            this.DeselectDateList.Size = new System.Drawing.Size(120, 29);
            this.DeselectDateList.TabIndex = 16;
            this.DeselectDateList.Text = "Deselect Date List";
            this.DeselectDateList.UseVisualStyleBackColor = true;
            this.DeselectDateList.Click += new System.EventHandler(this.DeselectDateList_Click);
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(953, 12);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(521, 288);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Order Search Parameters :";
            // 
            // SupplierNameSelectLabel
            // 
            this.SupplierNameSelectLabel.AutoSize = true;
            this.SupplierNameSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierNameSelectLabel.Location = new System.Drawing.Point(577, 285);
            this.SupplierNameSelectLabel.Name = "SupplierNameSelectLabel";
            this.SupplierNameSelectLabel.Size = new System.Drawing.Size(81, 13);
            this.SupplierNameSelectLabel.TabIndex = 20;
            this.SupplierNameSelectLabel.Text = "Supplier Name: ";
            // 
            // StoreCodeSelectLabel
            // 
            this.StoreCodeSelectLabel.AutoSize = true;
            this.StoreCodeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.StoreCodeSelectLabel.Location = new System.Drawing.Point(577, 272);
            this.StoreCodeSelectLabel.Name = "StoreCodeSelectLabel";
            this.StoreCodeSelectLabel.Size = new System.Drawing.Size(69, 13);
            this.StoreCodeSelectLabel.TabIndex = 20;
            this.StoreCodeSelectLabel.Text = "Store Code : ";
            // 
            // SupplierTypeSelectLabel
            // 
            this.SupplierTypeSelectLabel.AutoSize = true;
            this.SupplierTypeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.SupplierTypeSelectLabel.Location = new System.Drawing.Point(577, 298);
            this.SupplierTypeSelectLabel.Name = "SupplierTypeSelectLabel";
            this.SupplierTypeSelectLabel.Size = new System.Drawing.Size(79, 13);
            this.SupplierTypeSelectLabel.TabIndex = 21;
            this.SupplierTypeSelectLabel.Text = "Supplier Type : ";
            // 
            // DateSelectLabel
            // 
            this.DateSelectLabel.AutoSize = true;
            this.DateSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.DateSelectLabel.Location = new System.Drawing.Point(577, 311);
            this.DateSelectLabel.Name = "DateSelectLabel";
            this.DateSelectLabel.Size = new System.Drawing.Size(36, 13);
            this.DateSelectLabel.TabIndex = 22;
            this.DateSelectLabel.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Select Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Select Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Select Item";
            // 
            // ClearOrderList
            // 
            this.ClearOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ClearOrderList.Location = new System.Drawing.Point(287, 563);
            this.ClearOrderList.Name = "ClearOrderList";
            this.ClearOrderList.Size = new System.Drawing.Size(269, 29);
            this.ClearOrderList.TabIndex = 27;
            this.ClearOrderList.Text = "Clear List";
            this.ClearOrderList.UseVisualStyleBackColor = true;
            this.ClearOrderList.Click += new System.EventHandler(this.ClearOrderList_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(943, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "LoadChart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(10, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 29);
            this.button3.TabIndex = 29;
            this.button3.Text = "Save Filtered Order Results";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(561, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 172);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label3.Location = new System.Drawing.Point(814, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label4.Location = new System.Drawing.Point(814, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Supplier Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label5.Location = new System.Drawing.Point(814, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Store Code : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label6.Location = new System.Drawing.Point(814, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Supplier Name: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(803, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Graph Results";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(814, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Total Cost : £";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox1);
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
            this.Controls.Add(this.chart2);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SupplierNameSelectLabel;
        private System.Windows.Forms.Label StoreCodeSelectLabel;
        private System.Windows.Forms.Label SupplierTypeSelectLabel;
        private System.Windows.Forms.Label DateSelectLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearOrderList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

