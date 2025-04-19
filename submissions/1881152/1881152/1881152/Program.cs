using System;

namespace _1881152
{
    class Program
    {
        public struct MatHang
        {
            public string MaHang;
            public string TenHang;
            public string HanDung;
            public string CongTySanXuat;
            public string NamSanXuat;
            public string LoaiHang;
        }
        public struct DanhSachMatHang
        {
            public MatHang[] dsMathang;
        }

        public static MatHang ThemMatHang()
        {

            MatHang a;

            Console.Write("Ma Hang: ");
            a.MaHang = Console.ReadLine();

            Console.Write("Ten Hang: ");
            a.TenHang = Console.ReadLine();

            Console.Write("Han Dung: ");
            a.HanDung = Console.ReadLine();

            Console.Write("Cong Ty San Xuat: ");
            a.CongTySanXuat = Console.ReadLine();

            Console.Write("Nam San Xuat: ");
            a.NamSanXuat = Console.ReadLine();

            Console.Write("Loai Hang: ");
            a.LoaiHang = Console.ReadLine();

            return a;

        }

        public static DanhSachMatHang ThemDanhSach()
        {

            DanhSachMatHang a;
            Console.Write("SO LUONG MAT HANG: ");
            int n = int.Parse(Console.ReadLine());
            a.dsMathang = new MatHang[n];

            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                a.dsMathang[i] = ThemMatHang();
            }

            return a;
        }
        public static void XuatMatHang(DanhSachMatHang a)
        {
            Console.WriteLine("MaHang\t TenHang\t HangDung\t CongTySanXuat\t NamSanXuat\t LoaiHang");
            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}", a.dsMathang[i].MaHang, a.dsMathang[i].TenHang, a.dsMathang[i].HanDung, a.dsMathang[i].CongTySanXuat, a.dsMathang[i].NamSanXuat, a.dsMathang[i].LoaiHang);
            }
        }

        public static DanhSachMatHang TimMatHang(DanhSachMatHang a, string k)
        {
            DanhSachMatHang kq;
            kq.dsMathang = new MatHang[a.dsMathang.Length];

                for (int i = 0; i < a.dsMathang.Length; i++)
                {
                    if (a.dsMathang[i].MaHang.ToUpper().Contains(k.ToUpper()) || a.dsMathang[i].TenHang.ToUpper().Contains(k.ToUpper()) ||
                        a.dsMathang[i].CongTySanXuat.ToUpper().Contains(k.ToUpper()) || a.dsMathang[i].LoaiHang.ToUpper().Contains(k.ToUpper()) ||
                        a.dsMathang[i].HanDung.ToUpper().Contains(k.ToUpper()) || a.dsMathang[i].NamSanXuat.ToUpper().Contains(k.ToUpper()))
                    {

                        kq.dsMathang[i] = a.dsMathang[i];
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Khong Tim Thay Mat Hang");
                        Console.WriteLine();

                    }
                }
            
            return kq;
        }
        public static int MainDisplay()
        {
            int n;
            do
            {
                Console.WriteLine("\t\t\t\t QUAN LY CUA HANG");
                Console.WriteLine();
                Console.WriteLine("VUI LONG CHON CAC CHUC NANG SAU: ");
                Console.WriteLine();
                Console.WriteLine("1 : THEM MAT HANG");
                Console.WriteLine("2 : THEM LOAI HANG");
                Console.WriteLine("3 : TIM KIEM MAT HANG");
                Console.WriteLine("4 : TIM KIEM LOAI HANG");
                Console.WriteLine("5 : THOAT");
                Console.WriteLine();
                Console.Write("CHON CHUC NANG: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 5)
                {
                    Console.WriteLine("VUI LONG CHON CAC CHUC NANG TU 1 -> 5");
                }
                Console.WriteLine();
            } while (n < 0 || n > 5);

            return n;
        }
        public static DanhSachMatHang ThemLoaiHang(DanhSachMatHang a)
        {

            DanhSachMatHang kq;

            Console.Write("SO LUONG CAN THEM: ");
            int n = int.Parse(Console.ReadLine());
            kq.dsMathang = new MatHang[a.dsMathang.Length + n];
            for (int j = 0; j < a.dsMathang.Length; j++)
            {
                kq.dsMathang[j] = a.dsMathang[j];
            }

            for (int i = a.dsMathang.Length; i < kq.dsMathang.Length; i++)
            {
                Console.Write("NHAP LOAI HANG: ");

                kq.dsMathang[i].LoaiHang = Console.ReadLine();

            }
            return kq;
        }
        public static DanhSachMatHang SuaLoaiHang(DanhSachMatHang a, string key, string change)
        {

            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                if (a.dsMathang[i].LoaiHang.ToUpper().Contains(key.ToUpper()))
                {
                    a.dsMathang[i].LoaiHang = change;
                }
            }
            return a;
        }
        public static DanhSachMatHang XoaLoaiHang(DanhSachMatHang a, string key)
        {
            DanhSachMatHang kq;
            kq.dsMathang = new MatHang[a.dsMathang.Length - 1];

            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                if (a.dsMathang[i].LoaiHang.ToUpper().Equals(key.ToUpper()))
                {
                    if (i <= a.dsMathang.Length)
                    {
                        int j = i;
                        while (j < a.dsMathang.Length - 1)
                        {
                            a.dsMathang[j] = a.dsMathang[j + 1];
                            j++;
                        }
                    }
                }

            }
            for (int i = 0; i < kq.dsMathang.Length; i++)
            {
                kq.dsMathang[i] = a.dsMathang[i];
            }
            return kq;
        }

        public static DanhSachMatHang TimLoaiHang(DanhSachMatHang a, string key)
        {

            DanhSachMatHang kq;
            kq.dsMathang = new MatHang[a.dsMathang.Length];
            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                if (a.dsMathang[i].LoaiHang.ToUpper().Equals(key.ToUpper()))
                {
                    kq.dsMathang[i] = a.dsMathang[i];
                }
            }
            return kq;
        }

        public static DanhSachMatHang SuaMatHang(DanhSachMatHang a, string key)
        {

            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                if (a.dsMathang[i].MaHang.ToUpper().Equals(key.ToUpper()))
                {
                    Console.Write("NHAP TEN HANG MOI: ");
                    string tenhang = Console.ReadLine();
                    if (tenhang == "")
                    {
                        a.dsMathang[i].TenHang = a.dsMathang[i].TenHang;
                    }
                    else
                    {
                        a.dsMathang[i].TenHang = tenhang;
                    }

                    Console.Write("NHAP HAN DUNG MOI: ");
                    string handung = Console.ReadLine();
                    if (handung == "")
                    {
                        a.dsMathang[i].HanDung = a.dsMathang[i].HanDung;
                    }
                    else
                    {
                        a.dsMathang[i].HanDung = handung;
                    }
                    Console.Write("NHAP CONG TY SAN XUAT MOI: ");
                    string ctSanXuat = Console.ReadLine();
                    if (ctSanXuat == "")
                    {
                        a.dsMathang[i].CongTySanXuat = a.dsMathang[i].CongTySanXuat;
                    }
                    else
                    {
                        a.dsMathang[i].CongTySanXuat = ctSanXuat;
                    }

                    Console.Write("NHAP NAM SAN XUAT MOI: ");
                    string NamSanXuat = Console.ReadLine();
                    if (NamSanXuat == "")
                    {
                        a.dsMathang[i].NamSanXuat = a.dsMathang[i].NamSanXuat;
                    }
                    else
                    {
                        a.dsMathang[i].NamSanXuat = NamSanXuat;
                    }

                    Console.Write("NHAP LOAI HANG MOI: ");
                    string loaihang = Console.ReadLine();
                    if (loaihang == "")
                    {
                        a.dsMathang[i].LoaiHang = a.dsMathang[i].LoaiHang;
                    }
                    else
                    {
                        a.dsMathang[i].LoaiHang = loaihang;
                    }

                }
            }
            return a;
        }
        public static DanhSachMatHang XoaMatHang(DanhSachMatHang a, string key)
        {
            DanhSachMatHang kq;
            kq.dsMathang = new MatHang[a.dsMathang.Length - 1];

            for (int i = 0; i < a.dsMathang.Length; i++)
            {
                if (a.dsMathang[i].MaHang.ToUpper().Equals(key.ToUpper()))
                {
                    if (i <= a.dsMathang.Length)
                    {
                        int j = i;
                        while (j < a.dsMathang.Length - 1)
                        {
                            a.dsMathang[j] = a.dsMathang[j + 1];
                            j++;
                        }
                    }
                }

            }
            for (int i = 0; i < kq.dsMathang.Length; i++)
            {
                kq.dsMathang[i] = a.dsMathang[i];
            }
            return kq;
        }
        public static void ChonChucNang(int n, DanhSachMatHang a)
        {
            switch (n)
            {
                case 1:
                    a = ThemDanhSach();
                    XuatMatHang(a);
                    Console.WriteLine();
                    Console.Write("CHON Y: QUAY VE MAN HINH CHINH: ");
                    Console.WriteLine();
                    Console.Write("CHON S: SUA MAT HANG: ");
                    Console.WriteLine();
                    Console.Write("CHON x: XOA MAT HANG: ");
                    Console.WriteLine();
                    Console.Write("CHON N: THOAT CHUONG TRINH: ");
                    string b = Console.ReadLine();
                    if (b.ToUpper().Equals("Y"))
                    {
                        ChonChucNang(MainDisplay(), a);
                    }
                    if (b.ToUpper().Equals("S"))
                    {
                        Console.Write("NHAP MA HANG CUA MAT HANG CAN SUA: ");
                        string key = Console.ReadLine();
                        a = SuaMatHang(a, key);
                        XuatMatHang(a);
                    }
                    if (b.ToUpper().Equals("X"))
                    {
                        Console.Write("NHAP MA HANG CUA MAT HANG CAN XOA: ");
                        string key = Console.ReadLine();
                        a = XoaMatHang(a, key);
                        XuatMatHang(a);
                    }
                    if (b.ToUpper().Equals("N"))
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }

                    break;
                case 2:
                    a = ThemLoaiHang(a);
                    XuatMatHang(a);
                    Console.Write("NHAP S: SUA LOAI HANG: ");
                    Console.WriteLine();
                    Console.Write("NHAP x: XOA LOAI HANG: ");
                    string choose = Console.ReadLine();
                    if (choose.ToUpper().Equals("S"))
                    {
                        Console.Write("NHAP LOAI HANG CAN SUA: ");
                        string key = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("NHAP LOAI HANG THAY THE: ");
                        string change = Console.ReadLine();
                        a = SuaLoaiHang(a, key, change);
                        XuatMatHang(a);
                    }
                    if (choose.ToUpper().Equals("X"))
                    {
                        Console.Write("NHAP LOAI HANG CAN XOA: ");
                        string key = Console.ReadLine();
                        a = XoaLoaiHang(a, key);
                        XuatMatHang(a);
                    }
                    break;
                case 3:
                    Console.Write("NHAP MAT HANG CAN TIM: ");
                    string k = Console.ReadLine();
                    XuatMatHang(TimMatHang(a, k));
                    Console.WriteLine();
                    Console.Write("CHON S: SUA MAT HANG: ");
                    Console.WriteLine();
                    Console.Write("CHON X: XOA MAT HANG: ");
                    Console.WriteLine();
                    Console.Write("CHON N: THOAT CHUONG TRINH: ");
                    string t = Console.ReadLine();
                    if (t.ToUpper().Equals("Y"))
                    {
                        ChonChucNang(MainDisplay(), a);
                    }
                    if (t.ToUpper().Equals("S"))
                    {
                        Console.Write("NHAP MA HANG CUA MAT HANG CAN SUA: ");
                        string key = Console.ReadLine();
                        a = SuaMatHang(a, key);
                        XuatMatHang(a);
                    }
                    if (t.ToUpper().Equals("X"))
                    {
                        Console.Write("NHAP MA HANG CUA MAT HANG CAN XOA: ");
                        string key = Console.ReadLine();
                        a = XoaMatHang(a, key);
                        XuatMatHang(a);
                    }
                    if (t.ToUpper().Equals("N"))
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    break;
                case 4:
                    Console.Write("LOAI HANG CAN TIM: ");
                    string loai = Console.ReadLine();
                    a = TimLoaiHang(a, loai);
                    XuatMatHang(a);

                    Console.Write("NHAP S: SUA LOAI HANG: ");
                    Console.WriteLine();
                    Console.Write("NHAP x: XOA LOAI HANG: ");
                    string c = Console.ReadLine();
                    if (c.ToUpper().Equals("S"))
                    {
                        Console.Write("NHAP LOAI HANG CAN SUA: ");
                        string key = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("NHAP LOAI HANG THAY THE: ");
                        string change = Console.ReadLine();
                        a = SuaLoaiHang(a, key, change);
                        XuatMatHang(a);
                    }
                    if (c.ToUpper().Equals("X"))
                    {
                        Console.Write("NHAP LOAI HANG CAN XOA: ");
                        string key = Console.ReadLine();
                        a = XoaLoaiHang(a, key);
                        XuatMatHang(a);
                    }
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            DanhSachMatHang a = new DanhSachMatHang();
            int n = MainDisplay();
            ChonChucNang(n, a);



            Console.ReadKey();
        }
    }
}
