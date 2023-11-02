namespace PhoneShopManagement.AdminArea
{
    partial class frmRevenueReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StatisticsByTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_StatisticalBy = new System.Windows.Forms.Label();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.radioButton_Year = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Statistical = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Statistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Statistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Statistics.Legends.Add(legend1);
            this.chart_Statistics.Location = new System.Drawing.Point(387, 29);
            this.chart_Statistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_Statistics.Name = "chart_Statistics";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart_Statistics.Series.Add(series1);
            this.chart_Statistics.Size = new System.Drawing.Size(693, 434);
            this.chart_Statistics.TabIndex = 0;
            this.chart_Statistics.Text = "chart_Statistics";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatisticsByTime,
            this.Total});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 138);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 325);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StatisticsByTime
            // 
            this.StatisticsByTime.Text = "Tháng";
            this.StatisticsByTime.Width = 101;
            // 
            // Total
            // 
            this.Total.Text = "Doanh thu";
            this.Total.Width = 175;
            // 
            // lb_StatisticalBy
            // 
            this.lb_StatisticalBy.AutoSize = true;
            this.lb_StatisticalBy.Location = new System.Drawing.Point(18, 21);
            this.lb_StatisticalBy.Name = "lb_StatisticalBy";
            this.lb_StatisticalBy.Size = new System.Drawing.Size(116, 21);
            this.lb_StatisticalBy.TabIndex = 2;
            this.lb_StatisticalBy.Text = "Thống kê theo";
            // 
            // radioButton_Month
            // 
            this.radioButton_Month.AutoSize = true;
            this.radioButton_Month.Location = new System.Drawing.Point(142, 19);
            this.radioButton_Month.Name = "radioButton_Month";
            this.radioButton_Month.Size = new System.Drawing.Size(77, 25);
            this.radioButton_Month.TabIndex = 3;
            this.radioButton_Month.TabStop = true;
            this.radioButton_Month.Text = "Tháng";
            this.radioButton_Month.UseVisualStyleBackColor = true;
            // 
            // radioButton_Year
            // 
            this.radioButton_Year.AutoSize = true;
            this.radioButton_Year.Location = new System.Drawing.Point(235, 19);
            this.radioButton_Year.Name = "radioButton_Year";
            this.radioButton_Year.Size = new System.Drawing.Size(65, 25);
            this.radioButton_Year.TabIndex = 4;
            this.radioButton_Year.TabStop = true;
            this.radioButton_Year.Text = "Năm";
            this.radioButton_Year.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Year);
            this.panel1.Controls.Add(this.lb_StatisticalBy);
            this.panel1.Controls.Add(this.radioButton_Month);
            this.panel1.Location = new System.Drawing.Point(23, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 61);
            this.panel1.TabIndex = 5;
            // 
            // btn_Statistical
            // 
            this.btn_Statistical.Location = new System.Drawing.Point(112, 96);
            this.btn_Statistical.Name = "btn_Statistical";
            this.btn_Statistical.Size = new System.Drawing.Size(130, 35);
            this.btn_Statistical.TabIndex = 6;
            this.btn_Statistical.Text = "Thống kê";
            this.btn_Statistical.UseVisualStyleBackColor = true;
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 502);
            this.Controls.Add(this.btn_Statistical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chart_Statistics);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRevenueReport";
            this.Text = "Báo cáo doanh thu bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Statistics;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StatisticsByTime;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lb_StatisticalBy;
        private System.Windows.Forms.RadioButton radioButton_Month;
        private System.Windows.Forms.RadioButton radioButton_Year;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Statistical;
    }
}