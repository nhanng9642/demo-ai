using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhapMonLapTrinh
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        List<HangHoa> listHangHoa = new List<HangHoa>();
        List<LoaiHang> dsLoaiHang = new List<LoaiHang>();
        string selectedTenHang;
        string selectedLoaiHang;
        

        struct HangHoa
        {
            public string maHang;
            public string tenHang;
            public string hanDung;
            public string ctySanXuat;
            public string namSanXuat;
            public string loaiHang;
        }
        struct LoaiHang 
        {
            public string tenLoaiHang;
        }

        //hàm xóa text hàng
        public void clearTextNhapHang()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtHanDung.Text = "";
            txtCtySX.Text = "";
            txtNamSX.Text = "";
            txtLoaiHang.Text = "";
        }

        // hàm xóa text sau khi nhập
        public void clearText(TextBox textb)
        {
            textb.Text = "";
        }

        // hàm cập nhật lại list view sau khi thêm, xóa, sửa
        private void LoadLvHangHoa(List<HangHoa> listhh, List<LoaiHang> listlh) 
        {
            lvHangHoa.Items.Clear();
            lvLoaiHang.Items.Clear();



            for (int i = 0; i < listhh.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = listHangHoa.ElementAt(i).maHang;
                item.SubItems.Add(listHangHoa.ElementAt(i).tenHang);
                item.SubItems.Add(listHangHoa.ElementAt(i).hanDung);
                item.SubItems.Add(listHangHoa.ElementAt(i).ctySanXuat);
                item.SubItems.Add(listHangHoa.ElementAt(i).namSanXuat);
                item.SubItems.Add(listHangHoa.ElementAt(i).loaiHang);

                lvHangHoa.Items.Add(item);
            }

            for (int i = 0; i < listlh.Count; i++)
            {

                ListViewItem item = new ListViewItem();
                item.Text = dsLoaiHang.ElementAt(i).tenLoaiHang;

                lvLoaiHang.Items.Add(item);
            }
        }

        // hàm thêm hàng
        private void ThemHang(HangHoa hang)
         {
             listHangHoa.Add(hang);

             LoaiHang loaiHang;
             loaiHang.tenLoaiHang = hang.loaiHang;

             if(dsLoaiHang.Count == 0) 
             {
                dsLoaiHang.Add(loaiHang);
            }
            else
            {
                for (int i = 0; i < dsLoaiHang.Count; i++)
                {
                    if (dsLoaiHang.ElementAt(i).tenLoaiHang.Equals(hang.loaiHang))
                    {
                        break;
                    }
                    else
                    {
                        if(i == dsLoaiHang.Count - 1)
                        {
                            dsLoaiHang.Add(loaiHang);
                        }
                    }
                }
            }
             
             LoadLvHangHoa(listHangHoa, dsLoaiHang);
             
         }

        // hàm sửa Hàng
        private void SuaHang(HangHoa hang,int position)
        {
            listHangHoa.Insert(position,hang);
            LoaiHang loaiHang;
            loaiHang.tenLoaiHang = hang.loaiHang;
            

            for (int i = 0; i < dsLoaiHang.Count; i++)
            {
                if (dsLoaiHang.ElementAt(i).tenLoaiHang.Equals(hang.loaiHang))
                {
                    break;
                }
                else
                {
                    if (i == dsLoaiHang.Count - 1)
                    {
                        dsLoaiHang.Add(loaiHang);
                        break;
                    }
                }
            }


            LoadLvHangHoa(listHangHoa, dsLoaiHang);
        }

        // hàm tìm kiếm hàng
        private void searchHang(string key,List<HangHoa> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).tenHang.Equals(key))
                {
                    selectedTenHang = key;
                    txtMaHang.Text = list.ElementAt(i).maHang;
                    txtTenHang.Text = list.ElementAt(i).tenHang;
                    txtHanDung.Text = list.ElementAt(i).hanDung;
                    txtCtySX.Text = list.ElementAt(i).ctySanXuat;
                    txtNamSX.Text = list.ElementAt(i).namSanXuat;
                    txtLoaiHang.Text = list.ElementAt(i).loaiHang;

                    btAddHang.Enabled = false;
                    btDeleteHang.Enabled = true;
                    btUpdateHang.Enabled = true;
                    btSearchHang.Enabled = false;
                    break;
                }

                if (i == list.Count - 1)
                {
                    MessageBox.Show("Không tìm thấy tên hàng hóa này");
                }

            }
        }

        // hàm xóa hàng được tìm kiếm
        private void deleteHang(string key, List<HangHoa> list)
        {
            foreach (HangHoa hh in list)
            {
                if (hh.tenHang.Equals(key))
                {
                    listHangHoa.Remove(hh);

                    LoadLvHangHoa(listHangHoa, dsLoaiHang);

                    btAddHang.Enabled = true;
                    btDeleteHang.Enabled = false;
                    btUpdateHang.Enabled = false;
                    btSearchHang.Enabled = true;
                    break;
                }
            }
        }

        // hàm cập nhật hàng sau khi sửa
        private void updateHang(string key, List<HangHoa> list)
        {
            foreach (HangHoa hh in list)
            {
                if (hh.tenHang.Equals(key))
                {
                    int postion = list.IndexOf(hh);
                    listHangHoa.Remove(hh);
                    HangHoa hangSua;
                    hangSua.maHang = txtMaHang.Text;
                    hangSua.tenHang = txtTenHang.Text;
                    hangSua.hanDung = txtHanDung.Text;
                    hangSua.ctySanXuat = txtCtySX.Text;
                    hangSua.namSanXuat = txtNamSX.Text;
                    hangSua.loaiHang = txtLoaiHang.Text;

                    SuaHang(hangSua, postion);


                    btAddHang.Enabled = true;
                    btDeleteHang.Enabled = false;
                    btUpdateHang.Enabled = false;
                    btSearchHang.Enabled = true;
                    break;
                }
            }
        }

        // hàm thêm loại hàng
        private void ThemLoaiHang(LoaiHang loaihang)
        {
                        
            if (dsLoaiHang.Count == 0)
            {
                dsLoaiHang.Add(loaihang);
            }
            else
            {
                for (int i = 0; i < dsLoaiHang.Count; i++)
                {
                    if (dsLoaiHang.ElementAt(i).tenLoaiHang.Equals(loaihang.tenLoaiHang))
                    {
                        break;
                    }
                    else
                    {
                        if (i == dsLoaiHang.Count - 1)
                        {
                            dsLoaiHang.Add(loaihang);
                        }
                    }
                }
            }

            LoadLvHangHoa(listHangHoa, dsLoaiHang);

        }

        //hàm tìm kiếm loại hàng
        private void searchLoaiHang(string key, List<LoaiHang> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).tenLoaiHang.Equals(key))
                {
                    selectedLoaiHang = key;
                    textLoaiHang.Text = list.ElementAt(i).tenLoaiHang;

                    btAddLoaiHang.Enabled = false;
                    btDeleteLoaiHang.Enabled = true;
                    btUpdateLoaiHang.Enabled = true;
                    btSearchLoaiHang.Enabled = false;
                    break;
                }

                if(i == list.Count - 1)
                {
                    MessageBox.Show("Không tìm thấy loại hàng này");
                }
            }
        }

        //hàm xóa loại hàng
        private void deleteLoaiHang(string key, List<LoaiHang> list)
        {
            foreach (LoaiHang lh in list)
            {
                if (lh.tenLoaiHang.Equals(key))
                {
                    dsLoaiHang.Remove(lh);

                    LoadLvHangHoa(listHangHoa, dsLoaiHang);

                    btAddLoaiHang.Enabled = true;
                    btDeleteLoaiHang.Enabled = false;
                    btUpdateLoaiHang.Enabled = false;
                    btSearchLoaiHang.Enabled = true;
                    break;
                }
            }
        }

        //hàm sửa loại hàng
        private void SuaLoaiHang(LoaiHang loaihang, int position)
        {
                        
            for (int i = 0; i < dsLoaiHang.Count; i++)
            {
                if (dsLoaiHang.ElementAt(i).tenLoaiHang.Equals(loaihang.tenLoaiHang))
                {
                    break;
                }
                if (i == dsLoaiHang.Count - 1)
                {
                    dsLoaiHang.Insert(position, loaihang);
                    break;
                }
            }


            LoadLvHangHoa(listHangHoa, dsLoaiHang);
        }

        // hàm cập nhật loại hàng sau khi sửa
        private void updateLoaiHang(string key, List<LoaiHang> list)
        {
            foreach (LoaiHang lh in list)
            {
                if (lh.tenLoaiHang.Equals(key))
                {
                    
                    int postion = list.IndexOf(lh);
                    dsLoaiHang.Remove(lh);
                    LoaiHang loaihangSua;
                    loaihangSua.tenLoaiHang = textLoaiHang.Text;

                    SuaLoaiHang(loaihangSua, postion);


                    btAddLoaiHang.Enabled = true;
                    btDeleteLoaiHang.Enabled = false;
                    btUpdateLoaiHang.Enabled = false;
                    btSearchLoaiHang.Enabled = true;
                    break;
                }
            }
        }

        //hàm xửa lý khi bấm thêm hàng
        private void button1_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string tenHang = txtTenHang.Text;
            string hanDung = txtHanDung.Text;
            string ctySX = txtCtySX.Text;
            string namSX = txtNamSX.Text;
            string loaiHang = txtLoaiHang.Text;

            HangHoa hang;
            hang.maHang = maHang;
            hang.tenHang = tenHang;
            hang.hanDung = hanDung;
            hang.ctySanXuat = ctySX;
            hang.namSanXuat = namSX;
            hang.loaiHang = loaiHang;

            ThemHang(hang);
            clearTextNhapHang();
        }

        // ko sử dụng
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //hàm load màn hình chính
        private void Main_Load(object sender, EventArgs e)
        {
          
            btUpdateHang.Enabled = false;
            btDeleteHang.Enabled = false;
            btUpdateLoaiHang.Enabled = false;
            btDeleteLoaiHang.Enabled = false;
        }

        //hàm xử lý khi bấm sửa loại hàng
        private void button8_Click(object sender, EventArgs e)
        {
            updateLoaiHang(selectedLoaiHang, dsLoaiHang);
            clearText(textLoaiHang);
        }

        // hàm xử lý khi bấm xóa hàng
        private void btDeleteHang_Click(object sender, EventArgs e)
        {
            deleteHang(selectedTenHang, listHangHoa);
            clearTextNhapHang();
        }

        // hàm xử lý khi bấm sửa hàng
        private void btUpdateHang_Click(object sender, EventArgs e)
        {
            updateHang(selectedTenHang, listHangHoa);
            clearTextNhapHang();
        }

        // hàm xử lý khi bấm tìm kiếm hàng
        private void btSearchHang_Click(object sender, EventArgs e)
        {

            string keyHangHoa = tkHangHoa.Text;
            if (listHangHoa.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tên hàng hóa này");
            }

            searchHang(keyHangHoa, listHangHoa);
            clearText(tkHangHoa);

        }

        // hàm xử lý khi bấm thêm loại hàng
        private void btAddLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHang addLoaiHang;
            addLoaiHang.tenLoaiHang = textLoaiHang.Text;
            ThemLoaiHang(addLoaiHang);
            clearText(textLoaiHang);
        }

        // hàm xử lý khi bấm xóa loại hàng
        private void btDeleteLoaiHang_Click(object sender, EventArgs e)
        {
            deleteLoaiHang(selectedLoaiHang, dsLoaiHang);
            clearText(textLoaiHang);
        }

        // hàm xử lý khi bấm tìm kiếm loại hàng
        private void btSearchLoaiHang_Click(object sender, EventArgs e)
        {
            string keyLoaiHang = tkLoaiHang.Text;
            if (dsLoaiHang.Count == 0)
            {
                MessageBox.Show("Không tìm thấy loại hàng này");
            }

            searchLoaiHang(keyLoaiHang, dsLoaiHang);
            
            clearText(tkLoaiHang);
        }

        // không sử dụng
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
