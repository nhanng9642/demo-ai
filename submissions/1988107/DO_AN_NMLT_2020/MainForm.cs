using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_NMLT_2020
{
    public partial class MainForm : Form
    {
        public List<MATHANG> dsMatHang = new List<MATHANG>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btNhapMatHang_Click(object sender, EventArgs e)
        {
            MATHANG s;
            s.MaMH = int.Parse(txtMaMH.Text);
            s.TenMH = txtTenMH.Text;
            s.HanDung = int.Parse(txtHanDung.Text);
            s.CongTySX = txtCongTySX.Text;
            s.NamSX = int.Parse(txtNamSX.Text);
            s.LoaiHang = txtLoaiHang.Text;

            if (!XL_MATHANG.HanDungHopLe(int.Parse(txtHanDung.Text)))
            {
                MessageBox.Show($"Hạn dùng phải từ hiện tại {DateTime.Now.Year}", "Lỗi hạn dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ;
            }
            else
            if (!XL_MATHANG.NamSXHopLe(int.Parse(txtNamSX.Text)))
            {
                MessageBox.Show($"Năm sản xuất phải lớn hơn 1900 và nhỏ hơn hiện tại {DateTime.Now.Year}", "Lỗi năm sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (XL_LOAIHANG.TimKiemLH(dsLoaiHang, s.LoaiHang).Count > 0)
            {
                dsMatHang = XL_MATHANG.Them(dsMatHang, s);
            }
            else
            {
                MessageBox.Show($"Chưa có loại hàng {s.LoaiHang}", "Lỗi thiếu loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lsMatHang.Items.Clear();
            foreach (MATHANG p in dsMatHang)
            {
                //lsMatHang.Items.Add(new ListViewItem(new[]{p.MaMH.ToString(), p.TenMH.ToString(), p.HanDung.ToString(), p.CongTySX.ToString(), p.NamSX.ToString(), p.LoaiHang.ToString()}));
                var item = new ListViewItem(p.MaMH.ToString());
                item.SubItems.Add(p.TenMH);
                item.SubItems.Add(p.HanDung.ToString());
                item.SubItems.Add(p.CongTySX);
                item.SubItems.Add(p.NamSX.ToString());
                item.SubItems.Add(p.LoaiHang);
                lsMatHang.Items.Add(item);
            }
        }

        private void txtTimKiemMH_TextChanged(object sender, EventArgs e)
        {
            lsMatHang.Items.Clear();
            foreach (MATHANG p in dsMatHang)
            {
                if (string.IsNullOrEmpty(txtTimKiemMH.Text) || p.TenMH.Contains(txtTimKiemMH.Text))
                {
                    var item = new ListViewItem(p.MaMH.ToString());
                    item.SubItems.Add(p.TenMH);
                    item.SubItems.Add(p.HanDung.ToString());
                    item.SubItems.Add(p.CongTySX);
                    item.SubItems.Add(p.NamSX.ToString());
                    item.SubItems.Add(p.LoaiHang);
                    lsMatHang.Items.Add(item);
                }
            }
        }

        private void btXoaMatHang_Click(object sender, EventArgs e)
        {
            MATHANG s;
            s.MaMH = int.Parse(txtMaMH.Text);
            s.TenMH = txtTenMH.Text;
            s.HanDung = int.Parse(txtHanDung.Text);
            s.CongTySX = txtCongTySX.Text;
            s.NamSX = int.Parse(txtNamSX.Text);
            s.LoaiHang = txtLoaiHang.Text;

            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa mặt hàng {s.TenMH} với mã mặt hàng {s.MaMH} không?", "Xóa mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                dsMatHang = XL_MATHANG.Xoa(dsMatHang, s);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            lsMatHang.Items.Clear();
            foreach (MATHANG p in dsMatHang)
            {
                //lsMatHang.Items.Add(new ListViewItem(new[]{p.MaMH.ToString(), p.TenMH.ToString(), p.HanDung.ToString(), p.CongTySX.ToString(), p.NamSX.ToString(), p.LoaiHang.ToString()}));
                var item = new ListViewItem(p.MaMH.ToString());
                item.SubItems.Add(p.TenMH);
                item.SubItems.Add(p.HanDung.ToString());
                item.SubItems.Add(p.CongTySX);
                item.SubItems.Add(p.NamSX.ToString());
                item.SubItems.Add(p.LoaiHang);
                lsMatHang.Items.Add(item);
            }
        }

        private void btSuaMatHang_Click(object sender, EventArgs e)
        {
            MATHANG s;
            s.MaMH = int.Parse(txtMaMH.Text);
            s.TenMH = txtTenMH.Text;
            s.HanDung = int.Parse(txtHanDung.Text);
            s.CongTySX = txtCongTySX.Text;
            s.NamSX = int.Parse(txtNamSX.Text);
            s.LoaiHang = txtLoaiHang.Text;

            if (!XL_MATHANG.HanDungHopLe(int.Parse(txtHanDung.Text)))
            {
                MessageBox.Show($"Hạn dùng phải từ hiện tại {DateTime.Now.Year}", "Lỗi hạn dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ;
            }
            else
            if (!XL_MATHANG.NamSXHopLe(int.Parse(txtNamSX.Text)))
            {
                MessageBox.Show($"Năm sản xuất phải lớn hơn 1900 và nhỏ hơn hiện tại {DateTime.Now.Year}", "Lỗi năm sản xuất", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (XL_LOAIHANG.TimKiemLH(dsLoaiHang, s.LoaiHang).Count > 0)
            {
                dsMatHang = XL_MATHANG.Sua(dsMatHang, s);
            }
            else
            {
                MessageBox.Show($"Chưa có loại hàng {s.LoaiHang}", "Lỗi thiếu loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lsMatHang.Items.Clear();
            foreach (MATHANG p in dsMatHang)
            {
                //lsMatHang.Items.Add(new ListViewItem(new[]{p.MaMH.ToString(), p.TenMH.ToString(), p.HanDung.ToString(), p.CongTySX.ToString(), p.NamSX.ToString(), p.LoaiHang.ToString()}));
                var item = new ListViewItem(p.MaMH.ToString());
                item.SubItems.Add(p.TenMH);
                item.SubItems.Add(p.HanDung.ToString());
                item.SubItems.Add(p.CongTySX);
                item.SubItems.Add(p.NamSX.ToString());
                item.SubItems.Add(p.LoaiHang);
                lsMatHang.Items.Add(item);
            }
        }

        public List<LOAIHANG> dsLoaiHang = new List<LOAIHANG>();

        private void btNhapLoaiHang_Click(object sender, EventArgs e)
        {
            LOAIHANG s;
            s.MaLH = int.Parse(txtMaLH.Text);
            s.TenLH = txtTenLH.Text;

            dsLoaiHang = XL_LOAIHANG.Them(dsLoaiHang, s);

            lsLoaiHang.Items.Clear();
            foreach (LOAIHANG p in dsLoaiHang)
            {
                var item = new ListViewItem(p.MaLH.ToString());
                item.SubItems.Add(p.TenLH);
                lsLoaiHang.Items.Add(item);
            }
        }

        private void btXoaLoaiHang_Click(object sender, EventArgs e)
        {
            LOAIHANG s;
            s.MaLH = int.Parse(txtMaLH.Text);
            s.TenLH = txtTenLH.Text;

            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa loại hàng {s.TenLH} với mã {s.MaLH} không?", "Xóa loại hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                if (XL_MATHANG.TimKiemSoMHCungLoai(dsMatHang, s.TenLH).Count == 0)
                {
                    dsLoaiHang = XL_LOAIHANG.Xoa(dsLoaiHang, s);
                }
                else
                {
                    MessageBox.Show($"Không thể xóa mã loại hàng {s.MaLH} vì còn {XL_MATHANG.TimKiemSoMHCungLoai(dsMatHang, s.TenLH).Count} mặt hàng liên quan", "Lỗi xóa loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            lsLoaiHang.Items.Clear();
            foreach (LOAIHANG p in dsLoaiHang)
            {
                var item = new ListViewItem(p.MaLH.ToString());
                item.SubItems.Add(p.TenLH);
                lsLoaiHang.Items.Add(item);
            }
        }

        private void btSuaLoaiHang_Click(object sender, EventArgs e)
        {
            LOAIHANG s;
            s.MaLH = int.Parse(txtMaLH.Text);
            s.TenLH = txtTenLH.Text;

            if (XL_MATHANG.TimKiemSoMHCungLoai(dsMatHang, s.TenLH).Count == 0)
            {
                dsLoaiHang = XL_LOAIHANG.Sua(dsLoaiHang, s);
            }
            else
            {
                MessageBox.Show($"Không thể sửa mã loại hàng {s.MaLH} vì còn {XL_MATHANG.TimKiemSoMHCungLoai(dsMatHang, s.TenLH).Count} mặt hàng liên quan", "Lỗi sửa loại hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lsLoaiHang.Items.Clear();
            foreach (LOAIHANG p in dsLoaiHang)
            {
                var item = new ListViewItem(p.MaLH.ToString());
                item.SubItems.Add(p.TenLH);
                lsLoaiHang.Items.Add(item);
            }

        }

        private void txtTimKiemLH_TextChanged(object sender, EventArgs e)
        {
            lsLoaiHang.Items.Clear();
            foreach (LOAIHANG p in dsLoaiHang)
            {
                if (string.IsNullOrEmpty(txtTimKiemLH.Text) || p.TenLH.Contains(txtTimKiemLH.Text))
                {
                    var item = new ListViewItem(p.MaLH.ToString());
                    item.SubItems.Add(p.TenLH);
                    lsLoaiHang.Items.Add(item);
                }
            }
        }
    }
}
