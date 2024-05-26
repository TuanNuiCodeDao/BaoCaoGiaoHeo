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
	public partial class F_ThongTin : Form {
		private ThongTin thong_Tin;
		private bool saved;
		private static System.Drawing.Color colorError = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
		public F_ThongTin(ThongTin thong_Tin) {
			InitializeComponent();
			this.Thong_Tin = thong_Tin;
			Saved = false;
			setBegin();
			loadThongTin();
		}

		private void setBegin() {
			tbPhanHoiKH.BackColor = colorError;
			tbTenNguoiGui.BackColor = colorError;
			tbTenTraiXuat.BackColor = colorError;
			tbCodeKhachHang.BackColor = colorError;
			tbTenKhachHang.BackColor = colorError;
			tbSDTKhachHang.BackColor = colorError;
			tbDOKhachHang.BackColor = colorError;
			tbDiaChiGiaoHeo.BackColor = colorError;
			tbHoTenNguoiNhanHeo.BackColor = colorError;
			tbHoTen_TienThua.BackColor = colorError;
			tbSoTK_CCCD.BackColor = colorError;
			tbNganHang_NoiCap.BackColor = colorError;
		}

		void loadThongTin() {
			tbTenKhachHang.Text = thong_Tin.HoTenKH;
			tbTenNguoiGui.Text = thong_Tin.TenNguoiGui;
			tbTenTraiXuat.Text = thong_Tin.TenTraiXuat;
			dateNgayNhanHeo.Value = thong_Tin.NgayNhanHeo;
			dateNgayGiaoHeo.Value = thong_Tin.NgayGiaoHeo;
			tbCodeKhachHang.Text = thong_Tin.CodeKH;
			tbSDTKhachHang.Text = thong_Tin.SdtKH;
			tbDOKhachHang.Text = thong_Tin.DOKH;
			tbDiaChiGiaoHeo.Text = thong_Tin.DiaChiGiaoHeo;
			tbHoTenNguoiNhanHeo.Text = thong_Tin.TenNguoiNhanHeo;
			checkDaKyNhanHeo.Checked = thong_Tin.CheckDaKyNhan;
			if (thong_Tin.CheckKyDungTen) radioKyDungTen.Checked = true;
			else radioKySaiTen.Checked = true;
			checkNhanDuHeo_KHHaiLong.Checked = thong_Tin.CheckDuHeoHaiLong;
			tbPhanHoiKH.Text = thong_Tin.PhanHoiCuaKH;
			nudLoiDom.Value = thong_Tin.LoiDom;
			nudViemPhoi.Value = thong_Tin.ViemPhoi;
			nudAHN_VuLep.Value = thong_Tin.AHN_VuLep;
			nudViemKhop.Value = thong_Tin.DauChanViemKhop;
			nudNgoaiHinhXau.Value = thong_Tin.NgoaiHinhXau;
			nudChet.Value = thong_Tin.Chet;
			nudPhuLuc.Value = thong_Tin.PhuLuc;
			nudSoTienGiam.Value = thong_Tin.TienGiam;
			nudTienThanhToanSauTru.Value = thong_Tin.TongTienSauTruPhuLuc;
			nudTienKHThieu.Value = thong_Tin.TienKHThieu;
			nudTienKHThua.Value = thong_Tin.TienKHThua;
			if (thong_Tin.XuLyTienThuaTraLai) radioTraLaiTienThua.Checked = true;
			else radioMuaHeoTiep.Checked = true;
			tbHoTen_TienThua.Text = thong_Tin.HoTenTK_CCCD;
			tbSoTK_CCCD.Text = thong_Tin.SoTK_CCCD;
			tbNganHang_NoiCap.Text = thong_Tin.NganHang_NoiCap;
			checkNhanDuHeo_KHHaiLong.Checked = thong_Tin.CheckDuHeoHaiLong;
			if (checkNhanDuHeo_KHHaiLong.Checked == true) pnLoi.Hide();
			else pnLoi.Show();
		}

		private void button2_Click_1(object sender, EventArgs e) {
			thong_Tin = new ThongTin(tbTenNguoiGui.Text, tbTenTraiXuat.Text, (DateTime)dateNgayNhanHeo.Value, (DateTime)dateNgayGiaoHeo.Value,
				tbCodeKhachHang.Text, tbTenKhachHang.Text, tbSDTKhachHang.Text, tbDOKhachHang.Text,
				tbDiaChiGiaoHeo.Text, tbHoTenNguoiNhanHeo.Text, checkDaKyNhanHeo.Checked,
				radioKyDungTen.Checked, radioDuongVaoTot.Checked,
				checkNhanDuHeo_KHHaiLong.Checked, tbPhanHoiKH.Text, (int)nudLoiDom.Value, (int)nudViemPhoi.Value,
				(int)nudAHN_VuLep.Value, (int)nudViemKhop.Value, (int)nudNgoaiHinhXau.Value, (int)nudChet.Value,
				(int)nudPhuLuc.Value, (int)nudSoTienGiam.Value, (int)nudTienThanhToanSauTru.Value, (int)nudTienKHThieu.Value,
				(int)nudTienKHThua.Value, radioTraLaiTienThua.Checked, tbHoTen_TienThua.Text,
				tbSoTK_CCCD.Text, tbNganHang_NoiCap.Text);
			Saved = true;
			Close();
		}

		private void F_ThongTin_Load(object sender, EventArgs e) {

		}
		public ThongTin Thong_Tin { get => thong_Tin; set => thong_Tin = value; }
		public bool Saved { get => saved; set => saved = value; }

		private void label32_Click(object sender, EventArgs e) {

		}

		private void radioMuaHeoTiep_CheckedChanged(object sender, EventArgs e) {
		}

		private void radioTraLaiTienThua_CheckedChanged(object sender, EventArgs e) {
			if (radioTraLaiTienThua.Checked) {
				pnThongTinTraTienThua.Show();
			}
			else {
				pnThongTinTraTienThua.Hide();
				clearThongTinTraTienThua();
			}
		}

		private void clearThongTinTraTienThua() {
			tbHoTen_TienThua.Text = "";
			tbNganHang_NoiCap.Text = "";
			tbSoTK_CCCD.Text = "";
		}


		private void button1_Click(object sender, EventArgs e) {
			loadThongTin();
		}

		private void checkDaKyNhanHeo_CheckedChanged(object sender, EventArgs e) {
			if (checkDaKyNhanHeo.Checked) {
				checkDaKyNhanHeo.ForeColor = Color.Blue;
			}
			else {
				checkDaKyNhanHeo.ForeColor = Color.Red;
			}
		}

		private void tbPhanHoiKH_TextChanged(object sender, EventArgs e) {
			tbPhanHoiKH.Text = tbPhanHoiKH.Text.TrimStart();
			if (string.IsNullOrEmpty(tbPhanHoiKH.Text))
				tbPhanHoiKH.BackColor = colorError;
			else
				tbPhanHoiKH.BackColor = SystemColors.Window;
		}

		private void tbTenNguoiGui_TextChanged(object sender, EventArgs e) {
			tbTenNguoiGui.Text = tbTenNguoiGui.Text.TrimStart();
			if (string.IsNullOrEmpty(tbTenNguoiGui.Text))
				tbTenNguoiGui.BackColor = colorError;
			else
				tbTenNguoiGui.BackColor = SystemColors.Window;
		}

		private void tbTenTraiXuat_TextChanged(object sender, EventArgs e) {
			tbTenTraiXuat.Text = tbTenTraiXuat.Text.TrimStart();
			if (string.IsNullOrEmpty(tbTenTraiXuat.Text))
				tbTenTraiXuat.BackColor = colorError;
			else
				tbTenTraiXuat.BackColor = SystemColors.Window;
		}

		private void tbCodeKhachHang_TextChanged(object sender, EventArgs e) {
			tbCodeKhachHang.Text = tbCodeKhachHang.Text.TrimStart();
			if (string.IsNullOrEmpty(tbCodeKhachHang.Text))
				tbCodeKhachHang.BackColor = colorError;
			else
				tbCodeKhachHang.BackColor = SystemColors.Window;
		}

		private void tbTenKhachHang_TextChanged(object sender, EventArgs e) {
			tbTenKhachHang.Text = tbTenKhachHang.Text.TrimStart();
			if (string.IsNullOrEmpty(tbTenKhachHang.Text))
				tbTenKhachHang.BackColor = colorError;
			else
				tbTenKhachHang.BackColor = SystemColors.Window;
		}

		private void tbSDTKhachHang_TextChanged(object sender, EventArgs e) {
			tbSDTKhachHang.Text = tbSDTKhachHang.Text.TrimStart();
			if (string.IsNullOrEmpty(tbSDTKhachHang.Text))
				tbSDTKhachHang.BackColor = colorError;
			else
				tbSDTKhachHang.BackColor = SystemColors.Window;
		}

		private void tbDOKhachHang_TextChanged(object sender, EventArgs e) {
			tbDOKhachHang.Text = tbDOKhachHang.Text.TrimStart();
			if (string.IsNullOrEmpty(tbDOKhachHang.Text))
				tbDOKhachHang.BackColor = colorError;
			else
				tbDOKhachHang.BackColor = SystemColors.Window;
		}

		private void tbDiaChiGiaoHeo_TextChanged(object sender, EventArgs e) {
			tbDiaChiGiaoHeo.Text = tbDiaChiGiaoHeo.Text.TrimStart();
			if (string.IsNullOrEmpty(tbDiaChiGiaoHeo.Text))
				tbDiaChiGiaoHeo.BackColor = colorError;
			else
				tbDiaChiGiaoHeo.BackColor = SystemColors.Window;
		}


		private void tbHoTenNguoiNhanHeo_TextChanged(object sender, EventArgs e) {
			tbHoTenNguoiNhanHeo.Text = tbHoTenNguoiNhanHeo.Text.TrimStart();
			if (string.IsNullOrEmpty(tbHoTenNguoiNhanHeo.Text))
				tbHoTenNguoiNhanHeo.BackColor = colorError;
			else
				tbHoTenNguoiNhanHeo.BackColor = SystemColors.Window;
		}

		private void tbHoTen_TienThua_TextChanged(object sender, EventArgs e) {
			tbHoTen_TienThua.Text = tbHoTen_TienThua.Text.TrimStart();
			if (string.IsNullOrEmpty(tbHoTen_TienThua.Text))
				tbHoTen_TienThua.BackColor = colorError;
			else
				tbHoTen_TienThua.BackColor = SystemColors.Window;
		}

		private void tbSoTK_CCCD_TextChanged(object sender, EventArgs e) {
			tbSoTK_CCCD.Text = tbSoTK_CCCD.Text.TrimStart();
			if (string.IsNullOrEmpty(tbSoTK_CCCD.Text))
				tbSoTK_CCCD.BackColor = colorError;
			else
				tbSoTK_CCCD.BackColor = SystemColors.Window;
		}

		private void tbNganHang_NoiCap_TextChanged(object sender, EventArgs e) {
			tbNganHang_NoiCap.Text = tbNganHang_NoiCap.Text.TrimStart();
			if (string.IsNullOrEmpty(tbNganHang_NoiCap.Text))
				tbNganHang_NoiCap.BackColor = colorError;
			else
				tbNganHang_NoiCap.BackColor = SystemColors.Window;
		}

		private void checkNhanDuHeo_KHHaiLong_CheckedChanged(object sender, EventArgs e) {
			if (checkNhanDuHeo_KHHaiLong.Checked) {
				nudAHN_VuLep.Value = 0;
				nudLoiDom.Value = 0;
				nudNgoaiHinhXau.Value = 0;
				nudViemKhop.Value = 0;
				nudViemPhoi.Value = 0;
				nudChet.Value = 0;
				pnLoi.Hide();
			}
			else pnLoi.Show();
		}

		private void nudLoiDom_ValueChanged(object sender, EventArgs e) {
		}

		private void nudViemPhoi_ValueChanged(object sender, EventArgs e) {
		}

		private void nudAHN_VuLep_ValueChanged(object sender, EventArgs e) {
		}

		private void nudViemKhop_ValueChanged(object sender, EventArgs e) {
		}

		private void nudNgoaiHinhXau_ValueChanged(object sender, EventArgs e) {
		}

		private void nudChet_ValueChanged(object sender, EventArgs e) {
		}
	}
}
