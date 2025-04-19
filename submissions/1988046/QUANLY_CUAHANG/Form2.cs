using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_CUAHANG
{
    public partial class Form2 : Form
    {
        public ArrayList danhsachLoaiHang = new ArrayList();
        String MaloaihangSelected = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(LoaiHang lh in danhsachLoaiHang)
            { 
                ListViewItem item = new ListViewItem();
                item.Text = lh.MaLoaiHang;
                item.SubItems.Add(lh.TenLoaiHang);            
                listView1.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.MaLoaiHang = txtMaLoaiHang.Text;
            lh.TenLoaiHang = txtTenLoaiHang.Text;

            danhsachLoaiHang.Add(lh);

            ListViewItem item = new ListViewItem();
            item.Text = lh.MaLoaiHang;
            item.SubItems.Add(lh.TenLoaiHang);           

            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maloaihang = "";
            if (listView1.SelectedItems.Count > 0)
            {
                maloaihang = listView1.SelectedItems[0].Text;
                MaloaihangSelected = maloaihang;
                foreach (LoaiHang lh in danhsachLoaiHang)
                    if (lh.MaLoaiHang == maloaihang)
                    {
                        txtMaLoaiHang.Text = lh.MaLoaiHang;
                        txtTenLoaiHang.Text = lh.TenLoaiHang;                        
                    }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (LoaiHang lh in danhsachLoaiHang)
                if (lh.MaLoaiHang == txtMaLoaiHang.Text)
                {
                    lh.MaLoaiHang = txtMaLoaiHang.Text;
                    lh.TenLoaiHang = txtTenLoaiHang.Text;                
                }

            ListViewItem listViewItem = null;
            foreach (ListViewItem item in listView1.Items)
                if (item.Text == txtMaLoaiHang.Text)
                {
                    item.SubItems[1].Text = txtTenLoaiHang.Text;                   

                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiHang selected = null;
            if (MaloaihangSelected != "")
            {
                foreach (LoaiHang lh in danhsachLoaiHang)
                    if (lh.MaLoaiHang == MaloaihangSelected)
                    {
                        selected = lh;
                        break;
                    }
                if (selected != null)
                {
                    danhsachLoaiHang.Remove(selected);
                    //remove from ListView
                    ListViewItem listViewItem = null;
                    foreach (ListViewItem item in listView1.Items)
                        if (item.Text == selected.MaLoaiHang)
                            listViewItem = item;
                    if (listViewItem != null)
                        listView1.Items.Remove(listViewItem);

                    //Reset textbox
                    txtMaLoaiHang.Text = "";
                    txtTenLoaiHang.Text = "";                  
                }
                MaloaihangSelected = "";
            }
        }
    }
}
