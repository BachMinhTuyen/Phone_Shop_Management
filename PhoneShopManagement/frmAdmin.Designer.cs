namespace PhoneShopManagement
{
    partial class frmAdmin
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
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChúngTôiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_UserInformation = new System.Windows.Forms.GroupBox();
            this.lb_AdminName = new System.Windows.Forms.Label();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_UserLogin = new System.Windows.Forms.Label();
            this.txtBox_UserLogin = new System.Windows.Forms.TextBox();
            this.txtBox_AdminName = new System.Windows.Forms.TextBox();
            this.txtBox_Birthday = new System.Windows.Forms.TextBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox_Statistics = new System.Windows.Forms.GroupBox();
            this.NumberOfStaff = new System.Windows.Forms.Label();
            this.lb_NumberOfAccount = new System.Windows.Forms.Label();
            this.lb_NumberOfProduct = new System.Windows.Forms.Label();
            this.lb_NumberOfCustomer = new System.Windows.Forms.Label();
            this.txtBox_NumberOfAccount = new System.Windows.Forms.TextBox();
            this.txtBox_NumberOfStaff = new System.Windows.Forms.TextBox();
            this.txtBox_NumberOfProduct = new System.Windows.Forms.TextBox();
            this.txtBox_NumberOfCustomer = new System.Windows.Forms.TextBox();
            this.panel_Report = new System.Windows.Forms.Panel();
            this.groupBox_ReportOfProduct = new System.Windows.Forms.GroupBox();
            this.listView_Product = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceOfProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantitySold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_UserInformation.SuspendLayout();
            this.groupBox_Statistics.SuspendLayout();
            this.panel_Report.SuspendLayout();
            this.groupBox_ReportOfProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem,
            this.vềChúngTôiToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip_Main.Size = new System.Drawing.Size(878, 30);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinChiTiếtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thôngTinChiTiếtToolStripMenuItem
            // 
            this.thôngTinChiTiếtToolStripMenuItem.Name = "thôngTinChiTiếtToolStripMenuItem";
            this.thôngTinChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.thôngTinChiTiếtToolStripMenuItem.Text = "Thiết lập người dùng";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnNgườiDùngToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // tàiKhoảnNgườiDùngToolStripMenuItem
            // 
            this.tàiKhoảnNgườiDùngToolStripMenuItem.Name = "tàiKhoảnNgườiDùngToolStripMenuItem";
            this.tàiKhoảnNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tàiKhoảnNgườiDùngToolStripMenuItem.Text = "Tài khoản";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // vềChúngTôiToolStripMenuItem
            // 
            this.vềChúngTôiToolStripMenuItem.Name = "vềChúngTôiToolStripMenuItem";
            this.vềChúngTôiToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.vềChúngTôiToolStripMenuItem.Text = "Về chúng tôi";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // groupBox_UserInformation
            // 
            this.groupBox_UserInformation.Controls.Add(this.txtBox_Email);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_Birthday);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_AdminName);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_UserLogin);
            this.groupBox_UserInformation.Controls.Add(this.lb_UserLogin);
            this.groupBox_UserInformation.Controls.Add(this.lb_Email);
            this.groupBox_UserInformation.Controls.Add(this.lb_Birthday);
            this.groupBox_UserInformation.Controls.Add(this.lb_AdminName);
            this.groupBox_UserInformation.Location = new System.Drawing.Point(12, 42);
            this.groupBox_UserInformation.Name = "groupBox_UserInformation";
            this.groupBox_UserInformation.Size = new System.Drawing.Size(434, 187);
            this.groupBox_UserInformation.TabIndex = 1;
            this.groupBox_UserInformation.TabStop = false;
            this.groupBox_UserInformation.Text = "Thông tin người dùng";
            // 
            // lb_AdminName
            // 
            this.lb_AdminName.AutoSize = true;
            this.lb_AdminName.Location = new System.Drawing.Point(27, 72);
            this.lb_AdminName.Name = "lb_AdminName";
            this.lb_AdminName.Size = new System.Drawing.Size(152, 21);
            this.lb_AdminName.TabIndex = 0;
            this.lb_AdminName.Text = "Tên người quản trị:";
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.Location = new System.Drawing.Point(27, 108);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(88, 21);
            this.lb_Birthday.TabIndex = 1;
            this.lb_Birthday.Text = "Ngày sinh:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(27, 143);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(57, 21);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email:";
            // 
            // lb_UserLogin
            // 
            this.lb_UserLogin.AutoSize = true;
            this.lb_UserLogin.Location = new System.Drawing.Point(27, 38);
            this.lb_UserLogin.Name = "lb_UserLogin";
            this.lb_UserLogin.Size = new System.Drawing.Size(127, 21);
            this.lb_UserLogin.TabIndex = 3;
            this.lb_UserLogin.Text = "Tên đăng nhập:";
            // 
            // txtBox_UserLogin
            // 
            this.txtBox_UserLogin.Location = new System.Drawing.Point(201, 35);
            this.txtBox_UserLogin.Name = "txtBox_UserLogin";
            this.txtBox_UserLogin.ReadOnly = true;
            this.txtBox_UserLogin.Size = new System.Drawing.Size(196, 28);
            this.txtBox_UserLogin.TabIndex = 4;
            // 
            // txtBox_AdminName
            // 
            this.txtBox_AdminName.Location = new System.Drawing.Point(201, 69);
            this.txtBox_AdminName.Name = "txtBox_AdminName";
            this.txtBox_AdminName.ReadOnly = true;
            this.txtBox_AdminName.Size = new System.Drawing.Size(196, 28);
            this.txtBox_AdminName.TabIndex = 5;
            // 
            // txtBox_Birthday
            // 
            this.txtBox_Birthday.Location = new System.Drawing.Point(201, 105);
            this.txtBox_Birthday.Name = "txtBox_Birthday";
            this.txtBox_Birthday.ReadOnly = true;
            this.txtBox_Birthday.Size = new System.Drawing.Size(196, 28);
            this.txtBox_Birthday.TabIndex = 6;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(201, 140);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.ReadOnly = true;
            this.txtBox_Email.Size = new System.Drawing.Size(196, 28);
            this.txtBox_Email.TabIndex = 7;
            // 
            // groupBox_Statistics
            // 
            this.groupBox_Statistics.Controls.Add(this.txtBox_NumberOfCustomer);
            this.groupBox_Statistics.Controls.Add(this.txtBox_NumberOfProduct);
            this.groupBox_Statistics.Controls.Add(this.txtBox_NumberOfStaff);
            this.groupBox_Statistics.Controls.Add(this.txtBox_NumberOfAccount);
            this.groupBox_Statistics.Controls.Add(this.lb_NumberOfCustomer);
            this.groupBox_Statistics.Controls.Add(this.lb_NumberOfProduct);
            this.groupBox_Statistics.Controls.Add(this.lb_NumberOfAccount);
            this.groupBox_Statistics.Controls.Add(this.NumberOfStaff);
            this.groupBox_Statistics.Location = new System.Drawing.Point(467, 42);
            this.groupBox_Statistics.Name = "groupBox_Statistics";
            this.groupBox_Statistics.Size = new System.Drawing.Size(393, 187);
            this.groupBox_Statistics.TabIndex = 2;
            this.groupBox_Statistics.TabStop = false;
            this.groupBox_Statistics.Text = "Thống kê";
            // 
            // NumberOfStaff
            // 
            this.NumberOfStaff.AutoSize = true;
            this.NumberOfStaff.Location = new System.Drawing.Point(35, 72);
            this.NumberOfStaff.Name = "NumberOfStaff";
            this.NumberOfStaff.Size = new System.Drawing.Size(151, 21);
            this.NumberOfStaff.TabIndex = 0;
            this.NumberOfStaff.Text = "Tổng số nhân viên:";
            // 
            // lb_NumberOfAccount
            // 
            this.lb_NumberOfAccount.AutoSize = true;
            this.lb_NumberOfAccount.Location = new System.Drawing.Point(35, 38);
            this.lb_NumberOfAccount.Name = "lb_NumberOfAccount";
            this.lb_NumberOfAccount.Size = new System.Drawing.Size(235, 21);
            this.lb_NumberOfAccount.TabIndex = 1;
            this.lb_NumberOfAccount.Text = "Tổng số tài khoản người dùng:";
            // 
            // lb_NumberOfProduct
            // 
            this.lb_NumberOfProduct.AutoSize = true;
            this.lb_NumberOfProduct.Location = new System.Drawing.Point(35, 108);
            this.lb_NumberOfProduct.Name = "lb_NumberOfProduct";
            this.lb_NumberOfProduct.Size = new System.Drawing.Size(152, 21);
            this.lb_NumberOfProduct.TabIndex = 2;
            this.lb_NumberOfProduct.Text = "Tổng số sản phẩm:";
            // 
            // lb_NumberOfCustomer
            // 
            this.lb_NumberOfCustomer.AutoSize = true;
            this.lb_NumberOfCustomer.Location = new System.Drawing.Point(35, 143);
            this.lb_NumberOfCustomer.Name = "lb_NumberOfCustomer";
            this.lb_NumberOfCustomer.Size = new System.Drawing.Size(164, 21);
            this.lb_NumberOfCustomer.TabIndex = 3;
            this.lb_NumberOfCustomer.Text = "Tổng số khách hàng:";
            // 
            // txtBox_NumberOfAccount
            // 
            this.txtBox_NumberOfAccount.Location = new System.Drawing.Point(276, 35);
            this.txtBox_NumberOfAccount.Name = "txtBox_NumberOfAccount";
            this.txtBox_NumberOfAccount.ReadOnly = true;
            this.txtBox_NumberOfAccount.Size = new System.Drawing.Size(98, 28);
            this.txtBox_NumberOfAccount.TabIndex = 8;
            // 
            // txtBox_NumberOfStaff
            // 
            this.txtBox_NumberOfStaff.Location = new System.Drawing.Point(276, 69);
            this.txtBox_NumberOfStaff.Name = "txtBox_NumberOfStaff";
            this.txtBox_NumberOfStaff.ReadOnly = true;
            this.txtBox_NumberOfStaff.Size = new System.Drawing.Size(98, 28);
            this.txtBox_NumberOfStaff.TabIndex = 9;
            // 
            // txtBox_NumberOfProduct
            // 
            this.txtBox_NumberOfProduct.Location = new System.Drawing.Point(276, 105);
            this.txtBox_NumberOfProduct.Name = "txtBox_NumberOfProduct";
            this.txtBox_NumberOfProduct.ReadOnly = true;
            this.txtBox_NumberOfProduct.Size = new System.Drawing.Size(98, 28);
            this.txtBox_NumberOfProduct.TabIndex = 10;
            // 
            // txtBox_NumberOfCustomer
            // 
            this.txtBox_NumberOfCustomer.Location = new System.Drawing.Point(276, 140);
            this.txtBox_NumberOfCustomer.Name = "txtBox_NumberOfCustomer";
            this.txtBox_NumberOfCustomer.ReadOnly = true;
            this.txtBox_NumberOfCustomer.Size = new System.Drawing.Size(98, 28);
            this.txtBox_NumberOfCustomer.TabIndex = 11;
            // 
            // panel_Report
            // 
            this.panel_Report.Controls.Add(this.groupBox_ReportOfProduct);
            this.panel_Report.Location = new System.Drawing.Point(12, 248);
            this.panel_Report.Name = "panel_Report";
            this.panel_Report.Size = new System.Drawing.Size(848, 249);
            this.panel_Report.TabIndex = 3;
            // 
            // groupBox_ReportOfProduct
            // 
            this.groupBox_ReportOfProduct.Controls.Add(this.listView_Product);
            this.groupBox_ReportOfProduct.Location = new System.Drawing.Point(18, 13);
            this.groupBox_ReportOfProduct.Name = "groupBox_ReportOfProduct";
            this.groupBox_ReportOfProduct.Size = new System.Drawing.Size(811, 215);
            this.groupBox_ReportOfProduct.TabIndex = 0;
            this.groupBox_ReportOfProduct.TabStop = false;
            this.groupBox_ReportOfProduct.Text = "Top 5 sản phẩm bán chạy";
            // 
            // listView_Product
            // 
            this.listView_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.PriceOfProduct,
            this.QuantitySold});
            this.listView_Product.GridLines = true;
            this.listView_Product.HideSelection = false;
            this.listView_Product.Location = new System.Drawing.Point(13, 27);
            this.listView_Product.Name = "listView_Product";
            this.listView_Product.Size = new System.Drawing.Size(780, 172);
            this.listView_Product.TabIndex = 0;
            this.listView_Product.UseCompatibleStateImageBehavior = false;
            this.listView_Product.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Mã sản phẩm";
            this.ProductID.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Tên sản phẩm";
            this.ProductName.Width = 344;
            // 
            // PriceOfProduct
            // 
            this.PriceOfProduct.Text = "Giá sản phẩm";
            this.PriceOfProduct.Width = 132;
            // 
            // QuantitySold
            // 
            this.QuantitySold.Text = "Số lượng đã bán";
            this.QuantitySold.Width = 140;
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
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 517);
            this.Controls.Add(this.panel_Report);
            this.Controls.Add(this.groupBox_Statistics);
            this.Controls.Add(this.groupBox_UserInformation);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Quản trị hệ thống cửa hàng điện thoại và phụ kiện - Admin";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_UserInformation.ResumeLayout(false);
            this.groupBox_UserInformation.PerformLayout();
            this.groupBox_Statistics.ResumeLayout(false);
            this.groupBox_Statistics.PerformLayout();
            this.panel_Report.ResumeLayout(false);
            this.groupBox_ReportOfProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềChúngTôiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_UserInformation;
        private System.Windows.Forms.Label lb_AdminName;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.TextBox txtBox_Birthday;
        private System.Windows.Forms.TextBox txtBox_AdminName;
        private System.Windows.Forms.TextBox txtBox_UserLogin;
        private System.Windows.Forms.Label lb_UserLogin;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.GroupBox groupBox_Statistics;
        private System.Windows.Forms.Label lb_NumberOfCustomer;
        private System.Windows.Forms.Label lb_NumberOfProduct;
        private System.Windows.Forms.Label lb_NumberOfAccount;
        private System.Windows.Forms.Label NumberOfStaff;
        private System.Windows.Forms.TextBox txtBox_NumberOfCustomer;
        private System.Windows.Forms.TextBox txtBox_NumberOfProduct;
        private System.Windows.Forms.TextBox txtBox_NumberOfStaff;
        private System.Windows.Forms.TextBox txtBox_NumberOfAccount;
        private System.Windows.Forms.Panel panel_Report;
        private System.Windows.Forms.GroupBox groupBox_ReportOfProduct;
        private System.Windows.Forms.ListView listView_Product;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader PriceOfProduct;
        private System.Windows.Forms.ColumnHeader QuantitySold;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
    }
}