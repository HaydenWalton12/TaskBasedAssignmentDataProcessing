﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskBasedForms
{
    class Program
    {
        static Application _Application;
        static bool _Running_Flag = true;
        [STAThread]
        static void Main(string[] args)
        {

            _Application = new Application();


            _Application.Start(_Application);




        }
    }
}