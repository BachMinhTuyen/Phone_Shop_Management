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
    public partial class frmBrand : Form
    {

        private string ConnectSql = Properties.Settings.Default.ConnectionString_Remote;
        DataSet QL_PhoneShop = new DataSet();
        public frmBrand()
        {
            InitializeComponent();
        }
        void LoadDuLieu()
        {
            string strsel = "select *from ThuongHieu";
            SqlDataAdapter da_ThuongHieu = new SqlDataAdapter(strsel, ConnectSql);
            da_ThuongHieu.Fill(QL_PhoneShop, "ThuongHieu");
            dataGridView_BrandList.DataSource = QL_PhoneShop.Tables["ThuongHieu"];
            DataColumn[] key = new DataColumn[1];
            key[0] = QL_PhoneShop.Tables["ThuongHieu"].Columns[0];
            QL_PhoneShop.Tables["ThuongHieu"].PrimaryKey = key;
        }

        private void dataGridView_BrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_BrandList.Rows[e.RowIndex];
                string makhoa = selectedRow.Cells[0].Value.ToString();
                string tenkhoa = selectedRow.Cells[1].Value.ToString();
                txtBox_BrandID.Text = makhoa;
                txtBox_BrandName.Text = tenkhoa;
            }
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            txtBox_BrandID.Enabled = txtBox_BrandName.Enabled = false;
            btn_Update.Enabled = btn_Delete.Enabled =btn_Clear.Enabled = false;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            txtBox_BrandID.Enabled = txtBox_BrandName.Enabled = true;
            btn_Clear.Enabled = true;
            txtBox_BrandID.Focus();
            txtBox_BrandID.Clear();
            txtBox_BrandName.Clear();
        }

        public SqlDataAdapter da_ThuongHieu { get; set; }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Clear.Enabled = true;
            txtBox_BrandID.Enabled = true;
            txtBox_BrandName.Enabled = false;
        }

        private void LoadData()
        {
            string strsel = "select * from ThuongHieu";
            SqlDataAdapter da_ThuongHieu = new SqlDataAdapter(strsel, ConnectSql);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da_ThuongHieu);
            da_ThuongHieu.Update(QL_PhoneShop, "ThuongHieu");
            MessageBox.Show("Thành công");
            btn_Clear.Enabled = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (txtBox_BrandID.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Mã Thương Hiệu");
                txtBox_BrandID.Focus();
                return;
            }
            if (txtBox_BrandName.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Tên Thương Hiệu");
                txtBox_BrandName.Focus();
                return;
            }
            if (txtBox_BrandID.Enabled == true)
            {
                DataRow insert_New = QL_PhoneShop.Tables["ThuongHieu"].NewRow();
                insert_New["MaThuongHieu"] = txtBox_BrandID.Text;
                insert_New["TenThuongHieu"] =txtBox_BrandName.Text;
                QL_PhoneShop.Tables["ThuongHieu"].Rows.Add(insert_New);
            }
            else
            {
                DataRow update_New = QL_PhoneShop.Tables["ThuongHieu"].Rows.Find(txtBox_BrandID.Text);
                if (update_New != null)
                {
                    update_New["TenThuongHieu"] = txtBox_BrandName.Text;
                }
            }
            LoadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                DataTable dt_ThuongHieu = new DataTable();
                SqlDataAdapter da_ThuongHieu = new SqlDataAdapter("select * from ThuongHieu where MaThuongHieu='" + txtBox_BrandID.Text + "'", ConnectSql);
                da_ThuongHieu.Fill(dt_ThuongHieu);
                if (dt_ThuongHieu.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu đang sử dụng không thể xóa");
                    return;
                }
                DataRow upd_New = QL_PhoneShop.Tables["ThuongHieu"].Rows.Find(txtBox_BrandID.Text);
                if (upd_New != null)
                {
                    upd_New.Delete();
                }
                LoadData();
            }
        }

    }
}
