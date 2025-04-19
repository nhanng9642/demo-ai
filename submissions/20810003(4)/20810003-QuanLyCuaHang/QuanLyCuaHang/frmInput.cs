/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmInput : Form
    {
        public frmInput()
        {
            InitializeComponent();
        }

        public frmInput(string title, string inputName, string value)
            : this()
        {
            this.Text = title;
            lblLabel.Text = inputName;
            txtInput.Text = value;
        }

        public string Value
        {
            get { return txtInput.Text; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show(this, "Dữ liệu không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void frmInput_Shown(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}
