using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class QuanLyMatHang : Form
    {
        public QuanLyMatHang()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check constraint
            // Type Code is not null
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã Hàng hóa không được để trống.");
                txtMaHang.Focus();
                return;
            }

            // Add items
            addItems(txtMaHang.Text, txtTenHangHoa.Text, txtCtySX.Text, txtLoaiHang.Text, txtNamSX.Text, txtHanSD.Text);
            btnReset_Click(sender, e);
            txtMaHang.Focus();

            // Enable to click button Remove, Change
            btnRemove.Enabled = true;
            btnChange.Enabled = true;
        }

        // Add data row from textboxes to datagridview
        public void addItems(string MaHang, string TenHangHoa, string CTySX, string LoaiHang, string NamSX, string HanSD)
        {
            string[] row = { MaHang, TenHangHoa, CTySX, LoaiHang, NamSX, HanSD };
            dgvMatHang.Rows.Add(row);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove data rows
            foreach (DataGridViewRow item in this.dgvMatHang.SelectedRows)
            {
                dgvMatHang.Rows.RemoveAt(item.Index);
            }

            // Not Enabled when data does not exist
            if (dgvMatHang.Rows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnChange.Enabled = false;
                txtMaHang.Focus();
            }
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get data from datagridview in textboxes
            int rowIndex = dgvMatHang.CurrentCell.RowIndex;
            DataGridViewRow row = dgvMatHang.Rows[rowIndex];
            txtMaHang.Text = row.Cells[0].Value.ToString();
            txtTenHangHoa.Text = row.Cells[1].Value.ToString();
            txtLoaiHang.Text = row.Cells[2].Value.ToString();
            txtCtySX.Text = row.Cells[3].Value.ToString();
            txtNamSX.Text = row.Cells[4].Value.ToString();
            txtHanSD.Text = row.Cells[5].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Check constraint
            // Type Code is not null
            if (string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã Hàng hóa không được để trống.");
                txtMaHang.Focus();
                return;
            }

            if (dgvMatHang.Rows.Count != 0) 
            {
                int rowIndex = dgvMatHang.CurrentCell.RowIndex;
                DataGridViewRow newRow = dgvMatHang.Rows[rowIndex];
                newRow.Cells[0].Value = txtMaHang.Text;
                newRow.Cells[1].Value = txtTenHangHoa.Text;
                newRow.Cells[2].Value = txtLoaiHang.Text;
                newRow.Cells[3].Value = txtCtySX.Text;
                newRow.Cells[4].Value = txtNamSX.Text;
                newRow.Cells[5].Value = txtHanSD.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Remove all items in panel
            txtMaHang.ResetText();
            txtTenHangHoa.ResetText();
            txtCtySX.ResetText();
            txtLoaiHang.ResetText();
            txtNamSX.ResetText();
            txtHanSD.ResetText();
            txtMaHang.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvMatHang.ClearSelection();
            string searchValue = txtFind.Text;
            int columnIndex = cbbColFind.SelectedIndex;
            int rowIndex;

            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                // Check data validation
                if (dgvMatHang.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu. Vui lòng đảm bảo dữ liệu tồn tại trước khi tìm kiếm.");
                    return;
                }

                else if (cbbColFind.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vị trí cột cần tìm kiếm.");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtFind.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung cần tìm kiếm.");
                    return;
                }

                bool valueResult = true;
                foreach (DataGridViewRow row in dgvMatHang.Rows)
                {
                    if (columnIndex != 0)
                    {
                        if (row.Cells[columnIndex - 1].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvMatHang.Rows[rowIndex].Selected = true;
                            valueResult = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (row.Cells[i].Value.ToString().Equals(searchValue))
                            {
                                rowIndex = row.Index;
                                dgvMatHang.Rows[rowIndex].Selected = true;
                                valueResult = false;
                            }
                        }
                    }
                }

                if (cbbColFind.SelectedItem != null && !string.IsNullOrWhiteSpace(txtFind.Text) && valueResult != false)
                {
                    if (columnIndex != 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu \"" + searchValue
                            + "\" trong cột \"" + dgvMatHang.Columns[columnIndex - 1].HeaderText + "\"");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu \"" + searchValue + "\" trong tất cả các cột dữ liệu");
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Using Enter key to navigate the next textbox
        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the next textbox
        private void txtTenHangHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the next textbox
        private void txtCtySX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the next textbox
        private void txtLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the next textbox
        private void txtNamSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the button Add
        private void txtHanSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
