using HospitalManagementSystem.Common;
using HospitalManagementSystem.UI;
using HospitalManagementSystem.UI.Entry;
using HospitalManagementSystem.UI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbConnector.ConnectionString = "Data Source=ZAKAWARMAW\\SQL2022;Initial Catalog=HMS;User ID=sa;Password=sa@123";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
