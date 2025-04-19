using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang
{
    class XL_NhapXuatThongTin
    {
        public static string NhapChuoi(string yeuCauNhap)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string chuoi = "";
            while (chuoi == "")
            {
                Console.Write(yeuCauNhap+"  :   ");
                chuoi = Console.ReadLine();
            }
            return chuoi;
        }
        public static int NhapSoNguyen(string yeuCauNhap)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int soNguyen = 0;
            bool laSoNguyen = false;
            while (laSoNguyen == false)
            {
                Console.Write(yeuCauNhap+"  :   ");
                laSoNguyen = int.TryParse(Console.ReadLine(), out soNguyen);
            }
            return soNguyen;
        }
        public static int NhapLuaChon(string yeuCauNhap ,string[] cacLuaChon)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int luaChon = 0;
            if (cacLuaChon.Length == 0)
            {
                return luaChon;
            }

            Console.WriteLine(yeuCauNhap);
            for (int i = 0; i < cacLuaChon.Length; i++)
            {
                Console.WriteLine($"    +   Nhập {i+1} : {cacLuaChon[i]}");
            }

            while (luaChon <= 0 || luaChon > cacLuaChon.Length)
            {
                luaChon = NhapSoNguyen("Vui lòng chọn 1 phương án. Phương án được chọn phải nằm trong danh sách trên");
            }
            return luaChon;
        }
        public static LoaiHang NhapLoaiHang()
        {
            LoaiHang loaiHang;
            loaiHang.Ma = NhapSoNguyen("Vui lòng nhập mã loại hàng. Mã loại hàng phải là một số nguyên");
            loaiHang.Ten = NhapChuoi("Vui lòng nhập tên loại hàng. Tên loại hàng là một chuỗi ký tự");
            return loaiHang;
        }
        public static MatHang NhapMatHang()
        {
            MatHang matHang;
            matHang.Ma = NhapSoNguyen("Vui lòng nhập mã mặt hàng. Mã mặt hàng phải là một số nguyên");
            matHang.Ten = NhapChuoi("Vui lòng nhập tên mặt hàng. Tên mặt hàng là một chuỗi ký tự");
            matHang.HanDung = NhapChuoi("Vui lòng nhập hạn sử dụng theo định dạng dd/mm/yyyy");
            matHang.CongTySX = NhapChuoi("Vui lòng nhập tên công ty sản xuất. Tên công ty là một chuỗi ký tự");
            matHang.NamSX = NhapSoNguyen("Vui lòng nhập năm sản xuất. Năm sản xuất phải là một số nguyên 4 chữ số");
            matHang.Loai = NhapSoNguyen("Vui lòng nhập mã loại hàng. Mã loại hàng phải là một số nguyên, thuộc danh sách các mã loại hàng đã có trong cơ sở dữ liệu");
            return matHang;
        }
        public static void XuatMatHang(MatHang[] dsMatHang, string thongBao)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n"+thongBao+"\n");
            for (int i = 0; i < dsMatHang.Length; i++)
            {
                Console.WriteLine($"    +   Mã: {dsMatHang[i].Ma} - Tên: {dsMatHang[i].Ten} - HSD: {dsMatHang[i].HanDung} - Công ty: {dsMatHang[i].CongTySX} - Sản xuất năm: {dsMatHang[i].NamSX}");
            }
            Console.WriteLine($"\nDanh sách gồm: {dsMatHang.Length} mặt hàng.");
            TraKetQua("");
        }
        public static void XuatLoaiHang(LoaiHang[] dsLoaiHang, string thongBao)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n" + thongBao + "\n");
            for (int i = 0; i < dsLoaiHang.Length; i++)
            {
                Console.WriteLine($"    +   Mã loại hàng: {dsLoaiHang[i].Ma} - Tên loại hàng: {dsLoaiHang[i].Ten}");
            }
            Console.WriteLine($"\nDanh sách gồm: {dsLoaiHang.Length} loại hàng.");
            TraKetQua("");
        }
        public static void TraKetQua(string KetQua)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("\n"+KetQua+"\n");
            Console.Write("Bấm ENTER để tiếp tục");
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
