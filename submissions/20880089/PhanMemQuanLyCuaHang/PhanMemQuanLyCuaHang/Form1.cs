using System;
using System.Windows.Forms;

namespace PhanMemQuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            chkBoxLoaiHang.Checked = true;
        }
        private void XoaToanBoTxtNhap()
        {
            txtMa.Text      = "";
            txtTenhang.Text = "";
            // Khỏi xóa date Hạn dùng
            txtCtySX.Text   = "";
            txtNamSX.Text   = "";
            cbxLoaiHang.Text  = "" ;     //txtLoaihang.Text  = "";
            txtSoluong.Text   = "";
            txtDongia.Text    = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text !="" && txtTenhang.Text !="" && dateTimePicker_HanDung_KhoH.Value.ToString() != "" && txtCtySX.Text !="" && cbxLoaiHang.Text !="" && 
                txtNamSX.Text !="" && txtSoluong.Text !="" && txtDongia.Text != "")
            {
                try
                {
                    int soluong = Convert.ToInt32(txtSoluong.Text);
                    try
                    {
                        int dongia = Convert.ToInt32(txtDongia.Text);
                        dataGridViewKhohang.Rows.Add(
                            txtMa.Text, // Mã hàng
                            txtTenhang.Text, // Tên hàng
                            dateTimePicker_HanDung_KhoH.Value.ToString(),// Ngày hết hạn dùng
                            txtCtySX.Text,    // Tên công ty
                            txtNamSX.Text,    // Năm sản suất
                            cbxLoaiHang.Text,  //txtLoaihang.Text, 
                            txtSoluong.Text, 
                            txtDongia.Text
                            );
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nhập sai dữ liệu Đơn giá");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu Số lượng");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTenhang.Text != "" && dateTimePicker_HanDung_KhoH.Value.ToString() != "" && txtCtySX.Text != "" && cbxLoaiHang.Text != "" &&
                txtNamSX.Text != "" && txtSoluong.Text != "" && txtDongia.Text != "")
            {
                MATHANG h;
                int vitri = dataGridViewKhohang.CurrentCell.RowIndex;

                h.Ma = txtMa.Text;
                h.TenHang = txtTenhang.Text;
                h.HanDung = Convert.ToDateTime(dateTimePicker_HanDung_KhoH.Text);
                h.CtySX = txtCtySX.Text;
                h.NamSX = txtNamSX.Text;
                h.LoaiHang = cbxLoaiHang.Text;

                dataGridViewKhohang[0, vitri].Value = h.Ma;
                dataGridViewKhohang[1, vitri].Value = h.TenHang;
                dataGridViewKhohang[2, vitri].Value = h.HanDung;
                dataGridViewKhohang[3, vitri].Value = h.CtySX;
                dataGridViewKhohang[4, vitri].Value = h.NamSX;
                dataGridViewKhohang[5, vitri].Value = h.LoaiHang;
                try
                {
                    h.SoLuong = Convert.ToInt32(txtSoluong.Text);
                    dataGridViewKhohang[6, vitri].Value = h.SoLuong;
                    try
                    {
                        h.DonGia = Convert.ToInt32(txtDongia.Text);

                        dataGridViewKhohang[7, vitri].Value = h.DonGia;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nhập sai dữ liệu Đơn Giá");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai dữ liệu Số Lượng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
                   
                                                
        }
        public struct MATHANG
        {
            public string Ma;
            public string TenHang;
            public DateTime HanDung;
            public string CtySX;
            public string NamSX;
            public string LoaiHang;
            public int SoLuong;
            public int DonGia;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vitri = dataGridViewKhohang.CurrentCell.RowIndex;
            if(MessageBox.Show("Bạn có thật sự muốn xóa","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
            {
                dataGridViewKhohang.Rows.RemoveAt(vitri);
            }
        }

        private void dataGridViewKhohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewKhohang.SelectedCells.Count != 0)
            {
               
                    DataGridViewRow row = dataGridViewKhohang.Rows[dataGridViewKhohang.CurrentCell.RowIndex];
                    txtMa.Text       = row.Cells[0].Value.ToString();
                    txtTenhang.Text  = row.Cells[1].Value.ToString();
                    dateTimePicker_HanDung_KhoH.Text  = row.Cells[2].Value.ToString();
                    txtCtySX.Text    = row.Cells[3].Value.ToString();
                    txtNamSX.Text    = row.Cells[4].Value.ToString();
                    cbxLoaiHang.Text = row.Cells[5].Value.ToString();
                    txtSoluong.Text  = row.Cells[6].Value.ToString();
                    txtDongia.Text   = row.Cells[7].Value.ToString();
                
            }
        }
        private void dataGridViewKhohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKhohang.SelectedCells.Count != 0)
            {
                
                    DataGridViewRow row = dataGridViewKhohang.Rows[dataGridViewKhohang.CurrentCell.RowIndex];
                    txtMa.Text       = row.Cells[0].Value.ToString();
                    txtTenhang.Text  = row.Cells[1].Value.ToString();
                    dateTimePicker_HanDung_KhoH.Text = row.Cells[2].Value.ToString();
                    txtCtySX.Text    = row.Cells[3].Value.ToString();
                    txtNamSX.Text    = row.Cells[4].Value.ToString();
                    cbxLoaiHang.Text = row.Cells[5].Value.ToString();
                    txtSoluong.Text  = row.Cells[6].Value.ToString();
                    txtDongia.Text   = row.Cells[7].Value.ToString();
               
                
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaToanBoTxtNhap();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnXoaTimKiem.Enabled = true;

            if (chkBoxMa.Checked)  // Tìm theo mã hàng
                for(int i=0; i<dataGridViewKhohang.Rows.Count; i++)
                {
                    if (dataGridViewKhohang[0, i].Value.ToString() == txtTimMa.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value, 
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value, 
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value  );
                    }
                }
            else if (chkBoxTenhang.Checked) // Tìm theo Tên hàng
            {
                for (int i = 0; i < dataGridViewKhohang.Rows.Count; i++)
                {
                    if (dataGridViewKhohang[1, i].Value.ToString() == txtTimTenHang.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value,
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value,
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value);
                    }
                }

            }
            else if (chkBoxHanDung.Checked) // Tìm theo Hạn dùng
            {
                for (int i = 0; i < dataGridViewKhohang.Rows.Count; i++)
                {
                    if(Convert.ToDateTime(dataGridViewKhohang[2, i].Value) >=Convert.ToDateTime(dateTimePicker_TimTu.Value)
                        && Convert.ToDateTime(dataGridViewKhohang[2, i].Value) <= Convert.ToDateTime(dateTimePickerTimDen.Value))
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value,
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value,
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value);
                    }
                }

            }
            else if (chkBoxCty.Checked) // Tìm theo Công ty sản xuất
            {
                for (int i = 0; i < dataGridViewKhohang.Rows.Count; i++)
                {
                    if (dataGridViewKhohang[3, i].Value.ToString() == txtTimCty.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value,
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value,
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value);
                    }
                }

            }
            else if (chkBoxNamSX.Checked)  // Tìm theo năm sản xuất
            {
                for (int i = 0; i < dataGridViewKhohang.Rows.Count; i++)
                {
                    if (dataGridViewKhohang[4, i].Value.ToString() == txtTimNamSX.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value,
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value,
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value);
                    }
                }

            }
            else if (chkBoxLoaiHang.Checked)  // Tìm theo loại hàng
            {
                for (int i = 0; i < dataGridViewKhohang.Rows.Count; i++)
                {
                    if (dataGridViewKhohang[5, i].Value.ToString() == txtTimLoaiHang.Text)
                    {
                        dataGridViewTimKiem.Rows.Add(
                            dataGridViewKhohang[0, i].Value, dataGridViewKhohang[1, i].Value,
                            dataGridViewKhohang[2, i].Value, dataGridViewKhohang[3, i].Value,
                            dataGridViewKhohang[4, i].Value, dataGridViewKhohang[5, i].Value,
                            dataGridViewKhohang[6, i].Value, dataGridViewKhohang[7, i].Value);
                    }
                }
            }
            // Ngoài ra còn Tổ hợp chọn nhiều Loại tìm kiếm cùng lúc, nhưng ở đây  6 loại chọn nên triển khai sẽ rất dài
            // --> triển khai mẫu  2 loại Chọn theo Mã hàng và Ngày bán ở Tab Liệt kê hàng bán
                    
        }

        private void btnXoaTimKiem_Click(object sender, EventArgs e)
        {
            dataGridViewTimKiem.Rows.Clear();
                
        }

        private void dataGridViewTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaTimKiem.Enabled = true;
        }

        private void btnXuatBan_Click(object sender, EventArgs e)
        {
            if(txtMahangBan.Text !="" && txtSoluongBan.Text !="" && txtGiaBan.Text !="")
            {
                try
                {
                    int SoLuongBan = Convert.ToInt32(txtSoluongBan.Text);
                    try
                    {
                        int GiaBan = Convert.ToInt32(txtGiaBan.Text);
                        for (int i=0; i <dataGridViewKhohang.Rows.Count; i++)
                        { 
                            // Có hàng trong kho
                            if (dataGridViewKhohang[0,i].Value.ToString()==txtMahangBan.Text)
                            {
                                // Số lượng hàng còn trong Kho >= số lượng bán
                                if (Convert.ToInt32(dataGridViewKhohang[6, i].Value.ToString()) - Convert.ToInt32(txtSoluongBan.Text) >= 0)
                                {
                                    int GiaGoc = Convert.ToInt32(dataGridViewKhohang[7, i].Value.ToString());
                                    int GiaB = Convert.ToInt32(txtGiaBan.Text);
                                    int TienLai = (GiaB - GiaGoc) * Convert.ToInt32(txtSoluongBan.Text);

                                    dataGridViewXuatBan.Rows.Add(dataGridViewKhohang[0, i].Value, // Cột 0, mã hàng
                                                                    dataGridViewKhohang[1, i].Value,  // Cột 1, tên hàng
                                                                    txtSoluongBan.Text, // Cột 2
                                                                    dataGridViewKhohang[7, i].Value, // Đơn giá
                                                                    txtGiaBan.Text,            
                                                                    TienLai,
                                                                    dateTimePicker_NgayBan_XB.Text   // Ngày bán
                                                                    );

                                    dataGridViewKhohang[6, i].Value = Convert.ToInt32(dataGridViewKhohang[6, i].Value.ToString()) - Convert.ToInt32(txtSoluongBan.Text);// cập nhật lại số lượng trong kho
                                }
                                else
                                {
                                    MessageBox.Show("Số lượng trong kho không đủ, chỉ còn: " + dataGridViewKhohang[6, i].Value.ToString()+ " sản phẩm");
                                }

                            }
                            
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nhập sai Giá bán");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai số lượng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng Nhập đủ thông tin Mã hàng, Số lượng và Giá bán");
            }
        }

        private void btnTimTonKho_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapTimKiem_Again_Click(object sender, EventArgs e)
        {
            
            // Xóa check các check box
            chkBoxMa.Checked       = false;            
            chkBoxTenhang.Checked  = false;
            chkBoxHanDung.Checked  = false;
            chkBoxCty.Checked      = false;
            chkBoxNamSX.Checked    = false;
            chkBoxLoaiHang.Checked = false;

            // Xóa trắng các text box
            txtTimMa.Text      = "";
            txtTimTenHang.Text = "";
            // khỏi xóa hạng dùng
            txtTimCty.Text     = "";
            txtTimNamSX.Text   = "";
            txtTimLoaiHang.Text = "";

        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            if(txtTimMa.Text != "")
            {
                chkBoxMa.Checked = true;
            }
            else
            {
                chkBoxMa.Checked = false;
            }
        }

        private void txtTimTenHang_TextChanged(object sender, EventArgs e)
        {
            if(txtTimTenHang.Text != "")
            {
                chkBoxTenhang.Checked = true;
            }
            else
            {
                chkBoxTenhang.Checked = false;
            }
        }


        private void txtTimCty_TextChanged(object sender, EventArgs e)
        {
            chkBoxCty.Checked = true;
        }

        private void txtTimNamSX_TextChanged(object sender, EventArgs e)
        {
            chkBoxNamSX.Checked = true;
        }

        private void btnLietKeHangBan_Click(object sender, EventArgs e)
        {
            
            if (chkBoxMaHangBan_LK.Checked && chkBox_NgayBan_LK.Checked==false)
            {
                dataGridViewHangBan_LK.Rows.Clear();
                
                for (int i=0; i<dataGridViewXuatBan.Rows.Count; i++)
                {
                    if(dataGridViewXuatBan[0, i].Value.ToString() == txtMaHangLKBan.Text   ) 
                    {
                        dataGridViewHangBan_LK.Rows.Add(
                            dataGridViewXuatBan[0, i].Value,
                            dataGridViewXuatBan[1, i].Value,
                            dataGridViewXuatBan[2, i].Value,
                            dataGridViewXuatBan[3, i].Value,
                            dataGridViewXuatBan[4, i].Value,
                            dataGridViewXuatBan[5, i].Value,
                            dataGridViewXuatBan[6, i].Value
                            );
                        
                    }
                }
            }
            else if (chkBoxMaHangBan_LK.Checked==false && chkBox_NgayBan_LK.Checked)
            {
                dataGridViewHangBan_LK.Rows.Clear();
                for (int i = 0; i < dataGridViewXuatBan.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dataGridViewXuatBan[6, i].Value) >= Convert.ToDateTime(dateTimePicker_BanTuNgay_LK.Value)
                        && Convert.ToDateTime(dataGridViewXuatBan[6, i].Value) <= Convert.ToDateTime(dateTimePickerBanDenNgay_LK.Value)) 
                    {
                        dataGridViewHangBan_LK.Rows.Add(
                            dataGridViewXuatBan[0, i].Value,
                            dataGridViewXuatBan[1, i].Value,
                            dataGridViewXuatBan[2, i].Value,
                            dataGridViewXuatBan[3, i].Value,
                            dataGridViewXuatBan[4, i].Value,
                            dataGridViewXuatBan[5, i].Value,
                            dataGridViewXuatBan[6, i].Value
                            );
                        
                    }
                }
            }
            else if (chkBoxMaHangBan_LK.Checked && chkBox_NgayBan_LK.Checked)
            {
                dataGridViewHangBan_LK.Rows.Clear();
                for (int i = 0; i < dataGridViewXuatBan.Rows.Count; i++)
                {
                    if ((dataGridViewXuatBan[0, i].Value.ToString() == txtMaHangLKBan.Text) 
                        && (Convert.ToDateTime(dataGridViewXuatBan[6, i].Value) >= Convert.ToDateTime(dateTimePicker_BanTuNgay_LK.Value))
                        && (Convert.ToDateTime(dataGridViewXuatBan[6, i].Value) <= Convert.ToDateTime(dateTimePickerBanDenNgay_LK.Value)))
                    {
                        dataGridViewHangBan_LK.Rows.Add(
                            dataGridViewXuatBan[0, i].Value,
                            dataGridViewXuatBan[1, i].Value,
                            dataGridViewXuatBan[2, i].Value,
                            dataGridViewXuatBan[3, i].Value,
                            dataGridViewXuatBan[4, i].Value,
                            dataGridViewXuatBan[5, i].Value,
                            dataGridViewXuatBan[6, i].Value
                            );
                        
                    }
                }
            }
            
        }

        private void txtTimLoaiHang_TextChanged(object sender, EventArgs e)
        {
            chkBoxLoaiHang.Checked = true;
        }

        private void btn_Xoa_BangLK_Click(object sender, EventArgs e)
        {
            dataGridViewHangBan_LK.Rows.Clear();
        }
    }
}
