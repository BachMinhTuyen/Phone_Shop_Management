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
        
        public frmUserAccount()
        {
            InitializeComponent();
            LoadData();
        }
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        DataSet ds_QLPhoneShop = new DataSet();
        SqlDataAdapter da_UserAccount;
        string table = "USERNAME";
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
                        command.Parameters.AddWithValue("@Value_Role", "ADMIN");
                    else
                        command.Parameters.AddWithValue("@Value_Role", "User");
                    Sqlclient.Open();
                    command.ExecuteNonQuery();
                    Sqlclient.Close();
                }
            }
            LoadData();
        }
        public void UpdateSql()
        {
            string query = string.Format("UPDATE {0} SET User_password = @Value_Password , User_VaiTro = @Value_Role WHERE UserName = @Value_Name;", table);
            using (SqlConnection Sqlclient = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, Sqlclient))
                {
                    command.Parameters.AddWithValue("@Value_Name", txtBox_UserName.Text);
                    command.Parameters.AddWithValue("@Value_Password", txtBox_Password.Text);
                    if (radioBtn_Admin.Checked)
                        command.Parameters.AddWithValue("@Value_Role", "ADMIN");
                    else
                        command.Parameters.AddWithValue("@Value_Role", "User");
                    Sqlclient.Open();
                    command.ExecuteNonQuery();
                    Sqlclient.Close();
                }
            }
            LoadData();
        }
        public void DeleteSql()
        {
            string query = string.Format("DELETE FROM {0} WHERE UserName = @Value_UserName;", table);
            using (SqlConnection Sqlclient = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, Sqlclient))
                {
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
        public void LoadData()
        {
            int CountAdmin = 0;
            int CountUser = 0;
            int CoutAccount = 0;
            using (SqlConnection sqlclient = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT * FROM {0}", table);
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_AccountList.Rows.Clear();
                    foreach (DataRow row in data.Rows)
                    {
                        int rowIndex = dataGridView_AccountList.Rows.Add();
                        dataGridView_AccountList.Rows[rowIndex].Cells[1].Value = row[0];
                        dataGridView_AccountList.Rows[rowIndex].Cells[2].Value = row[1];
                        dataGridView_AccountList.Rows[rowIndex].Cells[3].Value = row[2];
                        dataGridView_AccountList.Rows[rowIndex].Cells[0].Value = ++CoutAccount;
                        if (string.Equals(row[2].ToString(), "ADMIN")) CountAdmin++;
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
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LoadData();
            txtBox_UserName.Text = "";
            txtBox_Password.Text = "";
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteSql();
            txtBox_UserName.Text = "";
            txtBox_Password.Text = "";
            txtBox_ConfirmPassword.Text = "";
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateSql();
            txtBox_UserName.Text = "";
            txtBox_Password.Text = "";
            txtBox_ConfirmPassword.Text = "";
        }
        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView_AccountList.CurrentRow.Index;
            txtBox_UserName.Text = dataGridView_AccountList.Rows[i].Cells[1].Value.ToString();
            txtBox_Password.Text = dataGridView_AccountList.Rows[i].Cells[2].Value.ToString();
            string text = dataGridView_AccountList.Rows[i].Cells[3].Value.ToString();// Lấy vai trò ra đem đi so sánh
            if (string.Equals(text, "ADMIN"))
                radioBtn_Admin.Checked = true;
            else
                radioBtn_User.Checked = true;
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
