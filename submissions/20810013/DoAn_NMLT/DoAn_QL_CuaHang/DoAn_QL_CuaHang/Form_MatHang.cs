using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_CuaHang
{
    public partial class Form_MatHang : Form
    {
        public Form_MatHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            HANGHOA Mathang;
            Mathang.Mahang = txtmahang.Text;
            Mathang.Tenhang = txttenhang.Text;
            Mathang.Hansudung = txthansudung.Text;
            Mathang.Ctysx = txtctysanxuat.Text;
            Mathang.Namsx = txtnamsanxuat.Text;
            
            Mathang.Loaihang = cbbloaihang.Text;
            
            ListViewItem item = new ListViewItem();
            item.Text = Mathang.Mahang.ToString();
            item.SubItems.Add(Mathang.Tenhang);
            item.SubItems.Add(Mathang.Hansudung);
            item.SubItems.Add(Mathang.Ctysx);
            item.SubItems.Add(Mathang.Namsx);
            item.SubItems.Add(Mathang.Loaihang.ToString());
            lvmathang.Items.Add(item);
            

        }

        private void Form_MatHang_Load(object sender, EventArgs e)
        {

        }
        private void cbbloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lvmathang_SelectedIndexChanged(object sender, EventArgs e)
        {

            HANGHOA sanpham;
            for (int i = 0; i < lvmathang.SelectedItems.Count; i++)
            {
                ListViewItem lvi = lvmathang.SelectedItems[i];
                sanpham.Mahang = lvi.SubItems[0].Text;
                sanpham.Tenhang = lvi.SubItems[1].Text;
                sanpham.Hansudung = lvi.SubItems[2].Text;
                sanpham.Ctysx = lvi.SubItems[3].Text;
                sanpham.Namsx = lvi.SubItems[4].Text;
                sanpham.Loaihang = lvi.SubItems[5].Text;

                txtmahang.Text = sanpham.Mahang.ToString();
                txttenhang.Text = sanpham.Tenhang.ToString();
                txthansudung.Text = sanpham.Hansudung.ToString();
                txtctysanxuat.Text = sanpham.Ctysx.ToString();
                txtnamsanxuat.Text = sanpham.Namsx.ToString();
                cbbloaihang.Text = sanpham.Loaihang.ToString();
            }



        }

        private void btnsua_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < lvmathang.SelectedItems.Count; i++)
            {

                HANGHOA Mathang;
                Mathang.Mahang = txtmahang.Text;
                Mathang.Tenhang = txttenhang.Text;
                Mathang.Hansudung = txthansudung.Text;
                Mathang.Ctysx = txtctysanxuat.Text;
                Mathang.Namsx = txtnamsanxuat.Text;
                Mathang.Loaihang = cbbloaihang.Text;

                ListViewItem lvi = lvmathang.SelectedItems[i];
                lvi.SubItems[0].Text = Mathang.Mahang.ToString();
                lvi.SubItems[1].Text = Mathang.Tenhang.ToString();
                lvi.SubItems[2].Text = Mathang.Hansudung.ToString();
                lvi.SubItems[3].Text = Mathang.Ctysx.ToString();
                lvi.SubItems[4].Text = Mathang.Namsx.ToString();
                lvi.SubItems[5].Text = Mathang.Loaihang.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvmathang.SelectedItems.Count; i++)
            {
                lvmathang.Items.RemoveAt(lvmathang.SelectedItems[i].Index);
            }
        }

        private void btnthemloaihang_Click(object sender, EventArgs e)
        {
            HANGHOA loaihang;
            loaihang.Maloaihang = txtmaloaihang.Text;
            loaihang.Tenloaihang = txttenloaihang.Text;
           
            ListViewItem lsv = new ListViewItem();
            lsv.Text = loaihang.Maloaihang;
            lsv.SubItems.Add(loaihang.Tenloaihang);
            lsvloaihang.Items.Add(lsv);
            cbbloaihang.Items.Add(loaihang.Tenloaihang);
        }

        private void btnxoaloaihang_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lsvloaihang.SelectedItems.Count; i++)
            {
                lsvloaihang.Items.RemoveAt(lsvloaihang.SelectedItems[i].Index);
               
                HANGHOA loaihang;
                loaihang.Maloaihang = txtmaloaihang.Text;
                loaihang.Tenloaihang = txttenloaihang.Text;

                ListViewItem lsv = new ListViewItem();
                lsv.Text = loaihang.Maloaihang;
                lsv.SubItems.Add(loaihang.Tenloaihang);
                cbbloaihang.Items.Remove(loaihang.Tenloaihang);
            }
           
        }

        private void btnsualoaihang_Click(object sender, EventArgs e)
        {
            HANGHOA Mathang;
            Mathang.Maloaihang = txtmaloaihang.Text;
            Mathang.Tenloaihang = txttenloaihang.Text;
            
            for (int i = 0; i < lsvloaihang.SelectedItems.Count; i++)
            {
                
                ListViewItem lvi = lsvloaihang.SelectedItems[i];
                lvi.SubItems[0].Text = Mathang.Maloaihang.ToString();
                lvi.SubItems[1].Text = Mathang.Tenloaihang.ToString();
                cbbloaihang.Items.RemoveAt(i);
             
                cbbloaihang.Items.Add(Mathang.Tenloaihang);
            }
            

            



        }

        private void lsvloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {

            HANGHOA loaihang;
            for (int i = 0; i < lsvloaihang.SelectedItems.Count; i++)
            {
                ListViewItem lvi = lsvloaihang.SelectedItems[i];
                loaihang.Maloaihang = lvi.SubItems[0].Text;
                loaihang.Tenloaihang = lvi.SubItems[1].Text;

                txtmaloaihang.Text = loaihang.Maloaihang.ToString();
                txttenloaihang.Text = loaihang.Tenloaihang.ToString();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btntimkiemloaihang_Click(object sender, EventArgs e)
        {
            string timkiemmaloai = txtmaloaihang.Text;
            string timkiemtenloai = txttenloaihang.Text;
            bool kq = false;

            for (int i=0;i<lsvloaihang.Items.Count;i++)
            {
                if (lsvloaihang.Items[i].SubItems[0].Text==timkiemmaloai|| lsvloaihang.Items[i].SubItems[1].Text==timkiemtenloai)
                {
                    kq = true;
                }
               
            }
            if (kq == true)
            {
                MessageBox.Show("Tim thay");
            }
            else
            {
                MessageBox.Show("khong tim thay");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiemmahang = txtmahang.Text;
            string timkiemtenhang = txttenhang.Text;
            bool kq = false;

            for (int i = 0; i < lvmathang.Items.Count; i++)
            {
                if (lvmathang.Items[i].SubItems[0].Text == timkiemmahang || lvmathang.Items[i].SubItems[1].Text == timkiemtenhang)
                {
                    kq = true;
                }

            }
            if (kq == true)
            {
                MessageBox.Show("Tim thay");
            }
            else
            {
                MessageBox.Show("khong tim thay");
            }
        }

        
    }
}
