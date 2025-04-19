using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyCuaHang
{
    public partial class PhanMatHang : Form
    {
        int STT = 0;
        int TimKiem = 0;
        public PhanMatHang()
        {
            InitializeComponent();
        }
        //Phần chức năng nhập-----------------------
        private void NhapMatHang_Click(object sender, EventArgs e)
        {
            var Check = false;
            if (MaText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Mã","Thông Báo");
            }else if (TenHangText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Tên Hàng", "Thông Báo");
            }else if (HanDungText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Hạn Dùng", "Thông Báo");
            }else if (CTSanXuatText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Công Ty Sản Xuất", "Thông Báo");
            }else if (NamSanXuatText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Năm Sản Xuất", "Thông Báo");
            }else if (LoaiHangText.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Loại Hàng", "Thông Báo");
            }
            else
            {
                if (DSMatHang.Items.Count > 0)
                {
                    for (int i = 0; i < DSMatHang.Items.Count; i++)
                    {
                        if (MaText.Text == DSMatHang.Items[i].SubItems[1].Text)
                        {
                            MessageBox.Show("Mặt hàng đang nhập có Mã Hàng trùng với Mã Hàng có trong danh sách. Xin vui lòng nhập lại", "Thông Báo");
                            Check = true;
                            break;
                        }
                    }
                    if (Check == false)
                    {
                        STT += 1;
                        ListViewItem item = new ListViewItem();
                        item.Text = STT.ToString();
                        item.SubItems.Add(MaText.Text);
                        item.SubItems.Add(TenHangText.Text);
                        item.SubItems.Add(HanDungText.Text);
                        item.SubItems.Add(CTSanXuatText.Text);
                        item.SubItems.Add(NamSanXuatText.Text);
                        item.SubItems.Add(LoaiHangText.Text);
                        DSMatHang.Items.Add(item);
                        MaText.Clear();
                        TenHangText.Clear();
                        HanDungText.Clear();
                        CTSanXuatText.Clear();
                        NamSanXuatText.Clear();
                        LoaiHangText.Clear();
                    }
                }
                else
                {
                    STT += 1;
                    ListViewItem item = new ListViewItem();
                    item.Text = STT.ToString();
                    item.SubItems.Add(MaText.Text);
                    item.SubItems.Add(TenHangText.Text);
                    item.SubItems.Add(HanDungText.Text);
                    item.SubItems.Add(CTSanXuatText.Text);
                    item.SubItems.Add(NamSanXuatText.Text);
                    item.SubItems.Add(LoaiHangText.Text);
                    DSMatHang.Items.Add(item);
                    MaText.Clear();
                    TenHangText.Clear();
                    HanDungText.Clear();
                    CTSanXuatText.Clear();
                    NamSanXuatText.Clear();
                    LoaiHangText.Clear();
                }
               
            }
        }
        //Phần chức năng xóa----------------------------------
        private void XoaMatHang_Click(object sender, EventArgs e)
        {
            STT = 0;
            var Xoa = 0;
            if (TKXoaHang.Text == "")
            {
                MessageBox.Show($"Chưa nhập thông tin {(XoaMaHang.Checked ? "Mã Hàng" : "Tên Hàng")} để xóa", "Thông Báo");
            }else if (DSMatHang.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả để xóa", "Thông Báo");
            }
            else
            {
                for (int i = 0; i < DSMatHang.Items.Count; i++)
                {
                    if (XoaMaHang.Checked)
                    {
                        if (DSMatHang.Items[i].SubItems[1].Text == TKXoaHang.Text)
                        {
                            DSMatHang.Items[i].Remove();
                            i = i - 1;
                            Xoa += 1;
                            TKXoaHang.Text = "";
                            MessageBox.Show("Đã xóa thành công", "Thông Báo");
                        }
                        else
                        {
                            STT += 1;
                            DSMatHang.Items[i].SubItems[0].Text = STT.ToString();
                            if (i == DSMatHang.Items.Count - 1 && Xoa == 0)
                            {
                                MessageBox.Show("Không tìm thấy kết quả để xóa", "Thông Báo");
                            }
                        }
                    }
                    else
                    {
                        if (DSMatHang.Items[i].SubItems[2].Text == TKXoaHang.Text)
                        {
                            DSMatHang.Items[i].Remove();
                            i = i - 1;
                            Xoa += 1;
                            TKXoaHang.Text = "";
                            MessageBox.Show("Đã xóa thành công", "Thông Báo");
                        }
                        else
                        {
                            STT += 1;
                            DSMatHang.Items[i].SubItems[0].Text = STT.ToString();
                            if (i == DSMatHang.Items.Count - 1 && Xoa == 0)
                            {
                                MessageBox.Show("Không tìm thấy kết quả để xóa", "Thông Báo");
                            }
                        }
                    }
                }
            }
        }
        //Phần chức năng sửa---------------------------------------
        private void TKSua_Click(object sender, EventArgs e)
        {
            var Check = false;
            if (TKSuaMatHang.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Mã Hàng để tìm kiếm và cập nhật","Thông Báo");
            }
            else
            {
                for (int i = 0; i < DSMatHang.Items.Count;i++)
                {
                    if (TKSuaMatHang.Text == DSMatHang.Items[i].SubItems[1].Text)
                    {
                        MaText.Text = DSMatHang.Items[i].SubItems[1].Text;
                        TenHangText.Text = DSMatHang.Items[i].SubItems[2].Text;
                        HanDungText.Text = DSMatHang.Items[i].SubItems[3].Text;
                        CTSanXuatText.Text = DSMatHang.Items[i].SubItems[4].Text;
                        NamSanXuatText.Text = DSMatHang.Items[i].SubItems[5].Text; ;
                        LoaiHangText.Text = DSMatHang.Items[i].SubItems[6].Text;
                        TimKiem = i;
                        Check = true;
                        break;
                    }
                }
                if (Check == false)
                {
                    MessageBox.Show("Không tìm thấy thông tin Mã Hàng để cập nhật", "Thông Báo");
                }
            }
        }
        private void CapNhatMatHang_Click(object sender, EventArgs e)
        {
            if (TKSuaMatHang.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin Mã Hàng để cập nhật", "Thông Báo");
            }else if (MaText.Text == "" || TimKiem == 0)
            {
                MessageBox.Show("Hiện không có thông tin Mặt Hàng để cập nhật. Xin vui lòng nhập lại phần tìm kiếm","Thông Báo");
            }
            else
            {
                var Check = false;
                for (int i = 0; i < DSMatHang.Items.Count; i++)
                {
                    if (MaText.Text == DSMatHang.Items[i].SubItems[1].Text && i != TimKiem)
                    {
                        MessageBox.Show("Phần cập nhật Mã Hàng trùng với Mã Hàng có trong Danh Sách Loại Hàng. Xin vui lòng nhập lại", "Thông Báo");
                        Check = true;
                        break;
                    }
                }
                if (Check == false)
                {
                    DSMatHang.Items[TimKiem].SubItems[1].Text = MaText.Text;
                    DSMatHang.Items[TimKiem].SubItems[2].Text = TenHangText.Text;
                    DSMatHang.Items[TimKiem].SubItems[3].Text = HanDungText.Text;
                    DSMatHang.Items[TimKiem].SubItems[4].Text = CTSanXuatText.Text;
                    DSMatHang.Items[TimKiem].SubItems[5].Text = NamSanXuatText.Text;
                    DSMatHang.Items[TimKiem].SubItems[6].Text = LoaiHangText.Text;
                    TimKiem = 0;
                    MaText.Text = "";
                    TenHangText.Text = "";
                    HanDungText.Text = "";
                    CTSanXuatText.Text = "";
                    NamSanXuatText.Text = "";
                    LoaiHangText.Text = "";
                    TKSuaMatHang.Text = "";
                    MessageBox.Show("Đã cập nhật thành công", "Thông Báo");
                }
            }
        }
        //Phần chức năng tìm kiếm---------------------------------------------
        private void TimKiemMatHang_Click(object sender, EventArgs e)
        {
            var TKMH = "";
            for (int i = 0; i < DSMatHang.Items.Count; i++)
            {
                if (TKMaHang.Checked)
                {
                    if (TKTimKiemMatHang.Text == DSMatHang.Items[i].SubItems[1].Text)
                    {
                        TKMH = "Mã : " + DSMatHang.Items[i].SubItems[1].Text + "\n" + 
                            "Tên hàng : " + DSMatHang.Items[i].SubItems[2].Text + "\n" + 
                            "Hạn dùng : " + DSMatHang.Items[i].SubItems[3].Text + "\n" + 
                            "Công ty sản xuất : " + DSMatHang.Items[i].SubItems[4].Text + "\n" + 
                            "Năm sản xuất : " + DSMatHang.Items[i].SubItems[5].Text + "\n" + 
                            "Loại hàng : " + DSMatHang.Items[i].SubItems[6].Text;
                        break;
                    }
                }
                else
                {
                    if (TKTimKiemMatHang.Text == DSMatHang.Items[i].SubItems[2].Text)
                    {
                        TKMH += "Mã : " + DSMatHang.Items[i].SubItems[1].Text + ", " +
                            "Tên hàng : " + DSMatHang.Items[i].SubItems[2].Text + ", " +
                            "Hạn dùng : " + DSMatHang.Items[i].SubItems[3].Text + ", " +
                            "Công ty sản xuất : " + DSMatHang.Items[i].SubItems[4].Text + ", " +
                            "Năm sản xuất : " + DSMatHang.Items[i].SubItems[5].Text + ", " +
                            "Loại hàng : " + DSMatHang.Items[i].SubItems[6].Text + "\n";
                    }
                }
            }
            if (TKMH == "")
            {
                MessageBox.Show("Không tìm thấy Mặt Hàng", "Thông Báo");
            }
            else
            {
                MessageBox.Show(TKMH, "Thông Báo");
            }
        }
        //Phần chức năng chuyển sang Phần Loại Hàng--------------------
        private void phanloaihangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanLoaiHang phanloaihang = new PhanLoaiHang();
            phanloaihang.Show();
        }
    }
}
