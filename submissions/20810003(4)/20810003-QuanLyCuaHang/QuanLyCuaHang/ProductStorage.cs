/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System.Collections.Generic;

namespace QuanLyCuaHang
{
    /// <summary>
    /// Lớp lưu trữ thông tin mặt hàng
    /// </summary>
    class ProductStorage
    {
        private readonly List<Product> _products = new List<Product>();
        private IdGenerator _idGenerator = new IdGenerator(1);


        public ProductStorage()
        { }

        public List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        /// <summary>
        /// Lưu trữ thôn tin mặt hàng
        /// </summary>
        /// <param name="product"></param>
        public void Save(Product product)
        {
            var existProduct = GetById(product.Id);
            // Nếu mặt hàng đã tồn tại ?
            if (existProduct != null)
            {
                // Cập nhật thông tin mặt hàng
                existProduct.Name = product.Name;
                existProduct.Code = product.Code;
                existProduct.ExpireDate = product.ExpireDate;
                existProduct.Producer = product.Producer;
                existProduct.ManufactureDate = product.ManufactureDate;
                existProduct.Type = product.Type;
            }
            else
            {
                // Thêm mặt hàng mới
                product.Id = _idGenerator.Next();
                _products.Add(product);
            }
        }

        // Tìm mặt hàng theo "tên mặt hàng"
        public List<Product> SearchByName(string keyword)
        {
            var result = new List<Product>(); // Chửa danh sách các mặt hàng tìm thấy
            for (var inx = 0; inx < _products.Count; ++inx)
            {
                var product = _products[inx];
                // Kiểm tra từ khóa tìm kiếm có nằm trong tên mặt hàng?
                if (product.Name.IndexOf(keyword, 0, System.StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        // Xóa mặt hàng theo mã duy nhất của mặt hàng (Id)
        public void RemoveById(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        // Lấy thông tin mặt hàng theo mã duy nhất - mã định danh (Id)
        public Product GetById(int id)
        {
            for (var inx = 0; inx < _products.Count; ++inx)
            {
                var product = _products[inx];
                if (product.Id == id) return product;
            }
            return null;
        }

        /// <summary>
        /// Đếm số lượng
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _products.Count;
        }
    }
}
