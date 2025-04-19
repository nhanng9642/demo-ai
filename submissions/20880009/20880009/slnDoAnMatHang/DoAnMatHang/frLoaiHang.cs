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
    public struct LoaiHang
    {
        public string maloaihang { get; set; }
        public string tenloaihang { get; set; }
    }    
    public partial class frLoaiHang : Form
    {   
        public static List<LoaiHang> lspLoaiHang = new List<LoaiHang>();   
        public frLoaiHang()
        {
            InitializeComponent();
        }

        private void frLoaiHang_Load(object sender, EventArgs e)
        {
            label3.Text = "- Nhập mã để xóa \n- Nhập mã và tên để tìm kiếm \n- Nút hiển thị lại để load lại danh sách \n- Nhập mã và các thông tin liên quan để sửa";
            xuatlistview(lspLoaiHang);           
        }     

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!check(txtMaLoaiHang.Text, txtTenLoaiHang.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }           
            if (lspLoaiHang.Count==0)
            {
                LoaiHang lh = new LoaiHang();
                lh.maloaihang = txtMaLoaiHang.Text.Trim();
                lh.tenloaihang = txtTenLoaiHang.Text.Trim();
                lspLoaiHang.Add(lh);
                xuatlistview(lspLoaiHang);
                xoaTextBox();
            }
            else
            {
                string mahang = txtMaLoaiHang.Text.Trim().ToUpper();
                string tenloai = txtTenLoaiHang.Text.Trim().ToUpper();
                bool check = false;
                for (int i = 0; i < lspLoaiHang.Count; i++)
                {
                    if ((lspLoaiHang[i].maloaihang.ToUpper()==mahang)|| (lspLoaiHang[i].tenloaihang.ToUpper() == tenloai))
                    {
                        MessageBox.Show("Mã hoặc Tên Loại Hàng Này Đã Có");
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    LoaiHang lh = new LoaiHang();
                    lh.maloaihang = txtMaLoaiHang.Text.Trim();
                    lh.tenloaihang = txtTenLoaiHang.Text.Trim();
                    lspLoaiHang.Add(lh);
                    xuatlistview(lspLoaiHang);
                    xoaTextBox();
                }
            }
                  

        }

        void xuatlistview(List<LoaiHang> lsp)
        {
            lsvLoaiHang.Items.Clear();
            if (lsp.Count>0)
            {
                for (int i = 0; i < lsp.Count; i++)
                {
                    ListViewItem lt = new ListViewItem();
                    lt.Text = lsp[i].maloaihang;
                    lt.SubItems.Add(lsp[i].tenloaihang);
                    lsvLoaiHang.Items.Add(lt);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            string mahang = txtMaLoaiHang.Text.Trim().ToUpper();
            int vitrixoa = -1;
            for (int i = 0; i < lspLoaiHang.Count(); i++)
            {
                if (lspLoaiHang[i].maloaihang.ToUpper()==mahang)
                {
                    lspLoaiHang.RemoveAt(i);
                    vitrixoa = i;                 
                    break;
                }
            }
            if (vitrixoa >= 0)
            {
                MessageBox.Show("Bạn đã xóa thành công");
                xuatlistview(lspLoaiHang);
                xoaTextBox();
            }
            else
                MessageBox.Show("Không có mã cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!check(txtMaLoaiHang.Text,txtTenLoaiHang.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            LoaiHang lh = new LoaiHang();
            lh.maloaihang = txtMaLoaiHang.Text.Trim();
            lh.tenloaihang = txtTenLoaiHang.Text.Trim();
            string mahang = txtMaLoaiHang.Text.Trim().ToUpper();
            int vitrixoa = -1;
            for (int i = 0; i < lspLoaiHang.Count(); i++)
            {
                if (lspLoaiHang[i].maloaihang.ToUpper() == mahang)
                {
                    lspLoaiHang.RemoveAt(i);
                    vitrixoa = i;
                    break;
                }
            }
            if (vitrixoa>=0)
            {
                lspLoaiHang.Add(lh);
                xuatlistview(lspLoaiHang);
                MessageBox.Show("Bạn đã sửa thành công");
                xoaTextBox();
            }
            else
                MessageBox.Show("Không có mã cần sửa");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<LoaiHang> lsptk = new List<LoaiHang>();
            string mahang = txtMaLoaiHang.Text.Trim().ToUpper();
            string tenloai = txtTenLoaiHang.Text.Trim().ToUpper();           
            for (int i = 0; i < lspLoaiHang.Count; i++)
            {
                if (lspLoaiHang[i].maloaihang.ToUpper() == mahang||lspLoaiHang[i].tenloaihang.ToUpper()==tenloai)
                {
                    lsptk.Add(lspLoaiHang[i]);                  
                }
            }
            if (lsptk.Count > 0)
            {
                xuatlistview(lsptk);
            }
            else
                MessageBox.Show("Không có loại hàng bạn cần tìm kiếm");
        }
        void xoaTextBox()
        {
            txtMaLoaiHang.Text = "";
            txtTenLoaiHang.Text = "";
        }

        static bool check(string maloai, string tenloai)
        {
            if (maloai.Trim().Length==0||tenloai.Trim().Length==0)
            {
                return false;
            }
            return true;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            xuatlistview(lspLoaiHang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frMatHang fr = new frMatHang();
            fr.MdiParent = Form1.ActiveForm;
            fr.Show();
        }
    }
}
