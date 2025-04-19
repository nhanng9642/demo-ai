using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_20810025
{
    public partial class LoaiHang : Form
    {
        private List<KB_LoaiHang> ds_loaihang;
        public LoaiHang()
        {
            InitializeComponent();
            ds_loaihang = new List<KB_LoaiHang>();
        }
        public LoaiHang(ref List<KB_LoaiHang> ts_ds_loaihang )
        {
            InitializeComponent();
            ds_loaihang =ts_ds_loaihang;  
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Hiển thị thông tin
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Thongbao;
            Thongbao = MessageBox.Show("Giao Diện Quản Lý Loại Hàng \nHọ Tên: Dương Đức Thắng \nMã SV: 20810025");
        }
        private void NewMethod()
        {
            this.Show();
        }
        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            var bindinglist = new BindingList<KB_LoaiHang>(ds_loaihang);
            var souce = new BindingSource(bindinglist, null);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = souce;
            dataGridView1.Refresh();
        }
        //Thêm dữ liệu loại hàng
        private void bt_ThemLH_Click(object sender, EventArgs e)
        {
            if
                (tB_MaLH.Text == "" | tB_TenLH.Text == "" | tB_Diengiai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin loại hàng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ds_loaihang.Add(new KB_LoaiHang() 
            {   
                Maloaihang = tB_MaLH.Text,
                Tenloaihang = tB_TenLH.Text,
                Ngaytao = dateTimePicker1.Value,
                Diengiai = tB_Diengiai.Text
            }
            );
            
            var bindinglist = new BindingList<KB_LoaiHang>(ds_loaihang);
            var souce = new BindingSource(bindinglist, null);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = souce;
            dataGridView1.Refresh();
            MessageBox.Show("Thêm loại hàng thành công");
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Thongbao;
            Thongbao = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thongbao == DialogResult.OK)
            Environment.Exit(1);
        }
        //Thêm dữ liệu loại hàng
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if
                (tB_MaLH.Text == "" | tB_TenLH.Text == "" | tB_Diengiai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin loại hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ds_loaihang.Add(new KB_LoaiHang()
            {
                Maloaihang = tB_MaLH.Text,
                Tenloaihang = tB_TenLH.Text,
                Ngaytao = dateTimePicker1.Value,
                Diengiai = tB_Diengiai.Text
            }
            );

            var bindinglist = new BindingList<KB_LoaiHang>(ds_loaihang);
            var souce = new BindingSource(bindinglist, null);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = souce;
            dataGridView1.Refresh();
        }
        //Cập nhật dữ liệu loại hàng
        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (tB_MaLH.Text == "")
            {
                MessageBox.Show("Không có dữ liệu loại hàng!");
                return;
            }
            string searchValue = tB_MaLH.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row == null)
                    break;
                if (row.Cells[0].Value.ToString().Contains(searchValue))
                {
                    rowIndex = row.Index;
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    dataGridView1.Focus();
                    string MaLH = tB_MaLH.Text;

                    //Không cho cập nhật mã loại hàng
                    //row.Cells[0].Value = tB_MaLH.Text;

                    row.Cells[1].Value = tB_TenLH.Text;
                    row.Cells[2].Value = dateTimePicker1.Text ;
                    row.Cells[3].Value = tB_Diengiai.Text;
                    break;
                }
            }
            if (rowIndex == -1)
            {
                MessageBox.Show("Không tìm thấy mã loại hàng");
            }
        }
        //Tìm kiếm loại hàng
        private void bt_TimkiemLH_Click(object sender, EventArgs e)
        {
            tB_MaLH.Text = "";
            tB_TenLH.Text = "";
            dateTimePicker1.Text = "";
            tB_Diengiai.Text = "";
            if (tB_TìmkiemLH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã loại hàng");
                return;
            }
            string searchValue = tB_TìmkiemLH.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                if (row == null)
                    break;
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridView1.Focus();
                        string MaLH = tB_MaLH.Text;
                        
                        tB_MaLH.Text = row.Cells[0].Value.ToString();
                        tB_TenLH.Text = row.Cells[1].Value.ToString();
                        dateTimePicker1.Text = row.Cells[2].Value.ToString();
                        tB_Diengiai.Text = row.Cells[3].Value.ToString();
                        break;
                    }
                }
                if (rowIndex == -1)
                {
                    MessageBox.Show("Không tìm thấy mã loại hàng");
                }
        }
        //Làm mới dữ liệu loại hàng
        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            tB_MaLH.Text = "";
            tB_TenLH.Text = "";
            dateTimePicker1.Text = "";
            tB_Diengiai.Text = "";
            tB_TìmkiemLH.Text = "";
        }
        //Xóa dữ liệu loại hàng
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (tB_MaLH.Text == "")
            {
                MessageBox.Show("Không có dữ liệu loại hàng!");
                return;
            }

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }
        //Xóa dữ liệu loại hàng
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tB_MaLH.Text == "")
            {
                MessageBox.Show("Không có dữ liệu loại hàng!");
                return;
            }
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }
        //Cập nhật dữ liệu loại hàng
        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tB_MaLH.Text == "")
            {
                MessageBox.Show("Không có dữ liệu loại hàng!");
                return;
            }
            string searchValue = tB_MaLH.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row == null)
                    break;
                if (row.Cells[0].Value.ToString().Contains(searchValue))
                {
                    rowIndex = row.Index;
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                    dataGridView1.Focus();
                    string MaLH = tB_MaLH.Text;

                    //Không cho cập nhật mã loại hàng
                    //row.Cells[0].Value = tB_MaLH.Text;

                    row.Cells[1].Value = tB_TenLH.Text;
                    row.Cells[2].Value = dateTimePicker1.Text;
                    row.Cells[3].Value = tB_Diengiai.Text;
                    break;
                }
            }
            if (rowIndex == -1)
            {
                MessageBox.Show("Không tìm thấy mã loại hàng");
            }
        }
    }
}
