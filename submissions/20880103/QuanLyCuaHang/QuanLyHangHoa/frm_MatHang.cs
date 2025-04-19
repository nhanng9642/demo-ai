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
    
    public partial class frm_MatHang : Form
    {
        LOAIHANG[] DSLoaiHang;
        public static MATHANG[] DSMatHang = XL_Hang.TaoMatHang();
        public frm_MatHang()
        {
            DSLoaiHang = frm_LoaiHang.DSLoaiHang;
            InitializeComponent();
        }
        private DataTable CreateDataTable(MATHANG[] DSDisplay, LOAIHANG[] DSLoaiHang)
        {
            DataTable dataTable = new DataTable();
            // create columns
            dataTable.Columns.Add("Mã Hàng");
            dataTable.Columns.Add("Tên Hàng");
            dataTable.Columns.Add("Hạn Sử Dụng");
            dataTable.Columns.Add("Công Ty Sản Xuất");
            dataTable.Columns.Add("Năm Sản Xuất");
            dataTable.Columns.Add("Loại Hàng");

            for (int j = 0; j < DSDisplay.Length; j++)
            {
                // create a DataRow using .NewRow()
                DataRow row = dataTable.NewRow();

                // iterate over all columns to fill the row
                row[0] = DSDisplay[j].maHang;
                row[1] = DSDisplay[j].tenHang;
                row[2] = DSDisplay[j].hanSD.ToString("yyyy-MM-dd");
                row[3] = DSDisplay[j].cTySX;
                row[4] = DSDisplay[j].namSX;
                row[5] = XL_Hang.TraCuuTenLoaiHang(DSLoaiHang, DSDisplay[j].loaiHang);

                // add the current row to the DataTable
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        private void DisplayData(MATHANG[] DSDisplay, LOAIHANG[] DSLoaiHang)
        {
            DataTable dt = CreateDataTable(DSDisplay, DSLoaiHang);
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dataGridView1.DataSource = dt;
            Display_LoaiHang_Combo.DataSource = DSLoaiHang;
        }
        private void frm_MatHang_Load(object sender, EventArgs e)
        {
            DisplayData(DSMatHang, DSLoaiHang);

            Display_LoaiHang_Combo.DisplayMember = "TenLoaiHang";
            Display_LoaiHang_Combo.ValueMember = "MaLoaiHang";

            ClearData();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Display_MaHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            Display_TenHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            Display_HSD.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            Display_CTSX.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            Display_NamSX.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            Display_LoaiHang_Combo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
        }
        private void ClearData()
        {
            Display_MaHang.Text = "";
            Display_TenHang.Text = "";
            Display_HSD.Text = "";
            Display_CTSX.Text = "";
            Display_NamSX.Text = "";
            Display_LoaiHang_Combo.SelectedItem = null;
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            label_KetQua.Text = "";
            ClearData();
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này?", "Xóa mặt hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string maHang = Convert.ToString(row.Cells[0].Value);
                    int viTriHang = XL_Hang.TraCuuMaHang(DSMatHang, maHang);
                    if (viTriHang != -1)
                    {
                        DSMatHang = XL_Hang.XoaMatHang(DSMatHang, viTriHang);
                    }
                    else
                    {
                        label_KetQua.Text = "Mặt hàng không tồn tại trong hệ thống!";
                        break;
                    }
                }

                label_KetQua.Text = "Xóa thành công!";
                DisplayData(DSMatHang, DSLoaiHang);
                ClearData();
            }
        }
        private int KT_DinhDangNgay(string value)
        {
            string[] format = new string[] { "yyyy-mm-dd" };
            DateTime datetime;

            if (DateTime.TryParseExact(value, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out datetime)
                && DateTime.TryParse(value, out datetime))
                return 1;
            else if (!DateTime.TryParseExact(value, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out datetime))
                return -1;
            else if (!DateTime.TryParse(value, out datetime))
                return -2;
            else
                return 0;
        }

        private short KT_NamSX(string NamSX, string HanSD)
        {
            short NamHanSD = Convert.ToInt16(HanSD.Substring(0,4));
            short namSX = Convert.ToInt16(NamSX);
            if (namSX <= NamHanSD)
                return namSX;
            else
                return -1;
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            string maHang = Display_MaHang.Text.Trim();
            int viTriHang = XL_Hang.TraCuuMaHang(DSMatHang, maHang);
            if (viTriHang != -1)
            {
                string hanSD = Display_HSD.Text.Trim();
                string namSX = Display_NamSX.Text.Trim();
                if (maHang!= "" && Display_TenHang.Text.Trim() != "" 
                    && hanSD != "" && KT_DinhDangNgay(hanSD) == 1 
                    && Display_CTSX.Text.Trim() != ""
                    && namSX != "" && KT_NamSX(namSX, hanSD) != -1
                    && Display_LoaiHang_Combo.Text.Trim() != "")
                {
                    MATHANG matHang = new MATHANG(maHang,
                        Display_TenHang.Text.Trim(),
                        DateTime.Parse(Display_HSD.Text.Trim()),
                        Display_CTSX.Text.Trim(),
                        Convert.ToInt16(Display_NamSX.Text.Trim()),
                        XL_Hang.TenLH_MaLH_Mapping(DSLoaiHang, Display_LoaiHang_Combo.Text.Trim()));

                    DSMatHang[viTriHang] = matHang;

                    label_KetQua.Text = "Cập nhật thành công!";
                    DisplayData(DSMatHang, DSLoaiHang);
                    ClearData();
                }
                else if (hanSD != "" && KT_DinhDangNgay(hanSD) == -1)
                {
                    MessageBox.Show("Hạn sử dụng không đúng định dạng yyyy-MM-dd");
                }
                else if (hanSD != "" && KT_DinhDangNgay(hanSD) == -2)
                {
                    MessageBox.Show("Hạn sử dụng không phải ngày hợp lệ");
                }
                else if (hanSD != "" && namSX != "" && KT_NamSX(namSX, hanSD) == -1)
                {
                    MessageBox.Show("Năm sản xuất phải trước hạn sử dụng");
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống thông tin");
                }
            }
            else
            {
                label_KetQua.Text = "Mặt hàng không tồn tại trong hệ thống!";
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            string maHang = Display_MaHang.Text.Trim();
            int viTriHang = XL_Hang.TraCuuMaHang(DSMatHang, maHang);
            if (viTriHang == -1)
            {
                string hanSD = Display_HSD.Text.Trim();
                string namSX = Display_NamSX.Text.Trim();
                if (maHang != "" && Display_TenHang.Text.Trim() != ""
                    && hanSD != "" && KT_DinhDangNgay(hanSD) == 1
                    && Display_CTSX.Text.Trim() != ""
                    && namSX != "" && KT_NamSX(namSX, hanSD) != -1
                    && Display_LoaiHang_Combo.Text.Trim() != "")
                {
                    MATHANG[] newDSMatHang = new MATHANG[DSMatHang.Length + 1];
                    for (int i = 0, j = 0; i < newDSMatHang.Length - 1; i++, j++)
                    {
                        newDSMatHang[i] = DSMatHang[j];
                    }

                    MATHANG matHang = new MATHANG(maHang,
                        Display_TenHang.Text.Trim(),
                        DateTime.Parse(Display_HSD.Text.Trim()),
                        Display_CTSX.Text.Trim(),
                        Convert.ToInt16(Display_NamSX.Text.Trim()),
                        XL_Hang.TenLH_MaLH_Mapping(DSLoaiHang, Display_LoaiHang_Combo.Text));

                    newDSMatHang[DSMatHang.Length] = matHang;
                    // overwrite the old array with the new one
                    DSMatHang = newDSMatHang;

                    label_KetQua.Text = "Thêm thành công!";
                    DisplayData(DSMatHang, DSLoaiHang);
                    ClearData();
                }
                else if (hanSD != "" && KT_DinhDangNgay(hanSD) == -1)
                {
                    MessageBox.Show("Hạn sử dụng không đúng định dạng yyyy-MM-dd");
                }
                else if (hanSD != "" && KT_DinhDangNgay(hanSD) == -2)
                {
                    MessageBox.Show("Hạn sử dụng không phải ngày hợp lệ");
                }
                else if (hanSD != "" && namSX != "" && KT_NamSX(namSX, hanSD) == -1)
                {
                    MessageBox.Show("Năm sản xuất phải trước hạn sử dụng");
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống thông tin");
                }
            }
            else
            {
                label_KetQua.Text = "Mặt hàng đã tồn tại trong hệ thống!";
            }
        }
        private void Tim_Click(object sender, EventArgs e)
        {
            label_KetQua.Text = "";

            if (TimTheoMaHang.Checked && MH_SearchBox.Text.Trim() != "")
            {
                string chuoiTim = MH_SearchBox.Text.Trim();
                Tim_Request.Text = "";

                int count = 0;
                for (int i = 0; i < DSMatHang.Length; i++)
                {
                    if (DSMatHang[i].maHang.ToLower().Contains(chuoiTim.ToLower()))
                    {
                        count += 1;
                    }
                }

                if (count == 0)
                {
                    Tim_Request.Text = "Không tìm thấy kết quả phù hợp";
                    MATHANG[] DSTimKiem = new MATHANG[count];
                    DisplayData(DSTimKiem, DSLoaiHang);
                }
                else
                {
                    Tim_Request.Text = $"Có {count} kết quả phù hợp";
                    MATHANG[] DSTimKiem = new MATHANG[count];
                    int j = 0;
                    for (int i = 0; i < DSMatHang.Length; i++)
                    {
                        if (DSMatHang[i].maHang.ToLower().Contains(chuoiTim.ToLower()))
                        {
                            DSTimKiem[j] = DSMatHang[i];
                            j++;
                        }
                    }

                    DisplayData(DSTimKiem, DSLoaiHang);
                }
            }
            else if (TimTheoTenHang.Checked && MH_SearchBox.Text.Trim() != "")
            {
                Tim_Request.Text = "";
                string chuoiTim = MH_SearchBox.Text.Trim();

                int count = 0;
                for (int i = 0; i < DSMatHang.Length; i++)
                {
                    if (DSMatHang[i].tenHang.ToLower().Contains(chuoiTim.ToLower()))
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
                    MATHANG[] DSTimKiem = new MATHANG[count];
                    int j = 0;
                    for (int i = 0; i < DSMatHang.Length; i++)
                    {
                        if (DSMatHang[i].tenHang.ToLower().Contains(chuoiTim.ToLower()))
                        {
                            DSTimKiem[j] = DSMatHang[i];
                            j++;
                        }
                    }
                    DisplayData(DSTimKiem, DSLoaiHang);
                }
            }
            else if (!TimTheoMaHang.Checked && !TimTheoMaHang.Checked)
            {
                Tim_Request.Text = "Vui lòng cho biết bạn muốn tìm theo Mã Hàng hay Tên Hàng";
            }
            else if (MH_SearchBox.Text == "")
            {
                Tim_Request.Text = "Vui lòng nhập thông tin mặt hàng bạn muốn tìm";
            }
        }
        private void XoaTimKiem_Click(object sender, EventArgs e)
        {
            Tim_Request.Text = "";
            MH_SearchBox.Text = "";
            DisplayData(DSMatHang, DSLoaiHang);
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm TrangChu = new MainForm();
            TrangChu.Show();
        }

        private void frm_MatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainForm TrangChu = new MainForm();
            TrangChu.Show();
        }
    }
}
