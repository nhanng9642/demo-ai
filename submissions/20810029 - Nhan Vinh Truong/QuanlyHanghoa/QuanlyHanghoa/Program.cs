using System;

namespace QuanlyHanghoa
{
    class Program
    {
        static MATHANG Nhap1MatHang()
        {
            MATHANG p;
            Console.Write("    Nhap Ma So mat hang: ");
            p.Maso = Console.ReadLine();
            Console.Write("              Nhap Ten mat hang: ");
            p.TenHang = Console.ReadLine();
            Console.Write("              Nhap ten Loai mat hang: ");
            p.LoaiHang = Console.ReadLine();
            Console.Write("              Nhap ten Cong ty san xuat: ");
            p.Congtysanxuat = Console.ReadLine();
            Console.Write("              Nhap ten Nam san xuat: ");
            p.Namsanxuat = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            return p; 
        }

        static void Xuat1MatHang(MATHANG p)
        {
           
            Console.WriteLine("         Ma So mat hang   :  "+ p.Maso);
            Console.WriteLine("         Ten mat hang     :  "+ p.TenHang);
            Console.WriteLine("         Loai mat hang    :  "+ p.LoaiHang);
            Console.WriteLine("         Cong ty san xuat :  "+ p.Congtysanxuat);  
            Console.WriteLine("         Nam san xuat     :  "+ p.Namsanxuat);
            Console.WriteLine("---------------------------------");

        }

        static MATHANG[] NhapNhieuMatHang(MATHANG[] a, int n)
        {
            
            
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Mat hang {0}", i+1);
                a[i] = Nhap1MatHang();
            }    
            return a; 
        }

        static void XuatNhieuMatHang(MATHANG[] a, int n)   
        {                                
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mat hang {0}", i + 1);
                Xuat1MatHang(a[i]);
                Console.WriteLine();
            }
        }

        static void TimKiemTheoTenMatHang(MATHANG[] a, int n, string b)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i].TenHang == b)
                {
                    Console.WriteLine("Mat Hang can tim kiem: ");
                    Xuat1MatHang(a[i]);
                    dem = dem + 1; 
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong co mat hang can tim kiem");
            }
        }

        static void TimKiemTheoTenLoaiHang(MATHANG[] a, int n, string c)
        {
            int Dem = 0;
            for (int j = 0; j < n; j++)
            {
                if (a[j].LoaiHang == c)
                {
                    Console.WriteLine("Loai Hang can tim kiem: ");
                    Xuat1MatHang(a[j]);
                    Dem = Dem + 1;
                }
            }
            if (Dem == 0)
            {
                Console.WriteLine("Khong co Loai hang can tim kiem");
            }
        }

        static void Them1MatHang(ref MATHANG[] A, MATHANG a, ref int n)
        {

            A[n] = a;
            n = n + 1; 
        }

        static void Xoa1MatHang(ref MATHANG[] A, ref int n, int vitri)
        {

            for (int i = vitri; i<n ; i++)
            {
                A[i] = A[i+1];
            }
            n = n - 1;
        }

        static void Sua1MatHang(ref MATHANG[] A, ref MATHANG a, int vitri)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ban muon sua muc nao: ");
            Console.WriteLine("    1. Ma so ");
            Console.WriteLine("    2. Ten hang ");
            Console.WriteLine("    3. Loai hang ");
            Console.WriteLine("    4. Cong ty san xuat ");
            Console.WriteLine("    5. Nam san xuat ");
            Console.WriteLine("---------------------------------");
            int luachon;
            Console.Write("Nhap lua chon: ");
            luachon = int.Parse(Console.ReadLine());
            if (luachon == 1)
            {
                Console.Write("Ma so moi: ");
                a.Maso = Console.ReadLine();
            }
            else if (luachon == 2)
            {
                Console.Write("Ten Hang moi: ");
                a.TenHang = Console.ReadLine();
            }
            else if (luachon == 3)
            {
                Console.Write("Loai hang moi: ");
                a.LoaiHang = Console.ReadLine();
            }
            else if (luachon == 4)
            {
                Console.Write("Cong ty san xuat moi: ");
                a.Congtysanxuat = Console.ReadLine();
            }
            else if (luachon == 5)
            {
                Console.Write("Nam san xuat moi: ");
                a.Namsanxuat = int.Parse(Console.ReadLine());
            }

        }

        static void Main(string[] args)
        {
            MATHANG[] a = new MATHANG[50];
            Console.WriteLine("Du lieu hien tai khong co Mat Hang nao !");
            Console.Write("Hay cho biet so luong mat hang dau tien se duoc nhap vao du lieu:  ");
            int n = int.Parse(Console.ReadLine());



            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== Lua chon ========");
                Console.WriteLine("1. Nhap lieu hang hoa ");
                Console.WriteLine("2. Hien thi hang hoa ");
                Console.WriteLine("3. Tim kiem theo ten mat hang");
                Console.WriteLine("4. Tim kiem theo ten loai hang");
                Console.WriteLine("5. Them 1 mat hang nao do");
                Console.WriteLine("6. Xoa 1 mat hang nao do");
                Console.WriteLine("7. Sua mot mat hang nao do");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Huong dan: de chuyen sang lua chon khac. Nhan Enter them 1 lan nua. ");
                Console.WriteLine("---------------------------------");
                int luachon;
                Console.Write("Nhap lua chon: ");
                luachon = int.Parse(Console.ReadLine());

                if (luachon == 1)
                {
                    Console.WriteLine("---------------------------------");
                    a = NhapNhieuMatHang(a,n); 
                    Console.ReadLine();
                }
                else if (luachon == 2)
                {
                    Console.WriteLine("---------------------------------");
                    XuatNhieuMatHang(a,n);
                    Console.ReadLine();
                }
                else if (luachon == 3)
                {
                    Console.WriteLine("---------------------------------");
                    Console.Write("Nhap vao ten Mat Hang muon tim kiem: ");
                    string p = Console.ReadLine();
                    TimKiemTheoTenMatHang(a, n, p);
                    Console.ReadLine();
                }
                else if (luachon == 4)
                {
                    Console.WriteLine("---------------------------------");
                    Console.Write("Nhap vao ten Loai Hang muon tim kiem: ");
                    string q = Console.ReadLine();
                    TimKiemTheoTenLoaiHang(a, n, q);
                    Console.ReadLine();
                }
                else if (luachon == 5)
                {
                    Console.WriteLine("---------------------------------");
                    //Console.Write("Nhap vao So Luong mat hang muon them: ");
                    // int them = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap thong tin Mat hang can them");
                    MATHANG x = Nhap1MatHang(); ;
                    Them1MatHang(ref a, x, ref n);
                    XuatNhieuMatHang(a, n);
                    Console.ReadLine();
                }
                else if (luachon == 6)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Ban muon xoa Mat hang thu may ? ");   
                    int vitri = int.Parse(Console.ReadLine());
                    vitri = vitri - 1; 
                    Xoa1MatHang(ref a, ref n, vitri);
                    XuatNhieuMatHang(a, n);
                    Console.ReadLine();
                }
                else if (luachon == 7)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Ban muon Sua mat hang thu may ? ");
                    int vitri = int.Parse(Console.ReadLine());
                    vitri = vitri - 1;
                    Sua1MatHang(ref a, ref a[vitri] ,vitri);
                    Console.WriteLine("---------------------------------");
                    XuatNhieuMatHang(a, n);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Lua chon khong ton tai");
                    break; 
                }

            }
        }
      
        struct MATHANG
        {
            public string Maso;
            public string TenHang;
            public string Congtysanxuat;
            public string LoaiHang;
            public int Namsanxuat;
        }






    }
}
