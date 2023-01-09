using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
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

            //Creating by Sir using for mdi connection for child tricks

            // GeneralFunction.mdiForm = new MainForm();
            GeneralFunction.mdiForm = new LoginForm();
            Application.Run(new LoginForm());
        }
    }
}
