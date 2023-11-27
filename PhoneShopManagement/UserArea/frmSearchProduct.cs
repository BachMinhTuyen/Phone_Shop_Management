using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneShopManagement.UserArea
{
    public partial class frmSearchProduct : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        DataSet ds_QLPhoneShop = new DataSet();
        SqlDataAdapter da_SrchProduct;
        public frmSearchProduct()
        {

            InitializeComponent();
            dataGridView_ProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        //Hàm tải thông tin sản phẩm
        private void Load_Product(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_SrchProduct = new SqlDataAdapter(cmd);

                    // Làm sạch DataSet
                    ds_QLPhoneShop.Clear();

                    // Đổ dữ liệu vào DataSet
                    da_SrchProduct.Fill(ds_QLPhoneShop, "SanPham");
                    dataGridView_ProductList.DataSource = ds_QLPhoneShop.Tables["SanPham"];

                    DataColumn[] key = new DataColumn[1];
                    key[0] = ds_QLPhoneShop.Tables["SanPham"].Columns[0];
                    ds_QLPhoneShop.Tables["SanPham"].PrimaryKey = key;
                }
            }
        }

        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
            Load_Filter();

            //Tải thông tin sản phẩm
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai";
            Load_Product(sqlCommand);
            

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT SP.MASP, TenSP, TenThuongHieu, TenLoai, KhuyenMai, Gia, HinhAnh, SoLuongConLai, TinhTrang, MoTa FROM SanPham SP, ThuongHieu TH, LoaiSanPham L WHERE SP.MaThuongHieu = TH.MaThuongHieu AND SP.MaLoai = L.MaLoai AND TenSP LIKE N'%" + txtBox_Search.Text + "%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (txtBox_Search.Text == string.Empty)
                    return;

                Load_Product(sqlCommand);
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
        void Load_ComboBox()
        {
            Load_BrandList();
            Load_ProductType();
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
                    if (giaKT == -1.0)
                        giaKT = MaxPrice();
                    //Giá bắt đầu phải nhỏ hơn giá kết thúc
                    if (giaBD >= giaKT)
                    {
                        MessageBox.Show("Giá bắt đầu phải nhỏ hơn giá kết thúc");
                        return;
                    }
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

            Load_Product(sqlCommand);
        }

        private string GetSelectedTinhTrang()
        {
            if (radioButton_FilterStocking.Checked)
                return "Còn hàng";
            else if (radioButton_FilterOutOfStock.Checked)
                return "Hết hàng";
            else if (radioButton_FilterStopBusiness.Checked)
                return "Ngừng kinh doanh";
            else
                return string.Empty;
        }

        private void btn_CopyProductName_Click(object sender, EventArgs e)
        {
            if (dataGridView_ProductList.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột "tenSP" từ dòng đầu tiên được chọn
                string tenSPValue = dataGridView_ProductList.SelectedRows[0].Cells["tenSP"].Value.ToString();

                // Thực hiện việc copy giá trị tenSPValue vào Clipboard
                Clipboard.SetText(tenSPValue);

                // Thông báo hoặc xử lý tiếp theo nếu cần
                MessageBox.Show("Nội dung đã được sao chép: " + tenSPValue);
            }
            else
            {
                // Thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một dòng trước khi sao chép.");
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
            Load_Product(sqlCommand);


        }
    }
}
