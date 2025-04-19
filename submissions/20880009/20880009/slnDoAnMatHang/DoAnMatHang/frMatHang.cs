using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMatHang
{
    public struct MatHang
    {
        public string MaHang;
        public string TenHang;
        public DateTime HanDung;
        public string CTYSX;
        public int NamSX;
        public string LoaiHang;
    }
    public partial class frMatHang : Form
    {
        public static List<MatHang> lspMatHang = new List<MatHang>();
        public frMatHang()
        {
            InitializeComponent();
        }

        private void frMatHang_Load(object sender, EventArgs e)
        {
            label7.Text = "- Nhập mã để xóa \n- Nhập mã và tên để tìm kiếm \n- Nút hiển thị lại để load lại danh sách\n- Nhập mã và các thông tin liên quan để sửa"; 
            xuatlistview(lspMatHang);
            XuatLoaiHang();

        }
        private void XuatLoaiHang()
        {
            List<LoaiHang> lsp = frLoaiHang.lspLoaiHang;
            List<LoaiHang> lsp1 = new List<LoaiHang>();
            for (int i = 0; i < lsp.Count; i++)
            {
                lsp1.Add(lsp[i]);
            }
            if (lsp1.Count > 0)
            {
                cbLoaiHang.DataSource = lsp1;
                cbLoaiHang.DisplayMember = "tenloaihang";
                cbLoaiHang.ValueMember = "maloaihang";               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text.Trim();
            string tenhang = txtTenHang.Text.Trim();
            string handung = txtHanDung.Text.Trim();
            string congty = txtCongTy.Text.Trim();
            string namsx = txtNam.Text.Trim();

            if (!check(mahang, tenhang, handung, congty, namsx))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            if (lspMatHang.Count == 0)
            {
                MatHang lh = new MatHang();
                lh.MaHang = mahang;
                lh.TenHang = tenhang;
                lh.HanDung = DateTime.Parse(handung);
                lh.NamSX = int.Parse(namsx);
                lh.CTYSX = congty;
                LoaiHang c = (LoaiHang)cbLoaiHang.SelectedItem;
                lh.LoaiHang = c.tenloaihang;
                lspMatHang.Add(lh);
                xuatlistview(lspMatHang);
                xoaTextBox();
            }
            else
            {

                bool check = false;
                for (int i = 0; i < lspMatHang.Count; i++)
                {
                    if (lspMatHang[i].MaHang.ToUpper() == mahang.ToUpper())
                    {
                        MessageBox.Show("Mã hoặc Tên Loại Hàng Này Đã Có");
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    MatHang lh = new MatHang();
                    lh.MaHang = mahang;
                    lh.TenHang = tenhang;
                    lh.HanDung = DateTime.Parse(handung);
                    lh.NamSX = int.Parse(namsx);
                    lh.CTYSX = congty;
                    LoaiHang c = (LoaiHang)cbLoaiHang.SelectedItem;
                    lh.LoaiHang = c.tenloaihang;
                    lspMatHang.Add(lh);
                    xuatlistview(lspMatHang);
                    xoaTextBox();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text.Trim();
            string tenhang = txtTenHang.Text.Trim();
            string handung = txtHanDung.Text.Trim();
            string congty = txtCongTy.Text.Trim();
            string namsx = txtNam.Text.Trim();
            if (!check(mahang, tenhang, handung, congty, namsx))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            MatHang lh = new MatHang();
            lh.MaHang = mahang;
            lh.TenHang = tenhang;
            lh.HanDung = DateTime.Parse(handung);
            lh.NamSX = int.Parse(namsx);
            lh.CTYSX = congty;
            LoaiHang c = (LoaiHang)cbLoaiHang.SelectedItem;
            lh.LoaiHang = c.tenloaihang;
            int vitrixoa = -1;
            for (int i = 0; i < lspMatHang.Count(); i++)
            {
                if (lspMatHang[i].MaHang.ToUpper() == mahang.ToUpper())
                {
                    lspMatHang.RemoveAt(i);
                    vitrixoa = i;
                    break;
                }
            }
            if (vitrixoa >= 0)
            {
                lspMatHang.Add(lh);
                xuatlistview(lspMatHang);
                MessageBox.Show("Bạn đã sửa thành công");
                xoaTextBox();
            }
            else
                MessageBox.Show("Không có mã cần sửa");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text.Trim().ToUpper();
            int vitrixoa = -1;
            for (int i = 0; i < lspMatHang.Count(); i++)
            {
                if (lspMatHang[i].MaHang.ToUpper() == mahang)
                {
                    lspMatHang.RemoveAt(i);
                    vitrixoa = i;
                    break;
                }
            }
            if (vitrixoa >= 0)
            {
                MessageBox.Show("Bạn đã xóa thành công");
                xuatlistview(lspMatHang);
                xoaTextBox();
            }
            else
                MessageBox.Show("Không có mã cần xóa");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<MatHang> lsptk = new List<MatHang>();
            string mahang = txtMaHang.Text.Trim().ToUpper();
            string tenhang = txtTenHang.Text.Trim().ToUpper();
            for (int i = 0; i < lspMatHang.Count; i++)
            {
                if (lspMatHang[i].MaHang.ToUpper() == mahang || lspMatHang[i].TenHang.ToUpper() == tenhang)
                {
                    lsptk.Add(lspMatHang[i]);
                }
            }
            if (lsptk.Count > 0)
            {
                xuatlistview(lsptk);
            }
            else
                MessageBox.Show("Không có loại hàng bạn cần tìm kiếm");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            xuatlistview(lspMatHang);
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frLoaiHang fr = new frLoaiHang();
            fr.MdiParent = Form1.ActiveForm;
            fr.Show();
        }

        void xuatlistview(List<MatHang> lsp)
        {
            lsvLoaiHang.Items.Clear();
            if (lsp.Count > 0)
            {
                for (int i = 0; i < lsp.Count; i++)
                {
                    ListViewItem lt = new ListViewItem();
                    lt.Text = lsp[i].MaHang;
                    lt.SubItems.Add(lsp[i].TenHang);
                    lt.SubItems.Add(lsp[i].HanDung.ToShortDateString());
                    lt.SubItems.Add(lsp[i].CTYSX);
                    lt.SubItems.Add(lsp[i].NamSX.ToString());
                    lt.SubItems.Add(lsp[i].LoaiHang);
                    lsvLoaiHang.Items.Add(lt);
                }
            }
        }

        void xoaTextBox()
        {
            txtMaHang.Text = "";
            txtCongTy.Text = "";
            txtHanDung.Text = "";
            txtNam.Text = "";
            txtTenHang.Text = "";
        }

        static bool check(string mahang, string tenhang, string handung, string congty, string nam)
        {
            if (mahang.Trim().Length == 0 || tenhang.Trim().Length == 0 ||
                handung.Trim().Length == 0 || congty.Trim().Length == 0 || nam.Trim().Length == 0)
            {
                return false;
            }
            DateTime check = new DateTime();
            if (!DateTime.TryParse(handung, out check))
            {
                return false;
            }
            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string mahang = txtMaHang.Text.Trim().ToUpper();
            int vitrisua = -1;
            for (int i = 0; i < lspMatHang.Count(); i++)
            {
                if (lspMatHang[i].MaHang.ToUpper() == mahang)
                {               
                    vitrisua = i;
                    break;
                }
            }
            if (vitrisua >= 0)
            {
                txtCongTy.Text = lspMatHang[vitrisua].CTYSX;
                txtHanDung.Text = lspMatHang[vitrisua].HanDung.ToShortDateString();
                txtNam.Text = lspMatHang[vitrisua].NamSX.ToString();
                txtTenHang.Text = lspMatHang[vitrisua].TenHang;
                int cb = 0;
                List<LoaiHang> lsp = frLoaiHang.lspLoaiHang;
                for (int i = 0; i < lsp.Count(); i++)
                {
                    if (lsp[i].tenloaihang.ToUpper() == lspMatHang[vitrisua].LoaiHang.ToUpper())
                    {
                        cb = i;
                        break;
                    }
                }
                cbLoaiHang.SelectedValue = lsp[cb].maloaihang;                
            }
            else
                MessageBox.Show("Không có mã cần sửa");
        }
    }
}
