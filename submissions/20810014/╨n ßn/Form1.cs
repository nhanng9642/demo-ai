using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();      
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HANG[] Arr = new HANG[3];
            Arr[0].TenMH = "Aquafina";Arr[0].MaMH = "Mh001";Arr[0].Cty = "HCM";Arr[0].NamSX = "2020";Arr[0].HSD = "22/12/2020";Arr[0].LoaiHang = "Nước suối";
            Arr[1].TenMH = "Cocacola"; Arr[1].MaMH = "Mh002"; Arr[1].Cty = "HCM"; Arr[1].NamSX = "2020"; Arr[1].HSD = "26/9/2020"; Arr[1].LoaiHang = "Nước ngọt";
            Arr[2].TenMH = "Mountain Dew"; Arr[2].MaMH = "Mh003"; Arr[2].Cty = "HCM"; Arr[2].NamSX = "2020"; Arr[2].HSD = "13/5/2020"; Arr[2].LoaiHang = "Nước ngọt";
            listView1.Items.Clear();
            for(int i = 0; i < Arr.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Arr[i].MaMH.ToString();
                item.SubItems.Add(Arr[i].TenMH.ToString());
                item.SubItems.Add(Arr[i].Cty.ToString());
                item.SubItems.Add(Arr[i].NamSX.ToString());
                item.SubItems.Add(Arr[i].HSD.ToString());
                item.SubItems.Add(Arr[i].LoaiHang.ToString());
                listView1.Items.Add(item);
            }
        }


        private void btnThemMH_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { txtMaMH.Text, txtTenMH.Text, txtCty.Text, txtNamsx.Text, txtHSD.Text, txtLoaiHang.Text });
            this.listView1.Items.AddRange(new ListViewItem[] { item });
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtMaMH.Text = item.Text;
            txtTenMH.Text = item.SubItems[1].Text;
            txtCty.Text = item.SubItems[2].Text;
            txtNamsx.Text = item.SubItems[3].Text;
            txtHSD.Text = item.SubItems[4].Text;
            txtLoaiHang.Text = item.SubItems[5].Text;

        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var xacnhan = MessageBox.Show("Bạn muốn xóa dòng này ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem item = listView1.SelectedItems[i];
                        listView1.Items[item.Index].Remove();
                    }
                }
            }
            else
                MessageBox.Show("Chọn dòng cần xóa");
        }


       

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < listView1.Items.Count; i++)
            {
                if(listView1.Items[i].Text == txtMaMH.Text)
                {
                    listView1.Items[i].SubItems[1].Text = txtTenMH.Text;
                    listView1.Items[i].SubItems[2].Text = txtCty.Text;
                    listView1.Items[i].SubItems[3].Text = txtNamsx.Text;
                    listView1.Items[i].SubItems[4].Text = txtHSD.Text;
                    listView1.Items[i].SubItems[5].Text = txtLoaiHang.Text;
                    return;
                }
            }
            ListViewItem item = new ListViewItem(new string[] { txtMaMH.Text, txtTenMH.Text, txtCty.Text, txtNamsx.Text, txtHSD.Text, txtLoaiHang.Text });
            this.listView1.Items.AddRange(new ListViewItem[] { item });
        }

        private void btnTimTenMH_Click(object sender, EventArgs e)
        {

        }
        private static HANG[] mathang;
        private void txtTimTenMH_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    if (subitem.Text.Equals(txtTimTenMH.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        break;
                    }
        }
        

       
    }      
}

