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
            this.lb_Login = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.chkBox_ShowHidePassword = new System.Windows.Forms.CheckBox();
            this.chkBox_Remember = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.pictureBox_BannerLogin = new System.Windows.Forms.PictureBox();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BannerLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(125, 21);
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
            this.panel_Login.Controls.Add(this.chkBox_ShowHidePassword);
            this.panel_Login.Controls.Add(this.chkBox_Remember);
            this.panel_Login.Controls.Add(this.btn_Login);
            this.panel_Login.Controls.Add(this.txtBox_Password);
            this.panel_Login.Controls.Add(this.txtBox_UserName);
            this.panel_Login.Controls.Add(this.lb_Password);
            this.panel_Login.Controls.Add(this.lb_UserName);
            this.panel_Login.Controls.Add(this.lb_Login);
            this.panel_Login.Location = new System.Drawing.Point(681, 29);
            this.panel_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(448, 453);
            this.panel_Login.TabIndex = 2;
            // 
            // chkBox_ShowHidePassword
            // 
            this.chkBox_ShowHidePassword.AutoSize = true;
            this.chkBox_ShowHidePassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_ShowHidePassword.Location = new System.Drawing.Point(273, 283);
            this.chkBox_ShowHidePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBox_ShowHidePassword.Name = "chkBox_ShowHidePassword";
            this.chkBox_ShowHidePassword.Size = new System.Drawing.Size(139, 25);
            this.chkBox_ShowHidePassword.TabIndex = 9;
            this.chkBox_ShowHidePassword.Text = "Hiện mật khẩu";
            this.chkBox_ShowHidePassword.UseVisualStyleBackColor = true;
            this.chkBox_ShowHidePassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkBox_Remember
            // 
            this.chkBox_Remember.AutoSize = true;
            this.chkBox_Remember.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_Remember.Location = new System.Drawing.Point(27, 283);
            this.chkBox_Remember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBox_Remember.Name = "chkBox_Remember";
            this.chkBox_Remember.Size = new System.Drawing.Size(171, 25);
            this.chkBox_Remember.TabIndex = 7;
            this.chkBox_Remember.Text = "Ghi nhớ đăng nhập";
            this.chkBox_Remember.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.BackgroundImage = global::PhoneShopManagement.Properties.Resources.abstract_textured_backgound;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.FlatAppearance.BorderSize = 2;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = global::PhoneShopManagement.Properties.Resources.icons8_login_50;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(113, 346);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(233, 77);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Password.Location = new System.Drawing.Point(177, 190);
            this.txtBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(252, 28);
            this.txtBox_Password.TabIndex = 5;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserName.Location = new System.Drawing.Point(177, 132);
            this.txtBox_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(252, 28);
            this.txtBox_UserName.TabIndex = 4;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(22, 193);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(84, 21);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Mật khẩu:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(22, 136);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(132, 21);
            this.lb_UserName.TabIndex = 2;
            this.lb_UserName.Text = "Tên đăng nhập: ";
            // 
            // pictureBox_BannerLogin
            // 
            this.pictureBox_BannerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_BannerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_BannerLogin.Image = global::PhoneShopManagement.Properties.Resources.mobile_phone_store_template_hand;
            this.pictureBox_BannerLogin.Location = new System.Drawing.Point(21, 29);
            this.pictureBox_BannerLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_BannerLogin.Name = "pictureBox_BannerLogin";
            this.pictureBox_BannerLogin.Size = new System.Drawing.Size(639, 453);
            this.pictureBox_BannerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_BannerLogin.TabIndex = 0;
            this.pictureBox_BannerLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PhoneShopManagement.Properties.Resources.abstract_textured_backgound;
            this.ClientSize = new System.Drawing.Size(1157, 510);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.pictureBox_BannerLogin);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Quản Lý Cửa Hàng Điện Thoại Và Phụ Kiện";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BannerLogin)).EndInit();
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
        private System.Windows.Forms.CheckBox chkBox_ShowHidePassword;
    }
}

