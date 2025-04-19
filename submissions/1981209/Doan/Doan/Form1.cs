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
        string[] DsNhaSX = { "Abott","Aptamil", "Asuzac Foods", "Avent" };
        string[] DsLoaiHang = { "Sữa bột", "Sữa nước", "Sữa tươi", "Thực phẩm dinh dưỡng" };
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(700, 500);
            this.MinimumSize= new Size(700, 500);
            FillData();
            loadCombobox();
            Reset();
        }

        private void loadCombobox()
        {
            if (cbLoaiHang.Items.Count == 0)
            {
                foreach (string lh in DsLoaiHang)
                {
                    cbLoaiHang.Items.Add(lh);
                }
                cbLoaiHang.SelectedIndex = 0;
            }

            if (cbNhaSX.Items.Count == 0)
            {
                foreach (string nsx in DsNhaSX)
                {
                    cbNhaSX.Items.Add(nsx);
                }
                cbNhaSX.SelectedIndex = 0;
            }
        }

        private void FillData()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = Program.dsSanPham;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = binding;

            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();

            editbutton.FlatStyle = FlatStyle.Flat;
            editbutton.HeaderText = "Sửa";
            editbutton.Name = "Edit";
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "Sửa";
            editbutton.InheritedStyle.BackColor = Color.Orange;
            editbutton.InheritedStyle.ForeColor = Color.White;
            editbutton.Width = 60;
            if (!dataGridView1.Columns.Contains(editbutton.Name = "Edit"))
            {
                dataGridView1.Columns.Add(editbutton);
            }

            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

            deletebutton.FlatStyle = FlatStyle.Flat;

            deletebutton.HeaderText = "Xoá";
            deletebutton.Name = "Delete";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "Xoá";
            deletebutton.InheritedStyle.BackColor = Color.Red;
            deletebutton.InheritedStyle.ForeColor = Color.White;
            deletebutton.Width = 60;
            if (!dataGridView1.Columns.Contains(deletebutton.Name = "Delete"))
            {
                dataGridView1.Columns.Add(deletebutton);
            }
        }
        private void Reset()
        {
            txtMaSP.Enabled = true;
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            cbNhaSX.SelectedIndex = 0;
            cbLoaiHang.SelectedIndex = 0;
            dateHanSD.Value = DateTime.Now;
            dateNgaySX.Value = DateTime.Now;
            btnThem.Text = "Tạo sản phẩm";
            btHuy.Visible = true;
            btTim.Enabled = true;
            btnXoa.Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex != 7)
                {
                    SanPham sp = (SanPham)((BindingSource)dataGridView1.DataSource)[e.RowIndex];
                    chooseProduct(sp);
                 
                }
                else
                {
                    SanPham sp = (SanPham)((BindingSource)dataGridView1.DataSource)[e.RowIndex];
                  
                    deleteProduct(sp);
                }

            }
        }

        private void deleteProduct(SanPham sp)
        {
            if (MessageBox.Show("Bạn chắc muốn xóa hàng hóa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.dsSanPham.Remove(sp);
                FillData();
                Reset();
            }
        }

        private void chooseProduct(SanPham sp)
        {
            txtMaSP.Enabled = false;
            txtMaSP.Text = sp.MaSanPham;
            txtTenSP.Text = sp.TenSanPham;
            cbNhaSX.SelectedIndex = Array.IndexOf(DsNhaSX, sp.NhaSanXuat);
            cbLoaiHang.SelectedIndex = Array.IndexOf(DsLoaiHang, sp.LoaiHang);
            dateHanSD.Value = sp.HanDung;
            dateNgaySX.Value = sp.NamSanXuat;
            btnThem.Text = "Cập nhật sản phẩm";
            btTim.Enabled = false;
            btHuy.Visible = true;
            btnXoa.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == string.Empty || txtTenSP.Text == string.Empty )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateNgaySX.Value >= dateHanSD.Value)
            {
                MessageBox.Show("Ngày sản xuất không được lớn hơn hạn sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtMaSP.Enabled)
            {
                SanPham sp = Program.dsSanPham.Find(x => x.MaSanPham == txtMaSP.Text);
                sp.TenSanPham = txtTenSP.Text;
                sp.NhaSanXuat = cbNhaSX.SelectedItem.ToString();
                sp.LoaiHang = cbLoaiHang.SelectedItem.ToString();
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
                sp.NhaSanXuat = cbNhaSX.SelectedItem.ToString();
                sp.LoaiHang = cbLoaiHang.SelectedItem.ToString();
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
            binding.DataSource =
                Program.dsSanPham.FindAll(x => x.MaSanPham.Contains(txtMaSP.Text) && x.TenSanPham.Contains(txtTenSP.Text));
            dataGridView1.DataSource = binding;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham p =(SanPham) Program.dsSanPham.Find(i => i.MaSanPham.ToLower() == txtMaSP.Text.ToLower());
            if (p != null)
            {
                deleteProduct(p);
            }
        }
    }
}
