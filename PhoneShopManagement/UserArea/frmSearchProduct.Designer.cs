namespace PhoneShopManagement.UserArea
{
    partial class frmSearchProduct
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.comboBox_FilterProductType = new System.Windows.Forms.ComboBox();
            this.lb_FilterProductType = new System.Windows.Forms.Label();
            this.comboBox_FilterBrandName = new System.Windows.Forms.ComboBox();
            this.lb_FilterBrandName = new System.Windows.Forms.Label();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.radioButton_FilterOutOfStock = new System.Windows.Forms.RadioButton();
            this.radioButton_FilterStocking = new System.Windows.Forms.RadioButton();
            this.radioButton_FilterStopBusiness = new System.Windows.Forms.RadioButton();
            this.comboBox_PriceTo = new System.Windows.Forms.ComboBox();
            this.comboBox_PriceFrom = new System.Windows.Forms.ComboBox();
            this.lb_PriceTo = new System.Windows.Forms.Label();
            this.lb_PriceFrom = new System.Windows.Forms.Label();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.dataGridView_ProductList = new System.Windows.Forms.DataGridView();
            this.btn_CopyProductName = new System.Windows.Forms.Button();
            this.panel_Filter.SuspendLayout();
            this.groupBox_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(494, 203);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 29);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(206, 207);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(274, 29);
            this.txtBox_Search.TabIndex = 9;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(28, 209);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(203, 22);
            this.lb_Search.TabIndex = 8;
            this.lb_Search.Text = "Tìm kiếm tên sản phẩm:";
            // 
            // panel_Filter
            // 
            this.panel_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Filter.Controls.Add(this.comboBox_FilterProductType);
            this.panel_Filter.Controls.Add(this.lb_FilterProductType);
            this.panel_Filter.Controls.Add(this.comboBox_FilterBrandName);
            this.panel_Filter.Controls.Add(this.lb_FilterBrandName);
            this.panel_Filter.Controls.Add(this.groupBox_Status);
            this.panel_Filter.Controls.Add(this.comboBox_PriceTo);
            this.panel_Filter.Controls.Add(this.comboBox_PriceFrom);
            this.panel_Filter.Controls.Add(this.lb_PriceTo);
            this.panel_Filter.Controls.Add(this.lb_PriceFrom);
            this.panel_Filter.Controls.Add(this.btn_DefaultFilter);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Location = new System.Drawing.Point(123, 12);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(816, 170);
            this.panel_Filter.TabIndex = 6;
            // 
            // comboBox_FilterProductType
            // 
            this.comboBox_FilterProductType.FormattingEnabled = true;
            this.comboBox_FilterProductType.Location = new System.Drawing.Point(180, 47);
            this.comboBox_FilterProductType.Name = "comboBox_FilterProductType";
            this.comboBox_FilterProductType.Size = new System.Drawing.Size(201, 30);
            this.comboBox_FilterProductType.TabIndex = 32;
            // 
            // lb_FilterProductType
            // 
            this.lb_FilterProductType.AutoSize = true;
            this.lb_FilterProductType.Location = new System.Drawing.Point(53, 50);
            this.lb_FilterProductType.Name = "lb_FilterProductType";
            this.lb_FilterProductType.Size = new System.Drawing.Size(131, 22);
            this.lb_FilterProductType.TabIndex = 31;
            this.lb_FilterProductType.Text = "Loại sản phẩm:";
            // 
            // comboBox_FilterBrandName
            // 
            this.comboBox_FilterBrandName.FormattingEnabled = true;
            this.comboBox_FilterBrandName.Location = new System.Drawing.Point(180, 14);
            this.comboBox_FilterBrandName.Name = "comboBox_FilterBrandName";
            this.comboBox_FilterBrandName.Size = new System.Drawing.Size(201, 30);
            this.comboBox_FilterBrandName.TabIndex = 30;
     
            // 
            // lb_FilterBrandName
            // 
            this.lb_FilterBrandName.AutoSize = true;
            this.lb_FilterBrandName.Location = new System.Drawing.Point(53, 17);
            this.lb_FilterBrandName.Name = "lb_FilterBrandName";
            this.lb_FilterBrandName.Size = new System.Drawing.Size(117, 22);
            this.lb_FilterBrandName.TabIndex = 29;
            this.lb_FilterBrandName.Text = "Thương hiệu:";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.radioButton_FilterOutOfStock);
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStocking);
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStopBusiness);
            this.groupBox_Status.Location = new System.Drawing.Point(426, 21);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(178, 119);
            this.groupBox_Status.TabIndex = 28;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Tình trạng sản phẩm";
            // 
            // radioButton_FilterOutOfStock
            // 
            this.radioButton_FilterOutOfStock.AutoSize = true;
            this.radioButton_FilterOutOfStock.Location = new System.Drawing.Point(27, 57);
            this.radioButton_FilterOutOfStock.Name = "radioButton_FilterOutOfStock";
            this.radioButton_FilterOutOfStock.Size = new System.Drawing.Size(107, 26);
            this.radioButton_FilterOutOfStock.TabIndex = 28;
            this.radioButton_FilterOutOfStock.TabStop = true;
            this.radioButton_FilterOutOfStock.Text = "Hết hàng";
            this.radioButton_FilterOutOfStock.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterStocking
            // 
            this.radioButton_FilterStocking.AutoSize = true;
            this.radioButton_FilterStocking.Location = new System.Drawing.Point(27, 30);
            this.radioButton_FilterStocking.Name = "radioButton_FilterStocking";
            this.radioButton_FilterStocking.Size = new System.Drawing.Size(111, 26);
            this.radioButton_FilterStocking.TabIndex = 27;
            this.radioButton_FilterStocking.TabStop = true;
            this.radioButton_FilterStocking.Text = "Còn hàng";
            this.radioButton_FilterStocking.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterStopBusiness
            // 
            this.radioButton_FilterStopBusiness.AutoSize = true;
            this.radioButton_FilterStopBusiness.Location = new System.Drawing.Point(27, 80);
            this.radioButton_FilterStopBusiness.Name = "radioButton_FilterStopBusiness";
            this.radioButton_FilterStopBusiness.Size = new System.Drawing.Size(182, 26);
            this.radioButton_FilterStopBusiness.TabIndex = 26;
            this.radioButton_FilterStopBusiness.TabStop = true;
            this.radioButton_FilterStopBusiness.Text = "Ngừng kinh doanh";
            this.radioButton_FilterStopBusiness.UseVisualStyleBackColor = true;
            // 
            // comboBox_PriceTo
            // 
            this.comboBox_PriceTo.FormattingEnabled = true;
            this.comboBox_PriceTo.Items.AddRange(new object[] {
            "19000000",
            "33990000",
            "40000000"});
            this.comboBox_PriceTo.Location = new System.Drawing.Point(180, 119);
            this.comboBox_PriceTo.Name = "comboBox_PriceTo";
            this.comboBox_PriceTo.Size = new System.Drawing.Size(201, 30);
            this.comboBox_PriceTo.TabIndex = 25;
            // 
            // comboBox_PriceFrom
            // 
            this.comboBox_PriceFrom.FormattingEnabled = true;
            this.comboBox_PriceFrom.Items.AddRange(new object[] {
            "100000",
            "500000",
            "1000000"});
            this.comboBox_PriceFrom.Location = new System.Drawing.Point(180, 84);
            this.comboBox_PriceFrom.Name = "comboBox_PriceFrom";
            this.comboBox_PriceFrom.Size = new System.Drawing.Size(201, 30);
            this.comboBox_PriceFrom.TabIndex = 24;
            // 
            // lb_PriceTo
            // 
            this.lb_PriceTo.AutoSize = true;
            this.lb_PriceTo.Location = new System.Drawing.Point(53, 122);
            this.lb_PriceTo.Name = "lb_PriceTo";
            this.lb_PriceTo.Size = new System.Drawing.Size(48, 22);
            this.lb_PriceTo.TabIndex = 23;
            this.lb_PriceTo.Text = "Đến:";
            // 
            // lb_PriceFrom
            // 
            this.lb_PriceFrom.AutoSize = true;
            this.lb_PriceFrom.Location = new System.Drawing.Point(53, 87);
            this.lb_PriceFrom.Name = "lb_PriceFrom";
            this.lb_PriceFrom.Size = new System.Drawing.Size(64, 22);
            this.lb_PriceFrom.TabIndex = 10;
            this.lb_PriceFrom.Text = "Giá từ:";
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(670, 87);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(89, 44);
            this.btn_DefaultFilter.TabIndex = 9;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            this.btn_DefaultFilter.Click += new System.EventHandler(this.btn_DefaultFilter_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(670, 29);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(89, 44);
            this.btn_Filter.TabIndex = 8;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // dataGridView_ProductList
            // 
            this.dataGridView_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductList.Location = new System.Drawing.Point(18, 248);
            this.dataGridView_ProductList.Name = "dataGridView_ProductList";
            this.dataGridView_ProductList.RowHeadersWidth = 51;
            this.dataGridView_ProductList.RowTemplate.Height = 24;
            this.dataGridView_ProductList.Size = new System.Drawing.Size(1046, 295);
            this.dataGridView_ProductList.TabIndex = 10;
            // 
            // btn_CopyProductName
            // 
            this.btn_CopyProductName.Location = new System.Drawing.Point(839, 203);
            this.btn_CopyProductName.Name = "btn_CopyProductName";
            this.btn_CopyProductName.Size = new System.Drawing.Size(225, 29);
            this.btn_CopyProductName.TabIndex = 11;
            this.btn_CopyProductName.Text = "Sao chép tên sản phẩm";
            this.btn_CopyProductName.UseVisualStyleBackColor = true;
            this.btn_CopyProductName.Click += new System.EventHandler(this.btn_CopyProductName_Click);
            // 
            // frmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 553);
            this.Controls.Add(this.btn_CopyProductName);
            this.Controls.Add(this.dataGridView_ProductList);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.panel_Filter);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSearchProduct";
            this.Text = "Tra cứu sản phẩm";
            this.Load += new System.EventHandler(this.frmSearchProduct_Load);
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.ComboBox comboBox_FilterProductType;
        private System.Windows.Forms.Label lb_FilterProductType;
        private System.Windows.Forms.ComboBox comboBox_FilterBrandName;
        private System.Windows.Forms.Label lb_FilterBrandName;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.RadioButton radioButton_FilterStocking;
        private System.Windows.Forms.RadioButton radioButton_FilterStopBusiness;
        private System.Windows.Forms.ComboBox comboBox_PriceTo;
        private System.Windows.Forms.ComboBox comboBox_PriceFrom;
        private System.Windows.Forms.Label lb_PriceTo;
        private System.Windows.Forms.Label lb_PriceFrom;
        private System.Windows.Forms.Button btn_DefaultFilter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DataGridView dataGridView_ProductList;
        private System.Windows.Forms.Button btn_CopyProductName;
        private System.Windows.Forms.RadioButton radioButton_FilterOutOfStock;
    }
}