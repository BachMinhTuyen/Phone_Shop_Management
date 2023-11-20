using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmProductType : Form
    {
        private SqlConnection conn;
        string connStr = @"workstation id = QL_PhoneShop.mssql.somee.com; packet size = 4096; user id = TuyenBach_MSSQL; pwd=TuyenBach_MSSQL2022;data source = QL_PhoneShop.mssql.somee.com; persist security info=False;initial catalog = QL_PhoneShop";
        public frmProductType()
        {
            InitializeComponent();
            conn = new SqlConnection(connStr);
        }

        private void frmProductType_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From LoaiSanPham", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_ProductType.DataSource = dt;
            dataGridView_ProductType.Columns["MaLoai"].HeaderText = "Mã Loại";
            dataGridView_ProductType.Columns["TenLoai"].HeaderText = "Tên Loại";
            conn.Close();

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string insertString;
                insertString = "Insert into LoaiSanPham Values('" + txtBox_ProductTypeID.Text + "',N'" + txtBox_ProductTypeName.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string updateString;
                updateString = "Update LoaiSanPham Set TenLoai = N'" + txtBox_ProductTypeName.Text + "' Where MaLoai = '" + txtBox_ProductTypeID.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, conn);
                int rowselected = cmd.ExecuteNonQuery();

                if (rowselected > 0)
                {
                    foreach (DataGridViewRow row in dataGridView_ProductType.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtBox_ProductTypeID.Text)
                        {
                            row.Cells[1].Value = txtBox_ProductTypeName.Text;
                            break;
                        }
                    }
                }

                MessageBox.Show("Thành công");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string deleteString;
                deleteString = "Delete LoaiSanPham where MaLoai='" + txtBox_ProductTypeID.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                int rowselected = cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_ProductTypeID.Clear();
            txtBox_ProductTypeName.Clear();
        }
        private void RefreshDataGridView()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From LoaiSanPham", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_ProductType.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView_ProductType.Columns[e.ColumnIndex].Name;

                if (columnName == "MaLoai" || columnName == "TenLoai")
                {
                    string maLoai = dataGridView_ProductType.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString();
                    string tenLoai = dataGridView_ProductType.Rows[e.RowIndex].Cells["TenLoai"].Value.ToString();
                    txtBox_ProductTypeID.Text = maLoai;
                    txtBox_ProductTypeName.Text = tenLoai;
                    txtBox_ProductTypeID.Enabled = false;
                }
            }
        }
    }
}
