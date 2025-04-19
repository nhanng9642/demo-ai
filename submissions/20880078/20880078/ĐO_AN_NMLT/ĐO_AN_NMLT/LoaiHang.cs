using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐO_AN_NMLT
{
    public partial class LoaiHang : Form
    {
        public BindingSource TenLoaiHang = new BindingSource();
        public LoaiHang()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            if (txtThemLoaiHang.Text != "")
            {
                dataGridViewLoaiHang.Rows.Add(txtThemLoaiHang.Text);
            }
            else
            {
                if (txtThemLoaiHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải Tên Loại Hàng");
                    txtThemLoaiHang.Focus();
                    return;
                }
            }
        }

        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewCell oneCell in dataGridViewLoaiHang.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridViewLoaiHang.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            else
            {
                return;
            }
        }

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            this.btnThemLoaiHang.Enabled = false;
            this.btnXoaLoaiHang.Enabled = false;
            this.btnSuaLoaiHang.Enabled = true;
            this.btnLuu.Enabled = true;

            this.txtThemLoaiHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtThemLoaiHang.Text != "")
            {
                dataGridViewLoaiHang.Rows.Add(txtThemLoaiHang.Text);

            }
            foreach (DataGridViewCell oneCell in dataGridViewLoaiHang.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewLoaiHang.Rows.RemoveAt(oneCell.RowIndex);
            }
            this.btnThemLoaiHang.Enabled = true;
            this.btnXoaLoaiHang.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtTimLoaiHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BindingSource TenMatHang = new BindingSource();
                TenMatHang.DataSource = dataGridViewLoaiHang.DataSource;
                TenMatHang.Filter = txtTimLoaiHang.Text.Trim();
                dataGridViewLoaiHang.DataSource = TenMatHang;

            }
        }

        private void dataGridViewLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dataGridViewLoaiHang.CurrentRow.Index;
            if (dataGridViewLoaiHang.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index >= 0)
            {
                TenLoaiHang.RemoveAt(index);
                TenLoaiHang.ResetBindings(false);

            }
        }
    }
}
               
            
    

