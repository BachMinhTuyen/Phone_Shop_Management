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
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.comboBox_FilterProductType = new System.Windows.Forms.ComboBox();
            this.lb_FilterProductType = new System.Windows.Forms.Label();
            this.comboBox_FilterBrandName = new System.Windows.Forms.ComboBox();
            this.lb_FilterBrandName = new System.Windows.Forms.Label();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.radioButton_FilterStocking = new System.Windows.Forms.RadioButton();
            this.radioButton_FilterStopBusiness = new System.Windows.Forms.RadioButton();
            this.comboBox_PriceTo = new System.Windows.Forms.ComboBox();
            this.comboBox_PriceFrom = new System.Windows.Forms.ComboBox();
            this.lb_PriceTo = new System.Windows.Forms.Label();
            this.lb_PriceFrom = new System.Windows.Forms.Label();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.comboBox_ColumnProduct = new System.Windows.Forms.ComboBox();
            this.lb_By = new System.Windows.Forms.Label();
            this.comboBox_SortMethod = new System.Windows.Forms.ComboBox();
            this.lb_Sort = new System.Windows.Forms.Label();
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
            this.radioButton_Stocking = new System.Windows.Forms.RadioButton();
            this.radioButton_StopBusiness = new System.Windows.Forms.RadioButton();
            this.lb_Status = new System.Windows.Forms.Label();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_ProductType = new System.Windows.Forms.TextBox();
            this.txtBox_BrandName = new System.Windows.Forms.TextBox();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentPromotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImagePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_TotalProduct = new System.Windows.Forms.Label();
            this.txtBox_TotalProduct = new System.Windows.Forms.TextBox();
            this.panel_Filter.SuspendLayout();
            this.groupBox_Status.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PercentPromotion)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
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
            this.panel_Filter.Controls.Add(this.comboBox_ColumnProduct);
            this.panel_Filter.Controls.Add(this.lb_By);
            this.panel_Filter.Controls.Add(this.comboBox_SortMethod);
            this.panel_Filter.Controls.Add(this.lb_Sort);
            this.panel_Filter.Location = new System.Drawing.Point(500, 50);
            this.panel_Filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(1177, 198);
            this.panel_Filter.TabIndex = 0;
            // 
            // comboBox_FilterProductType
            // 
            this.comboBox_FilterProductType.FormattingEnabled = true;
            this.comboBox_FilterProductType.Location = new System.Drawing.Point(199, 99);
            this.comboBox_FilterProductType.Name = "comboBox_FilterProductType";
            this.comboBox_FilterProductType.Size = new System.Drawing.Size(139, 29);
            this.comboBox_FilterProductType.TabIndex = 32;
            // 
            // lb_FilterProductType
            // 
            this.lb_FilterProductType.AutoSize = true;
            this.lb_FilterProductType.Location = new System.Drawing.Point(56, 103);
            this.lb_FilterProductType.Name = "lb_FilterProductType";
            this.lb_FilterProductType.Size = new System.Drawing.Size(123, 21);
            this.lb_FilterProductType.TabIndex = 31;
            this.lb_FilterProductType.Text = "Loại sản phẩm:";
            // 
            // comboBox_FilterBrandName
            // 
            this.comboBox_FilterBrandName.FormattingEnabled = true;
            this.comboBox_FilterBrandName.Location = new System.Drawing.Point(199, 61);
            this.comboBox_FilterBrandName.Name = "comboBox_FilterBrandName";
            this.comboBox_FilterBrandName.Size = new System.Drawing.Size(139, 29);
            this.comboBox_FilterBrandName.TabIndex = 30;
            // 
            // lb_FilterBrandName
            // 
            this.lb_FilterBrandName.AutoSize = true;
            this.lb_FilterBrandName.Location = new System.Drawing.Point(56, 64);
            this.lb_FilterBrandName.Name = "lb_FilterBrandName";
            this.lb_FilterBrandName.Size = new System.Drawing.Size(108, 21);
            this.lb_FilterBrandName.TabIndex = 29;
            this.lb_FilterBrandName.Text = "Thương hiệu:";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStocking);
            this.groupBox_Status.Controls.Add(this.radioButton_FilterStopBusiness);
            this.groupBox_Status.Location = new System.Drawing.Point(557, 20);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(200, 100);
            this.groupBox_Status.TabIndex = 28;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Tình trạng sản phẩm";
            // 
            // radioButton_FilterStocking
            // 
            this.radioButton_FilterStocking.AutoSize = true;
            this.radioButton_FilterStocking.Location = new System.Drawing.Point(30, 35);
            this.radioButton_FilterStocking.Name = "radioButton_FilterStocking";
            this.radioButton_FilterStocking.Size = new System.Drawing.Size(100, 25);
            this.radioButton_FilterStocking.TabIndex = 27;
            this.radioButton_FilterStocking.TabStop = true;
            this.radioButton_FilterStocking.Text = "Còn hàng";
            this.radioButton_FilterStocking.UseVisualStyleBackColor = true;
            // 
            // radioButton_FilterStopBusiness
            // 
            this.radioButton_FilterStopBusiness.AutoSize = true;
            this.radioButton_FilterStopBusiness.Location = new System.Drawing.Point(30, 66);
            this.radioButton_FilterStopBusiness.Name = "radioButton_FilterStopBusiness";
            this.radioButton_FilterStopBusiness.Size = new System.Drawing.Size(164, 25);
            this.radioButton_FilterStopBusiness.TabIndex = 26;
            this.radioButton_FilterStopBusiness.TabStop = true;
            this.radioButton_FilterStopBusiness.Text = "Ngừng kinh doanh";
            this.radioButton_FilterStopBusiness.UseVisualStyleBackColor = true;
            // 
            // comboBox_PriceTo
            // 
            this.comboBox_PriceTo.FormattingEnabled = true;
            this.comboBox_PriceTo.Location = new System.Drawing.Point(870, 61);
            this.comboBox_PriceTo.Name = "comboBox_PriceTo";
            this.comboBox_PriceTo.Size = new System.Drawing.Size(235, 29);
            this.comboBox_PriceTo.TabIndex = 25;
            // 
            // comboBox_PriceFrom
            // 
            this.comboBox_PriceFrom.FormattingEnabled = true;
            this.comboBox_PriceFrom.Location = new System.Drawing.Point(870, 20);
            this.comboBox_PriceFrom.Name = "comboBox_PriceFrom";
            this.comboBox_PriceFrom.Size = new System.Drawing.Size(235, 29);
            this.comboBox_PriceFrom.TabIndex = 24;
            // 
            // lb_PriceTo
            // 
            this.lb_PriceTo.AutoSize = true;
            this.lb_PriceTo.Location = new System.Drawing.Point(818, 64);
            this.lb_PriceTo.Name = "lb_PriceTo";
            this.lb_PriceTo.Size = new System.Drawing.Size(46, 21);
            this.lb_PriceTo.TabIndex = 23;
            this.lb_PriceTo.Text = "Đến:";
            // 
            // lb_PriceFrom
            // 
            this.lb_PriceFrom.AutoSize = true;
            this.lb_PriceFrom.Location = new System.Drawing.Point(803, 23);
            this.lb_PriceFrom.Name = "lb_PriceFrom";
            this.lb_PriceFrom.Size = new System.Drawing.Size(61, 21);
            this.lb_PriceFrom.TabIndex = 10;
            this.lb_PriceFrom.Text = "Giá từ:";
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(609, 146);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(100, 33);
            this.btn_DefaultFilter.TabIndex = 9;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(479, 146);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 33);
            this.btn_Filter.TabIndex = 8;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // comboBox_ColumnProduct
            // 
            this.comboBox_ColumnProduct.FormattingEnabled = true;
            this.comboBox_ColumnProduct.Location = new System.Drawing.Point(390, 20);
            this.comboBox_ColumnProduct.Name = "comboBox_ColumnProduct";
            this.comboBox_ColumnProduct.Size = new System.Drawing.Size(129, 29);
            this.comboBox_ColumnProduct.TabIndex = 3;
            // 
            // lb_By
            // 
            this.lb_By.AutoSize = true;
            this.lb_By.Location = new System.Drawing.Point(343, 23);
            this.lb_By.Name = "lb_By";
            this.lb_By.Size = new System.Drawing.Size(43, 21);
            this.lb_By.TabIndex = 2;
            this.lb_By.Text = "theo";
            // 
            // comboBox_SortMethod
            // 
            this.comboBox_SortMethod.FormattingEnabled = true;
            this.comboBox_SortMethod.Location = new System.Drawing.Point(201, 20);
            this.comboBox_SortMethod.Name = "comboBox_SortMethod";
            this.comboBox_SortMethod.Size = new System.Drawing.Size(137, 29);
            this.comboBox_SortMethod.TabIndex = 1;
            // 
            // lb_Sort
            // 
            this.lb_Sort.AutoSize = true;
            this.lb_Sort.Location = new System.Drawing.Point(71, 23);
            this.lb_Sort.Name = "lb_Sort";
            this.lb_Sort.Size = new System.Drawing.Size(74, 21);
            this.lb_Sort.TabIndex = 0;
            this.lb_Sort.Text = "Sắp xếp:";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Update);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(92, 494);
            this.groupBox_Operation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Operation.Size = new System.Drawing.Size(331, 161);
            this.groupBox_Operation.TabIndex = 1;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(186, 87);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(97, 45);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(58, 87);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(97, 45);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(186, 36);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 45);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(58, 36);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(97, 45);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(519, 272);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(190, 21);
            this.lb_Search.TabIndex = 4;
            this.lb_Search.Text = "Tìm kiếm tên sản phẩm:";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(720, 269);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(308, 28);
            this.txtBox_Search.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1044, 265);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 34);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(17, 24);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(115, 21);
            this.lb_ProductID.TabIndex = 6;
            this.lb_ProductID.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Stocking);
            this.panel1.Controls.Add(this.radioButton_StopBusiness);
            this.panel1.Controls.Add(this.lb_Status);
            this.panel1.Controls.Add(this.btn_UploadImage);
            this.panel1.Controls.Add(this.txtBox_Price);
            this.panel1.Controls.Add(this.txtBox_ProductType);
            this.panel1.Controls.Add(this.txtBox_BrandName);
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
            this.panel1.Location = new System.Drawing.Point(18, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 437);
            this.panel1.TabIndex = 7;
            // 
            // radioButton_Stocking
            // 
            this.radioButton_Stocking.AutoSize = true;
            this.radioButton_Stocking.Location = new System.Drawing.Point(352, 280);
            this.radioButton_Stocking.Name = "radioButton_Stocking";
            this.radioButton_Stocking.Size = new System.Drawing.Size(100, 25);
            this.radioButton_Stocking.TabIndex = 24;
            this.radioButton_Stocking.TabStop = true;
            this.radioButton_Stocking.Text = "Còn hàng";
            this.radioButton_Stocking.UseVisualStyleBackColor = true;
            // 
            // radioButton_StopBusiness
            // 
            this.radioButton_StopBusiness.AutoSize = true;
            this.radioButton_StopBusiness.Location = new System.Drawing.Point(177, 280);
            this.radioButton_StopBusiness.Name = "radioButton_StopBusiness";
            this.radioButton_StopBusiness.Size = new System.Drawing.Size(164, 25);
            this.radioButton_StopBusiness.TabIndex = 23;
            this.radioButton_StopBusiness.TabStop = true;
            this.radioButton_StopBusiness.Text = "Ngừng kinh doanh";
            this.radioButton_StopBusiness.UseVisualStyleBackColor = true;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(17, 282);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(92, 21);
            this.lb_Status.TabIndex = 22;
            this.lb_Status.Text = "Tình trạng:";
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(177, 241);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(113, 32);
            this.btn_UploadImage.TabIndex = 21;
            this.btn_UploadImage.Text = "Tải lên";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(177, 207);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(272, 28);
            this.txtBox_Price.TabIndex = 20;
            // 
            // txtBox_ProductType
            // 
            this.txtBox_ProductType.Location = new System.Drawing.Point(177, 133);
            this.txtBox_ProductType.Name = "txtBox_ProductType";
            this.txtBox_ProductType.Size = new System.Drawing.Size(272, 28);
            this.txtBox_ProductType.TabIndex = 19;
            // 
            // txtBox_BrandName
            // 
            this.txtBox_BrandName.Location = new System.Drawing.Point(177, 97);
            this.txtBox_BrandName.Name = "txtBox_BrandName";
            this.txtBox_BrandName.Size = new System.Drawing.Size(272, 28);
            this.txtBox_BrandName.TabIndex = 18;
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Location = new System.Drawing.Point(177, 58);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(272, 28);
            this.txtBox_ProductName.TabIndex = 17;
            // 
            // txtBox_ProductID
            // 
            this.txtBox_ProductID.Location = new System.Drawing.Point(177, 21);
            this.txtBox_ProductID.Name = "txtBox_ProductID";
            this.txtBox_ProductID.Size = new System.Drawing.Size(272, 28);
            this.txtBox_ProductID.TabIndex = 16;
            // 
            // txtBox_Description
            // 
            this.txtBox_Description.Location = new System.Drawing.Point(21, 337);
            this.txtBox_Description.Multiline = true;
            this.txtBox_Description.Name = "txtBox_Description";
            this.txtBox_Description.Size = new System.Drawing.Size(426, 89);
            this.txtBox_Description.TabIndex = 15;
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(17, 313);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(58, 21);
            this.lb_Description.TabIndex = 14;
            this.lb_Description.Text = "Mô tả:";
            // 
            // lb_UploadImage
            // 
            this.lb_UploadImage.AutoSize = true;
            this.lb_UploadImage.Location = new System.Drawing.Point(17, 245);
            this.lb_UploadImage.Name = "lb_UploadImage";
            this.lb_UploadImage.Size = new System.Drawing.Size(134, 21);
            this.lb_UploadImage.TabIndex = 13;
            this.lb_UploadImage.Text = "Tải lên hình ảnh:";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(19, 207);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(40, 21);
            this.lb_Price.TabIndex = 12;
            this.lb_Price.Text = "Giá:";
            // 
            // numericUpDown_PercentPromotion
            // 
            this.numericUpDown_PercentPromotion.Location = new System.Drawing.Point(177, 167);
            this.numericUpDown_PercentPromotion.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_PercentPromotion.Name = "numericUpDown_PercentPromotion";
            this.numericUpDown_PercentPromotion.Size = new System.Drawing.Size(64, 28);
            this.numericUpDown_PercentPromotion.TabIndex = 11;
            this.numericUpDown_PercentPromotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Promotion
            // 
            this.lb_Promotion.AutoSize = true;
            this.lb_Promotion.Location = new System.Drawing.Point(19, 172);
            this.lb_Promotion.Name = "lb_Promotion";
            this.lb_Promotion.Size = new System.Drawing.Size(138, 21);
            this.lb_Promotion.TabIndex = 10;
            this.lb_Promotion.Text = "Khuyến mãi (%):";
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Location = new System.Drawing.Point(19, 136);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(123, 21);
            this.lb_ProductType.TabIndex = 9;
            this.lb_ProductType.Text = "Loại sản phẩm:";
            // 
            // lb_BrandName
            // 
            this.lb_BrandName.AutoSize = true;
            this.lb_BrandName.Location = new System.Drawing.Point(17, 100);
            this.lb_BrandName.Name = "lb_BrandName";
            this.lb_BrandName.Size = new System.Drawing.Size(137, 21);
            this.lb_BrandName.TabIndex = 8;
            this.lb_BrandName.Text = "Tên thương hiệu:";
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(17, 61);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(121, 21);
            this.lb_ProductName.TabIndex = 7;
            this.lb_ProductName.Text = "Tên sản phẩm:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.BrandName,
            this.ProductType,
            this.PercentPromotion,
            this.Price,
            this.ImagePath,
            this.Status,
            this.Description});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(500, 315);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1177, 340);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Mã sản phẩm";
            this.ProductID.Width = 114;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Tên sản phẩm";
            this.ProductName.Width = 140;
            // 
            // BrandName
            // 
            this.BrandName.Text = "Tên thương hiệu";
            this.BrandName.Width = 141;
            // 
            // ProductType
            // 
            this.ProductType.Text = "Loại sản phẩm";
            this.ProductType.Width = 131;
            // 
            // PercentPromotion
            // 
            this.PercentPromotion.Text = "Khuyến mãi";
            this.PercentPromotion.Width = 135;
            // 
            // Price
            // 
            this.Price.Text = "Giá";
            this.Price.Width = 74;
            // 
            // ImagePath
            // 
            this.ImagePath.Text = "Hình ảnh";
            this.ImagePath.Width = 126;
            // 
            // Status
            // 
            this.Status.Text = "Tình trạng";
            this.Status.Width = 129;
            // 
            // Description
            // 
            this.Description.Text = "Mô tả sản phẩm";
            this.Description.Width = 151;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1689, 28);
            this.menuStrip_Main.TabIndex = 9;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thươngHiệuToolStripMenuItem,
            this.loạiSảnPhẩmToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // thươngHiệuToolStripMenuItem
            // 
            this.thươngHiệuToolStripMenuItem.Name = "thươngHiệuToolStripMenuItem";
            this.thươngHiệuToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.thươngHiệuToolStripMenuItem.Text = "Thương hiệu";
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // lb_TotalProduct
            // 
            this.lb_TotalProduct.AutoSize = true;
            this.lb_TotalProduct.Location = new System.Drawing.Point(1393, 278);
            this.lb_TotalProduct.Name = "lb_TotalProduct";
            this.lb_TotalProduct.Size = new System.Drawing.Size(130, 21);
            this.lb_TotalProduct.TabIndex = 27;
            this.lb_TotalProduct.Text = "Tổng sản phẩm:";
            // 
            // txtBox_TotalProduct
            // 
            this.txtBox_TotalProduct.Location = new System.Drawing.Point(1529, 275);
            this.txtBox_TotalProduct.Name = "txtBox_TotalProduct";
            this.txtBox_TotalProduct.ReadOnly = true;
            this.txtBox_TotalProduct.Size = new System.Drawing.Size(98, 28);
            this.txtBox_TotalProduct.TabIndex = 22;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 668);
            this.Controls.Add(this.txtBox_TotalProduct);
            this.Controls.Add(this.lb_TotalProduct);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.Text = "Quản lý sản phẩm";
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
        private System.Windows.Forms.Label lb_Sort;
        private System.Windows.Forms.ComboBox comboBox_SortMethod;
        private System.Windows.Forms.Label lb_By;
        private System.Windows.Forms.ComboBox comboBox_ColumnProduct;
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
        private System.Windows.Forms.TextBox txtBox_BrandName;
        private System.Windows.Forms.TextBox txtBox_ProductType;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader BrandName;
        private System.Windows.Forms.ColumnHeader ProductType;
        private System.Windows.Forms.ColumnHeader PercentPromotion;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ImagePath;
        private System.Windows.Forms.ColumnHeader Description;
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
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.RadioButton radioButton_FilterStocking;
        private System.Windows.Forms.RadioButton radioButton_FilterStopBusiness;
        private System.Windows.Forms.ComboBox comboBox_FilterProductType;
        private System.Windows.Forms.Label lb_FilterProductType;
        private System.Windows.Forms.ComboBox comboBox_FilterBrandName;
        private System.Windows.Forms.Label lb_FilterBrandName;
    }
}