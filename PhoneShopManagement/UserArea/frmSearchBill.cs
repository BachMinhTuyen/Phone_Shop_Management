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

namespace PhoneShopManagement.UserArea
{
    public partial class frmSearchBill : Form
    {
        public string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        public frmSearchBill()
        {
            InitializeComponent();
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);
                    connection.Close();
                }
                catch
                {
                    connection.Close();
                }
            }

            return data;
        }
        private void frmSearchBill_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string maDH = txtBox_ProductID.Text;
            string query = string.Format("SELECT * FROM DONHANG WHERE MADH like N'{0}'", maDH);
            DataTable data = ExecuteQuery(query);
            dataGridView_BillList.DataSource = data;
        }

        private void dataGridView_BillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_BillID.Enabled= false;   
            int index =e.RowIndex;
            if (index == -1)
                return;
            if (e.RowIndex == dataGridView_BillList.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                return;
            }
            string maDH= dataGridView_BillList.Rows[index].Cells["MADH"].Value.ToString();
            txtBox_BillID.Text = maDH;
            string MAKH= dataGridView_BillList.Rows[index].Cells["MAKH"].Value.ToString();
            txtBox_CustomerID.Text = MAKH;
            dateTimePicker_TimeOfPurchase.Value = Convert.ToDateTime(dataGridView_BillList.Rows[index].Cells["ThoiGianMuaHang"].Value);
            textBox1.Text = dataGridView_BillList.Rows[index].Cells["TongTien"].Value.ToString();
            string MaNV= dataGridView_BillList.Rows[index].Cells["MaNV"].Value.ToString();
            txtBox_StaffID.Text = MaNV;
            string queryKH = string.Format("SELECT * FROM KHACHHANG WHERE MAKH = N'{0}'", MAKH);
            DataTable dataKH = ExecuteQuery(queryKH);
            txtBox_CustomerName.Text = dataKH.Rows[0]["TenKH"].ToString();
            txtBox_Email.Text = dataKH.Rows[0]["Email"].ToString();
            txtBox_PhoneNumber.Text = dataKH.Rows[0]["SoDienThoai"].ToString();
            txtBox_Address.Text = dataKH.Rows[0]["DiaChi"].ToString();

            string queryNV = string.Format("SELECT * FROM NHANVIEN WHERE MANV = N'{0}'", MaNV);
            DataTable dataNV = ExecuteQuery(queryNV);
            txtBox_StaffName.Text = dataNV.Rows[0]["TenNV"].ToString();

            loadDetailsBill(maDH);
         
        }
        void loadDetailsBill(string maDH)
        {
            string query = string.Format("SELECT * FROM ChiTietDonHang WHERE MADH = N'{0}'", maDH);
            DataTable data = ExecuteQuery(query);
            dataGridView_Details.DataSource = data;
        }
    }
}
