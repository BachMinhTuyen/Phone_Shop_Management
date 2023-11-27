using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement.UserArea
{
    public partial class frmGenerateBill : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;

        DataSet ds_QLPhoneShop = new DataSet();
        SqlDataAdapter da_Details, da_Bill, da_Product;
        DataTable table_Details, table_Product;

        private string StaffID, NewBillID = "TP", CustomerID = "TP";
        private string maKhachHangTamThoi, maDonHangTamThoi;

        public frmGenerateBill()
        {
            InitializeComponent();
        }
        public frmGenerateBill(string StaffID)
        {
            InitializeComponent();
            this.StaffID = StaffID;
        }

        #region Hàm tự định nghĩa
        private string GetStaffName(string StaffID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT TenNV FROM NhanVien WHERE MaNV = @maNV";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maNV", StaffID);

                    connection.Open();
                    string name = cmd.ExecuteScalar().ToString();
                    return name;
                }
            }
        }
        private void CreateBillID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT MADH FROM DONHANG";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table_Bill = new DataTable();
                    adapter.Fill(table_Bill);

                    string newID = "0";
                    foreach (DataRow dr in table_Bill.Rows)
                    {
                        int lenght = dr["MaDH"].ToString().Length;
                        string id = dr["MaDH"].ToString().Substring(2, lenght - 2).Trim();

                        if (int.Parse(id) > int.Parse(newID))
                            newID = id;
                    }
                    int index = int.Parse(newID) + 1;
                    if (index < 10)
                        NewBillID += "00" + index;
                    else if (index < 100)
                        NewBillID += "0" + index;
                    else
                        NewBillID += index;
                }
            }
        }
        private void CreateCustomerID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT MaKH FROM KhachHang";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table_Customer = new DataTable();
                    adapter.Fill(table_Customer);

                    CustomerID = "0";
                    foreach (DataRow dr in table_Customer.Rows)
                    {
                        int lenght = dr["MaKH"].ToString().Length;
                        string id = dr["MaKH"].ToString().Substring(2, lenght - 2).Trim();

                        if (id == string.Empty)
                            break;

                        if (int.Parse(id) > int.Parse(CustomerID))
                            CustomerID = id;
                    }
                    int index = int.Parse(CustomerID) + 1;
                    if (index < 10)
                        CustomerID = "KH00" + index;
                    else if (index < 100)
                        CustomerID = "KH0" + index;
                    else
                        CustomerID = "KH" + index;
                }
            }
        }
        private void CreateTempBill(string maKhachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, SoDienThoai, Email, DiaChi) VALUES (@maKH, @tenKH, @ngaySinh, @soDienThoai, @email, @diaChi)";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maKH", maKhachHang);
                    cmd.Parameters.AddWithValue("@tenKH", "Tạm thời");
                    cmd.Parameters.AddWithValue("@ngaySinh", dateTimePicker_TimeOfPurchase.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@soDienThoai", "0000000000");
                    cmd.Parameters.AddWithValue("@email", "Tạm thời");
                    cmd.Parameters.AddWithValue("@diaChi", "Tạm thời");

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "INSERT INTO DonHang (MADH, ThoiGianMuaHang, ThanhToan, TongTien, MaKH, MaNV) VALUES (@maDonHang, @ngayMuaHang, @thanhToan, @tongTien, @maKH, @maNV)";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maDonHang", maDonHangTamThoi);
                    cmd.Parameters.AddWithValue("@ngayMuaHang", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@thanhToan", "Tiền Mặt");
                    cmd.Parameters.AddWithValue("@tongTien", 0);
                    cmd.Parameters.AddWithValue("@maKH", maKhachHang);
                    cmd.Parameters.AddWithValue("@maNV", StaffID);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteTempBill()
        {
            //Xoá các sản phẩm đơn hàng tạm thời trong bảng ChiTietDonHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE ChiTietDonHang WHERE MADH = @maDH";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maDH", maDonHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            //Xoá đơn hàng tạm thời trong bảng DonHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE DonHang WHERE MADH = @maDH";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maDH", maDonHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            //Xoá mã khách hàng tạm thời trong bảng KhachHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE KhachHang WHERE MAKH = @maKH";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maKH", maKhachHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void Load_Details(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Details = new SqlDataAdapter(cmd);

                    table_Details = new DataTable();
                    da_Details.Fill(table_Details);

                    dataGridView_Details.DataSource = table_Details;

                    // Điều chỉnh độ rộng của cột
                    dataGridView_Details.Columns["MaSP"].Width = 60;
                    dataGridView_Details.Columns["TenSP"].Width = 350;
                    dataGridView_Details.Columns["SoLuong"].Width = 100;
                    dataGridView_Details.Columns["DonGia"].Width = 120;
                    dataGridView_Details.Columns["ThanhTien"].Width = 120;
                }
            }
        }
        private void Load_ProductInformation(string maSP)
        {
            if (maSP == String.Empty) 
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT TenSP, Gia FROM SanPham WHERE MaSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    // Khởi tạo Sql Data Adapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    txtBox_ProductName.Text = table.Rows[0]["TenSP"].ToString();
                    txtBox_Price.Text = table.Rows[0]["Gia"].ToString();
                }
            }
        }
        private string KiemTraVaLayMaKhachHang(string soDienThoai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //string sqlCommand = "SELECT TOP(1) MaKH FROM KhachHang WHERE TenKH = '%' + @tenKH + '%' AND SoDienThoai = @sdt";
                string sqlCommand = "SELECT TOP(1) MaKH FROM KhachHang WHERE SoDienThoai = @sdt";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@sdt", soDienThoai);
                    //cmd.Parameters.AddWithValue("@tenKH", tenKhachHang);

                    connection.Open();
                    if (cmd.ExecuteScalar() == null)
                        return string.Empty;
                    else
                        return cmd.ExecuteScalar().ToString();
                }
            }
        }
        private double TinhTongTienSanPhamTrongDonHang()
        {
            double sum;
            string sqlCommand = "SELECT SUM(ThanhTien) FROM ChiTietDonHang WHERE MADH = '" + maDonHangTamThoi + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                sum = double.Parse(cmd.ExecuteScalar().ToString());
                connection.Close();
            }
            return sum;
        }
        private int TinhTongSoLuongSanPham()
        {
            int sum;
            string sqlCommand = "SELECT COUNT(MASP) FROM ChiTietDonHang WHERE MADH = '" + maDonHangTamThoi + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                sum = int.Parse(cmd.ExecuteScalar().ToString());
                connection.Close();
            }
            return sum;
        }
        private bool KiemTraMaSanPham(string maSP)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT COUNT(MaSP) FROM SanPham WHERE MaSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    connection.Open();
                    int sum = int.Parse(cmd.ExecuteScalar().ToString());
                    if (sum != 0)
                        return true; // Có tồn tại sản phẩm
                    else
                        return false; // Không có sản phẩm
                }
            }
        }
        private double LayGiaTriKhuyenMai(string maSP)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT TOP(1) KhuyenMai FROM SanPham WHERE MaSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    connection.Open();
                    double rate = double.Parse(cmd.ExecuteScalar().ToString());
                    return rate;
                }
            }
        }
        private void Clear()
        {
            NewBillID = CustomerID = "TP";

            txtBox_Total.Text = "0";
            txtBox_CustomerName.Clear();
            txtBox_Email.Clear();
            txtBox_PhoneNumber.Clear();
            txtBox_Address.Clear();
            txtBox_Price.Clear();
            txtBox_ProductID.Clear();
            txtBox_ProductName.Clear();

        }
        private void Refresh()
        {
            txtBox_ProductID.Clear();
            txtBox_ProductName.Clear();
            txtBox_Price.Clear();
            txtBox_StaffName.Text = GetStaffName(StaffID);
            txtBox_Total.Text = TinhTongTienSanPhamTrongDonHang().ToString("###,###.00");
        }
        private void UpdateCustomerInfo(string maKhachHang)
        {
            //Kiểm tra tuổi phải từ 18 tuổi trở lên
            if (dateTimePicker_TimeOfPurchase.Value.Year > DateTime.Now.Year - 18)
            {
                MessageBox.Show("Kiểm tra và cập nhật ngày sinh của khách hàng", "Thông báo");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = string.Format("INSERT INTO {0} VALUES (@Value_MaKH , @Value_TenKH, @Value_NgaySinh, @Value_SoDienThoai, @Value_Email, @Value_DiaChi)", "KhachHang");
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Tạo một đối tượng TextInfo từ CultureInfo hiện tại
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                    // Sử dụng phương thức ToTitleCase để chuyển đổi chuỗi thành dạng viết hoa chữ cái đầu
                    string CustomerName = textInfo.ToTitleCase(txtBox_CustomerName.Text);

                    cmd.Parameters.AddWithValue("@Value_MaKH", maKhachHang);
                    cmd.Parameters.AddWithValue("@Value_TenKH", CustomerName);
                    cmd.Parameters.AddWithValue("@Value_NgaySinh", Convert.ToDateTime(dateTimePicker_TimeOfPurchase.Value.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("@Value_SoDienThoai", txtBox_PhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Value_Email", txtBox_Email.Text);
                    cmd.Parameters.AddWithValue("@Value_DiaChi", txtBox_Address.Text);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string query;
            if (KiemTraMaSanPham(txtBox_ProductID.Text.Trim()) == true)
            {
                foreach (DataRow item in table_Details.Rows)
                {
                    //Đã có trong table Details thì cập nhật lại số lượng
                    if (String.Compare(txtBox_ProductID.Text.Trim(), item["MaSP"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string sqlCommand = "UPDATE ChiTietDonHang SET SoLuong = @soLuong WHERE MADH = '" + NewBillID + "' AND MaSP = @maSP ";
                            using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                            {
                                cmd.Parameters.AddWithValue("@maSP", txtBox_ProductID.Text.Trim());
                                cmd.Parameters.AddWithValue("@soLuong", int.Parse(item["SoLuong"].ToString()) + numericUpDown_Quantity.Value);

                                connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        Refresh();
                        query = "SELECT CT.MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + NewBillID + "'";
                        Load_Details(query);
                        return;
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlCommand = "INSERT INTO ChiTietDonHang (MADH, MaSP, SoLuong, DonGia, ThanhTien) VALUES (@maDonHang, @maSanPham, @soLuong, @donGia, @thanhTien)";
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                    {
                        cmd.Parameters.AddWithValue("@maDonHang", NewBillID);
                        cmd.Parameters.AddWithValue("@maSanPham", txtBox_ProductID.Text.Trim());
                        cmd.Parameters.AddWithValue("@soLuong", numericUpDown_Quantity.Value);
                        cmd.Parameters.AddWithValue("@donGia", double.Parse(txtBox_Price.Text.Trim()));
                        double thanhTien = (double)numericUpDown_Quantity.Value * double.Parse(txtBox_Price.Text.Trim()) * (1 - LayGiaTriKhuyenMai(txtBox_ProductID.Text.Trim()));
                        cmd.Parameters.AddWithValue("@thanhTien", Math.Round(thanhTien, 2));

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                Refresh();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm này\n\nVui lòng kiểm tra kỹ mã sản phẩm", "Thông báo");
            }
            query = "SELECT CT.MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + NewBillID + "'";
            Load_Details(query);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "UPDATE ChiTietDonHang SET SoLuong = @soLuong, ThanhTien = @thanhTien WHERE MADH = '" + NewBillID + "' AND MaSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", txtBox_ProductID.Text.Trim());
                    cmd.Parameters.AddWithValue("@soLuong", numericUpDown_Quantity.Value);
                    double thanhTien = (double)numericUpDown_Quantity.Value * double.Parse(txtBox_Price.Text.Trim()) * (1.0 - LayGiaTriKhuyenMai(txtBox_ProductID.Text.Trim()));
                    cmd.Parameters.AddWithValue("@thanhTien", Math.Round(thanhTien, 2));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            Refresh();
            string query = "SELECT CT.MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + NewBillID + "'";
            Load_Details(query);
        }

        private void dataGridView_Information_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tongSanPhamTimThay = dataGridView_Information.RowCount;
            int index = e.RowIndex;
            if (index == -1 || index == tongSanPhamTimThay)
                return;

            txtBox_ProductID.Text = dataGridView_Information.Rows[index].Cells["MaSP"].Value.ToString();
            txtBox_ProductName.Text = dataGridView_Information.Rows[index].Cells["TenSP"].Value.ToString();
            txtBox_Price.Text = dataGridView_Information.Rows[index].Cells["Gia"].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //if (TinhTongSoLuongSanPham() == 0)
            //    MessageBox.Show("Không xoá được vì đơn hàng chỉ còn một sản phẩm", "Thông báo");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE FROM ChiTietDonHang WHERE MASP = @maSP AND MADH = '" + NewBillID + "'";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", txtBox_ProductID.Text.Trim());

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            Refresh();
            string query = "SELECT CT.MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + NewBillID + "'";
            Load_Details(query);
        }

        private void txtBox_ProductID_Leave(object sender, EventArgs e)
        {
            Load_ProductInformation(txtBox_ProductID.Text.Trim());
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs frm = new frmAboutUs();
            frm.ShowDialog();
        }

        private void thiếtLậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserProfile frm = new frmUserProfile(StaffID);
            frm.ShowDialog();
        }

        private void đăgnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nếu bạn đăng xuất thì sẽ bị huỷ đơn hàng hiện tại", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DeleteTempBill();
                this.Close();
            }
        }

        private void tạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBill frm = new frmSearchBill();
            frm.ShowDialog();
        }

        private void xemHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new frmSearchProduct();
            frm.ShowDialog();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTempBill();
            Clear();
            txtBox_ProductID.Clear();
            txtBox_ProductName.Clear();
            txtBox_Price.Clear();
            txtBox_StaffName.Text = GetStaffName(StaffID);
            txtBox_Total.Text = "0";
            MessageBox.Show("Đã làm mới", "Thông báo");
        }

        private void dataGridView_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || index == TinhTongSoLuongSanPham())
                return;

            txtBox_ProductID.Text = dataGridView_Details.Rows[index].Cells["MaSP"].Value.ToString();
            txtBox_ProductName.Text = dataGridView_Details.Rows[index].Cells["TenSP"].Value.ToString();
            numericUpDown_Quantity.Value = int.Parse(dataGridView_Details.Rows[index].Cells["SoLuong"].Value.ToString());
            txtBox_Price.Text = dataGridView_Details.Rows[index].Cells["DonGia"].Value.ToString();
        }

        private void frmGenerateBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DeleteTempBill();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, KhuyenMai, Gia FROM SanPham SP, ThuongHieu TH WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.TenSP LIKE N'%" + txtBox_Search.Text.Trim() + "%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (txtBox_Search.Text == string.Empty)
                    return;

                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Product = new SqlDataAdapter(cmd);

                    table_Product = new DataTable();

                    // Đổ dữ liệu vào Data Table
                    da_Product.Fill(table_Product);
                    dataGridView_Information.DataSource = table_Product;

                    DataColumn[] key = new DataColumn[1];
                    key[0] = table_Product.Columns[0];
                    table_Product.PrimaryKey = key;

                    // Điều chỉnh độ rộng của cột
                    dataGridView_Information.Columns["MaSP"].Width = 60;
                    dataGridView_Information.Columns["TenSP"].Width = 200;
                    dataGridView_Information.Columns["TenThuongHieu"].Width = 120;
                    //dataGridView_Information.Columns["TenLoai"].Width = 120;
                    //dataGridView_Information.Columns["KhuyenMai"].Width = 80;
                    dataGridView_Information.Columns["Gia"].Width = 80;
                    //dataGridView_Information.Columns["HinhAnh"].Width = 120;
                    //dataGridView_Information.Columns["SoLuongConLai"].Width = 100;
                    //dataGridView_Information.Columns["TinhTrang"].Width = 80;
                    //dataGridView_Information.Columns["MoTa"].Width = 300;
                }
            }
        }
        
        private void btn_GenerateBill_Click(object sender, EventArgs e)
        {

            if (TinhTongSoLuongSanPham() == 0)
            {
                DeleteTempBill();
                return;
            }

            // Tạo một đối tượng TextInfo từ CultureInfo hiện tại
            //TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            // Sử dụng phương thức ToTitleCase để chuyển đổi chuỗi thành dạng viết hoa chữ cái đầu
            //string CustomerName = textInfo.ToTitleCase(txtBox_CustomerName.Text);

            string maKH = KiemTraVaLayMaKhachHang(txtBox_PhoneNumber.Text);

            if (maKH != String.Empty)
                CustomerID = maKH;
            // Ngược lại, thì khởi tạo mã khách hàng
            else
            {
                CreateCustomerID();

                //Cập nhật thông tin khách hàng
                UpdateCustomerInfo(CustomerID);
            }

            ////Tạo bill với mã bill hiện tại đã bỏ tiền tố (TP)
            int lenght = NewBillID.Length;
            NewBillID = "HD" + NewBillID.Substring(2, lenght - 2);

            string method = radioButton_Cash.Checked == true ? "Tiền mặt" : "Chuyển khoản/quẹt thẻ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "INSERT INTO DonHang (MADH, ThoiGianMuaHang, ThanhToan, TongTien, MaKH, MaNV) VALUES (@maDonHang, @ngayMuaHang, @thanhToan, @tongTien, @maKH, @maNV)";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maDonHang", NewBillID);
                    cmd.Parameters.AddWithValue("@ngayMuaHang", dateTimePicker_TimeOfPurchase.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@thanhToan", method);
                    cmd.Parameters.AddWithValue("@tongTien", TinhTongTienSanPhamTrongDonHang());
                    cmd.Parameters.AddWithValue("@maKH", CustomerID);
                    cmd.Parameters.AddWithValue("@maNV", StaffID);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            //Cập nhật loại mã hoá đơn cho các sản phẩm trong ChiTietDonHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "UPDATE ChiTietDonHang SET MADH = @MADH_Moi WHERE MADH = @MADH_Cu;";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@MADH_Moi", NewBillID);
                    cmd.Parameters.AddWithValue("@MADH_Cu", maDonHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            //Xoá đơn hàng tạm thời trong bảng DonHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE DonHang WHERE MADH = @maDH";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maDH", maDonHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            //Xoá mã khách hàng tạm thời trong bảng KhachHang
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE KhachHang WHERE MAKH = @maKH";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maKH", maKhachHangTamThoi);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Tạo hoá đơn thành công", "Thông báo");
            Clear();

            frmGenerateBill_Load(sender, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DeleteTempBill();

            MessageBox.Show("Huỷ hoá đơn thành công", "Thông báo");
            Clear();
        }

        private void frmGenerateBill_Load(object sender, EventArgs e)
        {

            maDonHangTamThoi = string.Empty;
            maKhachHangTamThoi = string.Empty;

            txtBox_Total.Text = "0";
            radioButton_Cash.Checked = true;
            txtBox_StaffName.Text = GetStaffName(StaffID);


            // Khởi tạo mã hoá đơn
            CreateBillID();

            // Gán giá trị lên biến tạm thời để sử dụng khi click "Tạo hoá đơn"
            maKhachHangTamThoi = CustomerID;
            maDonHangTamThoi = NewBillID;

            //Tạo một hoá đơn tạm thời
            CreateTempBill(CustomerID);

            // Tải thông tin sản phẩm về hoá đơn đó 
            string sqlCommand = "SELECT CT.MaSP, TenSP, KhuyenMai, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + NewBillID + "'";
            Load_Details(sqlCommand);
        }
    }
}
