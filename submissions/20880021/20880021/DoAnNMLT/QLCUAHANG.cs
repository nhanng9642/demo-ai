using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMLT
{
    public partial class QLCUAHANG : Form
    {
        public QLCUAHANG()
        {
            InitializeComponent();
        }
        private void XoaTTGiaodienLH()
        {
            tb_MaLH.Text = "";
            tb_TenLH_QLLH.Text = "";
        }
        private void XoaTTGiaodienMH()
        {
            tb_MaSP.Text = "";
            tb_TenHang.Text = "";
            dtime_HanDung.Text = "";
            tb_CtySX.Text = "";
            tb_NamSX.Text = "";
            cb_LoaiHang.Text = "";
        }

        private void bt_AddLH_Click(object sender, EventArgs e)
        {
            if (tb_MaLH.Text != "" && tb_TenLH_QLLH.Text != "")
            {
                dataGridViewLoaiHang.Rows.Add(tb_MaLH.Text, tb_TenLH_QLLH.Text, tb_MoTaLH.Text);
                XoaTTGiaodienLH();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_MaSP.Text != "" && tb_TenHang.Text != "" && dtime_HanDung.Text != "" && tb_CtySX.Text != "" && tb_NamSX.Text != "" && cb_LoaiHang.Text != "")
            {
                dataGridViewMatHang.Rows.Add(tb_MaSP.Text, tb_TenHang.Text, dtime_HanDung.Text, tb_CtySX.Text, tb_NamSX.Text, cb_LoaiHang.Text);
                XoaTTGiaodienMH();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
        private void capnhapLH_Click(object sender, EventArgs e)
        {
            cb_LoaiHang.Items.Clear(); 
            if (dataGridViewLoaiHang.RowCount > 0)
            {
                string[] LoaiHang = new string[dataGridViewLoaiHang.RowCount];
                for (int i = 0; i < LoaiHang.Length-1; i++)
                {
                    LoaiHang[i] = dataGridViewLoaiHang[1, i].Value.ToString();
                    cb_LoaiHang.Items.Add(LoaiHang[i]);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewMatHang.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewMatHang.Rows.RemoveAt(vitri);
            }
        }

        private void bt_Change_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewMatHang.CurrentCell.RowIndex;
            if (tb_MaSP.Text != "" && tb_TenHang.Text != "" && dtime_HanDung.Text != "" && tb_CtySX.Text != "" && tb_NamSX.Text != "" && cb_LoaiHang.Text != "")
            {
                dataGridViewMatHang[0, vitri].Value = tb_MaSP.Text;
                dataGridViewMatHang[1, vitri].Value = tb_TenHang.Text;
                dataGridViewMatHang[2, vitri].Value = dtime_HanDung.Text;
                dataGridViewMatHang[3, vitri].Value = tb_CtySX.Text;
                dataGridViewMatHang[4, vitri].Value = tb_NamSX.Text;
                dataGridViewMatHang[5, vitri].Value = cb_LoaiHang.Text;
                XoaTTGiaodienMH();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void bt_DeleteLH_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewLoaiHang.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridViewLoaiHang.Rows.RemoveAt(vitri);
            }
        }

        private void bt_ChangeLH_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewLoaiHang.CurrentCell.RowIndex;
            if (tb_MaLH.Text != "" && tb_TenLH_QLLH.Text != "")
            {
                dataGridViewLoaiHang[0, vitri].Value = tb_MaLH.Text;
                dataGridViewLoaiHang[1, vitri].Value = tb_TenLH_QLLH.Text;
                dataGridViewLoaiHang[2, vitri].Value = tb_MoTaLH.Text;
                XoaTTGiaodienLH();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewMatHang.Rows)
            {
                if (item.IsNewRow)
                {
                    continue;
                }
                if (item.Cells[1].Value.ToString().Contains(tb_TenHangsearch.Text))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void bt_SearchLH_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewLoaiHang.Rows)
            {
                if (item.IsNewRow)
                {
                    continue;
                }
                if (item.Cells[1].Value.ToString().Contains(tb_SearchLH.Text))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void dataGridViewMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewMatHang.CurrentCell.RowIndex;
            tb_MaSP.Text=dataGridViewMatHang[0, vitri].Value.ToString();
            tb_TenHang.Text=dataGridViewMatHang[1, vitri].Value.ToString();
            dtime_HanDung.Text=dataGridViewMatHang[2, vitri].Value.ToString();
            tb_CtySX.Text=dataGridViewMatHang[3, vitri].Value.ToString();
            tb_NamSX.Text=dataGridViewMatHang[4, vitri].Value.ToString();
            cb_LoaiHang.Text = dataGridViewMatHang[5, vitri].Value.ToString();
        }

        private void dataGridViewLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewLoaiHang.CurrentCell.RowIndex;
            tb_MaLH.Text = dataGridViewLoaiHang[0, vitri].Value.ToString();
            tb_TenLH_QLLH.Text = dataGridViewLoaiHang[1, vitri].Value.ToString();
            tb_MoTaLH.Text = dataGridViewLoaiHang[2, vitri].Value.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_TenHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

