﻿namespace PhoneShopManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_ChangeRole = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
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
            this.dataGridView_AccountList = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khôiPhụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Statistics.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            this.panel_Information.SuspendLayout();
            this.groupBox_Roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountList)).BeginInit();
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
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(789, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.khôiPhụcToolStripMenuItem,
            this.xoáToolStripMenuItem,
            this.làmMớiToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sửaToolStripMenuItem.Text = "Đổi vai trò";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xoáToolStripMenuItem.Text = "Xoá";
            this.xoáToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox_Statistics
            // 
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalStaffAccount);
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalAdminAccount);
            this.groupBox_Statistics.Controls.Add(this.txtBox_TotalAll);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalStaffAccount);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalAdminAccount);
            this.groupBox_Statistics.Controls.Add(this.lb_TotalAll);
            this.groupBox_Statistics.Location = new System.Drawing.Point(28, 40);
            this.groupBox_Statistics.Name = "groupBox_Statistics";
            this.groupBox_Statistics.Size = new System.Drawing.Size(335, 122);
            this.groupBox_Statistics.TabIndex = 1;
            this.groupBox_Statistics.TabStop = false;
            this.groupBox_Statistics.Text = "Thống kê";
            // 
            // txtBox_TotalStaffAccount
            // 
            this.txtBox_TotalStaffAccount.Location = new System.Drawing.Point(233, 85);
            this.txtBox_TotalStaffAccount.Name = "txtBox_TotalStaffAccount";
            this.txtBox_TotalStaffAccount.ReadOnly = true;
            this.txtBox_TotalStaffAccount.Size = new System.Drawing.Size(91, 26);
            this.txtBox_TotalStaffAccount.TabIndex = 5;
            // 
            // txtBox_TotalAdminAccount
            // 
            this.txtBox_TotalAdminAccount.Location = new System.Drawing.Point(233, 56);
            this.txtBox_TotalAdminAccount.Name = "txtBox_TotalAdminAccount";
            this.txtBox_TotalAdminAccount.ReadOnly = true;
            this.txtBox_TotalAdminAccount.Size = new System.Drawing.Size(91, 26);
            this.txtBox_TotalAdminAccount.TabIndex = 4;
            // 
            // txtBox_TotalAll
            // 
            this.txtBox_TotalAll.Location = new System.Drawing.Point(233, 26);
            this.txtBox_TotalAll.Name = "txtBox_TotalAll";
            this.txtBox_TotalAll.ReadOnly = true;
            this.txtBox_TotalAll.Size = new System.Drawing.Size(91, 26);
            this.txtBox_TotalAll.TabIndex = 3;
            // 
            // lb_TotalStaffAccount
            // 
            this.lb_TotalStaffAccount.AutoSize = true;
            this.lb_TotalStaffAccount.Location = new System.Drawing.Point(29, 87);
            this.lb_TotalStaffAccount.Name = "lb_TotalStaffAccount";
            this.lb_TotalStaffAccount.Size = new System.Drawing.Size(199, 18);
            this.lb_TotalStaffAccount.TabIndex = 2;
            this.lb_TotalStaffAccount.Text = "Tổng số tài khoản nhân viên:";
            // 
            // lb_TotalAdminAccount
            // 
            this.lb_TotalAdminAccount.AutoSize = true;
            this.lb_TotalAdminAccount.Location = new System.Drawing.Point(29, 58);
            this.lb_TotalAdminAccount.Name = "lb_TotalAdminAccount";
            this.lb_TotalAdminAccount.Size = new System.Drawing.Size(185, 18);
            this.lb_TotalAdminAccount.TabIndex = 1;
            this.lb_TotalAdminAccount.Text = "Tổng số tài khoản quản trị:";
            // 
            // lb_TotalAll
            // 
            this.lb_TotalAll.AutoSize = true;
            this.lb_TotalAll.Location = new System.Drawing.Point(29, 28);
            this.lb_TotalAll.Name = "lb_TotalAll";
            this.lb_TotalAll.Size = new System.Drawing.Size(174, 18);
            this.lb_TotalAll.TabIndex = 0;
            this.lb_TotalAll.Text = "Tổng số tất cả tài khoản:";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_ChangeRole);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Reset);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(368, 66);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(397, 76);
            this.groupBox_Operation.TabIndex = 2;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_ChangeRole
            // 
            this.btn_ChangeRole.Location = new System.Drawing.Point(101, 30);
            this.btn_ChangeRole.Name = "btn_ChangeRole";
            this.btn_ChangeRole.Size = new System.Drawing.Size(94, 30);
            this.btn_ChangeRole.TabIndex = 3;
            this.btn_ChangeRole.Text = "Đổi vai trò";
            this.btn_ChangeRole.UseVisualStyleBackColor = true;
            this.btn_ChangeRole.Click += new System.EventHandler(this.btn_ChangeRole_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(300, 30);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 30);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(206, 30);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(84, 30);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Khôi phục";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(12, 30);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 30);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(484, 40);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(158, 30);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            this.panel_Information.Location = new System.Drawing.Point(28, 167);
            this.panel_Information.Name = "panel_Information";
            this.panel_Information.Size = new System.Drawing.Size(738, 123);
            this.panel_Information.TabIndex = 3;
            // 
            // txtBox_ConfirmPassword
            // 
            this.txtBox_ConfirmPassword.Location = new System.Drawing.Point(514, 81);
            this.txtBox_ConfirmPassword.Name = "txtBox_ConfirmPassword";
            this.txtBox_ConfirmPassword.Size = new System.Drawing.Size(211, 26);
            this.txtBox_ConfirmPassword.TabIndex = 7;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(134, 79);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(211, 26);
            this.txtBox_Password.TabIndex = 6;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Location = new System.Drawing.Point(134, 32);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(211, 26);
            this.txtBox_UserName.TabIndex = 5;
            // 
            // groupBox_Roles
            // 
            this.groupBox_Roles.Controls.Add(this.radioBtn_User);
            this.groupBox_Roles.Controls.Add(this.radioBtn_Admin);
            this.groupBox_Roles.Location = new System.Drawing.Point(369, 11);
            this.groupBox_Roles.Name = "groupBox_Roles";
            this.groupBox_Roles.Size = new System.Drawing.Size(356, 63);
            this.groupBox_Roles.TabIndex = 4;
            this.groupBox_Roles.TabStop = false;
            this.groupBox_Roles.Text = "Vai trò";
            // 
            // radioBtn_User
            // 
            this.radioBtn_User.AutoSize = true;
            this.radioBtn_User.Location = new System.Drawing.Point(227, 23);
            this.radioBtn_User.Name = "radioBtn_User";
            this.radioBtn_User.Size = new System.Drawing.Size(59, 22);
            this.radioBtn_User.TabIndex = 4;
            this.radioBtn_User.TabStop = true;
            this.radioBtn_User.Text = "User";
            this.radioBtn_User.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Admin
            // 
            this.radioBtn_Admin.AutoSize = true;
            this.radioBtn_Admin.Location = new System.Drawing.Point(73, 23);
            this.radioBtn_Admin.Name = "radioBtn_Admin";
            this.radioBtn_Admin.Size = new System.Drawing.Size(69, 22);
            this.radioBtn_Admin.TabIndex = 3;
            this.radioBtn_Admin.TabStop = true;
            this.radioBtn_Admin.Text = "Admin";
            this.radioBtn_Admin.UseVisualStyleBackColor = true;
            // 
            // lb_ConfirmPassword
            // 
            this.lb_ConfirmPassword.AutoSize = true;
            this.lb_ConfirmPassword.Location = new System.Drawing.Point(365, 84);
            this.lb_ConfirmPassword.Name = "lb_ConfirmPassword";
            this.lb_ConfirmPassword.Size = new System.Drawing.Size(131, 18);
            this.lb_ConfirmPassword.TabIndex = 2;
            this.lb_ConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(12, 81);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(74, 18);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(12, 34);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(114, 18);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "Tên đăng nhập:";
            // 
            // dataGridView_AccountList
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AccountList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_AccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_AccountList.Location = new System.Drawing.Point(28, 297);
            this.dataGridView_AccountList.Name = "dataGridView_AccountList";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AccountList.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_AccountList.RowHeadersVisible = false;
            this.dataGridView_AccountList.RowHeadersWidth = 51;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_AccountList.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_AccountList.RowTemplate.Height = 24;
            this.dataGridView_AccountList.Size = new System.Drawing.Size(738, 262);
            this.dataGridView_AccountList.TabIndex = 4;
            this.dataGridView_AccountList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AccountList_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "Số thứ tự";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tài Khoản";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Mật Khẩu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Vai Trò";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // khôiPhụcToolStripMenuItem
            // 
            this.khôiPhụcToolStripMenuItem.Name = "khôiPhụcToolStripMenuItem";
            this.khôiPhụcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.khôiPhụcToolStripMenuItem.Text = "Khôi phục";
            this.khôiPhụcToolStripMenuItem.Click += new System.EventHandler(this.khôiPhụcToolStripMenuItem_Click);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 569);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dataGridView_AccountList);
            this.Controls.Add(this.panel_Information);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.groupBox_Statistics);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip_Main;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountList)).EndInit();
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
        private System.Windows.Forms.Button btn_Reset;
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
        private System.Windows.Forms.DataGridView dataGridView_AccountList;
        private System.Windows.Forms.Button btn_ChangeRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcToolStripMenuItem;
    }
}