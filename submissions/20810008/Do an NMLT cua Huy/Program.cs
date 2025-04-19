using System;

namespace Do_an_NMLT_cua_Huy
{
    class Program
    {
        static void Main(string[] args)
        {
            int boNhoLoaiHang; //dung de khoi tao array Loai Hang ban dau.
            int boNhoMatHang; //dung de khoi tao array Mat Hang ban dau.
            int viTriLoaiHang = 1; //Can co it nhat 1 loai hang tron co so du lieu de chay chuong trinh. Moi lan goi phuong thuc ThemLoaiHang(), viTriLoaiHang +1
            int viTriMatHang = 0;//Moi lan goi phuong thuc ThemMatHang(), viTriMatHang +1
            int lenh;
            int viTriSua;
            Console.WriteLine("Moi nhap so phan tu toi da cho loai hang (so tu nhien > 0): ");
            boNhoLoaiHang = int.Parse(Console.ReadLine());
            LoaiHang[] loaiHang = new LoaiHang[boNhoLoaiHang];
            Console.WriteLine("Moi nhap so phan tu toi da cho mat hang (so tu nhien > 0): ");
            boNhoMatHang = int.Parse(Console.ReadLine());
            MatHang[] matHang = new MatHang[boNhoMatHang];
            Console.WriteLine("Chu y: De chuong trinh chay lan dau can co it nhat 1 loai hang trong co so du lieu");
            loaiHang[0] = ThemLoaiHang(viTriLoaiHang);
            string thoat = "khong";
            while (thoat != "co")
            {
                lenh = 0;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Moi ban nhap so tuong ung voi lenh muon thuc hien: ");
                Console.WriteLine(">>>Thao tac voi mat hang:");
                Console.WriteLine("1. Them mat hang");
                Console.WriteLine("2. Sua mat hang");
                Console.WriteLine("3. Tim mat hang");
                Console.WriteLine("4. Xoa mat hang");
                Console.WriteLine(">>>Thao tac voi loai hang:");
                Console.WriteLine("5. Them loai hang");
                Console.WriteLine("6. Sua loai hang");
                Console.WriteLine("7. Tim loai hang");
                Console.WriteLine("8. Xoa loai hang");
                Console.WriteLine(">>>Thao tac khac:");
                Console.WriteLine("9. Hien danh sach mat hang");
                Console.WriteLine("10. Hien danh sach loai hang");
                Console.WriteLine("==========================================================================");
                lenh = int.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        Console.WriteLine("==========================================================================");
                        //them mat hang
                        matHang[viTriMatHang] = ThemMatHang(viTriMatHang, viTriLoaiHang, loaiHang);
                        viTriMatHang += 1;
                        Console.WriteLine("==========================================================================");
                        break;
                    case 2:
                        //sua mat hang. Can co it nhat 1 mat hang de thuc hien lenh.
                        Console.WriteLine("==========================================================================");
                        if (viTriMatHang == 0)
                        {
                            Console.WriteLine("Khong the sua vi chua co mat hang nao duoc tao");
                            Console.WriteLine("==========================================================================");
                        }
                        else
                        {
                            Console.WriteLine("Moi nhap ma so duoc may tao tu dong truoc dau || de chon mat hang ban muon sua");
                            for (int i = 0; i < viTriMatHang; i++)
                            {
                                Console.Write(i + " || ");
                                matHang[i].ShowMatHang();
                            }
                            viTriSua = int.Parse(Console.ReadLine());
                            matHang[viTriSua] = ThemMatHang(viTriSua, viTriLoaiHang, loaiHang);
                            Console.WriteLine("==========================================================================");
                        }                        
                        break;
                    case 3:
                        //tim kiem mat hang.
                        Console.WriteLine("==========================================================================");
                        timKiemMatHang(matHang, viTriMatHang, loaiHang);
                        Console.WriteLine("==========================================================================");
                        break;
                    case 4:
                        //xoa mat hang. Can co it nhat 1 mat hang trong co so du lieu de thuc hien lenh nay.
                        Console.WriteLine("==========================================================================");
                        if (viTriMatHang == 0)
                        {
                            Console.WriteLine("Khong the xoa vi chua co mat hang nao duoc tao");
                            Console.WriteLine("==========================================================================");
                        }
                        else
                        {
                            Console.WriteLine("Moi nhap ma so duoc may tao tu dong truoc dau || de chon mat hang ban muon xoa");
                            for (int i = 0; i < viTriMatHang; i++)
                            {
                                Console.Write(i + " || ");
                                matHang[i].ShowMatHang();
                            }
                            viTriSua = int.Parse(Console.ReadLine());
                            matHang[viTriSua].maMatHang = "Da xoa";
                            matHang[viTriSua].tenMatHang = "Da xoa";
                            matHang[viTriSua].giaTien = 0;
                            matHang[viTriSua].ngaySanXuat = "Da xoa";
                            matHang[viTriSua].ngayHetHan = "Da xoa";
                            matHang[viTriSua].tenNhaSanXuat = "Da xoa";
                            matHang[viTriSua].loaiHang.tenLoai = "Da xoa";
                            Console.WriteLine("Xoa mat hang thanh cong!");
                            Console.WriteLine("==========================================================================");
                        }
                        break;
                    case 5:
                        //them loai hang
                        Console.WriteLine("==========================================================================");
                        loaiHang[viTriLoaiHang] = ThemLoaiHang(viTriLoaiHang);
                        viTriLoaiHang += 1;
                        Console.WriteLine("==========================================================================");
                        break;
                    case 6:
                        //sua loai hang
                        Console.WriteLine("==========================================================================");
                        Console.WriteLine("Moi nhap ma so duoc may tao tu dong truoc dau || de chon loai hang ban muon sua");
                        for (int i = 0; i < viTriLoaiHang; i++)
                        {
                            Console.Write(i + " || ");
                            loaiHang[i].ShowLoaiHang();
                        }
                        viTriSua = int.Parse(Console.ReadLine());
                        loaiHang[viTriSua] = ThemLoaiHang(viTriSua);
                        Console.WriteLine("==========================================================================");
                        break;
                    case 7:
                        //tim loai hang
                        Console.WriteLine("==========================================================================");
                        TimLoaiHang(loaiHang, viTriLoaiHang);
                        Console.WriteLine("==========================================================================");
                        break;
                    case 8:
                        //xoa loai hang
                        Console.WriteLine("==========================================================================");
                        Console.WriteLine("Moi nhap ma so duoc may tao tu dong truoc dau || de chon mat hang ban muon xoa");
                        for (int i = 0; i < viTriLoaiHang; i++)
                        {
                            Console.Write(i + " || ");
                            loaiHang[i].ShowLoaiHang();
                        }
                        viTriSua = int.Parse(Console.ReadLine());
                        loaiHang[viTriSua].maLoai = "Da xoa";
                        loaiHang[viTriSua].tenLoai = "Da xoa";
                        Console.WriteLine("Xoa mat hang thanh cong!");
                        Console.WriteLine("==========================================================================");
                        break;
                    case 9:
                        //hien thi danh sach mat hang
                        Console.WriteLine("==========================================================================");
                        for (int i = 0; i < viTriMatHang; i++)
                        {
                            matHang[i].ShowMatHang();
                        }
                        Console.WriteLine("==========================================================================");
                        break;
                    case 10:
                        //hien thi danh sach loai hang
                        Console.WriteLine("==========================================================================");
                        for (int i = 0; i < viTriLoaiHang; i++)
                        {
                            loaiHang[i].ShowLoaiHang();
                        }
                        Console.WriteLine("==========================================================================");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Ban co muon thoat? co/khong");
                thoat = Console.ReadLine();
            }

        }

        public static void TimLoaiHang(LoaiHang[] loaiHang, int n)
        {
            string timKiem;
            int demKetQua = 0;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Nhap ky tu de mat dau tim kiem: ");
            timKiem = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (loaiHang[i].maLoai == timKiem)
                {
                    loaiHang[i].ShowLoaiHang();
                    demKetQua += 1;
                    continue;
                }
                else if (loaiHang[i].tenLoai == timKiem)
                {
                    loaiHang[i].ShowLoaiHang();
                    demKetQua += 1;
                    continue;
                }
                Console.WriteLine($"Tim thay {demKetQua} ket qua");                
            }
        }

        public static void timKiemMatHang(MatHang[] matHang, int n, LoaiHang[] loaiHang)
        {
            string timKiem;
            int demKetQua = 0;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Nhap ky tu de mat dau tim kiem: ");
            timKiem = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (matHang[i].maMatHang == timKiem)
                {
                    matHang[i].ShowMatHang();
                    demKetQua += 1;
                    continue;
                }
                else if (matHang[i].tenMatHang == timKiem)
                {
                    matHang[i].ShowMatHang();
                    demKetQua += 1;
                    continue;
                }
                else if (matHang[i].ngayHetHan == timKiem)
                {
                    matHang[i].ShowMatHang();
                    demKetQua += 1;
                    continue;
                }
                else if (matHang[i].ngaySanXuat == timKiem)
                {
                    matHang[i].ShowMatHang();
                    continue;
                }
                else if (matHang[i].tenNhaSanXuat == timKiem)
                {
                    matHang[i].ShowMatHang();
                    demKetQua += 1;
                    continue;
                }
                else if (matHang[i].loaiHang.tenLoai == timKiem)
                {
                    matHang[i].ShowMatHang();
                    demKetQua += 1;
                    continue;
                }                            
            }
            Console.WriteLine($"Tim thay {demKetQua} ket qua");
        }

        public static LoaiHang ThemLoaiHang(int n)
        {
            LoaiHang loaiHang = new LoaiHang();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Moi nhap thong tin loai hang: ");
            Console.WriteLine("Ma loai hang: ");
            loaiHang.maLoai = Console.ReadLine();
            Console.WriteLine("Ten loai hang: ");
            loaiHang.tenLoai = Console.ReadLine();
            Console.WriteLine("Thanh cong!");
            loaiHang.ShowLoaiHang();
            return loaiHang;
        }

        public static MatHang ThemMatHang(int n, int m, LoaiHang[] loaiHang)
        {
            MatHang matHang = new MatHang();
            Console.WriteLine("Moi nhap thong tin mat hang: ");
            Console.WriteLine("Ma mat hang: ");
            matHang.maMatHang = Console.ReadLine();
            Console.WriteLine("Ten mat hang: ");
            matHang.tenMatHang = Console.ReadLine();
            Console.WriteLine("Gia tien: ");
            matHang.giaTien = int.Parse(Console.ReadLine());
            Console.WriteLine("Ngay san xuat (yyyy-mm-dd): ");
            matHang.ngaySanXuat = Console.ReadLine();
            Console.WriteLine("Ngay het han(yyy-mm-dd): ");
            matHang.ngayHetHan = Console.ReadLine();
            Console.WriteLine("Ten nha san xuat: ");
            matHang.tenNhaSanXuat = Console.ReadLine();
            Console.WriteLine("Loai hang: ");
            Console.WriteLine("Moi nhap ma so duoc may tinh tao tu dong truoc dau || trong danh sach duoi day de chon loai hang***");
            for (int i = 0; i < m; i++)
            {
                Console.Write(i + " || ");
                loaiHang[i].ShowLoaiHang();
            }
            int t = int.Parse(Console.ReadLine());
            matHang.loaiHang = loaiHang[t];
            Console.WriteLine("Thanh cong!");
            matHang.ShowMatHang();
            return matHang;            
        }
    }

    
    public struct LoaiHang 
    {
        public string maLoai;
        public string tenLoai;
        public void ShowLoaiHang()
        {
            Console.WriteLine(maLoai + " " + tenLoai);
            Console.WriteLine("-------------------------------------");
        }

    }

    public struct MatHang 
    {
        public string maMatHang;
        public string tenMatHang;
        public int giaTien;
        public string ngaySanXuat;
        public string ngayHetHan;
        public string tenNhaSanXuat;
        public LoaiHang loaiHang;
        public void ShowMatHang()
        {
            Console.WriteLine($"{maMatHang} | {tenMatHang} | {giaTien} | {ngaySanXuat} | {ngayHetHan} | {tenNhaSanXuat} |{loaiHang.tenLoai}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }
}
