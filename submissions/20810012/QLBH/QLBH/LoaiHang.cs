using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    public class LoaiHang
    {
        private Dictionary<string, MatHang> dsMH =
           new Dictionary<string, MatHang>();
        public string TenLoaiHang { get; set; }
        public string MaLoaiHang { get; set; }
        public void ThemMatHang(MatHang mh)
        {
            if (this.dsMH.ContainsKey(mh.MaHang) == false)
            {
                this.dsMH.Add(mh.MaHang, mh);
                mh.Nhom = this;
            }
        }
        public Dictionary<string, MatHang> MatHangs
        {
            get { return this.dsMH; }
            set { this.dsMH = value; }
        }
        public override string ToString()
        {
            return this.TenLoaiHang;
        }
    }
}
