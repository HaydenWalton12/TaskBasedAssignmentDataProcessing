using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBasedForms
{

    partial class FormCharting
    {
        Form1 form1;
        public FormCharting(Form1 form)
        {
            form1 = form;

        }
        

        /// <summary>
        /// 
        /// 
        /// 
        /// </summary>
        public void CreateCharts(IEnumerable<Order> queried_orders, int data_processing_choice)
        {
            List<GraphData> ChartData = new List<GraphData>();
            //Based Upon This Input , THis will Decide What Data We Will Process To Which Chart
            switch (data_processing_choice)
            {
                //Process Supplier Type Cost Results For ColumnChart1
                case 1:
                    foreach (var Type in form1.SupplierTypeList.Items)
                    {
                        GraphData data = new GraphData
                        {
                            Field = Type.ToString(),
                            Count = 0

                        };

                        ChartData.Add(data);
                    }

                    //iterates threw all queried data
                    foreach (var order in queried_orders)
                    {
                        //Iterates Based Upon The chart Data count
                        for (int i = 0; i < ChartData.Count; i++)
                        {
                            //If the Chartdate indexed field equals an orders suppliertype instance
                            if (ChartData[i].Field == order.SupplierType)
                            {
                                ChartData[i].Count += order.Cost;
                            }
                        }
                    }
                    foreach (var data in ChartData)
                    { form1.ColumnChart1.Series.Add(data.Field); }

                    foreach (var data in ChartData)
                    { form1.ColumnChart1.Series.FindByName(data.Field).Points.AddY(data.Count); }
                    break;
                //Process Supplier Type Cost Results For ColumnChart2
                case 2:
                    foreach (var Type in form1.SupplierTypeList.Items)
                    {
                        GraphData data = new GraphData
                        {
                            Field = Type.ToString(),
                            Count = 0

                        };

                        ChartData.Add(data);
                    }

                    foreach (var order in queried_orders)
                    {

                        for (int i = 0; i < ChartData.Count; i++)
                        {

                            if (ChartData[i].Field == order.SupplierType)
                            {
                                ChartData[i].Count += order.Cost;
                            }
                        }
                    }
                    foreach (var data in ChartData)
                    { form1.ColumnChart1.Series.Add(data.Field); }

                    foreach (var data in ChartData)
                    { form1.ColumnChart2.Series.FindByName(data.Field).Points.AddY(data.Count); }
                    break;

                // Process Dates For ColumnChart1
                case 3:
                    //Each Data , Add Into Chart Data (Each Date Holds Unique Position On ColumnChart)
                    foreach (var Type in form1.DatesListBox.Items)
                    {
                        GraphData data = new GraphData
                        {
                            Field = Type.ToString(),
                            Count = 0
                        };
                        ChartData.Add(data);
                    }

                    foreach (var order in queried_orders)
                    {
                        for (int i = 0; i < ChartData.Count; i++)
                        {
                            if (ChartData[i].Field == "Week : " + order.Date.Week.ToString() + " Year : " + order.Date.Year.ToString())
                            {
                                ChartData[i].Count += order.Cost;
                            }
                        }
                    }

                    foreach (var data in ChartData)
                    {
                        if (form1.ColumnChart1.Series.IsUniqueName(data.Field))
                        {
                            form1.ColumnChart1.Series.Add(data.Field);
                        }
                    }

                    foreach (var data in ChartData)
                    { form1.ColumnChart1.Series.FindByName(data.Field).Points.AddY(data.Count); }
                    break;
                // Process Dates For ColumnChart2
                case 4:
                    //Each Data , Add Into Chart Data (Each Date Holds Unique Position On ColumnChart)
                    foreach (var Type in form1.DatesListBox.Items)
                    {
                        GraphData data = new GraphData
                        {
                            Field = Type.ToString(),
                            Count = 0
                        };
                        ChartData.Add(data);
                    }

                    foreach (var order in queried_orders)
                    {
                        for (int i = 0; i < ChartData.Count; i++)
                        {
                            if (ChartData[i].Field == "Week : " + order.Date.Week.ToString() + " Year : " + order.Date.Year.ToString())
                            {
                                ChartData[i].Count += order.Cost;
                            }
                        }
                    }

                    foreach (var data in ChartData)
                    {
                        if (form1.ColumnChart2.Series.IsUniqueName(data.Field))
                        {
                            form1.ColumnChart2.Series.Add(data.Field);
                        }
                    }

                    foreach (var data in ChartData)
                    { form1.ColumnChart2.Series.FindByName(data.Field).Points.AddY(data.Count); }
                    break;
                // Process SupplierNames For ColumnChart1
                case 5:
                    //Each Data , Add Into Chart Data (Each Date Holds Unique Position On ColumnChart)
                    foreach (var Type in form1.SupplierNameList.Items)
                    {
                        GraphData data = new GraphData
                        {
                            Field = Type.ToString(),
                            Count = 0
                        };
                        ChartData.Add(data);
                    }

                    foreach (var order in queried_orders)
                    {
                        for (int i = 0; i < ChartData.Count; i++)
                        {
                            if (ChartData[i].Field == order.SupplierName)
                            {
                                ChartData[i].Count += order.Cost;
                            }
                        }
                    }

                    ////Builds Series
                    //foreach (var data in ChartData)
                    //{
                    //    if (form1.ColumnChart2.Series.IsUniqueName(data.Field))
                    //    {
                    //        form1.ColumnChart2.Series.Add(data.Field);
                    //    }
                    //}

                    //Populates The Graph
                    form1.ColumnChart2.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                    foreach (var data in ChartData)
                    { form1.ColumnChart2.Series[0].Points.AddXY(data.Field , data.Count); }
                    break;
            }

            //double Order_Query_Total = orders.Sum(item => item.Cost);

            //TotalCostFilteredOrders.Text = "Total Cost : £ " + Order_Query_Total.ToString();



        }


    }


}
