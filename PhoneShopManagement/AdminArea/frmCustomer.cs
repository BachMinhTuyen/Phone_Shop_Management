using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmCustomer : Form
    {
        private string ConnectSql = Properties.Settings.Default.ConnectionString_Remote;
        public frmCustomer()
        {
            InitializeComponent();
            LoadData();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
        void LoadData() {
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql)) {
                string query = string.Format("SELECT * FROM KhachHang");
                int countKH = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient)) {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_CustomerList.Rows.Clear();
                    foreach (DataRow row in data.Rows) {
                        int rowIndex = dataGridView_CustomerList.Rows.Add();
                        for (int i = 0; i < dataGridView_CustomerList.ColumnCount; i++) {
                            if (i == 2) {
                                int index = row[i].ToString().IndexOf(" ");
                                dataGridView_CustomerList.Rows[rowIndex].Cells[i].Value = row[i].ToString().Substring(0, index);
                            } else
                                dataGridView_CustomerList.Rows[rowIndex].Cells[i].Value = row[i];
                        }
                        countKH++;
                    }
                    txtBox_TotalStaff.Text = countKH.ToString();
                }
            }
        }
        private void clearItem()
        {
            txtBox_CustomerID.Clear();
            txtBox_CustomerName.Clear();
            dateTimePicker_DateOfBirth.CustomFormat = "";
            txtBox_PhoneNumber.Clear();
            txtBox_Email.Clear();
            txtBox_Address.Clear();
        }
        public void UpdateSql()
        {
            try
            {
                string query = string.Format("UPDATE {0} SET  " +
                    "TenKH = @Value_TenKH , " +
                    "NgaySinh = @Value_NgaySinh, " +
                    "SoDienThoai = @Value_SoDienThoai, " +
                    "Email = @Value_Email, " +
                    "DiaChi = @Value_DiaChi " +
                    "WHERE MaKH = @Value_MaKH;", "KhachHang");
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaKH", txtBox_CustomerID.Text);
                        command.Parameters.AddWithValue("@Value_TenKH", txtBox_CustomerName.Text);
                        command.Parameters.AddWithValue("@Value_NgaySinh", dateTimePicker_DateOfBirth.Value);
                        command.Parameters.AddWithValue("@Value_SoDienThoai", txtBox_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@Value_Email", txtBox_Email.Text);
                        command.Parameters.AddWithValue("@Value_DiaChi", txtBox_Address.Text);
                        Sqlclient.Open();
                        command.ExecuteNonQuery();
                        Sqlclient.Close();
                    }
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Xảy Ra Lỗi Vui Lòng Thử Lại!");
            }
        }
        public void DeleteSql()
        {
            try
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @Value_MaKH;";
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaKH", txtBox_CustomerID.Text);
                        Sqlclient.Open();
                        command.ExecuteNonQuery();
                        Sqlclient.Close();
                    }
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Xảy Ra Lỗi Vui Lòng Thử Lại!");
            }
        }
        public void InsertSql()
        {
            try
            {
                string query = string.Format("INSERT INTO {0} VALUES (@Value_MaKH , @Value_TenKH,@Value_NgaySinh,@Value_SoDienThoai,@Value_Email,@Value_DiaChi)", "KhachHang");
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaKH", txtBox_CustomerID.Text);
                        command.Parameters.AddWithValue("@Value_TenKH", txtBox_CustomerName.Text);
                        command.Parameters.AddWithValue("@Value_NgaySinh", dateTimePicker_DateOfBirth.Value);
                        command.Parameters.AddWithValue("@Value_SoDienThoai", txtBox_PhoneNumber.Text);
                        command.Parameters.AddWithValue("@Value_Email", txtBox_Email.Text);
                        command.Parameters.AddWithValue("@Value_DiaChi", txtBox_Address.Text);
                        Sqlclient.Open();
                        command.ExecuteNonQuery();
                        Sqlclient.Close();
                    }
                }
                LoadData();
            }
            catch
            {
                MessageBox.Show("Xảy Ra Lỗi Vui Lòng Thử Lại!");
            }
        }

        private void dataGridView_CustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_CustomerList.Rows[e.RowIndex];
                txtBox_CustomerID.Text = selectedRow.Cells[0].Value.ToString();
                txtBox_CustomerName.Text = selectedRow.Cells[1].Value.ToString();
                dateTimePicker_DateOfBirth.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                txtBox_PhoneNumber.Text = selectedRow.Cells[3].Value.ToString();
                txtBox_Email.Text = selectedRow.Cells[4].Value.ToString();
                txtBox_Address.Text = selectedRow.Cells[5].Value.ToString();

                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            InsertSql();
            clearItem();
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteSql();
            clearItem();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateSql();
            clearItem();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
        }
    }
}
