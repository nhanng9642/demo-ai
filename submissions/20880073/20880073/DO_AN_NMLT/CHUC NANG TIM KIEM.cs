using System;
namespace DO_AN_NMLT
{
    public class TIMKIEM
    {
        public static HANGHOA[] TIMKIEM_LOAIHANG(HANGHOA[] LOAIHANG, HANGHOA[] A, string s)
        {
            HANGHOA[] H = new HANGHOA[LOAIHANG.Length];

            for (int i = 0; i < LOAIHANG.Length; i++)
            {
                if (LOAIHANG[i].Loai_Hang == s && A[i].Loai_Hang == s)
                {
                    H[i].Loai_Hang = s;
                    H[i].Ten_mat_hang = A[i].Ten_mat_hang;
                }
            }
            for (int i = 0; i < LOAIHANG.Length; i++)
            {
                Console.Write("LOAI HANG:" + H[i].Loai_Hang + " ");
                Console.Write("TEN MAT HANG:" + H[i].Ten_mat_hang + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
            return H;
        }
        public static string[] LUUTRU(int x)
        {
            string[] S = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("NHAP VAO TEN MAT HANG CAN TIM:");
                S[i] = Console.ReadLine();
            }
            return S;
        }
        public static HANGHOA[] TIM_KIEM_MATHANG(HANGHOA[] A, string[] S)
        {
            HANGHOA[] B = new HANGHOA[A.Length];
            for (int j = 0; j < S.Length; j++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Ten_mat_hang == S[j])
                    {
                        B[j].Ma_hang = A[i].Ma_hang;
                        B[j].Ten_mat_hang = A[i].Ten_mat_hang;
                        B[j].Cong_ty_SX = A[i].Cong_ty_SX;
                        B[j].Loai_Hang = A[i].Loai_Hang;
                        B[j].Nam_SX.ngay = A[i].Nam_SX.ngay;
                        B[j].Nam_SX.thang = A[i].Nam_SX.thang;
                        B[j].Nam_SX.nam = A[i].Nam_SX.nam;
                        B[j].Han_su_dung.ngay = A[i].Han_su_dung.ngay;
                        B[j].Han_su_dung.thang = A[i].Han_su_dung.thang;
                        B[j].Han_su_dung.nam = A[i].Han_su_dung.nam;
                    }
                }
            }
            Console.ReadLine();
            return B;
        }
        public static void XUATDSTIMKIEM(HANGHOA[] B)
        {
            Console.WriteLine("DANH SACH HANG HOA CAN TIM:");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"MA HANG:{B[i].Ma_hang}  ");
                Console.Write($"TEN MAT HANG:{B[i].Ten_mat_hang}  ");
                Console.Write($"DON VI SAN XUAT:{B[i].Cong_ty_SX}  ");
                Console.Write($"LOAI HANG:{B[i].Loai_Hang}  ");
                Console.Write($"NAM SAN XUAT:{B[i].Nam_SX.ngay}/{B[i].Nam_SX.thang}/{B[i].Nam_SX.nam}  ");
                Console.Write($"HAN SU DUNG:{B[i].Han_su_dung.ngay}/{B[i].Han_su_dung.thang}/{B[i].Han_su_dung.nam}  ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}