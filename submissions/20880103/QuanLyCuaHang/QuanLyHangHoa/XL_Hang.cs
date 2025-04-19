using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa
{
    class XL_Hang
    {
        public static LOAIHANG[] TaoLoaiHang()
        {
            LOAIHANG[] DSLoaiHang = new LOAIHANG[11];
            DSLoaiHang[0] = new LOAIHANG("BK01", "Bánh kẹo");
            DSLoaiHang[1] = new LOAIHANG("RAU02", "Rau xanh");
            DSLoaiHang[2] = new LOAIHANG("SUA03", "Sữa các loại");
            DSLoaiHang[3] = new LOAIHANG("TCF01", "Trà và cà phê");
            DSLoaiHang[4] = new LOAIHANG("PT01", "Đồ dùng phòng tắm");
            DSLoaiHang[5] = new LOAIHANG("MCP01", "Mì, cháo, phở ăn liền");
            DSLoaiHang[6] = new LOAIHANG("DAU02", "Dầu ăn, nước chấm, gia vị");
            DSLoaiHang[7] = new LOAIHANG("GAO01", "Gạo, thực phẩm khô");
            DSLoaiHang[8] = new LOAIHANG("DL01", "Đồ đông lạnh, đồ mát");
            DSLoaiHang[9] = new LOAIHANG("TB02", "Tã, bỉm, sản phẩm cho bé");
            DSLoaiHang[10] = new LOAIHANG("CSCN03", "Chăm sóc cá nhân");

            return DSLoaiHang;
        }

        public static MATHANG[] TaoMatHang()
        {
            LOAIHANG[] DSLoaiHang = TaoLoaiHang();
            MATHANG[] DSMatHang = new MATHANG[16];

            DSMatHang[0] = new MATHANG("BX253", "Bánh xốp nhân phô mai Nabati", DateTime.Parse("2021-03-01"), "Công ty Nabati (Indonesia)", 2020, DSLoaiHang[0].maLoaiHang);
            DSMatHang[1] = new MATHANG("SN002", "Snack khoai lang tím Jojo", DateTime.Parse("2021-02-15"), "Công ty Jojo (Việt Nam)", 2020, DSLoaiHang[0].maLoaiHang);
            DSMatHang[2] = new MATHANG("BG017", "Bánh gạo vị phô mai ngô 80g", DateTime.Parse("2021-04-15"), "Công ty One One", 2020, DSLoaiHang[0].maLoaiHang);
            DSMatHang[3] = new MATHANG("CN001", "Cải ngọt", DateTime.Parse("2020-12-20"), "4K Farm", 2020, DSLoaiHang[1].maLoaiHang);
            DSMatHang[4] = new MATHANG("RD008", "Rau dền", DateTime.Parse("2021-03-01"), "4K Farm", 2020, DSLoaiHang[1].maLoaiHang);
            DSMatHang[5] = new MATHANG("LO0087", "Sữa tươi tiệt trùng Lothamilk", DateTime.Parse("2021-05-01"), "Công ty Lothamilk (Việt Nam)", 2020, DSLoaiHang[2].maLoaiHang);
            DSMatHang[6] = new MATHANG("AUO276", "Sữa tươi tách béo không đường Australia's Own", DateTime.Parse("2021-07-10"), "Công ty Australia's Own (Úc)", 2020, DSLoaiHang[2].maLoaiHang);
            DSMatHang[7] = new MATHANG("TTNO26", "Trà Thái nguyên 100 g", DateTime.Parse("2021-11-30"), "Cơ sở sản xuất Nông Văn Khánh", 2020, DSLoaiHang[3].maLoaiHang);
            DSMatHang[8] = new MATHANG("CFC001", "Cà phê capuchino dừa Archcafe 240g", DateTime.Parse("2021-11-10"), "Công ty TNHH Nestle Việt Nam", 2020, DSLoaiHang[3].maLoaiHang);
            DSMatHang[9] = new MATHANG("CFD007", "Cà phê Nescafe 3 trong 1 (20g)", DateTime.Parse("2021-06-12"), "Công ty TNHH Nestle Việt Nam", 2020, DSLoaiHang[3].maLoaiHang);
            DSMatHang[10] = new MATHANG("DG042", "Dầu gội Purite by Provence 350ml", DateTime.Parse("2022-08-31"), "Công ty TNHH P&G Việt Nam", 2019, DSLoaiHang[4].maLoaiHang);
            DSMatHang[11] = new MATHANG("DG078", "Dầu gội Rejoice siêu mềm mượt 632ml", DateTime.Parse("2022-05-07"), "Công ty TNHH P&G Thái Lan", 2019, DSLoaiHang[4].maLoaiHang);
            DSMatHang[12] = new MATHANG("KDR12", "Kem đánh răng Formula Proteksi ngừa sâu răng 75g", DateTime.Parse("2023-09-30"), "PT Ultra Prima Abadi", 2020, DSLoaiHang[4].maLoaiHang);
            DSMatHang[13] = new MATHANG("MMM001", "Mì Mama vị tiềm", DateTime.Parse("2021-04-13"), "Công ty Thái Presidents Food Public Company Limited - Thái Lan", 2020, DSLoaiHang[5].maLoaiHang);
            DSMatHang[14] = new MATHANG("MLK002", "Mì lá kim Jin Ottogi", DateTime.Parse("2021-05-17"), "Công ty TNHH Ottogi Việt Nam", 2020, DSLoaiHang[5].maLoaiHang);
            DSMatHang[15] = new MATHANG("CT026", "Cháo tươi yến hạt sen lá dứa Cây Thị gói 260g", DateTime.Parse("2021-03-27"), "Công ty cổ phần sản xuất thực phẩm Anh Kim", 2020, DSLoaiHang[5].maLoaiHang);

            return DSMatHang;
        }
        public static int TraCuuMaHang(MATHANG[] DSMatHang, string MaHang)
        {
            int viTriHang = -1;
            for (int i = 0; i < DSMatHang.Length; i++)
            {
                if (MaHang == DSMatHang[i].maHang)
                {
                    viTriHang = i;
                    break;
                }
            }
            return viTriHang;
        }
        public static string TraCuuTenLoaiHang(LOAIHANG[] DSLoaiHang, string MaLoaiHang)
        {
            string tenLoaiHang = "";
            for (int i = 0; i < DSLoaiHang.Length; i++)
            {
                if (MaLoaiHang == DSLoaiHang[i].maLoaiHang)
                {
                    tenLoaiHang = DSLoaiHang[i].tenLoaiHang;
                    break;
                }
            }
            return tenLoaiHang;
        }
        public static string TenLH_MaLH_Mapping(LOAIHANG[] DSLoaiHang, string TenLoaiHang)
        {
            string maLoaiHang = "";
            for (int i = 0; i < DSLoaiHang.Length; i++)
            {
                if (TenLoaiHang == DSLoaiHang[i].tenLoaiHang)
                {
                    maLoaiHang = DSLoaiHang[i].maLoaiHang;
                    break;
                }
            }
            return maLoaiHang;
        }
        public static int TraCuuMaLoaiHang(LOAIHANG[] DSLoaiHang, string MaLoaiHang)
        {
            int viTriLoaiHang = -1;
            for (int i = 0; i < DSLoaiHang.Length; i++)
            {
                if (MaLoaiHang == DSLoaiHang[i].maLoaiHang)
                {
                    viTriLoaiHang = i;
                    break;
                }
            }
            return viTriLoaiHang;
        }
        public static MATHANG[] XoaMatHang(MATHANG[] DSMatHang, int viTriHang)
        {
            MATHANG[] newDSMatHang = new MATHANG[DSMatHang.Length - 1];
            for (int i = 0, j = 0; i < newDSMatHang.Length; i++, j++)
            {
                if (i == viTriHang)
                {
                    j++;
                }
                newDSMatHang[i] = DSMatHang[j];
            }
            // overwrite the old array with the new one
            DSMatHang = newDSMatHang;
            return DSMatHang;
        }
    }
}
