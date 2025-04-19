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
    public partial class HangHoa : Form
    {
        private List<KB_LoaiHang> ds_loaihang;
        public HangHoa()
        {
            InitializeComponent();
            ds_loaihang = new List<KB_LoaiHang>();
        }
        public HangHoa(ref List<KB_LoaiHang> ts_ds_loaihang)
        {
            InitializeComponent();
            ds_loaihang = ts_ds_loaihang;
        }
        // Làm mới dữ liệu hàng hóa
        private void bt_LamMoi_Click(object sender, EventArgs e)
        {
            tB_MaHang.Text = "";
            tB_TenHang.Text = "";
            tB_CongtySX.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            tB_Timkiem.Text = "";
        }
        // Thêm dữ liệu hàng hóa
        private void bt_Them_Click(object sender, EventArgs e)
        {
            //Thông báo khi thêm hàng hóa
            if
                (tB_MaHang.Text == "" | tB_TenHang.Text == "" | tB_CongtySX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin hàng hóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if
                (comboBox1.Text == "")
            {
                MessageBox.Show("Chưa có thông tin loại hàng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KB_HangHoa hang;
                hang.Mahang = tB_MaHang.Text;
                hang.Tenhang = tB_TenHang.Text;
                hang.CongtySX = tB_CongtySX.Text;
                hang.NamSX = dateTimePicker2.Value;
                hang.Hansudung = dateTimePicker1.Value;
                hang.Loaihang = comboBox1.Text;

                ListViewItem item = new ListViewItem();

                item.Text = hang.Mahang.ToString();
                item.SubItems.Add(hang.Tenhang);
                item.SubItems.Add(hang.CongtySX);
                item.SubItems.Add(hang.NamSX.ToShortDateString());
                item.SubItems.Add(hang.Hansudung.ToShortDateString());
                item.SubItems.Add(hang.Loaihang);

                listView1.Items.Add(item);
                MessageBox.Show("Thêm hàng hóa thành công");
            }
        }
        //Hiển thị thông tin
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DialogResult Thongbao;
                Thongbao = MessageBox.Show("Giao Diện Quản Lý Hàng Hóa \nHọ Tên: Dương Đức Thắng \nMã SV: 20810025");  
        }
        //Tắt form hàng hóa load lại form chính
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoadForm f = new LoadForm();
            this.Hide();
            f.ShowDialog();
        }
        //Cảnh báo khi thoát ứng dụng
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult Thongbao;
            Thongbao = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thongbao == DialogResult.OK) 
            Environment.Exit(1);
        }
        //Khai báo
        private void HangHoa_Load(object sender, EventArgs e)
        {
            var bindinglist = new BindingList<KB_LoaiHang>(ds_loaihang);
            var souce = new BindingSource(bindinglist, null);
            comboBox1.ValueMember = "Maloaihang";
            comboBox1.DisplayMember = "Tenloaihang";
            comboBox1.DataSource = souce;
        }
        //Xóa dữ liệu hàng hóa
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            string Mahang = tB_MaHang.Text;
            if (Mahang.Length == 0)
            {
                MessageBox.Show("Chưa chọn mã hàng hóa!");
                return;
            }
            foreach (ListViewItem it in listView1.Items)
            {
                if (it.Text == Mahang)
                {
                    it.Remove();
                    MessageBox.Show("Xóa hàng hóa thành công");
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy mã hàng hóa cần xóa");
        }
        private void tB_Timkiem_TextChanged(object sender, EventArgs e)
        {

        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tB_MaHang.Text = e.Item.Text;
        }
        //Tìm kiếm hàng hóa
        private void bt_TimkiemHH_Click(object sender, EventArgs e)
        {
            tB_MaHang.Text = "";
            tB_TenHang.Text = "";
            tB_CongtySX.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            if(tB_Timkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa!");
                return;
            }    
            if (tB_Timkiem.Text != "")
            {
                int timkiem = -1;

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(tB_Timkiem.Text.ToLower()))
                    {
                        item.Selected = true;
                        tB_MaHang.Text = item.SubItems[0].Text;
                        tB_TenHang.Text = item.SubItems[1].Text;
                        tB_CongtySX.Text = item.SubItems[2].Text;
                        dateTimePicker2.Text = item.SubItems[3].Text;
                        dateTimePicker1.Text = item.SubItems[4].Text;
                        comboBox1.Text = item.SubItems[5].Text;
                        timkiem = 1;
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
                if(timkiem == -1)
                {
                    MessageBox.Show("Không tìm thấy mã hàng hóa");
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Cập nhật dữ liệu hàng hóa
        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            string Mahang = tB_MaHang.Text;
            if (Mahang.Length == 0)
            {
                MessageBox.Show("Chưa chọn mã hàng hóa!");
                return;
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.ToLower().Contains(tB_Timkiem.Text.ToLower()))
                {
                        item.Selected = true;
                    //Không cho cập nhật mã hàng hóa
                    //item.SubItems[0].Text = tB_MaHang.Text; 
                        item.SubItems[1].Text = tB_TenHang.Text  ;
                        item.SubItems[2].Text = tB_CongtySX.Text;
                        item.SubItems[3].Text = dateTimePicker2.Text;
                        item.SubItems[4].Text = dateTimePicker1.Text;
                        item.SubItems[5].Text = comboBox1.Text;
                        MessageBox.Show("Cập nhật hàng hóa thành công");
                }
            }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
        }
        // Thêm dữ liệu hàng hóa
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Thông báo khi thêm hàng hóa
            if
                (tB_MaHang.Text == "" | tB_TenHang.Text == "" | tB_CongtySX.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin hàng hóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if
                (comboBox1.Text == "")
            {
                MessageBox.Show("Chưa có thông tin loại hàng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KB_HangHoa hang;
                hang.Mahang = tB_MaHang.Text;
                hang.Tenhang = tB_TenHang.Text;
                hang.CongtySX = tB_CongtySX.Text;
                hang.NamSX = dateTimePicker2.Value;
                hang.Hansudung = dateTimePicker1.Value;
                hang.Loaihang = comboBox1.Text;

                ListViewItem item = new ListViewItem();

                item.Text = hang.Mahang.ToString();
                item.SubItems.Add(hang.Tenhang);
                item.SubItems.Add(hang.CongtySX);
                item.SubItems.Add(hang.NamSX.ToString());
                item.SubItems.Add(hang.Hansudung.ToString());
                item.SubItems.Add(hang.Loaihang);

                listView1.Items.Add(item);
                MessageBox.Show("Thêm hàng hóa thành công");
            }
        }
        // Cập nhật dữ liệu hàng hóa
        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Mahang = tB_MaHang.Text;
            if (Mahang.Length == 0)
            {
                MessageBox.Show("Chưa chọn mã hàng hóa!");
                return;
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text.ToLower().Contains(tB_Timkiem.Text.ToLower()))
                {
                    item.Selected = true;
                    //Không thay đổi Mã hàng
                    // item.SubItems[0].Text = tB_MaHang.Text; 
                    item.SubItems[1].Text = tB_TenHang.Text;
                    item.SubItems[2].Text = tB_CongtySX.Text;
                    item.SubItems[3].Text = dateTimePicker1.Text;
                    item.SubItems[4].Text = dateTimePicker2.Text;
                    item.SubItems[5].Text = comboBox1.Text;
                    MessageBox.Show("Cập nhật dữ liệu hàng hóa thành công");
                }
            }
            if (listView1.SelectedItems.Count == 1)
            {
                listView1.Focus();
            }
        }        
        // Xóa dữ liệu hàng hóa
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string Mahang = tB_MaHang.Text;
                if (Mahang.Length == 0)
                {
                    MessageBox.Show("Chưa chọn mã hàng hóa!");
                    return;
                }
                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.Text == Mahang)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa hàng hóa thành công");
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy mã hàng hóa cần xóa");
            }
        }
    }   


