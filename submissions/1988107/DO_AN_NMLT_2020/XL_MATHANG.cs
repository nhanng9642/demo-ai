using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_NMLT_2020
{
    public struct MATHANG
    {
        public int MaMH;
        public string TenMH;
        public int HanDung;
        public string CongTySX;
        public int NamSX;
        public string LoaiHang;
    }
    class XL_MATHANG
    {
        public static bool KiemTraMaMH(List<MATHANG> dsMatHang, int s)
        {
            foreach (MATHANG p in dsMatHang)
            {
                if (p.MaMH == s)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool NamSXHopLe(int s)
        {
            if (s >= 1900 && s <= DateTime.Now.Year)
            {
                return true;
            }
            return false;
        }
        public static bool HanDungHopLe(int s)
        {
            if (s >= DateTime.Now.Year)
            {
                return true;
            }
            return false;
        }

        public static List<MATHANG> Them(List<MATHANG> dsMatHang, MATHANG s)
        {
            if (!KiemTraMaMH(dsMatHang, s.MaMH))
            {
                dsMatHang.Add(s);
            }
            return dsMatHang;
        }

        public static List<MATHANG> Xoa(List<MATHANG> dsMatHang, MATHANG s)
        {
            foreach (MATHANG p in dsMatHang)
            {
                if (s.MaMH == p.MaMH)
                {
                    dsMatHang.Remove(p);
                    break;
                }
            }
            return dsMatHang;
        }

        public static List<MATHANG> Sua(List<MATHANG> dsMatHang, MATHANG s)
        {
            foreach (MATHANG p in dsMatHang)
            {
                if (s.MaMH == p.MaMH)
                {
                    dsMatHang.Remove(p);
                    dsMatHang.Add(s);
                    break;
                }
            }
            return dsMatHang;
        }

        public static List<MATHANG> TimKiemSoMHCungLoai(List<MATHANG> dsMatHang, string keyword)
        {
            List<MATHANG> dsTimKiem = new List<MATHANG>();
            foreach (MATHANG p in dsMatHang)
            {
                if (string.IsNullOrEmpty(keyword) || p.LoaiHang.Contains(keyword))
                {
                    dsTimKiem.Add(p);
                }
            }
            return dsTimKiem;
        }
    }
}
