using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20880020
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            SetupListViewItem();
            SetupListViewCtg();
        }

        public void SetupListViewItem()
        {
            listViewItem.View = View.Details;
            listViewItem.FullRowSelect = true;
            listViewItem.CheckBoxes = true;
            listViewItem.MultiSelect = true;
            listViewItem.Columns.Add("ID");
            listViewItem.Columns.Add("Name");
            listViewItem.Columns[1].Width = 120;
            listViewItem.Columns.Add("Expiry Date");
            listViewItem.Columns[2].Width = 70;
            listViewItem.Columns.Add("Company");
            listViewItem.Columns.Add("Manufacture Year");
            listViewItem.Columns[4].Width = 120;
            listViewItem.Columns.Add("Category");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "001";
            item1.SubItems.Add("Mặt hàng 1");
            item1.SubItems.Add("12/3/2022");
            item1.SubItems.Add("Pepsi");
            item1.SubItems.Add("2019");
            item1.SubItems.Add("Soft drink");
            listViewItem.Items.Add(item1);

            ListViewItem item2 = new ListViewItem();
            item2.Text = "002";
            item2.SubItems.Add("Mặt hàng 2");
            item2.SubItems.Add("12/8/2022");
            item2.SubItems.Add("Coca cola");
            item2.SubItems.Add("2020");
            item2.SubItems.Add("Soft drink");
            listViewItem.Items.Add(item2);

            ListViewItem item3 = new ListViewItem();
            item3.Text = "003";
            item3.SubItems.Add("Bánh xốp Nabati");
            item3.SubItems.Add("25/10/2022");
            item3.SubItems.Add("Nabati");
            item3.SubItems.Add("2020");
            item3.SubItems.Add("Wafer");
            listViewItem.Items.Add(item3);
        }

        public void SetupListViewCtg()
        {
            listViewCtg.View = View.Details;
            listViewCtg.FullRowSelect = true;
            listViewCtg.CheckBoxes = true;
            listViewCtg.Columns.Clear();
            listViewCtg.Columns.Add("Name");
            listViewCtg.Columns[0].Width = 120;
            foreach (ListViewItem item in listViewItem.Items)
            {
                listViewCtg.Items.Add(item.SubItems[5].Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Text = "Item";
            //add existed category to ComboBox in form2
            foreach (ListViewItem item in listViewCtg.Items)
            {
                form2.ctgBox.Items.Add(item.Text);
            }
            DialogResult dr = form2.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                ListViewItem newItem = getItemfromF2(form2);
                listViewItem.Items.Add(newItem);
                form2.Close();
            } else if (dr == DialogResult.Cancel)
            {
                form2.Close();
            }
        }

        public static ListViewItem getItemfromF2(Form2 form2)
        {
            ListViewItem item = new ListViewItem();
            item.Text = form2.textBoxID.Text;
            item.SubItems.Add(form2.textBoxName.Text);
            item.SubItems.Add(form2.textBoxExpDate.Text);
            item.SubItems.Add(form2.textBoxCompany.Text);
            item.SubItems.Add(form2.textBoxMfYear.Text);
            item.SubItems.Add(form2.ctgBox.Text);
            return item;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection list = listViewItem.Items;
            foreach (ListViewItem lvi in list)
            {
                if (lvi.Checked == true)
                {
                    list.Remove(lvi);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Text = "Item";
            //add existed category to ComboBox in form2
            foreach (ListViewItem item in listViewCtg.Items)
            {
                form2.ctgBox.Items.Add(item.Text);
            }
            DialogResult dr = form2.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                ListView.ListViewItemCollection list = listViewItem.Items;
                foreach (ListViewItem lvi in list)
                {
                    if (lvi.Text == form2.textBoxID.Text)
                    {
                        int index = list.IndexOf(lvi);
                        list.RemoveAt(index);
                        list.Insert(index, getItemfromF2(form2));
                        break;
                    }
                }
                form2.Close();
            }
            else if (dr == DialogResult.Cancel)
            {
                form2.Close();
            }
        }

        private void listViewItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listViewCtg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            String key = findItem.Text;
            
            ListView.ListViewItemCollection list = listViewItem.Items;
            foreach (ListViewItem item in list)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    if (item.SubItems[i].Text.ToLower().Contains(key.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        break;
                    }
                    else if (item.Text.ToLower().Contains(key.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        break;
                    }
                    else
                    {
                        item.BackColor = default;
                        item.ForeColor = default;
                    }
                }
            }
        }

        private void findBtnCtg_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;

            ListView.ListViewItemCollection list = listViewCtg.Items;
            foreach (ListViewItem item in list)
            {
                if (item.Text.ToLower().Contains(key.ToLower()))
                {
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else
                {
                    item.BackColor = default;
                    item.ForeColor = default;
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listViewItem.Items)
            {
                l.BackColor = default;
                l.ForeColor = default;
            }

            foreach (ListViewItem l in listViewCtg.Items)
            {
                l.BackColor = default;
                l.ForeColor = default;
            }
        }

        private void addBtnCtg_Click(object sender, EventArgs e)
        {
                String newCtg = textBox1.Text;
                listViewCtg.Items.Add(newCtg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void delBtnCtg_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection list = listViewCtg.Items;
            foreach (ListViewItem lvi in list)
            {
                if (lvi.Checked == true)
                {
                    list.Remove(lvi);
                }
            }
        }

        private void editBtnCtg_Click(object sender, EventArgs e)
        {
            String newCtg = textBox1.Text;
            ListView.ListViewItemCollection list = listViewCtg.Items;
            foreach (ListViewItem lvi in list)
            {
                if (lvi.Checked == true)
                {
                    lvi.Text = newCtg;
                }
            }
        }
    }
}
