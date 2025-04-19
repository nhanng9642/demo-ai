using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLT_QLCH_WindowsFormsApp.Models
{
    public struct SanPham 
    {
        public bool IsNullStruct;
        public string MaHang;
        public string Ten;
        public int HanDungTheoNgay;
        public DateTime NgaySanXuat;
        public DateTime NgayHetHan
        {
            get
            {
                return NgaySanXuat.AddDays(this.HanDungTheoNgay);
            }
        }
        public string NoiSanXuat;
        public LoaiHang LoaiHang;
    }
}
