using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    class kieudulieu
    {
    }

    class LOAIHANG
    {
        public List<MATHANG> matHang = new List<MATHANG>();
        public string tenLoaiHang;

        public LOAIHANG(string ten)
        {
            this.tenLoaiHang = ten;
        }
    }

    struct MATHANG
    {
        public string ID;
        public string tenHang;
        public string hanDung;
        public string ctySanXuat;
        public int namSanXuat;

        public MATHANG(string ID, string tenHang, string hanDung, string ctySanXuat, int namSanXuat)
        {
            this.ID = ID;
            this.tenHang = tenHang;
            this.hanDung = hanDung;
            this.ctySanXuat = ctySanXuat;
            this.namSanXuat = namSanXuat;
    }
    }
}
