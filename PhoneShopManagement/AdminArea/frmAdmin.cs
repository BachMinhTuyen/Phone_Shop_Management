﻿using PhoneShopManagement.AdminArea;
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
    public partial class frmAdmin : Form
    {
        public frmAdmin(string iDNAME)
        {
            this.IDNAME = iDNAME;
            InitializeComponent();
            LoadData();
        }
        private string ConnectSql = Properties.Settings.Default.ConnectionString_Remote;
        private string IDNAME;
        private void LoadThongKe()
        {
            List<TextBox> ListProfile = new List<TextBox>();
            string[] querytext = {"NhanVien where ChucVu=N'Quản lý'", "NhanVien where ChucVu=N'Nhân Viên Bán Hàng'", "SanPham", "KhachHang" };
            ListProfile.Add(txtBox_NumberOfAccount);
            ListProfile.Add(txtBox_NumberOfStaff);
            ListProfile.Add(txtBox_NumberOfProduct);
            ListProfile.Add(txtBox_NumberOfCustomer);
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql))
            {
                sqlclient.Open();
                for (int i = 0; i < 4; i++)
                {
                    string query = string.Format("SELECT COUNT(*) FROM {0}", querytext[i]);
                    using (SqlCommand command = new SqlCommand(query, sqlclient))
                        ListProfile[i].Text = command.ExecuteScalar().ToString();
                }
            }


        }

        void LoadNguoiDung()
        {
            List<TextBox> ListProfile = new List<TextBox>();
            ListProfile.Add(txtBox_UserLogin);
            ListProfile.Add(txtBox_AdminName);
            ListProfile.Add(txtBox_Birthday);
            ListProfile.Add(txtBox_Email);
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql))
            {
                string query = string.Format("SELECT MaNV,TenNV,NgaySinh,Email FROM NhanVien WHERE MaNV ='{0}' ", IDNAME);
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    for (int i = 0; i < 4; i++)
                        ListProfile[i].Text = data.Rows[0][i].ToString();
                }
            }
        }
        void LoadTop5Item()
        {
            using (SqlConnection sqlclient = new SqlConnection(ConnectSql))
            {
                string query = string.Format("SELECT TOP(5) SP.MaSP, SP.TenSP, SP.Gia, CTDH.SoLuong FROM SanPham AS SP, ChiTietDonHang AS CTDH WHERE SP.MaSP = CTDH.MaSP ORDER BY CTDH.SoLuong");
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlclient))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridView_BestSellingProduct.Rows.Clear();
                    foreach (DataRow row in data.Rows) {
                        int rowIndex = dataGridView_BestSellingProduct.Rows.Add();
                        for(int i = 0; i < 4; i++)
                        dataGridView_BestSellingProduct.Rows[rowIndex].Cells[i].Value = row[i];
                    }
                }
            }
        }

        public void LoadData()
        {
            LoadThongKe();
            LoadNguoiDung();
            LoadTop5Item();
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutUs frm = new frmAboutUs();
            frm.ShowDialog();
        }

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserProfile frm = new frmUserProfile(IDNAME);
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc nhắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Đã làm mới", "Thông báo");
        }

        private void tàiKhoảnNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAccount frm = new frmUserAccount();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill(IDNAME);
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenueReport frm = new frmRevenueReport();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }
    }
}
