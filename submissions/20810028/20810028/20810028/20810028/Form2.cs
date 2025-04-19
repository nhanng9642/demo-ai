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
    public partial class Form2 : Form
    {
        public string[] loaiHang = new string[] { "Quần Jean", "Áo Jean", "Áo sơ mi", "Áo thun" };
        
        public Form2()
        {

            InitializeComponent();
            
            for (int i = 0; i < loaiHang.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = loaiHang[i];
                listView1.Items.Add(item);
                
            }

 


    }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textLoaiHang.Text;
            listView1.Items.Add(item);

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {

                    item.Text = textLoaiHang.Text;
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                    item.Remove();

            }
            MessageBox.Show("Đã xóa thành công");
        }

        
    }
}
