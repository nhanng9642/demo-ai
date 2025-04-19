using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            HangHoa[] a;
            a = XL_HangHoa.TaoDanhMuc();
            XL_HangHoa.XuatDanhMuc(a);
            int chon = 0;
            while (chon != 5)
            {
                Console.WriteLine("CHON YEU CAU:");
                Console.WriteLine("Nhap 1 - them.");
                Console.WriteLine("Nhap 2 - xoa.");
                Console.WriteLine("Nhap 3 - sua.");
                Console.WriteLine("Nhap 4 - tim kiem.");
                Console.WriteLine("Nhap 5 - thoat chuong trinh.");
                chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                    {
                    int ChonThem = 0;
                    while (ChonThem != 3)
                    {
                        Console.WriteLine("Them Mat hang chon [1] - Them Loai hang [2] - Thoat [3]:");
                        ChonThem = int.Parse(Console.ReadLine());
                        if (ChonThem == 1)
                        {
                            a = XL_HangHoa.ThemHangVaoDanhMuc(a);
                            XL_HangHoa.XuatDanhMuc(a);
                        }
                        else if(ChonThem == 2)
                        {
                            a = XL_LoaiHang.ThemLoaiHang(a);
                            XL_HangHoa.XuatDanhMuc(a);
                        }
                    }
                    }
                    else
                    {
                        if (chon == 2)
                        {
                        int ChonThem = 0;
                        while (ChonThem != 3)
                        {
                            Console.WriteLine("Xoa theo Mat hang chon [1] - Xoa theo Loai hang [2] - Thoat [3]:");
                            ChonThem = int.Parse(Console.ReadLine());
                            if (ChonThem == 1)
                            {
                                a = XL_HangHoa.XoaHang(a);
                            }
                            else if (ChonThem == 2)
                            {
                                a = XL_LoaiHang.XoaLoaiHang(a);
                            }
                        }
                    }
                            else
                            {
                                if (chon == 3)
                                {
                                int ChonThem = 0;
                                while (ChonThem != 3)
                                    {
                                    Console.WriteLine("Sua Mat hang chon [1] - Sua Loai hang [2] - Thoat [3]:");
                                    ChonThem = int.Parse(Console.ReadLine());
                                    if (ChonThem == 1)
                                    {
                                        a = XL_HangHoa.SuaHangHoa(a);
                                    }
                                else if (ChonThem == 2)
                                    {
                                        a = XL_LoaiHang.SuaLoaiHang(a);
                                    }
                                }
                        }
                        else
                                    {
                                        if (chon == 4)
                                        {
                                            XL_HangHoa.TimKiem(a);
                                        }
                                    }
                            }
                    }
            }

        }
    }
}
