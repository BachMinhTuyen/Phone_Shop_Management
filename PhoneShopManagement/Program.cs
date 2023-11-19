using PhoneShopManagement.AdminArea;
using PhoneShopManagement.UserArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            //Application.Run(new frmAdmin("NV003"));
            Application.Run(new frmProduct());
            //Application.Run(new frmUserAccount());
            //Application.Run(new frmStaff());
            //Application.Run(new frmBrand());
            //Application.Run(new frmCustomer());
            Application.Run(new frmDetailBill());
        }
    }
}
