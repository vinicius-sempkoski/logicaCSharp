using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
namespace WindowsFormsApplication1
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
            //Application.Run(new Form1());
            MessageBox.Show("Ola Mundo!!!");
        }
    }
}