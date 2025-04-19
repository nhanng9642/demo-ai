using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNMLT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Phần lock và unlock.
        public void LockLoaiHang()
        {
            btnLHThemLH.Enabled = true;
            btnLHSuaLH.Enabled = true;
            btnLHXoaLH.Enabled = true; 
            btnLHLuu.Enabled = false;
            btnLHHuy.Enabled = false;

            txtLHLoaiHang.ReadOnly = true;
        }
        public void UnLockLoaiHang()
        {
            btnLHThemLH.Enabled = false;
            btnLHSuaLH.Enabled = false;
            btnLHXoaLH.Enabled = false;
            btnLHLuu.Enabled = true;
            btnLHHuy.Enabled = true;

            txtLHLoaiHang.ReadOnly = false;
            txtLHLoaiHang.Focus();
        }

        public void LockMatHang()
        {
            btnMHThemMH.Enabled = true;
            btnMHSuaMH.Enabled = true;
            btnMHXoaMH.Enabled = true;
            btnMHLuu.Enabled = false;
            btnMHHuy.Enabled = false;
            
            txtMHMaMH.ReadOnly = true;
            txtMHTenMH.ReadOnly = true;
            txtMHTenCty.ReadOnly = true;
            txtMHNamSX.ReadOnly = true;
        }
        public void UnLockMatHang()
        {
            btnMHThemMH.Enabled = false;
            btnMHSuaMH.Enabled = false;
            btnMHXoaMH.Enabled = false;
            btnMHLuu.Enabled = true;
            btnMHHuy.Enabled = true;

            txtMHMaMH.ReadOnly = false;
            txtMHTenMH.ReadOnly = false;
            txtMHTenCty.ReadOnly = false;
            txtMHNamSX.ReadOnly = false;

            txtMHMaMH.Focus();
        }
        //Tạo flag
        string flag;
        //Tạo datatable cho phần loại hàng.
        public DataTable createTable1()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("LHLoaihang");
            return dt1;
        }
        public DataTable FindLoaiHang()
        {
            DataTable f1 = new DataTable();
            f1.Columns.Add("LHLoaihang");
            return f1;
        }

        DataTable dtLH;
        DataTable FindLH;

        //Vị trí con trỏ ở dataGridView loại hàng.
        int indexLH;

        // checkdata loại hàng và kiểm tra trùng lắp loại hàng khi thêm.
        public bool checkdataLH()
        {
            if (txtLHLoaiHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLHLoaiHang.Focus();
                return false;
            }
            return true;
        }
        public bool checkTrungLapLH()
        {
            for (int i = 0; i < dataGridViewLoaiHang.Rows.Count - 1; i ++)
            {
                if (txtLHLoaiHang.Text == dataGridViewLoaiHang[0,i].Value.ToString())
                {
                    MessageBox.Show("Loại hàng bạn vừa nhập đã có trong bảng. Vui lòng nhập một Loại hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLHLoaiHang.Focus();
                    return true;
                }
            }
            return false;
        }

        //Phần Loại Hàng.
        private void btnLHTimKiem_Click(object sender, EventArgs e)
        {
            UnLockLoaiHang();
            btnLHHuyTimKiem.Enabled = true; 
            dataGridViewLoaiHang.DataSource = dtLH;
            FindLH.Rows.Clear();
            for (int i = 0; i < dataGridViewLoaiHang.Rows.Count -1; i ++)
            {
                if (txtLHTimKiemLH.Text == dataGridViewLoaiHang[0,i].Value.ToString())
                {
                    FindLH.Rows.Add(txtLHTimKiemLH.Text);
                    dataGridViewLoaiHang.DataSource = FindLH;
                }
                else
                {
                    FindLH.Rows.Clear();
                    dataGridViewLoaiHang.DataSource = dtLH;
                    dataGridViewLoaiHang.RefreshEdit();
                }
            }
            txtLHTimKiemLH.Text = "";
        }

        private void btnLHHuyTimKiem_Click(object sender, EventArgs e)
        {
            LockLoaiHang();
            btnLHHuyTimKiem.Enabled = false;
            txtLHTimKiemLH.Text = "";
            dataGridViewLoaiHang.DataSource = dtLH;
            dataGridViewLoaiHang.RefreshEdit();
            FindLH.Rows.Clear();          
        }
        private void btnLHThemLH_Click(object sender, EventArgs e)
        {
            UnLockLoaiHang();
            flag = "addLH";

            txtLHLoaiHang.Text = "";
        }

        private void btnLHSuaLH_Click(object sender, EventArgs e)
        {
            UnLockLoaiHang();
            flag = "editLH";
            if (KTDuLieu() == true)
            {
                MessageBox.Show("Bạn không thể Sửa tên Loại hàng vì Loại hàng này đang được sử dụng để lưu thông tin Mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LockLoaiHang();
            }
            txtLHLoaiHang.Text = "";
        }

        //Kiểm tra xem Loại hàng muốn Sửa hay Xóa có đang được sử dụng để lưu thông tin Mặt hàng hay không.
        public bool KTDuLieu()
        {
            bool dangSuDung = false; 
            for (int i = 0; i < dataGridViewMatHang.Rows.Count - 1; i++)
            {
                if (dtLH.Rows[indexLH][0] == dataGridViewMatHang[3,i].Value)
                {                   
                    dangSuDung = true;
                    break;
                }
            }
            return dangSuDung;
        }

        private void btnLHXoaLH_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoaiHang.DataSource != null && dataGridViewLoaiHang.Rows.Count > 0)
            {
                if (indexLH != -1)
                {
                    if (KTDuLieu() == true)
                    {
                        MessageBox.Show("Bạn không thể Xóa tên Loại hàng vì Loại hàng này đang được sử dụng để lưu thông tin Mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        dataGridViewLoaiHang.Rows.RemoveAt(indexLH);
                    }
                }
            }
            LockLoaiHang();
        }
        private void btnLHLuu_Click(object sender, EventArgs e)
        {
            if (flag == "addLH")
            {
                if (checkdataLH() == true)
                {
                    if (checkTrungLapLH() == false)
                    {
                        dtLH.Rows.Add(txtLHLoaiHang.Text);
                        dataGridViewLoaiHang.DataSource = dtLH;
                        dataGridViewLoaiHang.RefreshEdit();
                    }
                }
            }
            if (flag == "editLH")
            {
                if (dataGridViewLoaiHang.CurrentRow != null)
                {
                    if (checkdataLH() == true)
                    {
                        if (checkTrungLapLH() == false)
                        {
                            dtLH.Rows[indexLH][0] = txtLHLoaiHang.Text;
                            dataGridViewLoaiHang.DataSource = dtLH;
                            dataGridViewLoaiHang.RefreshEdit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không thể Sửa Loại hàng khi chưa Thêm Loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LockLoaiHang();
        }
        private void btnLHHuy_Click(object sender, EventArgs e)
        {
            txtLHLoaiHang.Text = "";
            LockLoaiHang();
        }

        // checkdata mặt hàng và kiểm tra trùng lắp mặt hàng khi thêm.
        public bool checkTrungLapMH()
        {
            for (int i = 0; i < dataGridViewMatHang.Rows.Count - 1; i++)
            {
                if (txtMHMaMH.Text == dataGridViewMatHang[0, i].Value.ToString())
                {
                    MessageBox.Show("Mã mặt hàng bạn vừa nhập đã có trong bảng. Vui lòng nhập một Mã mặt hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMHMaMH.Focus();
                    return true;
                }
            }
            return false;
        }
        public bool checkdataMH()
        {
            if (txtMHMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHMaMH.Focus();
                return false;
            }
            if (txtMHTenMH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHTenMH.Focus();
                return false;
            }
            if (txtMHTenCty.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHTenCty.Focus();
                return false;
            }
            if (comboBoxLoaiHang.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Loại hàng. Vui lòng thêm Loại hàng trước khi nhập thông tin Mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxLoaiHang.Focus();
                return false;
            }
            if (txtMHNamSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Năm sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHNamSX.Focus();
                return false;
            }           

            return true;
        }
      
        //Tạo datatable cho phần mặt hàng.
        public DataTable createTable2()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Mamathang");
            dt2.Columns.Add("Tenmathang");
            dt2.Columns.Add("Tencongty");
            dt2.Columns.Add("Loaihang");
            dt2.Columns.Add("Hansudung");
            dt2.Columns.Add("Namsanxuat");
            return dt2;
        }

        public DataTable FindMatHang()
        {
            DataTable f2 = new DataTable();
            f2.Columns.Add("Mamathang");
            f2.Columns.Add("Tenmathang");
            f2.Columns.Add("Tencongty");
            f2.Columns.Add("Loaihang");
            f2.Columns.Add("Hansudung");
            f2.Columns.Add("Namsanxuat");
            return f2;
        }

        DataTable dtMH;
        DataTable FindMH;

        //Vị trí con trỏ ở dataGridView mặt hàng.
        int indexMH;

        //Phần Mặt Hàng.

        //Yêu cầu Năm sản xuất được nhập phải là số.
        private void txtMHNamSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Năm sản xuất phải ở dạng số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHNamSX.Focus();   
            }
        }

        private void btnMHTimKiemMaMH_Click(object sender, EventArgs e)
        {
            UnLockMatHang();
            btnMHHuyTimKiem.Enabled = true; 
            dataGridViewMatHang.DataSource = dtMH;
            FindMH.Rows.Clear();
            for (int i = 0; i < dataGridViewMatHang.Rows.Count - 1; i++)
            {
                if (txtTKMaMH.Text == dataGridViewMatHang[0, i].Value.ToString())
                {
                    FindMH.Rows.Add(dataGridViewMatHang[0, i].Value,
                        dataGridViewMatHang[1, i].Value,
                        dataGridViewMatHang[2, i].Value,
                        dataGridViewMatHang[3, i].Value,
                        dataGridViewMatHang[4, i].Value,
                        dataGridViewMatHang[5, i].Value);
                    dataGridViewMatHang.DataSource = FindMH;
                    dataGridViewMatHang.RefreshEdit();
                    break;
                }
                else
                {
                    FindMH.Rows.Clear();
                    dataGridViewMatHang.DataSource = dtMH;
                    dataGridViewMatHang.RefreshEdit();
                }
            }
        }

        private void btnMHHuyTimKiem_Click(object sender, EventArgs e)
        {
            LockMatHang();
            btnMHHuyTimKiem.Enabled = false;
            txtTKMaMH.Text = "";
            dataGridViewMatHang.DataSource = dtMH;
            dataGridViewMatHang.RefreshEdit();
            FindMH.Rows.Clear();

        }
        private void btnMHThemMH_Click(object sender, EventArgs e)
        {
            UnLockMatHang();
            if (dataGridViewLoaiHang.CurrentCell == null)
            {
                LockMatHang();
                MessageBox.Show("Bạn phải thêm Loại hàng trước khi Thêm Mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            flag = "addMH";

            txtMHMaMH.Text = "";
            txtMHTenMH.Text = "";
            txtMHTenCty.Text = "";
            comboBoxLoaiHang.SelectedIndex = -1;
            txtMHNamSX.Text = "";

        }

        private void btnMHXoaMH_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatHang.CurrentCell != null && dataGridViewMatHang.Rows.Count > 0)
            {
                if (indexMH != -1)
                {
                    dataGridViewMatHang.Rows.RemoveAt(indexMH);
                }
            }
            LockMatHang();
        }

        private void btnMHSuaMH_Click(object sender, EventArgs e)
        {
            UnLockMatHang();
            if (dataGridViewMatHang.DataSource == null && dataGridViewLoaiHang.DataSource == null)
            {
                LockMatHang();
                MessageBox.Show("Bạn phải thêm Mặt hàng trước khi Sửa Mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            flag = "editMH";

        }
        private void btnMHLuu_Click(object sender, EventArgs e)
        {
            if (flag == "addMH")
            {
                if (checkTrungLapMH() == false)
                {
                    if (checkdataMH() == true)
                    {
                        dtMH.Rows.Add(txtMHMaMH.Text, txtMHTenMH.Text, txtMHTenCty.Text,
                            comboBoxLoaiHang.Items[comboBoxLoaiHang.SelectedIndex].ToString(),
                            DateTimePickerHanSD.Value.ToString(),txtMHNamSX.Text);
                        dataGridViewMatHang.DataSource = dtMH;
                        dataGridViewMatHang.RefreshEdit();
                        txtMHNamSX.Text = "";
                        LockMatHang();
                    }
                }
            }
            if (flag == "editMH")
            {
                if (checkdataMH() == true)
                {
                    for (int i = 0; i < dataGridViewMatHang.Rows.Count - 1; i++)
                    {
                        if (txtMHMaMH.Text == dataGridViewMatHang[0, i].Value.ToString() && txtMHMaMH.Text != dtMH.Rows[indexMH][0].ToString())
                        {
                            txtMHMaMH.Text = "";
                            txtMHMaMH.Focus();
                            MessageBox.Show("Mã mặt hàng mà bạn vừa nhập trùng với Mã mặt hàng đang có trong danh sách. Vui lòng nhập lại Mã mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    dtMH.Rows[indexMH][0] = txtMHMaMH.Text;
                    dtMH.Rows[indexMH][1] = txtMHTenMH.Text;
                    dtMH.Rows[indexMH][2] = txtMHTenCty.Text;
                    dtMH.Rows[indexMH][3] = comboBoxLoaiHang.Items[comboBoxLoaiHang.SelectedIndex].ToString();
                    dtMH.Rows[indexMH][4] = DateTimePickerHanSD.Value.ToString();
                    dtMH.Rows[indexMH][5] = txtMHNamSX.Text;
                    dataGridViewMatHang.DataSource = dtMH;
                    dataGridViewMatHang.RefreshEdit();
                    LockMatHang();
                }
            }
        }

        private void btnMHHuy_Click(object sender, EventArgs e)
        {
            txtMHMaMH.Text = "";
            txtMHTenMH.Text = "";
            txtMHTenCty.Text = "";
            comboBoxLoaiHang.SelectedIndex = -1;
            txtMHNamSX.Text = "";
            LockMatHang();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LockLoaiHang();
            LockMatHang();

            dtLH = createTable1();
            FindLH = FindLoaiHang();

            dtMH = createTable2();
            FindMH = FindMatHang();

            btnLHHuyTimKiem.Enabled = false;
            btnMHHuyTimKiem.Enabled = false;
        }
        private void dataGridViewLoaiHang_SelectionChanged(object sender, EventArgs e)
        {
            indexLH = dataGridViewLoaiHang.CurrentCell == null ? -1 : dataGridViewLoaiHang.CurrentCell.RowIndex;
            DataTable dtLH = (DataTable)dataGridViewLoaiHang.DataSource;
            if (indexLH != -1)
            {
                txtLHLoaiHang.Text = dataGridViewLoaiHang.Rows[indexLH].Cells[0].Value.ToString();
            }
        }

        private void comboBoxLoaiHang_DropDown(object sender, EventArgs e)
        {
            comboBoxLoaiHang.Items.Clear();
            for (int i = 0; i < dataGridViewLoaiHang.Rows.Count - 1; i++)
            {
                comboBoxLoaiHang.Items.Add(dataGridViewLoaiHang.Rows[i].Cells[0].Value);
            }
        }

        private void dataGridViewMatHang_SelectionChanged(object sender, EventArgs e)
        {          
            indexMH = dataGridViewMatHang.CurrentRow == null ? -1 : dataGridViewMatHang.CurrentCell.RowIndex;
            DataTable dtMH = (DataTable)dataGridViewMatHang.DataSource;
            if (indexMH != -1)
            {
                txtMHMaMH.Text = dataGridViewMatHang.Rows[indexMH].Cells[0].Value.ToString();
                txtMHTenMH.Text = dataGridViewMatHang.Rows[indexMH].Cells[1].Value.ToString();
                txtMHTenCty.Text = dataGridViewMatHang.Rows[indexMH].Cells[2].Value.ToString();
                txtMHNamSX.Text = dataGridViewMatHang.Rows[indexMH].Cells[5].Value.ToString();
            }
        } 
    }
}



