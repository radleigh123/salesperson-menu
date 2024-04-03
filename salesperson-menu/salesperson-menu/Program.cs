using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace salesperson_menu
{
    internal static class Program
    {
        public static readonly List<Person> Person = new List<Person>();

        public static readonly double COMMISSION = 0.15;
        public static readonly int QUOTA = 1000;
        public static readonly double BASE_PAY = 250.00;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
