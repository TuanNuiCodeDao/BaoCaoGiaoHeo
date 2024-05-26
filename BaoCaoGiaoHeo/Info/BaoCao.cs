using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoGiaoHeo.Info {
	public class BaoCao {
		private ThongTin thong_Tin;
		private List<ChiTiet> chiTietList;
		public BaoCao() {
			Thong_Tin=new ThongTin();
			ChiTietList = new List<ChiTiet>();
		}
		public BaoCao(ThongTin thong_Tin, List<ChiTiet> chiTietList) {
			this.Thong_Tin = thong_Tin;
			this.ChiTietList = chiTietList;
		}

		public ThongTin Thong_Tin { get => thong_Tin; set => thong_Tin = value; }
		public List<ChiTiet> ChiTietList { get => chiTietList; set => chiTietList = value; }
	}
}
