using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnPMQLCH_20810019
{
    public partial class Form1 : Form
    {
        List<TenHang> lstTH;
        enum FormEditState { Them, Sua }
        FormEditState fES;
        public Form1()
        {
            InitializeComponent();
            lstTH = new List<TenHang>();
            dataGridView1.Rows.Add("MOBI01", "LG V50 ThinQ 5G", "LG Mobile Global", "Android Smartphone", "2019", null);
            dataGridView1.Rows.Add("MOBI02", "Sony Xperia 1 Mark II", "Sony Mobile", "Android Smartphone", "2020", null);
            dataGridView1.Rows.Add("MACBOO01", "MacBook Air 13 2020", "Apple Inc", "Laptop Mac", "2020", null);
            dataGridView1.Rows.Add("FLYC01", "DJI Mavic Pro 2 Flymore Combo", "DJI Technology Co., Ltd", "Drone", "2018", null);
            dataGridView1.Rows.Add("CAMR01", "Sony a7R Mark IV (ILCE-7RM4)", "Sony Alpha Corp", "Interchangeable Lens Digital Camera", "2019", null);
            dataGridView1.Rows.Add("LENS01", "Carl Zeiss Vario-Tessar T* FE 16-35mm F4 ZA OSS (SEL1635Z)", "Carl Zeiss Optics", "Camera Lens", "2015", null);
            dataGridView1.Rows.Add("ACTCAM01", "GoPro Hero 9 Black", "GoPro Inc", "Action Camera", "2020", null);
            dataGridView1.Rows.Add("CAMACCE01", "DJI Ronin-SC", "DJI Technology Co., Ltd", "Camera Gimbal", "2019", null);
            dataGridView1.Rows.Add("CAMACCE02", "MicroSDXC Samsung EVO Plus UHS-I U3 128GB 100MB/s MB-MC128H", "Samsung Inc", "Memory Card", "2018", null);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            ChangeButtonState(true);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var cr = dataGridView1 == null ? null : dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;

            bool allowchanged = !(btnOK.Enabled && btnOK.Visible);
            if (rowIndex >= 0 && allowchanged)
            {
                txtMaHH.Text = dataGridView1[0, rowIndex].Value?.ToString();
                txtTenHH.Text = dataGridView1[1, rowIndex].Value?.ToString();
                txtCty.Text = dataGridView1[2, rowIndex].Value?.ToString();
                txtLH.Text = dataGridView1[3, rowIndex].Value?.ToString();
                txtNSX.Text = dataGridView1[4, rowIndex].Value?.ToString();
                txtHSD.Text = dataGridView1[5, rowIndex].Value?.ToString();
            }
        }
        private void ResetTextBox()
        {
            txtMaHH.Text = string.Empty;
            txtTenHH.Text = string.Empty;
            txtCty.Text = string.Empty;
            txtLH.Text = string.Empty;
            txtNSX.Text = string.Empty;
            txtHSD.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Them;
            ResetTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Sua;
            dataGridView1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Rất tiếc! Không thể thực hiện thao tác xoá nữa!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
            dataGridView1.Enabled = true;
        }

        private void ChangeButtonState(bool check)
        {
            btnThoat.Enabled = check;
            btnSua.Enabled = check;
            btnXoa.Enabled = check;
            btnThem.Enabled = check;
            btnHuy.Visible = !check;
            btnOK.Visible = !check;
            btnSearch.Enabled = check;

            txtMaHH.ReadOnly = check;
            txtTenHH.ReadOnly = check;
            txtCty.ReadOnly = check;
            txtLH.ReadOnly = check;
            txtNSX.ReadOnly = check;
            txtHSD.ReadOnly = check;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime nsx;
            DateTime hsd;
            string nsxString = string.Empty;
            string hsdString = string.Empty;

            if (!string.IsNullOrWhiteSpace(txtNSX.Text))
            {
                bool check = DateTime.TryParse(txtNSX.Text, out nsx);
                if (check)
                    nsxString = nsx.ToString("d");
            }

            if (!string.IsNullOrWhiteSpace(txtHSD.Text))
            {
                bool check = DateTime.TryParse(txtHSD.Text, out hsd);
                if (check)
                    hsdString = hsd.ToString("d");
            }
            if (fES == FormEditState.Them)
            {
                dataGridView1.Rows.Add(txtMaHH.Text, txtTenHH.Text, txtCty.Text, txtLH.Text, nsxString, hsdString);
            }
            if (fES == FormEditState.Sua)
            {
                var row = dataGridView1.CurrentRow;
                row.Cells[0].Value = txtMaHH.Text;
                row.Cells[1].Value = txtTenHH.Text;
                row.Cells[2].Value = txtCty.Text;
                row.Cells[3].Value = txtLH.Text;
                row.Cells[4].Value = nsxString;
                row.Cells[5].Value = hsdString;
            }
            dataGridView1.Enabled = true;
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            var count = dataGridView1.Rows.Count;
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã loại hàng. Xin vui lòng nhập Mã loại hàng cần tìm tương ứng!");
                return;
            }
            if (dataGridView1.AllowUserToAddRows == true)
            {
                count -= 1;
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
