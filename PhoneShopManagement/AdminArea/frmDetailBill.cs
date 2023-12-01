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
    public partial class frmDetailBill : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        private DataSet ds_QLPhoneShop = new DataSet();
        private SqlDataAdapter da_Details;
        private string BillID = "HD001";
        public frmDetailBill()
        {
            InitializeComponent();
        }
        public frmDetailBill(string BillID)
        {
            InitializeComponent();
            this.BillID = BillID;
        }
        #region Hàm tự định nghĩa
        private void Load_Details(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Details = new SqlDataAdapter(cmd);

                    // Làm sạch DataSet
                    ds_QLPhoneShop.Clear();

                    // Đổ dữ liệu vào DataSet
                    da_Details.Fill(ds_QLPhoneShop, "ChiTietDonHang");
                    dataGridView_DetailsBill.DataSource = ds_QLPhoneShop.Tables["ChiTietDonHang"];

                    // Điều chỉnh độ rộng của cột
                    dataGridView_DetailsBill.Columns["MaSP"].Width = 60;
                    dataGridView_DetailsBill.Columns["TenSP"].Width = 350;
                    dataGridView_DetailsBill.Columns["SoLuong"].Width = 100;
                    dataGridView_DetailsBill.Columns["DonGia"].Width = 120;
                    dataGridView_DetailsBill.Columns["ThanhTien"].Width = 120;
                }
            }
        }
        private void Load_BillInfo(string BillID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT DH.ThoiGianMuaHang, DH.MaKH, KH.TenKH, DH.MaNV, NV.TenNV, KH.SoDienThoai, KH.Email, KH.DiaChi FROM DonHang DH, KhachHang KH, NhanVien NV WHERE DH.MaKH = KH.MaKH AND DH.MaNV = NV.MaNV AND DH.MADH = '" + BillID + "'";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Details = new SqlDataAdapter(cmd);

                    DataTable table = new DataTable();

                    da_Details.Fill(table);

                    txtBox_BillID.Text = BillID;
                    dateTimePicker_TimeOfPurchase.Value = (DateTime)table.Rows[0]["ThoiGianMuaHang"];
                    txtBox_CustomerID.Text = table.Rows[0]["MaKH"].ToString();
                    txtBox_CustomerName.Text = table.Rows[0]["TenKH"].ToString();
                    txtBox_StaffID.Text = table.Rows[0]["MaNV"].ToString();
                    txtBox_StaffName.Text = table.Rows[0]["TenNV"].ToString();
                    txtBox_PhoneNumber.Text = table.Rows[0]["SoDienThoai"].ToString();
                    txtBox_Email.Text = table.Rows[0]["Email"].ToString();
                    txtBox_Address.Text = table.Rows[0]["DiaChi"].ToString();
                }
            }
        }
        private int TinhTongSanPhamTrongDonHang()
        {
            int sum;
            string sqlCommand = "SELECT COUNT(MaSP) FROM ChiTietDonHang WHERE MADH = '" + BillID + "'";
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
        private void Load_ProductInformation(string maSP)
        {
            if (maSP == String.Empty || KiemTraMaSanPham(maSP) == false)
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
        private double TinhTongTienThanhToan()
        {
            double tongTT = 0;
            foreach (DataRow item in ds_QLPhoneShop.Tables["ChiTietDonHang"].Rows)
            {
                tongTT += double.Parse(item["ThanhTien"].ToString());
            }
            return tongTT;
        }
        private int KiemTraSoLuongHang(string maSanPham)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SoLuongConLai FROM SanPham WHERE MaSP = @MaSP";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", maSanPham);

                    // Thực thi truy vấn và trả về số lượng hàng còn lại của mã sản phẩm
                    int result = (int)command.ExecuteScalar();

                    return result;
                }
            }
        }
        private void CapNhatSoLuongHang(string maSanPham, int soLuong, string phuongThuc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "";

                connection.Open();

                //Nếu thêm vào chi tiết đơn hàng thì giảm số lượng
                if (String.Compare(phuongThuc, "insert", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    query = "UPDATE SanPham SET SoLuongConLai = SoLuongConLai - @soLuong FROM SanPham WHERE MaSP = @MaSP";
                }
                //Ngược lại thì tăng số lượng về ban đầu
                else
                {
                    query = "UPDATE SanPham SET SoLuongConLai = SoLuongConLai + @soLuong FROM SanPham WHERE MaSP = @MaSP";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", maSanPham);
                    command.Parameters.AddWithValue("@soLuong", soLuong);

                    // Thực thi truy vấn
                    command.ExecuteNonQuery();
                }
                //Kiểm tra số lượng sản phẩm có mã sản phẩm này (maSP). Nếu > 0 thì sửa thành 'Còn Hàng'
                if (KiemTraSoLuongHang(maSanPham) > 0)
                {
                    query = "UPDATE SanPham SET TinhTrang = N'Còn Hàng' WHERE SoLuongConLai > 0 AND MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSanPham);
                        command.Parameters.AddWithValue("@soLuong", soLuong);

                        // Thực thi truy vấn
                        command.ExecuteNonQuery();
                    }
                }
                //Kiểm tra số lượng sản phẩm có mã sản phẩm này (maSP). Nếu = 0 thì sửa thành 'Hết Hàng'
                if (KiemTraSoLuongHang(maSanPham) == 0)
                {
                    query = "UPDATE SanPham SET TinhTrang = N'Hết Hàng' WHERE SoLuongConLai <= 0 AND MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSanPham);
                        command.Parameters.AddWithValue("@soLuong", soLuong);

                        // Thực thi truy vấn
                        command.ExecuteNonQuery();
                    }
                }

            }
        }
        #endregion

        private void frmDetailBill_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT CT.MaSP, TenSP, SoLuong, DonGia, ThanhTien FROM ChiTietDonHang CT, SanPham SP WHERE CT.MaSP = SP.MaSP AND MADH = '" + BillID + "'";
            Load_Details(sqlCommand);
            Load_BillInfo(BillID);

            txtBox_Total.Text = TinhTongTienThanhToan().ToString("###,###.00");
            numericUpDown_Quantity.Value = 1;
        }

        private void dataGridView_DetailsBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_ProductID.ReadOnly = true;

            int index = e.RowIndex; 
            if (index == -1 || index == TinhTongSanPhamTrongDonHang())
                return;

            txtBox_ProductID.Text = dataGridView_DetailsBill.Rows[index].Cells["MaSP"].Value.ToString();
            txtBox_ProductName.Text = dataGridView_DetailsBill.Rows[index].Cells["TenSP"].Value.ToString();
            numericUpDown_Quantity.Value = int.Parse(dataGridView_DetailsBill.Rows[index].Cells["SoLuong"].Value.ToString());
            txtBox_Price.Text = dataGridView_DetailsBill.Rows[index].Cells["DonGia"].Value.ToString();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (KiemTraSoLuongHang(txtBox_ProductID.Text.Trim()) == 0)
            {
                MessageBox.Show("Sản phẩm này đang hết hàng", "Thông báo");
                return;
            }
            if (KiemTraSoLuongHang(txtBox_ProductID.Text.Trim()) < numericUpDown_Quantity.Value)
            {
                MessageBox.Show("Sản phẩm không đủ để giao dịch");
                return;
            }
            if (KiemTraMaSanPham(txtBox_ProductID.Text.Trim()) == true)
            {
                //Cập nhật lại số lượng sản phẩm trong kho
                CapNhatSoLuongHang(txtBox_ProductID.Text.Trim(), Convert.ToInt32(numericUpDown_Quantity.Value), "insert");
                
                foreach (DataRow item in ds_QLPhoneShop.Tables["ChiTietDonHang"].Rows)
                {
                    if (String.Compare(txtBox_ProductID.Text.Trim(), item["MaSP"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string sqlCommand = "UPDATE ChiTietDonHang SET SoLuong = @soLuong WHERE MADH = '" + BillID + "' AND MaSP = @maSP";
                            using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                            {
                                cmd.Parameters.AddWithValue("@maSP", txtBox_ProductID.Text.Trim());
                                cmd.Parameters.AddWithValue("@soLuong", int.Parse(item["SoLuong"].ToString()) + numericUpDown_Quantity.Value);

                                connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        btn_Refresh_Click(sender, e);
                        return;
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlCommand = "INSERT INTO ChiTietDonHang (MADH, MaSP, SoLuong, DonGia, ThanhTien) VALUES (@maDonHang, @maSanPham, @soLuong, @donGia, @thanhTien)";
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                    {
                        cmd.Parameters.AddWithValue("@maDonHang", BillID);
                        cmd.Parameters.AddWithValue("@maSanPham", txtBox_ProductID.Text.Trim());
                        cmd.Parameters.AddWithValue("@soLuong", numericUpDown_Quantity.Value);
                        cmd.Parameters.AddWithValue("@donGia", double.Parse(txtBox_Price.Text.Trim()));
                        double thanhTien = (double)numericUpDown_Quantity.Value * double.Parse(txtBox_Price.Text.Trim()) * (1 - LayGiaTriKhuyenMai(txtBox_ProductID.Text.Trim()));
                        cmd.Parameters.AddWithValue("@thanhTien", Math.Round(thanhTien, 2));

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                btn_Refresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm này\n\nVui lòng kiểm tra kỹ mã sản phẩm", "Thông báo");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in ds_QLPhoneShop.Tables["ChiTietDonHang"].Rows)
            {
                //Kiểm tra sản phẩm cần cập nhật
                if (String.Compare(txtBox_ProductID.Text.Trim(), item["MaSP"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    if (Convert.ToInt32(numericUpDown_Quantity.Value) > int.Parse(item["SoLuong"].ToString()))
                    {
                        int soLuongSanPhamChenhLech = Convert.ToInt32(numericUpDown_Quantity.Value) - int.Parse(item["SoLuong"].ToString());
                        //Cập nhật lại số lượng sản phẩm trong kho
                        CapNhatSoLuongHang(txtBox_ProductID.Text.Trim(), soLuongSanPhamChenhLech, "insert");
                    }
                    else if (Convert.ToInt32(numericUpDown_Quantity.Value) < int.Parse(item["SoLuong"].ToString()))
                    {
                        int soLuongSanPhamChenhLech = int.Parse(item["SoLuong"].ToString()) - Convert.ToInt32(numericUpDown_Quantity.Value);
                        //Cập nhật lại số lượng sản phẩm trong kho
                        CapNhatSoLuongHang(txtBox_ProductID.Text.Trim(), soLuongSanPhamChenhLech, "delete");
                    }
                    else
                        break;
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "UPDATE ChiTietDonHang SET SoLuong = @soLuong, ThanhTien = @thanhTien WHERE MADH = '" + BillID + "' AND MaSP = @maSP";
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
            btn_Refresh_Click(sender, e);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (TinhTongSanPhamTrongDonHang() == 1)
                MessageBox.Show("Không xoá được vì đơn hàng chỉ còn một sản phẩm", "Thông báo");
            foreach (DataRow item in ds_QLPhoneShop.Tables["ChiTietDonHang"].Rows)
            {
                //Kiểm tra sản phẩm cần cập nhật
                if (String.Compare(txtBox_ProductID.Text.Trim(), item["MaSP"].ToString(), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    //Cập nhật lại số lượng sản phẩm trong kho
                    CapNhatSoLuongHang(txtBox_ProductID.Text.Trim(), int.Parse(item["SoLuong"].ToString()), "delete");
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "DELETE FROM ChiTietDonHang WHERE MASP = @maSP AND MADH = '" + BillID + "'";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", txtBox_ProductID.Text.Trim());

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            btn_Refresh_Click(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txtBox_ProductID.ReadOnly = false;
            txtBox_ProductID.Clear();
            txtBox_ProductName.Clear();
            txtBox_Price.Clear();

            frmDetailBill_Load(sender, e);
        }

        private void btn_Final_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_ProductID_Leave(object sender, EventArgs e)
        {
            Load_ProductInformation(txtBox_ProductID.Text.Trim());
        }
    }
}
