using System;

namespace DoAnNMLT_20880100
{
    class Program
    {

        // Thêm phần tử vào mảng 1 chiều
        static public string[] themPhanTuMang1Chieu(string[] mang, string phanTu)
        {
            int soPhanTu = mang.Length + 1;
            string[] mangMoi = new string[soPhanTu];
            for(int i = 0; i < soPhanTu - 1; i++)
            {
                mangMoi[i] = mang[i];
            }
            mangMoi[soPhanTu - 1] = phanTu;
            return mangMoi;
        }

        //kiểm tra phần tử có phải phần tử trống hay không
        static public bool kiemTraPhanTuTrong(string phanTu)
        {
            if(phanTu == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Nhập số
        static public int nhapSo()
        {
            int soNhap;
            while (true)
            {
                try
                {
                    soNhap = int.Parse(Console.ReadLine());
                    return soNhap;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lựa chọn chức năng sai.");
                }
            }
        }
        // Lựa chọn các đáp án
        static public int luaChon(int sLLuaChon)
        {
            int tuyChon;
            while (true)
            {
                try
                {
                    Console.Write("Chọn chức năng: ");
                    tuyChon = int.Parse(Console.ReadLine());
                    if ((tuyChon >= 0) & (tuyChon <= sLLuaChon))
                    {
                        return tuyChon;
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn chức năng sai.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lựa chọn chức năng sai.");
                }
            }
        }

        // Lựa chọn có tiếp tục hay không
        static public bool luaChonCoKhong(string noiDungLuaChon)
        {
            int tuyChon;
            while (true)
            {
                try
                {
                    Console.WriteLine(noiDungLuaChon);
                    Console.WriteLine("1 - Có");
                    Console.WriteLine("0 - Không");
                    Console.Write("Nhập tùy chọn: ");
                    tuyChon = int.Parse(Console.ReadLine());
                    if (tuyChon == 0)
                    {
                        return false;
                    }
                    else if (tuyChon == 1)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Chỉ được chọn 1 - Có, 0 - Không");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Chỉ được chọn 1 - Có, 0 - Không");
                }
            }
        }

        // Kiểu dữ liệu lưu trữ loại hàng
        struct LOAIHANG
        {
            public string[] LoaiHang;
            // Khởi tạo danh sách loại hàng, với vị trí 0 để gợi nhớ mảng loại hàng.
            // Các loại hàng sẽ được lưu trữ bắt đầu từ vị trí số 1
            public void KhoiTao()
            {
                this.LoaiHang = new string[1];
                this.LoaiHang[0] = "Loại hàng";
            }

            public void QuanLyLoaiHang()
            {
                while (true)
                {
                    Console.WriteLine("TRANG QUẢN LÝ LOẠI HÀNG");
                    Console.WriteLine("1 - Xem và tìm kiếm loại hàng.");
                    Console.WriteLine("2 - Thêm loại hàng.");
                    Console.WriteLine("3 - Sửa loại hàng.");
                    Console.WriteLine("4 - Xóa loại hàng.");
                    Console.WriteLine("0 - Về trang chính.");
                    int tuyChon = luaChon(4);
                    // Xem loại hàng
                    if (tuyChon == 1)
                    {
                        this.XemLoaiHang();
                    }
                    // Thêm loại hàng
                    else if (tuyChon == 2)
                    {
                        this.ThemLoaiHang();
                    }
                    else if (tuyChon == 3)
                    {
                        this.SuaLoaiHang();
                    }
                    else if (tuyChon == 4)
                    {
                        this.XoaLoaiHang();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // Kiểm tra danh sách đã có hay chưa
            public bool kiemTraDSTrong()
            {
                if (this.LoaiHang.Length <= 1)
                {
                    Console.WriteLine("Danh sách loại hàng hiện đang trống");
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool kiemTraSTT(int sTT)
            {
                bool sTTKhongTonTai = (sTT <= 0) | (sTT >= this.LoaiHang.Length);
                if (sTTKhongTonTai)
                {
                    Console.WriteLine("Số thứ tự không hợp lệ.");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            // Tìm số thứ tự của loại hàng trong danh sách loại hàng
            public int TimSTTLoaiHang(string loaiHang)
            {
                int sTT = -1;
                for (int i = 1; i < this.LoaiHang.Length; i++)
                {
                    if (this.LoaiHang[i] == loaiHang)
                    {
                        sTT = i;
                        break;
                    }
                }
                if (sTT == -1)
                {
                    Console.WriteLine("Tên loại hàng không tồn tại.");
                }
                return sTT;
            }

            public bool KiemTraLoaiHangMoi(string loaiHang)
            {
                bool phanTuTrong = kiemTraPhanTuTrong(loaiHang);
                if (phanTuTrong)
                {
                    Console.WriteLine("Tên loại hàng không được trống.");
                    return false;
                }
                else
                {
                    for (int i = 1; i < this.LoaiHang.Length; i++)
                    {
                        if (this.LoaiHang[i] == loaiHang)
                        {
                            Console.WriteLine("Loại hàng {0} đã tồn tại và có số thứ tự {1}.", loaiHang, i);
                            return false;
                        }
                    }
                    return true;
                }
            }

            // Xem thông tin danh sách loại hàng
            public void ThongTinDanhSach()
            {
                int ChieuDaiDanhSach = this.LoaiHang.Length - 1;
                int slLoaiHang = 0;
                int sLDaXoa = 0;
                for (int i = 1; i <= ChieuDaiDanhSach; i++)
                {
                    if (this.LoaiHang[i] == null)
                    {
                        sLDaXoa++;
                    }
                    else
                    {
                        slLoaiHang++;
                    }
                }
                Console.WriteLine("Danh sách loại hàng có số thứ tự từ 1 đến {0}. Trong đó có {1} loại hàng đã bị xóa.", ChieuDaiDanhSach, sLDaXoa);
            }

            // Thêm một loại hàng vào danh sách loại hàng
            public void ThemLoaiHang()
            {
                while (true)
                {
                    Console.WriteLine("TRANG THÊM LOẠI HÀNG");
                    if (this.kiemTraDSTrong() == false)
                    {
                        this.ThongTinDanhSach();
                    }
                    Console.Write("Nhập loại hàng cần thêm: ");
                    string loaiHang = Console.ReadLine();
                    if (this.KiemTraLoaiHangMoi(loaiHang))
                    {
                        this.LoaiHang = themPhanTuMang1Chieu(this.LoaiHang, loaiHang);
                        Console.WriteLine("Đã thêm loại hàng {0} thành công.", loaiHang);
                    }
                    // Có tiếp tục hay không
                    if (luaChonCoKhong("Có tiếp tục thêm loại hàng không?") == false)
                    {
                        break;
                    }
                }
            }

            // Xóa loại hàng
            public void XoaLoaiHang()
            {
                if (this.kiemTraDSTrong() == false)
                {
                    while (true)
                    {
                        Console.WriteLine("TRANG XÓA LOẠI HÀNG");
                        this.ThongTinDanhSach();
                        Console.WriteLine("1 - Xóa loại hàng theo tên.");
                        Console.WriteLine("2 - Xóa loại hàng theo số thứ tự.");
                        Console.WriteLine("0 - Trở về trang quảng lý loại hàng.");
                        int tuyChon = luaChon(2);
                        if (tuyChon == 1)
                        {
                            this.XoaLoaiHangTheoTen();
                        }
                        else if (tuyChon == 2)
                        {
                            this.XoaLoaiHangTheoSTT();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            public bool STTCoPhanTu(int sTT)
            {
                bool kQ = true;
                if (this.LoaiHang[sTT] == null)
                {
                    kQ = false;
                    Console.WriteLine("Loại hàng có số thứ tự {0} đã bị xóa.", sTT);
                }
                return kQ;
            }

            // Xóa loại hàng theo số thứ tự
            public void XoaLoaiHangTheoSTT() 
            {
                while (true)
                {
                    Console.Write("Nhập số thứ tự loại hàng muốn xóa: ");
                    int sTT = nhapSo();
                    if (this.kiemTraSTT(sTT) & this.STTCoPhanTu(sTT))
                    {
                        String noiDung = String.Format("Loại hàng có số thứ tự {0} là {1}, bạn có muốn xóa?", sTT, this.LoaiHang[sTT]);
                        if (luaChonCoKhong(noiDung))
                        {
                            Console.WriteLine("Loại hàng {0} đã được xóa", this.LoaiHang[sTT]);
                            this.LoaiHang[sTT] = null;
                        }
                    }
                    // Lựa chọn tiếp tục hay không
                    if (luaChonCoKhong("Có tiếp tục xóa loại hàng theo số thứ tự không?") == false)
                    {
                        break;
                    }
                }
            }

            // Xóa loại hàng theo tên
            public void XoaLoaiHangTheoTen()
            {
                while (true)
                {
                    Console.Write("Nhập loại hàng muốn xóa: ");
                    string loaiHang = Console.ReadLine();
                    int sTT = this.TimSTTLoaiHang(loaiHang);
                    if (sTT != -1)
                    {
                        if (luaChonCoKhong("Đồng ý xóa?"))
                        {
                            this.LoaiHang[sTT] = null;
                        }
                    }
                    // Lựa chọn tiếp tục hay không
                    if (luaChonCoKhong("Có tiếp tục xóa loại hàng theo tên không?") == false)
                    {
                        break;
                    }
                }
            }

            // Sửa loại hàng
            public void SuaLoaiHang()
            {
                if (this.kiemTraDSTrong() == false)
                {
                    while (true)
                    {
                        Console.WriteLine("TRANG SỬA LOẠI HÀNG");
                        this.ThongTinDanhSach();
                        Console.WriteLine("1 - Sửa loại hàng theo tên.");
                        Console.WriteLine("2 - Sửa loại hàng theo số thứ tự.");
                        Console.WriteLine("0 - Trở về trang quảng lý loại hàng.");
                        int tuyChon = luaChon(2);
                        if (tuyChon == 1)
                        {
                            this.SuaLoaiHangTheoTen();
                        }
                        else if (tuyChon == 2)
                        {
                            this.SuaLoaiHangTheoSTT();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                
            }    

            // Sửa loại hàng theo số thứ tự
            public void SuaLoaiHangTheoSTT()
            {
                while (true)
                {
                    Console.Write("Nhập số thứ tự loại hàng muốn sửa: ");
                    int sTT = nhapSo();
                    if (this.kiemTraSTT(sTT))
                    {
                        if (this.STTCoPhanTu(sTT))
                        {
                            Console.Write("Nhập loại hàng mới thay thế cho loại hàng {0}: ", this.LoaiHang[sTT]);
                            string loaiHangMoi = Console.ReadLine();
                            if (this.KiemTraLoaiHangMoi(loaiHangMoi))
                            {
                                Console.Write("Loại hàng {0} đã được sửa thành: {1}", this.LoaiHang[sTT], loaiHangMoi);
                                this.LoaiHang[sTT] = loaiHangMoi;
                            }
                        }
                        else
                        {
                            if (luaChonCoKhong("Có tiếp tục sửa loại hàng đã xóa trước đây thành tên loại hàng khác?"))
                            {
                                Console.Write("Nhập loại hàng mới thay thế cho loại hàng đã bị xóa trước đây: ");
                                string loaiHangMoi = Console.ReadLine();
                                if (this.KiemTraLoaiHangMoi(loaiHangMoi))
                                {
                                    Console.Write("Loại hàng đã được sửa thành: {0}", loaiHangMoi);
                                    this.LoaiHang[sTT] = loaiHangMoi;
                                }
                            }

                        }
                    }
                    if (luaChonCoKhong("Có tiếp tục sửa loại hàng theo số thứ tự không?") == false)
                    {
                        break;
                    }
                }
            }
            // Sửa loại hàng theo tên
            public void SuaLoaiHangTheoTen()
            {
                while (true)
                {
                    Console.Write("Nhập loại hàng cần chỉnh sửa: ");
                    string loaiHangCu = Console.ReadLine();
                    int sTT = this.TimSTTLoaiHang(loaiHangCu);
                    if (sTT != -1)
                    {
                        while (true)
                        {
                            Console.Write("Loại hàng {0} chỉnh sửa thành: ", loaiHangCu);
                            string loaiHangMoi = Console.ReadLine();
                            if (this.KiemTraLoaiHangMoi(loaiHangMoi))
                            {
                                Console.WriteLine("Loại hàng {0} đã được chỉnh sửa thành: {1}", this.LoaiHang[sTT], loaiHangMoi);
                                this.LoaiHang[sTT] = loaiHangMoi;
                                break;
                            }
                        }
                    }
                    // Lựa chọn tiếp tục hay không
                    if (luaChonCoKhong("Có tiếp tục sửa loại hàng theo tên không?") == false)
                    {
                        break;
                    }
                }
            }
            //
            public void XemLoaiHang()
            {
                if (this.kiemTraDSTrong())
                {
                    Console.WriteLine("Danh sách loại hàng còn trống.");
                }
                else
                {

                    while (true)
                    {
                        Console.WriteLine("TRANG XEM VÀ TÌM KIẾM LOẠI HÀNG");
                        this.ThongTinDanhSach();
                        Console.WriteLine("1 - Tìm kiếm loại hàng.");
                        Console.WriteLine("2 - Xem một loại hàng theo số thứ tự.");
                        Console.WriteLine("3 - Xem một phần loại hàng.");
                        Console.WriteLine("4 - Xem toàn bộ loại hàng.");
                        Console.WriteLine("0 - Trở về trang quảng lý loại hàng.");
                        int tuyChon = luaChon(4);
                        if (tuyChon == 1)
                        {
                            this.TimKiemLoaiHang();
                        }
                        else if (tuyChon == 2)
                        {
                            this.InLoaiHang();
                        }
                        else if (tuyChon == 3)
                        {
                            this.InDSLoaiHang();
                        }
                        else if (tuyChon == 4)
                        {
                            this.InToanBoLoaiHang();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            // Tìm kiếm loại hàng
            public void TimKiemLoaiHang()
            {
                while (true)
                {
                    Console.Write("Nhập loại hàng tìm kiếm: ");
                    string loaiHangTimKiem = Console.ReadLine();
                    string mauHangCuaBang = "|{0,5}|{1,30}|";
                    string tieuDeBang = String.Format(mauHangCuaBang, "STT", "Loại Hàng");
                    Console.WriteLine(tieuDeBang);
                    Console.WriteLine(new string('-', 38));
                    loaiHangTimKiem = loaiHangTimKiem.ToLower();
                    int nCharTimKiem = loaiHangTimKiem.Length;
                    for (int i = 1; i < this.LoaiHang.Length; i++)
                    {
                        string loaiHangDaLuu = this.LoaiHang[i];
                        if (loaiHangDaLuu != null)
                        {
                            loaiHangDaLuu = loaiHangDaLuu.ToLower();
                            int nCharDaLuu = loaiHangDaLuu.Length;
                            int nchar = Math.Min(nCharTimKiem, nCharDaLuu);
                            if (loaiHangTimKiem.Substring(0, nchar) == loaiHangDaLuu.Substring(0, nchar))
                            {
                                string hang = String.Format(mauHangCuaBang, i, this.LoaiHang[i]);
                                Console.WriteLine(hang);
                            }

                        }
                    }
                    Console.WriteLine(new string('-', 38));
                    if (luaChonCoKhong("Có tiếp tục tìm kiếm loại hàng khác không?") == false)
                    {
                        break;
                    }
                }
            }
            // In một loại hàng
            public void InLoaiHang()
            {
                while (true)
                {
                    Console.Write("Nhập số thứ tự loại hàng muốn xem: ");
                    int sTT = nhapSo();
                    if (this.kiemTraSTT(sTT))
                    {
                        this.InDSLoaiHangTheoSTT(sTT, sTT);
                    }
                    if (luaChonCoKhong("Có tiếp tục xem loại hàng khác không?") == false)
                    {
                        break;
                    }
                }
            }

            // In danh sách theo số thứ tự
            private void InDSLoaiHangTheoSTT(int sTTDau, int sTTCuoi)
            {
                string mauHangCuaBang = "|{0,5}|{1,30}|";
                string tieuDeBang = String.Format(mauHangCuaBang, "STT", "Loại Hàng");
                Console.WriteLine(tieuDeBang);
                Console.WriteLine(new string('-', 38));

                for (int i = sTTDau; i <= sTTCuoi; i++)
                {
                    string hang;
                    if (this.LoaiHang[i] != null)
                    {
                        hang = String.Format(mauHangCuaBang, i, this.LoaiHang[i]);
                    }
                    else
                    {
                        hang = String.Format(mauHangCuaBang, i, "Đã bị xóa");
                    }
                    Console.WriteLine(hang);
                    Console.WriteLine(new string('-', 38));
                }
            }

            // In danh sách loại hàng
            public void InDSLoaiHang()
            {
                while (true)
                {
                    Console.Write("Nhập số thứ tự đầu: ");
                    int sTTDau = nhapSo();
                    if (this.kiemTraSTT(sTTDau))
                    {
                        Console.Write("Nhập số thứ tự cuối: ");
                        int sTTCuoi = nhapSo();
                        if (this.kiemTraSTT(sTTCuoi))
                        {
                            int sTTNho = Math.Min(sTTDau, sTTCuoi);
                            int sTTLon = Math.Max(sTTDau, sTTCuoi);
                            this.InDSLoaiHangTheoSTT(sTTNho, sTTLon);
                        }
                    }
                    if (luaChonCoKhong("Có tiếp tục xem danh sách loại hàng không?") == false)
                    {
                        break;
                    }
                }
            }

            // In toàn bộ Loại hàng
            public void InToanBoLoaiHang()
            {
                this.InDSLoaiHangTheoSTT(1, this.LoaiHang.Length - 1);
            }
        }

        struct MATHANG
        {
            public string MaHang;
            public string TenHang;
            public string CTySX;
            public DateTime HanDung;
            public int NamSX;
            public int LoaiHang;
        }

        static public DateTime nhapNgayThangNam(string noiDung)
        {
            string[] dinhDang = { "dd/MM/yyyy", "ddMMyyyy", "dd-MM-yyyy" };
            DateTime ngayThangNam;
            while (true)
            {
                Console.Write(noiDung + " (dd/MM/yyyy): ");
                string chuoiNgayThangNam = Console.ReadLine();
                if (DateTime.TryParseExact(chuoiNgayThangNam, dinhDang, null,
                                        System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                        System.Globalization.DateTimeStyles.AdjustToUniversal,
                                        out ngayThangNam))
                {
                    break;
                }    
                else
                {
                    Console.WriteLine("Nhập sai định dạng ngày tháng năm (dd/MM/yyyy)");
                }    
            }
            return ngayThangNam;
        }

        
        // Nhập mã mặt hàng
        static public string nhapMaMatHang()
        {
            string maLoaiHang;
            while (true)
            {
                Console.Write("Nhập mã mat hàng 5 ký tự: ");
                maLoaiHang = Console.ReadLine();
                if (maLoaiHang.Length == 5)
                {
                    return maLoaiHang;
                }
                else
                {
                    Console.WriteLine("Mã mat hàng phải có đúng 5 ký tự.");
                }
            }

        }
        static public string nhapChuoi(string noiDung)
        {
            string chuoiNhap;
            while (true)
            {
                Console.Write(noiDung + ": ");
                chuoiNhap = Console.ReadLine();
                if (chuoiNhap != "")
                {
                    return chuoiNhap;
                }
                else
                {
                    Console.WriteLine("Không được bỏ trống nội dung nhập.");
                }
            }

        }

        static public int nhapNam(string noiDung)
        {
            int namNhap;
            while (true)
            {
                try
                {
                    Console.Write(noiDung + ": ");
                    namNhap = int.Parse(Console.ReadLine());
                    if ((namNhap > 1900) & (namNhap < 3000))
                    {
                        return namNhap;
                    }
                    else
                    {
                        Console.WriteLine("Năm không nhỏ hơn 1900 và không lớn hơn 3000.  ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhập năm sai.");
                }
            }
        }
        static public int Nhap()
        {
            int soNhap;
            while (true)
            {
                try
                {
                    soNhap = int.Parse(Console.ReadLine());
                    return soNhap;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lựa chọn chức năng sai.");
                }
            }

        }


        struct CUAHANG
        {
            LOAIHANG LoaiHang;
            MATHANG[] DSMatHang;

            public void KhoiTao()
            {
                this.LoaiHang.KhoiTao();
                this.DSMatHang = new MATHANG[1];
                MATHANG matHangKhoiTao = new MATHANG();
                matHangKhoiTao.MaHang = "Mã Mặt Hàng";
                matHangKhoiTao.TenHang = "Tên Mặt Hàng";
                matHangKhoiTao.CTySX = "Công Ty Sản Xuất";
                matHangKhoiTao.HanDung = DateTime.Now;
                matHangKhoiTao.NamSX = DateTime.Now.Year;
                matHangKhoiTao.LoaiHang = 0;
                this.DSMatHang[0] = matHangKhoiTao;
            }

            public void QuanLyCuaHang()
            {
                Console.WriteLine("TRANG QUẢN LÝ CỬA HÀNG");
                Console.WriteLine("1 - Quản lý mặt hàng.");
                Console.WriteLine("2 - Quản lý loại hàng.");
                int tuyChon = luaChon(2);
                if (tuyChon == 1)
                {
                    this.QuanLyMatHang();
                }
                else if (tuyChon == 2)
                {
                    this.LoaiHang.QuanLyLoaiHang();
                }
            }

            // Quản lý loại hàng
            public void QuanLyMatHang()
            {
                while (true)
                {
                    Console.WriteLine("TRANG QUẢN LÝ MẶT HÀNG");
                    Console.WriteLine("1 - Xem và tìm kiếm mặt hàng.");
                    Console.WriteLine("2 - Thêm mặt hàng.");
                    Console.WriteLine("3 - Sửa mặt hàng.");
                    Console.WriteLine("4 - Xóa mặt hàng.");
                    Console.WriteLine("0 - Về trang chính.");
                    int tuyChon = luaChon(4);
                    // Xem mặt hàng
                    if (tuyChon == 1)
                    {
                        this.XemMatHang();
                    }
                    // Thêm mặt hàng
                    else if (tuyChon == 2)
                    {
                        this.ThemMatHang();
                    }
                    // Sửa mặt hàng
                    else if (tuyChon == 3)
                    {
                        this.SuaMatHang();
                    }
                    // Xóa mặt hàng
                    else if (tuyChon == 4)
                    {
                        this.XoaMatHang();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public void XemMatHang()
            {
                if (this.KiemTraDSTrong() == false)
                {
                    while (true)
                    {
                        Console.WriteLine("TRANG XEM, TÌM KIẾM MẶT HÀNG");
                        Console.WriteLine("1 - Xem danh sách mặt hàng.");
                        Console.WriteLine("2 - Tìm kiếm theo mã mặt hàng.");
                        Console.WriteLine("3 - Tìm kiếm theo tên mặt hàng.");
                        Console.WriteLine("4 - Tìm kiếm theo công ty sản xuất.");
                        Console.WriteLine("5 - Tìm kiếm theo năm sản xuất.");
                        Console.WriteLine("6 - Tìm kiếm theo hạn sử dụng.");
                        Console.WriteLine("0 - Về trang chính.");
                        int tuyChon = luaChon(6);
                        if (tuyChon == 1)
                        {
                            this.InDanhSachMatHang();
                        }
                        else if (tuyChon == 2)
                        {
                            this.TimKiemMaMatHang();
                        }
                        else if (tuyChon == 3)
                        {
                            this.TimKiemTenMatHang();
                        }
                        else if (tuyChon == 4)
                        {
                            this.TimKiemCongTySX();
                        }
                        else if (tuyChon == 5)
                        {
                            this.TimKiemNamSX();
                        }
                        else if (tuyChon == 6)
                        {
                            this.TimKiemHSD();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            // In tiêu đề của bảng
            private void InTieuDeBang()
            {
                
                string mauHangCuaBang = "|{0,7}|{1,30}|{2,30}|{3,10}|{4,6}|{5,20}|";
                string tieuDeBang = String.Format(mauHangCuaBang, "Mã MH", "Tên Mặt Hàng", "Cty SX", "HSD", "Năm SX", "Loại Hàng");
                Console.WriteLine(new string('-', 110));
                Console.WriteLine(tieuDeBang);
                Console.WriteLine(new string('-', 110));
            }

            // in hàng cuối cùng của bảng
            private void InCuoiBang()
            {
                Console.WriteLine(new string('-', 110));
            }

            // In một mặt hàng
            private void InMatHang(MATHANG matHang)
            {
                string mauHangCuaBang = "|{0,7}|{1,30}|{2,30}|{3,10}|{4,6}|{5,20}|";
                string matHangIn = String.Format(mauHangCuaBang, matHang.MaHang, matHang.TenHang, matHang.CTySX,
                                                 matHang.HanDung.ToString("dd/MM/yyyy"), matHang.NamSX, this.LoaiHang.LoaiHang[matHang.LoaiHang]);
                Console.WriteLine(matHangIn);
            }

            public void InDanhSachMatHang()
            {
                this.InTieuDeBang();
                for (int i = 1; i < this.DSMatHang.Length; i++)
                {
                    this.InMatHang(this.DSMatHang[i]);
                }
                this.InCuoiBang();
            }
            public void TimKiemMaMatHang()
            {
                while (true)
                {
                    Console.WriteLine("Nhập mã mặt hàng cần tìm kiếm: ");
                    string maMatHang = nhapMaMatHang();
                    Console.WriteLine("Kết quả: ");
                    this.InTieuDeBang();
                    for (int i = 0; i < this.DSMatHang.Length; i++)
                    {
                        if (this.DSMatHang[i].MaHang == maMatHang)
                        {
                            this.InMatHang(this.DSMatHang[i]);
                        }
                    }
                    this.InCuoiBang();

                    if (luaChonCoKhong("Tiếp tục tìm kiếm mặt hàng khác không?") == false)
                    {
                        break;
                    }
                }
                
            }
            public void TimKiemTenMatHang()
            {
                while (true)
                {
                    string tenMatHang = nhapChuoi("Nhập tên mặt hàng cần tìm kiến: ");
                    int chieuDaiTen = tenMatHang.Length;
                    Console.WriteLine("Kết quả: ");
                    this.InTieuDeBang();
                    for (int i = 0; i < this.DSMatHang.Length; i++)
                    {
                        if (this.DSMatHang[i].TenHang.Length >= chieuDaiTen)
                        {
                            if (this.DSMatHang[i].TenHang.ToLower().Substring(0, chieuDaiTen) == tenMatHang.ToLower())
                            {
                                this.InMatHang(this.DSMatHang[i]);
                            }
                        }
                    }
                    this.InCuoiBang();

                    if (luaChonCoKhong("Tiếp tục tìm kiếm mặt hàng khác không?") == false)
                    {
                        break;
                    }
                }
                
            }
            public void TimKiemCongTySX()
            {
                while (true)
                {
                    string tenCty = nhapChuoi("Nhập tên công ty cần tìm kiến: ");
                    int chieuDaiTen = tenCty.Length;
                    Console.WriteLine("Kết quả: ");
                    this.InTieuDeBang();
                    for (int i = 0; i < this.DSMatHang.Length; i++)
                    {
                        if (this.DSMatHang[i].CTySX.Length >= chieuDaiTen)
                        {
                            if (this.DSMatHang[i].CTySX.ToLower().Substring(0, chieuDaiTen) == tenCty.ToLower())
                            {
                                this.InMatHang(this.DSMatHang[i]);
                            }
                        }
                    }
                    this.InCuoiBang();
                    if (luaChonCoKhong("Tiếp tục tìm kiếm mặt hàng khác không?") == false)
                    {
                        break;
                    }
                }
            }
            public void TimKiemNamSX()
            {
                while (true)
                {
                    int namSX = nhapNam("Nhập năm sản xuất tìm kiếm");
                    Console.WriteLine("Kết quả: ");
                    this.InTieuDeBang();
                    for (int i = 0; i < this.DSMatHang.Length; i++)
                    {
                        if (this.DSMatHang[i].NamSX == namSX)
                        {
                            this.InMatHang(this.DSMatHang[i]);
                        }
                    }
                    this.InCuoiBang();
                    if (luaChonCoKhong("Tiếp tục tìm kiếm mặt hàng khác không?") == false)
                    {
                        break;
                    }
                }
            }
            public void TimKiemHSD()
            {
                while (true)
                {
                    DateTime hanSD = nhapNgayThangNam("Nhập hạn sử dụng tìm kiếm");
                    Console.WriteLine("Kết quả: ");
                    this.InTieuDeBang();
                    for (int i = 0; i < this.DSMatHang.Length; i++)
                    {
                        if (this.DSMatHang[i].HanDung == hanSD)
                        {
                            this.InMatHang(this.DSMatHang[i]);
                        }
                    }
                    this.InCuoiBang();
                    if (luaChonCoKhong("Tiếp tục tìm kiếm mặt hàng khác không?") == false)
                    {
                        break;
                    }
                }
            }

            // Kiểm tra mã mặt hàng có còn được sử dụng không
            public int KiemTraMaMatHang(string maMatHang)
            {
                int kq = -1;
                for (int i = 1; i < this.DSMatHang.Length; i++)
                {
                    if (this.DSMatHang[i].MaHang == maMatHang)
                    {
                        kq = i;
                        break;
                    }
                }
                return kq;
            }

            // Nhập mã mặt hàng
            public string NhapMaMatHang()
            {
                string maMatHang;
                while (true)
                {
                    Console.Write("Nhập mã mặt hàng 5 ký tự: ");
                    maMatHang = Console.ReadLine();
                    if (maMatHang.Length == 5)
                    {
                        if (this.DSMatHang.Length > 1)
                        {
                            if (this.KiemTraMaMatHang(maMatHang) == -1)
                            {
                                return maMatHang;
                            }
                            else
                            {
                                Console.WriteLine("Mã mặt hàng đã được sử dụng.");
                            }
                        }
                        else
                        {
                            return maMatHang;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Mã mặt hàng phải có đúng 5 ký tự.");
                    }
                }

            }

            // Nhập loại hàng
            public int NhapLoaiHang()
            {
                if (this.LoaiHang.kiemTraDSTrong())
                {
                    Console.WriteLine("Cần nhập loại hàng trước.");
                    return -1;
                }
                else
                {
                    this.LoaiHang.InToanBoLoaiHang();
                    Console.WriteLine("Nhập số thứ thự của loại hàng: ");
                    int maLoaiHang = luaChon(this.LoaiHang.LoaiHang.Length - 1);
                    if (maLoaiHang != 0)
                    {
                        if (this.LoaiHang.LoaiHang[maLoaiHang] != null)
                        {
                            return maLoaiHang;
                        }
                        else
                        {
                            Console.WriteLine("Không được chọn loại hàng đã bị xóa.");
                            return -1;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Chọn mã loại hàng sai.");
                        return -1;
                    }
                }
            }

            public void ThemMatHang()
            {
                while (true)
                {
                    this.KiemTraDSTrong();
                    int sLMatHangMoi = this.DSMatHang.Length + 1;
                    MATHANG[] DSMatHangMoi = new MATHANG[sLMatHangMoi];
                    for (int i = 0; i < sLMatHangMoi - 1; i++)
                    {
                        DSMatHangMoi[i] = this.DSMatHang[i];
                    }
                    MATHANG matHangMoi = new MATHANG();
                    matHangMoi.MaHang = this.NhapMaMatHang();
                    matHangMoi.TenHang = nhapChuoi("Nhập tên mặt hàng: ");
                    matHangMoi.CTySX = nhapChuoi("Công ty sản xuất: ");
                    matHangMoi.LoaiHang = this.NhapLoaiHang();
                    if (matHangMoi.LoaiHang != -1)
                    {
                        matHangMoi.HanDung = nhapNgayThangNam("Nhập hạn sử dụng");
                        matHangMoi.NamSX = nhapNam("Nhập năm sản xuất");
                        DSMatHangMoi[sLMatHangMoi - 1] = matHangMoi;
                        this.DSMatHang = DSMatHangMoi;
                        Console.WriteLine("Thêm mặt hàng thành công.");
                        if (luaChonCoKhong("Tiếp tục thêm mặt hàng khác không?") == false)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            public void SuaMatHang()
            {
                if (this.KiemTraDSTrong() == false)
                {
                    while (true)
                    {
                        string maMatHang = nhapMaMatHang();
                        int sTTMatHang = this.KiemTraMaMatHang(maMatHang);
                        if (sTTMatHang != -1)
                        {
                            this.InTieuDeBang();
                            this.InMatHang(this.DSMatHang[sTTMatHang]);
                            this.InCuoiBang();
                            Console.WriteLine("1 - Sửa mã mặt hàng.");
                            Console.WriteLine("2 - Sửa tên mặt hàng.");
                            Console.WriteLine("3 - Sửa công ty.");
                            Console.WriteLine("4 - Sửa hạn dùng.");
                            Console.WriteLine("5 - Sửa năm sản suất.");
                            Console.WriteLine("0 - Hủy.");
                            int tuyChon = luaChon(5);
                            if (tuyChon == 1)
                            {
                                Console.WriteLine("Nhập mã mặt hàng mới");
                                this.DSMatHang[sTTMatHang].MaHang = this.NhapMaMatHang();
                            }
                            else if (tuyChon == 2)
                            {
                                this.DSMatHang[sTTMatHang].TenHang = nhapChuoi("Nhập tên mặt hàng mới");
                            }
                            else if (tuyChon == 3)
                            {
                                this.DSMatHang[sTTMatHang].CTySX = nhapChuoi("Nhập tên công ty mới");
                            }
                            else if (tuyChon == 4)
                            {
                                this.DSMatHang[sTTMatHang].HanDung = nhapNgayThangNam("Nhập hạn sử dụng mới");
                            }
                            else if (tuyChon == 5)
                            {
                                this.DSMatHang[sTTMatHang].NamSX = nhapNam("Nhập năm sản xuất mới");
                            }
                            Console.WriteLine("Sửa thành công.");
                            this.InTieuDeBang();
                            this.InMatHang(this.DSMatHang[sTTMatHang]);
                            this.InCuoiBang();
                        }
                        else
                        {
                            Console.WriteLine("Mặt hàng không tồn tại.");
                        }
                        if (luaChonCoKhong("Tiếp tục sửa mặt hàng khác không?") == false)
                        {
                            break;
                        }
                    }
                    
                }
            }

            public void XoaMatHang()
            {
                if (this.KiemTraDSTrong() == false)
                {
                    while (true)
                    {
                        Console.WriteLine("Nhập mã mặt hàng muốn xóa.");
                        string maMatHang = nhapMaMatHang();
                        int sTTMatHang = this.KiemTraMaMatHang(maMatHang);
                        if (sTTMatHang != -1)
                        {
                            this.InTieuDeBang();
                            this.InMatHang(this.DSMatHang[sTTMatHang]);
                            this.InCuoiBang();
                            if (luaChonCoKhong("Xác nhận xóa mặt hàng này?"))
                            {
                                MATHANG[] DSMatHangMoi = new MATHANG[this.DSMatHang.Length - 1];
                                for (int i = 0; i < this.DSMatHang.Length; i++)
                                {
                                    if (i < sTTMatHang)
                                    {
                                        DSMatHangMoi[i] = this.DSMatHang[i];
                                    }
                                    else
                                    {
                                        DSMatHangMoi[i] = this.DSMatHang[i + 1];
                                    }
                                }
                                this.DSMatHang = DSMatHangMoi;
                                Console.WriteLine("Xóa thành công mặt hàng có mã {0}.", maMatHang);
                            }
                            else
                            {
                                Console.WriteLine("Hủy không xóa.");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Mặt hàng không tồn tại mặt hàng mã {0}.", maMatHang);
                        }
                        if (luaChonCoKhong("Tiếp tục xóa mặt hàng khác không?") == false)
                        {
                            break;
                        }
                    }
                }
            }
            // Kiểm tra danh sách mặt hàng trống hay không.
            public bool KiemTraDSTrong()
            {
                if (this.DSMatHang.Length <= 1)
                {
                    Console.WriteLine("Danh sách mặt hàng hiện đang trống");
                    return true;
                }
                else
                {
                    Console.WriteLine("Hiện có {0} trong danh sách loại hàng", this.DSMatHang.Length - 1);
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CUAHANG cuaHang = new CUAHANG();
            cuaHang.KhoiTao();
            while (true)
            {
                cuaHang.QuanLyCuaHang();
            }

        }

    }
}