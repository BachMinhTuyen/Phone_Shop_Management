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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmBill : Form
    {
        private string ConnectSql = Properties.Settings.Default.ConnectionString_Remote;
        public frmBill()
        {
            InitializeComponent();
            LoadData();
        }
        private string nameDH;

        void LoadData()
        {
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql))
            {
                string query = string.Format("SELECT DH.MADH, KH.TenKH, NV.TenNV, DH.TongTien, DH.ThoiGianMuaHang, DH.ThanhToan " +
                    "FROM DonHang AS DH " +
                    "JOIN KhachHang AS KH ON DH.MaKH = KH.MaKH " +
                    "JOIN NhanVien NV ON DH.MaNV = NV.MaNV");
                int countHD = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_BillList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_BillList.Rows.Add();
                        for (int i = 0; i < dataGridView_BillList.ColumnCount; i++)
                        {
                            if (i == 4)
                            {
                                int index = row[i].ToString().IndexOf(" ");
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i].ToString().Substring(0, index);
                            }
                            else
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i];
                        }
                        countHD++;
                    }
                    txtBox_TotalBill.Text = countHD.ToString();
                }
            }
        }

        private void dataGridView_BillList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_BillList.Rows[e.RowIndex];
                nameDH = selectedRow.Cells[0].Value.ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Xóa " + nameDH + "?", "Thông Báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) DeleteSql();
            
        }
        public void DeleteSql()
        {
            try
            {

                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    Sqlclient.Open();
                    string query = "DELETE FROM ChiTietDonHang WHERE MADH = @Value_MaDH;";
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaDH", nameDH);
                        command.ExecuteNonQuery();
                    }
                    query = "DELETE FROM DonHang WHERE MADH = @Value_MaDH;";
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaDH", nameDH);

                        command.ExecuteNonQuery();
                    }
                    Sqlclient.Close();
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Xuất Hiện Lỗi Vui Lòng Thử Lại!");
            }
        }
       
        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
            {
                string query = " SELECT DH.MADH, KH.TenKH, NV.TenNV, DH.TongTien, DH.ThoiGianMuaHang, DH.ThanhToan " +
                                "FROM DonHang AS DH " +
                                "JOIN KhachHang AS KH ON DH.MaKH = KH.MaKH " +
                                "JOIN NhanVien NV ON DH.MaNV = NV.MaNV " +
                                "WHERE DH.MADH LIKE '%"+ txtBox_Search.Text + "%'";
                int countHD = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_BillList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_BillList.Rows.Add();
                        for (int i = 0; i < dataGridView_BillList.ColumnCount; i++)
                        {
                            if (i == 4)
                            {
                                int index = row[i].ToString().IndexOf(" ");
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i].ToString().Substring(0, index);
                            }
                            else
                            {
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i];
                            }
                        }
                        countHD++;
                    }
                    txtBox_TotalBill.Text = countHD.ToString();
                }
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string PaymentMethods = (radioButton_FilterCashPaid.Checked) ? "Tiền Mặt" : "Không Tiền Mặt";
            using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
            {
                string query = " SELECT DH.MADH, KH.TenKH, NV.TenNV, DH.TongTien, DH.ThoiGianMuaHang, DH.ThanhToan " +
                                "FROM DonHang AS DH " +
                                "JOIN KhachHang AS KH ON DH.MaKH = KH.MaKH " +
                                "JOIN NhanVien NV ON DH.MaNV = NV.MaNV " +
                                "WHERE DH.ThanhToan LIKE N'" + PaymentMethods + "'";
                int countHD = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_BillList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_BillList.Rows.Add();
                        for (int i = 0; i < dataGridView_BillList.ColumnCount; i++)
                        {
                            if (i == 4)
                            {
                                int index = row[i].ToString().IndexOf(" ");
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i].ToString().Substring(0, index);
                            }
                            else
                            {
                                dataGridView_BillList.Rows[rowIndex].Cells[i].Value = row[i];
                            }
                        }
                        countHD++;
                    }
                    txtBox_TotalBill.Text = countHD.ToString();
                }
            }
        }

        private void btn_DefaultFilter_Click(object sender, EventArgs e)
        {
            LoadData();
            radioButton_FilterCashPaid.Checked = false;
            radioButton_FilterCardPaid.Checked = false;
            txtBox_Search.Clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
