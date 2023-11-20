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
            //Tải thông tin sản phẩm
            string sqlCommand = "SELECT MaSP, TenSP, Gia, MoTa, SoLuongConLai, HinhAnh, KhuyenMai,TinhTrang,MaThuongHieu,MaLoai FROM SanPham";
            
            Load_Product(sqlCommand);
            Load_ComboBox();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlCommand = "SELECT MaSP, TenSP, Gia, MoTa, SoLuongConLai, HinhAnh, KhuyenMai,TinhTrang,MaThuongHieu,MaLoai FROM SanPham WHERE TenSP LIKE N'%" + txtBox_Search.Text + "%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (txtBox_Search.Text == string.Empty)
                    return;

                Load_Product(sqlCommand);
            }
        }
        
        void Load_ComboBox()
        {
            DataSet ds = new DataSet();
            string strselect = "Select * from ThuongHieu ";
            SqlDataAdapter da = new SqlDataAdapter(strselect, connectionString);
            da.Fill(ds, "ThuongHieu");
            comboBox_FilterBrandName.DataSource = ds.Tables[0];
            comboBox_FilterBrandName.DisplayMember = "TenThuongHieu";
            comboBox_FilterBrandName.ValueMember = "MaThuongHieu";
            comboBox_FilterBrandName.SelectedIndex = -1;

            string queryLoaiSanPham = "SELECT * FROM LoaiSanPham";
            SqlDataAdapter da1 = new SqlDataAdapter(queryLoaiSanPham, connectionString);
            da1.Fill(ds, "LoaiSanPham");
            comboBox_FilterProductType.DataSource = ds.Tables["LoaiSanPham"];
            comboBox_FilterProductType.DisplayMember = "TenLoai";
            comboBox_FilterProductType.ValueMember = "MaLoai";
            comboBox_FilterProductType.SelectedIndex = -1;

        }
        private void btn_Filter_Click(object sender, EventArgs e)
        {

            string sqlCommand = "SELECT MaSP, TenSP, Gia, MoTa, SoLuongConLai, HinhAnh, KhuyenMai, TinhTrang, MaThuongHieu, MaLoai FROM SanPham WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (comboBox_FilterBrandName.SelectedItem != null)
            {
                string thuongHieu = comboBox_FilterBrandName.SelectedValue.ToString();
                sqlCommand += " AND MaThuongHieu = '" + thuongHieu + "'";
            }
            //// Lọc theo loại sản phẩm
            if (comboBox_FilterProductType.SelectedItem != null)
            {
                string maloai = comboBox_FilterProductType.SelectedValue.ToString();
                sqlCommand += " AND MaLoai = '" + maloai + "'";
            }

            if (comboBox_PriceFrom.SelectedItem != null && comboBox_PriceTo.SelectedItem != null)
            {
                int giaTu = Convert.ToInt32(comboBox_PriceFrom.SelectedItem);
                int giaDen = Convert.ToInt32(comboBox_PriceTo.SelectedItem);
                sqlCommand += " AND Gia >= @giaTu AND Gia <= @giaDen";
                parameters.Add(new SqlParameter("@giaTu", giaTu));
                parameters.Add(new SqlParameter("@giaDen", giaDen));
            }

            // Lọc theo tình trạng sản phẩm
            string tinhTrang = GetSelectedTinhTrang();
            if (!string.IsNullOrEmpty(tinhTrang))
            {
                sqlCommand += " AND TinhTrang = @tinhTrang";
                parameters.Add(new SqlParameter("@tinhTrang", tinhTrang));
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.Parameters.AddRange(parameters.ToArray());

                // Open the connection
                connection.Open();

                // Execute the query and retrieve the results
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "SanPham");

                // Close the connection
                connection.Close();

                // Bind the results to the DataGridView
                dataGridView_ProductList.DataSource = dataSet.Tables["SanPham"];
            }
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
