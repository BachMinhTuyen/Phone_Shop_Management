namespace PhoneShopManagement.AdminArea
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.radioButton_FilterCardPaid = new System.Windows.Forms.RadioButton();
            this.radioButton_FilterCashPaid = new System.Windows.Forms.RadioButton();
            this.lb_FilterPaidMethod = new System.Windows.Forms.Label();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_CreateBill = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_BillDetail = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.txtBox_TotalBill = new System.Windows.Forms.TextBox();
            this.lb_TotalBill = new System.Windows.Forms.Label();
            this.dataGridView_BillList = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNVBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Filter.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Filter
            // 
            this.panel_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Filter.Controls.Add(this.radioButton_FilterCardPaid);
            this.panel_Filter.Controls.Add(this.radioButton_FilterCashPaid);
            this.panel_Filter.Controls.Add(this.lb_FilterPaidMethod);
            this.panel_Filter.Controls.Add(this.btn_DefaultFilter);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Location = new System.Drawing.Point(438, 22);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(352, 131);
            this.panel_Filter.TabIndex = 47;
            // 
            // radioButton_FilterCardPaid
            // 
            this.radioButton_FilterCardPaid.AutoSize = true;
            this.radioButton_FilterCardPaid.Location = new System.Drawing.Point(204, 52);
            this.radioButton_FilterCardPaid.Name = "radioButton_FilterCardPaid";
            this.radioButton_FilterCardPaid.Size = new System.Drawing.Size(129, 22);
            this.radioButton_FilterCardPaid.TabIndex = 41;
            this.radioButton_FilterCardPaid.TabStop = true;
            this.radioButton_FilterCardPaid.Text = "Không tiền mặt";
            this.radioButton_FilterCardPaid.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterCashPaid
            // 
            this.radioButton_FilterCashPaid.AutoSize = true;
            this.radioButton_FilterCashPaid.Location = new System.Drawing.Point(204, 19);
            this.radioButton_FilterCashPaid.Name = "radioButton_FilterCashPaid";
            this.radioButton_FilterCashPaid.Size = new System.Drawing.Size(88, 22);
            this.radioButton_FilterCashPaid.TabIndex = 40;
            this.radioButton_FilterCashPaid.TabStop = true;
            this.radioButton_FilterCashPaid.Text = "Tiền mặt";
            this.radioButton_FilterCashPaid.UseVisualStyleBackColor = true;
            // 
            // lb_FilterPaidMethod
            // 
            this.lb_FilterPaidMethod.AutoSize = true;
            this.lb_FilterPaidMethod.Location = new System.Drawing.Point(18, 21);
            this.lb_FilterPaidMethod.Name = "lb_FilterPaidMethod";
            this.lb_FilterPaidMethod.Size = new System.Drawing.Size(172, 18);
            this.lb_FilterPaidMethod.TabIndex = 39;
            this.lb_FilterPaidMethod.Text = "Phương thức thanh toán:";
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(204, 86);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(89, 28);
            this.btn_DefaultFilter.TabIndex = 38;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            this.btn_DefaultFilter.Click += new System.EventHandler(this.btn_DefaultFilter_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(86, 86);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(89, 28);
            this.btn_Filter.TabIndex = 37;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_CreateBill);
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_BillDetail);
            this.groupBox_Operation.Location = new System.Drawing.Point(46, 22);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(313, 131);
            this.groupBox_Operation.TabIndex = 48;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_CreateBill
            // 
            this.btn_CreateBill.Location = new System.Drawing.Point(21, 34);
            this.btn_CreateBill.Name = "btn_CreateBill";
            this.btn_CreateBill.Size = new System.Drawing.Size(116, 39);
            this.btn_CreateBill.TabIndex = 8;
            this.btn_CreateBill.Text = "Tạo";
            this.btn_CreateBill.UseVisualStyleBackColor = true;
            this.btn_CreateBill.Click += new System.EventHandler(this.btn_CreateBill_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(164, 34);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 39);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(21, 76);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 39);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_BillDetail
            // 
            this.btn_BillDetail.Location = new System.Drawing.Point(164, 76);
            this.btn_BillDetail.Name = "btn_BillDetail";
            this.btn_BillDetail.Size = new System.Drawing.Size(129, 39);
            this.btn_BillDetail.TabIndex = 4;
            this.btn_BillDetail.Text = "Chi tiết hoá đơn";
            this.btn_BillDetail.UseVisualStyleBackColor = true;
            this.btn_BillDetail.Click += new System.EventHandler(this.btn_BillDetail_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(448, 175);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 24);
            this.btn_Search.TabIndex = 51;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(182, 176);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(250, 26);
            this.txtBox_Search.TabIndex = 49;
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(20, 178);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(158, 18);
            this.lb_Search.TabIndex = 50;
            this.lb_Search.Text = "Tìm kiếm mã hoá đơn:";
            // 
            // txtBox_TotalBill
            // 
            this.txtBox_TotalBill.Location = new System.Drawing.Point(767, 176);
            this.txtBox_TotalBill.Name = "txtBox_TotalBill";
            this.txtBox_TotalBill.ReadOnly = true;
            this.txtBox_TotalBill.Size = new System.Drawing.Size(88, 26);
            this.txtBox_TotalBill.TabIndex = 52;
            // 
            // lb_TotalBill
            // 
            this.lb_TotalBill.AutoSize = true;
            this.lb_TotalBill.Location = new System.Drawing.Point(646, 178);
            this.lb_TotalBill.Name = "lb_TotalBill";
            this.lb_TotalBill.Size = new System.Drawing.Size(106, 18);
            this.lb_TotalBill.TabIndex = 53;
            this.lb_TotalBill.Text = "Tổng hoá đơn:";
            // 
            // dataGridView_BillList
            // 
            this.dataGridView_BillList.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_BillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_BillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenKH,
            this.TenNVBH,
            this.Tongtien,
            this.TGMH,
            this.TrangThai});
            this.dataGridView_BillList.Location = new System.Drawing.Point(23, 213);
            this.dataGridView_BillList.Name = "dataGridView_BillList";
            this.dataGridView_BillList.RowHeadersVisible = false;
            this.dataGridView_BillList.RowHeadersWidth = 51;
            this.dataGridView_BillList.RowTemplate.Height = 24;
            this.dataGridView_BillList.Size = new System.Drawing.Size(831, 274);
            this.dataGridView_BillList.TabIndex = 54;
            this.dataGridView_BillList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BillList_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.FillWeight = 50F;
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // TenNVBH
            // 
            this.TenNVBH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNVBH.HeaderText = "Nhân viên bán hàng";
            this.TenNVBH.MinimumWidth = 6;
            this.TenNVBH.Name = "TenNVBH";
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            // 
            // TGMH
            // 
            this.TGMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGMH.HeaderText = "Thời gian mua hàng";
            this.TGMH.MinimumWidth = 6;
            this.TGMH.Name = "TGMH";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.HeaderText = "Phương Thức";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 498);
            this.Controls.Add(this.dataGridView_BillList);
            this.Controls.Add(this.txtBox_TotalBill);
            this.Controls.Add(this.lb_TotalBill);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.panel_Filter);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBill";
            this.Text = "Quản lý hoá đơn";
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.groupBox_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.Button btn_DefaultFilter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_BillDetail;
        private System.Windows.Forms.RadioButton radioButton_FilterCardPaid;
        private System.Windows.Forms.RadioButton radioButton_FilterCashPaid;
        private System.Windows.Forms.Label lb_FilterPaidMethod;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox txtBox_TotalBill;
        private System.Windows.Forms.Label lb_TotalBill;
        private System.Windows.Forms.Button btn_CreateBill;
        private System.Windows.Forms.DataGridView dataGridView_BillList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNVBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}