using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace BaoCaoGiaoHeo
{
    public partial class F_DangNhap : Form
    {
        private TaiKhoan tk;
        public TaiKhoan Tk { get => tk; set => tk = value; }
        public F_DangNhap()
        {
            InitializeComponent();
            Tk = null;
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (btShow.Text == "Hiện")
            {
                tbMatKhau.UseSystemPasswordChar = false;
                btShow.Text = "Ẩn";
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                btShow.Text = "Hiện";
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            tk = new TaiKhoan(tbTenTaiKhoan.Text, tbMatKhau.Text);
            btDangNhap.Enabled = false;
            btShow.Enabled = false;
            btThoat.Enabled = false;
   //         System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage(tk.TenTaiKhoan, "pholetrung@gmail.com", "'Check Login", tk.TenTaiKhoan + " đã đăng nhập thành công");
			//mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
			//mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
			if (/*HopThu.Instance.SendMail(tk,mailMessage)==*/true) {
                MessageBox.Show("Đăng nhập thành công !", "Thông báo");
                Close();
            }
            btDangNhap.Enabled = true;
            btShow.Enabled = true;
            btThoat.Enabled = true;
            Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", "https://myaccount.google.com/u/3/apppasswords?utm_source=google-account&utm_medium=myaccountsecurity&utm_campaign=tsv-settings&rapt=AEjHL4M-LojgD-7mS4MIm5bZkqQcyrgjzziPl0344S44lO8XeZEZWOv9JCO79byEoCKS_s42d_Yc3IOW2toCNs-gsrjyuCG0IA");
        }
    }
}
