namespace PhoneShopManagement.UserArea
{
    partial class frmGenerateBill
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
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăgnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_BillInformation = new System.Windows.Forms.GroupBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.txtBox_StaffName = new System.Windows.Forms.TextBox();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.lb_StaffName = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtBox_Total = new System.Windows.Forms.TextBox();
            this.lb_TotalBill = new System.Windows.Forms.Label();
            this.dateTimePicker_TimeOfPurchase = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lb_Quantity = new System.Windows.Forms.Label();
            this.txtBox_ProductName = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txtBox_ProductID = new System.Windows.Forms.TextBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.btn_GenerateBill = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dataGridView_Details = new System.Windows.Forms.DataGridView();
            this.dataGridView_Information = new System.Windows.Forms.DataGridView();
            this.radioButton_Cash = new System.Windows.Forms.RadioButton();
            this.radioButton_Transfer = new System.Windows.Forms.RadioButton();
            this.lb_PaymentMethod = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_BillInformation.SuspendLayout();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Information)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.hoáĐơnToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem,
            this.vềChúngTôiToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiToolStripMenuItem});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoToolStripMenuItem,
            this.xemHoáĐơnToolStripMenuItem});
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.hoáĐơnToolStripMenuItem.Text = "Tra cứu";
            // 
            // tạoToolStripMenuItem
            // 
            this.tạoToolStripMenuItem.Name = "tạoToolStripMenuItem";
            this.tạoToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.tạoToolStripMenuItem.Text = "Hoá đơn";
            this.tạoToolStripMenuItem.Click += new System.EventHandler(this.tạoToolStripMenuItem_Click);
            // 
            // xemHoáĐơnToolStripMenuItem
            // 
            this.xemHoáĐơnToolStripMenuItem.Name = "xemHoáĐơnToolStripMenuItem";
            this.xemHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.xemHoáĐơnToolStripMenuItem.Text = "Sản phẩm";
            this.xemHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemHoáĐơnToolStripMenuItem_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtLậpThôngTinToolStripMenuItem,
            this.đăgnToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // thiếtLậpThôngTinToolStripMenuItem
            // 
            this.thiếtLậpThôngTinToolStripMenuItem.Name = "thiếtLậpThôngTinToolStripMenuItem";
            this.thiếtLậpThôngTinToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.thiếtLậpThôngTinToolStripMenuItem.Text = "Thiết lập người dùng";
            this.thiếtLậpThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpThôngTinToolStripMenuItem_Click);
            // 
            // đăgnToolStripMenuItem
            // 
            this.đăgnToolStripMenuItem.Name = "đăgnToolStripMenuItem";
            this.đăgnToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.đăgnToolStripMenuItem.Text = "Đăng xuất";
            this.đăgnToolStripMenuItem.Click += new System.EventHandler(this.đăgnToolStripMenuItem_Click);
            // 
            // vềChúngTôiToolStripMenuItem
            // 
            this.vềChúngTôiToolStripMenuItem.Name = "vềChúngTôiToolStripMenuItem";
            this.vềChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.vềChúngTôiToolStripMenuItem.Text = "Về chúng tôi";
            this.vềChúngTôiToolStripMenuItem.Click += new System.EventHandler(this.vềChúngTôiToolStripMenuItem_Click);
            // 
            // groupBox_BillInformation
            // 
            this.groupBox_BillInformation.Controls.Add(this.txtBox_Email);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_StaffName);
            this.groupBox_BillInformation.Controls.Add(this.lb_CustomerName);
            this.groupBox_BillInformation.Controls.Add(this.lb_StaffName);
            this.groupBox_BillInformation.Controls.Add(this.lb_PhoneNumber);
            this.groupBox_BillInformation.Controls.Add(this.lb_Email);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_CustomerName);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_Address);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_PhoneNumber);
            this.groupBox_BillInformation.Controls.Add(this.lb_Address);
            this.groupBox_BillInformation.Location = new System.Drawing.Point(11, 40);
            this.groupBox_BillInformation.Name = "groupBox_BillInformation";
            this.groupBox_BillInformation.Size = new System.Drawing.Size(422, 227);
            this.groupBox_BillInformation.TabIndex = 45;
            this.groupBox_BillInformation.TabStop = false;
            this.groupBox_BillInformation.Text = "Thông tin hoá đơn";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(167, 141);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(229, 26);
            this.txtBox_Email.TabIndex = 28;
            // 
            // txtBox_StaffName
            // 
            this.txtBox_StaffName.Location = new System.Drawing.Point(167, 73);
            this.txtBox_StaffName.Name = "txtBox_StaffName";
            this.txtBox_StaffName.ReadOnly = true;
            this.txtBox_StaffName.Size = new System.Drawing.Size(229, 26);
            this.txtBox_StaffName.TabIndex = 36;
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Location = new System.Drawing.Point(18, 38);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(119, 18);
            this.lb_CustomerName.TabIndex = 7;
            this.lb_CustomerName.Text = "Tên khách hàng:";
            // 
            // lb_StaffName
            // 
            this.lb_StaffName.AutoSize = true;
            this.lb_StaffName.Location = new System.Drawing.Point(18, 75);
            this.lb_StaffName.Name = "lb_StaffName";
            this.lb_StaffName.Size = new System.Drawing.Size(144, 18);
            this.lb_StaffName.TabIndex = 34;
            this.lb_StaffName.Text = "Nhân viên bán hàng:";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(18, 114);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(121, 18);
            this.lb_PhoneNumber.TabIndex = 10;
            this.lb_PhoneNumber.Text = "SDT khách hàng:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(18, 144);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 18);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Email:";
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Location = new System.Drawing.Point(167, 35);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(229, 26);
            this.txtBox_CustomerName.TabIndex = 17;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(167, 177);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(229, 26);
            this.txtBox_Address.TabIndex = 30;
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(167, 111);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(229, 26);
            this.txtBox_PhoneNumber.TabIndex = 20;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(18, 179);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(135, 18);
            this.lb_Address.TabIndex = 29;
            this.lb_Address.Text = "Địa chỉ khách hàng:";
            // 
            // txtBox_Total
            // 
            this.txtBox_Total.Location = new System.Drawing.Point(626, 286);
            this.txtBox_Total.Name = "txtBox_Total";
            this.txtBox_Total.ReadOnly = true;
            this.txtBox_Total.Size = new System.Drawing.Size(231, 26);
            this.txtBox_Total.TabIndex = 38;
            // 
            // lb_TotalBill
            // 
            this.lb_TotalBill.AutoSize = true;
            this.lb_TotalBill.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalBill.Location = new System.Drawing.Point(435, 289);
            this.lb_TotalBill.Name = "lb_TotalBill";
            this.lb_TotalBill.Size = new System.Drawing.Size(165, 18);
            this.lb_TotalBill.TabIndex = 37;
            this.lb_TotalBill.Text = "Tổng tiền thanh toán:";
            // 
            // dateTimePicker_TimeOfPurchase
            // 
            this.dateTimePicker_TimeOfPurchase.Enabled = false;
            this.dateTimePicker_TimeOfPurchase.Location = new System.Drawing.Point(978, 58);
            this.dateTimePicker_TimeOfPurchase.Name = "dateTimePicker_TimeOfPurchase";
            this.dateTimePicker_TimeOfPurchase.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker_TimeOfPurchase.TabIndex = 27;
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Controls.Add(this.btn_Insert);
            this.groupBox_Details.Controls.Add(this.btn_Delete);
            this.groupBox_Details.Controls.Add(this.btn_Update);
            this.groupBox_Details.Controls.Add(this.txtBox_Price);
            this.groupBox_Details.Controls.Add(this.lb_Price);
            this.groupBox_Details.Controls.Add(this.numericUpDown_Quantity);
            this.groupBox_Details.Controls.Add(this.lb_Quantity);
            this.groupBox_Details.Controls.Add(this.txtBox_ProductName);
            this.groupBox_Details.Controls.Add(this.lb_ProductName);
            this.groupBox_Details.Controls.Add(this.txtBox_ProductID);
            this.groupBox_Details.Controls.Add(this.lb_ProductID);
            this.groupBox_Details.Location = new System.Drawing.Point(438, 40);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(418, 227);
            this.groupBox_Details.TabIndex = 46;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Text = "Chi tiết sản phẩm";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(68, 187);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(83, 29);
            this.btn_Insert.TabIndex = 50;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(290, 187);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(83, 29);
            this.btn_Delete.TabIndex = 48;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(178, 187);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 29);
            this.btn_Update.TabIndex = 47;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(163, 141);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.ReadOnly = true;
            this.txtBox_Price.Size = new System.Drawing.Size(234, 26);
            this.txtBox_Price.TabIndex = 46;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(35, 144);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(62, 18);
            this.lb_Price.TabIndex = 45;
            this.lb_Price.Text = "Đơn giá:";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(163, 107);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown_Quantity.TabIndex = 44;
            this.numericUpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Quantity
            // 
            this.lb_Quantity.AutoSize = true;
            this.lb_Quantity.Location = new System.Drawing.Point(35, 109);
            this.lb_Quantity.Name = "lb_Quantity";
            this.lb_Quantity.Size = new System.Drawing.Size(69, 18);
            this.lb_Quantity.TabIndex = 43;
            this.lb_Quantity.Text = "Số lượng:";
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Location = new System.Drawing.Point(163, 74);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.ReadOnly = true;
            this.txtBox_ProductName.Size = new System.Drawing.Size(234, 26);
            this.txtBox_ProductName.TabIndex = 42;
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(35, 75);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(109, 18);
            this.lb_ProductName.TabIndex = 41;
            this.lb_ProductName.Text = "Tên sản phẩm:";
            // 
            // txtBox_ProductID
            // 
            this.txtBox_ProductID.Location = new System.Drawing.Point(163, 41);
            this.txtBox_ProductID.Name = "txtBox_ProductID";
            this.txtBox_ProductID.Size = new System.Drawing.Size(234, 26);
            this.txtBox_ProductID.TabIndex = 40;
            this.txtBox_ProductID.Leave += new System.EventHandler(this.txtBox_ProductID_Leave);
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(35, 43);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(103, 18);
            this.lb_ProductID.TabIndex = 39;
            this.lb_ProductID.Text = "Mã sản phẩm:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1231, 142);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 29);
            this.btn_Search.TabIndex = 51;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(893, 145);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(325, 26);
            this.txtBox_Search.TabIndex = 53;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(861, 116);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(214, 18);
            this.lb_Search.TabIndex = 52;
            this.lb_Search.Text = "Tìm kiếm nhanh tên sản phẩm:";
            // 
            // btn_GenerateBill
            // 
            this.btn_GenerateBill.Location = new System.Drawing.Point(979, 482);
            this.btn_GenerateBill.Name = "btn_GenerateBill";
            this.btn_GenerateBill.Size = new System.Drawing.Size(117, 37);
            this.btn_GenerateBill.TabIndex = 55;
            this.btn_GenerateBill.Text = "Tạo hoá đơn";
            this.btn_GenerateBill.UseVisualStyleBackColor = true;
            this.btn_GenerateBill.Click += new System.EventHandler(this.btn_GenerateBill_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1101, 482);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(117, 37);
            this.btn_Cancel.TabIndex = 56;
            this.btn_Cancel.Text = "Huỷ";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dataGridView_Details
            // 
            this.dataGridView_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Details.Location = new System.Drawing.Point(11, 315);
            this.dataGridView_Details.Name = "dataGridView_Details";
            this.dataGridView_Details.RowHeadersWidth = 51;
            this.dataGridView_Details.RowTemplate.Height = 24;
            this.dataGridView_Details.Size = new System.Drawing.Size(845, 206);
            this.dataGridView_Details.TabIndex = 57;
            this.dataGridView_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Details_CellClick);
            // 
            // dataGridView_Information
            // 
            this.dataGridView_Information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Information.Location = new System.Drawing.Point(865, 182);
            this.dataGridView_Information.Name = "dataGridView_Information";
            this.dataGridView_Information.RowHeadersWidth = 51;
            this.dataGridView_Information.RowTemplate.Height = 24;
            this.dataGridView_Information.Size = new System.Drawing.Size(472, 242);
            this.dataGridView_Information.TabIndex = 58;
            this.dataGridView_Information.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Information_CellClick);
            // 
            // radioButton_Cash
            // 
            this.radioButton_Cash.AutoSize = true;
            this.radioButton_Cash.Location = new System.Drawing.Point(997, 443);
            this.radioButton_Cash.Name = "radioButton_Cash";
            this.radioButton_Cash.Size = new System.Drawing.Size(88, 22);
            this.radioButton_Cash.TabIndex = 59;
            this.radioButton_Cash.TabStop = true;
            this.radioButton_Cash.Text = "Tiền mặt";
            this.radioButton_Cash.UseVisualStyleBackColor = true;
            // 
            // radioButton_Transfer
            // 
            this.radioButton_Transfer.AutoSize = true;
            this.radioButton_Transfer.Location = new System.Drawing.Point(1121, 443);
            this.radioButton_Transfer.Name = "radioButton_Transfer";
            this.radioButton_Transfer.Size = new System.Drawing.Size(183, 22);
            this.radioButton_Transfer.TabIndex = 60;
            this.radioButton_Transfer.TabStop = true;
            this.radioButton_Transfer.Text = "Chuyển khoản/quẹt thẻ";
            this.radioButton_Transfer.UseVisualStyleBackColor = true;
            // 
            // lb_PaymentMethod
            // 
            this.lb_PaymentMethod.AutoSize = true;
            this.lb_PaymentMethod.Location = new System.Drawing.Point(880, 445);
            this.lb_PaymentMethod.Name = "lb_PaymentMethod";
            this.lb_PaymentMethod.Size = new System.Drawing.Size(96, 18);
            this.lb_PaymentMethod.TabIndex = 61;
            this.lb_PaymentMethod.Text = "Phương thức:";
            // 
            // frmGenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 531);
            this.Controls.Add(this.lb_PaymentMethod);
            this.Controls.Add(this.radioButton_Transfer);
            this.Controls.Add(this.radioButton_Cash);
            this.Controls.Add(this.dataGridView_Information);
            this.Controls.Add(this.dataGridView_Details);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_GenerateBill);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.txtBox_Total);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.lb_TotalBill);
            this.Controls.Add(this.groupBox_BillInformation);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.dateTimePicker_TimeOfPurchase);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "frmGenerateBill";
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerateBill_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerateBill_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_BillInformation.ResumeLayout(false);
            this.groupBox_BillInformation.PerformLayout();
            this.groupBox_Details.ResumeLayout(false);
            this.groupBox_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềChúngTôiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăgnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_BillInformation;
        private System.Windows.Forms.TextBox txtBox_Total;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label lb_TotalBill;
        private System.Windows.Forms.TextBox txtBox_StaffName;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.Label lb_StaffName;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txtBox_CustomerName;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimeOfPurchase;
        private System.Windows.Forms.GroupBox groupBox_Details;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.Label lb_Quantity;
        private System.Windows.Forms.TextBox txtBox_ProductName;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txtBox_ProductID;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button btn_GenerateBill;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dataGridView_Details;
        private System.Windows.Forms.DataGridView dataGridView_Information;
        private System.Windows.Forms.RadioButton radioButton_Cash;
        private System.Windows.Forms.RadioButton radioButton_Transfer;
        private System.Windows.Forms.Label lb_PaymentMethod;
    }
}