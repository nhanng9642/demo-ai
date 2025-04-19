using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_20810025
{
   
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }
        public List<KB_LoaiHang> DSLH = new List<KB_LoaiHang>();
        private void LoadForm_Load(object sender, EventArgs e)
        {
         
        }
        private void NewMethod()
        {
                this.Show();
        }
        private void bt_QLHH_Click(object sender, EventArgs e)
        {
                HangHoa f = new HangHoa(ref DSLH);
                this.Hide();
                f.ShowDialog();
                NewMethod();
        }
        private void bt_QLLH_Click(object sender, EventArgs e)
        {
                LoaiHang f = new LoaiHang(ref DSLH);
                this.Hide();
                f.ShowDialog();
                NewMethod();
        }
        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Thongbao;
            Thongbao = MessageBox.Show("Họ Tên: Dương Đức Thắng \nMã SV: 20810025\nVersions: Basic");
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Thongbao;
            Thongbao = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần mềm ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thongbao == DialogResult.OK)
                Application.Exit();
        }
        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa(ref DSLH);
            this.Hide();
            f.ShowDialog();
            f = null;
            NewMethod();
        }
        private void loạiHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoaiHang f = new LoaiHang(ref DSLH);
            this.Hide();
            f.ShowDialog();
            f = null;
            NewMethod();
        }
    }
}
