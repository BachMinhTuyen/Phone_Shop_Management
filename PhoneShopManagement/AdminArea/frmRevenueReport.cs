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
using System.Windows.Forms.DataVisualization.Charting;

namespace PhoneShopManagement.AdminArea
{
    public partial class frmRevenueReport : Form
    {
        private string connectionString = Properties.Settings.Default.ConnectionString_Remote;
        DataSet ds_PhoneShop = new DataSet();
        SqlDataAdapter da_Bill;
        public frmRevenueReport()
        {
            InitializeComponent();
        }
        #region Hàm tự định nghĩa

        private void Load_BillInfo(string sqlCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlCommand, connection))
                {
                    // Khởi tạo Sql Data Adapter
                    da_Bill = new SqlDataAdapter(cmd);

                    // Xoá dữ liệu Data Set và Data Table
                    ds_PhoneShop.Clear();

                    DataSet dataSet = new DataSet();

                    // Đổ dữ liệu vào Data Set
                    da_Bill.Fill(dataSet, "DonHang");

                    dataGridView_RevenueReport.DataSource = dataSet.Tables["DonHang"];

                    ds_PhoneShop = dataSet;
                }
            }
        }
        private void Load_DataChart()
        {
            chart_Statistics.DataSource = ds_PhoneShop.Tables["DonHang"];
            
            chart_Statistics.Series["Doanh Thu"].XValueMember = ds_PhoneShop.Tables["DonHang"].Columns[0].ToString();
            chart_Statistics.Series["Doanh Thu"].YValueMembers = ds_PhoneShop.Tables["DonHang"].Columns[1].ToString();

            chart_Statistics.Series["Doanh Thu"].XValueType = ChartValueType.Int32;
            chart_Statistics.Series["Doanh Thu"].YValueType = ChartValueType.Double;

            chart_Statistics.Series["Doanh Thu"].Color = Color.Blue;

            chart_Statistics.ChartAreas[0].AxisY.LabelStyle.Format = "###,###";
        }
        #endregion
        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            radioButton_Month.Checked = true;
         
            string sqlCommand = "SELECT MONTH(ThoiGianMuaHang)  AS 'Thang', SUM(TongTien) AS N'DoanhThu' FROM DonHang GROUP BY MONTH(ThoiGianMuaHang)";
            Load_BillInfo(sqlCommand);

            chart_Statistics.Titles.Add("Báo cáo doanh thu");
            Load_DataChart();
        }

        private void btn_Statistical_Click(object sender, EventArgs e)
        {
            string sqlCommand;

            if (radioButton_Month.Checked == true)
                sqlCommand = "SELECT MONTH(ThoiGianMuaHang) AS 'Thang', SUM(TongTien) AS N'DoanhThu' FROM DonHang GROUP BY MONTH(ThoiGianMuaHang)";
            else
                sqlCommand = "SELECT YEAR(ThoiGianMuaHang) AS 'Nam', SUM(TongTien) AS N'DoanhThu' FROM DonHang GROUP BY YEAR(ThoiGianMuaHang)";

            Load_BillInfo(sqlCommand);
            Load_DataChart();
        }
    }
}
