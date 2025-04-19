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
    public partial class Form1 : Form
    {
        ArrayList danhsachMatHang = new ArrayList();
        ArrayList danhsachLoaiHang = new ArrayList();
        String MahangSelected = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (MatHang mh in danhsachMatHang)
                if (mh.MaHang == txtMaHang.Text)
                {
                    //Kiem tra neu mat hang da ton tai thi ko them
                    found = true;
                    MessageBox.Show("Mat hang da ton tai");

                }
            if (found==false)
            { 
                MatHang MH = new MatHang();
                MH.MaHang = txtMaHang.Text;
                MH.TenHang = txtTenHang.Text;
                MH.HanDung = DateTime.Parse(cboHanDung.Text);
                MH.CongTySX = txtCongTySX.Text;
                MH.NamSX = int.Parse(txtNamSX.Text);
                MH.LoaiHang = cboLoaiHang.Text;

                danhsachMatHang.Add(MH);

                ListViewItem item = new ListViewItem();
                item.Text = MH.MaHang.ToString();
                item.SubItems.Add(MH.TenHang);
                item.SubItems.Add(MH.HanDung.ToShortDateString());
                item.SubItems.Add(MH.CongTySX);
                item.SubItems.Add(MH.NamSX.ToString());
                item.SubItems.Add(MH.LoaiHang);

                listView1.Items.Add(item);
            }



        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool Found = false;
            foreach (MatHang mh in danhsachMatHang)
                if (mh.MaHang == txtMaHang.Text)
                {
                    MessageBox.Show("Tim thay mat hang");
                    Found = true;
                    txtMaHang.Text = mh.MaHang;
                    txtTenHang.Text = mh.TenHang;
                    txtNamSX.Text = mh.NamSX.ToString();
                    txtCongTySX.Text = mh.CongTySX;
                    cboHanDung.Value = mh.HanDung;
                    cboLoaiHang.Text = mh.LoaiHang;
                }
            if (Found==false)
                MessageBox.Show("Khong tim thay mat hang");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (MatHang mh in danhsachMatHang)
                if (mh.MaHang == txtMaHang.Text)
                {
                    mh.MaHang = txtMaHang.Text;
                    mh.TenHang = txtTenHang.Text;
                    mh.NamSX = int.Parse(txtNamSX.Text);
                    mh.CongTySX=txtCongTySX.Text ;
                    mh.HanDung=cboHanDung.Value  ;
                    mh.LoaiHang = cboLoaiHang.Text;
                }

            ListViewItem listViewItem = null;
            foreach (ListViewItem item in listView1.Items)
                if (item.Text == txtMaHang.Text)
                {
                    item.SubItems[1].Text= txtTenHang.Text;
                    item.SubItems[2].Text = cboHanDung.Value.ToString();
                    item.SubItems[3].Text = txtCongTySX.Text;
                    item.SubItems[4].Text = txtNamSX.Text;
                    item.SubItems[5].Text = cboLoaiHang.Text;

                }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MatHang selected = null;
            MahangSelected = txtMaHang.Text;
            if (MahangSelected !="")
            {
                foreach (MatHang mh in danhsachMatHang)
                    if (mh.MaHang == MahangSelected)
                    {
                        selected = mh;
                        break;
                    }
                if (selected != null)
                {
                    danhsachMatHang.Remove(selected);
                    //remove from ListView
                    ListViewItem listViewItem = null;
                    foreach (ListViewItem item in listView1.Items)
                        if (item.Text == selected.MaHang)
                            listViewItem = item;
                    if (listViewItem != null)
                        listView1.Items.Remove(listViewItem);

                    //Reset textbox
                    txtMaHang.Text = "";
                    txtTenHang.Text = "";
                    txtCongTySX.Text = "";

                }
                MahangSelected = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init LoaiHang
            LoaiHang loaiHang = new LoaiHang();
            loaiHang.MaLoaiHang = "001";
            loaiHang.TenLoaiHang = "Coca";
            danhsachLoaiHang.Add(loaiHang);
            loaiHang = new LoaiHang();
            loaiHang.MaLoaiHang = "002";
            loaiHang.TenLoaiHang = "Pepsi";
            danhsachLoaiHang.Add(loaiHang);

            foreach (LoaiHang lh in danhsachLoaiHang)
                cboLoaiHang.Items.Add(lh.TenLoaiHang);

            cboLoaiHang.SelectedIndex = 0;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String mahang="";
            if (listView1.SelectedItems.Count > 0)
            {
                mahang = listView1.SelectedItems[0].Text;
                MahangSelected = mahang;
                foreach (MatHang mh in danhsachMatHang)
                    if (mh.MaHang == mahang)
                    {
                        txtMaHang.Text = mh.MaHang;
                        txtTenHang.Text = mh.TenHang;
                        txtNamSX.Text = mh.NamSX.ToString();
                        txtCongTySX.Text = mh.CongTySX;
                        cboHanDung.Value = mh.HanDung;
                        cboLoaiHang.Text = mh.LoaiHang;
                    }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.danhsachLoaiHang = danhsachLoaiHang;
            form2.ShowDialog();

            danhsachLoaiHang = form2.danhsachLoaiHang;
            //Load lai danh sach loai hang
            cboLoaiHang.Items.Clear();
            foreach (LoaiHang lh in danhsachLoaiHang)
            {
                cboLoaiHang.Items.Add(lh.TenLoaiHang);
            }
            cboLoaiHang.SelectedIndex = 0;
        }
    }
}
