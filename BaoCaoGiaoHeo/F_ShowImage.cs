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
    public partial class F_ShowImage : Form
    {
        public F_ShowImage(Image im)
        {
            InitializeComponent();
            ptAnh.Image = im;
        }

    }
}
