/*
 * Đồ án: Nhập môn lập trình
 * Mã môn: CTT003 
 * MSSV: 20810003
 * */

using System;

namespace QuanLyCuaHang
{
    internal class Product
    {
        /// <summary>
        /// Mã duy nhất - mã định danh mặt hàng
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên mặt hàng
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ngày hết hạn (hiển thị dang ngày/tháng/năm - dd/MM/yyyy)
        /// </summary>
        public DateTime ExpireDate { get; set; }

        /// <summary>
        /// Công ty sản xuất
        /// </summary>
        public string Producer { get; set; }

        /// <summary>
        /// Ngày sãn xuất (chỉ hiển thị năm)
        /// </summary>
        public DateTime ManufactureDate { get; set; }

        /// <summary>
        /// Loại mật hàng
        /// </summary>
        public ProductType Type { get; set; }

        public string ProductTypeName { get { return Type.Name; } }
    }
}
