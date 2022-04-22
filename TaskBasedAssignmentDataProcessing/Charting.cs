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
        /// Since We Have Two Present Charts That Allow us to simplify and visulise 
        /// query data , we can have two chart options that allow us to present the same queried data,  however
        /// can visualise multiple types of data at once
        /// 
        /// </summary>
        /// 
   
        public void StoreChart(IEnumerable<Order> queried_orders)
        {
            List<GraphData> ChartData = new List<GraphData>();
            
      
            foreach (var Type in form1.StoreCodesList.Items)
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
                    if (ChartData[i].Field == order.StoreCode)
                    {
                        ChartData[i].Count += order.Cost;
                    }
                }
            }

            form1.StoreChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var data in ChartData)
            {
                if (data.Count > 0)
                {
                    form1.StoreChart.Series[0].Points.AddXY(data.Field, data.Count);
                }
            }
        }

        public void DateChart(IEnumerable<Order> queried_orders)
        {
            List<GraphData> ChartData = new List<GraphData>();
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




            form1.DateChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var data in ChartData)
            {
                if (data.Count > 0)
                {
                    form1.DateChart.Series[0].Points.AddXY(data.Field, data.Count);
                }
                }

        }

        public void SupplierType(IEnumerable<Order> queried_orders)
        {
            List<GraphData> ChartData = new List<GraphData>();

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
     
            form1.SupplierTypeChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            foreach (var data in ChartData)
            {
                if (data.Count > 0)
                {
                    form1.SupplierTypeChart.Series[0].Points.AddXY(data.Field, data.Count);
                }
                }
        }

        public void SupplierName(IEnumerable<Order> queried_orders)
        {
            List<GraphData> ChartData = new List<GraphData>();

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
        
            //Populates The Graph
            //Allows Each Label To Interval Correctly
            form1.SupplierNameChart.ChartAreas[0].AxisX.LabelStyle.Interval = 0.5;
            foreach (var data in ChartData)
            {
                if (data.Count > 0)
                {
                    form1.SupplierNameChart.Series[0].Points.AddXY(data.Field, data.Count);
                }
            }

        }

    }


}
