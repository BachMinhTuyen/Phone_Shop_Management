namespace PhoneShopManagement.AdminArea
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
            this.lb_TotalStaff = new System.Windows.Forms.Label();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.comboBox_ColumnStaff = new System.Windows.Forms.ComboBox();
            this.lb_Sort = new System.Windows.Forms.Label();
            this.lb_By = new System.Windows.Forms.Label();
            this.comboBox_SortMethod = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.listView_Staff = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.groupBox_Operation.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            this.panel_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_TotalStaff
            // 
            this.txtBox_TotalStaff.Location = new System.Drawing.Point(1448, 136);
            this.txtBox_TotalStaff.Name = "txtBox_TotalStaff";
            this.txtBox_TotalStaff.ReadOnly = true;
            this.txtBox_TotalStaff.Size = new System.Drawing.Size(98, 28);
            this.txtBox_TotalStaff.TabIndex = 48;
            // 
            // lb_TotalStaff
            // 
            this.lb_TotalStaff.AutoSize = true;
            this.lb_TotalStaff.Location = new System.Drawing.Point(1312, 139);
            this.lb_TotalStaff.Name = "lb_TotalStaff";
            this.lb_TotalStaff.Size = new System.Drawing.Size(129, 21);
            this.lb_TotalStaff.TabIndex = 49;
            this.lb_TotalStaff.Text = "Tổng nhân viên:";
            // 
            // groupBox_Operation
            // 
            this.groupBox_Operation.Controls.Add(this.btn_Clear);
            this.groupBox_Operation.Controls.Add(this.btn_Delete);
            this.groupBox_Operation.Controls.Add(this.btn_Update);
            this.groupBox_Operation.Controls.Add(this.btn_Insert);
            this.groupBox_Operation.Location = new System.Drawing.Point(96, 324);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Size = new System.Drawing.Size(335, 153);
            this.groupBox_Operation.TabIndex = 47;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(179, 88);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(97, 45);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(51, 88);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(97, 45);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(179, 37);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 45);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(51, 37);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(97, 45);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // panel_Filter
            // 
            this.panel_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Filter.Controls.Add(this.btn_DefaultFilter);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Controls.Add(this.comboBox_ColumnStaff);
            this.panel_Filter.Controls.Add(this.lb_Sort);
            this.panel_Filter.Controls.Add(this.lb_By);
            this.panel_Filter.Controls.Add(this.comboBox_SortMethod);
            this.panel_Filter.Location = new System.Drawing.Point(533, 37);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(442, 104);
            this.panel_Filter.TabIndex = 46;
            // 
            // comboBox_ColumnStaff
            // 
            this.comboBox_ColumnStaff.FormattingEnabled = true;
            this.comboBox_ColumnStaff.Location = new System.Drawing.Point(291, 14);
            this.comboBox_ColumnStaff.Name = "comboBox_ColumnStaff";
            this.comboBox_ColumnStaff.Size = new System.Drawing.Size(129, 29);
            this.comboBox_ColumnStaff.TabIndex = 36;
            // 
            // lb_Sort
            // 
            this.lb_Sort.AutoSize = true;
            this.lb_Sort.Location = new System.Drawing.Point(11, 17);
            this.lb_Sort.Name = "lb_Sort";
            this.lb_Sort.Size = new System.Drawing.Size(74, 21);
            this.lb_Sort.TabIndex = 33;
            this.lb_Sort.Text = "Sắp xếp:";
            // 
            // lb_By
            // 
            this.lb_By.AutoSize = true;
            this.lb_By.Location = new System.Drawing.Point(232, 17);
            this.lb_By.Name = "lb_By";
            this.lb_By.Size = new System.Drawing.Size(43, 21);
            this.lb_By.TabIndex = 35;
            this.lb_By.Text = "theo";
            // 
            // comboBox_SortMethod
            // 
            this.comboBox_SortMethod.FormattingEnabled = true;
            this.comboBox_SortMethod.Location = new System.Drawing.Point(106, 14);
            this.comboBox_SortMethod.Name = "comboBox_SortMethod";
            this.comboBox_SortMethod.Size = new System.Drawing.Size(109, 29);
            this.comboBox_SortMethod.TabIndex = 34;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1316, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 28);
            this.btn_Search.TabIndex = 45;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(1002, 74);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(281, 28);
            this.txtBox_Search.TabIndex = 43;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(998, 49);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(160, 21);
            this.lb_Search.TabIndex = 44;
            this.lb_Search.Text = "Tìm kiếm nhân viên:";
            // 
            // listView_Staff
            // 
            this.listView_Staff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.CustomerName,
            this.DateOfBirth,
            this.PhoneNumber,
            this.EmailAddress,
            this.Address});
            this.listView_Staff.HideSelection = false;
            this.listView_Staff.Location = new System.Drawing.Point(533, 170);
            this.listView_Staff.Name = "listView_Staff";
            this.listView_Staff.Size = new System.Drawing.Size(1025, 356);
            this.listView_Staff.TabIndex = 42;
            this.listView_Staff.UseCompatibleStateImageBehavior = false;
            this.listView_Staff.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Mã khách hàng";
            this.CustomerID.Width = 132;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Tên khách hàng";
            this.CustomerName.Width = 197;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "Ngày sinh";
            this.DateOfBirth.Width = 121;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Số điện thoại";
            this.PhoneNumber.Width = 161;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Text = "Email";
            this.EmailAddress.Width = 179;
            // 
            // Address
            // 
            this.Address.Text = "Địa chỉ";
            this.Address.Width = 213;
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
            this.panel_Information.Location = new System.Drawing.Point(12, 37);
            this.panel_Information.Name = "panel_Information";
            this.panel_Information.Size = new System.Drawing.Size(496, 252);
            this.panel_Information.TabIndex = 41;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(177, 211);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(294, 28);
            this.txtBox_Address.TabIndex = 30;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(19, 214);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(67, 21);
            this.lb_Address.TabIndex = 29;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(177, 174);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(294, 28);
            this.txtBox_Email.TabIndex = 28;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(177, 100);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(294, 28);
            this.dateTimePicker_DateOfBirth.TabIndex = 27;
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(177, 139);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(294, 28);
            this.txtBox_PhoneNumber.TabIndex = 20;
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Location = new System.Drawing.Point(177, 58);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(294, 28);
            this.txtBox_CustomerName.TabIndex = 17;
            // 
            // txtBox_CustomerID
            // 
            this.txtBox_CustomerID.Location = new System.Drawing.Point(177, 21);
            this.txtBox_CustomerID.Name = "txtBox_CustomerID";
            this.txtBox_CustomerID.Size = new System.Drawing.Size(294, 28);
            this.txtBox_CustomerID.TabIndex = 16;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(19, 177);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(57, 21);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Email:";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(17, 142);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.lb_PhoneNumber.TabIndex = 10;
            this.lb_PhoneNumber.Text = "Số điện thoại:";
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Location = new System.Drawing.Point(17, 101);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(88, 21);
            this.lb_DateOfBirth.TabIndex = 9;
            this.lb_DateOfBirth.Text = "Ngày sinh:";
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Location = new System.Drawing.Point(17, 61);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(133, 21);
            this.lb_CustomerName.TabIndex = 7;
            this.lb_CustomerName.Text = "Tên khách hàng:";
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.AutoSize = true;
            this.lb_CustomerID.Location = new System.Drawing.Point(17, 24);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(127, 21);
            this.lb_CustomerID.TabIndex = 6;
            this.lb_CustomerID.Text = "Mã khách hàng:";
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(106, 61);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 33);
            this.btn_Filter.TabIndex = 37;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(236, 61);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(100, 33);
            this.btn_DefaultFilter.TabIndex = 38;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1569, 548);
            this.Controls.Add(this.txtBox_TotalStaff);
            this.Controls.Add(this.lb_TotalStaff);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.listView_Staff);
            this.Controls.Add(this.panel_Information);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomer";
            this.Text = "Quản lý khách hàng";
            this.groupBox_Operation.ResumeLayout(false);
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.panel_Information.ResumeLayout(false);
            this.panel_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_TotalStaff;
        private System.Windows.Forms.Label lb_TotalStaff;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.ComboBox comboBox_ColumnStaff;
        private System.Windows.Forms.Label lb_Sort;
        private System.Windows.Forms.Label lb_By;
        private System.Windows.Forms.ComboBox comboBox_SortMethod;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.ListView listView_Staff;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader Address;
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
        private System.Windows.Forms.Button btn_DefaultFilter;
        private System.Windows.Forms.Button btn_Filter;
    }
}