using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class formChinh : Form
    {
        public formChinh()
        {
            InitializeComponent();
            themDuLieuMau();
        }
        void themDuLieuMau()
        {
            loaiHang.Add(new LOAIHANG("Thực phẩm đông lạnh"));
            loaiHang.Add(new LOAIHANG("Hải sản tươi sống"));
            loaiHang.Add(new LOAIHANG("Đồ may mặc"));

            loaiHang[0].matHang.Add(new MATHANG("Dl20", "Khoai tây cọng", "3", "THSH", 2019));
            loaiHang[0].matHang.Add(new MATHANG("TS19", "Cà rốt thái nhỏ", "6", "Tifan hải dương", 2020));
            loaiHang[0].matHang.Add(new MATHANG("NNG", "Rau củ chiên cơm HH", "6", "Tifan hải dương", 2020));
            loaiHang[1].matHang.Add(new MATHANG("kgb", "Cá trabas", "3", "Maxwell vietnam", 2019));
            loaiHang[1].matHang.Add(new MATHANG("TS19", "Cá ngừ đại dương", "6", "Hakong inc", 2019));
            loaiHang[1].matHang.Add(new MATHANG("pias", "Thịt heo móng cái", "6", "Hakong inc", 2020));
            loaiHang[2].matHang.Add(new MATHANG("vcn11", "Quần jean", "3", "B&G INC", 2018));
            loaiHang[2].matHang.Add(new MATHANG("vcn12", "Quần bò", "6", "B&G INC", 2017));
            loaiHang[2].matHang.Add(new MATHANG("kgt09", "Áo phông", "6", "Cty may Hải Nam", 2017));


            updateCbLoaiHang();
            showAllToListview();
        }


        List<LOAIHANG> loaiHang = new List<LOAIHANG>();

        private void btThemMatHang_Click(object sender, EventArgs e)
        {
            if (loaiHang.Count == 0)
            {
                MessageBox.Show("Chưa có loại hàng nào, bạn hãy thêm loại hàng");
                return;
            }
            int loaiHangSelectedIndex = cbLoaiHang.SelectedIndex;
            if (loaiHangSelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn loại hàng, bạn hãy chọn lại loại hàng");
                return;
            }

            loaiHang[loaiHangSelectedIndex].matHang.Add(new MATHANG(tbID.Text, tbTenMatHang.Text, tbHanDung.Text, tbCtySanXuat.Text, int.Parse(dtpNamSanXuat.Text)));
            int cont = loaiHang[loaiHangSelectedIndex].matHang.Count - 1;
            //ListViewItem item = new ListViewItem(loaiHang[loaiHangSelectedIndex].matHang[cont].ID);
            //item.SubItems.Add(loaiHang[loaiHangSelectedIndex].matHang[cont].tenHang);
            //item.SubItems.Add(loaiHang[loaiHangSelectedIndex].matHang[cont].hanDung);
            //item.SubItems.Add(loaiHang[loaiHangSelectedIndex].matHang[cont].ctySanXuat);
            //item.SubItems.Add(loaiHang[loaiHangSelectedIndex].matHang[cont].namSanXuat.ToString());
            //item.SubItems.Add(loaiHang[loaiHangSelectedIndex].tenLoaiHang);
            //lvPanelHienThi.Items.Add(item);
            showAllToListview();
        }

        private void btThemLoaiHang_Click(object sender, EventArgs e)
        {
            if (tbTenLoaiHang.Text == "")
            {
                MessageBox.Show("Hãy điền tên vào ô \"Tên loại hàng\" rỗi hẳn bấm nút thêm");
            }
            string tenLoaiHang = tbTenLoaiHang.Text;
            loaiHang.Add(new LOAIHANG(tenLoaiHang));

            updateCbLoaiHang();
        }

        void updateCbLoaiHang()
        {
            cbLoaiHang.Items.Clear();
            cbLoaiHang2.Items.Clear();
            cbCSLoaiHang.Items.Clear();
            foreach (LOAIHANG item in loaiHang)
            {
                cbLoaiHang.Items.Add(item.tenLoaiHang);
                cbLoaiHang2.Items.Add(item.tenLoaiHang);
                cbCSLoaiHang.Items.Add(item.tenLoaiHang);
            }
        }

        void showAllToListview()
        {
            lvPanelHienThi.Items.Clear();
            foreach (LOAIHANG itemLoaiHang in loaiHang)
            {
                foreach (MATHANG itemMatHang in itemLoaiHang.matHang)
                {
                    ListViewItem item = new ListViewItem(itemMatHang.ID);
                    item.SubItems.Add(itemMatHang.tenHang);
                    item.SubItems.Add(itemMatHang.hanDung);
                    item.SubItems.Add(itemMatHang.ctySanXuat);
                    item.SubItems.Add(itemMatHang.namSanXuat.ToString());
                    item.SubItems.Add(itemLoaiHang.tenLoaiHang);
                    lvPanelHienThi.Items.Add(item);
                }
            }
            displayListView = 0;
        }

        void showMatHang(int loaiHangIndex)
        {
            lvPanelHienThi.Items.Clear();
            foreach (MATHANG itemMatHang in loaiHang[loaiHangIndex].matHang)
            {
                ListViewItem item = new ListViewItem(itemMatHang.ID);
                item.SubItems.Add(itemMatHang.tenHang);
                item.SubItems.Add(itemMatHang.hanDung);
                item.SubItems.Add(itemMatHang.ctySanXuat);
                item.SubItems.Add(itemMatHang.namSanXuat.ToString());
                item.SubItems.Add(loaiHang[loaiHangIndex].tenLoaiHang);
                lvPanelHienThi.Items.Add(item);
            }
        }

        private void btSuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (cbCSLoaiHang.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn loại hàng trong box trên");
                return;
            }
            loaiHang[cbCSLoaiHang.SelectedIndex].tenLoaiHang = tbCSTenLoaiHang.Text;
            
            updateCbLoaiHang();
            showAllToListview();
        }

        private void btXoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (cbCSLoaiHang.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn loại hàng trong box \"Tên loại hàng\"");
                return;
            }
            loaiHang.RemoveAt(cbCSLoaiHang.SelectedIndex);
            updateCbLoaiHang();
            showAllToListview();
        }

        private void btTimKiemLoaiHang_Click(object sender, EventArgs e)
        {
            if (cbCSLoaiHang.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn loại hàng trong box \"Tên loại hàng\"");
                return;
            }
            showMatHang(cbCSLoaiHang.SelectedIndex);
        }

        private void btHienThiAll_Click(object sender, EventArgs e)
        {
            showAllToListview();
        }


        int displayListView = 0;
        int loaiHangSelectedIndex = -1, matHangSelectedIndex = -1;

        private void btChinhSuaMatHang_Click(object sender, EventArgs e)
        {
            if (loaiHangSelectedIndex == -1 && matHangSelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn lại mặt hàng ở bảng rồi chĩnh sữa");
                return;
            }

            MATHANG matHangSelected = loaiHang[loaiHangSelectedIndex].matHang[matHangSelectedIndex];
            matHangSelected.ID = tbCsID.Text;
            matHangSelected.tenHang = tbCsTenMatHang.Text;
            matHangSelected.hanDung = tbCsHanDung.Text;
            matHangSelected.ctySanXuat = tbCsCtySanXuat.Text;
            matHangSelected.namSanXuat = (int)(nudCsNamSanXuat.Value);
            //cbLoaiHang2.SelectedIndex = loaiHangSelectedIndex;

            //loaiHang[loaiHangSelectedIndex].matHang[matHangSelectedIndex] = new MATHANG();
            loaiHang[loaiHangSelectedIndex].matHang.RemoveAt(matHangSelectedIndex);
            loaiHang[cbLoaiHang2.SelectedIndex].matHang.Insert(loaiHang[cbLoaiHang2.SelectedIndex].matHang.Count, matHangSelected);
            loaiHangSelectedIndex = -1;
            matHangSelectedIndex = -1;
            showAllToListview();
        }

        private void btTimKiemMatHang_Click(object sender, EventArgs e)
        { 
            if (tbCsTenMatHang.Text != "")
            {
                lvPanelHienThi.Items.Clear();
                List<MATHANG> matHangDaTimThay = new List<MATHANG>();

                int slMatHangTimDuoc = 0;
                foreach (LOAIHANG itemLoaiHang in loaiHang)
                {
                    foreach (MATHANG itemMatHang in itemLoaiHang.matHang)
                    {
                        if (itemMatHang.tenHang == tbCsTenMatHang.Text)
                        {
                            ListViewItem item = new ListViewItem(itemMatHang.ID);
                            item.SubItems.Add(itemMatHang.tenHang);
                            item.SubItems.Add(itemMatHang.hanDung);
                            item.SubItems.Add(itemMatHang.ctySanXuat);
                            item.SubItems.Add(itemMatHang.namSanXuat.ToString());
                            item.SubItems.Add(itemLoaiHang.tenLoaiHang);
                            lvPanelHienThi.Items.Add(item);
                            slMatHangTimDuoc++;
                        }
                    }
                }
                if (slMatHangTimDuoc == 0)
                {
                    MessageBox.Show("Không tìm thấy tên mặt hàng trong danh sách dữ liệu");
                }
                displayListView = 1;
            }
            else 
            {
                MessageBox.Show("Hãy nhập tên và thử lại");
            }
        }

        private void btXoaMatHang_Click(object sender, EventArgs e)
        {
            if (loaiHangSelectedIndex == -1 && matHangSelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn lại mặt hàng ở bảng rồi \"chĩnh sữa\" hoặc \"xóa\"");
                return;
            }
            loaiHang[loaiHangSelectedIndex].matHang.RemoveAt(matHangSelectedIndex);
            loaiHangSelectedIndex = -1;
            matHangSelectedIndex = -1;
            showAllToListview();
        }

        private void lvPanelHienThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = lvPanelHienThi.SelectedItems[0].Index;

                switch (displayListView)
                {
                    case 0: // trưởng hợp tìm index khi listview hiển thị toàn bộ thông tin 
                        int findedIndex = 0;
                        for (int i = 0; i < loaiHang.Count(); i++)
                        {
                            findedIndex += loaiHang[i].matHang.Count();
                            if (findedIndex > index && i == 0)
                            {
                                loaiHangSelectedIndex = 0;
                                matHangSelectedIndex = index;
                                break;
                            }
                            if (findedIndex > index)
                            {
                                loaiHangSelectedIndex = i;
                                findedIndex -= loaiHang[i].matHang.Count();
                                matHangSelectedIndex = index - findedIndex;
                                break;
                            }
                        }
                        break;
                }
                
            
                MATHANG matHangSelected = loaiHang[loaiHangSelectedIndex].matHang[matHangSelectedIndex];
                tbCsID.Text = matHangSelected.ID;
                tbCsTenMatHang.Text = matHangSelected.tenHang;
                tbCsHanDung.Text = matHangSelected.hanDung;
                tbCsCtySanXuat.Text = matHangSelected.ctySanXuat;
                nudCsNamSanXuat.Value = matHangSelected.namSanXuat;
                cbLoaiHang2.SelectedIndex = loaiHangSelectedIndex;

            } catch (Exception ex) { }

        }
    }
}
