using System;
using System.Collections.Generic;
using System.Text;

namespace QUAN_LY_CUA_HANG_NMLT_1988333
{
    public struct DATE
    {
        public int Ngay;
        public int Thang;
        public int Nam;
    }
    public struct MatHang
    {
        public int IDmh;
        public string TenMH;
        public DATE HanDung;
        public string CtySX;
        public int NamSX;
        public string LoaiHang;
    }
    public struct LOAIHANG
    {
        public string Ten_LH;
        public int SoLuong_MH;
        public List<MatHang> DSach_MH;
    }
    public class XL_QL_CUA_HANG
    {
        public static MatHang NhapTT_MH(List<MatHang> J)
        {
            int maxID = 0;
            for (int i = 0; i < J.Count; i++)
                if (maxID < J[i].IDmh) maxID = J[i].IDmh;
            MatHang A;
            A.IDmh = maxID + 1;
            Console.WriteLine("Nhap ten mat hang");
            A.TenMH = Console.ReadLine();
            Console.WriteLine("Nhap han su dung");
            Console.WriteLine("Nhap ngay");
            A.HanDung.Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            A.HanDung.Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            A.HanDung.Nam = int.Parse(Console.ReadLine());
            while (kiemtrahople(A.HanDung) == false)
            {
                Console.WriteLine("Du lieu thoi gian khong dung, vui long nhap lai:");
                Console.WriteLine("Nhap han su dung");
                Console.WriteLine("Nhap ngay");
                A.HanDung.Ngay = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang");
                A.HanDung.Thang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap nam");
                A.HanDung.Nam = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap cong ty san xuat");
            A.CtySX = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat");
            A.NamSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai hang");
            A.LoaiHang = Console.ReadLine();
            return A;
        }
        public static void XuatTT_MH(MatHang A)
        {
            Console.WriteLine("ID mat hang: " + A.IDmh + ", Ten mat hang: " + A.TenMH
                + ", Han dung: " + A.HanDung.Ngay + " - " + A.HanDung.Thang + " - " + A.HanDung.Nam);
            Console.WriteLine("Cong ty san xuat: " + A.CtySX + ", Nam san xuat: " + A.NamSX
                + ", Loai hang: " + A.LoaiHang);
        }
        public static void XuatTT_List_MH(List<MatHang> A)
        {
            for(int i = 0; i < A.Count; i++)
            {
                XuatTT_MH(A[i]);
                Console.WriteLine();
            }
        }
        public static List<MatHang> TimMH(List<MatHang> A,string a)
        {
            var B = new List<MatHang>();
            for (int i = 0; i < A.Count; i++)
                if (A[i].IDmh.ToString().Contains(a) || A[i].TenMH.Contains(a)
                    || A[i].HanDung.Ngay.ToString().Contains(a)
                    || A[i].HanDung.Thang.ToString().Contains(a)
                    || A[i].HanDung.Nam.ToString().Contains(a)
                    || A[i].CtySX.Contains(a) || A[i].NamSX.ToString().Contains(a)
                    || A[i].LoaiHang.Contains(a)) B.Add(A[i]);
            return B;
        }
        public static List<MatHang> XoaMH(List<MatHang> A,int l)
        {
            for (int i = 0; i < A.Count; i++)
                if (A[i].IDmh == l) A.Remove(A[i]);
            return A;
        }
        public static List<MatHang> ChinhSua_MH(List<MatHang> J,int l)
        {
            MatHang A;
            A.IDmh = l;
            Console.WriteLine("Nhap ten mat hang");
            A.TenMH = Console.ReadLine();
            Console.WriteLine("Nhap han su dung");
            Console.WriteLine("Nhap ngay");
            A.HanDung.Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            A.HanDung.Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            A.HanDung.Nam = int.Parse(Console.ReadLine());
            while (kiemtrahople(A.HanDung) == false)
            {
                Console.WriteLine("Du lieu thoi gian khong dung, vui long nhap lai:");
                Console.WriteLine("Nhap han su dung");
                Console.WriteLine("Nhap ngay");
                A.HanDung.Ngay = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang");
                A.HanDung.Thang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap nam");
                A.HanDung.Nam = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap cong ty san xuat");
            A.CtySX = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat");
            A.NamSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loai hang");
            A.LoaiHang = Console.ReadLine();
            for (int i = 0; i < J.Count; i++)
                if (J[i].IDmh == l) J[i] = A;
            return J;
        }
        public static bool kiemtrahople(DATE A)
        {
            if (A.Nam < 1900 || A.Nam > 2030) return false;
            else
            {
                if (A.Thang < 1 || A.Thang > 12) return false;
                else
                {
                    if (A.Ngay < 1 || A.Ngay > 31) return false;
                    else
                    {
                        if (A.Thang == 4 || A.Thang == 6 || A.Thang == 9 || A.Thang == 11)
                        {
                            if (A.Ngay > 30) return false;
                            else return true;
                        }
                        if (A.Thang == 2 && KTNamNhuan(A))
                        {
                            if (A.Ngay > 29) return false;
                            else return true;
                        }
                        if (A.Thang == 2 && !KTNamNhuan(A))
                        {
                            if (A.Ngay > 28) return false;
                            else return true;
                        }
                        else return true;
                    }
                }
            }
        }
        public static bool KTNamNhuan(DATE A)
        {
            if (A.Nam % 400 == 0 || (A.Nam % 100 != 0 && A.Nam % 4 == 0)) return true;
            return false;
        }
        public static bool KT_Tengiongnhau(List<string> A, string a)
        {
            for(int i=0;i<A.Count;i++) 
                if (A[i] == a) return true;
            return false;
        }
        public static List<string> Get_DSTen_LH(List<MatHang> A)
        {
            var J = new List<string>();
            J.Add(A[0].LoaiHang);
            for (int i = 1; i < A.Count; i++)
                if (KT_Tengiongnhau(J, A[i].LoaiHang) == false) J.Add(A[i].LoaiHang);
            return J;
        }
        public static LOAIHANG Get_LH(List<MatHang> A,string a)
        {
            LOAIHANG B;
            B.Ten_LH = a;
            B.DSach_MH = new List<MatHang>();
            for (int i = 0; i < A.Count; i++)
                if (A[i].LoaiHang == a) B.DSach_MH.Add(A[i]);
            B.SoLuong_MH = B.DSach_MH.Count;
            return B;
        }
        public static List<LOAIHANG> GetDS_LH(List<MatHang> A)
        {
            var B = new List<LOAIHANG>();
            var listTen = Get_DSTen_LH(A);
            for (int i = 0; i < listTen.Count; i++)
            {
                B.Add(Get_LH(A, listTen[i]));
            }
            return B;
        }
        public static LOAIHANG GetLH_from_ListLH(List<LOAIHANG> A,string a)
        {
            int i; var lh = new LOAIHANG();
            for (i = 0; i < A.Count; i++)
                if (A[i].Ten_LH == a)
                {
                    lh = A[i];
                    break;
                }
            return lh;
        }
        public static void XuatTT_LH(LOAIHANG A)
        {
            Console.WriteLine("**Loai hang: " + A.Ten_LH + ", So luong mat hang: " + A.SoLuong_MH);
            Console.Write("  Cac mat hang: ");
            for (int i = 0; i < A.DSach_MH.Count - 1; i++)
                Console.Write(A.DSach_MH[i].TenMH + ", ");
            Console.Write(A.DSach_MH[A.DSach_MH.Count - 1].TenMH);
        }
        public static void XuatTT_DS_LH(List<LOAIHANG> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                XuatTT_LH(A[i]);
                Console.WriteLine();
            }
        }
        public static List<LOAIHANG> TimKiem_LH(List<LOAIHANG> A,string a)
        {
            var B = new List<LOAIHANG>();
            for(int i = 0; i < A.Count; i++)
            {
                if (A[i].Ten_LH.Contains(a) || A[i].SoLuong_MH.ToString().Contains(a))
                    B.Add(A[i]);
                for(int j = 0; j < A[i].DSach_MH.Count; j++)
                {
                    if ((A[i].DSach_MH[j].IDmh.ToString().Contains(a)
                        || A[i].DSach_MH[j].TenMH.Contains(a)
                        || A[i].DSach_MH[j].CtySX.Contains(a)
                        || A[i].DSach_MH[j].NamSX.ToString().Contains(a))
                        && KT_LoaiHang_GiongNhau(B, A[i]) == false)
                        B.Add(A[i]);
                }
            }
            return B;
        }
        public static bool KT_LoaiHang_GiongNhau(List<LOAIHANG> A,LOAIHANG a)
        {
            for (int i = 0; i < A.Count; i++)
                if (A[i].Ten_LH == a.Ten_LH) return true;
            return false;
        }
        public static List<LOAIHANG> Them_LH(List<MatHang> J,string tenlh,int sl)
        {
            for(int i = 0; i < sl; i++)
            {
                var A = new MatHang();
                Console.WriteLine(" - Mat hang " + (i + 1));
                A.IDmh = Get_MaxID(J) + 1;
                Console.WriteLine("Nhap ten mat hang");
                A.TenMH = Console.ReadLine();
                Console.WriteLine("Nhap han su dung");
                Console.WriteLine("Nhap ngay");
                A.HanDung.Ngay = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang");
                A.HanDung.Thang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap nam");
                A.HanDung.Nam = int.Parse(Console.ReadLine());
                while (kiemtrahople(A.HanDung) == false)
                {
                    Console.WriteLine("Du lieu thoi gian khong dung, vui long nhap lai:");
                    Console.WriteLine("Nhap han su dung");
                    Console.WriteLine("Nhap ngay");
                    A.HanDung.Ngay = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap thang");
                    A.HanDung.Thang = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap nam");
                    A.HanDung.Nam = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Nhap cong ty san xuat");
                A.CtySX = Console.ReadLine();
                Console.WriteLine("Nhap nam san xuat");
                A.NamSX = int.Parse(Console.ReadLine());
                A.LoaiHang = tenlh;
                J.Add(A);
            }
            return GetDS_LH(J);
        }
        public static List<LOAIHANG> Update_DS_LH(List<MatHang> listMH, string tenlh, int sl)
        {
            var LH = new LOAIHANG();
            LH.Ten_LH = tenlh;
            LH.SoLuong_MH = sl;
            LH.DSach_MH = new List<MatHang>();
            for (int i = 0; i < sl; i++)
            {
                var A = new MatHang();
                Console.WriteLine(" - Mat hang " + (i + 1));
                Console.WriteLine("Nhap ID mat hang");
                A.IDmh = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten mat hang");
                A.TenMH = Console.ReadLine();
                Console.WriteLine("Nhap han su dung");
                Console.WriteLine("Nhap ngay");
                A.HanDung.Ngay = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang");
                A.HanDung.Thang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap nam");
                A.HanDung.Nam = int.Parse(Console.ReadLine());
                while (kiemtrahople(A.HanDung) == false)
                {
                    Console.WriteLine("Du lieu thoi gian khong dung, vui long nhap lai:");
                    Console.WriteLine("Nhap han su dung");
                    Console.WriteLine("Nhap ngay");
                    A.HanDung.Ngay = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap thang");
                    A.HanDung.Thang = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap nam");
                    A.HanDung.Nam = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Nhap cong ty san xuat");
                A.CtySX = Console.ReadLine();
                Console.WriteLine("Nhap nam san xuat");
                A.NamSX = int.Parse(Console.ReadLine());
                A.LoaiHang = tenlh;
                LH.DSach_MH.Add(A);
            }
            var ds_ten_LH = Get_DSTen_LH(listMH);
            if (KT_Tengiongnhau(ds_ten_LH, LH.Ten_LH) == true)
            {
                for (int i = 0; i < listMH.Count; i++)
                {
                    while (listMH[i].LoaiHang == LH.Ten_LH) listMH.Remove(listMH[i]);
                }
                for(int j = 0; j < LH.DSach_MH.Count; j++)
                {
                    listMH.Add(LH.DSach_MH[j]);
                }
                return GetDS_LH(listMH);
            }
            else
            {
                for (int k = 0; k < LH.DSach_MH.Count; k++)
                {
                    listMH.Add(LH.DSach_MH[k]);
                }
                return GetDS_LH(listMH);
            }
        }
        public static int Get_MaxID(List<MatHang> J)
        {
            int maxID = 0;
            for (int i = 0; i < J.Count; i++)
                if (maxID < J[i].IDmh) maxID = J[i].IDmh;
            return maxID;
        }
        public static List<LOAIHANG> XoaLoaiHang(List<MatHang> A,string a)
        {
            for (int i = 0; i < A.Count; i++)
            {
                while (A[i].LoaiHang == a) A.Remove(A[i]);
            }
            return GetDS_LH(A);
        }
    }
}
