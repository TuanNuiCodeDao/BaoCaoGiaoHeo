using BaoCaoGiaoHeo.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoGiaoHeo {
	public partial class F_ChiTiet : Form {
		private ChiTiet chi_Tiet;
		private bool isSaved;
		private static System.Drawing.Color colorError = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));

		public bool IsSaved { get => isSaved; set => isSaved = value; }
		public ChiTiet Chi_Tiet { get => chi_Tiet; set => chi_Tiet = value; }

		public F_ChiTiet(ChiTiet chiTiet) {
			InitializeComponent();
			this.chi_Tiet = chiTiet;
			IsSaved = false;
			setBegin();
			loadCBLoaiHeo();
			loadThongTin();
		}
		private void loadThongTin() {
			cbLoaiHeo.Text = chi_Tiet.LoaiHeo;
			if (chi_Tiet.NhaXeVanChuyen == "QD Trans") radioCheckNhaXeQDTran.Checked = true;
			else radioNhaXeDinhThiPhuong.Checked = true;
			tbBienKiemSoat.Text = chi_Tiet.BienKiemSoat;
			nudSoLuongBan.Value = chi_Tiet.SoLuongBan;
			nudSoLuongKhuyenMai.Value = chi_Tiet.SoLuongKhuyenMai;
			nudSoLuongBan.Value = chi_Tiet.TrongLuongBan;
			nudTrongLuongKhuyenMai.Value = chi_Tiet.TrongLuongKhuyenMai;
			nudTongGiaTri.Value = chi_Tiet.TongGiaTri;
			nudChietKhau.Value = chi_Tiet.ChietKhau;
			nudThueThuHo.Value = chi_Tiet.ThueThuHo;
			nudTongTienThanhToan.Value = chi_Tiet.TongThanhToan;
			nudTienKHTraTruoc.Value = chi_Tiet.TienKHTraTruoc;
		}
		private void loadCBLoaiHeo() {
			cbLoaiHeo.Items.Clear();
			cbLoaiHeo.Items.Add("Cai Sữa");
			cbLoaiHeo.Items.Add("Cai Sữa  đời con GF24");
			cbLoaiHeo.Items.Add("Hậu Bị GF24");
			cbLoaiHeo.Items.Add("Heo Nọc");
			cbLoaiHeo.Text = "Cai Sữa";
		}
		private void setBegin() {
			tbBienKiemSoat.BackColor = colorError;
		}
		private void btDangNhap_Click(object sender, EventArgs e) {
			chi_Tiet = new ChiTiet(radioCheckNhaXeQDTran.Checked ? "QD Trans" : "Đinh Thị Phương"
				, tbBienKiemSoat.Text, cbLoaiHeo.Text, (int)nudSoLuongBan.Value, (int)nudSoLuongKhuyenMai.Value
				, (int)nudTrongLuongBan.Value, (int)nudTrongLuongKhuyenMai.Value, (int)nudTongGiaTri.Value
				, (int)nudChietKhau.Value, (int)nudThueThuHo.Value, (int)nudTongTienThanhToan.Value, (int)nudTienKHTraTruoc.Value);
			IsSaved = true;
			Close();
		}

		private void panel5_Paint(object sender, PaintEventArgs e) {

		}

		private void tbBienKiemSoat_TextChanged(object sender, EventArgs e) {
			tbBienKiemSoat.Text = tbBienKiemSoat.Text.TrimStart();
			if (string.IsNullOrEmpty(tbBienKiemSoat.Text))
				tbBienKiemSoat.BackColor = colorError;
			else
				tbBienKiemSoat.BackColor = SystemColors.Window;
		}

		private void btReset_Click(object sender, EventArgs e) {
			loadThongTin();
		}

		private void F_BaoCaoNoiBo_Load(object sender, EventArgs e) {

		}

		private void nudTrongLuongBan_ValueChanged(object sender, EventArgs e) {
			setTLBQ();
		}

		private void nudSoLuongBan_ValueChanged(object sender, EventArgs e) {
			setTLBQ();
		}

		void setTLBQ() {
			double trongLuong = (int)nudTrongLuongBan.Value;
			double soLuong = (int)nudSoLuongBan.Value;
			if (soLuong == 0) soLuong = 1;

			tbTLBQ.Text = Math.Round(trongLuong / soLuong, 2) + "";
		}
	}
}
