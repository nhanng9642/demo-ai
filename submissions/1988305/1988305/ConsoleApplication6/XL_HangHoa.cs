using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public struct HangHoa
    {
        public string MaHang;
        public string TenHang;
        public string HanDung;
        public string CongTySanXuat;
        public string NamSanXuat;
        public string LoaiHang;
    }
    class XL_HangHoa
    {

        public static bool Check(string a, HangHoa[] b)
        {
            bool tim = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].MaHang == a || b[i].TenHang ==a)
                { tim = true; }
            }
            return tim;
        }

        public static HangHoa ThemHangHoa()
        {
            HangHoa hh;
            Console.WriteLine("Nhap Ma hang:");
            hh.MaHang = (Console.ReadLine());
            Console.WriteLine("Nhap Ten hang:");
            hh.TenHang = (Console.ReadLine());
            Console.WriteLine("Nhap Han dung:");
            hh.HanDung = (Console.ReadLine());
            Console.WriteLine("Nhap Cty san xuat:");
            hh.CongTySanXuat = (Console.ReadLine());
            Console.WriteLine("Nhap nam san xuat:");
            hh.NamSanXuat = (Console.ReadLine());
            Console.WriteLine("Nhap Loai hang:");
            hh.LoaiHang = (Console.ReadLine());
            return hh;
        }
        public static void XuatHangHoa(HangHoa x)
        {
            // return $"{x.MaHang} / {x.TenHang} / {x.HanDung} / {x.CongTySanXuat} / {x.NamSanXuat} / {x.LoaiHang}";
            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|", x.MaHang, x.TenHang, x.HanDung, x.CongTySanXuat, x.NamSanXuat, x.LoaiHang);
        }
        public static HangHoa[] TaoDanhMuc()                                        //TAO DANH MUC HANG HOA
        {
            Console.WriteLine("TAO DANH MUC HANG HOA");
            Console.WriteLine("=======================");
            Console.Write("So mat hang trong danh muc:");
            int n = int.Parse(Console.ReadLine());
            HangHoa[] a = new HangHoa[n];
            for (int i = 0; i < a.Length; i++)
            {
                bool TrungLap = true;
                while (TrungLap == true)
                {
                    Console.WriteLine($"Nhap thong tin hang hoa thu {i + 1}");
                    a[i] = XL_HangHoa.ThemHangHoa();
                    TrungLap = false;
                    for (int j = 0; j < i; j++)
                    {
                        if ((a[i].MaHang == a[j].MaHang && i != 0) || (a[i].TenHang == a[j].TenHang && i != 0))
                        {
                            Console.WriteLine("Trung Ma hang hoac trung ten hang, nhap lai:");
                            TrungLap = true;
                        }
                    }
                }
            }
            return a;
        }
        public static void XuatDanhMuc(HangHoa[] a)
        {
            Console.WriteLine("=================\n DANH MUC HANG HOA");
            Console.WriteLine("=================");
            Console.WriteLine("|MaHang    |TenHang   |HanDung   |CTySanXuat|Nam SXuat |LoaiHang  |");
            for (int i = 0; i < a.Length; i++)
            {
                XL_HangHoa.XuatHangHoa(a[i]);
            }
        }
        public static HangHoa[] ThemHangVaoDanhMuc(HangHoa[] a)                   //THEM HANG HOA VAO DANH MUC
        {
            HangHoa[] anew = new HangHoa[a.Length + 1];
            Console.WriteLine("NHAP THONG TIN HANG HOA THEM VAO:");
            anew[anew.Length-1] = XL_HangHoa.ThemHangHoa();
            while (KiemTra(anew[anew.Length - 1], a) == true)
            {
                Console.WriteLine("Da ton tai Ma hang hoac Ten hang, nhap lai thong tin:");
                anew[anew.Length-1] = XL_HangHoa.ThemHangHoa();
            }
            for (int i = 0; i < anew.Length-1; i++)
                {
                    anew[i] = a[i];
                }
            return anew;
        }
        public static HangHoa[] SuaHangHoa(HangHoa[] a)                          // SUA HANG HOA
        {
            Console.WriteLine("Nhap Ma hang can Sua:");
            string tim = (Console.ReadLine());
            if (Check(tim, a) == false)
            {
                Console.WriteLine("=>> Khong tim thay MaHang can sua");
            }
            else
            {
                //Console.WriteLine("Sua loai hang thanh:");
                //string sua = Console.ReadLine();
                for (int i = 0; i < a.Length; i++)
                {
                    if (tim == a[i].MaHang)
                    {
                        bool TrungLap = true;
                        //a[i] = XL_HangHoa.ThemHangHoa();
                        while (TrungLap == true)
                        {
                            a[i] = XL_HangHoa.ThemHangHoa();
                            TrungLap = false;
                            for (int j = 0; j < a.Length; j++)
                            {
                                if (a[j].MaHang == a[i].MaHang && j != i)
                                {
                                    Console.WriteLine("MaHang nay da ton tai. Nhap lai thong tin hang hoa can sua:");
                                    TrungLap = true;
                                }
                            }
                        }
                    }
                }
                XuatDanhMuc(a);
            }
        return a;
        }
        public static HangHoa[] XoaHang(HangHoa[] a)
        {
            HangHoa[] anew;
            anew = new HangHoa[a.Length - 1];
            Console.WriteLine("Chon Ma hang can xoa:");
            string xoa = (Console.ReadLine());
            if (Check(xoa,a) == false)
            {
                Console.WriteLine("Khong tim thay Ma hang can xoa:");
                return a;
            }
            else
            {
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].MaHang != xoa)
                    {
                        anew[j] = a[i];
                        j++;
                    }
                }
                XuatDanhMuc(anew);
            }
            return anew;
        }                           //XOA HANG TRONG DANH MUC
        public static void TimKiem(HangHoa[] a)
        {
            Console.WriteLine("Tim kiem theo MaHang chon [1]");
            Console.WriteLine("Tim kiem theo TenHang chon [2]");
            Console.WriteLine("Tim kiem theo CongTySanXuat chon [3]");
            Console.WriteLine("Tim kiem theo LoaiHang chon [4]");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.WriteLine("Nhap MaHang can tim kiem:");
                string tim = (Console.ReadLine());
                bool tontai = false;
                Console.WriteLine("==============\nKet qua la:\n ==============");
                Console.WriteLine("|MaHang    |TenHang   |HanDung   |CTySanXuat|Nam SXuat |LoaiHang  |");
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].MaHang == tim)
                    {
                        tontai = true;
                        XL_HangHoa.XuatHangHoa(a[i]);
                    }
                }
                if (tontai == false)
                {
                    Console.WriteLine("Khong tim thay Ma hang");
                }
            }
            if (chon == 2)
            {
                Console.WriteLine("Nhap TenHang can tim kiem:");
                string tim = Console.ReadLine();
                bool tontai = false;
                Console.WriteLine("==============\nKet qua la:");
                Console.WriteLine("|MaHang    |TenHang   |HanDung   |CTySanXuat|Nam SXuat |LoaiHang  |");
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].TenHang == tim)
                    {
                        tontai = true;
                        XL_HangHoa.XuatHangHoa(a[i]);
                    }
                }
                if (tontai == false)
                {
                     Console.WriteLine("Khong tim thay Ten hang\n\n ==============");
                }
             }
            if (chon == 3)
            {
                Console.WriteLine("Nhap TenCongTySanXuat can tim kiem:");
                string tim = Console.ReadLine();
                bool tontai = false;
                Console.WriteLine("==============\nKet qua la:\n ==============");
                Console.WriteLine("|MaHang    |TenHang   |HanDung   |CTySanXuat|Nam SXuat |LoaiHang  |");
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].CongTySanXuat == tim)
                    {
                        tontai = true;
                        XL_HangHoa.XuatHangHoa(a[i]);
                    }
                }
                if (tontai == false)
                {
                    Console.WriteLine("Khong tim thay Cong ty san xuat");
                }
            }
            if (chon == 4)
            {
                Console.WriteLine("Nhap LoaiHang can tim kiem:");
                string tim = Console.ReadLine();
                bool tontai = false;
                Console.WriteLine("==============\nKet qua la:\n ==============");
                Console.WriteLine("|MaHang    |TenHang   |HanDung   |CTySanXuat|Nam SXuat |LoaiHang  |");
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].LoaiHang == tim)
                    {
                        tontai = true;
                        XL_HangHoa.XuatHangHoa(a[i]);
                    }
                }
                if (tontai == false)
                {
                    Console.WriteLine("Khong tim thay Loai hang");
                }
            }
        }
        public static bool KiemTra(HangHoa a, HangHoa[] b)
        {
            bool tim = false ;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].MaHang == a.MaHang || b[i].TenHang == a.TenHang)
                { tim = true;  }
            }
        return tim;
        }
    }
}
