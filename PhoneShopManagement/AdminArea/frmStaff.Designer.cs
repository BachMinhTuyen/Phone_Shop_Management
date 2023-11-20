namespace PhoneShopManagement.AdminArea
{
    partial class frmStaff
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
            this.panel_Information = new System.Windows.Forms.Panel();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Staff = new System.Windows.Forms.RadioButton();
            this.radioButton_Manager = new System.Windows.Forms.RadioButton();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBox_StaffName = new System.Windows.Forms.TextBox();
            this.txtBox_StaffID = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.lb_Position = new System.Windows.Forms.Label();
            this.lb_StaffName = new System.Windows.Forms.Label();
            this.lb_StaffID = new System.Windows.Forms.Label();
            this.lb_Search = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.radioButton_FilterStaff = new System.Windows.Forms.RadioButton();
            this.btn_DefaultFilter = new System.Windows.Forms.Button();
            this.radioButton_FilterManager = new System.Windows.Forms.RadioButton();
            this.lb_FilterPosition = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.groupBox_Operation = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txtBox_TotalStaff = new System.Windows.Forms.TextBox();
            this.lb_TotalStaff = new System.Windows.Forms.Label();
            this.dataGridView_StaffList = new System.Windows.Forms.DataGridView();
            this.panel_Information.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            this.groupBox_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Information
            // 
            this.panel_Information.Controls.Add(this.txtBox_Address);
            this.panel_Information.Controls.Add(this.lb_Address);
            this.panel_Information.Controls.Add(this.txtBox_Email);
            this.panel_Information.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.panel_Information.Controls.Add(this.radioButton_Staff);
            this.panel_Information.Controls.Add(this.radioButton_Manager);
            this.panel_Information.Controls.Add(this.txtBox_PhoneNumber);
            this.panel_Information.Controls.Add(this.txtBox_StaffName);
            this.panel_Information.Controls.Add(this.txtBox_StaffID);
            this.panel_Information.Controls.Add(this.lb_Email);
            this.panel_Information.Controls.Add(this.lb_PhoneNumber);
            this.panel_Information.Controls.Add(this.lb_DateOfBirth);
            this.panel_Information.Controls.Add(this.lb_Position);
            this.panel_Information.Controls.Add(this.lb_StaffName);
            this.panel_Information.Controls.Add(this.lb_StaffID);
            this.panel_Information.Location = new System.Drawing.Point(10, 10);
            this.panel_Information.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Information.Name = "panel_Information";
            this.panel_Information.Size = new System.Drawing.Size(441, 252);
            this.panel_Information.TabIndex = 8;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(158, 207);
            this.txtBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(262, 29);
            this.txtBox_Address.TabIndex = 30;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(17, 209);
            this.lb_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(70, 22);
            this.lb_Address.TabIndex = 29;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(158, 174);
            this.txtBox_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(262, 29);
            this.txtBox_Email.TabIndex = 28;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(158, 111);
            this.dateTimePicker_DateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(262, 29);
            this.dateTimePicker_DateOfBirth.TabIndex = 27;
            // 
            // radioButton_Staff
            // 
            this.radioButton_Staff.AutoSize = true;
            this.radioButton_Staff.Location = new System.Drawing.Point(302, 84);
            this.radioButton_Staff.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Staff.Name = "radioButton_Staff";
            this.radioButton_Staff.Size = new System.Drawing.Size(114, 26);
            this.radioButton_Staff.TabIndex = 26;
            this.radioButton_Staff.TabStop = true;
            this.radioButton_Staff.Text = "Nhân viên";
            this.radioButton_Staff.UseVisualStyleBackColor = true;
            // 
            // radioButton_Manager
            // 
            this.radioButton_Manager.AutoSize = true;
            this.radioButton_Manager.Location = new System.Drawing.Point(185, 84);
            this.radioButton_Manager.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Manager.Name = "radioButton_Manager";
            this.radioButton_Manager.Size = new System.Drawing.Size(96, 26);
            this.radioButton_Manager.TabIndex = 25;
            this.radioButton_Manager.TabStop = true;
            this.radioButton_Manager.Text = "Quản lý";
            this.radioButton_Manager.UseVisualStyleBackColor = true;
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(158, 145);
            this.txtBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(262, 29);
            this.txtBox_PhoneNumber.TabIndex = 20;
            // 
            // txtBox_StaffName
            // 
            this.txtBox_StaffName.Location = new System.Drawing.Point(158, 50);
            this.txtBox_StaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_StaffName.Name = "txtBox_StaffName";
            this.txtBox_StaffName.Size = new System.Drawing.Size(262, 29);
            this.txtBox_StaffName.TabIndex = 17;
            // 
            // txtBox_StaffID
            // 
            this.txtBox_StaffID.Location = new System.Drawing.Point(158, 18);
            this.txtBox_StaffID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_StaffID.Name = "txtBox_StaffID";
            this.txtBox_StaffID.Size = new System.Drawing.Size(262, 29);
            this.txtBox_StaffID.TabIndex = 16;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(17, 178);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(58, 22);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Email:";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(17, 147);
            this.lb_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(120, 22);
            this.lb_PhoneNumber.TabIndex = 10;
            this.lb_PhoneNumber.Text = "Số điện thoại:";
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Location = new System.Drawing.Point(17, 117);
            this.lb_DateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(94, 22);
            this.lb_DateOfBirth.TabIndex = 9;
            this.lb_DateOfBirth.Text = "Ngày sinh:";
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(15, 86);
            this.lb_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(81, 22);
            this.lb_Position.TabIndex = 8;
            this.lb_Position.Text = "Chức vụ:";
            // 
            // lb_StaffName
            // 
            this.lb_StaffName.AutoSize = true;
            this.lb_StaffName.Location = new System.Drawing.Point(15, 52);
            this.lb_StaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_StaffName.Name = "lb_StaffName";
            this.lb_StaffName.Size = new System.Drawing.Size(129, 22);
            this.lb_StaffName.TabIndex = 7;
            this.lb_StaffName.Text = "Tên nhân viên:";
            // 
            // lb_StaffID
            // 
            this.lb_StaffID.AutoSize = true;
            this.lb_StaffID.Location = new System.Drawing.Point(15, 20);
            this.lb_StaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_StaffID.Name = "lb_StaffID";
            this.lb_StaffID.Size = new System.Drawing.Size(122, 22);
            this.lb_StaffID.TabIndex = 6;
            this.lb_StaffID.Text = "Mã nhân viên:";
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Location = new System.Drawing.Point(474, 31);
            this.lb_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(203, 22);
            this.lb_Search.TabIndex = 31;
            this.lb_Search.Text = "Tìm kiếm tên nhân viên:";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(654, 29);
            this.txtBox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(250, 29);
            this.txtBox_Search.TabIndex = 31;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(922, 29);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 24);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel_Filter
            // 
            this.panel_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Filter.Controls.Add(this.radioButton_FilterStaff);
            this.panel_Filter.Controls.Add(this.btn_DefaultFilter);
            this.panel_Filter.Controls.Add(this.radioButton_FilterManager);
            this.panel_Filter.Controls.Add(this.lb_FilterPosition);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Location = new System.Drawing.Point(66, 421);
            this.panel_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(331, 101);
            this.panel_Filter.TabIndex = 37;
            // 
            // radioButton_FilterStaff
            // 
            this.radioButton_FilterStaff.AutoSize = true;
            this.radioButton_FilterStaff.Location = new System.Drawing.Point(189, 14);
            this.radioButton_FilterStaff.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_FilterStaff.Name = "radioButton_FilterStaff";
            this.radioButton_FilterStaff.Size = new System.Drawing.Size(114, 26);
            this.radioButton_FilterStaff.TabIndex = 33;
            this.radioButton_FilterStaff.TabStop = true;
            this.radioButton_FilterStaff.Text = "Nhân viên";
            this.radioButton_FilterStaff.UseVisualStyleBackColor = true;
            // 
            // btn_DefaultFilter
            // 
            this.btn_DefaultFilter.Location = new System.Drawing.Point(184, 55);
            this.btn_DefaultFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DefaultFilter.Name = "btn_DefaultFilter";
            this.btn_DefaultFilter.Size = new System.Drawing.Size(89, 35);
            this.btn_DefaultFilter.TabIndex = 38;
            this.btn_DefaultFilter.Text = "Mặc định";
            this.btn_DefaultFilter.UseVisualStyleBackColor = true;
            this.btn_DefaultFilter.Click += new System.EventHandler(this.btn_DefaultFilter_Click);
            // 
            // radioButton_FilterManager
            // 
            this.radioButton_FilterManager.AutoSize = true;
            this.radioButton_FilterManager.Location = new System.Drawing.Point(98, 14);
            this.radioButton_FilterManager.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_FilterManager.Name = "radioButton_FilterManager";
            this.radioButton_FilterManager.Size = new System.Drawing.Size(96, 26);
            this.radioButton_FilterManager.TabIndex = 32;
            this.radioButton_FilterManager.TabStop = true;
            this.radioButton_FilterManager.Text = "Quản lý";
            this.radioButton_FilterManager.UseVisualStyleBackColor = true;
            // 
            // lb_FilterPosition
            // 
            this.lb_FilterPosition.AutoSize = true;
            this.lb_FilterPosition.Location = new System.Drawing.Point(15, 14);
            this.lb_FilterPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_FilterPosition.Name = "lb_FilterPosition";
            this.lb_FilterPosition.Size = new System.Drawing.Size(81, 22);
            this.lb_FilterPosition.TabIndex = 31;
            this.lb_FilterPosition.Text = "Chức vụ:";
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(54, 55);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(89, 35);
            this.btn_Filter.TabIndex = 37;
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
            this.groupBox_Operation.Location = new System.Drawing.Point(85, 275);
            this.groupBox_Operation.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Operation.Name = "groupBox_Operation";
            this.groupBox_Operation.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Operation.Size = new System.Drawing.Size(298, 132);
            this.groupBox_Operation.TabIndex = 38;
            this.groupBox_Operation.TabStop = false;
            this.groupBox_Operation.Text = "Thao tác";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(159, 75);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 38);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(46, 75);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 38);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(159, 32);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 38);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(46, 32);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(86, 38);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txtBox_TotalStaff
            // 
            this.txtBox_TotalStaff.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TotalStaff.Location = new System.Drawing.Point(1280, 28);
            this.txtBox_TotalStaff.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_TotalStaff.Name = "txtBox_TotalStaff";
            this.txtBox_TotalStaff.ReadOnly = true;
            this.txtBox_TotalStaff.Size = new System.Drawing.Size(87, 29);
            this.txtBox_TotalStaff.TabIndex = 39;
            this.txtBox_TotalStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_TotalStaff
            // 
            this.lb_TotalStaff.AutoSize = true;
            this.lb_TotalStaff.Location = new System.Drawing.Point(1160, 30);
            this.lb_TotalStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TotalStaff.Name = "lb_TotalStaff";
            this.lb_TotalStaff.Size = new System.Drawing.Size(140, 22);
            this.lb_TotalStaff.TabIndex = 40;
            this.lb_TotalStaff.Text = "Tổng nhân viên:";
            // 
            // dataGridView_StaffList
            // 
            this.dataGridView_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StaffList.Location = new System.Drawing.Point(467, 78);
            this.dataGridView_StaffList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_StaffList.Name = "dataGridView_StaffList";
            this.dataGridView_StaffList.RowHeadersWidth = 51;
            this.dataGridView_StaffList.RowTemplate.Height = 24;
            this.dataGridView_StaffList.Size = new System.Drawing.Size(922, 475);
            this.dataGridView_StaffList.TabIndex = 41;
            this.dataGridView_StaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_StaffList_CellClick);
            this.dataGridView_StaffList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_StaffList_MouseClick);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1400, 566);
            this.Controls.Add(this.dataGridView_StaffList);
            this.Controls.Add(this.txtBox_TotalStaff);
            this.Controls.Add(this.lb_TotalStaff);
            this.Controls.Add(this.groupBox_Operation);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.panel_Information);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmStaff";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel_Information.ResumeLayout(false);
            this.panel_Information.PerformLayout();
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.groupBox_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Information;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.RadioButton radioButton_Staff;
        private System.Windows.Forms.RadioButton radioButton_Manager;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_StaffName;
        private System.Windows.Forms.TextBox txtBox_StaffID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label lb_StaffName;
        private System.Windows.Forms.Label lb_StaffID;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.Button btn_DefaultFilter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.RadioButton radioButton_FilterStaff;
        private System.Windows.Forms.RadioButton radioButton_FilterManager;
        private System.Windows.Forms.Label lb_FilterPosition;
        private System.Windows.Forms.GroupBox groupBox_Operation;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txtBox_TotalStaff;
        private System.Windows.Forms.Label lb_TotalStaff;
        private System.Windows.Forms.DataGridView dataGridView_StaffList;
    }
}