using System;
using System.Collections.Generic;
using System.Text;
namespace QUAN_LY_CUA_HANG_NMLT_1988333
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MatHang suatuoi;
            suatuoi.IDmh = 0; suatuoi.TenMH = "Sua tuoi";
            suatuoi.HanDung.Ngay = 1; suatuoi.HanDung.Thang = 6; suatuoi.HanDung.Nam = 2021;
            suatuoi.CtySX = "Cong ty sua"; suatuoi.NamSX = 2020; suatuoi.LoaiHang = "Thuc pham uong";
            MatHang caphe;
            caphe.IDmh = 1; caphe.TenMH = "Ca phe";
            caphe.HanDung.Ngay = 1; caphe.HanDung.Thang = 12; caphe.HanDung.Nam = 2021;
            caphe.CtySX = "Cong ty ca phe"; caphe.NamSX = 2020; caphe.LoaiHang = "Thuc pham uong";
            MatHang gao;
            gao.IDmh = 2; gao.TenMH = "Gao";
            gao.HanDung.Ngay = 1; gao.HanDung.Thang = 12; gao.HanDung.Nam = 2021;
            gao.CtySX = "Cong ty gao"; gao.NamSX = 2020; gao.LoaiHang = "Luong thuc";
            var DSachMH = new List<MatHang>();
            DSachMH.Add(suatuoi);
            DSachMH.Add(caphe);
            DSachMH.Add(gao);
            var DS_LoaiHang = XL_QL_CUA_HANG.GetDS_LH(DSachMH);
            int z = 2; while (z > 0)
            {
                Console.WriteLine("MAN HINH CHINH : QUAN LY CUA HANG");
                Console.WriteLine("An cac phim sau de lua chon :");
                Console.WriteLine("Phim 1 : QUAN LY MAT HANG");
                Console.WriteLine("Phim 2 : QUAN LY THE LOAI HANG");
                int q = 3;
                while (q > 0 || q < 0)
                {
                    q = int.Parse(Console.ReadLine());
                    while (q != 0 && q != 1 && q != 2)
                    {
                        Console.WriteLine("Ban vui long chon 1 trong cac phim chuc nang sau:");
                        Console.WriteLine("Phim 0 : Tro ve man hinh chinh");
                        Console.WriteLine("Phim 1 : QUAN LY MAT HANG");
                        Console.WriteLine("Phim 2 : QUAN LY THE LOAI HANG");
                        q = int.Parse(Console.ReadLine());
                    }
                    while (q == 1)
                    {
                        Console.WriteLine("DANH SACH MAT HANG");
                        XL_QL_CUA_HANG.XuatTT_List_MH(DSachMH);
                        Console.WriteLine("---BAN CHON 1 TRONG CAC PHIM CHUC NANG SAU---");
                        Console.WriteLine("phim 1 : Tim kiem mat hang");
                        Console.WriteLine("phim 2 : Them mat hang");
                        Console.WriteLine("phim 3 : Xoa mat hang");
                        Console.WriteLine("phim 4 : Chinh sua mat hang");
                        int h = int.Parse(Console.ReadLine());
                        while (h != 1 && h != 2 && h != 3 && h != 4)
                        {
                            Console.WriteLine("Khong dung cu phap, ban vui long chon 1 trong cac phim chuc nang sau:");
                            Console.WriteLine("phim 1 : Tim kiem mat hang");
                            Console.WriteLine("phim 2 : Them mat hang");
                            Console.WriteLine("phim 3 : Xoa mat hang");
                            Console.WriteLine("phim 4 : Chinh sua mat hang");
                            h = int.Parse(Console.ReadLine());
                        }
                        switch (h)
                        {
                            case 1:
                                Console.WriteLine("--TIM KIEM MAT HANG--");
                                Console.WriteLine("Nhap tu khoa tim kiem:");
                                string tim = Console.ReadLine();
                                var kq = XL_QL_CUA_HANG.TimMH(DSachMH, tim);
                                while(kq.Count == 0)
                                {
                                    Console.WriteLine("**Du lieu khong tim thay, vui long thu lai");
                                    Console.WriteLine("Nhap tu khoa tim kiem:");
                                    tim = Console.ReadLine();
                                    kq = XL_QL_CUA_HANG.TimMH(DSachMH, tim);
                                }
                                Console.WriteLine("KET QUA TIM KIEM");
                                XL_QL_CUA_HANG.XuatTT_List_MH(kq);
                                break;
                            case 2:
                                Console.WriteLine("--THEM MAT HANG--");
                                Console.WriteLine("Nhap thong tin them mat hang:");
                                MatHang New_MH = XL_QL_CUA_HANG.NhapTT_MH(DSachMH);
                                DSachMH.Add(New_MH);
                                Console.WriteLine("---KET QUA NHAP HANG---");
                                XL_QL_CUA_HANG.XuatTT_List_MH(DSachMH);
                                break;
                            case 3:
                                Console.WriteLine("---XOA MAT HANG---");
                                Console.WriteLine("DANH SACH MAT HANG");
                                XL_QL_CUA_HANG.XuatTT_List_MH(DSachMH);
                                Console.WriteLine("BAN CHON 1 MAT HANG CAN XOA VA GHI ID XUONG DUOI");
                                int xoa = int.Parse(Console.ReadLine());
                                XL_QL_CUA_HANG.XoaMH(DSachMH, xoa);
                                Console.WriteLine("Ban da xoa THANH CONG");
                                break;
                            case 4:
                                Console.WriteLine("---CHINH SUA MAT HANG---");
                                Console.WriteLine("DANH SACH MAT HANG");
                                XL_QL_CUA_HANG.XuatTT_List_MH(DSachMH);
                                Console.WriteLine("BAN CHON 1 MAT HANG CAN CHINH SUA VA GHI ID XUONG DUOI");
                                int sua = int.Parse(Console.ReadLine());
                                XL_QL_CUA_HANG.ChinhSua_MH(DSachMH, sua);
                                Console.WriteLine("***Ban chinh sua mat hang THANH CONG***");
                                break;
                        }
                        Console.WriteLine("An 0 : Tro ve MENU CHINH");
                        Console.WriteLine("An 1 : Tro ve MENU MAT HANG");
                        q = int.Parse(Console.ReadLine());
                        while (q != 0 && q != 1)
                        {
                            Console.WriteLine("Ban vui long chon 1 trong cac phim chuc nang sau:");
                            Console.WriteLine("An 0 : Tro ve MENU CHINH");
                            Console.WriteLine("An 1 : Tro ve MENU MAT HANG");
                            q = int.Parse(Console.ReadLine());
                        }
                    }
                    while (q == 2)
                    {
                        Console.WriteLine("DANH SACH LOAI HANG");
                        XL_QL_CUA_HANG.XuatTT_DS_LH(DS_LoaiHang);
                        Console.WriteLine("---BAN CHON 1 TRONG CAC PHIM CHUC NANG SAU---");
                        Console.WriteLine("phim 1 : Tim kiem loai hang");
                        Console.WriteLine("phim 2 : Them loai hang");
                        Console.WriteLine("phim 3 : Xoa loai hang");
                        Console.WriteLine("phim 4 : Chinh sua loai hang");
                        int h = int.Parse(Console.ReadLine());
                        while (h != 1 && h != 2 && h != 3 && h != 4)
                        {
                            Console.WriteLine("Khong dung cu phap, ban vui long chon 1 trong cac phim chuc nang sau:");
                            Console.WriteLine("phim 1 : Tim kiem loai hang");
                            Console.WriteLine("phim 2 : Them loai hang");
                            Console.WriteLine("phim 3 : Xoa loai hang");
                            Console.WriteLine("phim 4 : Chinh sua loai hang");
                            h = int.Parse(Console.ReadLine());
                        }
                        switch (h)
                        {
                            case 1:
                                Console.WriteLine("--TIM KIEM LOAI HANG--");
                                Console.WriteLine("Nhap tu khoa tim kiem:");
                                string tim = Console.ReadLine();
                                var kq = XL_QL_CUA_HANG.TimKiem_LH(DS_LoaiHang, tim);
                                while (kq.Count == 0)
                                {
                                    Console.WriteLine("**Du lieu khong tim thay, vui long thu lai");
                                    Console.WriteLine("Nhap tu khoa tim kiem:");
                                    tim = Console.ReadLine();
                                    kq = XL_QL_CUA_HANG.TimKiem_LH(DS_LoaiHang, tim);
                                }
                                Console.WriteLine("KET QUA TIM KIEM");
                                XL_QL_CUA_HANG.XuatTT_DS_LH(kq);
                                break;
                            case 2:
                                Console.WriteLine("--THEM LOAI HANG--");
                                Console.WriteLine("Nhap thong tin loai hang:");
                                Console.WriteLine("--Nhap ten loai hang:");
                                string tenlh = Console.ReadLine();
                                Console.WriteLine("--Nhap so luong mat hang:");
                                int sl = int.Parse(Console.ReadLine());
                                Console.WriteLine("--Nhap thong tin cac mat hang:");
                                DS_LoaiHang = XL_QL_CUA_HANG.Them_LH(DSachMH, tenlh, sl);
                                Console.WriteLine("---Ban da them loai hang THANH CONG---");
                                break;
                            case 3:
                                Console.WriteLine("---XOA LOAI HANG---");
                                Console.WriteLine("DANH SACH LOAI HANG");
                                XL_QL_CUA_HANG.XuatTT_DS_LH(DS_LoaiHang);
                                Console.WriteLine("VUI LONG CHON 1 LOAI HANG CAN XOA VA NHAP CHINH XAC TEN LOAI HANG");
                                string lhxoa = Console.ReadLine();
                                var ds_ten_lh = XL_QL_CUA_HANG.Get_DSTen_LH(DSachMH);
                                while (XL_QL_CUA_HANG.KT_Tengiongnhau(ds_ten_lh, lhxoa) == false)
                                {
                                    Console.WriteLine("***Ban vui long nhap chinh xac ten loai hang can xoa:");
                                    lhxoa = Console.ReadLine();
                                }
                                DS_LoaiHang = XL_QL_CUA_HANG.XoaLoaiHang(DSachMH, lhxoa);
                                Console.WriteLine("Ban da xoa THANH CONG");
                                break;
                            case 4:
                                Console.WriteLine("---CHINH SUA LOAI HANG---");
                                Console.WriteLine("DANH SACH LOAI HANG");
                                XL_QL_CUA_HANG.XuatTT_DS_LH(DS_LoaiHang);
                                Console.WriteLine("VUI LONG CHON 1 LOAI HANG CAN CHINH SUA VA NHAP CHINH XAC TEN LOAI HANG");
                                string csua = Console.ReadLine();
                                var ds_ten_Lh = XL_QL_CUA_HANG.Get_DSTen_LH(DSachMH);
                                while (XL_QL_CUA_HANG.KT_Tengiongnhau(ds_ten_Lh, csua) == false)
                                {
                                    Console.WriteLine("***Ban vui long nhap chinh xac ten loai hang can chinh sua:");
                                    csua = Console.ReadLine();
                                }
                                LOAIHANG CSUA = XL_QL_CUA_HANG.GetLH_from_ListLH(DS_LoaiHang, csua);
                                Console.WriteLine("LOAI HANG CHINH SUA:");
                                XL_QL_CUA_HANG.XuatTT_LH(CSUA);
                                Console.WriteLine();
                                Console.WriteLine("**THONG TIN MAT HANG BAO GOM:");
                                XL_QL_CUA_HANG.XuatTT_List_MH(CSUA.DSach_MH);
                                Console.WriteLine("**Ban nhap thong tin loai hang chinh sua:");
                                Console.WriteLine("--Nhap ten loai hang:");
                                string tenLH = Console.ReadLine();
                                Console.WriteLine("--Nhap so luong mat hang bao gom:");
                                int SL = int.Parse(Console.ReadLine());
                                Console.WriteLine("--Nhap thong tin cac mat hang bao gom:");
                                DS_LoaiHang = XL_QL_CUA_HANG.Update_DS_LH(DSachMH, tenLH, SL);
                                Console.WriteLine("***Ban chinh sua THANH CONG***");
                                break;
                        }
                        Console.WriteLine("An 0 : Tro ve MENU CHINH");
                        Console.WriteLine("An 2 : Tro ve MENU LOAI HANG");
                        q = int.Parse(Console.ReadLine());
                        while (q != 0 && q != 2)
                        {
                            Console.WriteLine("Ban vui long chon 1 trong cac phim chuc nang sau:");
                            Console.WriteLine("An 0 : Tro ve MENU CHINH");
                            Console.WriteLine("An 2 : Tro ve MENU LOAI HANG");
                            q = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
