using System;
namespace DO_AN_NMLT
{
    public class XOA_MAT_HANG
    {
        public static HANGHOA[] XOA_LOAIHANG(HANGHOA[] A, HANGHOA[] B, string n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Loai_Hang == n)
                {
                    A[i].Loai_Hang = "";
                }
                for (int j = 0; j < B.Length; j++)
                {
                    if (B[j].Loai_Hang == n)
                    {
                        B[j].Loai_Hang = "";
                    }
                }
            }
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("MA HANG:" + B[j].Ma_hang + " ");
                Console.Write("TEN HANG:" + B[j].Ten_mat_hang + " ");
                Console.Write("LOAI HANG:" + B[j].Loai_Hang + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("LOAI HANG HOA:" + A[i].Loai_Hang + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
            return A;
        }
        public static HANGHOA[] XOA_HANG_HOA(HANGHOA[] A, int n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Ma_hang == n && n != 0)
                {
                    A[i].Ma_hang = 0;
                    A[i].Ten_mat_hang = "";
                    A[i].Cong_ty_SX = "";
                    A[i].Loai_Hang = "";
                    A[i].Nam_SX.ngay = 0;
                    A[i].Nam_SX.thang = 0;
                    A[i].Nam_SX.nam = 0;
                    A[i].Han_su_dung.ngay = 0;
                    A[i].Han_su_dung.thang = 0;
                    A[i].Han_su_dung.nam = 0;
                }
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
            Console.ReadLine();
            return A;
        }
    }
}
