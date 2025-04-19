using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    public class MatHang
    {
        public string TenHang { get; set; }
        public string MaHang { get; set; }
        public string CongTy { get; set; }
        public string NamSanXuat { get; set; }
        public DateTime HanDung { get; set; }
        public LoaiHang Nhom { get; set; }
        public override string ToString()
        {
            return this.TenHang;
        }
    }
}
