namespace BaoCaoGiaoHeo
{
    partial class F_GuiBaoCao
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.lbDangGui = new System.Windows.Forms.Label();
			this.flpnAnh = new System.Windows.Forms.FlowLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.flpnBaoCao = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.cbLoaiBaoCao = new System.Windows.Forms.ComboBox();
			this.btLuu = new System.Windows.Forms.Button();
			this.tbDiaChiMailNhan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBarGui = new System.Windows.Forms.ProgressBar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.lbDangGui);
			this.panel1.Controls.Add(this.flpnAnh);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.flpnBaoCao);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cbLoaiBaoCao);
			this.panel1.Controls.Add(this.btLuu);
			this.panel1.Controls.Add(this.tbDiaChiMailNhan);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.progressBarGui);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1394, 709);
			this.panel1.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(15, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 51);
			this.button1.TabIndex = 28;
			this.button1.Text = "Thông tin";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbDangGui
			// 
			this.lbDangGui.AutoSize = true;
			this.lbDangGui.BackColor = System.Drawing.Color.Transparent;
			this.lbDangGui.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDangGui.Location = new System.Drawing.Point(622, 119);
			this.lbDangGui.Name = "lbDangGui";
			this.lbDangGui.Size = new System.Drawing.Size(127, 25);
			this.lbDangGui.TabIndex = 27;
			this.lbDangGui.Text = "Đang gửi....";
			// 
			// flpnAnh
			// 
			this.flpnAnh.BackColor = System.Drawing.Color.Silver;
			this.flpnAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpnAnh.Location = new System.Drawing.Point(696, 161);
			this.flpnAnh.Name = "flpnAnh";
			this.flpnAnh.Size = new System.Drawing.Size(679, 530);
			this.flpnAnh.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(886, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(312, 32);
			this.label5.TabIndex = 24;
			this.label5.Text = "Danh sách ảnh đính kèm";
			// 
			// flpnBaoCao
			// 
			this.flpnBaoCao.BackColor = System.Drawing.Color.Silver;
			this.flpnBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpnBaoCao.Location = new System.Drawing.Point(15, 161);
			this.flpnBaoCao.Name = "flpnBaoCao";
			this.flpnBaoCao.Size = new System.Drawing.Size(662, 530);
			this.flpnBaoCao.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(203, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 27);
			this.label3.TabIndex = 22;
			this.label3.Text = "Loại báo cáo";
			// 
			// cbLoaiBaoCao
			// 
			this.cbLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLoaiBaoCao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbLoaiBaoCao.FormattingEnabled = true;
			this.cbLoaiBaoCao.Location = new System.Drawing.Point(424, 3);
			this.cbLoaiBaoCao.Name = "cbLoaiBaoCao";
			this.cbLoaiBaoCao.Size = new System.Drawing.Size(743, 33);
			this.cbLoaiBaoCao.TabIndex = 21;
			// 
			// btLuu
			// 
			this.btLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLuu.Location = new System.Drawing.Point(1211, 9);
			this.btLuu.Name = "btLuu";
			this.btLuu.Size = new System.Drawing.Size(135, 51);
			this.btLuu.TabIndex = 18;
			this.btLuu.Text = "Gửi";
			this.btLuu.UseVisualStyleBackColor = false;
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
			// 
			// tbDiaChiMailNhan
			// 
			this.tbDiaChiMailNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDiaChiMailNhan.Location = new System.Drawing.Point(424, 48);
			this.tbDiaChiMailNhan.Name = "tbDiaChiMailNhan";
			this.tbDiaChiMailNhan.Size = new System.Drawing.Size(743, 30);
			this.tbDiaChiMailNhan.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(205, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "Địa chỉ mail nhận";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(227, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 32);
			this.label1.TabIndex = 15;
			this.label1.Text = "Danh sách chi tiết";
			// 
			// progressBarGui
			// 
			this.progressBarGui.Location = new System.Drawing.Point(504, 112);
			this.progressBarGui.Name = "progressBarGui";
			this.progressBarGui.Size = new System.Drawing.Size(366, 43);
			this.progressBarGui.TabIndex = 26;
			// 
			// F_GuiBaoCao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1418, 733);
			this.Controls.Add(this.panel1);
			this.Name = "F_GuiBaoCao";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiaChiMailNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLuu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbLoaiBaoCao;
		private System.Windows.Forms.FlowLayoutPanel flpnAnh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.FlowLayoutPanel flpnBaoCao;
		private System.Windows.Forms.ProgressBar progressBarGui;
		private System.Windows.Forms.Label lbDangGui;
		private System.Windows.Forms.Button button1;
	}
}