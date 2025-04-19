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
    public partial class FormMatHang : Form
    {
        public static List<LoaiHang> dsLoaiHang = new List<LoaiHang>();
        List<MatHang> dsMatHang = new List<MatHang>();
        private int indexSua = -1;
        public FormMatHang()
        {
            InitializeComponent();
        }
        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            FormLoaiHang formLH = new FormLoaiHang();
            
            if (formLH.ShowDialog() == DialogResult.OK)
            {
                HienThiDSLoaiHangCombobox();
            }
        }
        private void HienThiDSLoaiHangCombobox()
        {
            cboLoaiHang.Items.Clear();
            foreach (LoaiHang loaiHang in dsLoaiHang)
                
                    cboLoaiHang.Items.Add(loaiHang);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtTimMatHang.Text = "";
            if (indexSua == -1)
            {
                     if (cboLoaiHang.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn LOẠI HÀNG");
                    return;
                }
                LoaiHang lh = cboLoaiHang.SelectedItem as LoaiHang;
                MatHang matHang = new MatHang();
                matHang.MaHang = txtID.Text;
                matHang.TenHang = txtTenHang.Text;
                matHang.NamSanXuat = txtNamSanXuat.Text;
                matHang.CongTy = txtCongTy.Text;
                matHang.HanDung = dtpHanDung.Value;
                lh.ThemMatHang(matHang);
                dsMatHang.Add(matHang);

                HienThiMatHangListbox();
                XoaChiTietMatHang();
                
            }
            else
            {
                LoaiHang lh = cboLoaiHang.SelectedItem as LoaiHang;
                MatHang matHang = new MatHang();
                matHang.MaHang = txtID.Text;
                matHang.TenHang = txtTenHang.Text;
                matHang.NamSanXuat = txtNamSanXuat.Text;
                matHang.CongTy = txtCongTy.Text;
                matHang.HanDung = dtpHanDung.Value;
                dsMatHang.RemoveAt(indexSua);
                lh.ThemMatHang(matHang);
                dsMatHang.Add(matHang);

                HienThiMatHangListbox();
                XoaChiTietMatHang();
            }
            
           
        }
        void HienThiMatHangListbox()
        {
            lstMatHang.Items.Clear();
            foreach (MatHang mh in dsMatHang)
            {
                if (KiemTraChuoiCon(txtTimMatHang.Text, mh.TenHang))
                {
                    lstMatHang.Items.Add(mh);
                }
            }
        }
        void XoaChiTietMatHang()
        {
            txtID.Text = "";
            txtTenHang.Text = "";
            txtCongTy.Text = "";
            txtNamSanXuat.Text = "";
        }

        private void lstMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedIndex == -1)
                return;
            MatHang mh = lstMatHang.SelectedItem as MatHang;
            //cboDanhMuc.SelectedItem = sp;
            cboLoaiHang.Text = mh.Nhom.TenLoaiHang;
            txtID.Text = mh.MaHang;
            txtTenHang.Text = mh.TenHang;
            txtCongTy.Text = mh.CongTy;
            txtNamSanXuat.Text = mh.NamSanXuat + "";
            dtpHanDung.Value = mh.HanDung;
            indexSua = lstMatHang.SelectedIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Mặt hàng");
                return;
            }
            MatHang mh = lstMatHang.SelectedItem as MatHang;
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc muốn xóa [" + mh.TenHang + "] không?",
                "Cân nhắc", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                dsMatHang.Remove(mh);
                lstMatHang.Items.Remove(mh);
                HienThiMatHangListbox();
                XoaChiTietMatHang();
            }
        }
        public bool KiemTraChuoiCon(string a, string b)
        {
            return b.Contains(a);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTimMatHang.Text = "";
        }

        private void txtTimMatHang_TextChanged(object sender, EventArgs e)
        {
            HienThiMatHangListbox();
        }
    }
}
