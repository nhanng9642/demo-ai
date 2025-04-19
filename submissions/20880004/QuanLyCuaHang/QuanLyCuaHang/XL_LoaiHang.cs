using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang
{
    public struct LoaiHang
    {
        public int Ma;
        public string Ten;
    }
    class XL_LoaiHang
    {
        public static void LietKeTatCaLoaiHang(LoaiHang[] dsLoaiHang)
        {
            if (dsLoaiHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có loại hàng nào trong dữ liệu");
                return;
            }
            XL_NhapXuatThongTin.XuatLoaiHang(dsLoaiHang, "Danh sách các loại hàng bao gồm:");
        }
        public static LoaiHang[] ThemLoaiHang(LoaiHang[] dsLoaiHang)
        {
            LoaiHang loaiHang = XL_NhapXuatThongTin.NhapLoaiHang();
            int indexLoaiHang = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, loaiHang.Ma);
            if (indexLoaiHang == -1)
            {
                LoaiHang[] dsMoi = XL_LuuDuLieu.LuuLoaiHangVaoMang(dsLoaiHang, loaiHang);
                XL_NhapXuatThongTin.TraKetQua($"Đã thêm thành công loại hàng: {loaiHang.Ten} - Mã số: {loaiHang.Ma}");
                return dsMoi;
            }
            XL_NhapXuatThongTin.TraKetQua($"Không thể thêm loại hàng: {loaiHang.Ten} - Mã số: {loaiHang.Ma}. Loại hàng này đã tồn tại trước đó");
            return dsLoaiHang;
        }
        public static LoaiHang[] XoaLoaiHang(LoaiHang[] dsLoaiHang)
        {
            if (dsLoaiHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không thể xóa dữ liệu. Không có loại hàng nào trong dữ liệu");
                return dsLoaiHang;
            }

            int maLoaiHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã loại hàng muốn xóa. Mã loại hàng phải là số nguyên");
            int indexLoaiHang = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, maLoaiHang);
            if (indexLoaiHang != -1)
            {
                dsLoaiHang = XL_LuuDuLieu.XoaLoaiHangRaKhoiMang(dsLoaiHang, maLoaiHang);
                XL_NhapXuatThongTin.TraKetQua($"Đã xóa thành công loại hàng có mã là {maLoaiHang}");
            } else
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể xóa dữ liệu. Không tồn tại loại hàng với mã là {maLoaiHang}");
            }
            return dsLoaiHang;
        }
        public static LoaiHang[] SuaLoaiHang(LoaiHang[] dsLoaiHang)
        {
            if (dsLoaiHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có loại hàng nào trong dữ liệu");
                return dsLoaiHang;
            }
            int maLoaiHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã loại hàng muốn sửa. Mã loại hàng phải là số nguyên");
            int indexLoaiHangCu = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, maLoaiHang);
            if (indexLoaiHangCu == -1)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có loại hàng với mã bằng {maLoaiHang} trong dữ liệu");
                return dsLoaiHang;
            }

            XL_NhapXuatThongTin.TraKetQua("Vui lòng nhập thông tin điều chỉnh loại hàng");
            LoaiHang loaiHangMoi = XL_NhapXuatThongTin.NhapLoaiHang();
            int indexLoaiHangMoi = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, maLoaiHang);
            if (indexLoaiHangMoi == -1 || indexLoaiHangMoi == indexLoaiHangCu)
            {
                dsLoaiHang[indexLoaiHangCu] = loaiHangMoi;
                XL_NhapXuatThongTin.TraKetQua($"Đã sửa thông tin loại hàng thành công");
            }
            else
            {
                XL_NhapXuatThongTin.TraKetQua($"Không thể sửa mã loại hàng thành {loaiHangMoi.Ma}. Mã này đã tồn tại");
            }
            return dsLoaiHang;
        }
        public static void TimLoaiHangTheoMa(LoaiHang[] dsLoaiHang)
        {
            if (dsLoaiHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có loại hàng nào trong dữ liệu");
                return;
            }

            int maLoaiHang = XL_NhapXuatThongTin.NhapSoNguyen("Nhập mã loại hàng muốn tìm kiếm. Mã loại hàng phải là số nguyên");
            int indexLoaiHang = XL_LuuDuLieu.LayIndexLoaiHangTrongMang(dsLoaiHang, maLoaiHang);
            if (indexLoaiHang != -1)
            {
                LoaiHang[] dsKetQua = new LoaiHang[] { dsLoaiHang[indexLoaiHang] };
                XL_NhapXuatThongTin.XuatLoaiHang(dsKetQua, $"Loại hàng có mã bằng {maLoaiHang} là:");
            }
            else
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có loại hàng với mã bằng {maLoaiHang} trong dữ liệu");
            }
        }
        public static void TimLoaiHangTheoTen(LoaiHang[] dsLoaiHang)
        {
            if (dsLoaiHang.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua("Không có loại hàng nào trong dữ liệu");
                return;
            }
            string keyword = XL_NhapXuatThongTin.NhapChuoi("Nhập tên loại hàng muốn tìm kiếm. Tên loại hàng là một chuỗi ký tự");
            LoaiHang[] dsKetQua = new LoaiHang[0];
            for (int i = 0; i < dsLoaiHang.Length; i++)
            {
                if (dsLoaiHang[i].Ten.ToLower().Contains(keyword.ToLower()) == true)
                {
                    dsKetQua = XL_LuuDuLieu.LuuLoaiHangVaoMang(dsKetQua, dsLoaiHang[i]);
                }
            }
            if (dsKetQua.Length == 0)
            {
                XL_NhapXuatThongTin.TraKetQua($"Không có loại hàng nào với tên `{keyword}` trong dữ liệu");
                return;
            }
            XL_NhapXuatThongTin.XuatLoaiHang(dsKetQua, $"Các loại hàng với tên là `{keyword}` bao gồm:");
        }
    }
}
