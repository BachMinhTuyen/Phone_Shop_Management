using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Utilities;

namespace PhoneShopManagement
{
    public partial class frmLogin : Form
    {

        public string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        public frmLogin()
        {
            InitializeComponent();
            LoadSavedCredentials();
           
        }
        private void LoadSavedCredentials()
        {
            string savedUsername = Properties.Settings.Default.UserName;
            string savedPassword = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                txtBox_UserName.Text = savedUsername;
                txtBox_Password.Text = savedPassword;
                chkBox_Remember.Checked = true;
            }
        }
        private void SaveCredentials()
        {
            if (chkBox_Remember.Checked)
            {
                Properties.Settings.Default.UserName = txtBox_UserName.Text;
                Properties.Settings.Default.Password = txtBox_Password.Text;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
            }

            Properties.Settings.Default.Save();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtBox_UserName.Text;
            string password = Password.Create_SHA256(txtBox_Password.Text);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@MaNV AND MatKhau = @MatKhau";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@MaNV", username);
                    command.Parameters.AddWithValue("@MatKhau", (password));

                    int count = (int)command.ExecuteScalar();
                    conn.Close();

                    if (count == 1)
                    {
                        if (chkBox_Remember.Checked)
                        {
                            SaveCredentials();
                        }

                        MessageBox.Show("Đăng nhập thành công.");
                        OpenForm(username);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                    }
                }
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_ShowHidePassword.Checked)
            {
                txtBox_Password.PasswordChar = '\0';
            }
            else
            {
                txtBox_Password.PasswordChar = '•';
            }
        }
        private void OpenForm(string username)
        {
            frmUserProfile frmuser = new frmUserProfile(username);
            this.Hide();
            frmuser.ShowDialog();
            this.Show();
        }
    }
}
