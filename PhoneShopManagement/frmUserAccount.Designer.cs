namespace PhoneShopManagement
{
    partial class frmUserAccount
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
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Statistics = new System.Windows.Forms.GroupBox();
            this.txtBox_TotalStaffAccount = new System.Windows.Forms.TextBox();
            this.txtBox_TotalAdminAccount = new System.Windows.Forms.TextBox();
            this.txtBox_TotalAll = new System.Windows.Forms.TextBox();
            this.lb_TotalStaffAccount = new System.Windows.Forms.Label();
            this.lb_TotalAdminAccount = new System.Windows.Forms.Label();
            this.lb_TotalAll = new System.Windows.Forms.Label();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.panel_Information = new System.Windows.Forms.Panel();
            this.txtBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.groupBox_Roles = new System.Windows.Forms.GroupBox();
            this.radioBtn_User = new System.Windows.Forms.RadioButton();
            this.radioBtn_Admin = new System.Windows.Forms.RadioButton();
            this.lb_ConfirmPassword = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.listView_Account = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumericalOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Statistics.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            this.panel_Information.SuspendLayout();
            this.groupBox_Roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(888, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xoáToolStripMenuItem,
            this.làmMớiToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.xoáToolStripMenuItem.Text = "Xoá";
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // groupBox_Statistics
            // 
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalStaffAccount);
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalAdminAccount);
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalAll);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalStaffAccount);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalAdminAccount);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalAll);
            this.groupBox_Statistics.Location = new System.Drawing.Point(31, 47);
            this.groupBox_Statistics.Name = "groupBox_Statistics";
            this.groupBox_Statistics.Size = new System.Drawing.Size(377, 142);
            this.groupBox_Statistics.TabIndex = 1;
            this.groupBox_Statistics.TabStop = false;
            this.groupBox_Statistics.Text = "Thống kê";
            // 
            // txtBox_TotalStaffAccount
            // 
            this.txtBox_TotalStaffAccount.Location = new System.Drawing.Point(262, 99);
            this.txtBox_TotalStaffAccount.Name = "txtBox_TotalStaffAccount";
            this.txtBox_TotalStaffAccount.ReadOnly = true;
            this.txtBox_TotalStaffAccount.Size = new System.Drawing.Size(102, 28);
            this.txtBox_TotalStaffAccount.TabIndex = 5;
            // 
            // txtBox_TotalAdminAccount
            // 
            this.txtBox_TotalAdminAccount.Location = new System.Drawing.Point(262, 65);
            this.txtBox_TotalAdminAccount.Name = "txtBox_TotalAdminAccount";
            this.txtBox_TotalAdminAccount.ReadOnly = true;
            this.txtBox_TotalAdminAccount.Size = new System.Drawing.Size(102, 28);
            this.txtBox_TotalAdminAccount.TabIndex = 4;
            // 
            // txtBox_TotalAll
            // 
            this.txtBox_TotalAll.Location = new System.Drawing.Point(262, 30);
            this.txtBox_TotalAll.Name = "txtBox_TotalAll";
            this.txtBox_TotalAll.ReadOnly = true;
            this.txtBox_TotalAll.Size = new System.Drawing.Size(102, 28);
            this.txtBox_TotalAll.TabIndex = 3;
            // 
            // lb_TotalStaffAccount
            // 
            this.lb_TotalStaffAccount.AutoSize = true;
            this.lb_TotalStaffAccount.Location = new System.Drawing.Point(33, 102);
            this.lb_TotalStaffAccount.Name = "lb_TotalStaffAccount";
            this.lb_TotalStaffAccount.Size = new System.Drawing.Size(224, 21);
            this.lb_TotalStaffAccount.TabIndex = 2;
            this.lb_TotalStaffAccount.Text = "Tổng số tài khoản nhân viên:";
            // 
            // lb_TotalAdminAccount
            // 
            this.lb_TotalAdminAccount.AutoSize = true;
            this.lb_TotalAdminAccount.Location = new System.Drawing.Point(33, 68);
            this.lb_TotalAdminAccount.Name = "lb_TotalAdminAccount";
            this.lb_TotalAdminAccount.Size = new System.Drawing.Size(210, 21);
            this.lb_TotalAdminAccount.TabIndex = 1;
            this.lb_TotalAdminAccount.Text = "Tổng số tài khoản quản trị:";
            // 
            // lb_TotalAll
            // 
            this.lb_TotalAll.AutoSize = true;
            this.lb_TotalAll.Location = new System.Drawing.Point(33, 33);
            this.lb_TotalAll.Name = "lb_TotalAll";
            this.lb_TotalAll.Size = new System.Drawing.Size(196, 21);
            this.lb_TotalAll.TabIndex = 0;
            this.lb_TotalAll.Text = "Tổng số tất cả tài khoản:";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Update);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(414, 77);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(447, 89);
            this.groupBox_Operation.TabIndex = 2;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(338, 35);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 35);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(231, 35);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 35);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(123, 35);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 35);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(14, 35);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 35);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // panel_Information
            // 
            this.panel_Information.Controls.Add(this.txtBox_ConfirmPassword);
            this.panel_Information.Controls.Add(this.txtBox_Password);
            this.panel_Information.Controls.Add(this.txtBox_UserName);
            this.panel_Information.Controls.Add(this.groupBox_Roles);
            this.panel_Information.Controls.Add(this.lb_ConfirmPassword);
            this.panel_Information.Controls.Add(this.lb_Password);
            this.panel_Information.Controls.Add(this.lb_UserName);
            this.panel_Information.Location = new System.Drawing.Point(31, 195);
            this.panel_Information.Name = "panel_Information";
            this.panel_Information.Size = new System.Drawing.Size(830, 144);
            this.panel_Information.TabIndex = 3;
            // 
            // txtBox_ConfirmPassword
            // 
            this.txtBox_ConfirmPassword.Location = new System.Drawing.Point(578, 95);
            this.txtBox_ConfirmPassword.Name = "txtBox_ConfirmPassword";
            this.txtBox_ConfirmPassword.Size = new System.Drawing.Size(237, 28);
            this.txtBox_ConfirmPassword.TabIndex = 7;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(151, 92);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(237, 28);
            this.txtBox_Password.TabIndex = 6;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Location = new System.Drawing.Point(151, 37);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(237, 28);
            this.txtBox_UserName.TabIndex = 5;
            // 
            // groupBox_Roles
            // 
            this.groupBox_Roles.Controls.Add(this.radioBtn_User);
            this.groupBox_Roles.Controls.Add(this.radioBtn_Admin);
            this.groupBox_Roles.Location = new System.Drawing.Point(415, 13);
            this.groupBox_Roles.Name = "groupBox_Roles";
            this.groupBox_Roles.Size = new System.Drawing.Size(400, 73);
            this.groupBox_Roles.TabIndex = 4;
            this.groupBox_Roles.TabStop = false;
            this.groupBox_Roles.Text = "Vai trò";
            // 
            // radioBtn_User
            // 
            this.radioBtn_User.AutoSize = true;
            this.radioBtn_User.Location = new System.Drawing.Point(255, 27);
            this.radioBtn_User.Name = "radioBtn_User";
            this.radioBtn_User.Size = new System.Drawing.Size(65, 25);
            this.radioBtn_User.TabIndex = 4;
            this.radioBtn_User.TabStop = true;
            this.radioBtn_User.Text = "User";
            this.radioBtn_User.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Admin
            // 
            this.radioBtn_Admin.AutoSize = true;
            this.radioBtn_Admin.Location = new System.Drawing.Point(82, 27);
            this.radioBtn_Admin.Name = "radioBtn_Admin";
            this.radioBtn_Admin.Size = new System.Drawing.Size(78, 25);
            this.radioBtn_Admin.TabIndex = 3;
            this.radioBtn_Admin.TabStop = true;
            this.radioBtn_Admin.Text = "Admin";
            this.radioBtn_Admin.UseVisualStyleBackColor = true;
            // 
            // lb_ConfirmPassword
            // 
            this.lb_ConfirmPassword.AutoSize = true;
            this.lb_ConfirmPassword.Location = new System.Drawing.Point(411, 98);
            this.lb_ConfirmPassword.Name = "lb_ConfirmPassword";
            this.lb_ConfirmPassword.Size = new System.Drawing.Size(150, 21);
            this.lb_ConfirmPassword.TabIndex = 2;
            this.lb_ConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(14, 95);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(84, 21);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(14, 40);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(127, 21);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "Tên đăng nhập:";
            // 
            // listView_Account
            // 
            this.listView_Account.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumericalOrder,
            this.UserName,
            this.Password,
            this.Role});
            this.listView_Account.GridLines = true;
            this.listView_Account.HideSelection = false;
            this.listView_Account.Location = new System.Drawing.Point(31, 345);
            this.listView_Account.Name = "listView_Account";
            this.listView_Account.Size = new System.Drawing.Size(830, 284);
            this.listView_Account.TabIndex = 4;
            this.listView_Account.UseCompatibleStateImageBehavior = false;
            this.listView_Account.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "User Name";
            this.UserName.Width = 176;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 232;
            // 
            // Role
            // 
            this.Role.Text = "Vai trò";
            this.Role.Width = 179;
            // 
            // NumericalOrder
            // 
            this.NumericalOrder.Text = "Số thứ tự";
            this.NumericalOrder.Width = 93;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 664);
            this.Controls.Add(this.listView_Account);
            this.Controls.Add(this.panel_Information);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.groupBox_Statistics);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserAccount";
            this.Text = "Quản lý tài khoản người dùng";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Statistics.ResumeLayout(false);
            this.groupBox_Statistics.PerformLayout();
            this.groupBox_Operation.ResumeLayout(false);
            this.panel_Information.ResumeLayout(false);
            this.panel_Information.PerformLayout();
            this.groupBox_Roles.ResumeLayout(false);
            this.groupBox_Roles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Statistics;
        private System.Windows.Forms.Label lb_TotalStaffAccount;
        private System.Windows.Forms.Label lb_TotalAdminAccount;
        private System.Windows.Forms.Label lb_TotalAll;
        private System.Windows.Forms.TextBox txtBox_TotalStaffAccount;
        private System.Windows.Forms.TextBox txtBox_TotalAdminAccount;
        private System.Windows.Forms.TextBox txtBox_TotalAll;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel panel_Information;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_ConfirmPassword;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.GroupBox groupBox_Roles;
        private System.Windows.Forms.RadioButton radioBtn_User;
        private System.Windows.Forms.RadioButton radioBtn_Admin;
        private System.Windows.Forms.TextBox txtBox_ConfirmPassword;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.ListView listView_Account;
        private System.Windows.Forms.ColumnHeader NumericalOrder;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Role;
    }
}