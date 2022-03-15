using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskBasedForms
{
    class Program
    {
        static Application _App;
        static bool _Running_Flag = true;
        [STAThread]
        static void Main(string[] args)
        {

            _App = new Application();


            _App.Start(_App);




        }
    }
}