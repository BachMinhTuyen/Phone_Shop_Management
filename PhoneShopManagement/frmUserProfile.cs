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
    public partial class frmUserProfile : Form
    {

        string connStr = @"workstation id = QL_PhoneShop.mssql.somee.com; packet size = 4096; user id = TuyenBach_MSSQL; pwd=TuyenBach_MSSQL2022;data source = QL_PhoneShop.mssql.somee.com; persist security info=False;initial catalog = QL_PhoneShop";
        private string username;
     
        public frmUserProfile(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData();
        }

        public frmUserProfile()
        {
        }

        private void LoadUserData()
        {
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien WHERE MaNV=@MaNV";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaNV", username);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtBox_UserLogin.Text = reader["MaNV"].ToString();
                    txtBox_FullName.Text = reader["TenNV"].ToString();
                    txtBox_Email.Text = reader["Email"].ToString();
                    dateTimePicker_DateOfBirth.Value = reader["NgaySinh"] as DateTime? ?? dateTimePicker_DateOfBirth.MinDate;
                    txtBox_PhoneNumber.Text = reader["SoDienThoai"].ToString();
                    txtBox_Address.Text = reader["DiaChi"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin người dùng: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "UPDATE NhanVien SET TenNV=@TenNV, Email=@Email,NgaySinh=@NgaySinh, SoDienThoai=@SoDienThoai, DiaChi=@DiaChi WHERE MaNV=@MaNV";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MaNV", txtBox_UserLogin.Text);
                command.Parameters.AddWithValue("@TenNV", txtBox_FullName.Text);
                command.Parameters.AddWithValue("@Email", txtBox_Email.Text);
                command.Parameters.AddWithValue("@NgaySinh", dateTimePicker_DateOfBirth.Value);
                command.Parameters.AddWithValue("@SoDienThoai", txtBox_PhoneNumber.Text);
                command.Parameters.AddWithValue("@DiaChi", txtBox_Address.Text);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thông tin người dùng: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r == DialogResult.Yes) 
            {
                this.Close();
            }
        }
    }
}
       
       

   