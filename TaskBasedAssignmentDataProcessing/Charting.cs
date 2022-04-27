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


        public void StoreChart(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> ChartData = new List<GraphData>();
            List<GraphData> ChartResult = new List<GraphData>();


            foreach (var Type in form1.StoreCodesList.Items)
            {
                string[] temp = Type.ToString().Split(' ');

                GraphData data = new GraphData
                {
                    Field = temp[0],
                    Count = 0
                };
                ChartData.Add(data);
            }
            foreach (var order in QueriedOrders)
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

                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    ChartResult.Add(item);
                }
            }
            foreach(var data in ChartResult)
            {
                form1.StoreChartResultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
     



        }

        public  void DateChart(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> ChartData = new List<GraphData>();
            List<GraphData> ChartResult = new List<GraphData>();

            foreach (var Type in form1.DateList.Items)
            {
                GraphData data = new GraphData
                {
                    Field = Type.ToString(),
                    Count = 0
                };
                ChartData.Add(data);
            }

            foreach (var order in QueriedOrders)
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
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    ChartResult.Add(item);
                }
                }


            foreach (var data in ChartResult)
            {
                form1.DateChartResultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
            

        }

        public void SupplierType(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> ChartData = new List<GraphData>();
            List<GraphData> ChartResult = new List<GraphData>();

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
            foreach (var order in QueriedOrders)
            {
                //Iterates Based Upon The chart Data count
                for (int i = 0; i < ChartData.Count; i++)
                {
                    //If the Chartdate indexed field equals an Orders suppliertype instance
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
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    ChartResult.Add(item);
                }
                }
           
            foreach (var data in ChartResult)
            {
                form1.SupplierTypeChartResultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }

        public void SupplierName(IEnumerable<Order> QueriedOrders)
        {
            List<GraphData> ChartData = new List<GraphData>();
            List<GraphData> ChartResult = new List<GraphData>();

            foreach (var Type in form1.SupplierNameList.Items)
            {
                GraphData data = new GraphData
                {
                    Field = Type.ToString(),
                    Count = 0
                };

                ChartData.Add(data);
            }
         
            foreach (var order in QueriedOrders)
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
                    GraphData item = new GraphData
                    {
                        Field = data.Field,
                        Count = data.Count
                    };

                    ChartResult.Add(item);
                }
            }
   
            foreach (var data in ChartResult)
            {
                form1.SupplierNameChartResultList.Items.Add(data.Field + " : " + data.Count.ToString());
            }
        }

    }


}
