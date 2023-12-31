﻿namespace PhoneShopManagement.AdminArea
{
    partial class frmCustomer
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
            this.txtBox_TotalStaff = new System.Windows.Forms.TextBox();
            this.lb_TotalCustomer = new System.Windows.Forms.Label();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.panel_Information = new System.Windows.Forms.Panel();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.txtBox_CustomerID = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.lb_CustomerID = new System.Windows.Forms.Label();
            this.dataGridView_CustomerList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Operation.SuspendLayout();
            this.panel_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_TotalStaff
            // 
            this.txtBox_TotalStaff.Location = new System.Drawing.Point(1255, 51);
            this.txtBox_TotalStaff.Name = "txtBox_TotalStaff";
            this.txtBox_TotalStaff.ReadOnly = true;
            this.txtBox_TotalStaff.Size = new System.Drawing.Size(88, 26);
            this.txtBox_TotalStaff.TabIndex = 48;
            // 
            // lb_TotalCustomer
            // 
            this.lb_TotalCustomer.AutoSize = true;
            this.lb_TotalCustomer.Location = new System.Drawing.Point(1134, 53);
            this.lb_TotalCustomer.Name = "lb_TotalCustomer";
            this.lb_TotalCustomer.Size = new System.Drawing.Size(127, 18);
            this.lb_TotalCustomer.TabIndex = 49;
            this.lb_TotalCustomer.Text = "Tổng khách hàng:";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Update);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(85, 278);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(298, 131);
            this.groupBox_Operation.TabIndex = 47;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(159, 75);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 39);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(45, 75);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 39);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(159, 32);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 39);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(45, 32);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(86, 39);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(768, 53);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 24);
            this.btn_Search.TabIndex = 45;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(489, 53);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(250, 26);
            this.txtBox_Search.TabIndex = 43;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(485, 32);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(179, 18);
            this.lb_Search.TabIndex = 44;
            this.lb_Search.Text = "Tìm kiếm tên khách hàng:";
            // 
            // panel_Information
            // 
            this.panel_Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Information.Controls.Add(this.txtBox_Address);
            this.panel_Information.Controls.Add(this.lb_Address);
            this.panel_Information.Controls.Add(this.txtBox_Email);
            this.panel_Information.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.panel_Information.Controls.Add(this.txtBox_PhoneNumber);
            this.panel_Information.Controls.Add(this.txtBox_CustomerName);
            this.panel_Information.Controls.Add(this.txtBox_CustomerID);
            this.panel_Information.Controls.Add(this.lb_Email);
            this.panel_Information.Controls.Add(this.lb_PhoneNumber);
            this.panel_Information.Controls.Add(this.lb_DateOfBirth);
            this.panel_Information.Controls.Add(this.lb_CustomerName);
            this.panel_Information.Controls.Add(this.lb_CustomerID);
            this.panel_Information.Location = new System.Drawing.Point(11, 32);
            this.panel_Information.Name = "panel_Information";
            this.panel_Information.Size = new System.Drawing.Size(441, 216);
            this.panel_Information.TabIndex = 41;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(157, 181);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(262, 26);
            this.txtBox_Address.TabIndex = 30;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(17, 183);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(55, 18);
            this.lb_Address.TabIndex = 29;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(157, 149);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(262, 26);
            this.txtBox_Email.TabIndex = 28;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(157, 86);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker_DateOfBirth.TabIndex = 27;
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(157, 119);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(262, 26);
            this.txtBox_PhoneNumber.TabIndex = 20;
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Location = new System.Drawing.Point(157, 50);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(262, 26);
            this.txtBox_CustomerName.TabIndex = 17;
            // 
            // txtBox_CustomerID
            // 
            this.txtBox_CustomerID.Location = new System.Drawing.Point(157, 18);
            this.txtBox_CustomerID.Name = "txtBox_CustomerID";
            this.txtBox_CustomerID.Size = new System.Drawing.Size(262, 26);
            this.txtBox_CustomerID.TabIndex = 16;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(17, 152);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 18);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Email:";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(15, 122);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(97, 18);
            this.lb_PhoneNumber.TabIndex = 10;
            this.lb_PhoneNumber.Text = "Số điện thoại:";
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Location = new System.Drawing.Point(15, 87);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(77, 18);
            this.lb_DateOfBirth.TabIndex = 9;
            this.lb_DateOfBirth.Text = "Ngày sinh:";
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Location = new System.Drawing.Point(15, 52);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(119, 18);
            this.lb_CustomerName.TabIndex = 7;
            this.lb_CustomerName.Text = "Tên khách hàng:";
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.AutoSize = true;
            this.lb_CustomerID.Location = new System.Drawing.Point(15, 21);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(113, 18);
            this.lb_CustomerID.TabIndex = 6;
            this.lb_CustomerID.Text = "Mã khách hàng:";
            // 
            // dataGridView_CustomerList
            // 
            this.dataGridView_CustomerList.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_CustomerList.Location = new System.Drawing.Point(474, 92);
            this.dataGridView_CustomerList.Name = "dataGridView_CustomerList";
            this.dataGridView_CustomerList.RowHeadersWidth = 51;
            this.dataGridView_CustomerList.RowTemplate.Height = 24;
            this.dataGridView_CustomerList.Size = new System.Drawing.Size(900, 368);
            this.dataGridView_CustomerList.TabIndex = 50;
            this.dataGridView_CustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CustomerList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã khách hàng ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1395, 470);
            this.Controls.Add(this.dataGridView_CustomerList);
            this.Controls.Add(this.txtBox_TotalStaff);
            this.Controls.Add(this.lb_TotalCustomer);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.panel_Information);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCustomer";
            this.Text = "Quản lý khách hàng";
            this.groupBox_Operation.ResumeLayout(false);
            this.panel_Information.ResumeLayout(false);
            this.panel_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_TotalStaff;
        private System.Windows.Forms.Label lb_TotalCustomer;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Panel panel_Information;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_CustomerName;
        private System.Windows.Forms.TextBox txtBox_CustomerID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.Label lb_CustomerID;
        private System.Windows.Forms.DataGridView dataGridView_CustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}