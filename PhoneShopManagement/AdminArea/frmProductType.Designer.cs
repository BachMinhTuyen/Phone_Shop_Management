namespace PhoneShopManagement.AdminArea
{
    partial class frmProductType
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
            this.groupBox_Information = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txtBox_ProductTypeName = new System.Windows.Forms.TextBox();
            this.txtBox_ProductTypeID = new System.Windows.Forms.TextBox();
            this.lb_ProductTypeID = new System.Windows.Forms.Label();
            this.lb_ProductTypeName = new System.Windows.Forms.Label();
            this.dataGridView_ProductType = new System.Windows.Forms.DataGridView();
            this.groupBox_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Information
            // 
            this.groupBox_Information.Controls.Add(this.btn_Clear);
            this.groupBox_Information.Controls.Add(this.btn_Delete);
            this.groupBox_Information.Controls.Add(this.btn_Update);
            this.groupBox_Information.Controls.Add(this.btn_Insert);
            this.groupBox_Information.Controls.Add(this.txtBox_ProductTypeName);
            this.groupBox_Information.Controls.Add(this.txtBox_ProductTypeID);
            this.groupBox_Information.Controls.Add(this.lb_ProductTypeID);
            this.groupBox_Information.Controls.Add(this.lb_ProductTypeName);
            this.groupBox_Information.Location = new System.Drawing.Point(19, 12);
            this.groupBox_Information.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Information.Name = "groupBox_Information";
            this.groupBox_Information.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Information.Size = new System.Drawing.Size(457, 150);
            this.groupBox_Information.TabIndex = 1;
            this.groupBox_Information.TabStop = false;
            this.groupBox_Information.Text = "Thông tin loại sản phẩm";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(339, 98);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 27);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(234, 98);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 27);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(129, 98);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 27);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(27, 98);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(86, 27);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // txtBox_ProductTypeName
            // 
            this.txtBox_ProductTypeName.Location = new System.Drawing.Point(129, 67);
            this.txtBox_ProductTypeName.Name = "txtBox_ProductTypeName";
            this.txtBox_ProductTypeName.Size = new System.Drawing.Size(296, 26);
            this.txtBox_ProductTypeName.TabIndex = 3;
            // 
            // txtBox_ProductTypeID
            // 
            this.txtBox_ProductTypeID.Location = new System.Drawing.Point(129, 35);
            this.txtBox_ProductTypeID.Name = "txtBox_ProductTypeID";
            this.txtBox_ProductTypeID.Size = new System.Drawing.Size(296, 26);
            this.txtBox_ProductTypeID.TabIndex = 2;
            // 
            // lb_ProductTypeID
            // 
            this.lb_ProductTypeID.AutoSize = true;
            this.lb_ProductTypeID.Location = new System.Drawing.Point(28, 38);
            this.lb_ProductTypeID.Name = "lb_ProductTypeID";
            this.lb_ProductTypeID.Size = new System.Drawing.Size(58, 18);
            this.lb_ProductTypeID.TabIndex = 1;
            this.lb_ProductTypeID.Text = "Mã loại:";
            // 
            // lb_ProductTypeName
            // 
            this.lb_ProductTypeName.AutoSize = true;
            this.lb_ProductTypeName.Location = new System.Drawing.Point(28, 69);
            this.lb_ProductTypeName.Name = "lb_ProductTypeName";
            this.lb_ProductTypeName.Size = new System.Drawing.Size(64, 18);
            this.lb_ProductTypeName.TabIndex = 0;
            this.lb_ProductTypeName.Text = "Tên loại:";
            // 
            // dataGridView_ProductType
            // 
            this.dataGridView_ProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductType.Location = new System.Drawing.Point(19, 169);
            this.dataGridView_ProductType.Name = "dataGridView_ProductType";
            this.dataGridView_ProductType.RowHeadersWidth = 51;
            this.dataGridView_ProductType.RowTemplate.Height = 24;
            this.dataGridView_ProductType.Size = new System.Drawing.Size(457, 253);
            this.dataGridView_ProductType.TabIndex = 2;
            // 
            // frmProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 432);
            this.Controls.Add(this.dataGridView_ProductType);
            this.Controls.Add(this.groupBox_Information);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProductType";
            this.Text = "Quản lý các loại sản phẩm";
            this.groupBox_Information.ResumeLayout(false);
            this.groupBox_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Information;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txtBox_ProductTypeName;
        private System.Windows.Forms.TextBox txtBox_ProductTypeID;
        private System.Windows.Forms.Label lb_ProductTypeID;
        private System.Windows.Forms.Label lb_ProductTypeName;
        private System.Windows.Forms.DataGridView dataGridView_ProductType;
    }
}