using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROJECT_NMLT
{
    public struct PRODUCTS
    {
        public int MaHang;
        public string TenHang;
        public int HanDung;
        public string CtySanXuat;
        public int NamSanXuat;
        public string LoaiHang;
    }
    public class XL_NHIEPVU
    {
        private static string filePath = "C:\\DB\\products.txt";
        
        // Ham Them San Pham
        public static void ThemHang(PRODUCTS s)
        {
            var dsHang = TimKiem(string.Empty);
            dsHang.Add(s);
            LuuDanhSachHang(dsHang);
        }
        // Luu Danh Sach Mat Hang
        public static void LuuDanhSachHang(List<PRODUCTS> dsHang)
        {
            StreamWriter file = new StreamWriter(filePath);
            for (int i = 0; i < dsHang.Count; i++)
            {
                var s = dsHang[i];
                string line = $"{s.MaHang},{s.TenHang},{s.HanDung},{s.CtySanXuat},{s.NamSanXuat},{s.LoaiHang}";
                if (i == dsHang.Count - 1)
                {
                    file.Write(line);
                }
                else
                {
                    file.WriteLine(line);
                }
            }
            file.Close();
        }
        public static void XoaHang(int maHang)
        {
            var dsHang = TimKiem(string.Empty);
            foreach (var s in dsHang)
            {
                if (s.MaHang == maHang)
                {
                    dsHang.Remove(s);
                    break;
                }
            }
            LuuDanhSachHang(dsHang);
        }
        public static List<PRODUCTS> TimKiem(string keyword)
        {
            //var isNumber = int.TryParse(keyword, out int keyword_int);
            List<PRODUCTS> ds = new List<PRODUCTS>();
            StreamReader file = new StreamReader(filePath);
            while (!file.EndOfStream)
            {
                var line = file.ReadLine();
                var hang = KhoiTao(line);
                if (string.IsNullOrEmpty(keyword) || hang.TenHang.Contains(keyword))
                {
                    ds.Add(hang);
                }
                if (string.IsNullOrEmpty(keyword) || hang.LoaiHang.Contains(keyword))
                {
                    ds.Add(hang);
                }
            }
            file.Close();
            return ds;
        }
        //Sua Hang
        public static void SuaHang(PRODUCTS s)
        {
            //Kiem tra tinh hop le
            var dsHang = DocDanhSachHang(string.Empty);
            foreach (var hang in dsHang)
            {
                //var sach = dsSach[i];
                if (hang.MaHang == s.MaHang)
                {
                    dsHang.Remove(hang);
                    dsHang.Add(s);
                    break;
                }
            }
            LuuDanhSachHang(dsHang);
        }
        public static PRODUCTS DocHang(int maHang)
        {
            PRODUCTS kq = new PRODUCTS();
            var dsHang = DocDanhSachHang(string.Empty);
            foreach (var s in dsHang)
            {
                if (s.MaHang == maHang)
                {
                    kq = s;
                    break;
                }
            }
            return kq;
        }
        public static List<PRODUCTS> DocDanhSachHang(string keywork)
        {
            List<PRODUCTS> ds = new List<PRODUCTS>();
            ds = TimKiem(keywork);
            return ds;
        }
        public static PRODUCTS KhoiTao(string line)
        {
            PRODUCTS s;
            var m = line.Split(',');
            s.MaHang = int.Parse(m[0]);
            s.TenHang = m[1];
            s.HanDung = int.Parse(m[2]);
            s.CtySanXuat = m[3];
            s.NamSanXuat = int.Parse(m[4]);
            s.LoaiHang = m[5];
            return s;
        }
    }
}
