using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace QuanLyCuaHang
{
    public partial class QuanLyCuaHang : Form
    {
        public QuanLyCuaHang()
        {
            InitializeComponent();
        }

        private void btnQLMatHang_Click(object sender, EventArgs e)
        {
            Form frmQLMatHang = new QuanLyMatHang();
            frmQLMatHang.Show();
        }

        private void btnQLLoaiHang_Click(object sender, EventArgs e)
        {
            Form frmQLLoaiHang = new QuanLyLoaiHang();
            frmQLLoaiHang.Show();
        }

        private void mnu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frmInfo = new frmInfo();
            frmInfo.Show();
        }
    }
}
