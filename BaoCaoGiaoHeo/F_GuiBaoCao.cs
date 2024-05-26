using BaoCaoGiaoHeo.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoGiaoHeo {
	public partial class F_GuiBaoCao : Form {
		private TaiKhoan tk;
		BaoCao bc;
		private List<string> lFilePath;
		public F_GuiBaoCao(TaiKhoan tk) {
			InitializeComponent();
			this.tk = tk;
			load();
		}

		void hideThongBaoGui() {
			lbDangGui.Hide();
			progressBarGui.Hide();
		}

		void showThongBaoGui() {
			lbDangGui.Show();
			progressBarGui.Show();
		}

		private void load() {
			hideThongBaoGui();
			bc = new BaoCao();
			lFilePath = new List<string>();
			loadCBLoaiBaoCao();
			loadThongTin();
		}

		Button getButtonThemChiTiet() {
			Button btThem = new Button() { Width = 115, Height = 60 };
			btThem.Text = "Thêm";
			btThem.Click += btThemBC_Click;
			btThem.Tag = -1;
			btThem.BackColor = Color.Orange;

			return btThem;
		}

		Button getButtonThemAnh() {
			Button btThem = new Button() { Width = 115, Height = 60 };
			btThem.Text = "Thêm";
			btThem.Click += btThemAnh_Click;
			btThem.Tag = -1;
			btThem.BackColor = Color.Orange;

			return btThem;
		}

		private void loadDSChiTiet() {
			flpnBaoCao.Controls.Clear();

			for (int i = 0; i < bc.ChiTietList.Count; i++) {
				Button bt = new Button() { Width = 115, Height = 60 };
				bt.Text = "Chi tiết " + (i + 1);
				bt.MouseWheel += btChiTiet_MouseWheel;
				bt.Click += btBC_Click;
				bt.Tag = i;
				bt.BackColor = bc.ChiTietList[i].checkDuThongTin() ? Color.Green : Color.OrangeRed;
				flpnBaoCao.Controls.Add(bt);
			}

			flpnBaoCao.Controls.Add(getButtonThemChiTiet());
		}

		void btChiTiet_MouseWheel(object sender, MouseEventArgs e) {
			int id = int.Parse((sender as Button).Tag.ToString());

			if (MessageBox.Show("Xác nhận xóa chi tiết " + (id + 1) + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
				bc.ChiTietList.RemoveAt(id);
				loadDSChiTiet();
			}
		}
		public void btBC_Click(object sender, EventArgs e) {
			int id = int.Parse((sender as Button).Tag.ToString());

			F_ChiTiet f = new F_ChiTiet(bc.ChiTietList[id]);
			f.ShowDialog();

			if (f.IsSaved) bc.ChiTietList[id] = f.Chi_Tiet;

			loadDSChiTiet();
		}

		public void btThemBC_Click(object sender, EventArgs e) {
			bc.ChiTietList.Add(new ChiTiet());
			loadDSChiTiet();
			MessageBox.Show("Thêm mới báo cáo thành công", "Thông báo");
		}

		public void btThemAnh_Click(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Chọn ảnh";
			openFileDialog.Filter = "Files hình ảnh|*.jpg;*.jpeg;*.png";
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					string fileName = openFileDialog.FileName;
					Image im = Image.FromFile(fileName);
					if (im != null) {
						lFilePath.Add(fileName);
						loadDSAnh();
						MessageBox.Show("Thêm mới ảnh thành công", "Thông báo");
					}
				}
				catch {
				}
			}
		}

		private void loadDSAnh() {
			flpnAnh.Controls.Clear();

			for (int i = 0; i < lFilePath.Count; i++) {
				Image im = Image.FromFile(lFilePath[i]);
				if (im == null)
					continue;
				PictureBox pt = new PictureBox() { Width = 150, Height = 100 };
				pt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				pt.Image = im;
				pt.MouseWheel += ptAnh_MouseWheel;
				pt.Click += ptAnh_Click;
				pt.Tag = i;
				pt.BackColor = Color.OrangeRed;
				flpnAnh.Controls.Add(pt);
			}

			flpnAnh.Controls.Add(getButtonThemAnh());
		}

		public void ptAnh_Click(object sender, EventArgs e) {

			int id = int.Parse((sender as PictureBox).Tag.ToString());
			F_ShowImage f = new F_ShowImage(Image.FromFile(lFilePath[id]));
			f.ShowDialog();
		}

		public void ptAnh_MouseWheel(object sender, MouseEventArgs e) {
			int id = int.Parse((sender as PictureBox).Tag.ToString());

			if (MessageBox.Show("Xác nhận xóa ảnh " + (id + 1) + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
				lFilePath.RemoveAt(id);
				loadDSAnh();
			}
		}

		private void loadCBLoaiBaoCao() {
			cbLoaiBaoCao.Items.Clear();
			cbLoaiBaoCao.Items.Add("Báo cáo Data nội bộ");
			cbLoaiBaoCao.Items.Add("Báo cáo Data khách hàng");
			cbLoaiBaoCao.Text = "Báo cáo Data nội bộ";
		}

		private void loadThongTin() {
			loadDSChiTiet();
			loadDSAnh();
			loadBTThongTin();
		}
		private async void guiBaoCao() {
			MailMessage mailMessage = new MailMessage(tk.TenTaiKhoan, tbDiaChiMailNhan.Text, cbLoaiBaoCao.Text, "");
			mailMessage.Attachments.Clear();
			for (int i = 0; i < lFilePath.Count; i++)
				mailMessage.Attachments.Add(new Attachment(lFilePath[i]));
			mailMessage.Body = bc.Thong_Tin.getStringFistFormKhachHang();

			for (int i = 0; i < bc.ChiTietList.Count; i++)
				mailMessage.Body += "\n\n" + (i + 1) + bc.ChiTietList[i].getStringFormKhachHang();

			mailMessage.Body += bc.Thong_Tin.getStringLastFormKhachHang();

			mailMessage.SubjectEncoding = Encoding.Unicode;
			mailMessage.BodyEncoding = Encoding.Unicode;

			DisableFormControls();
			showThongBaoGui();
			await ProcessStatisticsAsync();

			HopThu.Instance.SendMail(tk, mailMessage);

			UpdateProgressBar(0);
			hideThongBaoGui();
			EnableFormControls();
			MessageBox.Show("Gửi thành công !", "Thông báo");
		}

		private void DisableFormControls() {
			Cursor.Current = Cursors.WaitCursor;

			// Vô hiệu hóa tất cả các điều khiển trên form
			foreach (Control control in this.Controls) {
				control.Enabled = false;
			}
		}

		private void EnableFormControls() {
			// Khôi phục con trỏ chuột về trạng thái mặc định
			Cursor.Current = Cursors.Default;
			foreach (Control control in this.Controls) {
				control.Enabled = true;
			}
		}

		private async Task ProcessStatisticsAsync() {
			int totalSteps = 100 + lFilePath.Count * 80;

			for (int i = 0; i <= totalSteps; i++) {
				int progressPercentage = (i * 100) / totalSteps;

				UpdateProgressBar(progressPercentage);

				await Task.Delay(50);
			}
		}

		private void UpdateProgressBar(int percentage) {

			if (percentage < progressBarGui.Minimum)
				percentage = progressBarGui.Minimum;
			if (percentage > progressBarGui.Maximum)
				percentage = progressBarGui.Maximum;

			progressBarGui.Value = percentage;
		}

		private void btLuu_Click(object sender, EventArgs e) {
			if (bc.ChiTietList.Count == 0) {
				MessageBox.Show("Hiện chưa có chi tiết nào !", "Nhắc nhở");
				return;
			}
			if (bc.Thong_Tin.checkDuThongTin() == false) {
				MessageBox.Show("Hãy đảm bảo thông tin báo cáo đã đầy đủ !", "Nhắc nhở");
				return;
			}
			foreach (ChiTiet ct in bc.ChiTietList) {
				if (ct.checkDuThongTin() == false) {
					MessageBox.Show("Hãy đảm bảo tất cả chi tiết đều đầy đủ thông tin!", "Nhắc nhở");
					return;
				}
			}
			if (string.IsNullOrEmpty(tbDiaChiMailNhan.Text)) {
				MessageBox.Show("Hãy nhập địa chỉ mail nhận trước!", "Nhắc nhở");
				return;
			}
			if (MessageBox.Show("Xác nhận gửi báo cáo '" + cbLoaiBaoCao.Text + "' ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
				guiBaoCao();
			}
		}

		void loadBTThongTin() {
			button1.BackColor = (bc.Thong_Tin.checkDuThongTin() ? Color.Green : Color.OrangeRed);
		}

		private void button1_Click(object sender, EventArgs e) {
			F_ThongTin f = new F_ThongTin(bc.Thong_Tin);
			f.ShowDialog();
			if (f.Saved) {
				bc.Thong_Tin = f.Thong_Tin;
				loadBTThongTin();
			}
		}
	}
}
