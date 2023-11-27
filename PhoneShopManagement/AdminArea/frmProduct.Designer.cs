namespace PhoneShopManagement.AdminArea
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lb_Search = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.comboBox_BrandName = new System.Windows.Forms.ComboBox();
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.radioButton_OutOfStock = new System.Windows.Forms.RadioButton();
            this.radioButton_Stocking = new System.Windows.Forms.RadioButton();
            this.radioButton_StopBusiness = new System.Windows.Forms.RadioButton();
            this.lb_Status = new System.Windows.Forms.Label();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_ProductName = new System.Windows.Forms.TextBox();
            this.txtBox_ProductID = new System.Windows.Forms.TextBox();
            this.txtBox_Description = new System.Windows.Forms.TextBox();
            this.lb_Description = new System.Windows.Forms.Label();
            this.lb_UploadImage = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.numericUpDown_PercentPromotion = new System.Windows.Forms.NumericUpDown();
            this.lb_Promotion = new System.Windows.Forms.Label();
            this.lb_ProductType = new System.Windows.Forms.Label();
            this.lb_BrandName = new System.Windows.Forms.Label();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_TotalProduct = new System.Windows.Forms.Label();
            this.txtBox_TotalProduct = new System.Windows.Forms.TextBox();
            this.dataGridView_ProductList = new System.Windows.Forms.DataGridView();
            this.panel_Filter.SuspendLayout();
            this.groupBox_Status.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PercentPromotion)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductList)).BeginInit();
            this.SuspendLayout();
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
            this.panel_Filter.Location = new System.Drawing.Point(585, 43);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(806, 170);
            this.panel_Filter.TabIndex = 0;
            // 
            // comboBox_FilterProductType
            // 
            this.comboBox_FilterProductType.FormattingEnabled = true;
            this.comboBox_FilterProductType.Location = new System.Drawing.Point(177, 50);
            this.comboBox_FilterProductType.Name = "comboBox_FilterProductType";
            this.comboBox_FilterProductType.Size = new System.Drawing.Size(173, 26);
            this.comboBox_FilterProductType.TabIndex = 32;
            // 
            // lb_FilterProductType
            // 
            this.lb_FilterProductType.AutoSize = true;
            this.lb_FilterProductType.Location = new System.Drawing.Point(50, 53);
            this.lb_FilterProductType.Name = "lb_FilterProductType";
            this.lb_FilterProductType.Size = new System.Drawing.Size(108, 18);
            this.lb_FilterProductType.TabIndex = 31;
            this.lb_FilterProductType.Text = "Loại sản phẩm:";
            // 
            // comboBox_FilterBrandName
            // 
            this.comboBox_FilterBrandName.FormattingEnabled = true;
            this.comboBox_FilterBrandName.Location = new System.Drawing.Point(177, 17);
            this.comboBox_FilterBrandName.Name = "comboBox_FilterBrandName";
            this.comboBox_FilterBrandName.Size = new System.Drawing.Size(173, 26);
            this.comboBox_FilterBrandName.TabIndex = 30;
            // 
            // lb_FilterBrandName
            // 
            this.lb_FilterBrandName.AutoSize = true;
            this.lb_FilterBrandName.Location = new System.Drawing.Point(50, 20);
            this.lb_FilterBrandName.Name = "lb_FilterBrandName";
            this.lb_FilterBrandName.Size = new System.Drawing.Size(95, 18);
            this.lb_FilterBrandName.TabIndex = 29;
            this.lb_FilterBrandName.Text = "Thương hiệu:";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.radioButton_FilterOutOfStock);
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStocking);
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStopBusiness);
            this.groupBox_Status.Location = new System.Drawing.Point(428, 26);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(178, 120);
            this.groupBox_Status.TabIndex = 28;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Tình trạng sản phẩm";
            // 
            // radioButton_FilterOutOfStock
            // 
            this.radioButton_FilterOutOfStock.AutoSize = true;
            this.radioButton_FilterOutOfStock.Location = new System.Drawing.Point(27, 55);
            this.radioButton_FilterOutOfStock.Name = "radioButton_FilterOutOfStock";
            this.radioButton_FilterOutOfStock.Size = new System.Drawing.Size(89, 22);
            this.radioButton_FilterOutOfStock.TabIndex = 29;
            this.radioButton_FilterOutOfStock.TabStop = true;
            this.radioButton_FilterOutOfStock.Text = "Hết hàng";
            this.radioButton_FilterOutOfStock.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterStocking
            // 
            this.radioButton_FilterStocking.AutoSize = true;
            this.radioButton_FilterStocking.Location = new System.Drawing.Point(27, 30);
            this.radioButton_FilterStocking.Name = "radioButton_FilterStocking";
            this.radioButton_FilterStocking.Size = new System.Drawing.Size(91, 22);
            this.radioButton_FilterStocking.TabIndex = 27;
            this.radioButton_FilterStocking.TabStop = true;
            this.radioButton_FilterStocking.Text = "Còn hàng";
            this.radioButton_FilterStocking.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterStopBusiness
            // 
            this.radioButton_FilterStopBusiness.AutoSize = true;
            this.radioButton_FilterStopBusiness.Location = new System.Drawing.Point(27, 81);
            this.radioButton_FilterStopBusiness.Name = "radioButton_FilterStopBusiness";
            this.radioButton_FilterStopBusiness.Size = new System.Drawing.Size(147, 22);
            this.radioButton_FilterStopBusiness.TabIndex = 26;
            this.radioButton_FilterStopBusiness.TabStop = true;
            this.radioButton_FilterStopBusiness.Text = "Ngừng kinh doanh";
            this.radioButton_FilterStopBusiness.UseVisualStyleBackColor = true;
            // 
            // comboBox_PriceTo
            // 
            this.comboBox_PriceTo.FormattingEnabled = true;
            this.comboBox_PriceTo.Location = new System.Drawing.Point(177, 125);
            this.comboBox_PriceTo.Name = "comboBox_PriceTo";
            this.comboBox_PriceTo.Size = new System.Drawing.Size(173, 26);
            this.comboBox_PriceTo.TabIndex = 25;
            // 
            // comboBox_PriceFrom
            // 
            this.comboBox_PriceFrom.FormattingEnabled = true;
            this.comboBox_PriceFrom.Location = new System.Drawing.Point(177, 90);
            this.comboBox_PriceFrom.Name = "comboBox_PriceFrom";
            this.comboBox_PriceFrom.Size = new System.Drawing.Size(173, 26);
            this.comboBox_PriceFrom.TabIndex = 24;
            // 
            // lb_PriceTo
            // 
            this.lb_PriceTo.AutoSize = true;
            this.lb_PriceTo.Location = new System.Drawing.Point(50, 128);
            this.lb_PriceTo.Name = "lb_PriceTo";
            this.lb_PriceTo.Size = new System.Drawing.Size(39, 18);
            this.lb_PriceTo.TabIndex = 23;
            this.lb_PriceTo.Text = "Đến:";
            // 
            // lb_PriceFrom
            // 
            this.lb_PriceFrom.AutoSize = true;
            this.lb_PriceFrom.Location = new System.Drawing.Point(50, 93);
            this.lb_PriceFrom.Name = "lb_PriceFrom";
            this.lb_PriceFrom.Size = new System.Drawing.Size(52, 18);
            this.lb_PriceFrom.TabIndex = 10;
            this.lb_PriceFrom.Text = "Giá từ:";
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(668, 94);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(89, 47);
            this.btn_DefaultFilter.TabIndex = 9;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            this.btn_DefaultFilter.Click += new System.EventHandler(this.btn_DefaultFilter_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(668, 30);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(89, 47);
            this.btn_Filter.TabIndex = 8;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Update);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(82, 423);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(294, 138);
            this.groupBox_Operation.TabIndex = 1;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(165, 75);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 39);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(52, 75);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 39);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(165, 31);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 39);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(52, 31);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(86, 39);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(461, 233);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(169, 18);
            this.lb_Search.TabIndex = 4;
            this.lb_Search.Text = "Tìm kiếm tên sản phẩm:";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(640, 231);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(274, 26);
            this.txtBox_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(928, 227);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 29);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(15, 21);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(103, 18);
            this.lb_ProductID.TabIndex = 6;
            this.lb_ProductID.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_ProductType);
            this.panel1.Controls.Add(this.comboBox_BrandName);
            this.panel1.Controls.Add(this.txtBox_Quantity);
            this.panel1.Controls.Add(this.lb_Quantity);
            this.panel1.Controls.Add(this.radioButton_OutOfStock);
            this.panel1.Controls.Add(this.radioButton_Stocking);
            this.panel1.Controls.Add(this.radioButton_StopBusiness);
            this.panel1.Controls.Add(this.lb_Status);
            this.panel1.Controls.Add(this.btn_UploadImage);
            this.panel1.Controls.Add(this.txtBox_Price);
            this.panel1.Controls.Add(this.txtBox_ProductName);
            this.panel1.Controls.Add(this.txtBox_ProductID);
            this.panel1.Controls.Add(this.txtBox_Description);
            this.panel1.Controls.Add(this.lb_Description);
            this.panel1.Controls.Add(this.lb_UploadImage);
            this.panel1.Controls.Add(this.lb_Price);
            this.panel1.Controls.Add(this.numericUpDown_PercentPromotion);
            this.panel1.Controls.Add(this.lb_Promotion);
            this.panel1.Controls.Add(this.lb_ProductType);
            this.panel1.Controls.Add(this.lb_BrandName);
            this.panel1.Controls.Add(this.lb_ProductName);
            this.panel1.Controls.Add(this.lb_ProductID);
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 375);
            this.panel1.TabIndex = 7;
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Location = new System.Drawing.Point(157, 114);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(249, 26);
            this.comboBox_ProductType.TabIndex = 33;
            // 
            // comboBox_BrandName
            // 
            this.comboBox_BrandName.FormattingEnabled = true;
            this.comboBox_BrandName.Location = new System.Drawing.Point(157, 83);
            this.comboBox_BrandName.Name = "comboBox_BrandName";
            this.comboBox_BrandName.Size = new System.Drawing.Size(249, 26);
            this.comboBox_BrandName.TabIndex = 32;
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Location = new System.Drawing.Point(282, 202);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(116, 26);
            this.txtBox_Quantity.TabIndex = 31;
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Location = new System.Drawing.Point(279, 179);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(119, 18);
            this.lb_Quantity.TabIndex = 30;
            this.lb_Quantity.Text = "Số lượng còn lại: ";
            // 
            // radioButton_OutOfStock
            // 
            this.radioButton_OutOfStock.AutoSize = true;
            this.radioButton_OutOfStock.Location = new System.Drawing.Point(265, 242);
            this.radioButton_OutOfStock.Name = "radioButton_OutOfStock";
            this.radioButton_OutOfStock.Size = new System.Drawing.Size(89, 22);
            this.radioButton_OutOfStock.TabIndex = 29;
            this.radioButton_OutOfStock.TabStop = true;
            this.radioButton_OutOfStock.Text = "Hết hàng";
            this.radioButton_OutOfStock.UseVisualStyleBackColor = true;
            // 
            // radioButton_Stocking
            // 
            this.radioButton_Stocking.AutoSize = true;
            this.radioButton_Stocking.Location = new System.Drawing.Point(157, 242);
            this.radioButton_Stocking.Name = "radioButton_Stocking";
            this.radioButton_Stocking.Size = new System.Drawing.Size(91, 22);
            this.radioButton_Stocking.TabIndex = 24;
            this.radioButton_Stocking.TabStop = true;
            this.radioButton_Stocking.Text = "Còn hàng";
            this.radioButton_Stocking.UseVisualStyleBackColor = true;
            // 
            // radioButton_StopBusiness
            // 
            this.radioButton_StopBusiness.AutoSize = true;
            this.radioButton_StopBusiness.Location = new System.Drawing.Point(189, 265);
            this.radioButton_StopBusiness.Name = "radioButton_StopBusiness";
            this.radioButton_StopBusiness.Size = new System.Drawing.Size(147, 22);
            this.radioButton_StopBusiness.TabIndex = 23;
            this.radioButton_StopBusiness.TabStop = true;
            this.radioButton_StopBusiness.Text = "Ngừng kinh doanh";
            this.radioButton_StopBusiness.UseVisualStyleBackColor = true;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(15, 242);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(80, 18);
            this.lb_Status.TabIndex = 22;
            this.lb_Status.Text = "Tình trạng:";
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(157, 207);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(100, 27);
            this.btn_UploadImage.TabIndex = 21;
            this.btn_UploadImage.Text = "Tải lên";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(157, 144);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(249, 26);
            this.txtBox_Price.TabIndex = 20;
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Location = new System.Drawing.Point(157, 50);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(249, 26);
            this.txtBox_ProductName.TabIndex = 17;
            // 
            // txtBox_ProductID
            // 
            this.txtBox_ProductID.Location = new System.Drawing.Point(157, 18);
            this.txtBox_ProductID.Name = "txtBox_ProductID";
            this.txtBox_ProductID.Size = new System.Drawing.Size(249, 26);
            this.txtBox_ProductID.TabIndex = 16;
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(19, 289);
            this.txtBox_Description.Multiline = true;
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(379, 77);
            this.txtBox_Description.TabIndex = 15;
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(15, 268);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(51, 18);
            this.lb_Description.TabIndex = 14;
            this.lb_Description.Text = "Mô tả:";
            // 
            // lb_UploadImage
            // 
            this.lb_UploadImage.AutoSize = true;
            this.lb_UploadImage.Location = new System.Drawing.Point(15, 210);
            this.lb_UploadImage.Name = "lb_UploadImage";
            this.lb_UploadImage.Size = new System.Drawing.Size(116, 18);
            this.lb_UploadImage.TabIndex = 13;
            this.lb_UploadImage.Text = "Tải lên hình ảnh:";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(17, 144);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(33, 18);
            this.lb_Price.TabIndex = 12;
            this.lb_Price.Text = "Giá:";
            // 
            // numericUpDown_PercentPromotion
            // 
            this.numericUpDown_PercentPromotion.Location = new System.Drawing.Point(157, 177);
            this.numericUpDown_PercentPromotion.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_PercentPromotion.Name = "numericUpDown_PercentPromotion";
            this.numericUpDown_PercentPromotion.Size = new System.Drawing.Size(57, 26);
            this.numericUpDown_PercentPromotion.TabIndex = 11;
            this.numericUpDown_PercentPromotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Promotion
            // 
            this.lb_Promotion.AutoSize = true;
            this.lb_Promotion.Location = new System.Drawing.Point(17, 181);
            this.lb_Promotion.Name = "lb_Promotion";
            this.lb_Promotion.Size = new System.Drawing.Size(122, 18);
            this.lb_Promotion.TabIndex = 10;
            this.lb_Promotion.Text = "Khuyến mãi (%):";
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Location = new System.Drawing.Point(17, 117);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(108, 18);
            this.lb_ProductType.TabIndex = 9;
            this.lb_ProductType.Text = "Loại sản phẩm:";
            // 
            // lb_BrandName
            // 
            this.lb_BrandName.AutoSize = true;
            this.lb_BrandName.Location = new System.Drawing.Point(15, 86);
            this.lb_BrandName.Name = "lb_BrandName";
            this.lb_BrandName.Size = new System.Drawing.Size(121, 18);
            this.lb_BrandName.TabIndex = 8;
            this.lb_BrandName.Text = "Tên thương hiệu:";
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(15, 52);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(109, 18);
            this.lb_ProductName.TabIndex = 7;
            this.lb_ProductName.Text = "Tên sản phẩm:";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(1501, 28);
            this.menuStrip_Main.TabIndex = 9;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thươngHiệuToolStripMenuItem,
            this.loạiSảnPhẩmToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // thươngHiệuToolStripMenuItem
            // 
            this.thươngHiệuToolStripMenuItem.Name = "thươngHiệuToolStripMenuItem";
            this.thươngHiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thươngHiệuToolStripMenuItem.Text = "Thương hiệu";
            this.thươngHiệuToolStripMenuItem.Click += new System.EventHandler(this.thươngHiệuToolStripMenuItem_Click);
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lb_TotalProduct
            // 
            this.lb_TotalProduct.AutoSize = true;
            this.lb_TotalProduct.Location = new System.Drawing.Point(1238, 238);
            this.lb_TotalProduct.Name = "lb_TotalProduct";
            this.lb_TotalProduct.Size = new System.Drawing.Size(117, 18);
            this.lb_TotalProduct.TabIndex = 27;
            this.lb_TotalProduct.Text = "Tổng sản phẩm:";
            // 
            // txtBox_TotalProduct
            // 
            this.txtBox_TotalProduct.Location = new System.Drawing.Point(1359, 236);
            this.txtBox_TotalProduct.Name = "txtBox_TotalProduct";
            this.txtBox_TotalProduct.ReadOnly = true;
            this.txtBox_TotalProduct.Size = new System.Drawing.Size(88, 26);
            this.txtBox_TotalProduct.TabIndex = 22;
            this.txtBox_TotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_ProductList
            // 
            this.dataGridView_ProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ProductList.Location = new System.Drawing.Point(444, 265);
            this.dataGridView_ProductList.Name = "dataGridView_ProductList";
            this.dataGridView_ProductList.RowHeadersWidth = 51;
            this.dataGridView_ProductList.RowTemplate.Height = 24;
            this.dataGridView_ProductList.Size = new System.Drawing.Size(1046, 297);
            this.dataGridView_ProductList.TabIndex = 28;
            this.dataGridView_ProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ProductList_CellClick);
            this.dataGridView_ProductList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_ProductList_MouseClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 573);
            this.Controls.Add(this.dataGridView_ProductList);
            this.Controls.Add(this.txtBox_TotalProduct);
            this.Controls.Add(this.lb_TotalProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "frmProduct";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            this.groupBox_Operation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PercentPromotion)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_DefaultFilter;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.Label lb_BrandName;
        private System.Windows.Forms.Label lb_ProductType;
        private System.Windows.Forms.Label lb_Promotion;
        private System.Windows.Forms.NumericUpDown numericUpDown_PercentPromotion;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_UploadImage;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.TextBox txtBox_Description;
        private System.Windows.Forms.TextBox txtBox_ProductID;
        private System.Windows.Forms.TextBox txtBox_ProductName;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thươngHiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lb_PriceFrom;
        private System.Windows.Forms.Label lb_PriceTo;
        private System.Windows.Forms.ComboBox comboBox_PriceTo;
        private System.Windows.Forms.ComboBox comboBox_PriceFrom;
        private System.Windows.Forms.Label lb_TotalProduct;
        private System.Windows.Forms.TextBox txtBox_TotalProduct;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.RadioButton radioButton_Stocking;
        private System.Windows.Forms.RadioButton radioButton_StopBusiness;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.RadioButton radioButton_FilterStocking;
        private System.Windows.Forms.RadioButton radioButton_FilterStopBusiness;
        private System.Windows.Forms.ComboBox comboBox_FilterProductType;
        private System.Windows.Forms.Label lb_FilterProductType;
        private System.Windows.Forms.ComboBox comboBox_FilterBrandName;
        private System.Windows.Forms.Label lb_FilterBrandName;
        private System.Windows.Forms.RadioButton radioButton_FilterOutOfStock;
        private System.Windows.Forms.RadioButton radioButton_OutOfStock;
        private System.Windows.Forms.DataGridView dataGridView_ProductList;
        private System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.Label lb_Quantity;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.ComboBox comboBox_BrandName;
    }
}