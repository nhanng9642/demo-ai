using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGUYENVANTIEN_NMLT_20880080
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Xoatgiaodien1()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            cbPhanloai.Text = "";
            txtCongty.Text = "";
            txtNamsanxuat.Text = "";
            txtHansudung.Text = "";
        }
        private void Xoatgiaodien2()
        {
            txtMahangTK.Text = "";
            txtTenhangTK.Text = "";
            cbPhanloaiTK.Text = "";
            txtCongtyTK.Text = "";
            txtNamsanxuatTK.Text = "";
            txtHansudungTK.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMahang.Text != "")
            {
                if(txtTenhang.Text != "")
                {
                    if(cbPhanloai.Text != "")
                    {
                        if(txtCongty.Text != "")
                        {
                            if(txtNamsanxuat.Text != "")
                            {
                                if(txtHansudung.Text != "")
                                {
                                    dataGridViewSanPham.Rows.Add(txtMahang.Text, txtTenhang.Text, cbPhanloai.Text, txtCongty.Text, txtNamsanxuat.Text, txtHansudung.Text);
                                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Xoatgiaodien1();
                                }
                                else
                                {
                                    MessageBox.Show("Bạn chưa nhập Hạn Sử Dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa nhập Năm Sản Xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập Tên Công Ty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCongty.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập Phân loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập Tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenhang.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hàng!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMahang.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mặc hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewSanPham.CurrentCell.RowIndex;
                dataGridViewSanPham.Rows.RemoveAt(index);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.SelectedCells.Count > 0)
            {
                int vitri = dataGridViewSanPham.CurrentCell.RowIndex;
                dataGridViewSanPham[0, vitri].Value = txtMahang.Text;
                dataGridViewSanPham[1, vitri].Value = txtTenhang.Text;
                dataGridViewSanPham[2, vitri].Value = cbPhanloai.Text;
                dataGridViewSanPham[3, vitri].Value = txtCongty.Text;
                dataGridViewSanPham[4, vitri].Value = txtNamsanxuat.Text;
                dataGridViewSanPham[5, vitri].Value = txtHansudung.Text;
                Xoatgiaodien1();
            }
            else
            {
                MessageBox.Show("Không có gì để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewSanPham.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewSanPham.Rows[dataGridViewSanPham.CurrentCell.RowIndex];
                txtMahang.Text = row.Cells[0].Value.ToString();
                txtTenhang.Text = row.Cells[1].Value.ToString();
                cbPhanloai.Text = row.Cells[2].Value.ToString();
                txtCongty.Text = row.Cells[3].Value.ToString();
                txtNamsanxuat.Text = row.Cells[4].Value.ToString();
                txtHansudung.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (radMahang.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i<dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if(txtMahangTK.Text == dataGridViewSanPham[0, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
            else if (radTenhang.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if (txtTenhangTK.Text == dataGridViewSanPham[1, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
            else if (radPhanloai.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if (cbPhanloaiTK.Text == dataGridViewSanPham[2, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
            else if (radCongty.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if (txtCongtyTK.Text == dataGridViewSanPham[3, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
            else if (radNamsanxuat.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if (txtNamsanxuatTK.Text == dataGridViewSanPham[4, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
            else if (radHansudung.Checked)
            {
                dataGridViewTimKiem.Rows.Clear();
                for (int i = 0; i < dataGridViewSanPham.Rows.Count - 1; i++)
                {
                    if (txtHansudungTK.Text == dataGridViewSanPham[5, i].Value.ToString())
                    {
                        dataGridViewTimKiem.Rows.Add(dataGridViewSanPham[0, i].Value.ToString(), dataGridViewSanPham[1, i].Value.ToString(), dataGridViewSanPham[2, i].Value.ToString(), dataGridViewSanPham[3, i].Value.ToString(), dataGridViewSanPham[4, i].Value.ToString(), dataGridViewSanPham[5, i].Value.ToString());
                    }
                }
                Xoatgiaodien2();
            }
        }
    }
}
