using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormLoaiHang : Form
    {
        private int indexSua = -1;
        public bool CoThayDoi = false;
        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void btnLuuLoaiHang_Click(object sender, EventArgs e)
        {
            txtTimLoaiHang.Text = "";
            if(indexSua == -1)
            {
                LoaiHang lh = new LoaiHang();            
                lh.TenLoaiHang = txtLoaiHang.Text;
                lh.MaLoaiHang = txtMaLoaiHang.Text;
                FormMatHang.dsLoaiHang.Add(lh);
                HienThiDSLoaiHangListbox();
                
                txtLoaiHang.Text = "";
                txtMaLoaiHang.Text = "";
                CoThayDoi = true;
            } 
            else
            {
                FormMatHang.dsLoaiHang[indexSua].TenLoaiHang = txtLoaiHang.Text;
                HienThiDSLoaiHangListbox();
                txtLoaiHang.Text = "";
                txtMaLoaiHang.Text = "";
                indexSua = -1;
                CoThayDoi = true;
            }
            
            
            
        }
        void HienThiDSLoaiHangListbox()
        {
            lstLoaiHang.Items.Clear();
            foreach (LoaiHang lh in FormMatHang.dsLoaiHang)
            {
                if (KiemTraChuoiCon(txtTimLoaiHang.Text,lh.TenLoaiHang))
                {
                lstLoaiHang.Items.Add(lh);
                }
            }
        }

        private void lstLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLoaiHang.SelectedIndex != -1)
            {
                LoaiHang lh = lstLoaiHang.SelectedItem as LoaiHang;
                txtMaLoaiHang.Text = lh.MaLoaiHang;
                txtLoaiHang.Text = lh.TenLoaiHang;
                indexSua = lstLoaiHang.SelectedIndex;
               
            }
        }

        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (lstLoaiHang.SelectedIndex != -1)
            {
                LoaiHang lh = lstLoaiHang.SelectedItem as LoaiHang;
                lstLoaiHang.Items.Remove(lh);
                FormMatHang.dsLoaiHang.Remove(lh);
                txtLoaiHang.Text = "";
                txtLoaiHang.Focus();
                CoThayDoi = true;
                
            }
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiHangListbox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (CoThayDoi)
            {

            DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void txtTimLoaiHang_TextChanged(object sender, EventArgs e)
        {
            HienThiDSLoaiHangListbox();
        }
        public bool KiemTraChuoiCon(string a, string b)
        {
            return b.Contains(a);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTimLoaiHang.Text = "";
        }
    }
}
