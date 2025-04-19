using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang_20880110
{
    struct CUAHANG
    {
        public string MaHang;
        public string TenHang;
        public string HanDung;
        public string CongTySanXuat;
        public int NamSanXuat;
        public string LoaiHang;
    }
    public partial class frmQLyCuaHang : Form
    {
        public frmQLyCuaHang()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            datetimeHanDung.Value = DateTime.Today;
            txtCtySanXuat.Text = "";
            txtNamSanXuat.Text = "";
            txtLoaiHang.Text = "";
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
            }
            else if (txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
            }
            else if (datetimeHanDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập hạn dùng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datetimeHanDung.Focus();
            }
            else if (txtCtySanXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập công ty sản xuất.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCtySanXuat.Focus();
            }
            else if (txtNamSanXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm sản xuất.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSanXuat.Focus();
            }
            else if (txtLoaiHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại hàng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoaiHang.Focus();
            }
            else
            { 
                CUAHANG cuahang;
                cuahang.MaHang = txtMaHang.Text;
                cuahang.TenHang = txtTenHang.Text;
                cuahang.HanDung = datetimeHanDung.Text;
                cuahang.CongTySanXuat = txtCtySanXuat.Text;
                cuahang.NamSanXuat = int.Parse(txtNamSanXuat.Text);
                cuahang.LoaiHang = txtLoaiHang.Text;

                int stt = listKetQua.Items.Count + 1;
                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(cuahang.MaHang);
                item.SubItems.Add(cuahang.TenHang);
                item.SubItems.Add(cuahang.HanDung);
                item.SubItems.Add(cuahang.CongTySanXuat);
                item.SubItems.Add(cuahang.NamSanXuat.ToString());
                item.SubItems.Add(cuahang.LoaiHang);
                listKetQua.Items.Add(item);
                ClearAll();
                MessageBox.Show("Đã thêm mặt hàng thành công.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
            }
        }

        public void btnSua_Click(object sender, EventArgs e)
        {
            if (listKetQua.SelectedItems.Count == 1)
            {
                listKetQua.SelectedItems[0].SubItems[1].Text = txtMaHang.Text;
                listKetQua.SelectedItems[0].SubItems[2].Text = txtTenHang.Text;
                listKetQua.SelectedItems[0].SubItems[3].Text = datetimeHanDung.Text;
                listKetQua.SelectedItems[0].SubItems[4].Text = txtCtySanXuat.Text;
                listKetQua.SelectedItems[0].SubItems[5].Text = txtNamSanXuat.Text;
                listKetQua.SelectedItems[0].SubItems[6].Text = txtLoaiHang.Text;
                ClearAll();
                MessageBox.Show("Đã sửa mặt hàng thành công.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnXoa_Click(object sender, EventArgs e)
        {
            if (listKetQua.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cửa hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {     
                    for (int i = listKetQua.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        listKetQua.Items.RemoveAt(listKetQua.SelectedIndices[i]);
                    }
                    MessageBox.Show("Đã xóa mặt hàng thành công.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    txtMaHang.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mặt hàng.", "Cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listKetQua.Items)
            {
                item.BackColor = SystemColors.Window;
                item.ForeColor = SystemColors.WindowText;
            }
            if (txtMaHang.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[1].Text.Contains(txtMaHang.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
            if (txtTenHang.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[2].Text.Contains(txtTenHang.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
            if (datetimeHanDung.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[3].Text.Contains(datetimeHanDung.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
            if (txtCtySanXuat.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[4].Text.Contains(txtCtySanXuat.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
            if (txtNamSanXuat.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[5].Text.Contains(txtNamSanXuat.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
            if (txtLoaiHang.Text != "")
            {

                for (int i = listKetQua.Items.Count - 1; i >= 0; i--)
                {
                    var item = listKetQua.Items[i];
                    if (item.SubItems[6].Text.Contains(txtLoaiHang.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                }
            }
        }

        public void listKetQua_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaHang.Text = listKetQua.SelectedItems[0].SubItems[1].Text;
            txtTenHang.Text = listKetQua.SelectedItems[0].SubItems[2].Text;
            datetimeHanDung.Text = listKetQua.SelectedItems[0].SubItems[3].Text;
            txtCtySanXuat.Text = listKetQua.SelectedItems[0].SubItems[4].Text;
            txtNamSanXuat.Text = listKetQua.SelectedItems[0].SubItems[5].Text;
            txtLoaiHang.Text = listKetQua.SelectedItems[0].SubItems[6].Text;
        }

        private void txtNamSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtLoaiHang.Focus();
            }
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTenHang.Focus();
            }
        }

        private void txtTenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                datetimeHanDung.Focus();
            }
        }

        private void datetimeHanDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCtySanXuat.Focus();
            }
        }

        private void txtCtySanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNamSanXuat.Focus();
            }
        }

        private void txtLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnThem.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            foreach (ListViewItem item in listKetQua.Items)
            {
                item.BackColor = SystemColors.Window;
                item.ForeColor = SystemColors.WindowText;
            }
            txtMaHang.Focus();
        }

        private void frmQLyCuaHang_Load(object sender, EventArgs e)
        {
            datetimeHanDung.Value = DateTime.Today;
        }
    }
}
