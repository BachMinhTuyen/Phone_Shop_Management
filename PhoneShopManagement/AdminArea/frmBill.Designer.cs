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
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.radioButton_FilterCardPaid = new System.Windows.Forms.RadioButton();
            this.radioButton_FilterCashPaid = new System.Windows.Forms.RadioButton();
            this.lb_FilterPaidMethod = new System.Windows.Forms.Label();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.comboBox_ColumnStaff = new System.Windows.Forms.ComboBox();
            this.lb_Sort = new System.Windows.Forms.Label();
            this.lb_By = new System.Windows.Forms.Label();
            this.comboBox_SortMethod = new System.Windows.Forms.ComboBox();
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
            this.panel_Filter.Controls.Add(this.comboBox_ColumnStaff);
            this.panel_Filter.Controls.Add(this.lb_Sort);
            this.panel_Filter.Controls.Add(this.lb_By);
            this.panel_Filter.Controls.Add(this.comboBox_SortMethod);
            this.panel_Filter.Location = new System.Drawing.Point(461, 12);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(441, 177);
            this.panel_Filter.TabIndex = 47;
            // 
            // radioButton_FilterCardPaid
            // 
            this.radioButton_FilterCardPaid.AutoSize = true;
            this.radioButton_FilterCardPaid.Location = new System.Drawing.Point(230, 94);
            this.radioButton_FilterCardPaid.Name = "radioButton_FilterCardPaid";
            this.radioButton_FilterCardPaid.Size = new System.Drawing.Size(144, 25);
            this.radioButton_FilterCardPaid.TabIndex = 41;
            this.radioButton_FilterCardPaid.TabStop = true;
            this.radioButton_FilterCardPaid.Text = "Không tiền mặt";
            this.radioButton_FilterCardPaid.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterCashPaid
            // 
            this.radioButton_FilterCashPaid.AutoSize = true;
            this.radioButton_FilterCashPaid.Location = new System.Drawing.Point(230, 55);
            this.radioButton_FilterCashPaid.Name = "radioButton_FilterCashPaid";
            this.radioButton_FilterCashPaid.Size = new System.Drawing.Size(97, 25);
            this.radioButton_FilterCashPaid.TabIndex = 40;
            this.radioButton_FilterCashPaid.TabStop = true;
            this.radioButton_FilterCashPaid.Text = "Tiền mặt";
            this.radioButton_FilterCashPaid.UseVisualStyleBackColor = true;
            // 
            // lb_FilterPaidMethod
            // 
            this.lb_FilterPaidMethod.AutoSize = true;
            this.lb_FilterPaidMethod.Location = new System.Drawing.Point(20, 57);
            this.lb_FilterPaidMethod.Name = "lb_FilterPaidMethod";
            this.lb_FilterPaidMethod.Size = new System.Drawing.Size(194, 21);
            this.lb_FilterPaidMethod.TabIndex = 39;
            this.lb_FilterPaidMethod.Text = "Phương thức thanh toán:";
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(230, 133);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(100, 33);
            this.btn_DefaultFilter.TabIndex = 38;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(97, 133);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 33);
            this.btn_Filter.TabIndex = 37;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // comboBox_ColumnStaff
            // 
            this.comboBox_ColumnStaff.FormattingEnabled = true;
            this.comboBox_ColumnStaff.Location = new System.Drawing.Point(285, 14);
            this.comboBox_ColumnStaff.Name = "comboBox_ColumnStaff";
            this.comboBox_ColumnStaff.Size = new System.Drawing.Size(129, 29);
            this.comboBox_ColumnStaff.TabIndex = 36;
            // 
            // lb_Sort
            // 
            this.lb_Sort.AutoSize = true;
            this.lb_Sort.Location = new System.Drawing.Point(20, 17);
            this.lb_Sort.Name = "lb_Sort";
            this.lb_Sort.Size = new System.Drawing.Size(74, 21);
            this.lb_Sort.TabIndex = 33;
            this.lb_Sort.Text = "Sắp xếp:";
            // 
            // lb_By
            // 
            this.lb_By.AutoSize = true;
            this.lb_By.Location = new System.Drawing.Point(226, 17);
            this.lb_By.Name = "lb_By";
            this.lb_By.Size = new System.Drawing.Size(43, 21);
            this.lb_By.TabIndex = 35;
            this.lb_By.Text = "theo";
            // 
            // comboBox_SortMethod
            // 
            this.comboBox_SortMethod.FormattingEnabled = true;
            this.comboBox_SortMethod.Location = new System.Drawing.Point(100, 14);
            this.comboBox_SortMethod.Name = "comboBox_SortMethod";
            this.comboBox_SortMethod.Size = new System.Drawing.Size(109, 29);
            this.comboBox_SortMethod.TabIndex = 34;
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_CreateBill);
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_BillDetail);
            this.groupBox_Operation.Location = new System.Drawing.Point(52, 26);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(352, 153);
            this.groupBox_Operation.TabIndex = 48;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_CreateBill
            // 
            this.btn_CreateBill.Location = new System.Drawing.Point(24, 40);
            this.btn_CreateBill.Name = "btn_CreateBill";
            this.btn_CreateBill.Size = new System.Drawing.Size(130, 45);
            this.btn_CreateBill.TabIndex = 8;
            this.btn_CreateBill.Text = "Tạo";
            this.btn_CreateBill.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(184, 40);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(145, 45);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(24, 89);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 45);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_BillDetail
            // 
            this.btn_BillDetail.Location = new System.Drawing.Point(184, 89);
            this.btn_BillDetail.Name = "btn_BillDetail";
            this.btn_BillDetail.Size = new System.Drawing.Size(145, 45);
            this.btn_BillDetail.TabIndex = 4;
            this.btn_BillDetail.Text = "Chi tiết hoá đơn";
            this.btn_BillDetail.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(504, 204);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 28);
            this.btn_Search.TabIndex = 51;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(205, 205);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(281, 28);
            this.txtBox_Search.TabIndex = 49;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(22, 208);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(177, 21);
            this.lb_Search.TabIndex = 50;
            this.lb_Search.Text = "Tìm kiếm mã hoá đơn:";
            // 
            // txtBox_TotalBill
            // 
            this.txtBox_TotalBill.Location = new System.Drawing.Point(863, 205);
            this.txtBox_TotalBill.Name = "txtBox_TotalBill";
            this.txtBox_TotalBill.ReadOnly = true;
            this.txtBox_TotalBill.Size = new System.Drawing.Size(98, 28);
            this.txtBox_TotalBill.TabIndex = 52;
            // 
            // lb_TotalBill
            // 
            this.lb_TotalBill.AutoSize = true;
            this.lb_TotalBill.Location = new System.Drawing.Point(727, 208);
            this.lb_TotalBill.Name = "lb_TotalBill";
            this.lb_TotalBill.Size = new System.Drawing.Size(118, 21);
            this.lb_TotalBill.TabIndex = 53;
            this.lb_TotalBill.Text = "Tổng hoá đơn:";
            // 
            // dataGridView_BillList
            // 
            this.dataGridView_BillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillList.Location = new System.Drawing.Point(26, 249);
            this.dataGridView_BillList.Name = "dataGridView_BillList";
            this.dataGridView_BillList.RowHeadersWidth = 51;
            this.dataGridView_BillList.RowTemplate.Height = 24;
            this.dataGridView_BillList.Size = new System.Drawing.Size(935, 320);
            this.dataGridView_BillList.TabIndex = 54;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(980, 581);
            this.Controls.Add(this.dataGridView_BillList);
            this.Controls.Add(this.txtBox_TotalBill);
            this.Controls.Add(this.lb_TotalBill);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.panel_Filter);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ComboBox comboBox_ColumnStaff;
        private System.Windows.Forms.Label lb_Sort;
        private System.Windows.Forms.Label lb_By;
        private System.Windows.Forms.ComboBox comboBox_SortMethod;
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
    }
}