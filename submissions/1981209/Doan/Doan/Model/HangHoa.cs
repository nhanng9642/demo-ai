using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Model
{
    class HangHoa
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public DateTime HanDung { get; set; }
        public DateTime NamSanXuat { get; set; }
        public LoaiHangHoa LoaiHangHoa { get; set; }
        public string NhaSanXuat { get; set; }
    }
}
