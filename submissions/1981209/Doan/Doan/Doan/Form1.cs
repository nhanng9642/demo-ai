using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FillData()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = Program.dsSanPham;
            dataGridView1.DataSource = binding;
        }
        private void Reset()
        {
            txtMaSP.Enabled = true;
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex != 5)
                {
                    SanPham sp = (SanPham)((BindingSource)dataGridView1.DataSource)[e.RowIndex];

                    txtMaSP.Enabled = false;
                    txtMaSP.Text = sp.MaSanPham;
                    txtTenSP.Text = sp.TenSanPham;
                    txtNhaSX.Text = sp.NhaSanXuat;
                    dateHanSD.Value = sp.HanDung;
                    dateNgaySX.Value = sp.NamSanXuat;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc muốn xóa hàng hóa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SanPham sp = (SanPham)((BindingSource)dataGridView1.DataSource)[e.RowIndex];
                        Program.dsSanPham.Remove(sp);
                        FillData();
                    }
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == string.Empty || txtTenSP.Text == string.Empty || txtNhaSX.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateNgaySX.Value > dateHanSD.Value)
            {
                MessageBox.Show("Ngày sản xuất không được lớn hơn hạn sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtMaSP.Enabled)
            {
                SanPham sp = Program.dsSanPham.Find(x => x.MaSanPham == txtMaSP.Text);
                sp.TenSanPham = txtTenSP.Text;            
                sp.NhaSanXuat = txtNhaSX.Text;
                sp.NamSanXuat = dateNgaySX.Value;
                sp.HanDung = dateHanSD.Value;

                FillData();
                Reset();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Program.dsSanPham.Find(x => x.MaSanPham == txtMaSP.Text) != null)
                {
                    MessageBox.Show("Mã hàng hóa đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SanPham sp = new SanPham();
                sp.MaSanPham = txtMaSP.Text;
                sp.TenSanPham = txtTenSP.Text;
                sp.NhaSanXuat = txtNhaSX.Text;
                sp.NamSanXuat = dateNgaySX.Value;
                sp.HanDung = dateHanSD.Value;

                Program.dsSanPham.Add(sp);
                FillData();
                Reset();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            FillData();
            Reset();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = Program.dsSanPham.FindAll(x => x.MaSanPham.Contains(txtMaSP.Text) && x.TenSanPham.Contains(txtTenSP.Text));
            dataGridView1.DataSource = binding;
        }
    }
}
