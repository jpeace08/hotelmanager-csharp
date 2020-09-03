using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace hotelmanager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strConnect = "Data Source=DESKTOP-DQ8K0M0;Initial Catalog=HotelDatabase;Integrated Security=True";
            if (CONNECT_BLL.Connect(strConnect))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
            else
            {
                MessageBox.Show("Can not connect to database!");
            }
        }
    }
}
