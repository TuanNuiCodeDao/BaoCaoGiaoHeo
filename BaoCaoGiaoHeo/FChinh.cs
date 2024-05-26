using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoGiaoHeo
{
    public partial class FChinh : Form
    {
        private TaiKhoan tk;
        private Form formCon; 
        public FChinh()
        {
            InitializeComponent();
            tk = null;
            setLogOut();
        }
        private void OpenChildForm(Form childForm)
        {
            if (formCon != null)
            {
                formCon.Close();
            }
            formCon = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void setLogOut()
        {
            guiBaoCaoToolStripMenuItem1.Enabled = false;
            qLThongKeToolStripMenuItem.Enabled = false;
            dangNhapToolStripMenuItem.Text = "Đăng nhập";
            if (formCon != null)
                formCon.Close();
        }
        private void setLogIn()
        {
            guiBaoCaoToolStripMenuItem1.Enabled = true;
            qLThongKeToolStripMenuItem.Enabled = true;
            dangNhapToolStripMenuItem.Text = "Đăng xuất";
            OpenChildForm(new F_GuiBaoCao(tk));
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dangNhapToolStripMenuItem.Text=="Đăng xuất")
            {
                setLogOut();
            }
            else
            {
                F_DangNhap f = new F_DangNhap();
                f.ShowDialog();
                tk = f.Tk;
                if(tk==null)
                {
                    setLogOut();
                }
                else
                {
                    setLogIn();
                }
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

		private void guiBaoCaoToolStripMenuItem1_Click(object sender, EventArgs e) {
			OpenChildForm(new F_GuiBaoCao(tk));
		}
	}
}
