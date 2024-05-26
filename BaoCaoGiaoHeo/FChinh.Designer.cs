namespace BaoCaoGiaoHeo
{
    partial class FChinh
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChinh));
			this.pnTong = new System.Windows.Forms.Panel();
			this.pnBody = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.guiBaoCaoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.qLThongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongKeTheoNguonGmail = new System.Windows.Forms.ToolStripMenuItem();
			this.thongKeTheoThoiGian = new System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpSốLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pnTong.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnTong
			// 
			this.pnTong.Controls.Add(this.pnBody);
			this.pnTong.Controls.Add(this.menuStrip1);
			this.pnTong.Location = new System.Drawing.Point(1, 1);
			this.pnTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnTong.Name = "pnTong";
			this.pnTong.Size = new System.Drawing.Size(1446, 791);
			this.pnTong.TabIndex = 1;
			// 
			// pnBody
			// 
			this.pnBody.Location = new System.Drawing.Point(3, 34);
			this.pnBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnBody.Name = "pnBody";
			this.pnBody.Size = new System.Drawing.Size(1436, 750);
			this.pnBody.TabIndex = 2;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiBaoCaoToolStripMenuItem1,
            this.qLThongKeToolStripMenuItem,
            this.dangNhapToolStripMenuItem,
            this.thoátToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1446, 32);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// guiBaoCaoToolStripMenuItem1
			// 
			this.guiBaoCaoToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.guiBaoCaoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guiBaoCaoToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guiBaoCaoToolStripMenuItem1.Image = global::BaoCaoGiaoHeo.Properties.Resources.gmail;
			this.guiBaoCaoToolStripMenuItem1.Name = "guiBaoCaoToolStripMenuItem1";
			this.guiBaoCaoToolStripMenuItem1.Size = new System.Drawing.Size(160, 28);
			this.guiBaoCaoToolStripMenuItem1.Text = "Gửi báo cáo";
			this.guiBaoCaoToolStripMenuItem1.Click += new System.EventHandler(this.guiBaoCaoToolStripMenuItem1_Click);
			// 
			// qLThongKeToolStripMenuItem
			// 
			this.qLThongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongKeTheoNguonGmail,
            this.thongKeTheoThoiGian,
            this.tổngHợpSốLiệuToolStripMenuItem});
			this.qLThongKeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.qLThongKeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLThongKeToolStripMenuItem.Image")));
			this.qLThongKeToolStripMenuItem.Name = "qLThongKeToolStripMenuItem";
			this.qLThongKeToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
			this.qLThongKeToolStripMenuItem.Text = "Thống kê Số liệu";
			// 
			// thongKeTheoNguonGmail
			// 
			this.thongKeTheoNguonGmail.Image = global::BaoCaoGiaoHeo.Properties.Resources.account;
			this.thongKeTheoNguonGmail.Name = "thongKeTheoNguonGmail";
			this.thongKeTheoNguonGmail.Size = new System.Drawing.Size(355, 28);
			this.thongKeTheoNguonGmail.Text = "Thống kê theo Nguồn gmail";
			// 
			// thongKeTheoThoiGian
			// 
			this.thongKeTheoThoiGian.Image = global::BaoCaoGiaoHeo.Properties.Resources.thoiGian;
			this.thongKeTheoThoiGian.Name = "thongKeTheoThoiGian";
			this.thongKeTheoThoiGian.Size = new System.Drawing.Size(355, 28);
			this.thongKeTheoThoiGian.Text = "Thống kê theo Thời gian";
			// 
			// tổngHợpSốLiệuToolStripMenuItem
			// 
			this.tổngHợpSốLiệuToolStripMenuItem.Image = global::BaoCaoGiaoHeo.Properties.Resources.packup;
			this.tổngHợpSốLiệuToolStripMenuItem.Name = "tổngHợpSốLiệuToolStripMenuItem";
			this.tổngHợpSốLiệuToolStripMenuItem.Size = new System.Drawing.Size(355, 28);
			this.tổngHợpSốLiệuToolStripMenuItem.Text = "Tổng hợp Số liệu";
			// 
			// dangNhapToolStripMenuItem
			// 
			this.dangNhapToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.dangNhapToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dangNhapToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.dangNhapToolStripMenuItem.Image = global::BaoCaoGiaoHeo.Properties.Resources.đăng_xuất;
			this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
			this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
			this.dangNhapToolStripMenuItem.Text = "Đăng nhập";
			this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.dangNhapToolStripMenuItem_Click);
			// 
			// thoátToolStripMenuItem1
			// 
			this.thoátToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.thoátToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
			this.thoátToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thoátToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
			this.thoátToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem1.Image")));
			this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
			this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(99, 28);
			this.thoátToolStripMenuItem1.Text = "Thoát";
			this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
			// 
			// FChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1453, 798);
			this.Controls.Add(this.pnTong);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FChinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo số liệu giao heo";
			this.pnTong.ResumeLayout(false);
			this.pnTong.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guiBaoCaoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLThongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeTheoNguonGmail;
        private System.Windows.Forms.ToolStripMenuItem thongKeTheoThoiGian;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpSốLiệuToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

