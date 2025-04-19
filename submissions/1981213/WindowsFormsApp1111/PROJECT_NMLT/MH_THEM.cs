using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_NMLT
{
    public partial class MH_THEM : Form
    {
        public MH_THEM()
        {
            InitializeComponent();
        }
    private void b_them_Click(object sender, EventArgs e)
        {
            PROJECT_NMLT.PRODUCTS s;
            s.MaHang = int.Parse(t_mahang.Text);
            s.TenHang = t_tenhang.Text;
            s.HanDung = int.Parse(t_handung.Text);
            s.CtySanXuat = t_ctysanxuat.Text;
            s.NamSanXuat = int.Parse(t_namsanxuat.Text);
            s.LoaiHang = t_loaihang.Text;
            PROJECT_NMLT.XL_NHIEPVU.ThemHang(s);
        }
    }
}
