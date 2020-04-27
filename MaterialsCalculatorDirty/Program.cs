using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;


namespace MaterialsCalculatorDirty
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm());

            TestProgram pr = new TestProgram();
            pr.Run();
            Console.Read();

        }


    }


    
}
