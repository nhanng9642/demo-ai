using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang
{
    class XL_LuongChuongTrinh
    {
        public static void BatDauChuongTrinh()
        {
            LoaiHang[] dsLoaiHang = new LoaiHang[0];
            MatHang[] dsMatHang = new MatHang[0];
            int luaChon;
            bool thoatChuongTrinh = false;
            string[] cacLuaChon = new string[] { 
                "Thao tác với các mặt hàng",
                "Thao tác với các loại hàng",
                "Thoát chương trình"
            };

            while (thoatChuongTrinh == false)
            {
                luaChon = XL_NhapXuatThongTin.NhapLuaChon("Bạn muốn làm gì?", cacLuaChon);
                Console.Clear();
                switch (luaChon)
                {
                    case 1:
                        dsMatHang = ThaoTacVoiMatHang(dsMatHang, dsLoaiHang);
                        break;
                    case 2:
                        dsLoaiHang = ThaoTacVoiLoaiHang(dsLoaiHang);
                        break;
                    default:
                        XL_NhapXuatThongTin.TraKetQua("Chương trình kết thúc");
                        thoatChuongTrinh = true;
                        break;
                }
            }
        }
        private static MatHang[] ThaoTacVoiMatHang(MatHang[] dsMatHang, LoaiHang[] dsLoaiHang)
        {
            int luaChon;
            string[] cacLuaChon = new string[] {
                "Thêm mặt hàng",
                "Xóa mặt hàng",
                "Sửa mặt hàng",
                "Tìm mặt hàng theo mã mặt hàng",
                "Tìm mặt hàng theo tên mặt hàng",
                "Liệt kê tất cả mặt hàng",
                "Thoát khỏi chức năng thao tác với mặt hàng",
            };
            bool thoatChucNang = false;

            while (thoatChucNang == false)
            {
                luaChon = XL_NhapXuatThongTin.NhapLuaChon("Bạn muốn làm thao tác gì với các mặt hàng", cacLuaChon);
                Console.Clear();
                switch (luaChon)
                {
                    case 1:
                        dsMatHang = XL_MatHang.ThemMatHang(dsMatHang, dsLoaiHang);
                        break;
                    case 2:
                        dsMatHang = XL_MatHang.XoaMatHang(dsMatHang);
                        break;
                    case 3:
                        dsMatHang = XL_MatHang.SuaMatHang(dsMatHang, dsLoaiHang);
                        break;
                    case 4:
                        XL_MatHang.TimMatHangTheoMa(dsMatHang);
                        break;
                    case 5:
                        XL_MatHang.TimMatHangTheoTen(dsMatHang);
                        break;
                    case 6:
                        XL_MatHang.LietKeTatCaMatHang(dsMatHang);
                        break;
                    default:
                        XL_NhapXuatThongTin.TraKetQua("Thoát khỏi chức năng thao tác với mặt hàng");
                        thoatChucNang = true;
                        break;
                }
            }
            return dsMatHang;
        }

        private static LoaiHang[] ThaoTacVoiLoaiHang(LoaiHang[] dsLoaiHang)
        {
            int luaChon;
            string[] cacLuaChon = new string[] {
                "Thêm loại hàng",
                "Xóa loại hàng",
                "Sửa loại hàng",
                "Tìm loại hàng theo mã loại hàng",
                "Tìm loại hàng theo tên loại hàng",
                "Liệt kê tất cả loại hàng",
                "Thoát khỏi chức năng thao tác với loại hàng",
            };
            bool thoatChucNang = false;

            while (thoatChucNang == false)
            {
                luaChon = XL_NhapXuatThongTin.NhapLuaChon("Bạn muốn làm thao tác gì với các loại hàng", cacLuaChon);
                Console.Clear();
                switch (luaChon)
                {
                    case 1:
                        dsLoaiHang = XL_LoaiHang.ThemLoaiHang(dsLoaiHang);
                        break;
                    case 2:
                        dsLoaiHang = XL_LoaiHang.XoaLoaiHang(dsLoaiHang);
                        break;
                    case 3:
                        dsLoaiHang = XL_LoaiHang.SuaLoaiHang(dsLoaiHang);
                        break;
                    case 4:
                        XL_LoaiHang.TimLoaiHangTheoMa(dsLoaiHang);
                        break;
                    case 5:
                        XL_LoaiHang.TimLoaiHangTheoTen(dsLoaiHang);
                        break;
                    case 6:
                        XL_LoaiHang.LietKeTatCaLoaiHang(dsLoaiHang);
                        break;
                    default:
                        XL_NhapXuatThongTin.TraKetQua("Thoát khỏi chức năng thao tác với loại hàng");
                        thoatChucNang = true;
                        break;
                }
            }
            return dsLoaiHang;
        }
    }
}
