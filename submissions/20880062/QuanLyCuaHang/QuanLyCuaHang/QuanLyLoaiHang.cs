using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class QuanLyLoaiHang : Form
    {
        public QuanLyLoaiHang()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check constraint
            // Type Code is not null
            if (string.IsNullOrWhiteSpace(txtMaLoaiHang.Text))
            {
                MessageBox.Show("Mã Loại hàng không được để trống.");
                txtMaLoaiHang.Focus();
                return;
            }

            // Check constraint
            // Check duplicated data
            foreach (DataGridViewRow row in dgvLoaiHang.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(txtMaLoaiHang.Text))
                {
                    MessageBox.Show("Mã loại hàng đã tồn tại. Mã loại hàng không được trùng lặp. Vui lòng nhập mã loại hàng khác.");
                    txtMaLoaiHang.Focus();
                    return;
                }
            }

            // Add items
            addItems(txtMaLoaiHang.Text, txtTenLoaiHang.Text);
            btnReset_Click(sender, e);
            txtMaLoaiHang.Focus();

            // Enable to click button Remove, Change
            btnRemove.Enabled = true;
            btnChange.Enabled = true;
        }

        // Add data row from textboxes to datagridview
        public void addItems(string MaLoaiHang, string TenLoaiHang)
        {
            string[] row = { MaLoaiHang, TenLoaiHang };
            dgvLoaiHang.Rows.Add(row);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvLoaiHang.SelectedRows)
            {
                dgvLoaiHang.Rows.RemoveAt(item.Index);
            }

            // Not Enabled when data does not exist
            if (dgvLoaiHang.Rows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get data from datagridview in textboxes
            int rowIndex = dgvLoaiHang.CurrentCell.RowIndex;
            DataGridViewRow row = dgvLoaiHang.Rows[rowIndex];
            txtMaLoaiHang.Text = row.Cells[0].Value.ToString();
            txtTenLoaiHang.Text = row.Cells[1].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Check constraint
            // Type Code is not null
            if (string.IsNullOrWhiteSpace(txtMaLoaiHang.Text))
            {
                MessageBox.Show("Mã Loại hàng không được để trống.");
                txtMaLoaiHang.Focus();
                return;
            }

            // Check constraint
            // Check duplicated data
            foreach (DataGridViewRow row in dgvLoaiHang.Rows)
            {
                if (row.Index == dgvLoaiHang.CurrentCell.RowIndex)
                {
                    continue;
                }

                if (row.Cells[0].Value.ToString().Equals(txtMaLoaiHang.Text))
                {
                    MessageBox.Show("Mã loại hàng đã tồn tại. Mã loại hàng không được trùng lặp. Vui lòng nhập mã loại hàng khác.");
                    txtMaLoaiHang.Focus();
                    return;
                }
            }

            if (dgvLoaiHang.Rows.Count != 0)
            {
                int rowIndex = dgvLoaiHang.CurrentCell.RowIndex;
                DataGridViewRow newRow = dgvLoaiHang.Rows[rowIndex];
                newRow.Cells[0].Value = txtMaLoaiHang.Text;
                newRow.Cells[1].Value = txtTenLoaiHang.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Remove all items in panel
            txtMaLoaiHang.ResetText();
            txtTenLoaiHang.ResetText();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvLoaiHang.ClearSelection();
            string searchValue = txtFind.Text;
            int columnIndex = cbbColFind.SelectedIndex;
            int rowIndex;

            dgvLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                // Check constraint
                if (dgvLoaiHang.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu. Vui lòng đảm bảo dữ liệu tồn tại trước khi tìm kiếm.");
                    return;
                }

                else if (cbbColFind.SelectedItem == null)
                {
                    MessageBox.Show("Chọn vị trí cột cần tìm kiếm.");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtFind.Text))
                {
                    MessageBox.Show("Nhập nội dung cần tìm kiếm.");
                    return;
                }

                bool valueResult = true;
                foreach (DataGridViewRow row in dgvLoaiHang.Rows)
                {
                    if (columnIndex > 0)
                    {
                        if (row.Cells[columnIndex - 1].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            dgvLoaiHang.Rows[rowIndex].Selected = true;
                            valueResult = false;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (row.Cells[i].Value.ToString().Equals(searchValue))
                            {
                                rowIndex = row.Index;
                                dgvLoaiHang.Rows[rowIndex].Selected = true;
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
                            + "\" trong cột \"" + dgvLoaiHang.Columns[columnIndex - 1].HeaderText + "\"");
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
        private void txtMaLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // Using Enter key to navigate the button Add
        private void txtTenLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
