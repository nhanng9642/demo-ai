using System;
namespace DO_AN_NMLT
{
    public struct HANGHOA
    {
        public string Ten_mat_hang;
        public int Ma_hang;
        public DATE Han_su_dung;
        public string Cong_ty_SX;
        public DATE Nam_SX;
        public string Loai_Hang;
        public struct DATE
        {
            public int ngay;
            public int thang;
            public int nam;
        }
    }
    public class THEMMOI
    {
        public static HANGHOA[] NhapLoaiHang(int n)
        {
            HANGHOA[] LOAIHANG = new HANGHOA[n];
            for (int i = 0; i < LOAIHANG.Length; i++)
            {
                Console.Write("NHAP LOẠI HANG:");
                LOAIHANG[i].Loai_Hang = Console.ReadLine();
            }
            return LOAIHANG;
        }
        public static HANGHOA[] NhapHangHoa(int n)
        {
            HANGHOA[] Arr = new HANGHOA[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("NHAP THONG TIN HANG HOA:", i);
                Console.Write("NHAP MA HANG HOA:");
                Arr[i].Ma_hang = int.Parse(Console.ReadLine());
                Console.Write("NHAP TEN HANG HOA:", i);
                Arr[i].Ten_mat_hang = Console.ReadLine();
                Console.Write("NHAP TEN DON VI SAN XUAT:");
                Arr[i].Cong_ty_SX = Console.ReadLine();
                Console.Write("NHAP LOAI HANG:");
                Arr[i].Loai_Hang = Console.ReadLine();
                Console.Write("NHAP THOI GIAN SAN XUAT-NGAY D:");
                Arr[i].Nam_SX.ngay = int.Parse(Console.ReadLine());
                Console.Write("NHAP THOI GIAN SAN XUAT-THANG M:");
                Arr[i].Nam_SX.thang = int.Parse(Console.ReadLine());
                Console.Write("NHAP THOI GIAN SAN XUAT-NAM YYYY:");
                Arr[i].Nam_SX.nam = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-NGAY D:");
                Arr[i].Han_su_dung.ngay = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-THANG M:");
                Arr[i].Han_su_dung.thang = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-NAM YYYY:");
                Arr[i].Han_su_dung.nam = int.Parse(Console.ReadLine());
            }
            return Arr;
        }
        public static void XUATTTLOAIHANG(HANGHOA[] LOAIHANG)
        {
            Console.WriteLine("THONG TIN CHI TIET PHAN LOAI HANG HOA:");
            for (int i = 0; i < LOAIHANG.Length; i++)
            {
                Console.Write("LOAI HANG HOA:" + LOAIHANG[i].Loai_Hang + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void XUATTTHANGHOA(HANGHOA[] A)
        {
            Console.WriteLine("THONG TIN CHI TIET CAC MAT HANG:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("MA HANG:" + A[i].Ma_hang + " ");
                Console.Write("TEN HANG:" + A[i].Ten_mat_hang + " ");
                Console.Write("DON VI SAN XUAT:" + A[i].Cong_ty_SX + " ");
                Console.Write("LOAI HANG:" + A[i].Loai_Hang + " ");
                Console.Write($"NAM SAN XUAT:{A[i].Nam_SX.ngay}/{A[i].Nam_SX.thang}/{A[i].Nam_SX.nam}  ");
                Console.Write($"HAN SU DUNG:{A[i].Han_su_dung.ngay}/{A[i].Han_su_dung.thang}/{A[i].Han_su_dung.nam}  ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static HANGHOA[] TANG_KICH_THUOT_LH(HANGHOA[] Arr, int n)
        {
            HANGHOA[] A = new HANGHOA[Arr.Length + n];
            for (int j = 0; j < Arr.Length; j++)
            {
                A[j].Loai_Hang = Arr[j].Loai_Hang;
            }
            return A;
        }
        public static HANGHOA[] TANG_KICH_THUOT_HH(HANGHOA[] Arr, int m)
        {
            HANGHOA[] A = new HANGHOA[Arr.Length + m];
            for (int j = 0; j < Arr.Length; j++)
            {
                A[j].Ma_hang = Arr[j].Ma_hang; ;
                A[j].Ten_mat_hang = Arr[j].Ten_mat_hang;
                A[j].Cong_ty_SX = Arr[j].Cong_ty_SX;
                A[j].Loai_Hang = Arr[j].Loai_Hang;
                A[j].Nam_SX = Arr[j].Nam_SX;
                A[j].Han_su_dung = Arr[j].Han_su_dung;
            }
            return A;
        }
        public static HANGHOA[] THEM_LOAI_HANG(HANGHOA[] Arr, int n)
        {
            HANGHOA[] A = TANG_KICH_THUOT_LH(Arr, n);
            for (int k = A.Length - n; k < A.Length; k++)
            {
                Console.WriteLine("NHAP LOAI HANG:");
                A[k].Loai_Hang = Console.ReadLine();
                for (int j = 0; j < k; j++)
                {
                    if (A[k].Loai_Hang == A[j].Loai_Hang)
                    {
                        Console.WriteLine("LOAI HANG VUA THEM DA TON TAI!");
                        A[k].Ma_hang = 0;
                        return A;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("LOAI HANG:" + A[i].Loai_Hang + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
            return A;
        }
        public static HANGHOA[] THEM_MAT_HANG_MOI(HANGHOA[] Arr, int m)
        {
            HANGHOA[] A = TANG_KICH_THUOT_HH(Arr, m);
            for (int k = A.Length - m; k < A.Length; k++)
            {
                Console.Write("NHAP MA HANG:");
                A[k].Ma_hang = int.Parse(Console.ReadLine());
                for (int j = 0; j < k; j++)
                {
                    if (A[k].Ma_hang == A[j].Ma_hang)
                    {
                        Console.Write("MA HANG VUA THEM DA TON TAI");
                        A[k].Ma_hang = 0;
                        return A;
                    }
                }
                Console.Write("NHAP TEN HANG:");
                A[k].Ten_mat_hang = Console.ReadLine();
                Console.Write("NHAP TEN DON VI SAN XUAT:");
                A[k].Cong_ty_SX = Console.ReadLine();
                Console.Write("NHAP LOAI HANG:");
                A[k].Loai_Hang = Console.ReadLine();
                Console.Write("NHAP THOI GIAN SAN XUAT-NGAY D:");
                A[k].Nam_SX.ngay = int.Parse(Console.ReadLine());
                Console.Write("NHAP THOI GIAN SAN XUAT-THANG M:");
                A[k].Nam_SX.thang = int.Parse(Console.ReadLine());
                Console.Write("NHAP THOI GIAN SAN XUAT-NAM YYYY:");
                A[k].Nam_SX.nam = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-NGAY D:");
                A[k].Han_su_dung.ngay = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-THANG M:");
                A[k].Han_su_dung.thang = int.Parse(Console.ReadLine());
                Console.Write("NHAP HAN SU DUNG-NAM YYYY:");
                A[k].Han_su_dung.nam = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("MA HANG:" + A[i].Ma_hang + " ");
                Console.Write("TEN HANG:" + A[i].Ten_mat_hang + " ");
                Console.Write("DON VI SAN XUAT:" + A[i].Cong_ty_SX + " ");
                Console.Write("LOAI HANG:" + A[i].Loai_Hang + " ");
                Console.Write($"NAM SAN XUAT:{A[i].Nam_SX.ngay}/{A[i].Nam_SX.thang}/{A[i].Nam_SX.nam}  ");
                Console.Write($"HAN SU DUNG:{A[i].Han_su_dung.ngay}/{A[i].Han_su_dung.thang}/{A[i].Han_su_dung.nam}  ");
                Console.WriteLine();
            }
            return A;
        }
    }
}


