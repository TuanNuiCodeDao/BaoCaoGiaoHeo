using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoGiaoHeo.Info {
	public class ThongTin {
		private string tenNguoiGui;
		private string tenTraiXuat;
		private DateTime ngayNhanHeo;
		private DateTime ngayGiaoHeo;
		private string codeKH;
		private string hoTenKH;
		private string sdtKH;
		private string dOKH;
		private string diaChiGiaoHeo;
		private string tenNguoiNhanHeo;
		private bool checkDaKyNhan;
		private bool checkKyDungTen;
		private bool duongVaoTraiTot;
		private bool checkDuHeoHaiLong;
		private string phanHoiCuaKH;
		private int loiDom;
		private int viemPhoi;
		private int aHN_VuLep;
		private int dauChanViemKhop;
		private int ngoaiHinhXau;
		private int chet;
		private int phuLuc;
		private int tienGiam;
		private int tongTienSauTruPhuLuc;
		private int tienKHThieu;
		private int tienKHThua;
		private bool xuLyTienThuaTraLai;
		private string hoTenTK_CCCD;
		private string soTK_CCCD;
		private string nganHang_NoiCap;

		public ThongTin() {
			this.tenNguoiGui = "";
			this.TenTraiXuat = "";
			this.NgayNhanHeo = DateTime.Now;
			this.NgayGiaoHeo = DateTime.Now;
			this.CodeKH = "";
			this.HoTenKH = "";
			this.SdtKH = "";
			this.DOKH = "";
			this.TenNguoiNhanHeo = "";
			this.CheckDaKyNhan = true;
			this.CheckKyDungTen = true;
			this.DuongVaoTraiTot = true;
			this.CheckDuHeoHaiLong = true;
			this.PhanHoiCuaKH = "";
			this.LoiDom = 0;
			this.ViemPhoi = 0;
			this.AHN_VuLep = 0;
			this.DauChanViemKhop = 0;
			this.NgoaiHinhXau = 0;
			this.Chet = 0;
			this.PhuLuc = 0;
			this.TienGiam = 0;
			this.TongTienSauTruPhuLuc = 0;
			this.TienKHThieu = 0;
			this.TienKHThua = 0;
			this.XuLyTienThuaTraLai = true;
			this.HoTenTK_CCCD = "";
			this.SoTK_CCCD = "";
			this.NganHang_NoiCap = "";
		}

		public ThongTin(string tenNguoiGui, string tenTraiXuat, DateTime ngayNhanHeo, DateTime ngayGiaoHeo, string codeKH, string hoTenKH, string sdtKH, string dOKH, string diaChiGiaoHeo, string tenNguoiNhanHeo, bool checkDaKyNhan, bool checkKyDungTen, bool duongVaoTraiTot, bool checkDuHeoHaiLong, string phanHoiCuaKH, int loiDom, int viemPhoi, int aHN_VuLep, int dauChanViemKhop, int ngoaiHinhXau, int chet, int phuLuc, int tienGiam, int tongTienSauTruPhuLuc, int tienKHThieu, int tienKHThua, bool xuLyTienThuaTraLai, string hoTenTK_CCCD, string soTK_CCCD, string nganHang_NoiCap) {
			this.TenNguoiGui = tenNguoiGui;
			this.TenTraiXuat = tenTraiXuat;
			this.NgayNhanHeo = ngayNhanHeo;
			this.NgayGiaoHeo = ngayGiaoHeo;
			this.CodeKH = codeKH;
			this.HoTenKH = hoTenKH;
			this.SdtKH = sdtKH;
			this.DOKH = dOKH;
			this.DiaChiGiaoHeo = diaChiGiaoHeo;
			this.TenNguoiNhanHeo = tenNguoiNhanHeo;
			this.CheckDaKyNhan = checkDaKyNhan;
			this.CheckKyDungTen = checkKyDungTen;
			this.DuongVaoTraiTot = duongVaoTraiTot;
			this.CheckDuHeoHaiLong = checkDuHeoHaiLong;
			this.PhanHoiCuaKH = phanHoiCuaKH;
			this.LoiDom = loiDom;
			this.ViemPhoi = viemPhoi;
			this.AHN_VuLep = aHN_VuLep;
			this.DauChanViemKhop = dauChanViemKhop;
			this.NgoaiHinhXau = ngoaiHinhXau;
			this.Chet = chet;
			this.PhuLuc = phuLuc;
			this.TienGiam = tienGiam;
			this.TongTienSauTruPhuLuc = tongTienSauTruPhuLuc;
			this.TienKHThieu = tienKHThieu;
			this.TienKHThua = tienKHThua;
			this.XuLyTienThuaTraLai = xuLyTienThuaTraLai;
			this.HoTenTK_CCCD = hoTenTK_CCCD;
			this.SoTK_CCCD = soTK_CCCD;
			this.NganHang_NoiCap = nganHang_NoiCap;
		}

		public bool checkDuThongTin() {
			if (string.IsNullOrEmpty(TenNguoiGui) || string.IsNullOrEmpty(TenTraiXuat) || string.IsNullOrEmpty(CodeKH) ||
				string.IsNullOrEmpty(HoTenKH) || string.IsNullOrEmpty(SdtKH) || string.IsNullOrEmpty(DOKH) ||
					string.IsNullOrEmpty(DiaChiGiaoHeo) || string.IsNullOrEmpty(TenNguoiNhanHeo) || string.IsNullOrEmpty(PhanHoiCuaKH))
				return false;

			if (!checkDaKyNhan || !CheckKyDungTen) return false;

			if (xuLyTienThuaTraLai && (string.IsNullOrEmpty(HoTenTK_CCCD) ||
				string.IsNullOrEmpty(SoTK_CCCD) || string.IsNullOrEmpty(NganHang_NoiCap))) return false;

			return true;
		}

		public string getStringFistFormKhachHang() {
			return "Kính gửi Anh/Chị: "+
					"\n" + tenNguoiGui + " gửi báo cáo giao heo khách hàng xuất trại " + tenTraiXuat + ", ngày " + NgayGiaoHeo.ToString("dd/MM/yyyy") + " như sau" +
					"\n- Mã Code khách hàng: " + codeKH +
					"\n- Tên khách hàng: " + hoTenKH +
					"\n- Số điện thoại khách hàng: " + sdtKH +
					"\n- DO khách hàng: " + DOKH +
					"\n- Địa chỉ: " + diaChiGiaoHeo +
					"\n- Ngày nhận heo: " + NgayNhanHeo.ToString("dd/MM/yyyy");
		}

		string getThongSoLoiHeoForm() {
			if (checkDuHeoHaiLong) return "\n- Nhận đủ heo, khách hàng hài lòng";
			return ((loiDom > 0 ? "\n- Lòi dom: " + String.Format("{0:###,###,##0}", loiDom) + " con" : "") +
					(ViemPhoi > 0 ? "\n- Viêm phổi: " + String.Format("{0:###,###,##0}", ViemPhoi) + " con" : "") +
					(AHN_VuLep > 0 ? "\n- Âm hộ nhỏ, vú lép: " + String.Format("{0:###,###,##0}", AHN_VuLep) + " con" : "") +
					(DauChanViemKhop > 0 ? "\n- Đau chân, viêm khớp: " + String.Format("{0:###,###,##0}", DauChanViemKhop) + " con" : "") +
					(NgoaiHinhXau > 0 ? "\n- Ngoại hình xấu: " + String.Format("{0:###,###,##0}", NgoaiHinhXau) + " con" : "") +
					(Chet > 0 ? "\n- Chết: " + String.Format("{0:###,###,##0}", Chet) + " con" : ""));
		}

		public string getStringLastFormKhachHang() {
			return "\n\n" +
					"\n* Tổng kết: " +
					"\n- Người ký chứng từ: " + tenNguoiNhanHeo +
					"\n- Phản hồi của KH: " + phanHoiCuaKH +
					getThongSoLoiHeoForm() +
					"\n- Đường vào trại: " + (duongVaoTraiTot ? "Đường tốt, xe vào tận trại" : "Đường xấu, khách hàng trung chuyển") +
					"\n- Phụ lục: " + String.Format("{0:###,###,##0}", phuLuc) + " VNĐ" +
					"\n- Tiền giảm: " + String.Format("{0:###,###,##0}", TienGiam) + " VNĐ" +
					"\n- Tổng tiền sau trừ phụ lục: " + String.Format("{0:###,###,##0}", TongTienSauTruPhuLuc) + " VNĐ" +
					"\n- Tiền khách hàng thiếu: " + String.Format("{0:###,###,##0}", TienKHThieu) + " VNĐ" +
					"\n- Tiền khách hàng thừa: " + String.Format("{0:###,###,##0}", TienKHThua) + " VNĐ" +
					"\n- Xử lý tiền thừa: " + (xuLyTienThuaTraLai ? "Trả lại" : "Mua heo tiếp") +
					(xuLyTienThuaTraLai ? ("\n + Họ tên chủ tài khoản ngân hàng / Họ tên trên căn cước công dân: " + hoTenTK_CCCD +
					"\n + Số tài khoản ngân hàng / Số căn cước công dân: " + SoTK_CCCD +
					"\n + Tên ngân hàng / Nơi cấp căn cước công dân: " + NganHang_NoiCap
					) : "");
		}

		public string TenNguoiGui { get => tenNguoiGui; set => tenNguoiGui = value; }
		public string TenTraiXuat { get => tenTraiXuat; set => tenTraiXuat = value; }
		public DateTime NgayNhanHeo { get => ngayNhanHeo; set => ngayNhanHeo = value; }
		public DateTime NgayGiaoHeo { get => ngayGiaoHeo; set => ngayGiaoHeo = value; }
		public string CodeKH { get => codeKH; set => codeKH = value; }
		public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
		public string SdtKH { get => sdtKH; set => sdtKH = value; }
		public string DOKH { get => dOKH; set => dOKH = value; }
		public string DiaChiGiaoHeo { get => diaChiGiaoHeo; set => diaChiGiaoHeo = value; }
		public string TenNguoiNhanHeo { get => tenNguoiNhanHeo; set => tenNguoiNhanHeo = value; }
		public bool CheckDaKyNhan { get => checkDaKyNhan; set => checkDaKyNhan = value; }
		public bool CheckKyDungTen { get => checkKyDungTen; set => checkKyDungTen = value; }
		public bool DuongVaoTraiTot { get => duongVaoTraiTot; set => duongVaoTraiTot = value; }
		public bool CheckDuHeoHaiLong { get => checkDuHeoHaiLong; set => checkDuHeoHaiLong = value; }
		public string PhanHoiCuaKH { get => phanHoiCuaKH; set => phanHoiCuaKH = value; }
		public int LoiDom { get => loiDom; set => loiDom = value; }
		public int ViemPhoi { get => viemPhoi; set => viemPhoi = value; }
		public int AHN_VuLep { get => aHN_VuLep; set => aHN_VuLep = value; }
		public int DauChanViemKhop { get => dauChanViemKhop; set => dauChanViemKhop = value; }
		public int NgoaiHinhXau { get => ngoaiHinhXau; set => ngoaiHinhXau = value; }
		public int Chet { get => chet; set => chet = value; }
		public int PhuLuc { get => phuLuc; set => phuLuc = value; }
		public int TienGiam { get => tienGiam; set => tienGiam = value; }
		public int TongTienSauTruPhuLuc { get => tongTienSauTruPhuLuc; set => tongTienSauTruPhuLuc = value; }
		public int TienKHThieu { get => tienKHThieu; set => tienKHThieu = value; }
		public int TienKHThua { get => tienKHThua; set => tienKHThua = value; }
		public bool XuLyTienThuaTraLai { get => xuLyTienThuaTraLai; set => xuLyTienThuaTraLai = value; }
		public string HoTenTK_CCCD { get => hoTenTK_CCCD; set => hoTenTK_CCCD = value; }
		public string SoTK_CCCD { get => soTK_CCCD; set => soTK_CCCD = value; }
		public string NganHang_NoiCap { get => nganHang_NoiCap; set => nganHang_NoiCap = value; }
	}
}
