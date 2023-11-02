﻿namespace PhoneShopManagement
{
    partial class frmUserProfile
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
            this.groupBox_UserInformation = new System.Windows.Forms.GroupBox();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.txtBox_FullName = new System.Windows.Forms.TextBox();
            this.txtBox_UserLogin = new System.Windows.Forms.TextBox();
            this.lb_UserLogin = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox_UserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_UserInformation
            // 
            this.groupBox_UserInformation.Controls.Add(this.txtBox_Address);
            this.groupBox_UserInformation.Controls.Add(this.lb_Address);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_PhoneNumber);
            this.groupBox_UserInformation.Controls.Add(this.lb_PhoneNumber);
            this.groupBox_UserInformation.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.groupBox_UserInformation.Controls.Add(this.lb_DateOfBirth);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_Email);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_FullName);
            this.groupBox_UserInformation.Controls.Add(this.txtBox_UserLogin);
            this.groupBox_UserInformation.Controls.Add(this.lb_UserLogin);
            this.groupBox_UserInformation.Controls.Add(this.lb_Email);
            this.groupBox_UserInformation.Controls.Add(this.lb_FullName);
            this.groupBox_UserInformation.Location = new System.Drawing.Point(38, 29);
            this.groupBox_UserInformation.Name = "groupBox_UserInformation";
            this.groupBox_UserInformation.Size = new System.Drawing.Size(504, 274);
            this.groupBox_UserInformation.TabIndex = 2;
            this.groupBox_UserInformation.TabStop = false;
            this.groupBox_UserInformation.Text = "Thông tin";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(185, 106);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(294, 28);
            this.txtBox_Email.TabIndex = 7;
            // 
            // txtBox_FullName
            // 
            this.txtBox_FullName.Location = new System.Drawing.Point(185, 69);
            this.txtBox_FullName.Name = "txtBox_FullName";
            this.txtBox_FullName.ReadOnly = true;
            this.txtBox_FullName.Size = new System.Drawing.Size(294, 28);
            this.txtBox_FullName.TabIndex = 5;
            // 
            // txtBox_UserLogin
            // 
            this.txtBox_UserLogin.Location = new System.Drawing.Point(185, 35);
            this.txtBox_UserLogin.Name = "txtBox_UserLogin";
            this.txtBox_UserLogin.ReadOnly = true;
            this.txtBox_UserLogin.Size = new System.Drawing.Size(294, 28);
            this.txtBox_UserLogin.TabIndex = 4;
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
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(27, 109);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(57, 21);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email:";
            // 
            // lb_FullName
            // 
            this.lb_FullName.AutoSize = true;
            this.lb_FullName.Location = new System.Drawing.Point(27, 72);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(87, 21);
            this.lb_FullName.TabIndex = 0;
            this.lb_FullName.Text = "Họ và tên:";
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(185, 143);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(294, 28);
            this.dateTimePicker_DateOfBirth.TabIndex = 29;
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Location = new System.Drawing.Point(27, 149);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(88, 21);
            this.lb_DateOfBirth.TabIndex = 28;
            this.lb_DateOfBirth.Text = "Ngày sinh:";
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(185, 182);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(294, 28);
            this.txtBox_PhoneNumber.TabIndex = 31;
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Location = new System.Drawing.Point(27, 185);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(113, 21);
            this.lb_PhoneNumber.TabIndex = 30;
            this.lb_PhoneNumber.Text = "Số điện thoại:";
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(185, 220);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(294, 28);
            this.txtBox_Address.TabIndex = 33;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(27, 223);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(67, 21);
            this.lb_Address.TabIndex = 32;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(223, 332);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(147, 33);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Lưu thông tin";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(401, 332);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 33);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 386);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox_UserInformation);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserProfile";
            this.Text = "Thiết lập hồ sơ người dùng";
            this.groupBox_UserInformation.ResumeLayout(false);
            this.groupBox_UserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_UserInformation;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.TextBox txtBox_FullName;
        private System.Windows.Forms.TextBox txtBox_UserLogin;
        private System.Windows.Forms.Label lb_UserLogin;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}