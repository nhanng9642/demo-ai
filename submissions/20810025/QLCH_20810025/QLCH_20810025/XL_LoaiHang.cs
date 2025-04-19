using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_20810025
{
    public class KB_LoaiHang
    {
        public string Maloaihang { get; set; }
        public string Tenloaihang { get; set; }
        public DateTime Ngaytao { get; set; }
        public string Diengiai { get; set; }

        public  KB_LoaiHang() {

        }

        public KB_LoaiHang(string maloaihang, string tenloaihang, DateTime ngaytao, string diengiai)
        {
            Maloaihang = maloaihang;
            Tenloaihang = tenloaihang;
            DateTime Ngaytao = ngaytao;
            string Diengiai = diengiai;
        }
}

}

