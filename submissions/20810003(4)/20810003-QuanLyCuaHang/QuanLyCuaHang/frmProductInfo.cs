/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    internal partial class frmProductInfo : Form
    {
        private Product _product;
        private readonly ProductTypeStorage _productTypeStorage;

        public frmProductInfo(ProductTypeStorage productTypeStorage)
        {
            InitializeComponent();
            _productTypeStorage = productTypeStorage;

            cmbProductType.DisplayMember = "Name";
            cmbProductType.ValueMember = "Id";
        }

        public frmProductInfo(ProductTypeStorage productTypeStorage, Product product)
            : this(productTypeStorage)
        {
            SetProduct(product);
        }

        /// <summary>
        /// Lấy dữ liệu mặt hàng từ cửa sổ
        /// </summary>
        /// <returns></returns>
        public Product GetProduct()
        {
            var product = new Product
            {
                Id = _product != null ? _product.Id : -1,
                Code = txtCode.Text,
                Name = txtProductName.Text,
                ExpireDate = dtpExpireDate.Value,
                Producer = txtProducer.Text,
                ManufactureDate = dtpManufactureDate.Value,
                Type = GetSelectedProductType()
            };
            return product;
        }

        // Truyền dữ liệu từ bên ngoài vào cửa sổ
        // Dùng cho mục đích sửa dữ liệu
        public void SetProduct(Product product)
        {
            _product = product;

            txtCode.Text = product.Code;
            txtProductName.Text = product.Name;
            dtpExpireDate.Value = product.ExpireDate;
            dtpManufactureDate.Value = product.ManufactureDate;
            txtProducer.Text = product.Producer;
            cmbProductType.SelectedItem = product.Type;
        }

        private ProductType GetSelectedProductType()
        {
            return cmbProductType.SelectedItem as ProductType;
        }

        private void UpdateProductTypeDropdown(List<ProductType> productTypes) {
            cmbProductType.DataSource = productTypes.ToArray();
        }

        // Lưu giữ liệu
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var product = GetProduct();
            var validateResult = Validate(product); // Kiểm tra dữ liệu
            if (!string.IsNullOrWhiteSpace(validateResult))
            {
                // Hiển thị cảnh báo dữ liệu sai
                MessageBox.Show(this, validateResult, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK; // Tín hiệu để cửa sổ chính nhận biết "Lưu" giữ liệu
            }
        }

        // Đóng cửa sổ, không lưu dữ liệu
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmProductInfo_Shown(object sender, System.EventArgs e)
        {
            UpdateProductTypeDropdown(_productTypeStorage.ProductTypes);
        }

        /// <summary>
        /// Kiểm tra dữ liệu mặt hàng
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private string Validate(Product product)
        {
            var result = new List<string>();

            // Kiem tra du lieu
            if (string.IsNullOrWhiteSpace(product.Code))
            {
                result.Add("\"Mã hàng\" không được để trống.");
            }

            if (string.IsNullOrWhiteSpace(product.Name) || product.Name.Trim().Length < 5)
            {
                result.Add("\"Tên hàng\" phải có ít nhất 5 ký tự");
            }

            if (string.IsNullOrWhiteSpace(product.Producer))
            {
                result.Add("\"Công ty sản xuất\" không được để trống");
            }

            if (product.Type == null || string.IsNullOrWhiteSpace(product.Type.Name))
            {
                result.Add("\"Loại hàng\" không được bỏ trống");
            }

            var sb = new StringBuilder();
            for (var inx = 0; inx < result.Count; ++inx)
            {
                sb.AppendLine(result[inx]);
            }
            return sb.ToString();
        }
    }
}
