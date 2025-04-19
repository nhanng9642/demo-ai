/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmMain : Form
    {
        private ProductStorage _productStore = new ProductStorage(); // Dùng lưu trữ và truy xuất dữ liệu mặt hàng
        private ProductTypeStorage _productTypeStore = new ProductTypeStorage();

        public frmMain()
        {
            InitializeComponent();
        }

        // Nhấn nút "Thêm mặt hàng"
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if(_productTypeStore.Count() == 0)
            {
                MessageBox.Show(this, "Bạn chưa nhập loại mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Hiển thị form thêm mặt hàng
            var formAddProduct = new frmProductInfo(_productTypeStore);
            if (formAddProduct.ShowDialog(this) == DialogResult.OK)
            {
                // Lưu thông tin mặt hàng nếu người dùng nhấn nút "Lưu"
                var product = formAddProduct.GetProduct();
                _productStore.Save(product);

                UpdateGrid();
            }
        }

        // Nhấn nút "Sửa"
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var selectedRows = gridProducts.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var product = selectedRows[0].DataBoundItem as Product;
                if (product != null)
                {
                    // Nếu trên danh sách có chọn một mặt hàng
                    // Hiển thị cửa sổ sửa thông tin mặt hàng
                    var formEditProduct = new frmProductInfo(_productTypeStore, product);
                    formEditProduct.Text = "Sửa mặt hàng";
                    if (formEditProduct.ShowDialog(this) == DialogResult.OK)
                    {
                        // Lưu thôn tin mặt hàng nếu người dùng nhẫn nút "Lưu"
                        var editedProduct = formEditProduct.GetProduct();
                        _productStore.Save(editedProduct);

                        UpdateGrid();
                    }
                }
            }
        }

        // Nhấn nút "Xóa"
        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var selectedRows = gridProducts.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var product = selectedRows[0].DataBoundItem as Product;

                // Nếu trên danh sách có chọn một mặt hàng bất kỳ
                // Hiển thị cửa sổ xác nhận thao tác xóa
                if (product != null && MessageBox.Show(this, "Bạn có muốn xóa mặt hàng: " + product.Name, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _productStore.RemoveById(product.Id);
                    UpdateGrid();
                }
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            var keyword = inpSearch.Text;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var searchResults = _productStore.SearchByName(keyword.Trim());
                UpdateGrid(searchResults);
            }
            else
            {
                UpdateGrid();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show(this, "Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void productTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var formProductManage = new frmProductType(_productTypeStore);
            formProductManage.ShowDialog(this);
        }

        private void UpdateGrid()
        {
            UpdateGrid(_productStore.Products);
        }

        private void UpdateGrid(List<Product> products)
        {
            gridProducts.DataSource = products.ToArray();
        }
    }
}
