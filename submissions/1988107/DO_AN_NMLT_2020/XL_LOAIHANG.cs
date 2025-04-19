using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_NMLT_2020
{
    public struct LOAIHANG
    {
        public int MaLH;
        public string TenLH;
    }
    class XL_LOAIHANG
    {
        public static bool KiemTraMaLH(List<LOAIHANG> dsLoaiHang, int s)
        {
            foreach (LOAIHANG p in dsLoaiHang)
            {
                if (p.MaLH == s)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<LOAIHANG> Them(List<LOAIHANG> dsLoaiHang, LOAIHANG s)
        {
            if (!KiemTraMaLH(dsLoaiHang, s.MaLH))
            {
                dsLoaiHang.Add(s);
            }
            return dsLoaiHang;
        }
        public static List<LOAIHANG> Xoa(List<LOAIHANG> dsLoaiHang, LOAIHANG s)
        {
            foreach (LOAIHANG p in dsLoaiHang)
            {
                if (s.MaLH == p.MaLH && s.TenLH == p.TenLH)
                {
                    dsLoaiHang.Remove(p);
                    break;
                }
            }
            return dsLoaiHang;
        }
        public static List<LOAIHANG> Sua(List<LOAIHANG> dsLoaiHang, LOAIHANG s)
        {
            foreach (LOAIHANG p in dsLoaiHang)
            {
                if (s.MaLH == p.MaLH)
                {
                    dsLoaiHang.Remove(p);
                    dsLoaiHang.Add(s);
                    break;
                }
            }
            return dsLoaiHang;
        }
        public static List<LOAIHANG> TimKiemLH(List<LOAIHANG> dsLoaiHang, string keyword)
        {
            List<LOAIHANG> dsTimKiem = new List<LOAIHANG>();
            foreach (LOAIHANG p in dsLoaiHang)
            {
                if (string.IsNullOrEmpty(keyword) || p.TenLH.Contains(keyword))
                {
                    dsTimKiem.Add(p);
                }
            }
            return dsTimKiem;
        }
    }
}
