using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa
{
    public class MATHANG
    {
        public string maHang { get; set; }
        public string tenHang { get; set; }
        public DateTime hanSD { get; set; }
        public string cTySX { get; set; }
        public short namSX { get; set; }
        public string loaiHang { get; set; }

        public MATHANG(string MaHang, string TenHang, DateTime HanSD, string CTySX, short NamSX, string LoaiHang)
        {
            maHang = MaHang;
            tenHang = TenHang;
            hanSD = HanSD;
            cTySX = CTySX;
            namSX = NamSX;
            loaiHang = LoaiHang;
        }
    }

    public class LOAIHANG
    {
        public string maLoaiHang { get; set; }
        public string tenLoaiHang { get; set; }

        public LOAIHANG(string MaLoaiHang, string TenLoaiHang)
        {
            maLoaiHang = MaLoaiHang;
            tenLoaiHang = TenLoaiHang;
        }
    }
}
