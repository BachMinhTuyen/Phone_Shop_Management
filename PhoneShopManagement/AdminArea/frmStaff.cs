using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmStaff : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        DataSet ds_QLPhoneShop = new DataSet();
        SqlDataAdapter da_Staff;
        public frmStaff()
        {
            InitializeComponent();
        }

        #region Hàm tự định nghĩa
        // Hàm tải thông tin nhân viên
        private void Load_StaffInformation(SqlCommand sqlCommand)
        {
            // Khởi tạo Sql Data Adapter
            da_Staff = new SqlDataAdapter(sqlCommand);
            
            // Làm sạch DataSet
            ds_QLPhoneShop.Clear();

            // Đổ dữ liệu vào DataSet
            da_Staff.Fill(ds_QLPhoneShop, "NhanVien");
            dataGridView_StaffList.DataSource = ds_QLPhoneShop.Tables["NhanVien"];

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_QLPhoneShop.Tables["NhanVien"].Columns[0];
            ds_QLPhoneShop.Tables["NhanVien"].PrimaryKey = key;

            // Điều chỉnh độ rộng của cột
            dataGridView_StaffList.Columns["MaNV"].Width = 80;
            dataGridView_StaffList.Columns["TenNV"].Width = 150;
            dataGridView_StaffList.Columns["ChucVu"].Width = 125;
            dataGridView_StaffList.Columns["NgaySinh"].Width = 100;
            dataGridView_StaffList.Columns["SoDienThoai"].Width = 120;
            dataGridView_StaffList.Columns["Email"].Width = 170;
            dataGridView_StaffList.Columns["DiaChi"].Width = 120;
        }
        private string TinhTongNhanVien()
        {
            string sum;
            string sqlCommand = "SELECT COUNT(MaNV) FROM NhanVien";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                sum = cmd.ExecuteScalar().ToString();
                connection.Close();
            }
            return sum;
        }
        private bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }
        private bool KiemTraMaNhanVien(string maNV)
        {
            
            foreach (DataRow row in ds_QLPhoneShop.Tables["NhanVien"].Rows)
                if (String.Compare(maNV, row["MaNV"].ToString()) == 0)
                    return true; // trùng mã nhân viên
            return false; //chưa có mã nhân viên
        }
        private bool KiemTraThongTinDauVao()
        {
            //Kiểm tra mã nhân viên
            if (txtBox_StaffID.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo");
                txtBox_StaffID.Focus();
                return false;
            }
            else
            {
                if (KiemTraMaNhanVien(txtBox_StaffID.Text) == true)
                {
                    MessageBox.Show("Đã có mã nhân viên này", "Thông báo");
                    txtBox_StaffID.Focus();
                    return false;
                }
            }
            // Kiểm tra thông tin họ tên nhân viên
            if (txtBox_StaffName.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Thông báo");
                txtBox_StaffName.Focus();
                return false;
            }
            // Kiểm tra vai trò chức vụ
            if (radioButton_Manager.Checked == false && radioButton_Staff.Checked == false)
            {
                MessageBox.Show("Chưa lựa chọn chức vụ", "Thông báo");
                radioButton_Staff.Checked = true;
                return false;
            }
            // Kiểm tra ngày sinh từ 18 tuổi trở lên
            if (dateTimePicker_DateOfBirth.Value > DateTime.Now || (DateTime.Now.Year - dateTimePicker_DateOfBirth.Value.Year) < 18)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ngày tháng năm sinh", "Thông báo");
                return false;
            }
            // Kiểm tra số điện thoại
            if (txtBox_PhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Thông báo");
                txtBox_PhoneNumber.Focus();
                return false;
            }
            else
            {
                if (IsNumber(txtBox_PhoneNumber.Text) == false)
                {
                    MessageBox.Show("Kiểm tra lại số điện thoại", "Thông báo");
                    txtBox_PhoneNumber.Focus();
                    return false;
                }
            }
            // Kiểm tra thông tin email
            if (txtBox_Email.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập email nhân viên", "Thông báo");
                txtBox_Email.Focus();
                return false;
            }
            else
            {
                if (txtBox_Email.Text.Contains("@") == false || txtBox_Email.Text.Count(chk => chk == '@') > 1)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng email", "Thông báo");
                    txtBox_Email.Focus();
                    return false;
                }
            }
            // Kiểm tra thông tin địa chỉ
            if (txtBox_Address.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập địa chỉ nhân viên", "Thông báo");
                txtBox_Email.Focus();
                return false;
            }
            return true;
        }

        //Vị trí khi nhấn chuột phải
        private int currentRowIndex, currentColIndex = 0;
        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView_StaffList.Rows[currentRowIndex].Cells[currentColIndex].Value.ToString());
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            btn_Delete_Click(sender, e);
        }
        #endregion

        // Sự kiện Load Form
        private void frmStaff_Load(object sender, EventArgs e)
        {
            //Tải thông tin nhân viên
            string sqlCommand = "SELECT MaNV, TenNV, ChucVu, NgaySinh, SoDienThoai, Email, DiaChi FROM NhanVien";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);

            Load_StaffInformation(cmd);

            txtBox_TotalStaff.Text = TinhTongNhanVien();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT MaNV, TenNV, ChucVu, NgaySinh, SoDienThoai, Email, DiaChi FROM NhanVien WHERE TenNV LIKE N'%' + @tenNV + '%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.Parameters.AddWithValue("@tenNV", txtBox_Search.Text);

                Load_StaffInformation(cmd);
            }    
        }

        private void dataGridView_StaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_StaffID.Enabled = false;
            radioButton_Manager.Enabled = radioButton_Staff.Enabled = false;

            int index = e.RowIndex;
            if (index == -1 || index == int.Parse(TinhTongNhanVien())) 
                return;

            txtBox_StaffID.Text = dataGridView_StaffList.Rows[index].Cells["MaNV"].Value.ToString();
            txtBox_StaffName.Text = dataGridView_StaffList.Rows[index].Cells["TenNV"].Value.ToString();
            string role = dataGridView_StaffList.Rows[index].Cells["ChucVu"].Value.ToString();
            if (role == "Quản Lý")
            {
                radioButton_Manager.Checked = true;
                radioButton_Staff.Checked = false;
            }
            else
            {
                radioButton_Manager.Checked = false;
                radioButton_Staff.Checked = true;
            }
            dateTimePicker_DateOfBirth.Value = Convert.ToDateTime(dataGridView_StaffList.Rows[index].Cells["NgaySinh"].Value);
            txtBox_PhoneNumber.Text = dataGridView_StaffList.Rows[index].Cells["SoDienThoai"].Value.ToString();
            txtBox_Email.Text = dataGridView_StaffList.Rows[index].Cells["Email"].Value.ToString();
            txtBox_Address.Text = dataGridView_StaffList.Rows[index].Cells["DiaChi"].Value.ToString();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            frmStaff_Load(sender, e);
            if (KiemTraThongTinDauVao() == false)
                return;

            DataRow insertNew = ds_QLPhoneShop.Tables["NhanVien"].NewRow();
            insertNew["MaNV"] = txtBox_StaffID.Text.Trim();
            insertNew["TenNV"] = txtBox_StaffName.Text.Trim();
            //insertNew["ChucVu"] = radioButton_Manager.Checked == true ? "Quản Lý" : "Nhân Viên Bán Hàng";
            insertNew["NgaySinh"] = dateTimePicker_DateOfBirth.Value.ToString("yyyy-MM-dd");
            insertNew["SoDienThoai"] = txtBox_PhoneNumber.Text.Trim();
            insertNew["Email"] = txtBox_Email.Text.Trim();
            insertNew["DiaChi"] = txtBox_Address.Text.Trim();

            ds_QLPhoneShop.Tables["NhanVien"].Rows.Add(insertNew);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da_Staff);
            da_Staff.Update(ds_QLPhoneShop, "NhanVien");
            MessageBox.Show("Thành công");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataRow row = ds_QLPhoneShop.Tables["NhanVien"].Rows.Find(txtBox_StaffID.Text);
            row["TenNV"] = txtBox_StaffName.Text.Trim();
            //row["ChucVu"] = radioButton_Manager.Checked == true ? "Quản Lý" : "Nhân Viên Bán Hàng";
            row["NgaySinh"] = dateTimePicker_DateOfBirth.Value.ToString("yyyy-MM-dd");
            row["SoDienThoai"] = txtBox_PhoneNumber.Text.Trim();
            row["Email"] = txtBox_Email.Text.Trim();
            row["DiaChi"] = txtBox_Address.Text.Trim();

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da_Staff);
            da_Staff.Update(ds_QLPhoneShop, "NhanVien");

            btn_Clear_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có chắc muốn xoá nhân viên {txtBox_StaffID.Text}", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string sqlCommand = "SELECT * FROM DonHang WHERE MaNV = '" + txtBox_StaffID.Text + "'";

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connectionString);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xoá nhân viên này\nNhân viên này đang có trong dữ liệu hoá đơn", "Thông Báo");
                    return;
                }
                DataRow row = ds_QLPhoneShop.Tables["NhanVien"].Rows.Find(txtBox_StaffID.Text);
                row.Delete();

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da_Staff);
                da_Staff.Update(ds_QLPhoneShop, "NhanVien");
                MessageBox.Show("Thành công");
            }
            else
                return;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Search.Clear();
            txtBox_StaffID.Focus();
            txtBox_StaffID.Enabled = true;
            txtBox_StaffID.Clear();
            txtBox_StaffName.Clear();
            radioButton_FilterManager.Checked = radioButton_FilterStaff.Checked = radioButton_Manager.Checked = false;
            radioButton_Staff.Checked = true;
            dateTimePicker_DateOfBirth.Value = DateTime.Now;
            txtBox_PhoneNumber.Clear();
            txtBox_Email.Clear();
            txtBox_Address.Clear();
            frmStaff_Load(sender, e);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (radioButton_FilterManager.Checked == false && radioButton_FilterStaff.Checked == false)
            {
                MessageBox.Show("Chọn chức vụ cần lọc");
                return;
            }
            string role;
            if (radioButton_FilterManager.Checked == true)
                role = "Quản Lý";
            else
                role = "Nhân Viên Bán Hàng";
            string sqlCommand = "SELECT MaNV, TenNV, ChucVu, NgaySinh, SoDienThoai, Email, DiaChi FROM NhanVien WHERE ChucVu = @chucVu";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            cmd.Parameters.AddWithValue("@chucVu", role);

            Load_StaffInformation(cmd);
        }

        private void btn_DefaultFilter_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT MaNV, TenNV, ChucVu, NgaySinh, SoDienThoai, Email, DiaChi FROM NhanVien";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            Load_StaffInformation(cmd);
        }

       

        private void dataGridView_StaffList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentRowIndex = dataGridView_StaffList.HitTest(e.X, e.Y).RowIndex;
                currentColIndex = dataGridView_StaffList.HitTest(e.X, e.Y).ColumnIndex;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Copy", Copy_Click));
                m.MenuItems.Add(new MenuItem("Delete", Delete_Click));

                m.Show(dataGridView_StaffList, new Point(e.X, e.Y));
            }
        }
    }
}
