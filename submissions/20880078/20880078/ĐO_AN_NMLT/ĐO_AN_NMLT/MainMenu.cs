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
    public partial class MainMenu : Form
    {
        public BindingSource TenMatHang = new BindingSource();
        
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                foreach (DataGridViewCell oneCell in dataGridViewMatHang.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridViewMatHang.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            else
            {
                return;
            }    
        }
        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang frmLoaiHang = new LoaiHang();
            frmLoaiHang.Show();

        }
        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            DateTime HanSuDung = Convert.ToDateTime(dtpHanSuDung.Value);
            DateTime NgaySanXuat = Convert.ToDateTime(dtpNamSanXuat.Value);
            TimeSpan time = HanSuDung - NgaySanXuat;
            int SoNgay = time.Days;
            
            if(txtMaMatHang.Text != "" && txtCTSanXuat.Text != "" && txtTenMatHang.Text != "" && cbLoaiHang.Text != "" && SoNgay >= 0)
            {
                dataGridViewMatHang.Rows.Add(txtMaMatHang.Text, txtTenMatHang.Text, dtpHanSuDung.Text, txtCTSanXuat.Text, dtpNamSanXuat.Text, cbLoaiHang.Text);

            }    
            else
            {
                if(txtMaMatHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã Mặt Hàng");
                    txtMaMatHang.Focus();
                    return;
                }
                if(txtCTSanXuat.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên Công Ty sản xuất");
                    txtCTSanXuat.Focus();
                    return;
                }
                if(txtTenMatHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên Mặt Hàng");
                    txtTenMatHang.Focus();
                    return;
                }    
                if(cbLoaiHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn Loại Hàng");
                    return;
                }    
                if(SoNgay < 0)
                {
                    MessageBox.Show("Bạn vui lòng kiểm tra lại Ngày Sản Xuất và Hạn Sử Dụng");
                    return;
                }    
            }
            
        }

      
        private void btnSuaMatHang_Click(object sender, EventArgs e)
        {
         
            this.btnThemMatHang.Enabled = false;
            this.btnXoaMatHang.Enabled = false;
            this.btnSuaMatHang.Enabled = true;
            this.btnLuu.Enabled = true;

            this.txtMaMatHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMatHang.Text != "" && txtCTSanXuat.Text != "" && txtTenMatHang.Text != "" && cbLoaiHang.Text != "")
            {
                dataGridViewMatHang.Rows.Add(txtMaMatHang.Text, txtTenMatHang.Text, dtpHanSuDung.Text, txtCTSanXuat.Text, dtpNamSanXuat.Text, cbLoaiHang.Text);

            }
            foreach (DataGridViewCell oneCell in dataGridViewMatHang.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridViewMatHang.Rows.RemoveAt(oneCell.RowIndex);
            }
            this.btnThemMatHang.Enabled = true;
            this.btnXoaMatHang.Enabled = true;
        }
        
        private void btnTimMatHang_Click(object sender, EventArgs e)
        {
            if(txtTimMatHang.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                BindingSource TenMatHang = new BindingSource();
                TenMatHang.DataSource = dataGridViewMatHang.DataSource;
                TenMatHang.Filter = txtTimMatHang.Text.Trim();
                dataGridViewMatHang.DataSource = TenMatHang;
            }    
        }
        private void dataGridViewMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dataGridViewMatHang.CurrentRow.Index;
            if (dataGridViewMatHang.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index >= 0)
            {
                TenMatHang.RemoveAt(index);
                TenMatHang.ResetBindings(false);

            }
            
        }
    }
}
