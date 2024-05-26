using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoGiaoHeo {
	public class EmailBaoCao {

		private string tieuDe;
		private List<Image> lAnh;

		public EmailBaoCao() {
			TieuDe = "";
			LAnh = new List<Image>();
		}

		public string TieuDe { get => tieuDe; set => tieuDe = value; }
		public List<Image> LAnh { get => lAnh; set => lAnh = value; }
	}
}
