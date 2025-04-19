using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20880010
{
    public partial class MH_Chinh : Form
    {

        string[] LoaiHang;
        ListViewItem lvi = new ListViewItem();

        public MH_Chinh()
        {
            InitializeComponent();
        }

       
        private void MH_Chinh_Load(object sender, EventArgs e)
        {
            int [] NamSX = new int[] {2015,2016,2017,2018,2019,2020 };
            LoaiHang = new string[4] { "Classic","Accoustic","Trống Cajon", "Guitar điện"};
            foreach (int a in NamSX)
            {
                cbb_NamSX.Items.Add(a);
            }
            foreach (string a in LoaiHang)
            {
                cbb_Loai.Items.Add(a);
                lv_LoaiHang.Items.Add(a);
            }

            lvi = new ListViewItem("MH01");
            lvi.SubItems.Add("Guitar 1");
            lvi.SubItems.Add("01/01/2020");
            lvi.SubItems.Add("ABC");
            lvi.SubItems.Add("2015");
            lvi.SubItems.Add("Classic");
            lv_DanhSach.Items.Add(lvi);

            lvi = new ListViewItem("MH02");
            lvi.SubItems.Add("Guitar 2");
            lvi.SubItems.Add("12/01/2020");
            lvi.SubItems.Add("XYZ");
            lvi.SubItems.Add("2016");
            lvi.SubItems.Add("Accoustic");
            lv_DanhSach.Items.Add(lvi);

            lvi = new ListViewItem("MH03");
            lvi.SubItems.Add("Trống");
            lvi.SubItems.Add("13/01/2020");
            lvi.SubItems.Add("XYZ");
            lvi.SubItems.Add("2017");
            lvi.SubItems.Add("Trống Cajon");
            lv_DanhSach.Items.Add(lvi);

            lvi = new ListViewItem("MH04");
            lvi.SubItems.Add("Guitar 3");
            lvi.SubItems.Add("15/02/1998");
            lvi.SubItems.Add("XYZ");
            lvi.SubItems.Add("2017");
            lvi.SubItems.Add("Guitar điện");
            lv_DanhSach.Items.Add(lvi);
        }

        
        private void lv_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_DanhSach.SelectedItems.Count>0)
            {
                lvi = lv_DanhSach.SelectedItems[0];

                string MaHang = lvi.SubItems[0].Text;
                string TenHang = lvi.SubItems[1].Text;
                DateTime HanDung = DateTime.Parse(lvi.SubItems[2].Text);
                string CongTySX = lvi.SubItems[3].Text;
                int NamSX = int.Parse(lvi.SubItems[4].Text);
                string Loai = lvi.SubItems[5].Text;

                tb_MaHang.Text = MaHang;
                tb_TenHang.Text = TenHang;
                dt_HanDung.Value = HanDung;
                tb_CongTySX.Text = CongTySX;
                cbb_NamSX.Text = NamSX.ToString();
                cbb_Loai.Text = Loai;

            }
           
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (lv_DanhSach.SelectedItems.Count > 0)
            {

                string MaHang = tb_MaHang.Text;
                string TenHang = tb_TenHang.Text;
                DateTime HanDung = dt_HanDung.Value;
                string CongTySX = tb_CongTySX.Text;
                int NamSX = int.Parse(cbb_NamSX.Text);
                string Loai = cbb_Loai.Text;

                lvi = lv_DanhSach.SelectedItems[0];
                lvi.SubItems[0].Text = MaHang;
                lvi.SubItems[1].Text = TenHang;
                lvi.SubItems[2].Text = HanDung.ToString();
                lvi.SubItems[3].Text = CongTySX;
                lvi.SubItems[4].Text = NamSX.ToString();
                lvi.SubItems[5].Text = Loai;
            }
        }

        private void tb_TimSP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in lv_DanhSach.Items)
            {
                //Tìm theo tên hàng
                if (item.SubItems[1].Text.ToLower().StartsWith(tb_TimSP.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = Color.CornflowerBlue;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }

            }
            
            if (lv_DanhSach.SelectedItems.Count == 1)
            {
              lv_DanhSach.Focus();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbb_NamSX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv_DanhSach.CheckedItems)
            {
                lv_DanhSach.Items.Remove(lvi);                
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }


        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (tb_MaHang.Text.Trim() != "")
            {
               
                string MaHang = tb_MaHang.Text;
                string TenHang = tb_TenHang.Text;
                DateTime HanDung = dt_HanDung.Value;
                string CongTySX = tb_CongTySX.Text;
                int NamSX = int.Parse(cbb_NamSX.Text);
                string Loai = cbb_Loai.Text;             

                ListViewItem dong = new ListViewItem();
                dong.Text = MaHang.ToString();
                dong.SubItems.Add(TenHang.ToString());
                dong.SubItems.Add(HanDung.ToString());
                dong.SubItems.Add(CongTySX.ToString());
                dong.SubItems.Add(NamSX.ToString());
                dong.SubItems.Add(Loai.ToString());
                lv_DanhSach.Items.Add(dong);
            }

        }

        private void Lv_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a = new ListViewItem();
            if (lv_LoaiHang.SelectedItems.Count > 0)
            {
                a = lv_LoaiHang.SelectedItems[0];

                string LoaiHang = a.SubItems[0].Text;
                tb_lh_LoaiHang.Text = LoaiHang;             

            }
        }

        private void Tb_lh_LoaiHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_lh_Them_Click(object sender, EventArgs e)
        {
            
            if(tb_lh_LoaiHang.Text.Trim() !="")
            {
                string LH = tb_lh_LoaiHang.Text;
                ListViewItem dong = new ListViewItem();
                dong.Text = LH.ToString();
                lv_LoaiHang.Items.Add(dong);
            }
            
        }

        private void Bt_lh_Xoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv_LoaiHang.CheckedItems)
            {
                lv_LoaiHang.Items.Remove(lvi);
            }
        }

        private void Bt_lh_CapNhat_Click(object sender, EventArgs e)
        {
            if (lv_LoaiHang.SelectedItems.Count > 0)
            {

                string LH = tb_lh_LoaiHang.Text;
                lvi = lv_LoaiHang.SelectedItems[0];
                lvi.SubItems[0].Text = LH;
                
            }
        }

        private void Bt_lh_Tim_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_LoaiHang.Items)
            {

                if (item.Text.ToLower().StartsWith(tb_lh_TimKiem.Text.ToLower()))
                {
                    item.Selected = true;
                    item.BackColor = Color.CornflowerBlue;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }

            if (lv_LoaiHang.SelectedItems.Count == 1)
            {
                lv_LoaiHang.Focus();
            }
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
