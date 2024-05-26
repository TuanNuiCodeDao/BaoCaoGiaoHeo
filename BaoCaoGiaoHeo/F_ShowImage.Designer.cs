namespace BaoCaoGiaoHeo
{
    partial class F_ShowImage
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
			this.ptAnh = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// ptAnh
			// 
			this.ptAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ptAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptAnh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptAnh.Location = new System.Drawing.Point(0, 0);
			this.ptAnh.Name = "ptAnh";
			this.ptAnh.Size = new System.Drawing.Size(1412, 797);
			this.ptAnh.TabIndex = 0;
			this.ptAnh.TabStop = false;
			// 
			// F_ShowImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1412, 797);
			this.Controls.Add(this.ptAnh);
			this.Name = "F_ShowImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image";
			((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptAnh;
    }
}