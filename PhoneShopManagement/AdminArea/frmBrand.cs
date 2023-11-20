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

namespace PhoneShopManagement.AdminArea
{
    public partial class frmBrand : Form
    {

        private string ConnectSql = Properties.Settings.Default.ConnectionString_Remote;

        public frmBrand()
        {
            InitializeComponent();
          
        }
        void LoadData()
        {
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql))
            {
                string query = string.Format("Select * from ThuongHieu");
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_BrandList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_BrandList.Rows.Add();
                        for (int i = 0; i < 2; i++)
                            dataGridView_BrandList.Rows[rowIndex].Cells[i].Value = row[i];
                    }
                }
            }
        }
        private void frmBrand_Load(object sender, EventArgs e)
        {

            LoadData();
            dataGridView_BrandList.ReadOnly = true;
            dataGridView_BrandList.AllowUserToAddRows = false;
        }
        private void dataGridView_BrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_BrandList.Rows[e.RowIndex];
                txtBox_BrandID.Text = selectedRow.Cells[0].Value.ToString();
                txtBox_BrandName.Text = selectedRow.Cells[1].Value.ToString();
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }
 
        public void InsertSql()
        {
            try
            {
                string query = string.Format("INSERT INTO {0} VALUES (@Value_MaThuongHieu , @Value_TenThuongHieu)", "ThuongHieu");
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaThuongHieu", txtBox_BrandID.Text);
                        command.Parameters.AddWithValue("@Value_TenThuongHieu", txtBox_BrandName.Text);
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
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (btn_Update.Text == "Sửa")
            {
                btn_Update.Text = "Lưu";
                txtBox_BrandName.ReadOnly = false;
                btn_Insert.Enabled = false;
                btn_Delete.Enabled = false;
            }
            else
            {
                UpdateSql();
                btn_Update.Text = "Sửa";
                txtBox_BrandName.ReadOnly = true;
                btn_Delete.Enabled = true;
                btn_Insert.Enabled = true;

            }
        }

        public void UpdateSql()
        {
            try
            {
                string query = string.Format("UPDATE {0} SET TenThuongHieu = @Value_TenThuongHieu WHERE MaThuongHieu = @Value_MaThuongHieu;", "ThuongHieu");
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaThuongHieu", txtBox_BrandID.Text);
                        command.Parameters.AddWithValue("@Value_TenThuongHieu", txtBox_BrandName.Text);
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

     

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txtBox_BrandName.ReadOnly)
            {
                txtBox_BrandID.ReadOnly = false;
                txtBox_BrandName.ReadOnly = false;
                btn_Clear.Enabled = true;
                //  btn_Update.Enabled = false;
                //  btn_Delete.Enabled = false;
                txtBox_BrandID.Clear();
                txtBox_BrandName.Clear();
            }
            else
            {
                txtBox_BrandID.ReadOnly = true;
                txtBox_BrandName.ReadOnly = true;
                InsertSql();
                txtBox_BrandID.Clear();
                txtBox_BrandName.Clear();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("DELETE FROM {0} WHERE MaThuongHieu = @Value_MaThuongHieu;", "ThuongHieu");
                using (SqlConnection Sqlclient = new SqlConnection(ConnectSql))
                {
                    using (SqlCommand command = new SqlCommand(query, Sqlclient))
                    {
                        command.Parameters.AddWithValue("@Value_MaThuongHieu", txtBox_BrandID.Text);
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_BrandID.Clear();
            txtBox_BrandName.Clear();
            LoadData();
        }
    }
}
