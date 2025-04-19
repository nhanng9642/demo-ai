using System;
namespace DO_AN_NMLT
{
    public class SUA_MAT_HANG
    {
        public static HANGHOA[] SUATTLOAIHANG(HANGHOA[] A, HANGHOA[] B, int m)
        {
            bool check = true;
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Loai_Hang == "")
                {
                    index = i;
                    check = false;
                    break;
                }
            }
            while (m > 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (check == false)
                    {
                        Console.Write("NHAP TEN LOAI HANG MOI:");
                        A[index].Loai_Hang = Console.ReadLine();
                        break;
                    }
                    else if (check)
                    {
                        Console.Write("NHAP TEN LOAI HANG MUON THAY THE:");
                        string lh = Console.ReadLine();
                        XOA_MAT_HANG.XOA_LOAIHANG(A, B, lh);
                        Console.Write("NHAP LOAI HANG MUON THAY DOI:");
                        string L = Console.ReadLine();
                        for (int j = 0; j < A.Length; j++)
                        {
                            if (A[j].Loai_Hang == "")
                            {
                                A[j].Loai_Hang = L;
                            }
                        }
                    }
                }
                m--;
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
        public static HANGHOA[] SUATHONGTIN(HANGHOA[] A, int m)
        {
            bool check = true;
            int index = 0;
            for (int e = 0; e < A.Length; e++)
            {
                if (A[e].Ma_hang == 0)
                {
                    index = e;
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            while (m > 0)
            {
                Console.Write("NHAP MA HANG CAN SUA:");
                int x = int.Parse(Console.ReadLine());
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Ma_hang == x && check == true)
                    {
                        Console.WriteLine("NHAP SL CHI TIET MUON THAY DOI:");
                        int count = int.Parse(Console.ReadLine());
                        Console.WriteLine("CHON CHI TIET MUON THAY DOI:");
                        Console.WriteLine("1:THAY DOI TEN MAT HANG:");
                        Console.WriteLine("2:THAY DOI TEN DON VI SAN XUAT");
                        Console.WriteLine("3:THAY DOI LOAI MAT HANG");
                        Console.WriteLine("4:THAY DOI NAM SAN XUAT");
                        Console.WriteLine("5:THAY DOI HAN SU DUNG");
                        int detail = int.Parse(Console.ReadLine());
                            switch (detail)
                            {
                                case 1:
                                    Console.Write("THAY DOI TEN MAT HANG:");
                                    A[i].Ten_mat_hang = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("THAY DOI DON VI SAN XUAT:");
                                    A[i].Cong_ty_SX = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("THAY DOI LOAI SAN PHAM:");
                                    A[i].Loai_Hang = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("THAY DOI THOI GIAN SAN XUAT-NGAY D:");
                                    A[i].Nam_SX.ngay = int.Parse(Console.ReadLine());
                                    Console.Write("THAY DOI GIAN SAN XUAT-THANG M:");
                                    A[i].Nam_SX.thang = int.Parse(Console.ReadLine());
                                    Console.Write("THAY DOI GIAN SAN XUAT-NAM YYYY:");
                                    A[i].Nam_SX.nam = int.Parse(Console.ReadLine());
                                    break;
                                case 5:
                                    Console.Write("THAY DOI HAN SU DUNG-NGAY D:");
                                    A[i].Han_su_dung.ngay = int.Parse(Console.ReadLine());
                                    Console.Write("THAY DOI HAN SU DUNG-THANG M:");
                                    A[i].Han_su_dung.thang = int.Parse(Console.ReadLine());
                                    Console.Write("THAY DOI HAN SU DUNG-NAM YYYY:");
                                    A[i].Han_su_dung.nam = int.Parse(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("KHONG CAN THAY DOI THONG TIN MAT HANG NAY:");
                                    break;
                            }
                            count++;
                        }
                    else if (check == true && A[i].Ma_hang != x)
                    {
                        Console.Write("CHON MAT HANG ĐE THAY THE:");
                        int z = int.Parse(Console.ReadLine());
                        A = XOA_MAT_HANG.XOA_HANG_HOA(A, z);
                        i = z - 1;
                        Console.WriteLine("CAP NHAT LAI MA MAT HANG:" + x);
                        A[i].Ma_hang = x;
                        Console.Write("NHAP TEN MAT HANG MOI:");
                        A[i].Ten_mat_hang = Console.ReadLine();
                        Console.Write("NHAP TEN DON VI SAN XUAT:");
                        A[i].Cong_ty_SX = Console.ReadLine();
                        Console.Write("NHAP LOAI MAT HANG:");
                        A[i].Loai_Hang = Console.ReadLine();
                        Console.Write("NHAP THOI GIAN SAN XUAT-NGAY D:");
                        A[i].Nam_SX.ngay = int.Parse(Console.ReadLine());
                        Console.Write("NHAP THOI GIAN SAN XUAT-THANG M:");
                        A[i].Nam_SX.thang = int.Parse(Console.ReadLine());
                        Console.Write("NHAP THOI GIAN SAN XUAT-NAM YYYY:");
                        A[i].Nam_SX.nam = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-NGAY D:");
                        A[i].Han_su_dung.ngay = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-THANG M:");
                        A[i].Han_su_dung.thang = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-NAM YYYY:");
                        A[i].Han_su_dung.nam = int.Parse(Console.ReadLine());
                        break;
                    }
                    else if (check == false)
                    {
                        Console.WriteLine("CAP NHAT LAI MA MAT HANG:" + x);
                        A[index].Ma_hang = x;
                        Console.Write("NHAP TEN MAT HANG MOI:");
                        A[index].Ten_mat_hang = Console.ReadLine();
                        Console.Write("NHAP TEN DON VI SAN XUAT:");
                        A[index].Cong_ty_SX = Console.ReadLine();
                        Console.Write("NHAP LOAI MAT HANG:");
                        A[index].Loai_Hang = Console.ReadLine();
                        Console.Write("NHAP THOI GIAN SAN XUAT-NGAY D:");
                        A[index].Nam_SX.ngay = int.Parse(Console.ReadLine());
                        Console.Write("NHAP THOI GIAN SAN XUAT-THANG M:");
                        A[index].Nam_SX.thang = int.Parse(Console.ReadLine());
                        Console.Write("NHAP THOI GIAN SAN XUAT-NAM YYYY:");
                        A[index].Nam_SX.nam = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-NGAY D:");
                        A[index].Han_su_dung.ngay = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-THANG M:");
                        A[index].Han_su_dung.thang = int.Parse(Console.ReadLine());
                        Console.Write("NHAP HAN SU DUNG-NAM YYYY:");
                        A[index].Han_su_dung.nam = int.Parse(Console.ReadLine());
                        break;
                    }
                }
                m--;
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





