/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System.Collections.Generic;

namespace QuanLyCuaHang
{
    internal class ProductTypeStorage
    {
        public List<ProductType> _productTypes = new List<ProductType>();
        private IdGenerator _idGenerator = new IdGenerator(1);

        public ProductTypeStorage()
        {
        }

        public List<ProductType> ProductTypes { get { return _productTypes; } }

        /// <summary>
        /// Lưu trữ loại hàng
        /// </summary>
        /// <param name="type"></param>
        public void Save(ProductType type)
        {
            var exist = GetById(type.Id);
            if (exist != null)
            {
                exist.Name = type.Name;
            }
            else
            {
                type.Id = _idGenerator.Next(); // Tạo ID mới
                _productTypes.Add(type);
            }
        }

        /// <summary>
        /// Xóa theo Id
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            var exist = GetById(id);
            if (exist != null)
            {
                _productTypes.Remove(exist);
            }
        }

        /// <summary>
        /// Lấy loại hàng theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductType GetById(int id)
        {
            for (var inx = 0; inx < _productTypes.Count; ++inx)
            {
                if (_productTypes[inx].Id == id)
                {
                    return _productTypes[inx];
                }
            }
            return null;
        }

        /// <summary>
        /// Tìm loại hàng theo tên
        /// </summary>
        /// <param name="name">từ khóa</param>
        /// <returns></returns>
        public List<ProductType> Search(string keyword)
        {
            var result = new List<ProductType>();
            for(var inx = 0; inx < _productTypes.Count; ++inx)
            {
                var type = _productTypes[inx];
                if(type.Name.IndexOf(keyword, 0, System.StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    result.Add(type);
                }
            }
            return result;
        }

        /// <summary>
        /// Đếm số lượng
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _productTypes.Count;
        }
    }
}
