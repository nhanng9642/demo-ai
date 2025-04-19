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
    public partial class MH_SANPHAM : Form
    {
        public MH_SANPHAM()
        {
            InitializeComponent();
        }

        private void b_timkiem_Click(object sender, EventArgs e)
        {
            List<PROJECT_NMLT.PRODUCTS> kq = new List<PROJECT_NMLT.PRODUCTS>(); //render danh sach
            var keyword = string.Empty;
            keyword = t_timkiem.Text;
            kq = PROJECT_NMLT.XL_NHIEPVU.DocDanhSachHang(keyword);
            foreach (var s in kq)
            {
                l_mahang.Text = s.MaHang.ToString();
                l_tenhang.Text = s.TenHang;
                l_handung.Text = s.HanDung.ToString();
                l_ctysanxuat.Text = s.CtySanXuat;
                l_namsanxuat.Text = s.NamSanXuat.ToString();
                l_loaihang.Text = s.LoaiHang;
                
            }

        }

        private void b_mhthem_Click(object sender, EventArgs e)
        {
            var mh = new MH_THEM();
            mh.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void b_timkiemg_Click(object sender, EventArgs e)
        {
            
            List<PROJECT_NMLT.PRODUCTS> kq = new List<PROJECT_NMLT.PRODUCTS>();
            var keyword = string.Empty;
            keyword = t_timkiem.Text;
            kq = PROJECT_NMLT.XL_NHIEPVU.DocDanhSachHang(keyword);
            DataTable table = new DataTable();
            table.Columns.Add("Ma Hang", typeof(int));
            table.Columns.Add("Ten Hang", typeof(string));
            table.Columns.Add("Han Dung", typeof(int));
            table.Columns.Add("Cty San Xuat", typeof(string));
            table.Columns.Add("Nam San Xuat", typeof(int));
            table.Columns.Add("Loai Hang", typeof(string));
            foreach (var s in kq)
            {
              table.Rows.Add(s.MaHang, s.TenHang, s.HanDung, s.CtySanXuat, s.NamSanXuat, s.LoaiHang);
            }
            dataGridView1.DataSource = table;

        }

        private void b_suasanpham_Click(object sender, EventArgs e)
        {
            var mh = new MH_SUASANPHAM();
            mh.ShowDialog();
        }
    }
}
