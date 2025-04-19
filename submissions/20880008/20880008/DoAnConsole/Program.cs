using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnConsole
{
    class Program
    {
        public static string starLine = "******************";
        public static List<LoaiHang> LoaiHangList = new List<LoaiHang> { new LoaiHang { MaLH = "lh1", LH = "dien thoai" },
            new LoaiHang { MaLH = "lh2", LH = "dong ho" }};
        public static List<HangHoa> HangHoaList = new List<HangHoa>() { new HangHoa { Mahh = "hh1", Tenhh = "iphone", LH = LoaiHangList[0], NSX = DateTime.Now }, 
            new HangHoa { Mahh = "hh2", Tenhh = "intel core i7" } };
        
        public static string kCLon = "{0,-30}";
        public static string kCVua = "{0,-15}";
        public static string kCNho = "{0,-10}";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu();
        }
        public static HangHoa NhapDuLieuHangHoa()
        {
            HangHoa hh = new HangHoa();
            while (true)
            {
                Console.WriteLine("Nhập mã hàng hóa: ");
                string maHH = Console.ReadLine();
                bool duplicateCheck = false;
                foreach (var item in HangHoaList)
                {
                    if (maHH == item.Mahh)
                    {
                        duplicateCheck = true;
                        break;
                    }
                }
                if (!duplicateCheck)
                {
                    hh.Mahh = maHH;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Mã HH bị trùng! Enter để nhập lại");
                Console.ReadLine();
            }
            Console.WriteLine("Nhập tên hàng hóa: ");
            hh.Tenhh = Console.ReadLine();
            Console.WriteLine("Nhập tên công ty: ");
            hh.Cty = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Bạn có muốn tìm loại hàng ko(Y/N): ");
                var request = Console.ReadLine();
                if (request == "Y" || request == "y")
                {
                    TimMenu(1, 1);
                }
                Console.WriteLine("Nhập mã loại hàng");
                string maLH = Console.ReadLine();
                int index = -1;
                for (int i = 0; i < LoaiHangList.Count; i++)
                {
                    if (maLH == LoaiHangList[i].MaLH)
                    {
                        index = i;
                    }
                }
                if (index ==-1)
                {
                    Console.WriteLine($"Mã loại hàng {maLH} ko tồn tại");
                    Console.Write("Bạn có muốn tiếp tục nhập loại hàng ko(Y/N): ");
                    var input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    hh.LH = null ;
                    break;
                }
                hh.LH = LoaiHangList[index];
                break;
            }
            hh.NSX = NhapNgay("Nhập ngày sản xuất (để trống nếu ko muốn nhập): ");
            hh.HSD = NhapNgay("Nhập hạn sử dụng (để trống nếu ko muốn nhập): ");
            return hh;
        }
        public static DateTime? NhapNgay(string s)
        {
            bool isDone = false;
            DateTime? r = default ;
            while (!isDone)
            {
                Console.WriteLine(s);
                var str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str))
                {
                    break;
                }
                DateTime d;
                isDone = DateTime.TryParse(str, out d);
                r = d;
            }
            return r;
        }
        public static LoaiHang NhapDuLieuLoaiHang()
        {
            LoaiHang lh = new LoaiHang();
            while (true)
            {
                Console.WriteLine("Nhập mã hàng hóa: ");
                lh.MaLH = Console.ReadLine();
                bool duplicateCheck = false;
                foreach (var item in LoaiHangList)
                {
                    if (lh.MaLH == item.MaLH)
                    {
                        duplicateCheck = true;
                        break;
                    }
                }
                if (!duplicateCheck)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Mã LH bị trùng");
            }

            Console.WriteLine("Nhập loại hàng: ");
            lh.LH = Console.ReadLine();
            return lh;
        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Hãy lựa chọn: ");
                Console.WriteLine(" 1.  Xem danh sách hàng hóa");
                Console.WriteLine(" 2.  Thêm hàng hóa");
                Console.WriteLine(" 3.  Sửa hàng hóa");
                Console.WriteLine(" 4.  Tìm hàng hóa");
                Console.WriteLine(" 5.  Xóa hàng hóa");
                Console.WriteLine(" 6.  Xem danh sách loại hàng");
                Console.WriteLine(" 7.  Thêm loại hàng");
                Console.WriteLine(" 8.  Sửa loại hàng");
                Console.WriteLine(" 9.  Tìm loại hàng");
                Console.WriteLine(" 10. Xóa loại hàng");
                Console.WriteLine(" 11. Thoát");
                Console.WriteLine(starLine);
                Console.Write("Lựa chọn :");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        XemMenu();
                        break;
                    case "2":
                        Console.Clear();
                        ThemMenu();
                        break;
                    case "3":
                        Console.Clear();
                        SuaMenu();
                        break;
                    case "4":
                        Console.Clear();
                        TimMenu();
                        break;
                    case "5":
                        Console.Clear();
                        XoaMenu();
                        break;
                    case "6":
                        Console.Clear();
                        XemMenu(1);
                        break;
                    case "7":
                        Console.Clear();
                        ThemMenu(1);
                        break;
                    case "8":
                        Console.Clear();
                        SuaMenu(1);
                        break;
                    case "9":
                        Console.Clear();
                        TimMenu(1);
                        break;
                    case "10":
                        Console.Clear();
                        XoaMenu(1);
                        break;
                    default:
                        break;
                }
                if (input == "11")
                {
                    break;
                }
                Console.Clear();
            }

        }
        public static void XemMenu(int maBang =0)
        {
            if (maBang  ==0)
            {
                if (HangHoaList.Count < 1)
                {
                    Console.WriteLine("Không có dữ liệu! ");
                }
                else
                    XuatBangDuLieu(HangHoaList);
            }
            if (maBang == 1)
            {
                if (LoaiHangList.Count < 1)
                {
                    Console.WriteLine("Không có dữ liệu! ");
                }
                else 
                    XuatBangDuLieu(LoaiHangList);
            }
            Console.WriteLine("Enter để quay lại");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ThemMenu(int maBang = 0)
        {
            while (true)
            {
                HangHoa hh = null;
                LoaiHang lh = null;
                if (maBang == 0)
                {
                    hh = NhapDuLieuHangHoa();
                    Console.WriteLine("Bạn vừa nhập hàng hóa: ");
                    XuatBangDuLieu(hh);
                }
                if (maBang == 1)
                {
                    lh = NhapDuLieuLoaiHang();
                    Console.WriteLine("Bạn vừa nhập loại hàng: ");
                    XuatBangDuLieu(lh);
                }
                Console.Write("Bạn có muốn thêm dữ liệu trên vào hệ thống (Y/N):");
                string input = Console.ReadLine();
                if (input == "Y" || input == "y")
                {
                    if (hh != null) ThemDuLieu(hh);
                    if (lh != null) ThemDuLieu(lh);
                }
                Console.Clear();
                Console.Write("Bạn có muốn tiếp tục nhập dữ liệu  (Y/N):");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "Y" || input == "y")
                {
                    continue;
                }
                break;
            }
        }
        public static void SuaMenu(int maBang=0)
        {
            if (maBang==0)
            {
                while (true)
                {
                    Console.Write("Mời nhập mã hàng hóa muốn sửa:");
                    string maHH = Console.ReadLine();
                    HangHoa hh = new HangHoa();
                    int hhUpdateIndex = -1;
                    for (int i = 0; i < HangHoaList.Count; i++)
                    {
                        if (HangHoaList[i].Mahh == maHH)
                        {
                            hhUpdateIndex = i;
                            hh = HangHoaList[i];
                            break;
                        }
                    }
                    if (hh.Mahh == null)
                    {
                        Console.WriteLine("Mã hàng hóa ko tồn tại!");
                        Console.Write("Bạn có muốn tiếp tục sửa hàng hóa không(Y/N): ");
                        var input = Console.ReadLine();
                        if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        SuaHangHoaSubMenu(hh, hhUpdateIndex);
                        Console.Write("Bạn có muốn tiếp tục sửa hàng hóa không(Y/N): ");
                        var input = Console.ReadLine();
                        if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                }
               
            }
            if (maBang == 1)
            {
                while (true)
                {
                    Console.Write("Mời nhập mã loại hàng muốn sửa:");
                    string maLH = Console.ReadLine();
                    LoaiHang lh = new LoaiHang();
                    int hhUpdateIndex = -1;
                    for (int i = 0; i < LoaiHangList.Count; i++)
                    {
                        if (LoaiHangList[i].MaLH == maLH)
                        {
                            hhUpdateIndex = i;
                            lh = LoaiHangList[i];
                            break;
                        }
                    }
                    if (lh.MaLH == null)
                    {
                        Console.WriteLine("Mã loại hàng ko tồn tại!");
                    }
                    else
                    {
                        SuaLoaiHangSubMenu(lh);
                        Console.Write("Bạn có muốn tiếp tục sửa loại hàng không(Y/N): ");
                        var input = Console.ReadLine();
                        if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        public static void TimMenu(int maBang = 0, int submenu = 0)
        {
            if (maBang ==0)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Mời bạn nhập tên hàng hóa cần tìm: ");
                    string tenHH = Console.ReadLine();
                    var hhs = TimHangHoa(tenHH);
                    if (hhs.Count <= 0)
                    {
                        Console.WriteLine("Không tìm thấy dữ liệu về tên hàng hóa có chứa : " + tenHH);
                        Console.Write("Bạn có muốn tìm kiếm tiếp không? (Y/N): ");
                        var input = Console.ReadLine();
                        if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Danh sách hàng hóa tìm được: ");
                        XuatBangDuLieu(hhs);
                        if (submenu==0)
                        {
                            Console.WriteLine("1. Sửa hàng hóa");
                            Console.WriteLine("2. Xóa hàng hóa");
                            Console.WriteLine("3. Tìm hàng hóa khác");
                            Console.WriteLine("Enter để quay lại");
                            Console.WriteLine(starLine);
                            Console.Write("Lựa chọn: ");
                            var input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.Clear();
                                SuaMenu();
                            }
                            if (input == "2")
                            {
                                Console.Clear();
                                XoaMenu();
                            }
                            if (input == "3")
                            {
                                continue;
                            }
                            Console.Clear();
                        }
                        break;
                    }
                }
            }
            if (maBang ==1)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Mời bạn nhập loại hàng cần tìm: ");
                    string tenLH = Console.ReadLine();
                    var lhs = TimLoaiHang(tenLH);
                    if (lhs.Count <= 0)
                    {
                        Console.WriteLine("Không tìm thấy dữ liệu về loại hàng có chứa: " + tenLH);
                        Console.Write("Bạn có muốn tìm kiếm tiếp không? (Y/N): ");
                        var input = Console.ReadLine();
                        if (input == "Y" || input == "y")
                        {
                            Console.Clear();
                            continue;
                        }
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Danh sách loại hàng tìm được: ");
                        XuatBangDuLieu(lhs);
                        if (submenu==0)
                        {
                            Console.WriteLine("1. Sửa loại hàng");
                            Console.WriteLine("2. Xóa loại hàng");
                            Console.WriteLine("3. Tìm loại hàng khác");
                            Console.WriteLine("Bấm enter để quay lại");
                            Console.WriteLine(starLine);
                            Console.Write("Lựa chọn: ");
                            var input = Console.ReadLine();
                            if (input == "1")
                            {
                                SuaMenu(1);
                            }
                            if (input == "2")
                            {
                                XoaMenu(1);
                            }
                            if (input == "3")
                            {
                                continue;
                            }
                            Console.Clear();
                        }
                        
                        if (submenu == 1)
                        {
                            Console.Write("Bạn có muốn tìm loại hàng khác ko(Y/N): ");
                            var input = Console.ReadLine();
                            if (input == "Y" || input == "y")
                            {
                                Console.Clear();
                                continue;
                            }
                            break;
                        }
                        break;
                    }
                }
            }
        }
        public static void XoaMenu(int maBang =0)
        {
            if (maBang ==0)
            {
                while (true)
                {
                    if (HangHoaList.Count <= 0)
                    {
                        Console.WriteLine("Ko có dữ liệu về hàng hóa! Enter để quay lại");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    Console.Write("Nhập mã hàng hóa muốn xóa:");
                    string maHH = Console.ReadLine();
                    HangHoa hh = new HangHoa();
                    for (int i = 0; i < HangHoaList.Count; i++)
                    {
                        if (HangHoaList[i].Mahh == maHH)
                        {
                            hh = HangHoaList[i];
                        }
                    }
                    if (hh.Mahh == null)
                    {
                        Console.WriteLine("Mã hàng hóa ko tồn tại!");
                    }
                    else
                    {
                        Console.WriteLine("Hàng hóa cần xóa là: ");
                        XuatBangDuLieu(hh);
                        Console.Write("Bấm Y để xóa (Y/N):");
                        string inputXoa = Console.ReadLine();
                        if (inputXoa == "Y" || inputXoa == "y")
                        {
                            XoaHangHoa(hh);
                            Console.WriteLine("Đã xóa thành công hàng hóa có mã là: " + hh.Mahh);
                        }
                    }
                    Console.Write("Bạn có muốn xóa hàng hóa khác ko (Y/N): ");
                    var input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    break;
                }
            }
            if (maBang == 1)
            {
                while (true)
                {
                    if (LoaiHangList.Count <= 0)
                    {
                        Console.WriteLine("Ko có dữ liệu về loại hàng! Enter để quay lại");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    Console.Write("Nhập mã loại hàng muốn xóa:");
                    string maLH = Console.ReadLine();
                    LoaiHang lh = new LoaiHang();
                    for (int i = 0; i < LoaiHangList.Count; i++)
                    {
                        if (LoaiHangList[i].MaLH == maLH)
                        {
                            lh = LoaiHangList[i];
                        }
                    }
                    if (lh.MaLH == null)
                    {
                        Console.WriteLine("Mã loại hàng ko tồn tại!");
                    }
                    else
                    {
                        var lhCheck = new Dictionary<string, bool>();
                        foreach (var item in HangHoaList)
                        {
                            if (item.LH == null)
                            {
                                continue;
                            }
                            if (!lhCheck.ContainsKey(item.LH.MaLH))
                            {
                                lhCheck[item.LH.MaLH] = true;
                            }
                        }
                        if (lhCheck.ContainsKey(lh.MaLH) && lhCheck[lh.MaLH])
                        {
                            Console.WriteLine("Không thể xóa loại hàng này do có hàng hóa đang tham chiếu đến.");
                        }
                        else
                        {
                            Console.WriteLine("Hàng hóa cần xóa là: ");
                            XuatBangDuLieu(lh);
                            Console.Write("Bấm Y để xóa (Y/N):");
                            string inputXoa = Console.ReadLine();
                            if (inputXoa == "Y" || inputXoa == "y")
                            {
                                XoaLoaiHang(lh);
                                Console.WriteLine("Đã xóa thành công hàng hóa có mã là: " + lh.MaLH);
                            }
                        }
                    }
                    Console.Write("Bạn có muốn xóa loại hàng khác ko (Y/N): ");
                    var input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    break;
                }
            }
        }
        public static List<HangHoa> TimHangHoa(string tenHH)
        {
            var hhs = new List<HangHoa>();
            for (int i = 0; i < HangHoaList.Count; i++)
            {
                if (HangHoaList[i].Tenhh.ToLower().Contains(tenHH.ToLower()))
                {
                    hhs.Add(HangHoaList[i]);
                }
            }
            return hhs;
        }
        public static List<LoaiHang> TimLoaiHang(string tenLH)
        {
            var lhs = new List<LoaiHang>();
            for (int i = 0; i < LoaiHangList.Count; i++)
            {
                if (LoaiHangList[i].LH.ToLower().Contains(tenLH.ToLower()))
                {
                    lhs.Add(LoaiHangList[i]);
                }
            }
            return lhs;
        }
        public static void ThemDuLieu(HangHoa hh)
        {
            HangHoaList.Add(hh);
        }
        public static void ThemDuLieu(LoaiHang lh)
        {
            LoaiHangList.Add(lh);
        }
        public static void SuaHangHoaSubMenu(HangHoa hh, int hhUpdateIndex)
        {
            int[] tenCot = new int[] { 0, 1, 2, 3, 4, 5 };
            List<int> indexList = new List<int>();
            HangHoa newHH = hh;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hàng hóa muốn sửa là:");
                Console.WriteLine(NhanChuoiTieuDe());
                Console.WriteLine(NhanChuoiDuLieu(hh));
                Console.WriteLine("Mời nhập các index của cột muốn sửa(index của cột đầu tiên là 0 và cuối cùng là 5, các index cách nhau bằng dấu \"-\" \n VD: để sửa cột 0,1 và 3 hãy nhập: 0-1-3): ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    input = input.Trim();
                    bool check = CheckIndexString(input);
                    if (!check)
                    {
                        Console.Write("Chuỗi index không hợp lệ!. Bạn có muốn nhập chuỗi index mới không(Y/N): ");
                        var request = Console.ReadLine();
                        if (request == "Y" || request == "y")
                        {
                            continue;
                        }
                        break;
                    }
                    var indexs = input.Split('-');

                    NhapHangHoaSua(newHH, indexs);
                    Console.Clear();
                    Console.WriteLine("Hàng hóa sau khi sửa sẽ là:");
                    Console.WriteLine(NhanChuoiTieuDe());
                    Console.WriteLine(NhanChuoiDuLieu(newHH));
                    Console.Write("Bạn có muốn update hàng hóa trên không(Y/N): ");
                    var inputUpdate = Console.ReadLine();
                    if (inputUpdate == "Y" || inputUpdate == "y")
                    {
                        SuaHangHoa(hhUpdateIndex, newHH, indexs);
                        Console.WriteLine("Đã sửa xong!");
                        break;
                    }
                    break;
                }
            }

        }
        public static void SuaHangHoa(int hhUpdateIndex, HangHoa newHH, string[] indexs)
        {
            HangHoa hh = HangHoaList[hhUpdateIndex];
            foreach (var index in indexs)
            {
                switch (index)
                {
                    case "0":
                        hh.Mahh = newHH.Mahh;
                        break;
                    case "1":
                        hh.Tenhh = newHH.Tenhh;
                        break;
                    case "2":
                        hh.Cty = newHH.Cty;
                        break;
                    case "3":
                        hh.LH = newHH.LH;
                        break;
                    case "4":
                        hh.NSX = newHH.NSX;
                        break;
                    case "5":
                        hh.HSD = newHH.HSD;
                        break;
                    default:
                        break;
                }
            }
            HangHoaList[hhUpdateIndex] = hh;
        }
        public static void NhapHangHoaSua(HangHoa hh, string[] indexs)
        {
            foreach (var index in indexs)
            {
                switch (index)
                {
                    case "0":
                        while (true)
                        {
                            Console.WriteLine("Nhập mã hàng hóa: ");
                            string maHH = Console.ReadLine();
                            bool duplicateCheck = false;
                            foreach (var item in HangHoaList)
                            {
                                if (maHH == item.Mahh && maHH != hh.Mahh)
                                {
                                    duplicateCheck = true;
                                    break;
                                }
                            }
                            if (!duplicateCheck)
                            {
                                hh.Mahh = maHH;
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Mã HH bị trùng! Enter để nhập lại");
                            Console.ReadLine();
                        }
                        break;
                    case "1":
                        Console.WriteLine("Nhập tên hàng hóa:");
                        hh.Tenhh = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Nhập tên công ty:");
                        hh.Cty = Console.ReadLine();
                        break;
                    case "3":
                        while (true)
                        {
                            Console.WriteLine("Bạn có muốn tìm loại hàng ko(Y/N): ");
                            var request = Console.ReadLine();
                            if (request == "Y" || request == "y")
                            {
                                TimMenu(1, 1);
                            }
                            Console.WriteLine("Nhập mã loại hàng");
                            string maLH = Console.ReadLine();
                            int lhIndex = -1;
                            for (int i = 0; i < LoaiHangList.Count; i++)
                            {
                                if (maLH == LoaiHangList[i].MaLH)
                                {
                                    lhIndex = i;
                                }
                            }
                            if (lhIndex == -1)
                            {
                                Console.WriteLine($"Mã loại hàng {maLH} ko tồn tại");
                                Console.Write("Bạn có muốn tiếp tục nhập loại hàng ko(Y/N): ");
                                var input = Console.ReadLine();
                                if (input == "Y" || input == "y")
                                {
                                    Console.Clear();
                                    continue;
                                }
                                hh.LH = null;
                                break;
                            }
                            hh.LH = LoaiHangList[lhIndex];
                            break;
                        }
                        break;
                    case "4":
                        bool isDoneNSX = false;
                        while (!isDoneNSX)
                        {
                            Console.WriteLine("Nhập ngày sản xuất:");
                            var str= Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(str))
                            {
                                break;
                            }
                            DateTime nsx ;
                            isDoneNSX = DateTime.TryParse(str, out nsx);
                            hh.NSX= nsx;
                        }
                        break;
                    case "5":
                        bool isDoneHSD = false;
                        while (!isDoneHSD)
                        {
                            Console.WriteLine("Nhập hạn sử dụng:");
                            var str = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(str))
                            {
                                break;
                            }
                            DateTime d;
                            isDoneHSD = DateTime.TryParse(str, out d);
                            hh.HSD = d;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public static void SuaLoaiHangSubMenu(LoaiHang lh)
        {
            LoaiHang newLH =null;
            var lhCheck = new Dictionary<string, bool>();
            foreach (var item in HangHoaList)
            {
                if (item.LH ==null)
                {
                    continue;
                }
                if (!lhCheck.ContainsKey(item.LH.MaLH))
                {
                    lhCheck[item.LH.MaLH] = true;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Loại hàng muốn sửa là:");
                XuatBangDuLieu(lh);
                if (lhCheck.ContainsKey(lh.MaLH)&& lhCheck[lh.MaLH])
                {
                    Console.WriteLine($"Do đang có hàng hóa đang tham chiếu đến mã loại hàng {lh.MaLH} nên chỉ có thể sửa tên loại hàng.");
                }
                else
                {
                    Console.Write("Bạn có muốn sửa mã loại hàng ko (Y/N) :");
                    var request2 = Console.ReadLine();
                    if (request2 == "Y" || request2 == "y")
                    {
                        if (newLH ==null)
                        {
                            newLH = new LoaiHang();
                        }
                        Console.WriteLine("Mời nhập mã loại hàng");
                        newLH.MaLH = Console.ReadLine();
                    } 
                }

                Console.Write("Bạn có muốn sửa tên loại hàng ko (Y/N) :");
                var request1 = Console.ReadLine();
                if (request1 == "Y" || request1 == "y")
                {
                    if (newLH ==null)
                    {
                        newLH = new LoaiHang();
                        newLH.MaLH = lh.MaLH;
                    }
                    Console.WriteLine("Mời nhập tên loại hàng");
                    newLH.LH = Console.ReadLine();
                }

                Console.Clear();
                if (newLH !=null)
                {
                    Console.WriteLine("Loại hàng sau khi sửa sẽ là:");
                    XuatBangDuLieu(newLH);
                    Console.Write("Bạn có muốn update loại hàng trên không(Y/N): ");
                    var inputUpdate = Console.ReadLine();
                    if (inputUpdate == "Y" || inputUpdate == "y")
                    {
                        lh.MaLH = newLH.MaLH;
                        lh.LH = newLH.LH;
                        Console.WriteLine("Đã sửa xong!");
                        break;
                    }
                }
                break;
            }
        }
        public static void XoaHangHoa(HangHoa hh)
        {
            HangHoaList.Remove(hh);
        }
        public static void XoaLoaiHang(LoaiHang lh)
        {
            LoaiHangList.Remove(lh);
        }
        public static bool CheckIndexString(string input)
        {
            var s = input.Replace("-", "");
            if (s.Length > 1)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (i == j)
                        {
                            return false;
                        }
                    }
                }
            }
            foreach (var c in s)
            {
                if (c < '0' || c > '5')
                    return false;
            }
            return true;
        }
        public static string NhanChuoiTieuDe(int maBang = 0)
        {
            StringBuilder tieuDe = new StringBuilder();
            if (maBang == 0)
            {
                tieuDe.Append(string.Format(kCNho, "Mã HH (0)"));
                tieuDe.Append(string.Format(kCLon, "Tên Hàng (1)"));
                tieuDe.Append(string.Format(kCVua, "Tên Cty (2)"));
                tieuDe.Append(string.Format(kCVua, "Loại HH (3)"));
                tieuDe.Append(string.Format(kCVua, " Ngày SX (4)"));
                tieuDe.Append(string.Format(kCVua, "Hạn SD (5)"));
            }
            if (maBang == 1)
            {
                tieuDe.Append(string.Format(kCNho, "Mã LH"));
                tieuDe.Append(string.Format(kCLon, "Tên Loại Hàng"));
            }

            return tieuDe.ToString();

        }
        public static string NhanChuoiDuLieu(HangHoa hh)
        {
            StringBuilder duLieu = new StringBuilder();
            duLieu.Append(string.Format(kCNho, hh.Mahh));
            duLieu.Append(string.Format(kCLon, hh.Tenhh));
            duLieu.Append(string.Format(kCVua, hh.Cty));
            duLieu.Append(string.Format(kCVua, hh.LH==null ? string.Empty: hh.LH.LH));
            if (hh.NSX !=null)
            {
                duLieu.Append(string.Format(kCVua, ((DateTime)hh.NSX).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            else
            {
                duLieu.Append(string.Format(kCVua, string.Empty));
            }
            if (hh.HSD != null)
            {
                duLieu.Append(string.Format(kCVua, ((DateTime)hh.HSD).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            else
            {
                duLieu.Append(string.Format(kCVua, string.Empty));
            }
            return duLieu.ToString();
        }
        public static string NhanChuoiDuLieu(LoaiHang lh)
        {
            StringBuilder duLieu = new StringBuilder();
            duLieu.Append(string.Format(kCNho, lh.MaLH));
            duLieu.Append(string.Format(kCLon, lh.LH));
            return duLieu.ToString();
        }
        public static string NhanChuoiDuLieu(List<LoaiHang> lhs)
        {
            var strBuilder = new StringBuilder();
            foreach (var item in lhs)
            {
                strBuilder.Append(NhanChuoiDuLieu(item));
                strBuilder.Append("\n");
            }
            return strBuilder.ToString();
        }
        public static string NhanChuoiDuLieu(List<HangHoa> hhs)
        {
            var strBuilder = new StringBuilder();
            foreach (var item in hhs)
            {
                strBuilder.Append(NhanChuoiDuLieu(item));
                strBuilder.Append("\n");
            }
            return strBuilder.ToString();
        }
        public static void XuatBangDuLieu(LoaiHang lh)
        {
            Console.WriteLine(NhanChuoiTieuDe(1));
            Console.WriteLine(NhanChuoiDuLieu(lh));
        }
        public static void XuatBangDuLieu(List<LoaiHang> lhs)
        {
            Console.WriteLine(NhanChuoiTieuDe(1));
            Console.WriteLine(NhanChuoiDuLieu(lhs));
        }
        public static void XuatBangDuLieu(HangHoa hh)
        {
            Console.WriteLine(NhanChuoiTieuDe());
            Console.WriteLine(NhanChuoiDuLieu(hh));
        }
        public static void XuatBangDuLieu(List<HangHoa> hhs)
        {
            Console.WriteLine(NhanChuoiTieuDe());
            Console.WriteLine(NhanChuoiDuLieu(hhs));
        }
    }
    public class HangHoa
    {
        public string Mahh;
        public string Tenhh;
        public string Cty;
        public LoaiHang LH;
        public DateTime? NSX;
        public DateTime? HSD;
    }
    public class LoaiHang
    {
        public string MaLH;
        public string LH;
    }
}
