using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang
{
    public struct MatHang
    {
        public int Ma;
        public string Ten;
        public string HanDung;
        public string CongTySX;
        public int NamSX;
        public int Loai;
    }
    class XL_MatHang
    {
        public static void LietKeTatCaMatHang(MatHang[] dsMatHang)
        {
            if (dsMatHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có mặt hàng nào trong dữ liệu");
                return;
            }
            XL_NhapXuatThongTin.XuatMatHang(dsMatHang, "Danh sách các mặt hàng bao gồm:");
        }
        public static MatHang[] ThemMatHang(MatHang[] dsMatHang, LoaiHang[] dsLoaiHang)
        {
            MatHang matHang = XL_NhapXuatThongTin.NhapMatHang();
            int indexLoaiHang = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, matHang.Loai);
            int indexMatHang = XL_LuuDuLieu.LayIndexMatHangTrongMang(dsMatHang, matHang.Ma);
            if (indexMatHang == -1 && indexLoaiHang != -1)
            {
                MatHang[] dsMoi = XL_LuuDuLieu.LuuMatHangVaoMang(dsMatHang, matHang);
                XL_NhapXuatThongTin.TraKetQua($"Đã thêm thành công mặt hàng: {matHang.Ten} - Mã số: {matHang.Ma} - HSD: {matHang.HanDung} - Công ty: {matHang.CongTySX}");
                return dsMoi;
            }
            if (indexMatHang != -1)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể thêm mặt hàng: {matHang.Ten} - Mã số: {matHang.Ma} - HSD: {matHang.HanDung} - Công ty: {matHang.CongTySX}. Mặt hàng này có mã số đã tồn tại trước đó");
                return dsMatHang;
            }
            XL_NhapXuatThongTin.TraKetQua($"Không thể thêm mặt hàng: {matHang.Ten} - Thuộc loại hàng: {matHang.Loai}. Mặt hàng này thuộc một loại hàng chưa có sẵn trong dữ liệu. Vui lòng nhập loại hàng trước");
            return dsMatHang;
        }
        public static MatHang[] XoaMatHang(MatHang[] dsMatHang)
        {
            if (dsMatHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không thể xóa dữ liệu. Không có mặt hàng nào trong dữ liệu");
                return dsMatHang;
            }

            int maMatHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã mặt hàng muốn xóa. Mã mặt hàng phải là số nguyên");
            int indexMatHang = XL_LuuDuLieu.LayIndexMatHangTrongMang(dsMatHang, maMatHang);
            if (indexMatHang != -1)
            {
                dsMatHang = XL_LuuDuLieu.XoaMatHangRaKhoiMang(dsMatHang, maMatHang);
                XL_NhapXuatThongTin.TraKetQua($"Đã xóa thành công mặt hàng có mã là {maMatHang}");
            }
            else
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể xóa dữ liệu. Không tồn tại mặt hàng với mã là {maMatHang}");
            }
            return dsMatHang;
        }
        public static MatHang[] SuaMatHang(MatHang[] dsMatHang, LoaiHang[] dsLoaiHang)
        {
            if (dsMatHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có mặt hàng nào trong dữ liệu");
                return dsMatHang;
            }
            int maMatHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã mặt hàng muốn sửa. Mã mặt hàng phải là số nguyên");
            int indexMatHangCu = XL_LuuDuLieu.LayIndexMatHangTrongMang(dsMatHang, maMatHang);
            if (indexMatHangCu == -1)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có mặt hàng với mã bằng {maMatHang} trong dữ liệu");
                return dsMatHang;
            }

            XL_NhapXuatThongTin.TraKetQua("Vui lòng nhập thông tin điều chỉnh mặt hàng");
            MatHang matHangMoi = XL_NhapXuatThongTin.NhapMatHang();
            int indexLoaiHangMoi = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, matHangMoi.Loai);
            int indexMatHangMoi = XL_LuuDuLieu.LayIndexMatHangTrongMang(dsMatHang, maMatHang);
            if (indexMatHangMoi != -1 && indexMatHangMoi != indexMatHangCu)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể sửa mã mặt hàng thành {matHangMoi.Ma}. Mã này đã tồn tại");
                return dsMatHang;
            }
            if (indexLoaiHangMoi == -1)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể sửa loại mặt hàng thành {matHangMoi.Loai}. Loại mặt hàng này chưa tồn tại. Vui lòng thêm mã loại hàng trước");
                return dsMatHang;
            }
            dsMatHang[indexMatHangCu] = matHangMoi;
            XL_NhapXuatThongTin.TraKetQua($"Đã sửa thông tin mặt hàng thành công");
            return dsMatHang;
        }
        public static void TimMatHangTheoMa(MatHang[] dsMatHang)
        {
            if (dsMatHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có mặt hàng nào trong dữ liệu");
                return;
            }

            int maMatHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã mặt hàng muốn tìm kiếm. Mã mặt hàng phải là số nguyên");
            int indexMatHang = XL_LuuDuLieu.LayIndexMatHangTrongMang(dsMatHang, maMatHang);
            if (indexMatHang != -1)
            {
                MatHang[] dsKetQua = new MatHang[] { dsMatHang[indexMatHang]};
                XL_NhapXuatThongTin.XuatMatHang(dsKetQua, $"Mặt hàng với mã bằng {maMatHang}:");
            }
            else
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có mặt hàng với mã bằng {maMatHang} trong dữ liệu");
            }
        }
        public static void TimMatHangTheoTen(MatHang[] dsMatHang)
        {
            if (dsMatHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có mặt hàng nào trong dữ liệu");
                return;
            }
            string keyword = XL_NhapXuatThongTin.NhapChuoi("Nhập tên mặt hàng muốn tìm kiếm. Tên mặt hàng là một chuỗi ký tự");
            MatHang[] dsKetQua = new MatHang[0];
            for (int i = 0; i < dsMatHang.Length; i++)
            {
                if (dsMatHang[i].Ten.ToLower().Contains(keyword.ToLower()) == true)
                {
                    dsKetQua = XL_LuuDuLieu.LuuMatHangVaoMang(dsKetQua, dsMatHang[i]);
                }
            }
            if (dsKetQua.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có mặt hàng nào với tên `{keyword}` trong dữ liệu");
                return;
            }
            XL_NhapXuatThongTin.XuatMatHang(dsKetQua, $"Các mặt hàng với tên là `{keyword}` bao gồm:");
        }
    }
}
