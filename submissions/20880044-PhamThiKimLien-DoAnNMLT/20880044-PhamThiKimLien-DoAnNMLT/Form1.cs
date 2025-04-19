using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20880044_PhamThiKimLien_DoAnNMLT
{
    public partial class Form1 : Form
    {
        //DEADLINE: 6:00 PM, 12/12/2020
        //Viết phần mềm quản lý cửa hàng với các chức năng sau:
        //Thêm, xóa, sửa và tìm kiếm các mặt hàng(mã, tên hàng, hạn dùng, công ty sản xuất, năm sản xuất, loại hàng).
        //Thêm, xóa, sửa và tìm kiếm các loại hàng.

        //Chú ý:
        //Làm với giao diện console hoặc windows form
        //Các dữ liệu không cần lưu trữ lại
        
        ListViewItem HangHoa;
        ListViewItem LoaiHang;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {        
            //Load combo Năm sản xuất
            int[] Nam = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030 };
            for (int i = 0; i < Nam.Length; i++)
            { 
                cbNamSanXuat.Items.Add(Nam[i]); 
            }
            //Format DateTimePicker
            dtpHanDung.Format = DateTimePickerFormat.Custom;
            dtpHanDung.CustomFormat = "           ";
        }
        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            //Format 
            listViewLoaiHang.Visible = true;
            listViewTimKiemLoaiHang.Visible = false;
            //Đổ dữ liệu từ textbox vào listView
            if (txtLoaiHang.Text.Trim()!="")
            {
                LoaiHang = new ListViewItem();
                LoaiHang.Text = txtLoaiHang.Text;

                listViewLoaiHang.Items.Add(LoaiHang);
                //Dữ liệu đồng thời đổ vào list tìm kiếm luôn.                
                listViewTimKiemLoaiHang.Items.Add(LoaiHang.Clone() as ListViewItem);
            }
            //Xóa dữ liệu trong textbox sau khi Click nút Thêm
            txtLoaiHang.Clear();            
            //Đổ dữ liệu trong listview vào combobox Loại hàng
            cbLoaiHang.Items.Clear();
            for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
            {                
                cbLoaiHang.Items.Add(listViewLoaiHang.Items[i].Text);
            }
        }
        private void btnTimKiemLoaiHang_Click(object sender, EventArgs e)
        {
            //Format listview
            listViewLoaiHang.Visible = false;
            listViewTimKiemLoaiHang.Visible = true;
            //Tìm kiếm
            listViewTimKiemLoaiHang.Items.Clear();
            for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
            {
                if (listViewLoaiHang.Items[i].Text.Contains(txtTimKiemLoaiHang.Text.Trim()))
                    listViewTimKiemLoaiHang.Items.Add(listViewLoaiHang.Items[i].Clone() as ListViewItem);
            }
        }
        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (listViewTimKiemLoaiHang.Visible)
            {
                if (listViewTimKiemLoaiHang.FocusedItem != null)
                {
                    for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
                    {
                        if (listViewLoaiHang.Items[i].Text.Contains(listViewTimKiemLoaiHang.FocusedItem.Text))
                            listViewLoaiHang.Items[i].Remove();
                    }
                    listViewTimKiemLoaiHang.FocusedItem.Remove();
                }
            }
            else
            {
                if (listViewLoaiHang.FocusedItem != null)
                    listViewLoaiHang.FocusedItem.Remove();
            }
            //Đổ dữ liệu trong listview vào combobox Loại hàng
            cbLoaiHang.Items.Clear();
            for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
            {
                cbLoaiHang.Items.Add(listViewLoaiHang.Items[i].Text);
            }
        }
        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (listViewTimKiemLoaiHang.Visible)
            {
                //Format
                if (listViewTimKiemMatHang.Items.Count >= 0)                
                    btnLuuLoaiHang.Enabled = true;                
                //Sửa loại hàng
                if (listViewTimKiemLoaiHang.FocusedItem != null)
                    txtLoaiHang.Text = listViewTimKiemLoaiHang.FocusedItem.Text;
            }
            else
            {
                //Format
                if (listViewLoaiHang.Items.Count > 0)
                    btnLuuLoaiHang.Enabled = true;                
                //Sửa loại hàng
                if (listViewLoaiHang.FocusedItem != null)
                    txtLoaiHang.Text = listViewLoaiHang.FocusedItem.Text;
            }            
        }
        private void btnLuuLoaiHang_Click(object sender, EventArgs e)
        {
            //Format
            btnLuuLoaiHang.Enabled = false;
            //Lưu Loai Hang
            if (listViewTimKiemLoaiHang.Visible)
            {
                if (listViewTimKiemLoaiHang.FocusedItem != null)
                {
                    for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
                    {
                        if (listViewLoaiHang.Items[i].Text.Contains(listViewTimKiemLoaiHang.FocusedItem.Text))
                            listViewLoaiHang.Items[i].Text = txtLoaiHang.Text;
                    }
                    listViewTimKiemLoaiHang.FocusedItem.Text = txtLoaiHang.Text;
                    txtLoaiHang.Clear();
                }
            }
            else
            {
                if (listViewLoaiHang.FocusedItem != null)
                {                   
                    listViewLoaiHang.FocusedItem.Text = txtLoaiHang.Text;
                    txtLoaiHang.Clear();
                }
            }            
            //Đổ dữ liệu trong listview vào combobox Loại hàng
            cbLoaiHang.Items.Clear();
            for (int i = 0; i < listViewLoaiHang.Items.Count; i++)
            {
                cbLoaiHang.Items.Add(listViewLoaiHang.Items[i].Text);
            }            
        }

        //--------------------------------------------------------------------------
        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            //Format
            listViewMatHang.Visible = true;
            listViewTimKiemMatHang.Visible = false;
            //Đổ dữ liệu từ textbox, combobox vào listView
            if (txtMaHang.Text.Trim() != "" || txtTenHang.Text.Trim() != "" ||(dtpHanDung.Text.Trim() != "" || txtCongTySanXuat.Text.Trim() != "" || cbNamSanXuat.Text.Trim() != "" || cbLoaiHang.Text.Trim() != ""))
            {
                HangHoa = new ListViewItem();
                HangHoa.Text = txtMaHang.Text;
                HangHoa.SubItems.Add(txtTenHang.Text);
                HangHoa.SubItems.Add(dtpHanDung.Text);
                HangHoa.SubItems.Add(txtCongTySanXuat.Text);
                HangHoa.SubItems.Add(cbNamSanXuat.Text);
                HangHoa.SubItems.Add(cbLoaiHang.Text);

                listViewMatHang.Items.Add(HangHoa);
                //Dữ liệu đồng thời đổ vào list tìm kiếm luôn.
                listViewTimKiemMatHang.Items.Add(HangHoa.Clone() as ListViewItem);
            }
            //Xóa dữ liệu trong textbox, combobox sau khi Click nút Thêm
            txtMaHang.Clear();
            txtTenHang.Clear();
            dtpHanDung.Format = DateTimePickerFormat.Custom;
            txtCongTySanXuat.Clear();
            cbNamSanXuat.SelectedIndex = -1;
            cbLoaiHang.SelectedIndex = -1;
        }
        private void btnTimKiemMatHang_Click(object sender, EventArgs e)
        {
            listViewTimKiemMatHang.Items.Clear();            
            for (int i = 0; i < listViewMatHang.Items.Count; i++)
            {
                bool Match = false;
                for (int j = 0; j < listViewMatHang.Items[i].SubItems.Count; j++)
                {
                    if (listViewMatHang.Items[i].SubItems[j].Text.Contains(txtTimKiemMatHang.Text.Trim()))
                    {
                        Match = true;
                        break;
                    }
                }
                if (Match)
                listViewTimKiemMatHang.Items.Add(listViewMatHang.Items[i].Clone() as ListViewItem);
            }
            //Format listview
            listViewMatHang.Visible = false;
            listViewTimKiemMatHang.Visible = true;
            
        }
        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            if (listViewTimKiemMatHang.Visible)
            {
                if (listViewTimKiemMatHang.FocusedItem != null)
                {
                    //Xóa trong listview MatHang
                    for (int i = 0; i < listViewMatHang.Items.Count; i++)
                    {
                        if (listViewMatHang.Items[i].Text.Contains(listViewTimKiemMatHang.FocusedItem.Text))
                            listViewMatHang.Items[i].Remove();
                    }
                    //Xóa trong listview TimKiemMatHang
                    listViewTimKiemMatHang.FocusedItem.Remove();
                }                
            }
            else
            {
                if (listViewMatHang.FocusedItem != null)
                    listViewMatHang.FocusedItem.Remove();
            }            
        }
        private void btnSuaMatHang_Click(object sender, EventArgs e)
        {

            if (listViewTimKiemMatHang.Visible)
            {
                //Format
                if (listViewTimKiemLoaiHang.Items.Count>=0)                
                    btnLuuMatHang.Enabled = true;                
                //Sửa
                if (listViewTimKiemMatHang.FocusedItem != null)
                {
                    txtMaHang.Text = listViewTimKiemMatHang.FocusedItem.Text;
                    txtTenHang.Text = listViewTimKiemMatHang.FocusedItem.SubItems[1].Text;
                    if (listViewTimKiemMatHang.FocusedItem.SubItems[2].Text.Trim() != "")
                        dtpHanDung.Text = listViewTimKiemMatHang.FocusedItem.SubItems[2].Text;
                    else dtpHanDung.Format = DateTimePickerFormat.Custom;
                    txtCongTySanXuat.Text = listViewTimKiemMatHang.FocusedItem.SubItems[3].Text;
                    cbNamSanXuat.Text = listViewTimKiemMatHang.FocusedItem.SubItems[4].Text;
                    cbLoaiHang.Text = listViewTimKiemMatHang.FocusedItem.SubItems[5].Text;
                }
            }
            else
            {
                //Format
                if (listViewMatHang.Items.Count > 0)                
                    btnLuuMatHang.Enabled = true;                
                //Sửa
                if (listViewMatHang.FocusedItem != null)
                {
                    txtMaHang.Text = listViewMatHang.FocusedItem.Text;
                    txtTenHang.Text = listViewMatHang.FocusedItem.SubItems[1].Text;
                    if (listViewMatHang.FocusedItem.SubItems[2].Text.Trim() != "")
                        dtpHanDung.Text = listViewMatHang.FocusedItem.SubItems[2].Text;
                    else dtpHanDung.Format = DateTimePickerFormat.Custom;
                    txtCongTySanXuat.Text = listViewMatHang.FocusedItem.SubItems[3].Text;
                    cbNamSanXuat.Text = listViewMatHang.FocusedItem.SubItems[4].Text;
                    cbLoaiHang.Text = listViewMatHang.FocusedItem.SubItems[5].Text;
                }
            }                    
        }
        private void btnLuuMatHang_Click(object sender, EventArgs e)
        {
            //format 
            btnLuuMatHang.Enabled = false;
            //Lưu mặt hàng
            if (listViewTimKiemMatHang.Visible)
            {
                if (listViewTimKiemMatHang.FocusedItem != null)
                {
                    //Lưu trong listview MatHang
                    for (int i = 0; i < listViewMatHang.Items.Count; i++)
                    {
                        if (listViewMatHang.Items[i].Text.Contains(listViewTimKiemMatHang.FocusedItem.Text))
                        {
                            listViewMatHang.Items[i].Text = txtMaHang.Text;
                            listViewMatHang.Items[i].SubItems[1].Text = txtTenHang.Text;
                            listViewMatHang.Items[i].SubItems[2].Text = dtpHanDung.Text;
                            listViewMatHang.Items[i].SubItems[3].Text = txtCongTySanXuat.Text;
                            listViewMatHang.Items[i].SubItems[4].Text = cbNamSanXuat.Text;
                            listViewMatHang.Items[i].SubItems[5].Text = cbLoaiHang.Text;
                        }
                    }
                    //Lưu trong listview TimKiemMatHang
                    listViewTimKiemMatHang.FocusedItem.Text = txtMaHang.Text;
                    listViewTimKiemMatHang.FocusedItem.SubItems[1].Text = txtTenHang.Text;
                    listViewTimKiemMatHang.FocusedItem.SubItems[2].Text = dtpHanDung.Text;
                    listViewTimKiemMatHang.FocusedItem.SubItems[3].Text = txtCongTySanXuat.Text;
                    listViewTimKiemMatHang.FocusedItem.SubItems[4].Text = cbNamSanXuat.Text;
                    listViewTimKiemMatHang.FocusedItem.SubItems[5].Text = cbLoaiHang.Text;
                    txtMaHang.Clear();
                    txtTenHang.Clear();
                    dtpHanDung.Format = DateTimePickerFormat.Custom;
                    txtCongTySanXuat.Clear();
                    cbNamSanXuat.SelectedIndex = -1;
                    cbLoaiHang.SelectedIndex = -1;
                }
            }
            else
            {
                if (listViewMatHang.FocusedItem != null)
                {
                    //Lưu trong listview MatHang
                    listViewMatHang.FocusedItem.Text = txtMaHang.Text;
                    listViewMatHang.FocusedItem.SubItems[1].Text = txtTenHang.Text;
                    listViewMatHang.FocusedItem.SubItems[2].Text = dtpHanDung.Text;
                    listViewMatHang.FocusedItem.SubItems[3].Text = txtCongTySanXuat.Text;
                    listViewMatHang.FocusedItem.SubItems[4].Text = cbNamSanXuat.Text;
                    listViewMatHang.FocusedItem.SubItems[5].Text = cbLoaiHang.Text;
                    txtMaHang.Clear();
                    txtTenHang.Clear();
                    dtpHanDung.Format = DateTimePickerFormat.Custom;
                    txtCongTySanXuat.Clear();
                    cbNamSanXuat.SelectedIndex = -1;
                    cbLoaiHang.SelectedIndex = -1;
                }
            }                    
        }      
        private void dtpHanDung_ValueChanged(object sender, EventArgs e)
        {
            dtpHanDung.Format = DateTimePickerFormat.Short;
        }



    }
}

    
       



        



    

        
    
