namespace PhoneShopManagement
{
    partial class frmAboutUs
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
            this.lb_Topic = new System.Windows.Forms.Label();
            this.lb_TopicName = new System.Windows.Forms.Label();
            this.lb_Member = new System.Windows.Forms.Label();
            this.lb_FirstMember = new System.Windows.Forms.Label();
            this.lb_SecondName = new System.Windows.Forms.Label();
            this.lb_ThirdName = new System.Windows.Forms.Label();
            this.lb_Tools = new System.Windows.Forms.Label();
            this.lb_ToolName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Topic
            // 
            this.lb_Topic.AutoSize = true;
            this.lb_Topic.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Topic.Location = new System.Drawing.Point(42, 37);
            this.lb_Topic.Name = "lb_Topic";
            this.lb_Topic.Size = new System.Drawing.Size(100, 21);
            this.lb_Topic.TabIndex = 0;
            this.lb_Topic.Text = "Tên đề tài:";
            // 
            // lb_TopicName
            // 
            this.lb_TopicName.AutoSize = true;
            this.lb_TopicName.Location = new System.Drawing.Point(179, 37);
            this.lb_TopicName.Name = "lb_TopicName";
            this.lb_TopicName.Size = new System.Drawing.Size(339, 21);
            this.lb_TopicName.TabIndex = 1;
            this.lb_TopicName.Text = "Quản lý cửa hàng bán điện thoại và phụ kiện";
            // 
            // lb_Member
            // 
            this.lb_Member.AutoSize = true;
            this.lb_Member.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Member.Location = new System.Drawing.Point(42, 88);
            this.lb_Member.Name = "lb_Member";
            this.lb_Member.Size = new System.Drawing.Size(110, 21);
            this.lb_Member.TabIndex = 2;
            this.lb_Member.Text = "Thành viên:";
            // 
            // lb_FirstMember
            // 
            this.lb_FirstMember.AutoSize = true;
            this.lb_FirstMember.Location = new System.Drawing.Point(179, 88);
            this.lb_FirstMember.Name = "lb_FirstMember";
            this.lb_FirstMember.Size = new System.Drawing.Size(259, 21);
            this.lb_FirstMember.TabIndex = 3;
            this.lb_FirstMember.Text = "+ 2001216289 - Bạch Minh Tuyên";
            // 
            // lb_SecondName
            // 
            this.lb_SecondName.AutoSize = true;
            this.lb_SecondName.Location = new System.Drawing.Point(179, 127);
            this.lb_SecondName.Name = "lb_SecondName";
            this.lb_SecondName.Size = new System.Drawing.Size(289, 21);
            this.lb_SecondName.TabIndex = 4;
            this.lb_SecondName.Text = "+ 2001215904 - Nguyễn Thị Xuân Lan";
            // 
            // lb_ThirdName
            // 
            this.lb_ThirdName.AutoSize = true;
            this.lb_ThirdName.Location = new System.Drawing.Point(179, 164);
            this.lb_ThirdName.Name = "lb_ThirdName";
            this.lb_ThirdName.Size = new System.Drawing.Size(233, 21);
            this.lb_ThirdName.TabIndex = 5;
            this.lb_ThirdName.Text = "+ 2001216252 - Trần Thị Trúc";
            // 
            // lb_Tools
            // 
            this.lb_Tools.AutoSize = true;
            this.lb_Tools.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tools.Location = new System.Drawing.Point(42, 220);
            this.lb_Tools.Name = "lb_Tools";
            this.lb_Tools.Size = new System.Drawing.Size(85, 21);
            this.lb_Tools.TabIndex = 6;
            this.lb_Tools.Text = "Công cụ:";
            // 
            // lb_ToolName
            // 
            this.lb_ToolName.AutoSize = true;
            this.lb_ToolName.Location = new System.Drawing.Point(179, 220);
            this.lb_ToolName.Name = "lb_ToolName";
            this.lb_ToolName.Size = new System.Drawing.Size(305, 21);
            this.lb_ToolName.TabIndex = 7;
            this.lb_ToolName.Text = "Visual Studio 2022, MS SQL Server 2022";
            // 
            // frmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 282);
            this.Controls.Add(this.lb_ToolName);
            this.Controls.Add(this.lb_Tools);
            this.Controls.Add(this.lb_ThirdName);
            this.Controls.Add(this.lb_SecondName);
            this.Controls.Add(this.lb_FirstMember);
            this.Controls.Add(this.lb_Member);
            this.Controls.Add(this.lb_TopicName);
            this.Controls.Add(this.lb_Topic);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAboutUs";
            this.Text = "Thông tin về chúng tôi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Topic;
        private System.Windows.Forms.Label lb_TopicName;
        private System.Windows.Forms.Label lb_Member;
        private System.Windows.Forms.Label lb_FirstMember;
        private System.Windows.Forms.Label lb_SecondName;
        private System.Windows.Forms.Label lb_ThirdName;
        private System.Windows.Forms.Label lb_Tools;
        private System.Windows.Forms.Label lb_ToolName;
    }
}