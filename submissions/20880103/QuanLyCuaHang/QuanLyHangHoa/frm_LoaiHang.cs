using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class frm_LoaiHang : Form
    {
        public static LOAIHANG[] DSLoaiHang = XL_Hang.TaoLoaiHang();
        public frm_LoaiHang()
        {
            InitializeComponent();
        }
        private DataTable CreateDataTable(LOAIHANG[] DSDisplay)
        {
            DataTable dataTable = new DataTable();
            // create columns
            dataTable.Columns.Add("Mã Loại Hàng");
            dataTable.Columns.Add("Tên Loại Hàng");

            for (int j = 0; j < DSDisplay.Length; j++)
            {
                // create a DataRow using .NewRow()
                DataRow row = dataTable.NewRow();

                // iterate over all columns to fill the row
                row[0] = DSDisplay[j].maLoaiHang;
                row[1] = DSDisplay[j].tenLoaiHang;

                // add the current row to the DataTable
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        private void DisplayData(LOAIHANG[] DSDisplay)
        {
            DataTable dt = CreateDataTable(DSDisplay);
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
        private void frm_LoaiHang_Load(object sender, EventArgs e)
        {
            DisplayData(DSLoaiHang);

            dataGridView1.Columns[0].HeaderText = "Mã Loại Hàng";
            dataGridView1.Columns[1].HeaderText = "Tên Loại Hàng";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Th_MaLoaiHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            Th_TenLoaiHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
        }
        private void ClearData()
        {
            Th_MaLoaiHang.Text = "";
            Th_TenLoaiHang.Text = "";
        }
        private void NhapLai_Click(object sender, EventArgs e)
        {
            label_KetQua.Text = "";
            ClearData();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            ClearData();
            label_KetQua.Text = "";

            if (MaLH_Search.Checked && SearchBox.Text.Trim() != "")
            {
                string chuoiTim = SearchBox.Text.Trim();
                Tim_Request.Text = "";

                int count = 0;
                for (int i = 0; i < DSLoaiHang.Length; i++)
                {
                    if (DSLoaiHang[i].maLoaiHang.ToLower().Contains(chuoiTim.ToLower()))
                    {
                        count += 1;
                    }
                }

                if (count == 0)
                {
                    Tim_Request.Text = "Không tìm thấy kết quả phù hợp";
                    LOAIHANG[] DSTimKiem = new LOAIHANG[count];
                    DisplayData(DSTimKiem);
                }
                else
                {
                    Tim_Request.Text = $"Có {count} kết quả phù hợp";
                    LOAIHANG[] DSTimKiem = new LOAIHANG[count];
                    int j = 0;
                    for (int i = 0; i < DSLoaiHang.Length; i++)
                    {
                        if (DSLoaiHang[i].maLoaiHang.ToLower().Contains(chuoiTim.ToLower()))
                        {
                            DSTimKiem[j] = DSLoaiHang[i];
                            j++;
                        }
                    }

                    DisplayData(DSTimKiem);
                    ClearData();
                }
            }
            else if (TenLH_Search.Checked && SearchBox.Text.Trim() != "")
            {
                Tim_Request.Text = "";
                string chuoiTim = SearchBox.Text.Trim();
                Tim_Request.Text = "";

                int count = 0;
                for (int i = 0; i < DSLoaiHang.Length; i++)
                {
                    if (DSLoaiHang[i].tenLoaiHang.ToLower().Contains(chuoiTim.ToLower()))
                    {
                        count += 1;
                    }
                }

                if (count == 0)
                {
                    Tim_Request.Text = "Không tìm thấy kết quả phù hợp";
                }
                else
                {
                    Tim_Request.Text = $"Có {count} kết quả phù hợp";
                    LOAIHANG[] DSTimKiem = new LOAIHANG[count];
                    int j = 0;
                    for (int i = 0; i < DSLoaiHang.Length; i++)
                    {
                        if (DSLoaiHang[i].tenLoaiHang.ToLower().Contains(chuoiTim.ToLower()))
                        {
                            DSTimKiem[j] = DSLoaiHang[i];
                            j++;
                        }
                    }
                    DisplayData(DSTimKiem);
                }
            }
            else if (!MaLH_Search.Checked && !TenLH_Search.Checked)
            {
                Tim_Request.Text = "Vui lòng cho biết bạn muốn tìm theo Mã Loại Hàng hay Tên Loại Hàng";
            }
            else if (SearchBox.Text == "")
            {
                Tim_Request.Text = "Vui lòng nhập thông tin loại hàng bạn muốn tìm";
            }
        }

        private void Tim_Refresh_Click(object sender, EventArgs e)
        {
            Tim_Request.Text = "";
            SearchBox.Text = "";
            DisplayData(DSLoaiHang);
        }
        private void Them_Click(object sender, EventArgs e)
        {
            string maLoaiHang = Th_MaLoaiHang.Text.Trim();
            int viTriLoaiHang = XL_Hang.TraCuuMaLoaiHang(DSLoaiHang, maLoaiHang);
            if (viTriLoaiHang == -1)
            {
                if (maLoaiHang != "" && Th_TenLoaiHang.Text.Trim() != "")
                {
                    LOAIHANG[] newDSLoaiHang = new LOAIHANG[DSLoaiHang.Length + 1];
                    for (int i = 0, j = 0; i < newDSLoaiHang.Length - 1; i++, j++)
                    {
                        newDSLoaiHang[i] = DSLoaiHang[j];
                    }

                    LOAIHANG loaiHang = new LOAIHANG(maLoaiHang, Th_TenLoaiHang.Text.Trim());

                    newDSLoaiHang[DSLoaiHang.Length] = loaiHang;
                    // overwrite the old array with the new one
                    DSLoaiHang = newDSLoaiHang;

                    label_KetQua.Text = "Thêm thành công!";
                    DisplayData(DSLoaiHang);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống thông tin");
                }
            }
            else
            {
                label_KetQua.Text = "Loại hàng đã tồn tại trong hệ thống!";
            }
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            string maLoaiHang = Th_MaLoaiHang.Text.Trim();
            int viTriLoaiHang = XL_Hang.TraCuuMaLoaiHang(DSLoaiHang, maLoaiHang);
            if (viTriLoaiHang != -1)
            {
                if (maLoaiHang != "" && Th_TenLoaiHang.Text.Trim() != "")
                {
                    LOAIHANG loaiHang = new LOAIHANG(maLoaiHang, Th_TenLoaiHang.Text);
                    DSLoaiHang[viTriLoaiHang] = loaiHang;
                    label_KetQua.Text = "Cập nhật thành công!";
                    DisplayData(DSLoaiHang);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống thông tin");
                }
            }
            else
            {
                label_KetQua.Text = "Loại hàng không tồn tại trong hệ thống!";
            }
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa loại hàng này sẽ xóa các mặt hàng thuộc loại hàng này. Bạn có chắc chắn muốn xóa loại hàng này?", 
                "Xóa loại hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string maLoaiHang = Convert.ToString(row.Cells[0].Value);
                    int viTriLoaiHang = XL_Hang.TraCuuMaLoaiHang(DSLoaiHang, maLoaiHang);
                    if (viTriLoaiHang != -1)
                    {
                        LOAIHANG[] newDSLoaiHang = new LOAIHANG[DSLoaiHang.Length - 1];
                        for (int i = 0, j = 0; i < newDSLoaiHang.Length; i++, j++)
                        {
                            if (i == viTriLoaiHang)
                            {
                                j++;
                            }
                            newDSLoaiHang[i] = DSLoaiHang[j];
                        }
                        // overwrite the old array with the new one
                        DSLoaiHang = newDSLoaiHang;

                        // Xóa các mặt hàng trong loại hàng
                        for (int i = 0; i < frm_MatHang.DSMatHang.Length; i++)
                        {
                            if (frm_MatHang.DSMatHang[i].loaiHang == maLoaiHang)
                            {
                                frm_MatHang.DSMatHang = XL_Hang.XoaMatHang(frm_MatHang.DSMatHang, i);
                                i--;
                            }
                        }
                    }
                    else
                    {
                        label_KetQua.Text = "Loại hàng không tồn tại trong hệ thống!";
                        break;
                    }
                }

                label_KetQua.Text = "Xóa thành công!";
                DisplayData(DSLoaiHang);
                ClearData();
            }
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm TrangChu = new MainForm();
            TrangChu.Show();
        }

        private void frm_LoaiHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainForm TrangChu = new MainForm();
            TrangChu.Show();
        }
    }
}
