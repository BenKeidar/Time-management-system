using System;
using System.Windows.Forms;

namespace Win1
{
    internal static class Program
    {
        /// <summary>
        /// This is a time management system.
        /// Using this app a user can manage his schedule and meetings using a calendar with events,
        /// build and use a comfortable to-do list, add notes and add notifications. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}