namespace BaoCaoGiaoHeo
{
    partial class F_DangNhap
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbTenTaiKhoan = new System.Windows.Forms.TextBox();
			this.tbMatKhau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btShow = new System.Windows.Forms.Button();
			this.btThoat = new System.Windows.Forms.Button();
			this.btDangNhap = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.link = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(115, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gmail";
			// 
			// tbTenTaiKhoan
			// 
			this.tbTenTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTenTaiKhoan.Location = new System.Drawing.Point(272, 155);
			this.tbTenTaiKhoan.Name = "tbTenTaiKhoan";
			this.tbTenTaiKhoan.Size = new System.Drawing.Size(504, 30);
			this.tbTenTaiKhoan.TabIndex = 1;
			// 
			// tbMatKhau
			// 
			this.tbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMatKhau.Location = new System.Drawing.Point(272, 227);
			this.tbMatKhau.Name = "tbMatKhau";
			this.tbMatKhau.Size = new System.Drawing.Size(504, 30);
			this.tbMatKhau.TabIndex = 3;
			this.tbMatKhau.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(115, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mật khẩu App";
			// 
			// btShow
			// 
			this.btShow.BackColor = System.Drawing.Color.Silver;
			this.btShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btShow.Location = new System.Drawing.Point(821, 224);
			this.btShow.Name = "btShow";
			this.btShow.Size = new System.Drawing.Size(103, 36);
			this.btShow.TabIndex = 8;
			this.btShow.Text = "Hiện";
			this.btShow.UseVisualStyleBackColor = false;
			this.btShow.Click += new System.EventHandler(this.btShow_Click);
			// 
			// btThoat
			// 
			this.btThoat.BackColor = System.Drawing.Color.Silver;
			this.btThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btThoat.Location = new System.Drawing.Point(658, 293);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(118, 36);
			this.btThoat.TabIndex = 10;
			this.btThoat.Text = "Trở về";
			this.btThoat.UseVisualStyleBackColor = false;
			this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
			// 
			// btDangNhap
			// 
			this.btDangNhap.BackColor = System.Drawing.Color.Silver;
			this.btDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDangNhap.Location = new System.Drawing.Point(479, 293);
			this.btDangNhap.Name = "btDangNhap";
			this.btDangNhap.Size = new System.Drawing.Size(137, 36);
			this.btDangNhap.TabIndex = 9;
			this.btDangNhap.Text = "Đăng nhập";
			this.btDangNhap.UseVisualStyleBackColor = false;
			this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(280, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(489, 45);
			this.label3.TabIndex = 11;
			this.label3.Text = "Đăng nhập tài khoản Gmail";
			// 
			// link
			// 
			this.link.AutoSize = true;
			this.link.BackColor = System.Drawing.Color.LightSteelBlue;
			this.link.DisabledLinkColor = System.Drawing.Color.Red;
			this.link.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.link.Location = new System.Drawing.Point(268, 303);
			this.link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.link.Name = "link";
			this.link.Size = new System.Drawing.Size(149, 19);
			this.link.TabIndex = 12;
			this.link.TabStop = true;
			this.link.Text = "Lấy mật khẩu App";
			this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
			// 
			// F_DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1018, 443);
			this.Controls.Add(this.link);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btThoat);
			this.Controls.Add(this.btDangNhap);
			this.Controls.Add(this.btShow);
			this.Controls.Add(this.tbMatKhau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTenTaiKhoan);
			this.Controls.Add(this.label1);
			this.Name = "F_DangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập Gmail";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link;
    }
}