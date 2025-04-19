using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20810028
{
    
    public partial class Form1 : Form
    {
        public string[] loaihan = { "Quần Jean", "Áo Jean", "Áo sơ mi", "Áo thun" };

         
    public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < loaihan.Length; i++)
            {
                cboLoaiHang.Items.Add(loaihan[i]);
            }
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MatHang sp;
            sp.maHang = txtMaHang.Text;
            sp.tenHang = txtTenHang.Text;
            sp.loaiHang = cboLoaiHang.Text;
            sp.namSx = txtNamSx.Text;
            sp.ctySx = txtCty.Text;
            sp.hanDung = txtHanSuDung.Text;

            ListViewItem item = new ListViewItem();
            item.Text = sp.maHang;
            item.SubItems.Add(sp.tenHang);
            item.SubItems.Add(sp.loaiHang);
            item.SubItems.Add(sp.ctySx);
            item.SubItems.Add(sp.namSx);
            item.SubItems.Add(sp.hanDung);

            listView1.Items.Add(item);
        }

        private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    
                    item.Text = txtMaHang.Text;
                    item.SubItems[1].Text = txtTenHang.Text;
                    item.SubItems[2].Text = cboLoaiHang.Text;
                    item.SubItems[3].Text = txtCty.Text;
                    item.SubItems[4].Text = txtNamSx.Text;
                    item.SubItems[5].Text = txtHanSuDung.Text;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                    item.Remove();
                
            }
            MessageBox.Show("Đã xóa thành công");
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 j = new Form2();
            j.Show();
        }
    }
}
