using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoGiaoHeo.Info {
	public class ChiTiet {
		private string nhaXeVanChuyen;
		private string bienKiemSoat;
		private string loaiHeo;
		private int soLuongBan;
		private int soLuongKhuyenMai;
		private int trongLuongBan;
		private int trongLuongKhuyenMai;
		private int tongGiaTri;
		private int chietKhau;
		private int thueThuHo;
		private int tongThanhToan;
		private int tienKHTraTruoc;

		public ChiTiet() {
			nhaXeVanChuyen = "QD Trans";
			bienKiemSoat = "";
			loaiHeo = "Cai Sữa";
			soLuongBan = 0;
			soLuongKhuyenMai = 0;
			trongLuongBan = 0;
			trongLuongKhuyenMai = 0;
			tongGiaTri = 0;
			chietKhau = 0;
			thueThuHo = 0;
			tongThanhToan = 0;
			tienKHTraTruoc = 0;
		}

		public ChiTiet(string nhaXeVanChuyen, string bienKiemSoat, string loaiHeo, int soLuongBan, int soLuongKhuyenMai, int trongLuongBan, int trongLuongKhuyenMai, int tongGiaTri, int chietKhau, int thueThuHo, int tongThanhToan, int tienKHTraTruoc) {
			this.NhaXeVanChuyen = nhaXeVanChuyen;
			this.BienKiemSoat = bienKiemSoat;
			this.LoaiHeo = loaiHeo;
			this.SoLuongBan = soLuongBan;
			this.SoLuongKhuyenMai = soLuongKhuyenMai;
			this.TrongLuongBan = trongLuongBan;
			this.TrongLuongKhuyenMai = trongLuongKhuyenMai;
			this.TongGiaTri = tongGiaTri;
			this.ChietKhau = chietKhau;
			this.ThueThuHo = thueThuHo;
			this.TongThanhToan = tongThanhToan;
			this.TienKHTraTruoc = tienKHTraTruoc;
		}

		public bool checkDuThongTin() {
			if (string.IsNullOrEmpty(bienKiemSoat))
				return false;
			return true;
		}

		public string getStringFormKhachHang() {
			double trongLuong = trongLuongBan;
			double soLuong = soLuongBan; ;
			if (soLuong == 0) soLuong = 1;

			string tlbq = Math.Round(trongLuong / soLuong, 2) + " kg/con";

			return ".Xe " + BienKiemSoat +
					"\n- Nhà xe vận chuyển: " + nhaXeVanChuyen +
					"\n- Loại heo: " + loaiHeo+
					"\n- Số lượng bán: " + String.Format("{0:###,###,##0}", soLuongBan) + " con" +
					"\n- Trọng lượng bán: " + String.Format("{0:###,###,##0}", trongLuongBan) + " kg" +
					"\n- Số lượng khuyến mãi: " + String.Format("{0:###,###,##0}", soLuongKhuyenMai) + " con" +
					"\n- Trọng lượng khuyến mãi: " + String.Format("{0:###,###,##0}", trongLuongKhuyenMai) + " kg" +
					"\n- Trọng lượng bình quân heo bán: " + tlbq +
					"\n- Tổng giá trị đơn hàng: " + String.Format("{0:###,###,##0}", tongGiaTri) + " VNĐ" +
					"\n- Tổng số tiền chiết khấu: " + String.Format("{0:###,###,##0}", chietKhau) + " VNĐ" +
					"\n- Thuế thu nhập cá nhân thu hộ: " + String.Format("{0:###,###,##0}", thueThuHo) + " VNĐ" +
					"\n- Tổng cộng tiền thanh toán: " + String.Format("{0:###,###,##0}", tongThanhToan) + " VNĐ" +
					"\n- Tổng tiền khách hàng trả trước: " + String.Format("{0:###,###,##0}", tienKHTraTruoc) + " VNĐ";
		}

		public string NhaXeVanChuyen { get => nhaXeVanChuyen; set => nhaXeVanChuyen = value; }
		public string BienKiemSoat { get => bienKiemSoat; set => bienKiemSoat = value; }
		public string LoaiHeo { get => loaiHeo; set => loaiHeo = value; }
		public int SoLuongBan { get => soLuongBan; set => soLuongBan = value; }
		public int SoLuongKhuyenMai { get => soLuongKhuyenMai; set => soLuongKhuyenMai = value; }
		public int TrongLuongBan { get => trongLuongBan; set => trongLuongBan = value; }
		public int TrongLuongKhuyenMai { get => trongLuongKhuyenMai; set => trongLuongKhuyenMai = value; }
		public int TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
		public int ChietKhau { get => chietKhau; set => chietKhau = value; }
		public int ThueThuHo { get => thueThuHo; set => thueThuHo = value; }
		public int TongThanhToan { get => tongThanhToan; set => tongThanhToan = value; }
		public int TienKHTraTruoc { get => tienKHTraTruoc; set => tienKHTraTruoc = value; }
	}
}
