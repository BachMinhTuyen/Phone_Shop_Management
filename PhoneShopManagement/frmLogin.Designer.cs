namespace PhoneShopManagement
{
    partial class frmLogin
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
            this.pictureBox_BannerLogin = new System.Windows.Forms.PictureBox();
            this.lb_Login = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.lb_Message = new System.Windows.Forms.Label();
            this.chkBox_Remember = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BannerLogin)).BeginInit();
            this.panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_BannerLogin
            // 
            this.pictureBox_BannerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_BannerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_BannerLogin.Image = global::PhoneShopManagement.Properties.Resources.mobile_phone_store_template_hand;
            this.pictureBox_BannerLogin.Location = new System.Drawing.Point(21, 31);
            this.pictureBox_BannerLogin.Name = "pictureBox_BannerLogin";
            this.pictureBox_BannerLogin.Size = new System.Drawing.Size(568, 407);
            this.pictureBox_BannerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_BannerLogin.TabIndex = 0;
            this.pictureBox_BannerLogin.TabStop = false;
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(111, 16);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(180, 84);
            this.lb_Login.TabIndex = 1;
            this.lb_Login.Text = "Login";
            // 
            // panel_Login
            // 
            this.panel_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Login.BackColor = System.Drawing.Color.White;
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.lb_Message);
            this.panel_Login.Controls.Add(this.chkBox_Remember);
            this.panel_Login.Controls.Add(this.btn_Login);
            this.panel_Login.Controls.Add(this.txtBox_Password);
            this.panel_Login.Controls.Add(this.txtBox_UserName);
            this.panel_Login.Controls.Add(this.lb_Password);
            this.panel_Login.Controls.Add(this.lb_UserName);
            this.panel_Login.Controls.Add(this.lb_Login);
            this.panel_Login.Location = new System.Drawing.Point(611, 61);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(398, 348);
            this.panel_Login.TabIndex = 2;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.Location = new System.Drawing.Point(151, 212);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 21);
            this.lb_Message.TabIndex = 8;
            // 
            // chkBox_Remember
            // 
            this.chkBox_Remember.AutoSize = true;
            this.chkBox_Remember.Checked = true;
            this.chkBox_Remember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_Remember.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Remember.Location = new System.Drawing.Point(21, 236);
            this.chkBox_Remember.Name = "chkBox_Remember";
            this.chkBox_Remember.Size = new System.Drawing.Size(171, 25);
            this.chkBox_Remember.TabIndex = 7;
            this.chkBox_Remember.Text = "Ghi nhớ đăng nhập";
            this.chkBox_Remember.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(155, 277);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(126, 43);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.Location = new System.Drawing.Point(155, 165);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(224, 28);
            this.txtBox_Password.TabIndex = 5;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserName.Location = new System.Drawing.Point(155, 121);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(224, 28);
            this.txtBox_UserName.TabIndex = 4;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(17, 168);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(84, 21);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(17, 124);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(132, 21);
            this.lb_UserName.TabIndex = 2;
            this.lb_UserName.Text = "Tên đăng nhập: ";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhoneShopManagement.Properties.Resources.abstract_textured_backgound;
            this.ClientSize = new System.Drawing.Size(1034, 460);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.pictureBox_BannerLogin);
            this.Name = "frmLogin";
            this.Text = "Quản Lý Cửa Hàng Điện Thoại Và Phụ Kiện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BannerLogin)).EndInit();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_BannerLogin;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.CheckBox chkBox_Remember;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.Label lb_Message;
    }
}

