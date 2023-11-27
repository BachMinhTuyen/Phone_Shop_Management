namespace PhoneShopManagement.UserArea
{
    partial class frmSearchBill
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
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtBox_ProductID = new System.Windows.Forms.TextBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.groupBox_BillInformation = new System.Windows.Forms.GroupBox();
            this.txtBox_Total = new System.Windows.Forms.TextBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.lb_TotalBill = new System.Windows.Forms.Label();
            this.lb_BillID = new System.Windows.Forms.Label();
            this.txtBox_StaffName = new System.Windows.Forms.TextBox();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.txtBox_StaffID = new System.Windows.Forms.TextBox();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.lb_StaffName = new System.Windows.Forms.Label();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.lb_StaffID = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txtBox_CustomerID = new System.Windows.Forms.TextBox();
            this.txtBox_BillID = new System.Windows.Forms.TextBox();
            this.lb_CustomerID = new System.Windows.Forms.Label();
            this.txtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.dateTimePicker_TimeOfPurchase = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_BillList = new System.Windows.Forms.DataGridView();
            this.groupBox_BillList = new System.Windows.Forms.GroupBox();
            this.dataGridView_Details = new System.Windows.Forms.DataGridView();
            this.lb_HeadingDetails = new System.Windows.Forms.Label();
            this.groupBox_Search.SuspendLayout();
            this.groupBox_BillInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillList)).BeginInit();
            this.groupBox_BillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.btn_Search);
            this.groupBox_Search.Controls.Add(this.txtBox_ProductID);
            this.groupBox_Search.Controls.Add(this.lb_ProductID);
            this.groupBox_Search.Location = new System.Drawing.Point(890, 33);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(564, 127);
            this.groupBox_Search.TabIndex = 48;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Tra cứu hoá đơn";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(153, 75);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(83, 29);
            this.btn_Search.TabIndex = 47;
            this.btn_Search.Text = "Tra cứu";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtBox_ProductID
            // 
            this.txtBox_ProductID.Location = new System.Drawing.Point(153, 40);
            this.txtBox_ProductID.Name = "txtBox_ProductID";
            this.txtBox_ProductID.Size = new System.Drawing.Size(234, 26);
            this.txtBox_ProductID.TabIndex = 40;
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Location = new System.Drawing.Point(42, 43);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(92, 18);
            this.lb_ProductID.TabIndex = 39;
            this.lb_ProductID.Text = "Mã hoá đơn:";
            // 
            // groupBox_BillInformation
            // 
            this.groupBox_BillInformation.Controls.Add(this.txtBox_Total);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_Email);
            this.groupBox_BillInformation.Controls.Add(this.lb_TotalBill);
            this.groupBox_BillInformation.Controls.Add(this.lb_BillID);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_StaffName);
            this.groupBox_BillInformation.Controls.Add(this.lb_CustomerName);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_StaffID);
            this.groupBox_BillInformation.Controls.Add(this.lb_DateOfBirth);
            this.groupBox_BillInformation.Controls.Add(this.lb_StaffName);
            this.groupBox_BillInformation.Controls.Add(this.lb_PhoneNumber);
            this.groupBox_BillInformation.Controls.Add(this.lb_StaffID);
            this.groupBox_BillInformation.Controls.Add(this.lb_Email);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_CustomerID);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_BillID);
            this.groupBox_BillInformation.Controls.Add(this.lb_CustomerID);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_CustomerName);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_Address);
            this.groupBox_BillInformation.Controls.Add(this.txtBox_PhoneNumber);
            this.groupBox_BillInformation.Controls.Add(this.lb_Address);
            this.groupBox_BillInformation.Controls.Add(this.dateTimePicker_TimeOfPurchase);
            this.groupBox_BillInformation.Location = new System.Drawing.Point(28, 19);
            this.groupBox_BillInformation.Name = "groupBox_BillInformation";
            this.groupBox_BillInformation.Size = new System.Drawing.Size(857, 227);
            this.groupBox_BillInformation.TabIndex = 47;
            this.groupBox_BillInformation.TabStop = false;
            this.groupBox_BillInformation.Text = "Thông tin hoá đơn";
            // 
            // txtBox_Total
            // 
            this.txtBox_Total.Location = new System.Drawing.Point(599, 175);
            this.txtBox_Total.Name = "txtBox_Total";
            this.txtBox_Total.ReadOnly = true;
            this.txtBox_Total.Size = new System.Drawing.Size(231, 26);
            this.txtBox_Total.TabIndex = 38;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(568, 139);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(262, 26);
            this.txtBox_Email.TabIndex = 28;
            // 
            // lb_TotalBill
            // 
            this.lb_TotalBill.AutoSize = true;
            this.lb_TotalBill.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalBill.Location = new System.Drawing.Point(420, 177);
            this.lb_TotalBill.Name = "lb_TotalBill";
            this.lb_TotalBill.Size = new System.Drawing.Size(165, 18);
            this.lb_TotalBill.TabIndex = 37;
            this.lb_TotalBill.Text = "Tổng tiền thanh toán:";
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BillID.Location = new System.Drawing.Point(15, 43);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(97, 18);
            this.lb_BillID.TabIndex = 6;
            this.lb_BillID.Text = "Mã hoá đơn:";
            // 
            // txtBox_StaffName
            // 
            this.txtBox_StaffName.Location = new System.Drawing.Point(568, 106);
            this.txtBox_StaffName.Name = "txtBox_StaffName";
            this.txtBox_StaffName.Size = new System.Drawing.Size(262, 26);
            this.txtBox_StaffName.TabIndex = 36;
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Location = new System.Drawing.Point(420, 75);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(119, 18);
            this.lb_CustomerName.TabIndex = 7;
            this.lb_CustomerName.Text = "Tên khách hàng:";
            // 
            // txtBox_StaffID
            // 
            this.txtBox_StaffID.Location = new System.Drawing.Point(161, 106);
            this.txtBox_StaffID.Name = "txtBox_StaffID";
            this.txtBox_StaffID.Size = new System.Drawing.Size(234, 26);
            this.txtBox_StaffID.TabIndex = 35;
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Location = new System.Drawing.Point(420, 44);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(118, 18);
            this.lb_DateOfBirth.TabIndex = 9;
            this.lb_DateOfBirth.Text = "Ngày mua hàng:";
            // 
            // lb_StaffName
            // 
            this.lb_StaffName.AutoSize = true;
            this.lb_StaffName.Location = new System.Drawing.Point(420, 109);
            this.lb_StaffName.Name = "lb_StaffName";
            this.lb_StaffName.Size = new System.Drawing.Size(144, 18);
            this.lb_StaffName.TabIndex = 34;
            this.lb_StaffName.Text = "Nhân viên bán hàng:";
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(15, 144);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(121, 18);
            this.lb_PhoneNumber.TabIndex = 10;
            this.lb_PhoneNumber.Text = "SDT khách hàng:";
            // 
            // lb_StaffID
            // 
            this.lb_StaffID.AutoSize = true;
            this.lb_StaffID.Location = new System.Drawing.Point(15, 109);
            this.lb_StaffID.Name = "lb_StaffID";
            this.lb_StaffID.Size = new System.Drawing.Size(101, 18);
            this.lb_StaffID.TabIndex = 33;
            this.lb_StaffID.Text = "Mã nhân viên:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(420, 141);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 18);
            this.lb_Email.TabIndex = 12;
            this.lb_Email.Text = "Email:";
            // 
            // txtBox_CustomerID
            // 
            this.txtBox_CustomerID.Location = new System.Drawing.Point(161, 73);
            this.txtBox_CustomerID.Name = "txtBox_CustomerID";
            this.txtBox_CustomerID.Size = new System.Drawing.Size(234, 26);
            this.txtBox_CustomerID.TabIndex = 32;
            // 
            // txtBox_BillID
            // 
            this.txtBox_BillID.Location = new System.Drawing.Point(161, 40);
            this.txtBox_BillID.Name = "txtBox_BillID";
            this.txtBox_BillID.Size = new System.Drawing.Size(234, 26);
            this.txtBox_BillID.TabIndex = 16;
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.AutoSize = true;
            this.lb_CustomerID.Location = new System.Drawing.Point(15, 75);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(113, 18);
            this.lb_CustomerID.TabIndex = 31;
            this.lb_CustomerID.Text = "Mã khách hàng:";
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Location = new System.Drawing.Point(568, 73);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(262, 26);
            this.txtBox_CustomerName.TabIndex = 17;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(161, 175);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(234, 26);
            this.txtBox_Address.TabIndex = 30;
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(161, 139);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(234, 26);
            this.txtBox_PhoneNumber.TabIndex = 20;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(17, 177);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(135, 18);
            this.lb_Address.TabIndex = 29;
            this.lb_Address.Text = "Địa chỉ khách hàng:";
            // 
            // dateTimePicker_TimeOfPurchase
            // 
            this.dateTimePicker_TimeOfPurchase.Location = new System.Drawing.Point(568, 38);
            this.dateTimePicker_TimeOfPurchase.Name = "dateTimePicker_TimeOfPurchase";
            this.dateTimePicker_TimeOfPurchase.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker_TimeOfPurchase.TabIndex = 27;
            // 
            // dataGridView_BillList
            // 
            this.dataGridView_BillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_BillList.Location = new System.Drawing.Point(5, 31);
            this.dataGridView_BillList.Name = "dataGridView_BillList";
            this.dataGridView_BillList.RowHeadersWidth = 51;
            this.dataGridView_BillList.RowTemplate.Height = 24;
            this.dataGridView_BillList.Size = new System.Drawing.Size(553, 344);
            this.dataGridView_BillList.TabIndex = 49;
            this.dataGridView_BillList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BillList_CellClick);
            // 
            // groupBox_BillList
            // 
            this.groupBox_BillList.Controls.Add(this.dataGridView_BillList);
            this.groupBox_BillList.Location = new System.Drawing.Point(890, 165);
            this.groupBox_BillList.Name = "groupBox_BillList";
            this.groupBox_BillList.Size = new System.Drawing.Size(564, 381);
            this.groupBox_BillList.TabIndex = 50;
            this.groupBox_BillList.TabStop = false;
            this.groupBox_BillList.Text = "Danh sách hoá đơn";
            // 
            // dataGridView_Details
            // 
            this.dataGridView_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Details.Location = new System.Drawing.Point(28, 285);
            this.dataGridView_Details.Name = "dataGridView_Details";
            this.dataGridView_Details.RowHeadersWidth = 51;
            this.dataGridView_Details.RowTemplate.Height = 24;
            this.dataGridView_Details.Size = new System.Drawing.Size(857, 261);
            this.dataGridView_Details.TabIndex = 51;
            // 
            // lb_HeadingDetails
            // 
            this.lb_HeadingDetails.AutoSize = true;
            this.lb_HeadingDetails.Location = new System.Drawing.Point(43, 258);
            this.lb_HeadingDetails.Name = "lb_HeadingDetails";
            this.lb_HeadingDetails.Size = new System.Drawing.Size(197, 18);
            this.lb_HeadingDetails.TabIndex = 52;
            this.lb_HeadingDetails.Text = "Thông tin chi tiết về hoá đơn";
            // 
            // frmSearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 568);
            this.Controls.Add(this.lb_HeadingDetails);
            this.Controls.Add(this.dataGridView_Details);
            this.Controls.Add(this.groupBox_BillList);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.groupBox_BillInformation);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSearchBill";
            this.Text = "Tra cứu hoá đơn";
            this.Load += new System.EventHandler(this.frmSearchBill_Load);
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            this.groupBox_BillInformation.ResumeLayout(false);
            this.groupBox_BillInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillList)).EndInit();
            this.groupBox_BillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtBox_ProductID;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.GroupBox groupBox_BillInformation;
        private System.Windows.Forms.TextBox txtBox_Total;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label lb_TotalBill;
        private System.Windows.Forms.Label lb_BillID;
        private System.Windows.Forms.TextBox txtBox_StaffName;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.TextBox txtBox_StaffID;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.Label lb_StaffName;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.Label lb_StaffID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txtBox_CustomerID;
        private System.Windows.Forms.TextBox txtBox_BillID;
        private System.Windows.Forms.Label lb_CustomerID;
        private System.Windows.Forms.TextBox txtBox_CustomerName;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimeOfPurchase;
        private System.Windows.Forms.DataGridView dataGridView_BillList;
        private System.Windows.Forms.GroupBox groupBox_BillList;
        private System.Windows.Forms.DataGridView dataGridView_Details;
        private System.Windows.Forms.Label lb_HeadingDetails;
    }
}