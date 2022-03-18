using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBasedForms
{
    public class Application
    {
        string[] function_names = new string[8];
        public void Start(Application app)
        {
            Form1 form1 = new Form1(app);
            form1.ShowDialog();
        }
    }

}
class Date
{
    public int Week { get; set; }
    public int Year { get; set; }
}

class GraphData
{
    public string Field { get; set; }  

    public double Count { get; set; }  

}

//Used to find data of an order from a store , and all invoice data inquired from a sale
class Order
{
    public string StoreCode { get; set; }
    public Date Date { get; set; }
    public string SupplierName { get; set; }
    public string SupplierType { get; set; }
    public double Cost { get; set; }
}

