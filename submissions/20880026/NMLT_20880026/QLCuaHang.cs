using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMLT_20880026
{
    public partial class QLCuaHang : Form
    {
        public QLCuaHang()
        {
            InitializeComponent();
        }



        private void QLCuaHang_Load(object sender, EventArgs e)
        {

        }
        Hang hang;
        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo 1 mớ label, textbox
            Form formPopup = new Form() { Width = 500, Height = 260 };
            formPopup.Text = "Thêm mới";
            Label lblmahang = new Label() { Left = 10, Top = 12 };
            TextBox txtmahang = new TextBox() { Left = 80, Top = 10, Width = 390 };
            lblmahang.Text = "Mã hàng";
            Label lblten = new Label() { Left = 10, Top = 39 };
            TextBox txtten = new TextBox() { Left = 80, Top = 37, Width = 390 };
            lblten.Text = "Tên hàng";
            Label lblhsd = new Label() { Left = 10, Top = 66 };
            TextBox txthsd = new TextBox() { Left = 80, Top = 64, Width = 390 };
            lblhsd.Text = "HSD";
            Label lblctsx = new Label() { Left = 10, Top = 93 };
            TextBox txtctsx = new TextBox() { Left = 80, Top = 91, Width = 390 };
            lblctsx.Text = "Công ty SX";
            Label lblnamsx = new Label() { Left = 10, Top = 120 };
            TextBox txtnamsx = new TextBox() { Left = 80, Top = 118, Width = 390 };
            lblnamsx.Text = "Năm SX";
            Label lblloaihang = new Label() { Left = 10, Top = 147 };
            TextBox txtloaihang = new TextBox() { Left = 80, Top = 144, Width = 390 };
            lblloaihang.Text = "Loại hàng";
            //tạo nút
            Button taomoi = new Button() { Left = 300, Top = 180 };
            taomoi.Text = "Tạo mới";
            formPopup.AcceptButton = taomoi;
            Button huybo = new Button() { Left = 400, Top = 180 };
            huybo.Text = "Hủy bỏ";
            formPopup.CancelButton = huybo;
            //thêm mới label, text, btn vào formpopup
            formPopup.Controls.Add(txtmahang);
            formPopup.Controls.Add(txtten);
            formPopup.Controls.Add(txthsd);
            formPopup.Controls.Add(txtctsx);
            formPopup.Controls.Add(txtnamsx);
            formPopup.Controls.Add(txtloaihang);
            formPopup.Controls.Add(lblmahang);
            formPopup.Controls.Add(lblten);
            formPopup.Controls.Add(lblhsd);
            formPopup.Controls.Add(lblctsx);
            formPopup.Controls.Add(lblnamsx);
            formPopup.Controls.Add(lblloaihang);
            formPopup.Controls.Add(taomoi);
            formPopup.Controls.Add(huybo);
            taomoi.Click += delegate
            {
                hang.mahang = txtmahang.Text;
                hang.tenhang = txtten.Text;
                hang.hsd = txthsd.Text;
                hang.ctsx = txtctsx.Text;
                hang.loaihang = txtloaihang.Text;
                hang.namsx = txtnamsx.Text;
                if (hang.tenhang == "" || hang.mahang == "" || hang.hsd == "" || hang.ctsx == "" || hang.namsx == "" || hang.loaihang == "")
                {
                    MessageBox.Show("Tất cả các mục cần chứa dữ liệu");
                }
                else
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = hang.mahang;
                    item.SubItems.Add(hang.tenhang);
                    item.SubItems.Add(hang.hsd);
                    item.SubItems.Add(hang.ctsx);
                    item.SubItems.Add(hang.namsx);
                    item.SubItems.Add(hang.loaihang);
                    listView1.Items.Add(item);
                    formPopup.Close();
                }
            };
            formPopup.FormClosing += delegate
            {
                hang = default(Hang);
            };
            formPopup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Form formPopup = new Form() { Width = 500, Height = 260 };
                formPopup.Text = "Chỉnh sửa";
                Label lblmahang = new Label() { Left = 10, Top = 12 };
                TextBox txtmahang = new TextBox() { Left = 80, Top = 10, Width = 390 };
                lblmahang.Text = "Mã hàng";
                Label lblten = new Label() { Left = 10, Top = 39 };
                TextBox txtten = new TextBox() { Left = 80, Top = 37, Width = 390 };
                lblten.Text = "Tên hàng";
                Label lblhsd = new Label() { Left = 10, Top = 66 };
                TextBox txthsd = new TextBox() { Left = 80, Top = 64, Width = 390 };
                lblhsd.Text = "HSD";
                Label lblctsx = new Label() { Left = 10, Top = 93 };
                TextBox txtctsx = new TextBox() { Left = 80, Top = 91, Width = 390 };
                lblctsx.Text = "Công ty SX";
                Label lblnamsx = new Label() { Left = 10, Top = 120 };
                TextBox txtnamsx = new TextBox() { Left = 80, Top = 118, Width = 390 };
                lblnamsx.Text = "Năm SX";
                Label lblloaihang = new Label() { Left = 10, Top = 147 };
                TextBox txtloaihang = new TextBox() { Left = 80, Top = 144, Width = 390 };
                lblloaihang.Text = "Loại hàng";
                txtmahang.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtten.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txthsd.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtctsx.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtnamsx.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtloaihang.Text = listView1.SelectedItems[0].SubItems[5].Text;
                //tạo nút
                Button chinhsua = new Button() { Left = 300, Top = 180 };
                chinhsua.Text = "Chỉnh sửa";
                formPopup.AcceptButton = chinhsua;
                Button huybo = new Button() { Left = 400, Top = 180 };
                huybo.Text = "Hủy bỏ";
                formPopup.CancelButton = huybo;
                formPopup.Controls.Add(txtmahang);
                formPopup.Controls.Add(txtten);
                formPopup.Controls.Add(txthsd);
                formPopup.Controls.Add(txtctsx);
                formPopup.Controls.Add(txtnamsx);
                formPopup.Controls.Add(txtloaihang);
                formPopup.Controls.Add(lblmahang);
                formPopup.Controls.Add(lblten);
                formPopup.Controls.Add(lblhsd);
                formPopup.Controls.Add(lblctsx);
                formPopup.Controls.Add(lblnamsx);
                formPopup.Controls.Add(lblloaihang);
                formPopup.Controls.Add(chinhsua);
                formPopup.Controls.Add(huybo);
                chinhsua.Click += delegate
                {
                    hang.mahang = txtmahang.Text;
                    hang.tenhang = txtten.Text;
                    hang.hsd = txthsd.Text;
                    hang.ctsx = txtctsx.Text;
                    hang.namsx = txtnamsx.Text;
                    hang.loaihang = txtloaihang.Text;
                    if (hang.tenhang == "" || hang.mahang == "" || hang.hsd == "" || hang.ctsx == "" || hang.namsx == "" || hang.loaihang == "")
                    {
                        MessageBox.Show("Tất cả các mục cần chứa dữ liệu");
                    }
                    else
                    {
                        listView1.SelectedItems[0].SubItems[0].Text = hang.mahang;
                        listView1.SelectedItems[0].SubItems[1].Text = hang.tenhang;
                        listView1.SelectedItems[0].SubItems[2].Text = hang.hsd;
                        listView1.SelectedItems[0].SubItems[3].Text = hang.ctsx;
                        listView1.SelectedItems[0].SubItems[4].Text = hang.namsx;
                        listView1.SelectedItems[0].SubItems[5].Text = hang.loaihang;
                        formPopup.Close();
                    }
                };
                formPopup.FormClosing += delegate
                {
                    hang = default(Hang);
                };
                formPopup.ShowDialog();
            }
            else
                MessageBox.Show("Hãy chọn mặt hàng cần chỉnh sửa");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[1].Text.ToLower().Contains(textBox1.Text.ToLower()) || item.SubItems[5].Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        item.Selected = true;
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = SystemColors.Window;
                        item.ForeColor = SystemColors.ControlText;
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Selected = false;
                    item.BackColor = SystemColors.Window;
                    item.ForeColor = SystemColors.ControlText;
                }
        }
    }
 }