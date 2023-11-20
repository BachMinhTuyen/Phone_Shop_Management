using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmProduct : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        private DataSet ds_QLPhoneShop = new DataSet();
        private SqlDataAdapter da_Product;

        private string fileImageName, oldImageName;
        private string selectedImagePath;
        public frmProduct()
        {
            InitializeComponent();
        }

        #region Hàm tự định nghĩa
        private void Load_ProductInformation(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Product = new SqlDataAdapter(cmd);

                    // Làm sạch DataSet
                    ds_QLPhoneShop.Clear();

                    // Đổ dữ liệu vào DataSet
                    da_Product.Fill(ds_QLPhoneShop, "SanPham");
                    dataGridView_ProductList.DataSource = ds_QLPhoneShop.Tables["SanPham"];

                    DataColumn[] key = new DataColumn[1];
                    key[0] = ds_QLPhoneShop.Tables["SanPham"].Columns[0];
                    ds_QLPhoneShop.Tables["SanPham"].PrimaryKey = key;

                    // Điều chỉnh độ rộng của cột
                    dataGridView_ProductList.Columns["MaSP"].Width = 60;
                    dataGridView_ProductList.Columns["TenSP"].Width = 200;
                    dataGridView_ProductList.Columns["TenThuongHieu"].Width = 120;
                    dataGridView_ProductList.Columns["TenLoai"].Width = 120;
                    dataGridView_ProductList.Columns["KhuyenMai"].Width = 80;
                    dataGridView_ProductList.Columns["Gia"].Width = 80;
                    dataGridView_ProductList.Columns["HinhAnh"].Width = 120;
                    dataGridView_ProductList.Columns["SoLuongConLai"].Width = 100;
                    dataGridView_ProductList.Columns["TinhTrang"].Width = 80;
                    dataGridView_ProductList.Columns["MoTa"].Width = 300;
                }
            }
        }
        private void Load_BrandList()
        {
            string sqlCommand = "SELECT * FROM ThuongHieu";
            using (DataSet data = new DataSet())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data, "ThuongHieu");
                }

                comboBox_BrandName.DataSource = data.Tables["ThuongHieu"];
                comboBox_BrandName.DisplayMember = "TenThuongHieu";
                comboBox_BrandName.ValueMember = "MaThuongHieu";

                DataTable dataTable = data.Tables["ThuongHieu"].Copy();

                // Thêm một dòng mới với giá trị MaThuongHieu là -1 và TenThuongHieu là "Lựa chọn"
                DataRow newRow = dataTable.NewRow();
                newRow["MaThuongHieu"] = -1;
                newRow["TenThuongHieu"] = "Lựa chọn";
                dataTable.Rows.InsertAt(newRow, 0); // Chèn vào vị trí đầu tiên

                comboBox_FilterBrandName.DataSource = dataTable;
                comboBox_FilterBrandName.DisplayMember = "TenThuongHieu";
                comboBox_FilterBrandName.ValueMember = "MaThuongHieu";
            }
        }
        private void Load_ProductType()
        {
            string sqlCommand = "SELECT * FROM LoaiSanPham";
            using (DataSet data = new DataSet())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data, "LoaiSanPham");
                }
                int i = comboBox_ProductType.Items.Count;

                comboBox_ProductType.DataSource = data.Tables["LoaiSanPham"];
                comboBox_ProductType.DisplayMember = "TenLoai";
                comboBox_ProductType.ValueMember = "MaLoai";

                DataTable dataTable = data.Tables["LoaiSanPham"].Copy();
                
                // Thêm một dòng mới với giá trị MaLoai là -1 và TenLoai là "Lựa chọn"
                DataRow newRow = dataTable.NewRow();
                newRow["MaLoai"] = -1;
                newRow["TenLoai"] = "Lựa chọn";
                dataTable.Rows.InsertAt(newRow, 0); // Chèn vào vị trí đầu tiên

                comboBox_FilterProductType.DataSource = dataTable;
                comboBox_FilterProductType.DisplayMember = "TenLoai";
                comboBox_FilterProductType.ValueMember = "MaLoai";
            }
        }
        private void Load_Filter()
        {
            string[] data = { "Lựa chọn", "0", "5000000", "10000000", "15000000", "20000000", "25000000", "30000000", "35000000", "Trên 35 triệu" };

            if (comboBox_PriceFrom.Items.Count > 0 || comboBox_PriceTo.Items.Count > 0)
            {
                comboBox_PriceFrom.Items.Clear();
                comboBox_PriceTo.Items.Clear();
            }

            foreach (string item in data)
            {
                
                comboBox_PriceFrom.Items.Add(item);
                comboBox_PriceTo.Items.Add(item);
            }

            comboBox_PriceFrom.SelectedIndex = 0;
            comboBox_PriceTo.SelectedIndex = 0;
            radioButton_FilterStocking.Checked = true;
            radioButton_FilterOutOfStock.Checked = radioButton_FilterStopBusiness.Checked = false;
        }
        private string GetID(string tenCotLayGiaTri, string tenBang, string tenCot, string giaTriCot)
        {
            string ID = "";
            string sqlCommand = "SELECT " + tenCotLayGiaTri + " FROM " + tenBang + " WHERE " + tenCot + " = @giaTriCot";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.Parameters.AddWithValue("@giaTriCot", giaTriCot);

                connection.Open();
                ID = cmd.ExecuteScalar().ToString();
            }
            return ID;
        }
        private string TongSanPham()
        {
            string total;
            string sqlCommand = "SELECT COUNT(MaSP) FROM SanPham";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                connection.Open();
                total = cmd.ExecuteScalar().ToString();
            }
            return total;
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
        private bool KiemTraMaSP(string maNV)
        {
            foreach (DataRow row in ds_QLPhoneShop.Tables["SanPham"].Rows)
                if (String.Compare(maNV, row["MaSP"].ToString()) == 0)
                    return true; // trùng mã sản phẩm
            return false; //chưa có mã sản phẩm
        }
        private bool KiemTraThongTinDauVao()
        {
            //Kiểm tra mã sản phẩm
            if (txtBox_ProductID.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã sản phẩm", "Thông báo");
                txtBox_ProductID.Focus();
                return false;
            }
            else
            {
                if (KiemTraMaSP(txtBox_ProductID.Text) == true)
                {
                    MessageBox.Show("Đã có mã nhân viên này", "Thông báo");
                    txtBox_ProductID.Focus();
                    return false;
                }
            }
            // Kiểm tra thông tin tên sản phẩm
            if (txtBox_ProductName.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", "Thông báo");
                txtBox_ProductName.Focus();
                return false;
            }
            // Kiểm tra thông tin tên thương hiệu
            if (comboBox_BrandName.SelectedValue.ToString() == String.Empty)
            {
                MessageBox.Show("Chưa chọn tên thương hiệu", "Thông báo");
                comboBox_BrandName.SelectedIndex = 0;
                return false;
            }
            // Kiểm tra thông tin loại sản phẩm
            if (comboBox_ProductType.SelectedValue.ToString() == String.Empty)
            {
                MessageBox.Show("Chưa chọn loại sản phẩm", "Thông báo");
                comboBox_BrandName.SelectedIndex = 0;
                return false;
            }
            // Kiểm tra thông tin giá cả sản phẩm
            if (txtBox_Price.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập giá cả sản phẩm", "Thông báo");
                txtBox_Price.Focus();
                return false;
            }
            else
            {
                if (IsNumber(txtBox_Price.Text) == false)
                {
                    MessageBox.Show("Kiểm tra lại giá cả sản phẩm", "Thông báo");
                    txtBox_Price.Focus();
                    return false;
                }
            }
            // Kiểm tra tỉ lệ khuyến mãi (từ 0 tới 50%)
            if (numericUpDown_PercentPromotion.Value < 0 || numericUpDown_PercentPromotion.Value > 50)
            {
                MessageBox.Show("Tỉ lệ khuyến mãi (từ 0 tới 50%)", "Thông báo");
                numericUpDown_PercentPromotion.Value = 0;
                return false;
            }
            // Kiểm tra sản phầm hiện có trong kho
            if (txtBox_Quantity.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập số lượng hiện có", "Thông báo");
                txtBox_Quantity.Focus();
                return false;
            }
            else
            {
                if (IsNumber(txtBox_Quantity.Text) == false)
                {
                    MessageBox.Show("Kiểm tra lại số lượng hiện có", "Thông báo");
                    txtBox_Quantity.Focus();
                    return false;
                }
            }
            if (radioButton_StopBusiness.Checked == true)
            {
                MessageBox.Show("Sản phẩm mới không được để ngừng kinh doanh", "Thông báo");
                radioButton_StopBusiness.Checked = false;
                radioButton_Stocking.Checked = true;
                return false;
            }
            return true;
        }
        private void getImageName()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    //Lấy tên file ảnh
                    fileImageName = Path.GetFileName(selectedImagePath).Trim();
                }
                MessageBox.Show("Tải lên thành công!");
            }
        }
        private void SaveImage(string imagePath)
        {
            try
            {
                // Thư mục đích trong dự án (chỉ định đường dẫn thư mục của bạn)
                string destinationFolder = Directory.GetCurrentDirectory();;
                destinationFolder = Path.GetFullPath(Path.Combine(destinationFolder, @"..\..\", "Images"));

                // Tạo thư mục nếu nó không tồn tại
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                //Xoá ảnh cũ để thay thế ảnh mới (nếu có)
                string oldImagePath = Path.Combine(destinationFolder, oldImageName);
                if (File.Exists(oldImagePath))
                {
                    File.Delete(oldImagePath);
                }

                // Lưu trữ ảnh: Copy từ đường dẫn nguồn đến thư mục đích
                string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(imagePath));
                File.Copy(imagePath, destinationPath, true);

                MessageBox.Show("Lưu trữ ảnh thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private double MaxPrice()
        {
            double max;
            string sqlCommand = "SELECT MAX(Gia) FROM SanPham";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                connection.Open();
                max = double.Parse(cmd.ExecuteScalar().ToString());
            }
            return max;
        }
        private bool KiemTraSanPhamCoTrongDonHang(string maSP)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlCommand = "SELECT COUNT(MaSP) FROM ChiTietDonHang WHERE MaSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    connection.Open();
                    int c = int.Parse(cmd.ExecuteScalar().ToString());
                    if (c != 0)
                        return true; // Có sản phẩm trong đơn hàng
                    else
                        return false; // Không có sản phẩm trong đơn hàng
                }
            }
        }
        //Vị trí khi nhấn chuột phải
        private int currentRowIndex, currentColIndex = 0;
        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView_ProductList.Rows[currentRowIndex].Cells[currentColIndex].Value.ToString());
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            btn_Clear_Click(sender, e);
            txtBox_ProductID.Text = dataGridView_ProductList.Rows[currentRowIndex].Cells["MaSP"].Value.ToString();
            btn_Delete_Click(sender, e);
        }
        #endregion

        private void frmProduct_Load(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";
            Load_BrandList();
            Load_ProductType();
            Load_Filter();
            Load_ProductInformation(sqlCommand);

            radioButton_Stocking.Checked = true;
            txtBox_TotalProduct.Text = TongSanPham();
        }

        private void dataGridView_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fileImageName = "";
            txtBox_ProductID.Enabled = false;

            int index = e.RowIndex;
            if (index == -1 || index == int.Parse(TongSanPham()))
                return;

            txtBox_ProductID.Text = dataGridView_ProductList.Rows[index].Cells["MaSP"].Value.ToString();
            txtBox_ProductName.Text = dataGridView_ProductList.Rows[index].Cells["TenSP"].Value.ToString();

            ////Hiển thị tên thương hiệu trên combo box
            string tenThuongHieu = dataGridView_ProductList.Rows[index].Cells["TenThuongHieu"].Value.ToString();
            string maThuongHieu = GetID("MaThuongHieu", "ThuongHieu", "TenThuongHieu", tenThuongHieu);
            foreach (DataRowView item in comboBox_BrandName.Items)
            {
                string value = item[comboBox_BrandName.ValueMember]?.ToString();
                if (String.Compare(value, maThuongHieu) == 0)
                {
                    comboBox_BrandName.SelectedValue = value;
                    break;
                }
            }

            //// Hiển thị tên loại trên combo box
            string tenLoai = dataGridView_ProductList.Rows[index].Cells["TenLoai"].Value.ToString();
            string maLoai = GetID("MaLoai", "LoaiSanPham", "TenLoai", tenLoai);
            foreach (DataRowView item in comboBox_ProductType.Items)
            {
                string value = item[comboBox_ProductType.ValueMember]?.ToString();
                if (String.Compare(value, maLoai) == 0)
                {
                    comboBox_ProductType.SelectedValue = value;
                    break;
                }
            }

            txtBox_Price.Text = dataGridView_ProductList.Rows[index].Cells["Gia"].Value.ToString();
            numericUpDown_PercentPromotion.Maximum = 50;
            numericUpDown_PercentPromotion.Minimum = 0;
            numericUpDown_PercentPromotion.Value = Convert.ToInt32((double)dataGridView_ProductList.Rows[index].Cells["KhuyenMai"].Value * 100);
            txtBox_Quantity.Text = dataGridView_ProductList.Rows[index].Cells["SoLuongConLai"].Value.ToString();
            fileImageName = dataGridView_ProductList.Rows[index].Cells["HinhAnh"].Value.ToString();

            string status = dataGridView_ProductList.Rows[index].Cells["TinhTrang"].Value.ToString();
            if (String.Compare(status, "Hết Hàng", StringComparison.OrdinalIgnoreCase) == 0)
                radioButton_OutOfStock.Checked = true;
            else if (String.Compare(status, "Còn Hàng", StringComparison.OrdinalIgnoreCase) == 0)
                radioButton_Stocking.Checked = true;
            else // Ngừng kinh doanh
                radioButton_StopBusiness.Checked = true;

            txtBox_Description.Text = dataGridView_ProductList.Rows[index].Cells["MoTa"].Value.ToString();
        }
        
        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            if (fileImageName != "")
            {
                if (MessageBox.Show("Đã tồn tại hình ảnh.\n Bạn có chắc muốn thay thế nó", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
                else
                {
                    oldImageName = fileImageName;
                    getImageName();
                }    
            }
            else
            {
                getImageName();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            //Tải dữ liểu cho data grid view
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";
            Load_ProductInformation(sqlCommand);

            if (KiemTraThongTinDauVao() == false) 
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL INSERT
                    string insertCommand = "INSERT INTO SanPham (MaSP, TenSP, Gia, MoTa, SoLuongConLai, HinhAnh, KhuyenMai, TinhTrang, MaThuongHieu, MaLoai) VALUES (@MaSP, @TenSP, @Gia, @MoTa, @SoLuongConLai, @HinhAnh, @KhuyenMai, @TinhTrang, @MaThuongHieu, @MaLoai)";

                    using (SqlCommand insertCmd = new SqlCommand(insertCommand, connection))
                    {
                        // Thêm các tham số cho command
                        insertCmd.Parameters.AddWithValue("@MaSP", txtBox_ProductID.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@TenSP", txtBox_ProductName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@Gia", double.Parse(txtBox_Price.Text.Trim()));
                        insertCmd.Parameters.AddWithValue("@MoTa", txtBox_Description.Text);
                        insertCmd.Parameters.AddWithValue("@SoLuongConLai", int.Parse(txtBox_Quantity.Text.Trim()));
                        insertCmd.Parameters.AddWithValue("@HinhAnh", fileImageName);
                        insertCmd.Parameters.AddWithValue("@KhuyenMai", Math.Round((numericUpDown_PercentPromotion.Value) / 100, 2));

                        // Xử lý tình trạng
                        string tinhTrang;
                        if (radioButton_Stocking.Checked == true)
                            tinhTrang = "Còn hàng";
                        else if (radioButton_OutOfStock.Checked == true)
                            tinhTrang = "Hết hàng";
                        else
                            tinhTrang = "Ngừng kinh doanh";
                        insertCmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        insertCmd.Parameters.AddWithValue("@MaThuongHieu", comboBox_BrandName.SelectedValue.ToString());
                        insertCmd.Parameters.AddWithValue("@MaLoai", comboBox_ProductType.SelectedValue.ToString());

                        // Thực hiện câu lệnh INSERT
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Gọi hàm để lưu trữ ảnh
                SaveImage(selectedImagePath);

                // Cập nhật DataTable và hiển thị trên DataGridView
                btn_Clear_Click(sender, e);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi hàm để lưu trữ ảnh
                SaveImage(selectedImagePath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL UPDATE
                    string updateCommand = @"UPDATE SanPham SET TenSP = @TenSP, Gia = @Gia, MoTa = @MoTa, SoLuongConLai = @SoLuongConLai, HinhAnh = @HinhAnh, KhuyenMai = @KhuyenMai, TinhTrang = @TinhTrang, MaThuongHieu = @MaThuongHieu, MaLoai = @MaLoai WHERE MaSP = @MaSP";

                    using (SqlCommand updateCmd = new SqlCommand(updateCommand, connection))
                    {
                        // Thêm các tham số cho command
                        updateCmd.Parameters.AddWithValue("@MaSP", txtBox_ProductID.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@TenSP", txtBox_ProductName.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@Gia", double.Parse(txtBox_Price.Text.Trim()));
                        updateCmd.Parameters.AddWithValue("@MoTa", txtBox_Description.Text);
                        updateCmd.Parameters.AddWithValue("@SoLuongConLai", int.Parse(txtBox_Quantity.Text.Trim()));
                        updateCmd.Parameters.AddWithValue("@HinhAnh", fileImageName);
                        updateCmd.Parameters.AddWithValue("@KhuyenMai", Math.Round((numericUpDown_PercentPromotion.Value) / 100, 2));

                        // Xử lý tình trạng
                        string tinhTrang;
                        if (radioButton_Stocking.Checked == true)
                            tinhTrang = "Còn Hàng";
                        else if (radioButton_OutOfStock.Checked == true)
                            tinhTrang = "Hết Hàng";
                        else
                            tinhTrang = "Ngừng Kinh Doanh";
                        updateCmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        updateCmd.Parameters.AddWithValue("@MaThuongHieu", comboBox_BrandName.SelectedValue.ToString());
                        updateCmd.Parameters.AddWithValue("@MaLoai", comboBox_ProductType.SelectedValue.ToString());

                        // Thực hiện câu lệnh UPDATE
                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Chỉnh sửa thành công!");
                btn_Clear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (KiemTraSanPhamCoTrongDonHang(txtBox_ProductID.Text.Trim()))
                    {
                        MessageBox.Show("Đang có sản phẩm tồn tại trong đơn hàng\nTrạng thái sản phẩm sẽ chuyển sang \"NGỪNG KINH DOANH\"");
                        radioButton_StopBusiness.Checked = true;
                        // Tạo câu lệnh SQL UPDATE
                        string updateCommand = @"UPDATE SanPham SET TinhTrang = @TinhTrang WHERE MaSP = @MaSP";
                        //string updateCommand = @"UPDATE SanPham SET SoLuongConLai = @SoLuongConLai, TinhTrang = @TinhTrang WHERE MaSP = @MaSP";

                        using (SqlCommand updateCmd = new SqlCommand(updateCommand, connection))
                        {
                            // Thêm các tham số cho command
                            updateCmd.Parameters.AddWithValue("@MaSP", txtBox_ProductID.Text.Trim());
                            //updateCmd.Parameters.AddWithValue("@SoLuongConLai", int.Parse(txtBox_Quantity.Text.Trim()));

                            // Xử lý tình trạng
                            string tinhTrang;
                            if (radioButton_Stocking.Checked == true)
                                tinhTrang = "Còn Hàng";
                            else if (radioButton_OutOfStock.Checked == true)
                                tinhTrang = "Hết Hàng";
                            else
                                tinhTrang = "Ngừng Kinh Doanh";
                            updateCmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                            // Thực hiện câu lệnh UPDATE
                            updateCmd.ExecuteNonQuery();
                        }
                        btn_Clear_Click(sender, e);
                    }
                    else
                    {
                        try
                        {
                            // Tạo câu lệnh SQL DELETE
                            string updateCommand = @"DELETE SanPham WHERE MaSP = @MaSP";

                            using (SqlCommand deleteCmd = new SqlCommand(updateCommand, connection))
                            {
                                // Thêm các tham số cho command
                                deleteCmd.Parameters.AddWithValue("@MaSP", txtBox_ProductID.Text.Trim());

                                // Thực hiện câu lệnh DELETE
                                deleteCmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Xoá thành công!");
                            btn_Clear_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            else
                return;    
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            fileImageName = "";

            txtBox_ProductID.Enabled = true;
            txtBox_ProductID.Clear();
            txtBox_ProductID.Focus();
            txtBox_ProductName.Clear();

            comboBox_BrandName.SelectedIndex = comboBox_ProductType.SelectedIndex = comboBox_FilterBrandName.SelectedIndex = comboBox_FilterProductType.SelectedIndex = comboBox_PriceFrom.SelectedIndex = comboBox_PriceTo.SelectedIndex = 0;

            txtBox_Price.Clear();
            numericUpDown_PercentPromotion.Value = 0;
            txtBox_Quantity.Clear();

            radioButton_Stocking.Checked = true;
            radioButton_OutOfStock.Checked = radioButton_StopBusiness.Checked = radioButton_FilterStocking.Checked = radioButton_FilterOutOfStock.Checked = radioButton_FilterStopBusiness.Checked = false;

            txtBox_Description.Clear();
            txtBox_Search.Clear();

            radioButton_Stocking.Checked = true;
            txtBox_TotalProduct.Text = TongSanPham();

            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";
            // Cập nhật DataTable và hiển thị trên DataGridView
            Load_ProductInformation(sqlCommand);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai AND SP.TenSP LIKE N'%" + txtBox_Search.Text.Trim()  + "%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (txtBox_Search.Text == string.Empty)
                    return;

                Load_ProductInformation(sqlCommand);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";

            string mathuongHieu = comboBox_FilterBrandName.SelectedValue.ToString();
            if (String.Compare(mathuongHieu, "-1", StringComparison.Ordinal) != 0)
            {
                sqlCommand += " AND SP.MaThuongHieu = '" + mathuongHieu + "'";
            }
            
            string maloaiSP = comboBox_FilterProductType.SelectedValue.ToString();
            if (String.Compare(maloaiSP, "-1", StringComparison.Ordinal) != 0)
            {
                sqlCommand += " AND SP.MaLoai = '" + maloaiSP + "'";
            }
            
            string giaBatDau = comboBox_PriceFrom.SelectedItem?.ToString() == "Trên 35 triệu" ? "-1" : comboBox_PriceFrom.SelectedItem.ToString();
            string giaKetThuc = comboBox_PriceTo.SelectedItem?.ToString() == "Trên 35 triệu" ? "-1" : comboBox_PriceTo.SelectedItem.ToString();
            
            //Giá khởi đầu được chọn
            if (String.Compare(giaBatDau, "Lựa chọn", StringComparison.Ordinal) != 0)
            {
                double giaBD = double.Parse(giaBatDau);
                double giaCaoNhat;

                //Giá kết thúc được chọn
                if (String.Compare(giaKetThuc, "Lựa chọn", StringComparison.Ordinal) != 0)
                {
                    double giaKT = double.Parse(giaKetThuc);
                    //Giá bắt đầu phải nhỏ hơn giá kết thúc
                    if (giaBD >= giaKT)
                    {
                        MessageBox.Show("Giá bắt đầu phải nhỏ hơn giá kết thúc");
                        return;
                    }
                    if (giaKT == -1.0)
                        giaKT = 35000000;
                    sqlCommand += " AND Gia BETWEEN " + giaBD + " AND " + giaKT;
                }
                else
                {
                    if (giaBD == -1.0)
                        giaBD = 35000000;
                    giaCaoNhat = MaxPrice();
                    sqlCommand += " AND Gia BETWEEN " + giaBD + " AND " + giaCaoNhat;
                }
            }

            string tinhTrang;
            if (radioButton_FilterStocking.Checked == true)
                tinhTrang = "Còn hàng";
            else if (radioButton_FilterOutOfStock.Checked == true)
                tinhTrang = "Hết hàng";
            else
                tinhTrang = "Ngừng kinh doanh";

            sqlCommand += " AND TinhTrang = N'" + tinhTrang + "'";

            Load_ProductInformation(sqlCommand);
        }

        private void dataGridView_ProductList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentRowIndex = dataGridView_ProductList.HitTest(e.X, e.Y).RowIndex;
                currentColIndex = dataGridView_ProductList.HitTest(e.X, e.Y).ColumnIndex;

                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Copy", Copy_Click));
                m.MenuItems.Add(new MenuItem("Delete", Delete_Click));

                m.Show(dataGridView_ProductList, new Point(e.X, e.Y));
            }
        }

        private void btn_DefaultFilter_Click(object sender, EventArgs e)
        {
            comboBox_FilterBrandName.SelectedIndex = 0;
            comboBox_FilterProductType.SelectedIndex = 0;
            comboBox_PriceFrom.SelectedIndex = 0;
            comboBox_PriceTo.SelectedIndex = 0;
            radioButton_FilterStocking.Checked = true;

            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";
            Load_ProductInformation(sqlCommand);
        }
    }
}
