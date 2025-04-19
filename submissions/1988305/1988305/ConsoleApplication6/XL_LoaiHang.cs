using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class XL_LoaiHang
    {
        public static bool Check(string a, HangHoa[] b)
        {
            bool tim = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].LoaiHang == a)
                { tim = true; }
            }
            return tim;
        }

        public static bool KiemTra(HangHoa a, HangHoa[] b)
        {
            bool tim = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].MaHang == a.MaHang || b[i].TenHang == a.TenHang)
                { tim = true; }
            }
            return tim;
        }

        public static HangHoa[] ThemLoaiHang(HangHoa[] a)                         //THEM LOAI HANG VAO DANH MUC

        {
            HangHoa[] anew = new HangHoa[a.Length + 1];
            Console.WriteLine("NHAP THONG TIN HANG HOA THEM VAO:");
            anew[anew.Length - 1] = XL_HangHoa.ThemHangHoa();
            while (KiemTra(anew[anew.Length - 1], a) == true)
            {
                Console.WriteLine("Da ton tai, nhap lai thong tin:");
                anew[anew.Length - 1] = XL_HangHoa.ThemHangHoa();
            }
            for (int i = 0; i < anew.Length - 1; i++)
            {
                anew[i] = a[i];
            }
            return anew;
        }

        public static HangHoa[] SuaLoaiHang(HangHoa[] a)                          // SUA LOAI HANG
        {
            Console.WriteLine("Nhap Loai hang can Sua:");
            string tim = (Console.ReadLine());
            if (Check(tim, a) == true)
            {
                Console.WriteLine("Sua loai hang thanh:");
                string sua = Console.ReadLine();
                for (int i = 0; i < a.Length; i++)
                {
                    if (tim == a[i].LoaiHang)
                    {
                        a[i].LoaiHang = sua;
                    }
                }
                XL_HangHoa.XuatDanhMuc(a);
            }
            else
            {
                Console.WriteLine("=>> Khong tim thay Loai hang can sua");
            }
            return a;
        }

        public static HangHoa[] XoaLoaiHang(HangHoa[] a)
        {
            HangHoa[] anew;
            Console.WriteLine("Chon Loai hang can xoa:");
            string tim = (Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].LoaiHang == tim)
                {
                    dem++;
                }
            }
            anew = new HangHoa[a.Length - dem];
            if (dem > 0)
            {
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].LoaiHang != tim)
                        {
                            anew[j] = a[i];
                            j++;
                        }
                 }
                XL_HangHoa.XuatDanhMuc(anew);
             }
            else
            {
                Console.WriteLine("Khong tim thay Loai hang can xoa");
            }
            return anew;
        }
    }
}
