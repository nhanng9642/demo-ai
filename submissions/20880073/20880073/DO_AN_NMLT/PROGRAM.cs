using System;
namespace DO_AN_NMLT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NHAP SO LUONG LOAI HANG:");
            int t = int.Parse(Console.ReadLine());
            HANGHOA[] LOAIHANG = THEMMOI.NhapLoaiHang(t);
            Console.Write("NHAP SO LUONG MAT HANG:");
            int n = int.Parse(Console.ReadLine());
            HANGHOA[] A = THEMMOI.NhapHangHoa(n);
            THEMMOI.XUATTTLOAIHANG(LOAIHANG);
            THEMMOI.XUATTTHANGHOA(A);
            Console.WriteLine("XIN MOI CHON THAO TAC:");
            Console.WriteLine("AN 1 DE THUC HIEN THEM-XOA-SUA-TIM KIEM MAT HANG:");
            Console.WriteLine("AN 2 DE THUC HIEN THEM-XOA-SUA-TIM KIEM LOAI HANG:");
            int o = int.Parse(Console.ReadLine());
            switch (o)
            {
                case 1:
                    Console.Write("THEM HANG HOA MOI VAO KHO:" + " y/n ?");
                    string req = Console.ReadLine();
                    if (req == "y")
                    {
                        Console.Write("NHAP SO LUONG CAN THEM:");
                        int m = int.Parse(Console.ReadLine());
                        A = THEMMOI.THEM_MAT_HANG_MOI(A, m);
                    }
                    else if (req == "n")
                    {
                        Console.WriteLine("TRONG KHO VAN CON HANG HOA:");
                    }
                    Console.Write("XOA MAT HANG " + " y/n ?");
                    string req1 = Console.ReadLine();
                    if (req1 == "y")
                    {
                        Console.Write("NHAP SO LUONG MAT HANG CAN XOA:");
                        int k = int.Parse(Console.ReadLine());
                        while (k > 0)
                        {
                            Console.Write("NHAP MA HANG CAN XOA:");
                            int l = int.Parse(Console.ReadLine());
                            A = XOA_MAT_HANG.XOA_HANG_HOA(A, l);
                            k--;
                        }
                    }
                    else if (req1 == "n")
                    {
                        Console.WriteLine("--------------------");
                    }
                    Console.Write("SUA THONG TIN HANG HOA:" + " y/n ?");
                    string req2 = Console.ReadLine();
                    if (req2 == "y")
                    {
                        Console.Write("NHAP SO LUONG MAT HANG CAN SUA:");
                        int y = int.Parse(Console.ReadLine());
                        A = SUA_MAT_HANG.SUATHONGTIN(A, y);
                    }
                    else
                    {
                        Console.WriteLine("---------------------");
                    }
                    Console.Write("TIM KIEM MAT HANG:" + " y/n ?");
                    string req3 = Console.ReadLine();
                    if (req3 == "y")
                    {
                        Console.Write("NHAP VAO SO LUONG MA HANG CAN TIM:");
                        int x = int.Parse(Console.ReadLine());
                        string[] S = TIMKIEM.LUUTRU(x);
                        HANGHOA[] B = TIMKIEM.TIM_KIEM_MATHANG(A, S);
                        TIMKIEM.XUATDSTIMKIEM(B);
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                    break;
                case 2:
                    Console.WriteLine("THEM-XOA-SUA-TIM KIEM LOAI HANG HOA:");
                    Console.Write("THEM LOAI HANG HOA MOI VAO KHO:" + " y/n ?");
                    string chon1 = Console.ReadLine();
                    if (chon1 == "y")
                    {
                        Console.Write("NHAP SO LUONG LOAI HANG CAN THEM:");
                        int s = int.Parse(Console.ReadLine());
                        LOAIHANG = THEMMOI.THEM_LOAI_HANG(LOAIHANG, s);
                    }
                    else if (chon1 == "n")
                    {
                        Console.WriteLine("-------------------");
                    }
                    Console.Write("XOA LOAI HANG" + " y/n ?");
                    string chon2 = Console.ReadLine();
                    if (chon2 == "y")
                    {
                        Console.Write("NHAP SO LUONG LOAI HANG CAN XOA:");
                        int s = int.Parse(Console.ReadLine());
                        while (s > 0)
                        {
                            Console.Write("NHAP LOAI HANG CAN XOA:");
                            string l = Console.ReadLine();
                            LOAIHANG = XOA_MAT_HANG.XOA_LOAIHANG(LOAIHANG, A, l);
                            s--;
                        }
                    }
                    else if (chon2 == "n")
                    {
                        Console.WriteLine("------------------");
                    }
                    Console.Write("SUA THONG TIN LOAI HANG:" + " y/n ?");
                    string chon3 = Console.ReadLine();
                    if (chon3 == "y")
                    {
                        Console.Write("NHAP SO LUONG LOAI HANG CAN SUA:");
                        int y = int.Parse(Console.ReadLine());
                        LOAIHANG = SUA_MAT_HANG.SUATTLOAIHANG(LOAIHANG, A, y);
                    }
                    else
                    {
                        Console.WriteLine("--------------------------");
                    }
                    Console.Write("TIM KIEM LOAI HANG:" + " y/n ?");
                    string chon4 = Console.ReadLine();
                    if (chon4 == "y")
                    {
                        Console.Write("NHAP VAO SO LUONG LOAI HANG CAN TIM:");
                        int x = int.Parse(Console.ReadLine());
                        HANGHOA[] H = new HANGHOA[x];
                        while (x > 0)
                        {
                            Console.Write("NHAP TEN LOAI HANG CAN TIM:");
                            string s = Console.ReadLine();
                            H = TIMKIEM.TIMKIEM_LOAIHANG(LOAIHANG, A, s);
                            x--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("-------------------------");
                    }
                    break;
            }
        }
    }
}
