using System;
using System.Windows.Forms;
using MHR___Ass.Data.Armors.Sets;

namespace MHR___Ass
{
    static class Program
    {
        /// <summary>The main entry point for the application.</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}