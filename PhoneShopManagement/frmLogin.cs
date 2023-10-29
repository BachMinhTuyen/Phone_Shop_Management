using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement
{
    public partial class frmLogin : Form
    {
        public string connectionString = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlCommand = "INSERT INTO SANPHAM VALUES (dbo.auto_IdSP(), N'Sữa rửa mặt trị mụn', 50, 10000, N'một sản phẩm giúp da mặt mau chóng hết mụn.', 'NV01')";
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
        }
    }
}
