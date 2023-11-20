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
using System.Xml.Linq;

namespace PhoneShopManagement
{
    public partial class frmUserAccount : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        DataSet ds_QLPhoneShop = new DataSet();
        SqlDataAdapter da_UserAccount;
        string table = "NhanVien";
        public frmUserAccount()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int CountAdmin = 0;
            int CountUser = 0;
            int CoutAccount = 0;
            using (SqlConnection sqlclient = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT ROW_NUMBER() OVER (ORDER BY MaNV) AS STT,MaNV,MatKhau,ChucVu FROM {0}", table);
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_AccountList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_AccountList.Rows.Add();
                        for (int i = 0; i < 4; i++) dataGridView_AccountList.Rows[rowIndex].Cells[i].Value = row[i];
                        ++CoutAccount;
                        if (string.Equals(row[3].ToString(), "Quản Lý")) CountAdmin++;
                        else CountUser++;
                    }
                    txtBox_TotalAll.Text = CoutAccount.ToString();
                    txtBox_TotalAdminAccount.Text = CountAdmin.ToString();
                    txtBox_TotalStaffAccount.Text = CountUser.ToString();
                }
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (checkValues())
            {
                InsertSql();
                txtBox_UserName.Text = "";
                txtBox_Password.Text = "";
                txtBox_ConfirmPassword.Text = "";
            }
            else MessageBox.Show("Vui Lòng Nhập đầy đủ");
        }
        public void InsertSql()
        {
            string query = string.Format("INSERT INTO {0} VALUES (@Value_UserName,@Value_User_password,@Value_Role)", table);
            using (SqlConnection Sqlclient = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, Sqlclient))
                {
                    
                    command.Parameters.AddWithValue("@Value_UserName", txtBox_UserName.Text);
                    command.Parameters.AddWithValue("@Value_User_password", txtBox_Password.Text);
                    if (radioBtn_Admin.Checked)
                        command.Parameters.AddWithValue("@Value_Role", "Quản Lí");
                    else
                        command.Parameters.AddWithValue("@Value_Role", "Nhân Viên Bán Hàng");
                    Sqlclient.Open();
                    command.ExecuteNonQuery();
                    Sqlclient.Close();
                }
            }
            LoadData();
        }


        public void KhoiPhucMatKhau()
        {
            for (int i = 0; i < dataGridView_AccountList.Rows.Count-1; i++)
                dataGridView_AccountList.Rows[i].Cells[2].Value = "123456";
        }
        public void DeleteSql()
        {
            string query = string.Format("DELETE FROM {0} WHERE MaNV = @Value_UserName;", table);
            using (SqlConnection Sqlclient = new SqlConnection(connectionString)) {
                using (SqlCommand command = new SqlCommand(query, Sqlclient)) {
                    command.Parameters.AddWithValue("@Value_UserName", txtBox_UserName.Text);
                    Sqlclient.Open();
                    command.ExecuteNonQuery();
                    Sqlclient.Close();
                }
            }
            LoadData();
        }
        public bool checkValues()
        {
            string UserName_text = txtBox_UserName.Text;
            string Password_text = txtBox_Password.Text;
            string ConfirmPassword_text = txtBox_ConfirmPassword.Text;
            if (UserName_text.Length > 0 && Password_text.Length > 0 && ConfirmPassword_text.Length > 0)
            {
                if (string.Equals(Password_text, ConfirmPassword_text)) return true;
                else return false;
            }
            return false;
        }
      
      

      

      

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LoadData();
            txtBox_UserName.Text = "";
            txtBox_Password.Text = "";
        }

        private void dataGridView_AccountList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_AccountList.Rows[e.RowIndex];
                txtBox_UserName.Text = selectedRow.Cells[1].Value.ToString();
                txtBox_Password.Text = selectedRow.Cells[2].Value.ToString();
                string text = selectedRow.Cells[3].Value.ToString();
                if (string.Equals(text, "Quản Lí"))
                    radioBtn_Admin.Checked = true;
                else
                    radioBtn_User.Checked = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteSql();
            txtBox_UserName.Text = "";
            txtBox_Password.Text = "";
            txtBox_ConfirmPassword.Text = "";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            KhoiPhucMatKhau();
        }

        private void btn_ChangeRole_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE {0} SET ChucVu = @Value_Role WHERE MaNV = @MaNV", table);
            using (SqlConnection Sqlclient = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, Sqlclient))
                {
                    string Role = (radioBtn_Admin.Checked) ? "Quản Lí" : "Nhân Viên Bán Hàng";
                    command.Parameters.AddWithValue("@Value_Role", Role);
                    command.Parameters.AddWithValue("@MaNV",txtBox_UserName.Text);
                    Sqlclient.Open();
                    command.ExecuteNonQuery();
                    Sqlclient.Close();
                }
            }
            LoadData();
        }
    }
}
