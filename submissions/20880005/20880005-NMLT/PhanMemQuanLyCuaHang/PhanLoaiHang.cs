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
    public partial class PhanLoaiHang : Form
    {
        int STT = 0;
        public PhanLoaiHang()
        {
            InitializeComponent();
        }
        //Phần chức năng nhập----------------------------
        private void NhapLoaiHang_Click(object sender, EventArgs e)
        {
            var Check = false;
            if (NhapLoaiHangText.Text == "")
            {
                MessageBox.Show("Chưa nhập Loại hàng","Thông Báo");
            }
            else
            {
                if (DSLoaiHang.Items.Count > 0)
                {
                    for (int i = 0; i < DSLoaiHang.Items.Count; i++)
                    {
                        if (NhapLoaiHangText.Text == DSLoaiHang.Items[i].SubItems[1].Text)
                        {
                            MessageBox.Show("Loại hàng đang nhập hiện đã có trong danh sách. Xin vui lòng nhập lại","Thông Báo");
                            Check = true;
                            break;
                        }
                    }
                    if (Check == false)
                    {
                        STT += 1;
                        ListViewItem item = new ListViewItem();
                        item.Text = STT.ToString();
                        item.SubItems.Add(NhapLoaiHangText.Text);
                        DSLoaiHang.Items.Add(item);
                        NhapLoaiHangText.Text = "";
                    }
                }
                else
                {
                    STT += 1;
                    ListViewItem item = new ListViewItem();
                    item.Text = STT.ToString();
                    item.SubItems.Add(NhapLoaiHangText.Text);
                    DSLoaiHang.Items.Add(item);
                    NhapLoaiHangText.Text = "";
                }
            }
        }
        //Phần chức năng xóa-----------------------
        private void XoaLoaiHang_Click(object sender, EventArgs e)
        {
            STT = 0;
            var Xoa = 0;
            if (XoaLoaiHangText.Text == "")
            {
                MessageBox.Show("Chưa nhập Loại hàng", "Thông Báo");
            }
            else
            {
                if (DSLoaiHang.Items.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy Loại Hàng để xóa. Xin vui lòng nhập lại", "Thông Báo");
                }
                else
                {
                    for (int i = 0; i < DSLoaiHang.Items.Count; i++)
                    {
                        if (DSLoaiHang.Items[i].SubItems[1].Text == XoaLoaiHangText.Text)
                        {
                            DSLoaiHang.Items[i].Remove();
                            i = i - 1;
                            Xoa += 1;
                            XoaLoaiHangText.Text = "";
                            MessageBox.Show("Đã xóa thành công", "Thông Báo");
                        }
                        else
                        {
                            STT += 1;
                            DSLoaiHang.Items[i].SubItems[0].Text = STT.ToString();
                            if (i == DSLoaiHang.Items.Count - 1 && Xoa == 0)
                            {
                                MessageBox.Show("Không tìm thấy Loại Hàng để xóa. Xin vui lòng nhập lại", "Thông Báo");
                            }
                        }
                    }
                }
            }
        }
        //Phần chức năng tìm kiếm---------------------
        private void TimKiemLoaiHang_Click(object sender, EventArgs e)
        {
            var TKLH = "";
            for (int i = 0; i < DSLoaiHang.Items.Count; i++)
            {
                if (TKLoaiHangText.Text == DSLoaiHang.Items[i].SubItems[1].Text)
                {
                    TKLH = $"Tìm thấy 1 loại hàng {TKLoaiHangText.Text}";
                }
            }
            if (TKLH == "")
            {
                MessageBox.Show("Không tìm thấy Loại Hàng. Xin vui lòng nhập lại", "Thông Báo");
            }
            else
            {
                TKLoaiHangText.Text = "";
                MessageBox.Show(TKLH, "Thông Báo");
            }
        }
        //Phần chức năng sửa---------------------------
        private void CapNhatLoaiHang_Click(object sender, EventArgs e)
        {
            var Check = false;
            if (TKChinhSuaText.Text == "")
            {
                MessageBox.Show("Chưa nhập Loại Hàng để chỉnh sửa", "Thông Báo");
            }
            else 
            {
                for (int i = 0; i < DSLoaiHang.Items.Count; i++)
                {
                    if (CapNhatLoaiHangText.Text == DSLoaiHang.Items[i].SubItems[1].Text)
                    {
                        MessageBox.Show("Phần cập nhật Loại Hàng đã có trong Danh Sách Loại Hàng. Xin vui lòng nhập lại", "Thông Báo");
                        Check = true;
                        break;
                    }
                }
                if (Check == false)
                {
                    if (CapNhatLoaiHangText.Text != "")
                    {
                        for (int j = 0; j < DSLoaiHang.Items.Count; j++)
                        {
                            if (TKChinhSuaText.Text == DSLoaiHang.Items[j].SubItems[1].Text)
                            {
                                DSLoaiHang.Items[j].SubItems[1].Text = CapNhatLoaiHangText.Text;
                                Check = true;
                                MessageBox.Show("Đã cập nhật thành công", "Thông Báo");
                                break;
                            }
                        }
                        if (Check == false)
                        {
                            MessageBox.Show("Không tìm thấy Loại Hàng để cập nhật", "Thông Báo");
                        }
                        CapNhatLoaiHangText.Text = "";
                        TKChinhSuaText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập nội dung cập nhật", "Thông Báo");
                    }
                } 
            }
            
        }
        //Phần chức năng chuyển sang Phần Mặt Hàng
        private void phanmathangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
