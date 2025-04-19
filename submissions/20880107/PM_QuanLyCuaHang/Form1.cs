using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MatHang mh;
                mh.MaHang = int.Parse(txtMahang.Text);
                mh.TenMatHang = txtTenhang.Text;
                mh.LoaiHang = txtLoaihang.Text;
                mh.Congty = txtCongty.Text;
                mh.NamSX = int.Parse(txtNamSX.Text);
                mh.HanDung = int.Parse(txtHandung.Text);

                // Add item
                ListViewItem item = new ListViewItem();

                item.Text = mh.MaHang.ToString();
                item.SubItems.Add(mh.TenMatHang);
                item.SubItems.Add(mh.LoaiHang);
                item.SubItems.Add(mh.Congty);
                item.SubItems.Add(mh.NamSX.ToString());
                item.SubItems.Add(mh.HanDung.ToString());

                listView1.Items.Add(item);
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai hoặc thiếu dữ liệu");
            }

            // Xóa txt nhập liệu
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtLoaihang.Text = "";
            txtCongty.Text = "";
            txtNamSX.Text = "";
            txtHandung.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sửa dữ liệu
            listView1.SelectedItems[0].SubItems[0].Text = txtMahang.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtTenhang.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtLoaihang.Text;
            listView1.SelectedItems[0].SubItems[3].Text = txtCongty.Text;
            listView1.SelectedItems[0].SubItems[4].Text = txtNamSX.Text;
            listView1.SelectedItems[0].SubItems[5].Text = txtHandung.Text;

            // Xóa txt nhập liệu
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtLoaihang.Text = "";
            txtCongty.Text = "";
            txtNamSX.Text = "";
            txtHandung.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa dòng đang chọn
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

            // Xóa textbox nhập liệu
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtLoaihang.Text = "";
            txtCongty.Text = "";
            txtNamSX.Text = "";
            txtHandung.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiện dòng đang chọn lên textbox
            try
            {
                txtMahang.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTenhang.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtLoaihang.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtCongty.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtNamSX.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtHandung.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
            catch { }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            if(txtMahang2.Text != "" && txtLoaihang2.Text == "")
            {
                listView2.Items.Clear();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == txtMahang2.Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = listView1.Items[i].SubItems[0].Text;
                        item.SubItems.Add(listView1.Items[i].SubItems[1].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[2].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[3].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[4].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[5].Text);
                        listView2.Items.Add(item);
                    }
                }
            }
            else if (txtMahang2.Text == "" && txtLoaihang2.Text != "")
            {
                listView2.Items.Clear();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[2].Text == txtLoaihang2.Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = listView1.Items[i].SubItems[0].Text;
                        item.SubItems.Add(listView1.Items[i].SubItems[1].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[2].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[3].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[4].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[5].Text);
                        listView2.Items.Add(item);
                    }
                }
            }
            else if (txtMahang2.Text != "" && txtLoaihang2.Text != "")
            {
                listView2.Items.Clear();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == txtMahang2.Text && listView1.Items[i].SubItems[2].Text == txtLoaihang2.Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = listView1.Items[i].SubItems[0].Text;
                        item.SubItems.Add(listView1.Items[i].SubItems[1].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[2].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[3].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[4].Text);
                        item.SubItems.Add(listView1.Items[i].SubItems[5].Text);
                        listView2.Items.Add(item);
                    }
                }
            }

        }
    }
}