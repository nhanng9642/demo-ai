using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHang
{
    class XL_LuuDuLieu
    {
        public static LoaiHang[] LuuLoaiHangVaoMang(LoaiHang[] dsHienTai, LoaiHang loaiHangMoi)
        {
            LoaiHang[] dsMoi = new LoaiHang[dsHienTai.Length + 1];
           
            for (int i = 0; i < dsHienTai.Length; i++)
            {
                dsMoi[i] = dsHienTai[i];
            }

            dsMoi[dsMoi.Length - 1] = loaiHangMoi;
            return dsMoi;
        }
        public static LoaiHang[] XoaLoaiHangRaKhoiMang(LoaiHang[] dsHienTai, int maLoaiHang)
        {
            LoaiHang[] dsMoi = new LoaiHang[dsHienTai.Length - 1];
            if (dsMoi.Length == 0)
            {
                return dsMoi;
            }

            int i = 0;
            int j = 0;
            for (; i < dsHienTai.Length; )
            {
                if (dsHienTai[i].Ma == maLoaiHang)
                {
                    i++;
                }
                dsMoi[j] = dsHienTai[i];
                i++;
                j++;
            }
            return dsMoi;
        }
        public static int LayIndexLoaiHangTrongMang(LoaiHang[] dsHienTai, int maLoaiHang)
        {
            for (int i = 0; i < dsHienTai.Length; i++)
            {
                if (dsHienTai[i].Ma == maLoaiHang)
                {
                    return i;
                }
            }
            return -1;
        }
        public static MatHang[] LuuMatHangVaoMang(MatHang[] dsHienTai, MatHang matHangMoi)
        {
            MatHang[] dsMoi = new MatHang[dsHienTai.Length + 1];

            for (int i = 0; i < dsHienTai.Length; i++)
            {
                dsMoi[i] = dsHienTai[i];
            }

            dsMoi[dsMoi.Length - 1] = matHangMoi;
            return dsMoi;
        }
        public static MatHang[] XoaMatHangRaKhoiMang(MatHang[] dsHienTai, int maMatHang)
        {
            MatHang[] dsMoi = new MatHang[dsHienTai.Length - 1];
            if (dsMoi.Length == 0)
            {
                return dsMoi;
            }

            int i = 0;
            int j = 0;
            for (; i < dsHienTai.Length;)
            {
                if (dsHienTai[i].Ma == maMatHang)
                {
                    i++;
                }
                dsMoi[j] = dsHienTai[i];
                i++;
                j++;
            }
            return dsMoi;
        }
        public static int LayIndexMatHangTrongMang(MatHang[] dsHienTai, int maMatHang)
        {
            for (int i = 0; i < dsHienTai.Length; i++)
            {
                if (dsHienTai[i].Ma == maMatHang)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
