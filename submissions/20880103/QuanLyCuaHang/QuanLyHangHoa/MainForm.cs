using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_MatHang fmMatHang = new frm_MatHang();
            fmMatHang.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_LoaiHang fmLoaiHang = new frm_LoaiHang();
            fmLoaiHang.Show();
        }

        private void MatHangBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_MatHang fmMatHang = new frm_MatHang();
            fmMatHang.Show();
        }

        private void LoaiHangBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_LoaiHang fmLoaiHang = new frm_LoaiHang();
            fmLoaiHang.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lf = new Login();
            lf.Show();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login DangNhap = new Login();
            DangNhap.Show();
        }
    }
}
