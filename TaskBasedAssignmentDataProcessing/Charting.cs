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
        /// Each one of these works the same essentially : 
        /// 1.)WIth the givne queried data passed into the funciton , we use a foreach
        /// this foreach iterates threw the amount of values given in the list for the specfic function
        /// 2.)We split up each function into its individual segement of graph data , adding to a list
        /// 3.)We then iterate threw each queried order, using each checking each chart data field with the selected filtered choice, if theres a match
        /// we add to that field instance
        /// 4.)We then iterate threw each field , checking if each field has a count/value greater than zero , if it is , we populate the graph
        /// assigned to that field with the current data given
        /// </summary>
        public void StoreChart(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> chart_data = new List<GraphData>();
            List<GraphData> chart_result = new List<GraphData>();


            foreach (var type in form1.StoreCodesList.Items)
            {
                string[] temp = type.ToString().Split(' ');

                GraphData data = new GraphData
                {
                    Field = temp[0],
                    Count = 0
                };
                chart_data.Add(data);
            }
            foreach (var order in QueriedOrders)
            {
                for (int i = 0; i < chart_data.Count; i++)
                {
                    if (chart_data[i].Field == order.StoreCode)
                    {
                        chart_data[i].Count += order.Cost;
                    }
                }
            }

            form1.StoreChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var data in chart_data)
            {
                if (data.Count > 0)
                {
                    form1.StoreChart.Series[0].Points.AddXY(data.Field, data.Count);

                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    chart_result.Add(item);
                }
            }
            foreach(var data in chart_result)
            {
                form1.Storechart_resultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }
        public  void DateChart(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> chart_data = new List<GraphData>();
            List<GraphData> chart_result = new List<GraphData>();

            foreach (var type in form1.DateList.Items)
            {
                GraphData data = new GraphData
                {
                    Field = type.ToString(),
                    Count = 0
                };
                chart_data.Add(data);
            }

            foreach (var order in QueriedOrders)
            {
                for (int i = 0; i < chart_data.Count; i++)
                {
                    if (chart_data[i].Field == "Week : " + order.Date.Week.ToString() + " Year : " + order.Date.Year.ToString())
                    {
                        chart_data[i].Count += order.Cost;
                    }
                }
                
            }




            form1.DateChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var data in chart_data)
            {
                if (data.Count > 0)
                {
                    form1.DateChart.Series[0].Points.AddXY(data.Field, data.Count);
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    chart_result.Add(item);
                }
                }


            foreach (var data in chart_result)
            {
                form1.Datechart_resultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }
        public void SupplierType(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> chart_data = new List<GraphData>();
            List<GraphData> chart_result = new List<GraphData>();

            foreach (var type in form1.SupplierTypeList.Items)
            {
                GraphData data = new GraphData
                {
                    Field = type.ToString(),
                    Count = 0

                };

                chart_data.Add(data);
            }

            //iterates threw all queried data
            foreach (var order in QueriedOrders)
            {
                //Iterates Based Upon The chart Data count
                for (int i = 0; i < chart_data.Count; i++)
                {
                    //If the Chartdate indexed field equals an Orders suppliertype instance
                    if (chart_data[i].Field == order.SupplierType)
                    {
                        chart_data[i].Count += order.Cost;
                    }
                }
            }
     
            form1.SupplierTypeChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var data in chart_data)
            {
                if (data.Count > 0)
                {
                    form1.SupplierTypeChart.Series[0].Points.AddXY(data.Field, data.Count);
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    chart_result.Add(item);
                }
                }
           
            foreach (var data in chart_result)
            {
                form1.SupplierTypechart_resultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }
        public void SupplierName(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> chart_data = new List<GraphData>();
            List<GraphData> chart_result = new List<GraphData>();

            foreach (var type in form1.SupplierNameList.Items)
            {
                GraphData data = new GraphData
                {
                    Field = type.ToString(),
                    Count = 0
                };

                chart_data.Add(data);
            }
         
            foreach (var order in QueriedOrders)
            {
                for (int i = 0; i < chart_data.Count; i++)
                {
                    if (chart_data[i].Field == order.SupplierName)
                    {
                        chart_data[i].Count += order.Cost;

                    }
                }
            }
        
            //Populates The Graph
            //Allows Each Label To Interval Correctly
            form1.SupplierNameChart.ChartAreas[0].AxisX.LabelStyle.Interval = 0.5;
            foreach (var data in chart_data)
            {
                if (data.Count > 0)
                {
                    form1.SupplierNameChart.Series[0].Points.AddXY(data.Field, data.Count);
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    chart_result.Add(item);
                }
            }
   
            foreach (var data in chart_result)
            {
                form1.SupplierNamechart_resultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }

    }
}
