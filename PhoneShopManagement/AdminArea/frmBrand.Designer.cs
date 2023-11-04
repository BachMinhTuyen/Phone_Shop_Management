﻿namespace PhoneShopManagement.AdminArea
{
    partial class frmBrand
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
            this.txtBox_BrandName = new System.Windows.Forms.TextBox();
            this.txtBox_BrandID = new System.Windows.Forms.TextBox();
            this.lb_BrandID = new System.Windows.Forms.Label();
            this.lb_BrandName = new System.Windows.Forms.Label();
            this.dataGridView_BrandList = new System.Windows.Forms.DataGridView();
            this.groupBox_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BrandList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Information
            // 
            this.groupBox_Information.Controls.Add(this.btn_Clear);
            this.groupBox_Information.Controls.Add(this.btn_Delete);
            this.groupBox_Information.Controls.Add(this.btn_Update);
            this.groupBox_Information.Controls.Add(this.btn_Insert);
            this.groupBox_Information.Controls.Add(this.txtBox_BrandName);
            this.groupBox_Information.Controls.Add(this.txtBox_BrandID);
            this.groupBox_Information.Controls.Add(this.lb_BrandID);
            this.groupBox_Information.Controls.Add(this.lb_BrandName);
            this.groupBox_Information.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Information.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Information.Name = "groupBox_Information";
            this.groupBox_Information.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Information.Size = new System.Drawing.Size(508, 189);
            this.groupBox_Information.TabIndex = 0;
            this.groupBox_Information.TabStop = false;
            this.groupBox_Information.Text = "Thông tin thương hiệu";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(378, 129);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(83, 33);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(260, 129);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(83, 33);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(144, 129);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 33);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(32, 129);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(83, 33);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // txtBox_BrandName
            // 
            this.txtBox_BrandName.Location = new System.Drawing.Point(181, 76);
            this.txtBox_BrandName.Name = "txtBox_BrandName";
            this.txtBox_BrandName.Size = new System.Drawing.Size(280, 28);
            this.txtBox_BrandName.TabIndex = 3;
            // 
            // txtBox_BrandID
            // 
            this.txtBox_BrandID.Location = new System.Drawing.Point(181, 38);
            this.txtBox_BrandID.Name = "txtBox_BrandID";
            this.txtBox_BrandID.Size = new System.Drawing.Size(280, 28);
            this.txtBox_BrandID.TabIndex = 2;
            // 
            // lb_BrandID
            // 
            this.lb_BrandID.AutoSize = true;
            this.lb_BrandID.Location = new System.Drawing.Point(28, 41);
            this.lb_BrandID.Name = "lb_BrandID";
            this.lb_BrandID.Size = new System.Drawing.Size(131, 21);
            this.lb_BrandID.TabIndex = 1;
            this.lb_BrandID.Text = "Mã thương hiệu:";
            // 
            // lb_BrandName
            // 
            this.lb_BrandName.AutoSize = true;
            this.lb_BrandName.Location = new System.Drawing.Point(28, 79);
            this.lb_BrandName.Name = "lb_BrandName";
            this.lb_BrandName.Size = new System.Drawing.Size(137, 21);
            this.lb_BrandName.TabIndex = 0;
            this.lb_BrandName.Text = "Tên thương hiệu:";
            // 
            // dataGridView_BrandList
            // 
            this.dataGridView_BrandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BrandList.Location = new System.Drawing.Point(13, 221);
            this.dataGridView_BrandList.Name = "dataGridView_BrandList";
            this.dataGridView_BrandList.RowHeadersWidth = 51;
            this.dataGridView_BrandList.RowTemplate.Height = 24;
            this.dataGridView_BrandList.Size = new System.Drawing.Size(507, 273);
            this.dataGridView_BrandList.TabIndex = 1;
            // 
            // frmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 506);
            this.Controls.Add(this.dataGridView_BrandList);
            this.Controls.Add(this.groupBox_Information);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBrand";
            this.Text = "Quản lý thương hiệu";
            this.groupBox_Information.ResumeLayout(false);
            this.groupBox_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BrandList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Information;
        private System.Windows.Forms.Label lb_BrandName;
        private System.Windows.Forms.Label lb_BrandID;
        private System.Windows.Forms.TextBox txtBox_BrandName;
        private System.Windows.Forms.TextBox txtBox_BrandID;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView_BrandList;
    }
}