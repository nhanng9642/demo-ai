/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    internal partial class frmProductType : Form
    {
        private ProductTypeStorage _store = null;
        public frmProductType(ProductTypeStorage store)
        {
            InitializeComponent();
            _store = store;
            lstProductTypes.DisplayMember = "Name";
            lstProductTypes.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var inputForm = new frmInput("Thêm loại hàng", "Tên loại hàng", "");
            if (inputForm.ShowDialog(this) == DialogResult.OK)
            {
                var value = inputForm.Value;
                _store.Save(new ProductType
                {
                    Id = -1,
                    Name = value
                });

                UpdateList();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var selectedItem = lstProductTypes.SelectedItem as ProductType;
            if (selectedItem != null)
            {
                var inputForm = new frmInput("Sửa loại hàng", "Tên loại hàng", selectedItem.Name);
                if (inputForm.ShowDialog(this) == DialogResult.OK)
                {
                    var value = inputForm.Value;
                    _store.Save(new ProductType
                    {
                        Id = selectedItem.Id,
                        Name = value
                    });

                    UpdateList();
                }
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var selectedItem = lstProductTypes.SelectedItem as ProductType;
            if (selectedItem != null)
            {
                _store.Remove(selectedItem.Id);
                UpdateList();
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            var keyword = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                UpdateList(_store.ProductTypes);
            }
            else
            {
                var searchResults = _store.Search(keyword);
                UpdateList(searchResults);
            }
        }

        private void frmProductType_Shown(object sender, System.EventArgs e)
        {
            txtSearch.Focus();
            UpdateList(_store.ProductTypes);
        }

        private void UpdateList()
        {
            UpdateList(_store.ProductTypes);
        }

        private void UpdateList(List<ProductType> types)
        {
            lstProductTypes.DataSource = types.ToArray();
        }
    }
}
